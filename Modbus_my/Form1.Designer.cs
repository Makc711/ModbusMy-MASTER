namespace Modbus_my
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxCommandsMa = new System.Windows.Forms.GroupBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.textBoxErrorCounter = new System.Windows.Forms.TextBox();
            this.textBoxCycleCounter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonPollDisable = new System.Windows.Forms.Button();
            this.textBoxPollingPeriod = new System.Windows.Forms.TextBox();
            this.buttonPollEnable = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBoxBatteryСharacteristics = new System.Windows.Forms.GroupBox();
            this.pictureBoxLed4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLed3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLed2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLed1 = new System.Windows.Forms.PictureBox();
            this.checkBoxLed4 = new System.Windows.Forms.CheckBox();
            this.checkBoxLed3 = new System.Windows.Forms.CheckBox();
            this.checkBoxLed2 = new System.Windows.Forms.CheckBox();
            this.checkBoxLed1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVoltage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxButton1 = new System.Windows.Forms.PictureBox();
            this.groupBoxHandshaking = new System.Windows.Forms.GroupBox();
            this.radioButtonHSRCOO = new System.Windows.Forms.RadioButton();
            this.radioButtonHSOO = new System.Windows.Forms.RadioButton();
            this.radioButtonHSRC = new System.Windows.Forms.RadioButton();
            this.radioButtonHSNone = new System.Windows.Forms.RadioButton();
            this.groupBoxSB = new System.Windows.Forms.GroupBox();
            this.radioButtonSB2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSB1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSB15 = new System.Windows.Forms.RadioButton();
            this.groupBoxParity = new System.Windows.Forms.GroupBox();
            this.radioButtonParitySpace = new System.Windows.Forms.RadioButton();
            this.radioButtonParityMark = new System.Windows.Forms.RadioButton();
            this.radioButtonParityEven = new System.Windows.Forms.RadioButton();
            this.radioButtonParityOdd = new System.Windows.Forms.RadioButton();
            this.radioButtonParityNone = new System.Windows.Forms.RadioButton();
            this.groupBoxDB = new System.Windows.Forms.GroupBox();
            this.radioButtonDB8 = new System.Windows.Forms.RadioButton();
            this.radioButtonDB5 = new System.Windows.Forms.RadioButton();
            this.radioButtonDB7 = new System.Windows.Forms.RadioButton();
            this.radioButtonDB6 = new System.Windows.Forms.RadioButton();
            this.groupBoxBR = new System.Windows.Forms.GroupBox();
            this.radioButtonBR256000 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR128000 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR115200 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR57600 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR56000 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR38400 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR28800 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR19200 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR14400 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR9600 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR4800 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR2400 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR1200 = new System.Windows.Forms.RadioButton();
            this.radioButtonBR600 = new System.Windows.Forms.RadioButton();
            this.groupBoxCOMPort = new System.Windows.Forms.GroupBox();
            this.buttonReScan = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxCOMs = new System.Windows.Forms.ComboBox();
            this.tabControlDebug = new System.Windows.Forms.TabControl();
            this.checkBoxUpdateOutputs = new System.Windows.Forms.CheckBox();
            this.textBoxCommunicationErrors = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageMain.SuspendLayout();
            this.groupBoxCommandsMa.SuspendLayout();
            this.groupBoxBatteryСharacteristics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton1)).BeginInit();
            this.groupBoxHandshaking.SuspendLayout();
            this.groupBoxSB.SuspendLayout();
            this.groupBoxParity.SuspendLayout();
            this.groupBoxDB.SuspendLayout();
            this.groupBoxBR.SuspendLayout();
            this.groupBoxCOMPort.SuspendLayout();
            this.tabControlDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBoxCommandsMa);
            this.tabPageMain.Controls.Add(this.groupBoxBatteryСharacteristics);
            this.tabPageMain.Controls.Add(this.groupBoxHandshaking);
            this.tabPageMain.Controls.Add(this.groupBoxSB);
            this.tabPageMain.Controls.Add(this.groupBoxParity);
            this.tabPageMain.Controls.Add(this.groupBoxDB);
            this.tabPageMain.Controls.Add(this.groupBoxBR);
            this.tabPageMain.Controls.Add(this.groupBoxCOMPort);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(651, 426);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главная";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxCommandsMa
            // 
            this.groupBoxCommandsMa.Controls.Add(this.label9);
            this.groupBoxCommandsMa.Controls.Add(this.textBoxCommunicationErrors);
            this.groupBoxCommandsMa.Controls.Add(this.textBoxAnswer);
            this.groupBoxCommandsMa.Controls.Add(this.textBoxCommand);
            this.groupBoxCommandsMa.Controls.Add(this.textBoxErrorCounter);
            this.groupBoxCommandsMa.Controls.Add(this.textBoxCycleCounter);
            this.groupBoxCommandsMa.Controls.Add(this.label5);
            this.groupBoxCommandsMa.Controls.Add(this.label6);
            this.groupBoxCommandsMa.Controls.Add(this.label4);
            this.groupBoxCommandsMa.Controls.Add(this.label3);
            this.groupBoxCommandsMa.Controls.Add(this.label24);
            this.groupBoxCommandsMa.Controls.Add(this.buttonPollDisable);
            this.groupBoxCommandsMa.Controls.Add(this.textBoxPollingPeriod);
            this.groupBoxCommandsMa.Controls.Add(this.buttonPollEnable);
            this.groupBoxCommandsMa.Controls.Add(this.label25);
            this.groupBoxCommandsMa.Controls.Add(this.label23);
            this.groupBoxCommandsMa.Location = new System.Drawing.Point(6, 242);
            this.groupBoxCommandsMa.Name = "groupBoxCommandsMa";
            this.groupBoxCommandsMa.Size = new System.Drawing.Size(639, 178);
            this.groupBoxCommandsMa.TabIndex = 22;
            this.groupBoxCommandsMa.TabStop = false;
            this.groupBoxCommandsMa.Text = "Соединение";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer.ForeColor = System.Drawing.Color.Black;
            this.textBoxAnswer.Location = new System.Drawing.Point(69, 140);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(554, 20);
            this.textBoxAnswer.TabIndex = 159;
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCommand.ForeColor = System.Drawing.Color.Black;
            this.textBoxCommand.Location = new System.Drawing.Point(70, 116);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.ReadOnly = true;
            this.textBoxCommand.Size = new System.Drawing.Size(553, 20);
            this.textBoxCommand.TabIndex = 158;
            // 
            // textBoxErrorCounter
            // 
            this.textBoxErrorCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxErrorCounter.ForeColor = System.Drawing.Color.Black;
            this.textBoxErrorCounter.Location = new System.Drawing.Point(96, 88);
            this.textBoxErrorCounter.Name = "textBoxErrorCounter";
            this.textBoxErrorCounter.ReadOnly = true;
            this.textBoxErrorCounter.Size = new System.Drawing.Size(78, 20);
            this.textBoxErrorCounter.TabIndex = 157;
            // 
            // textBoxCycleCounter
            // 
            this.textBoxCycleCounter.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCycleCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCycleCounter.ForeColor = System.Drawing.Color.Black;
            this.textBoxCycleCounter.Location = new System.Drawing.Point(96, 65);
            this.textBoxCycleCounter.Name = "textBoxCycleCounter";
            this.textBoxCycleCounter.ReadOnly = true;
            this.textBoxCycleCounter.Size = new System.Drawing.Size(78, 20);
            this.textBoxCycleCounter.TabIndex = 156;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ответ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Команда:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Число ошибок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Число циклов:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(345, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 13);
            this.label24.TabIndex = 47;
            this.label24.Text = "мс";
            // 
            // buttonPollDisable
            // 
            this.buttonPollDisable.Enabled = false;
            this.buttonPollDisable.Location = new System.Drawing.Point(215, 21);
            this.buttonPollDisable.Name = "buttonPollDisable";
            this.buttonPollDisable.Size = new System.Drawing.Size(83, 23);
            this.buttonPollDisable.TabIndex = 46;
            this.buttonPollDisable.Text = "Выключить";
            this.buttonPollDisable.UseVisualStyleBackColor = true;
            this.buttonPollDisable.Click += new System.EventHandler(this.buttonPollDisable_Click);
            // 
            // textBoxPollingPeriod
            // 
            this.textBoxPollingPeriod.Location = new System.Drawing.Point(298, 65);
            this.textBoxPollingPeriod.Name = "textBoxPollingPeriod";
            this.textBoxPollingPeriod.Size = new System.Drawing.Size(42, 20);
            this.textBoxPollingPeriod.TabIndex = 46;
            this.textBoxPollingPeriod.Text = "250";
            this.textBoxPollingPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPollingPeriod.TextChanged += new System.EventHandler(this.textBoxPollingPeriod_TextChanged);
            // 
            // buttonPollEnable
            // 
            this.buttonPollEnable.Enabled = false;
            this.buttonPollEnable.Location = new System.Drawing.Point(122, 21);
            this.buttonPollEnable.Name = "buttonPollEnable";
            this.buttonPollEnable.Size = new System.Drawing.Size(83, 23);
            this.buttonPollEnable.TabIndex = 3;
            this.buttonPollEnable.Text = "Включить";
            this.buttonPollEnable.UseVisualStyleBackColor = true;
            this.buttonPollEnable.Click += new System.EventHandler(this.buttonPollEnable_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(205, 68);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "Период опроса:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Опрос контроллера:";
            // 
            // groupBoxBatteryСharacteristics
            // 
            this.groupBoxBatteryСharacteristics.Controls.Add(this.checkBoxUpdateOutputs);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.pictureBoxLed4);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.pictureBoxLed3);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.pictureBoxLed2);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.pictureBoxLed1);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.checkBoxLed4);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.checkBoxLed3);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.checkBoxLed2);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.checkBoxLed1);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.label7);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.label19);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.textBoxTemperature);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.label8);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.label2);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.textBoxVoltage);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.label1);
            this.groupBoxBatteryСharacteristics.Controls.Add(this.pictureBoxButton1);
            this.groupBoxBatteryСharacteristics.Location = new System.Drawing.Point(6, 119);
            this.groupBoxBatteryСharacteristics.Name = "groupBoxBatteryСharacteristics";
            this.groupBoxBatteryСharacteristics.Size = new System.Drawing.Size(639, 117);
            this.groupBoxBatteryСharacteristics.TabIndex = 21;
            this.groupBoxBatteryСharacteristics.TabStop = false;
            this.groupBoxBatteryСharacteristics.Text = "Данные из контроллера";
            // 
            // pictureBoxLed4
            // 
            this.pictureBoxLed4.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxLed4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLed4.Location = new System.Drawing.Point(255, 89);
            this.pictureBoxLed4.Name = "pictureBoxLed4";
            this.pictureBoxLed4.Size = new System.Drawing.Size(13, 13);
            this.pictureBoxLed4.TabIndex = 159;
            this.pictureBoxLed4.TabStop = false;
            // 
            // pictureBoxLed3
            // 
            this.pictureBoxLed3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxLed3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLed3.Location = new System.Drawing.Point(255, 66);
            this.pictureBoxLed3.Name = "pictureBoxLed3";
            this.pictureBoxLed3.Size = new System.Drawing.Size(13, 13);
            this.pictureBoxLed3.TabIndex = 158;
            this.pictureBoxLed3.TabStop = false;
            // 
            // pictureBoxLed2
            // 
            this.pictureBoxLed2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxLed2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLed2.Location = new System.Drawing.Point(255, 43);
            this.pictureBoxLed2.Name = "pictureBoxLed2";
            this.pictureBoxLed2.Size = new System.Drawing.Size(13, 13);
            this.pictureBoxLed2.TabIndex = 157;
            this.pictureBoxLed2.TabStop = false;
            // 
            // pictureBoxLed1
            // 
            this.pictureBoxLed1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxLed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLed1.Location = new System.Drawing.Point(255, 20);
            this.pictureBoxLed1.Name = "pictureBoxLed1";
            this.pictureBoxLed1.Size = new System.Drawing.Size(13, 13);
            this.pictureBoxLed1.TabIndex = 156;
            this.pictureBoxLed1.TabStop = false;
            // 
            // checkBoxLed4
            // 
            this.checkBoxLed4.AutoSize = true;
            this.checkBoxLed4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLed4.Location = new System.Drawing.Point(189, 88);
            this.checkBoxLed4.Name = "checkBoxLed4";
            this.checkBoxLed4.Size = new System.Drawing.Size(56, 17);
            this.checkBoxLed4.TabIndex = 155;
            this.checkBoxLed4.Text = "LED 4";
            this.checkBoxLed4.UseVisualStyleBackColor = true;
            this.checkBoxLed4.CheckedChanged += new System.EventHandler(this.checkBoxLed4_CheckedChanged);
            // 
            // checkBoxLed3
            // 
            this.checkBoxLed3.AutoSize = true;
            this.checkBoxLed3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLed3.Location = new System.Drawing.Point(189, 65);
            this.checkBoxLed3.Name = "checkBoxLed3";
            this.checkBoxLed3.Size = new System.Drawing.Size(56, 17);
            this.checkBoxLed3.TabIndex = 154;
            this.checkBoxLed3.Text = "LED 3";
            this.checkBoxLed3.UseVisualStyleBackColor = true;
            this.checkBoxLed3.CheckedChanged += new System.EventHandler(this.checkBoxLed3_CheckedChanged);
            // 
            // checkBoxLed2
            // 
            this.checkBoxLed2.AutoSize = true;
            this.checkBoxLed2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLed2.Location = new System.Drawing.Point(189, 42);
            this.checkBoxLed2.Name = "checkBoxLed2";
            this.checkBoxLed2.Size = new System.Drawing.Size(56, 17);
            this.checkBoxLed2.TabIndex = 153;
            this.checkBoxLed2.Text = "LED 2";
            this.checkBoxLed2.UseVisualStyleBackColor = true;
            this.checkBoxLed2.CheckedChanged += new System.EventHandler(this.checkBoxLed2_CheckedChanged);
            // 
            // checkBoxLed1
            // 
            this.checkBoxLed1.AutoSize = true;
            this.checkBoxLed1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLed1.Location = new System.Drawing.Point(189, 19);
            this.checkBoxLed1.Name = "checkBoxLed1";
            this.checkBoxLed1.Size = new System.Drawing.Size(56, 17);
            this.checkBoxLed1.TabIndex = 48;
            this.checkBoxLed1.Text = "LED 1";
            this.checkBoxLed1.UseVisualStyleBackColor = true;
            this.checkBoxLed1.CheckedChanged += new System.EventHandler(this.checkBoxLed1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "°C";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(287, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 152;
            this.label19.Text = "Кнопка 1";
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(88, 44);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.ReadOnly = true;
            this.textBoxTemperature.Size = new System.Drawing.Size(42, 20);
            this.textBoxTemperature.TabIndex = 10;
            this.textBoxTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Температура:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "В";
            // 
            // textBoxVoltage
            // 
            this.textBoxVoltage.Location = new System.Drawing.Point(89, 18);
            this.textBoxVoltage.Name = "textBoxVoltage";
            this.textBoxVoltage.ReadOnly = true;
            this.textBoxVoltage.Size = new System.Drawing.Size(42, 20);
            this.textBoxVoltage.TabIndex = 1;
            this.textBoxVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напряжение:";
            // 
            // pictureBoxButton1
            // 
            this.pictureBoxButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxButton1.Location = new System.Drawing.Point(346, 20);
            this.pictureBoxButton1.Name = "pictureBoxButton1";
            this.pictureBoxButton1.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButton1.TabIndex = 143;
            this.pictureBoxButton1.TabStop = false;
            // 
            // groupBoxHandshaking
            // 
            this.groupBoxHandshaking.Controls.Add(this.radioButtonHSRCOO);
            this.groupBoxHandshaking.Controls.Add(this.radioButtonHSOO);
            this.groupBoxHandshaking.Controls.Add(this.radioButtonHSRC);
            this.groupBoxHandshaking.Controls.Add(this.radioButtonHSNone);
            this.groupBoxHandshaking.Location = new System.Drawing.Point(498, 6);
            this.groupBoxHandshaking.Name = "groupBoxHandshaking";
            this.groupBoxHandshaking.Size = new System.Drawing.Size(147, 107);
            this.groupBoxHandshaking.TabIndex = 15;
            this.groupBoxHandshaking.TabStop = false;
            this.groupBoxHandshaking.Text = "Handshaking";
            // 
            // radioButtonHSRCOO
            // 
            this.radioButtonHSRCOO.AutoSize = true;
            this.radioButtonHSRCOO.Location = new System.Drawing.Point(7, 82);
            this.radioButtonHSRCOO.Name = "radioButtonHSRCOO";
            this.radioButtonHSRCOO.Size = new System.Drawing.Size(134, 17);
            this.radioButtonHSRCOO.TabIndex = 3;
            this.radioButtonHSRCOO.Text = "RTS/CTS+XON/XOFF";
            this.radioButtonHSRCOO.UseVisualStyleBackColor = true;
            // 
            // radioButtonHSOO
            // 
            this.radioButtonHSOO.AutoSize = true;
            this.radioButtonHSOO.Location = new System.Drawing.Point(7, 61);
            this.radioButtonHSOO.Name = "radioButtonHSOO";
            this.radioButtonHSOO.Size = new System.Drawing.Size(80, 17);
            this.radioButtonHSOO.TabIndex = 2;
            this.radioButtonHSOO.Text = "XON/XOFF";
            this.radioButtonHSOO.UseVisualStyleBackColor = true;
            // 
            // radioButtonHSRC
            // 
            this.radioButtonHSRC.AutoSize = true;
            this.radioButtonHSRC.Location = new System.Drawing.Point(7, 40);
            this.radioButtonHSRC.Name = "radioButtonHSRC";
            this.radioButtonHSRC.Size = new System.Drawing.Size(73, 17);
            this.radioButtonHSRC.TabIndex = 1;
            this.radioButtonHSRC.Text = "RTS/CTS";
            this.radioButtonHSRC.UseVisualStyleBackColor = true;
            // 
            // radioButtonHSNone
            // 
            this.radioButtonHSNone.AutoSize = true;
            this.radioButtonHSNone.Checked = true;
            this.radioButtonHSNone.Location = new System.Drawing.Point(7, 20);
            this.radioButtonHSNone.Name = "radioButtonHSNone";
            this.radioButtonHSNone.Size = new System.Drawing.Size(49, 17);
            this.radioButtonHSNone.TabIndex = 0;
            this.radioButtonHSNone.TabStop = true;
            this.radioButtonHSNone.Text = "none";
            this.radioButtonHSNone.UseVisualStyleBackColor = true;
            // 
            // groupBoxSB
            // 
            this.groupBoxSB.Controls.Add(this.radioButtonSB2);
            this.groupBoxSB.Controls.Add(this.radioButtonSB1);
            this.groupBoxSB.Controls.Add(this.radioButtonSB15);
            this.groupBoxSB.Location = new System.Drawing.Point(429, 6);
            this.groupBoxSB.Name = "groupBoxSB";
            this.groupBoxSB.Size = new System.Drawing.Size(63, 107);
            this.groupBoxSB.TabIndex = 18;
            this.groupBoxSB.TabStop = false;
            this.groupBoxSB.Text = "Stop bits";
            // 
            // radioButtonSB2
            // 
            this.radioButtonSB2.AutoSize = true;
            this.radioButtonSB2.Location = new System.Drawing.Point(13, 82);
            this.radioButtonSB2.Name = "radioButtonSB2";
            this.radioButtonSB2.Size = new System.Drawing.Size(31, 17);
            this.radioButtonSB2.TabIndex = 17;
            this.radioButtonSB2.Text = "2";
            this.radioButtonSB2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSB1
            // 
            this.radioButtonSB1.AutoSize = true;
            this.radioButtonSB1.Checked = true;
            this.radioButtonSB1.Location = new System.Drawing.Point(13, 19);
            this.radioButtonSB1.Name = "radioButtonSB1";
            this.radioButtonSB1.Size = new System.Drawing.Size(31, 17);
            this.radioButtonSB1.TabIndex = 14;
            this.radioButtonSB1.TabStop = true;
            this.radioButtonSB1.Text = "1";
            this.radioButtonSB1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSB15
            // 
            this.radioButtonSB15.AutoSize = true;
            this.radioButtonSB15.Location = new System.Drawing.Point(13, 50);
            this.radioButtonSB15.Name = "radioButtonSB15";
            this.radioButtonSB15.Size = new System.Drawing.Size(40, 17);
            this.radioButtonSB15.TabIndex = 15;
            this.radioButtonSB15.Text = "1.5";
            this.radioButtonSB15.UseVisualStyleBackColor = true;
            // 
            // groupBoxParity
            // 
            this.groupBoxParity.Controls.Add(this.radioButtonParitySpace);
            this.groupBoxParity.Controls.Add(this.radioButtonParityMark);
            this.groupBoxParity.Controls.Add(this.radioButtonParityEven);
            this.groupBoxParity.Controls.Add(this.radioButtonParityOdd);
            this.groupBoxParity.Controls.Add(this.radioButtonParityNone);
            this.groupBoxParity.Location = new System.Drawing.Point(360, 6);
            this.groupBoxParity.Name = "groupBoxParity";
            this.groupBoxParity.Size = new System.Drawing.Size(63, 107);
            this.groupBoxParity.TabIndex = 14;
            this.groupBoxParity.TabStop = false;
            this.groupBoxParity.Text = "Parity";
            // 
            // radioButtonParitySpace
            // 
            this.radioButtonParitySpace.AutoSize = true;
            this.radioButtonParitySpace.Location = new System.Drawing.Point(7, 86);
            this.radioButtonParitySpace.Name = "radioButtonParitySpace";
            this.radioButtonParitySpace.Size = new System.Drawing.Size(54, 17);
            this.radioButtonParitySpace.TabIndex = 4;
            this.radioButtonParitySpace.Text = "space";
            this.radioButtonParitySpace.UseVisualStyleBackColor = true;
            // 
            // radioButtonParityMark
            // 
            this.radioButtonParityMark.AutoSize = true;
            this.radioButtonParityMark.Location = new System.Drawing.Point(7, 68);
            this.radioButtonParityMark.Name = "radioButtonParityMark";
            this.radioButtonParityMark.Size = new System.Drawing.Size(48, 17);
            this.radioButtonParityMark.TabIndex = 3;
            this.radioButtonParityMark.Text = "mark";
            this.radioButtonParityMark.UseVisualStyleBackColor = true;
            // 
            // radioButtonParityEven
            // 
            this.radioButtonParityEven.AutoSize = true;
            this.radioButtonParityEven.Location = new System.Drawing.Point(7, 50);
            this.radioButtonParityEven.Name = "radioButtonParityEven";
            this.radioButtonParityEven.Size = new System.Drawing.Size(49, 17);
            this.radioButtonParityEven.TabIndex = 2;
            this.radioButtonParityEven.Text = "even";
            this.radioButtonParityEven.UseVisualStyleBackColor = true;
            // 
            // radioButtonParityOdd
            // 
            this.radioButtonParityOdd.AutoSize = true;
            this.radioButtonParityOdd.Location = new System.Drawing.Point(7, 32);
            this.radioButtonParityOdd.Name = "radioButtonParityOdd";
            this.radioButtonParityOdd.Size = new System.Drawing.Size(43, 17);
            this.radioButtonParityOdd.TabIndex = 1;
            this.radioButtonParityOdd.Text = "odd";
            this.radioButtonParityOdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonParityNone
            // 
            this.radioButtonParityNone.AutoSize = true;
            this.radioButtonParityNone.Checked = true;
            this.radioButtonParityNone.Location = new System.Drawing.Point(7, 14);
            this.radioButtonParityNone.Name = "radioButtonParityNone";
            this.radioButtonParityNone.Size = new System.Drawing.Size(49, 17);
            this.radioButtonParityNone.TabIndex = 0;
            this.radioButtonParityNone.TabStop = true;
            this.radioButtonParityNone.Text = "none";
            this.radioButtonParityNone.UseVisualStyleBackColor = true;
            // 
            // groupBoxDB
            // 
            this.groupBoxDB.Controls.Add(this.radioButtonDB8);
            this.groupBoxDB.Controls.Add(this.radioButtonDB5);
            this.groupBoxDB.Controls.Add(this.radioButtonDB7);
            this.groupBoxDB.Controls.Add(this.radioButtonDB6);
            this.groupBoxDB.Location = new System.Drawing.Point(291, 6);
            this.groupBoxDB.Name = "groupBoxDB";
            this.groupBoxDB.Size = new System.Drawing.Size(63, 107);
            this.groupBoxDB.TabIndex = 2;
            this.groupBoxDB.TabStop = false;
            this.groupBoxDB.Text = "Data bits";
            // 
            // radioButtonDB8
            // 
            this.radioButtonDB8.AutoSize = true;
            this.radioButtonDB8.Checked = true;
            this.radioButtonDB8.Location = new System.Drawing.Point(13, 82);
            this.radioButtonDB8.Name = "radioButtonDB8";
            this.radioButtonDB8.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDB8.TabIndex = 17;
            this.radioButtonDB8.TabStop = true;
            this.radioButtonDB8.Text = "8";
            this.radioButtonDB8.UseVisualStyleBackColor = true;
            // 
            // radioButtonDB5
            // 
            this.radioButtonDB5.AutoSize = true;
            this.radioButtonDB5.Location = new System.Drawing.Point(13, 19);
            this.radioButtonDB5.Name = "radioButtonDB5";
            this.radioButtonDB5.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDB5.TabIndex = 14;
            this.radioButtonDB5.Text = "5";
            this.radioButtonDB5.UseVisualStyleBackColor = true;
            // 
            // radioButtonDB7
            // 
            this.radioButtonDB7.AutoSize = true;
            this.radioButtonDB7.Location = new System.Drawing.Point(13, 61);
            this.radioButtonDB7.Name = "radioButtonDB7";
            this.radioButtonDB7.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDB7.TabIndex = 16;
            this.radioButtonDB7.Text = "7";
            this.radioButtonDB7.UseVisualStyleBackColor = true;
            // 
            // radioButtonDB6
            // 
            this.radioButtonDB6.AutoSize = true;
            this.radioButtonDB6.Location = new System.Drawing.Point(13, 40);
            this.radioButtonDB6.Name = "radioButtonDB6";
            this.radioButtonDB6.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDB6.TabIndex = 15;
            this.radioButtonDB6.Text = "6";
            this.radioButtonDB6.UseVisualStyleBackColor = true;
            // 
            // groupBoxBR
            // 
            this.groupBoxBR.Controls.Add(this.radioButtonBR256000);
            this.groupBoxBR.Controls.Add(this.radioButtonBR128000);
            this.groupBoxBR.Controls.Add(this.radioButtonBR115200);
            this.groupBoxBR.Controls.Add(this.radioButtonBR57600);
            this.groupBoxBR.Controls.Add(this.radioButtonBR56000);
            this.groupBoxBR.Controls.Add(this.radioButtonBR38400);
            this.groupBoxBR.Controls.Add(this.radioButtonBR28800);
            this.groupBoxBR.Controls.Add(this.radioButtonBR19200);
            this.groupBoxBR.Controls.Add(this.radioButtonBR14400);
            this.groupBoxBR.Controls.Add(this.radioButtonBR9600);
            this.groupBoxBR.Controls.Add(this.radioButtonBR4800);
            this.groupBoxBR.Controls.Add(this.radioButtonBR2400);
            this.groupBoxBR.Controls.Add(this.radioButtonBR1200);
            this.groupBoxBR.Controls.Add(this.radioButtonBR600);
            this.groupBoxBR.Location = new System.Drawing.Point(97, 6);
            this.groupBoxBR.Name = "groupBoxBR";
            this.groupBoxBR.Size = new System.Drawing.Size(188, 107);
            this.groupBoxBR.TabIndex = 1;
            this.groupBoxBR.TabStop = false;
            this.groupBoxBR.Text = "Baud rate";
            // 
            // radioButtonBR256000
            // 
            this.radioButtonBR256000.AutoSize = true;
            this.radioButtonBR256000.Location = new System.Drawing.Point(123, 68);
            this.radioButtonBR256000.Name = "radioButtonBR256000";
            this.radioButtonBR256000.Size = new System.Drawing.Size(61, 17);
            this.radioButtonBR256000.TabIndex = 13;
            this.radioButtonBR256000.Text = "256000";
            this.radioButtonBR256000.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR128000
            // 
            this.radioButtonBR128000.AutoSize = true;
            this.radioButtonBR128000.Location = new System.Drawing.Point(123, 50);
            this.radioButtonBR128000.Name = "radioButtonBR128000";
            this.radioButtonBR128000.Size = new System.Drawing.Size(61, 17);
            this.radioButtonBR128000.TabIndex = 12;
            this.radioButtonBR128000.Text = "128000";
            this.radioButtonBR128000.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR115200
            // 
            this.radioButtonBR115200.AutoSize = true;
            this.radioButtonBR115200.Checked = true;
            this.radioButtonBR115200.Location = new System.Drawing.Point(123, 32);
            this.radioButtonBR115200.Name = "radioButtonBR115200";
            this.radioButtonBR115200.Size = new System.Drawing.Size(61, 17);
            this.radioButtonBR115200.TabIndex = 11;
            this.radioButtonBR115200.TabStop = true;
            this.radioButtonBR115200.Text = "115200";
            this.radioButtonBR115200.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR57600
            // 
            this.radioButtonBR57600.AutoSize = true;
            this.radioButtonBR57600.Location = new System.Drawing.Point(123, 14);
            this.radioButtonBR57600.Name = "radioButtonBR57600";
            this.radioButtonBR57600.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBR57600.TabIndex = 10;
            this.radioButtonBR57600.Text = "57600";
            this.radioButtonBR57600.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR56000
            // 
            this.radioButtonBR56000.AutoSize = true;
            this.radioButtonBR56000.Location = new System.Drawing.Point(62, 86);
            this.radioButtonBR56000.Name = "radioButtonBR56000";
            this.radioButtonBR56000.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBR56000.TabIndex = 9;
            this.radioButtonBR56000.Text = "56000";
            this.radioButtonBR56000.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR38400
            // 
            this.radioButtonBR38400.AutoSize = true;
            this.radioButtonBR38400.Location = new System.Drawing.Point(62, 68);
            this.radioButtonBR38400.Name = "radioButtonBR38400";
            this.radioButtonBR38400.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBR38400.TabIndex = 8;
            this.radioButtonBR38400.Text = "38400";
            this.radioButtonBR38400.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR28800
            // 
            this.radioButtonBR28800.AutoSize = true;
            this.radioButtonBR28800.Location = new System.Drawing.Point(62, 50);
            this.radioButtonBR28800.Name = "radioButtonBR28800";
            this.radioButtonBR28800.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBR28800.TabIndex = 7;
            this.radioButtonBR28800.Text = "28800";
            this.radioButtonBR28800.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR19200
            // 
            this.radioButtonBR19200.AutoSize = true;
            this.radioButtonBR19200.Location = new System.Drawing.Point(62, 32);
            this.radioButtonBR19200.Name = "radioButtonBR19200";
            this.radioButtonBR19200.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBR19200.TabIndex = 6;
            this.radioButtonBR19200.Text = "19200";
            this.radioButtonBR19200.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR14400
            // 
            this.radioButtonBR14400.AutoSize = true;
            this.radioButtonBR14400.Location = new System.Drawing.Point(62, 14);
            this.radioButtonBR14400.Name = "radioButtonBR14400";
            this.radioButtonBR14400.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBR14400.TabIndex = 5;
            this.radioButtonBR14400.Text = "14400";
            this.radioButtonBR14400.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR9600
            // 
            this.radioButtonBR9600.AutoSize = true;
            this.radioButtonBR9600.Location = new System.Drawing.Point(7, 86);
            this.radioButtonBR9600.Name = "radioButtonBR9600";
            this.radioButtonBR9600.Size = new System.Drawing.Size(49, 17);
            this.radioButtonBR9600.TabIndex = 4;
            this.radioButtonBR9600.Text = "9600";
            this.radioButtonBR9600.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR4800
            // 
            this.radioButtonBR4800.AutoSize = true;
            this.radioButtonBR4800.Location = new System.Drawing.Point(7, 68);
            this.radioButtonBR4800.Name = "radioButtonBR4800";
            this.radioButtonBR4800.Size = new System.Drawing.Size(49, 17);
            this.radioButtonBR4800.TabIndex = 3;
            this.radioButtonBR4800.Text = "4800";
            this.radioButtonBR4800.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR2400
            // 
            this.radioButtonBR2400.AutoSize = true;
            this.radioButtonBR2400.Location = new System.Drawing.Point(7, 50);
            this.radioButtonBR2400.Name = "radioButtonBR2400";
            this.radioButtonBR2400.Size = new System.Drawing.Size(49, 17);
            this.radioButtonBR2400.TabIndex = 2;
            this.radioButtonBR2400.Text = "2400";
            this.radioButtonBR2400.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR1200
            // 
            this.radioButtonBR1200.AutoSize = true;
            this.radioButtonBR1200.Location = new System.Drawing.Point(7, 32);
            this.radioButtonBR1200.Name = "radioButtonBR1200";
            this.radioButtonBR1200.Size = new System.Drawing.Size(49, 17);
            this.radioButtonBR1200.TabIndex = 1;
            this.radioButtonBR1200.Text = "1200";
            this.radioButtonBR1200.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR600
            // 
            this.radioButtonBR600.AutoSize = true;
            this.radioButtonBR600.Location = new System.Drawing.Point(7, 14);
            this.radioButtonBR600.Name = "radioButtonBR600";
            this.radioButtonBR600.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBR600.TabIndex = 0;
            this.radioButtonBR600.Text = "600";
            this.radioButtonBR600.UseVisualStyleBackColor = true;
            // 
            // groupBoxCOMPort
            // 
            this.groupBoxCOMPort.Controls.Add(this.buttonReScan);
            this.groupBoxCOMPort.Controls.Add(this.buttonConnect);
            this.groupBoxCOMPort.Controls.Add(this.comboBoxCOMs);
            this.groupBoxCOMPort.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCOMPort.Name = "groupBoxCOMPort";
            this.groupBoxCOMPort.Size = new System.Drawing.Size(85, 107);
            this.groupBoxCOMPort.TabIndex = 0;
            this.groupBoxCOMPort.TabStop = false;
            this.groupBoxCOMPort.Text = "COM Port";
            // 
            // buttonReScan
            // 
            this.buttonReScan.Location = new System.Drawing.Point(7, 77);
            this.buttonReScan.Name = "buttonReScan";
            this.buttonReScan.Size = new System.Drawing.Size(70, 23);
            this.buttonReScan.TabIndex = 2;
            this.buttonReScan.Text = "ReScan";
            this.buttonReScan.UseVisualStyleBackColor = true;
            this.buttonReScan.Click += new System.EventHandler(this.buttonReScan_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(7, 48);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(70, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxCOMs
            // 
            this.comboBoxCOMs.FormattingEnabled = true;
            this.comboBoxCOMs.Location = new System.Drawing.Point(7, 19);
            this.comboBoxCOMs.Name = "comboBoxCOMs";
            this.comboBoxCOMs.Size = new System.Drawing.Size(70, 21);
            this.comboBoxCOMs.TabIndex = 0;
            // 
            // tabControlDebug
            // 
            this.tabControlDebug.Controls.Add(this.tabPageMain);
            this.tabControlDebug.Location = new System.Drawing.Point(12, 12);
            this.tabControlDebug.Name = "tabControlDebug";
            this.tabControlDebug.SelectedIndex = 0;
            this.tabControlDebug.Size = new System.Drawing.Size(659, 452);
            this.tabControlDebug.TabIndex = 1;
            // 
            // checkBoxUpdateOutputs
            // 
            this.checkBoxUpdateOutputs.AutoSize = true;
            this.checkBoxUpdateOutputs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUpdateOutputs.Location = new System.Drawing.Point(7, 85);
            this.checkBoxUpdateOutputs.Name = "checkBoxUpdateOutputs";
            this.checkBoxUpdateOutputs.Size = new System.Drawing.Size(99, 17);
            this.checkBoxUpdateOutputs.TabIndex = 160;
            this.checkBoxUpdateOutputs.Text = "Update outputs";
            this.checkBoxUpdateOutputs.UseVisualStyleBackColor = true;
            this.checkBoxUpdateOutputs.CheckedChanged += new System.EventHandler(this.checkBoxUpdateOutputs_CheckedChanged);
            // 
            // textBoxCommunicationErrors
            // 
            this.textBoxCommunicationErrors.Location = new System.Drawing.Point(380, 32);
            this.textBoxCommunicationErrors.Multiline = true;
            this.textBoxCommunicationErrors.Name = "textBoxCommunicationErrors";
            this.textBoxCommunicationErrors.ReadOnly = true;
            this.textBoxCommunicationErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommunicationErrors.Size = new System.Drawing.Size(243, 72);
            this.textBoxCommunicationErrors.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 160;
            this.label9.Text = "Ошибки связи:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 472);
            this.Controls.Add(this.tabControlDebug);
            this.Name = "Form1";
            this.Text = "Modbus_my";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxCommandsMa.ResumeLayout(false);
            this.groupBoxCommandsMa.PerformLayout();
            this.groupBoxBatteryСharacteristics.ResumeLayout(false);
            this.groupBoxBatteryСharacteristics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton1)).EndInit();
            this.groupBoxHandshaking.ResumeLayout(false);
            this.groupBoxHandshaking.PerformLayout();
            this.groupBoxSB.ResumeLayout(false);
            this.groupBoxSB.PerformLayout();
            this.groupBoxParity.ResumeLayout(false);
            this.groupBoxParity.PerformLayout();
            this.groupBoxDB.ResumeLayout(false);
            this.groupBoxDB.PerformLayout();
            this.groupBoxBR.ResumeLayout(false);
            this.groupBoxBR.PerformLayout();
            this.groupBoxCOMPort.ResumeLayout(false);
            this.tabControlDebug.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBoxButton1;
        private System.Windows.Forms.GroupBox groupBoxCommandsMa;
        private System.Windows.Forms.CheckBox checkBoxLed1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button buttonPollDisable;
        private System.Windows.Forms.TextBox textBoxPollingPeriod;
        private System.Windows.Forms.Button buttonPollEnable;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBoxBatteryСharacteristics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVoltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxHandshaking;
        private System.Windows.Forms.RadioButton radioButtonHSRCOO;
        private System.Windows.Forms.RadioButton radioButtonHSOO;
        private System.Windows.Forms.RadioButton radioButtonHSRC;
        private System.Windows.Forms.RadioButton radioButtonHSNone;
        private System.Windows.Forms.GroupBox groupBoxSB;
        private System.Windows.Forms.RadioButton radioButtonSB2;
        private System.Windows.Forms.RadioButton radioButtonSB1;
        private System.Windows.Forms.RadioButton radioButtonSB15;
        private System.Windows.Forms.GroupBox groupBoxParity;
        private System.Windows.Forms.RadioButton radioButtonParitySpace;
        private System.Windows.Forms.RadioButton radioButtonParityMark;
        private System.Windows.Forms.RadioButton radioButtonParityEven;
        private System.Windows.Forms.RadioButton radioButtonParityOdd;
        private System.Windows.Forms.RadioButton radioButtonParityNone;
        private System.Windows.Forms.GroupBox groupBoxDB;
        private System.Windows.Forms.RadioButton radioButtonDB8;
        private System.Windows.Forms.RadioButton radioButtonDB5;
        private System.Windows.Forms.RadioButton radioButtonDB7;
        private System.Windows.Forms.RadioButton radioButtonDB6;
        private System.Windows.Forms.GroupBox groupBoxBR;
        private System.Windows.Forms.RadioButton radioButtonBR256000;
        private System.Windows.Forms.RadioButton radioButtonBR128000;
        private System.Windows.Forms.RadioButton radioButtonBR115200;
        private System.Windows.Forms.RadioButton radioButtonBR57600;
        private System.Windows.Forms.RadioButton radioButtonBR56000;
        private System.Windows.Forms.RadioButton radioButtonBR38400;
        private System.Windows.Forms.RadioButton radioButtonBR28800;
        private System.Windows.Forms.RadioButton radioButtonBR19200;
        private System.Windows.Forms.RadioButton radioButtonBR14400;
        private System.Windows.Forms.RadioButton radioButtonBR9600;
        private System.Windows.Forms.RadioButton radioButtonBR4800;
        private System.Windows.Forms.RadioButton radioButtonBR2400;
        private System.Windows.Forms.RadioButton radioButtonBR1200;
        private System.Windows.Forms.RadioButton radioButtonBR600;
        private System.Windows.Forms.GroupBox groupBoxCOMPort;
        private System.Windows.Forms.Button buttonReScan;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxCOMs;
        private System.Windows.Forms.TabControl tabControlDebug;
        private System.Windows.Forms.CheckBox checkBoxLed4;
        private System.Windows.Forms.CheckBox checkBoxLed3;
        private System.Windows.Forms.CheckBox checkBoxLed2;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.TextBox textBoxErrorCounter;
        private System.Windows.Forms.TextBox textBoxCycleCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxLed4;
        private System.Windows.Forms.PictureBox pictureBoxLed3;
        private System.Windows.Forms.PictureBox pictureBoxLed2;
        private System.Windows.Forms.PictureBox pictureBoxLed1;
        private System.Windows.Forms.CheckBox checkBoxUpdateOutputs;
        private System.Windows.Forms.TextBox textBoxCommunicationErrors;
        private System.Windows.Forms.Label label9;
    }
}

