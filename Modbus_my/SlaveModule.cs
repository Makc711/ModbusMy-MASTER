using System;
using System.IO.Ports;
using System.Timers;
using System.Threading;

namespace Modbus_my
{
    internal class SlaveModule
    {
        private const byte SlaveAddress = 0x01;
        private const int RxDataSize = 6;
        private const int TimeOutRx = 25;
        private const int DelayToAnswer = TimeOutRx + 10;

        private readonly Form1 _form;
        private readonly SerialPort _serialPort;
        private readonly System.Timers.Timer _oneMsTimer;
        private readonly Thread _threadReceivedDataProcessing;
        private readonly Thread _threadExchangeDataWithSlave;
        private UartCommand _lastCommand = UartCommand.SendData;
        private UartCommand _currentCommand = UartCommand.SendData;
        private bool _isPollEnable;
        private int _pollingPeriod;
        private uint _cycleCount;
        private uint _errorCount;
        private CommunicationStatus _communicationStatus = CommunicationStatus.Start;
        private CommunicationError _communicationError = CommunicationError.None;
        private byte _timeOutRxCount;
        private byte _dataToSlave;
        private RxData _rxData;

        private struct RxData
        {
            internal Int16 Temperature;
            internal UInt16 Voltage;
            internal byte DiscreteState;
            internal CommunicationError Error;
        }

        [Flags]
        private enum SlaveDiscrete
        {
            Led1State = 0x01,
            Led2State = 0x02,
            Led3State = 0x04,
            Led4State = 0x08,
            Button1State = 0x10
        }

        internal enum UartCommand : byte
        {
            SendData = 0x01,
            UpdateOutputs = 0x02,

            ErrorReset = 0x0F
        }

        internal enum CommunicationError : byte
        {
            None = 0x00,
            UartParity = 0x01,
            UartNoise = 0x02,
            UartFrame = 0x03,
            UartOverrun = 0x04,
            UartDmaTransfer = 0x05,
            IncorrectUartCommand = 0x06,

            IncorrectCrc = 0x07,
            TimeOutRx = 0x08,
            ProgramFailure = 0x09
        }

        internal enum CommunicationStatus
        {
            Start,
            Continue,
            SuccessfullyCompleted,
            Error
        }

        public SlaveModule(Form1 form, SerialPort serialPort, int pollingPeriod)
        {
            _form = form;
            _serialPort = serialPort;
            _pollingPeriod = pollingPeriod;

            _oneMsTimer = new System.Timers.Timer(1);
            _oneMsTimer.Elapsed += OneMsTimerLoop;
            _oneMsTimer.Start();

            _threadReceivedDataProcessing = new Thread(ReceivedDataProcessing);
            _threadReceivedDataProcessing.Start();
            _threadExchangeDataWithSlave = new Thread(ExchangeDataWithSlave);
            _threadExchangeDataWithSlave.Start();
        }

        private void ReceivedDataProcessing()
        {
            while (true)
            {
                if (_isPollEnable)
                {
                    _communicationStatus = CommunicationStatus.Start;
                    _cycleCount++;
                    Thread.Sleep(DelayToAnswer);

                    switch (_communicationStatus)
                    {
                        case CommunicationStatus.SuccessfullyCompleted:
                            _form.UpdateConnectionStatus("");
                            _form.UpdateMeasurementResults();
                            if (_currentCommand == UartCommand.ErrorReset)
                            {
                                _currentCommand = _lastCommand;
                            }

                            break;
                        case CommunicationStatus.Error:
                            _errorCount++;
                            var error = _errorCount + ") " + _communicationError;
                            _form.UpdateConnectionStatus(error);
                            if (_communicationError == CommunicationError.UartParity ||
                                _communicationError == CommunicationError.UartNoise ||
                                _communicationError == CommunicationError.UartFrame ||
                                _communicationError == CommunicationError.UartOverrun ||
                                _communicationError == CommunicationError.UartDmaTransfer ||
                                _communicationError == CommunicationError.IncorrectUartCommand)
                            {
                                _currentCommand = UartCommand.ErrorReset;
                            }

                            break;
                    }

                    Thread.Sleep(_pollingPeriod - DelayToAnswer);
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }

        private void OneMsTimerLoop(object sender, ElapsedEventArgs eventArgs)
        {
            if (_isPollEnable)
            {
                _timeOutRxCount++;
            }
        }

        private void ExchangeDataWithSlave()
        {
            while (true)
            {
                if (_isPollEnable)
                {
                    switch (_communicationStatus)
                    {
                        case CommunicationStatus.Start:
                        {
                            byte[] data = { (byte)(SlaveAddress | ((byte)_currentCommand << 4)), _dataToSlave };
                            var crc = Crc8(data);
                            byte[] buffer = { data[0], data[1], crc };
                            _form.WriteBytesToTextBoxCommand(buffer);
                            _serialPort.Write(buffer, 0, buffer.Length);
                            _communicationStatus = CommunicationStatus.Continue;
                            break;
                        }

                        case CommunicationStatus.Continue:
                        {
                            if (_serialPort.BytesToRead == (RxDataSize + sizeof(ushort)))
                            {
                                var dataFromSlave = new byte[RxDataSize];
                                _serialPort.Read(dataFromSlave, 0, dataFromSlave.Length);
                                var crc = Crc16(dataFromSlave);
                                var crcInput = (ushort)(_serialPort.ReadByte() | (_serialPort.ReadByte() << 8));
                                WriteDataToTextBoxAnswer(dataFromSlave, crcInput);
                                if (crcInput == crc)
                                {
                                    _rxData = StructTools.RawDeserialize<RxData>(dataFromSlave, 0);
                                    _communicationError = _rxData.Error;
                                    _communicationStatus = (_rxData.Error == CommunicationError.None)
                                        ? CommunicationStatus.SuccessfullyCompleted
                                        : CommunicationStatus.Error;

                                }
                                else
                                {
                                    EraseUnreadBytesFromUartBuffer();
                                    _communicationError = CommunicationError.IncorrectCrc;
                                    _communicationStatus = CommunicationStatus.Error;
                                }
                            }
                            else
                            {
                                if (_timeOutRxCount > TimeOutRx)
                                {
                                    EraseUnreadBytesFromUartBuffer();
                                    _communicationError = CommunicationError.TimeOutRx;
                                    _communicationStatus = CommunicationStatus.Error;
                                }
                            }

                            break;
                        }

                        case CommunicationStatus.SuccessfullyCompleted:
                        {
                            _timeOutRxCount = 0;
                            break;
                        }

                        case CommunicationStatus.Error:
                        {
                            _timeOutRxCount = 0;
                            break;
                        }

                        default:
                        {
                            _communicationError = CommunicationError.ProgramFailure;
                            _communicationStatus = CommunicationStatus.Error;
                            break;
                        }
                    }
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }

        private void EraseUnreadBytesFromUartBuffer()
        {
            while (_serialPort.BytesToRead != 0)
            {
                _serialPort.ReadByte();
            }
        }

        private void WriteDataToTextBoxAnswer(byte[] dataFromSlave, uint crc)
        {
            var data = new byte[RxDataSize + sizeof(ushort)];
            Array.Copy(dataFromSlave, data, dataFromSlave.Length);
            data[RxDataSize] = (byte)(crc >> 8);
            data[RxDataSize + 1] = (byte)crc;
            _form.WriteBytesToTextBoxAnswer(data);
        }

        private static byte Crc8(byte[] data)
        {
            byte crc = 0xFF;
            foreach (var t in data)
            {
                crc ^= t;
                for (var i = 0; i < 8; i++)
                {
                    crc = ((crc & 0x80) != 0)
                        ? (byte)((crc << 1) ^ 0x31)
                        : (byte)(crc << 1);
                }
            }
            return crc;
        }
        
        private static ushort Crc16(byte[] data)
        {
            ushort crc = 0xFFFF;
            foreach (var t in data)
            {
                crc ^= (ushort)(t << 8);
                for (var i = 0; i < 8; i++)
                {
                    crc = ((crc & 0x8000) != 0)
                        ? (ushort)((crc << 1) ^ 0x1021)
                        : (ushort)(crc << 1);
                }
            }
            return crc;
        }

        public void SetPollingPeriod(int period)
        {
            if (_isPollEnable == false)
            {
                _pollingPeriod = period;
            }
        }

        public bool IsPollEnable
        {
            set => _isPollEnable = value;
        }

        public void ChangeCommand(bool isUpdateOutputs)
        {
            _lastCommand = isUpdateOutputs ? UartCommand.UpdateOutputs : UartCommand.SendData;
            if (_currentCommand != UartCommand.ErrorReset)
            {
                _currentCommand = _lastCommand;
            }
        }

        public void FreeingUpResources()
        {
            _oneMsTimer.Stop();
            _oneMsTimer.Dispose();
            _threadReceivedDataProcessing.Abort();
            _threadReceivedDataProcessing.Join();
            _threadExchangeDataWithSlave.Abort();
            _threadExchangeDataWithSlave.Join();
        }

        public UInt32 GetCycleCount()
        {
            return _cycleCount;
        }

        public UInt32 GetErrorCount()
        {
            return _errorCount;
        }

        public Int32 GetTemperature()
        {
            return _rxData.Temperature;
        }

        public UInt32 GetVoltage()
        {
            return _rxData.Voltage;
        }

        public bool GetLed1State()
        {
            return (_rxData.DiscreteState & (byte)SlaveDiscrete.Led1State) != 0;
        }

        public bool GetLed2State()
        {
            return (_rxData.DiscreteState & (byte)SlaveDiscrete.Led2State) != 0;
        }

        public bool GetLed3State()
        {
            return (_rxData.DiscreteState & (byte)SlaveDiscrete.Led3State) != 0;
        }

        public bool GetLed4State()
        {
            return (_rxData.DiscreteState & (byte)SlaveDiscrete.Led4State) != 0;
        }

        public bool GetButton1State()
        {
            return (_rxData.DiscreteState & (byte)SlaveDiscrete.Button1State) != 0;
        }

        public void SetLed1State(bool state)
        {
            if (state)
            {
                _dataToSlave |= (byte)SlaveDiscrete.Led1State;
            }
            else
            {
                _dataToSlave &= ((byte)SlaveDiscrete.Led1State ^ 0xFF);
            }
        }

        public void SetLed2State(bool state)
        {
            if (state)
            {
                _dataToSlave |= (byte)SlaveDiscrete.Led2State;
            }
            else
            {
                _dataToSlave &= ((byte)SlaveDiscrete.Led2State ^ 0xFF);
            }
        }

        public void SetLed3State(bool state)
        {
            if (state)
            {
                _dataToSlave |= (byte)SlaveDiscrete.Led3State;
            }
            else
            {
                _dataToSlave &= ((byte)SlaveDiscrete.Led3State ^ 0xFF);
            }
        }

        public void SetLed4State(bool state)
        {
            if (state)
            {
                _dataToSlave |= (byte)SlaveDiscrete.Led4State;
            }
            else
            {
                _dataToSlave &= ((byte)SlaveDiscrete.Led4State ^ 0xFF);
            }
        }
    }
}
