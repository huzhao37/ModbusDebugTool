namespace ModbusDebugTool.LED
{
    partial class Led
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtPage = new DevComponents.Editors.IntegerInput();
            this.txtNum = new DevComponents.Editors.IntegerInput();
            this.cbSendMethod = new System.Windows.Forms.ComboBox();
            this.rbtN = new System.Windows.Forms.RadioButton();
            this.rbtS = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAddress = new DevComponents.Editors.IntegerInput();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbSerialName = new System.Windows.Forms.ComboBox();
            this.lblTimeX = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddress1 = new DevComponents.Editors.IntegerInput();
            this.txtPort = new DevComponents.Editors.IntegerInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.txtPage);
            this.panelEx1.Controls.Add(this.txtNum);
            this.panelEx1.Controls.Add(this.cbSendMethod);
            this.panelEx1.Controls.Add(this.rbtN);
            this.panelEx1.Controls.Add(this.rbtS);
            this.panelEx1.Controls.Add(this.panel2);
            this.panelEx1.Controls.Add(this.btnSet);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.label10);
            this.panelEx1.Controls.Add(this.label9);
            this.panelEx1.Controls.Add(this.btnSend);
            this.panelEx1.Controls.Add(this.lblResult);
            this.panelEx1.Controls.Add(this.label8);
            this.panelEx1.Controls.Add(this.txtMessage);
            this.panelEx1.Controls.Add(this.label6);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.cbCardType);
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(892, 438);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // txtPage
            // 
            // 
            // 
            // 
            this.txtPage.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPage.Location = new System.Drawing.Point(685, 108);
            this.txtPage.MinValue = 0;
            this.txtPage.Name = "txtPage";
            this.txtPage.ShowUpDown = true;
            this.txtPage.Size = new System.Drawing.Size(84, 21);
            this.txtPage.TabIndex = 92;
            this.txtPage.TabStop = false;
            this.txtPage.WatermarkText = "0";
            // 
            // txtNum
            // 
            // 
            // 
            // 
            this.txtNum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtNum.Location = new System.Drawing.Point(685, 156);
            this.txtNum.LockUpdateChecked = true;
            this.txtNum.MinValue = 0;
            this.txtNum.Name = "txtNum";
            this.txtNum.ShowUpDown = true;
            this.txtNum.Size = new System.Drawing.Size(84, 21);
            this.txtNum.TabIndex = 91;
            this.txtNum.TabStop = false;
            this.txtNum.WatermarkText = "0";
            // 
            // cbSendMethod
            // 
            this.cbSendMethod.FormattingEnabled = true;
            this.cbSendMethod.Items.AddRange(new object[] {
            "SendRom",
            "SendRam"});
            this.cbSendMethod.Location = new System.Drawing.Point(538, 157);
            this.cbSendMethod.Name = "cbSendMethod";
            this.cbSendMethod.Size = new System.Drawing.Size(64, 20);
            this.cbSendMethod.TabIndex = 89;
            this.cbSendMethod.Text = "SendRom";
            // 
            // rbtN
            // 
            this.rbtN.AutoSize = true;
            this.rbtN.Location = new System.Drawing.Point(127, 280);
            this.rbtN.Name = "rbtN";
            this.rbtN.Size = new System.Drawing.Size(71, 16);
            this.rbtN.TabIndex = 78;
            this.rbtN.TabStop = true;
            this.rbtN.Text = "网络通信";
            this.rbtN.UseVisualStyleBackColor = true;
            // 
            // rbtS
            // 
            this.rbtS.AutoSize = true;
            this.rbtS.Location = new System.Drawing.Point(127, 113);
            this.rbtS.Name = "rbtS";
            this.rbtS.Size = new System.Drawing.Size(71, 16);
            this.rbtS.TabIndex = 77;
            this.rbtS.TabStop = true;
            this.rbtS.Text = "串口通信";
            this.rbtS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.lblStopBit);
            this.panel2.Controls.Add(this.lblBaudRate);
            this.panel2.Controls.Add(this.cbBaudRate);
            this.panel2.Controls.Add(this.cbSerialName);
            this.panel2.Controls.Add(this.lblTimeX);
            this.panel2.Location = new System.Drawing.Point(127, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 108);
            this.panel2.TabIndex = 76;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAddress.Location = new System.Drawing.Point(90, 81);
            this.txtAddress.MinValue = 1;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ShowUpDown = true;
            this.txtAddress.Size = new System.Drawing.Size(83, 21);
            this.txtAddress.TabIndex = 39;
            this.txtAddress.TabStop = false;
            this.txtAddress.Value = 1;
            this.txtAddress.WatermarkText = "1";
            // 
            // lblStopBit
            // 
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.Location = new System.Drawing.Point(30, 81);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(65, 12);
            this.lblStopBit.TabIndex = 19;
            this.lblStopBit.Text = "设备地址：";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(30, 50);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(53, 12);
            this.lblBaudRate.TabIndex = 1;
            this.lblBaudRate.Text = "波特率：";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "76800"});
            this.cbBaudRate.Location = new System.Drawing.Point(89, 47);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(84, 20);
            this.cbBaudRate.TabIndex = 16;
            this.cbBaudRate.Text = "9600";
            // 
            // cbSerialName
            // 
            this.cbSerialName.FormattingEnabled = true;
            this.cbSerialName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28",
            "COM29",
            "COM30",
            "COM31",
            "COM32",
            "COM33",
            "COM20",
            "COM21"});
            this.cbSerialName.Location = new System.Drawing.Point(89, 10);
            this.cbSerialName.Name = "cbSerialName";
            this.cbSerialName.Size = new System.Drawing.Size(84, 20);
            this.cbSerialName.TabIndex = 33;
            this.cbSerialName.Text = "COM1";
            // 
            // lblTimeX
            // 
            this.lblTimeX.AutoSize = true;
            this.lblTimeX.Location = new System.Drawing.Point(30, 13);
            this.lblTimeX.Name = "lblTimeX";
            this.lblTimeX.Size = new System.Drawing.Size(53, 12);
            this.lblTimeX.TabIndex = 23;
            this.lblTimeX.Text = "串口名：";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(228, 273);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 73;
            this.btnSet.Text = "确定设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(124, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "请选择你通信方式";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 12);
            this.label10.TabIndex = 90;
            this.label10.Text = "发送方式（仅限小卡）：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 87;
            this.label9.Text = "节目页：";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(685, 197);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 23);
            this.btnSend.TabIndex = 86;
            this.btnSend.Text = "确定发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(461, 417);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(31, 12);
            this.lblResult.TabIndex = 85;
            this.lblResult.Text = "结果";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 83;
            this.label8.Text = "位  置：";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(463, 233);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(306, 176);
            this.txtMessage.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 81;
            this.label6.Text = "输入要发送的信息：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 80;
            this.label4.Text = "卡类型：";
            // 
            // cbCardType
            // 
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Items.AddRange(new object[] {
            "圆心小卡",
            "圆心大卡"});
            this.cbCardType.Location = new System.Drawing.Point(463, 114);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(139, 20);
            this.cbCardType.TabIndex = 79;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddress1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(127, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 112);
            this.panel1.TabIndex = 75;
            // 
            // txtAddress1
            // 
            // 
            // 
            // 
            this.txtAddress1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAddress1.Location = new System.Drawing.Point(89, 86);
            this.txtAddress1.MinValue = 1;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ShowUpDown = true;
            this.txtAddress1.Size = new System.Drawing.Size(84, 21);
            this.txtAddress1.TabIndex = 38;
            this.txtAddress1.TabStop = false;
            this.txtAddress1.Value = 1;
            this.txtAddress1.WatermarkText = "1";
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPort.Location = new System.Drawing.Point(90, 52);
            this.txtPort.MinValue = 1;
            this.txtPort.Name = "txtPort";
            this.txtPort.ShowUpDown = true;
            this.txtPort.Size = new System.Drawing.Size(83, 21);
            this.txtPort.TabIndex = 37;
            this.txtPort.TabStop = false;
            this.txtPort.Value = 1;
            this.txtPort.WatermarkText = "1024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "设备地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "IP：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-164, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "IP地址：";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(89, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(84, 21);
            this.txtIP.TabIndex = 27;
            this.txtIP.TabStop = false;
            this.txtIP.Text = "192.168.1.233";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "端口号：";
            // 
            // Led
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 438);
            this.Controls.Add(this.panelEx1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Led";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Led";
            this.Load += new System.EventHandler(this.Led_Load);
            this.Click += new System.EventHandler(this.Led_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.ComboBox cbSendMethod;
        private System.Windows.Forms.RadioButton rbtN;
        private System.Windows.Forms.RadioButton rbtS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbSerialName;
        private System.Windows.Forms.Label lblTimeX;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label7;
        private DevComponents.Editors.IntegerInput txtNum;
        private DevComponents.Editors.IntegerInput txtPage;
        private DevComponents.Editors.IntegerInput txtPort;
        private DevComponents.Editors.IntegerInput txtAddress1;
        private DevComponents.Editors.IntegerInput txtAddress;

    }
}