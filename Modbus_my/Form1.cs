using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Modbus_my
{
    public partial class Form1 : Form
    {
        private SlaveModule _slaveModule;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchSerialPorts();
            ClearMeasurementsFields();
            _slaveModule = new SlaveModule(this, serialPort1, int.Parse(textBoxPollingPeriod.Text));
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == @"Connect")
            {
                try
                {
                    ConfigureSerialPort();
                    serialPort1.Open();
                    buttonConnect.Text = @"Disconnect";
                    buttonReScan.Enabled = false;
                    buttonPollEnable.Enabled = true;
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                buttonPollDisable_Click(this, EventArgs.Empty);
                buttonPollEnable.Enabled = false;
                buttonConnect.Text = @"Connect";
                buttonReScan.Enabled = true;
                CloseSerialPort();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseSerialPort();
            _slaveModule.FreeingUpResources();
        }

        private void CloseSerialPort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void SearchSerialPorts()
        {
            comboBoxCOMs.Items.Clear();
            var ports = SerialPort.GetPortNames();
            var sortingPorts = new List<string>();
            sortingPorts.AddRange(ports);
            sortingPorts.Sort();
            foreach (var port in sortingPorts.Where(port => port.StartsWith("COM")))
            {
                comboBoxCOMs.Items.Add(port);
            }
            if (comboBoxCOMs.Items.Count > 0)
            {
                comboBoxCOMs.SelectedIndex = 0;
            } 
            else
            {
                comboBoxCOMs.Text = string.Empty;
            }
        }

        private void buttonReScan_Click(object sender, EventArgs e)
        {
            SearchSerialPorts();
        }

        private void ConfigureSerialPort()
        {
            serialPort1.PortName = comboBoxCOMs.Text;
            serialPort1.BaudRate = GetSelectedBaudRate();
            serialPort1.DataBits = GetSelectedDataBits();
            serialPort1.Parity = GetSelectedParity();
            serialPort1.StopBits = GetSelectedStopBits();
            serialPort1.Handshake = GetSelectedHandshake();
        }

        private int GetSelectedBaudRate()
        {
            var baudRate = 9600;
            foreach (RadioButton radioButton in groupBoxBR.Controls)
            {
                if (radioButton.Checked)
                {
                    baudRate = int.Parse(radioButton.Text);
                    break;
                }
            }
            return baudRate;
        }

        private int GetSelectedDataBits()
        {
            var dataBits = 8;
            foreach (RadioButton radioButton in groupBoxDB.Controls)
            {
                if (radioButton.Checked)
                {
                    dataBits = int.Parse(radioButton.Text);
                    break;
                }
            }
            return dataBits;
        }

        private Parity GetSelectedParity()
        {
            var parity = Parity.None;
            if (radioButtonParityNone.Checked)
            {
                parity = Parity.None;
            } else if (radioButtonParityOdd.Checked)
            {
                parity = Parity.Odd;
            } else if (radioButtonParityEven.Checked)
            {
                parity = Parity.Even;
            } else if (radioButtonParityMark.Checked)
            {
                parity = Parity.Mark;
            } else if (radioButtonParitySpace.Checked)
            {
                parity = Parity.Space;
            }
            return parity;
        }

        private StopBits GetSelectedStopBits()
        {
            var stopBits = StopBits.One;
            if (radioButtonSB1.Checked)
            {
                stopBits = StopBits.One;
            } else if (radioButtonSB15.Checked)
            {
                stopBits = StopBits.OnePointFive;
            } else if (radioButtonSB2.Checked)
            {
                stopBits = StopBits.Two;
            }
            return stopBits;
        }

        private Handshake GetSelectedHandshake()
        {
            var handshake = Handshake.None;
            if (radioButtonHSNone.Checked)
            {
                handshake = Handshake.None;
            } else if (radioButtonHSRC.Checked)
            {
                handshake = Handshake.RequestToSend;
            } else if (radioButtonHSOO.Checked)
            {
                handshake = Handshake.XOnXOff;
            } else if (radioButtonHSRCOO.Checked)
            {
                handshake = Handshake.RequestToSendXOnXOff;
            }
            return handshake;
        }

        private void buttonPollEnable_Click(object sender, EventArgs e)
        {
            buttonPollDisable.Enabled = true;
            buttonPollEnable.Enabled = false;
            textBoxPollingPeriod.ReadOnly = true;
            _slaveModule.SetPollingPeriod(int.Parse(textBoxPollingPeriod.Text));
            _slaveModule.IsPollEnable = true;
        }

        private void buttonPollDisable_Click(object sender, EventArgs e)
        {
            buttonPollEnable.Enabled = true;
            buttonPollDisable.Enabled = false;
            textBoxPollingPeriod.ReadOnly = false;
            _slaveModule.IsPollEnable = false;
        }

        private void ClearMeasurementsFields()
        {
            textBoxVoltage.Text = string.Empty;
            textBoxTemperature.Text = string.Empty;
            textBoxCycleCounter.Text = string.Empty;
            textBoxErrorCounter.Text = string.Empty;
            textBoxCommand.Text = string.Empty;
            textBoxAnswer.Text = string.Empty;
        }

        public void UpdateConnectionStatus(string error)
        {
            textBoxCycleCounter.Invoke((ThreadStart)delegate
            {
                textBoxCycleCounter.Text = _slaveModule.GetCycleCount().ToString();
            });
            textBoxErrorCounter.Invoke((ThreadStart)delegate
            {
                textBoxErrorCounter.Text = _slaveModule.GetErrorCount().ToString();
            });
            textBoxCommunicationErrors.Invoke((ThreadStart)delegate
            {
                if (error != "")
                {
                    textBoxCommunicationErrors.Text += error + '\r' + '\n';
                }
            });
        }

        public void WriteBytesToTextBoxCommand(byte[] data)
        {
            textBoxCommand.Invoke((ThreadStart)delegate
            {
                textBoxCommand.Text = ConvertBytesToString(data);
            });
        }

        public void WriteBytesToTextBoxAnswer(byte[] data)
        {
            textBoxAnswer.Invoke((ThreadStart)delegate
            {
                textBoxAnswer.Text = ConvertBytesToString(data);
            });
        }

        private static string ConvertBytesToString(byte[] data)
        {
            string text = null;
            foreach (var d in data)
            {
                text += d.ToString("X2") + " ";
            }
            return text;
        }

        public void UpdateMeasurementResults()
        {
            textBoxTemperature.Invoke((ThreadStart)delegate
            {
                textBoxTemperature.Text = _slaveModule.GetTemperature().ToString();
            });
            textBoxVoltage.Invoke((ThreadStart)delegate
            {
                textBoxVoltage.Text = _slaveModule.GetVoltage().ToString();
            });
            pictureBoxLed1.Invoke((ThreadStart)delegate
            {
                pictureBoxLed1.BackColor = _slaveModule.GetLed1State()
                    ? Color.Firebrick
                    : Color.Gainsboro;
            });
            pictureBoxLed2.Invoke((ThreadStart)delegate
            {
                pictureBoxLed2.BackColor = _slaveModule.GetLed2State()
                    ? Color.Firebrick
                    : Color.Gainsboro;
            });
            pictureBoxLed3.Invoke((ThreadStart)delegate
            {
                pictureBoxLed3.BackColor = _slaveModule.GetLed3State()
                    ? Color.Firebrick
                    : Color.Gainsboro;
            });
            pictureBoxLed4.Invoke((ThreadStart)delegate
            {
                pictureBoxLed4.BackColor = _slaveModule.GetLed4State()
                    ? Color.Firebrick
                    : Color.Gainsboro;
            });
            pictureBoxButton1.Invoke((ThreadStart)delegate
            {
                pictureBoxButton1.BackColor = _slaveModule.GetButton1State()
                    ? Color.Green
                    : Color.Gainsboro;
            });
        }

        private void textBoxPollingPeriod_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBoxPollingPeriod.Text) < 50)
            {
                textBoxPollingPeriod.Invoke((ThreadStart)delegate
                {
                    textBoxPollingPeriod.Text = 50.ToString();
                });
            }
            if (int.Parse(textBoxPollingPeriod.Text) > 10000)
            {
                textBoxPollingPeriod.Invoke((ThreadStart)delegate
                {
                    textBoxPollingPeriod.Text = 10000.ToString();
                });
            }
        }

        private void checkBoxLed1_CheckedChanged(object sender, EventArgs e)
        {
            _slaveModule.SetLed1State(checkBoxLed1.Checked);
        }

        private void checkBoxLed2_CheckedChanged(object sender, EventArgs e)
        {
            _slaveModule.SetLed2State(checkBoxLed2.Checked);
        }

        private void checkBoxLed3_CheckedChanged(object sender, EventArgs e)
        {
            _slaveModule.SetLed3State(checkBoxLed3.Checked);
        }

        private void checkBoxLed4_CheckedChanged(object sender, EventArgs e)
        {
            _slaveModule.SetLed4State(checkBoxLed4.Checked);
        }

        private void checkBoxUpdateOutputs_CheckedChanged(object sender, EventArgs e)
        {
            _slaveModule.ChangeCommand(checkBoxUpdateOutputs.Checked);
        }
    }
}
