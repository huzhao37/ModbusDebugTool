namespace ModbusDebugTool
{
    partial class BaseSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseSet));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.rbtN = new System.Windows.Forms.RadioButton();
            this.rbtS = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbSerialName = new System.Windows.Forms.ComboBox();
            this.lblDataBit = new System.Windows.Forms.Label();
            this.cbDataBit = new System.Windows.Forms.ComboBox();
            this.lblTimeX = new System.Windows.Forms.Label();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbParityBit = new System.Windows.Forms.ComboBox();
            this.lblParityBit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPort = new DevComponents.Editors.IntegerInput();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.panelEx1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.rbtN);
            this.panelEx1.Controls.Add(this.rbtS);
            this.panelEx1.Controls.Add(this.panel2);
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.btnSet);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(527, 310);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // rbtN
            // 
            this.rbtN.AutoSize = true;
            this.rbtN.Location = new System.Drawing.Point(18, 150);
            this.rbtN.Name = "rbtN";
            this.rbtN.Size = new System.Drawing.Size(71, 16);
            this.rbtN.TabIndex = 44;
            this.rbtN.TabStop = true;
            this.rbtN.Text = "网络通信";
            this.rbtN.UseVisualStyleBackColor = true;
            // 
            // rbtS
            // 
            this.rbtS.AutoSize = true;
            this.rbtS.Location = new System.Drawing.Point(18, 16);
            this.rbtS.Name = "rbtS";
            this.rbtS.Size = new System.Drawing.Size(71, 16);
            this.rbtS.TabIndex = 43;
            this.rbtS.TabStop = true;
            this.rbtS.Text = "串口通信";
            this.rbtS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStopBit);
            this.panel2.Controls.Add(this.lblBaudRate);
            this.panel2.Controls.Add(this.cbBaudRate);
            this.panel2.Controls.Add(this.cbSerialName);
            this.panel2.Controls.Add(this.lblDataBit);
            this.panel2.Controls.Add(this.cbDataBit);
            this.panel2.Controls.Add(this.lblTimeX);
            this.panel2.Controls.Add(this.cbStopBit);
            this.panel2.Controls.Add(this.cbParityBit);
            this.panel2.Controls.Add(this.lblParityBit);
            this.panel2.Location = new System.Drawing.Point(7, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 100);
            this.panel2.TabIndex = 42;
            // 
            // lblStopBit
            // 
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.Location = new System.Drawing.Point(224, 22);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(53, 12);
            this.lblStopBit.TabIndex = 19;
            this.lblStopBit.Text = "停止位：";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(18, 22);
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
            this.cbBaudRate.Location = new System.Drawing.Point(77, 19);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(70, 20);
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
            "COM12"});
            this.cbSerialName.Location = new System.Drawing.Point(77, 66);
            this.cbSerialName.Name = "cbSerialName";
            this.cbSerialName.Size = new System.Drawing.Size(70, 20);
            this.cbSerialName.TabIndex = 33;
            this.cbSerialName.Text = "COM1";
            // 
            // lblDataBit
            // 
            this.lblDataBit.AutoSize = true;
            this.lblDataBit.Location = new System.Drawing.Point(381, 22);
            this.lblDataBit.Name = "lblDataBit";
            this.lblDataBit.Size = new System.Drawing.Size(53, 12);
            this.lblDataBit.TabIndex = 17;
            this.lblDataBit.Text = "数据位：";
            // 
            // cbDataBit
            // 
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDataBit.Location = new System.Drawing.Point(440, 19);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(70, 20);
            this.cbDataBit.TabIndex = 18;
            this.cbDataBit.Text = "8";
            // 
            // lblTimeX
            // 
            this.lblTimeX.AutoSize = true;
            this.lblTimeX.Location = new System.Drawing.Point(18, 69);
            this.lblTimeX.Name = "lblTimeX";
            this.lblTimeX.Size = new System.Drawing.Size(53, 12);
            this.lblTimeX.TabIndex = 23;
            this.lblTimeX.Text = "串口名：";
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBit.Location = new System.Drawing.Point(283, 19);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(70, 20);
            this.cbStopBit.TabIndex = 20;
            this.cbStopBit.Text = "1";
            // 
            // cbParityBit
            // 
            this.cbParityBit.FormattingEnabled = true;
            this.cbParityBit.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验",
            "Mark校验",
            "空格"});
            this.cbParityBit.Location = new System.Drawing.Point(283, 69);
            this.cbParityBit.Name = "cbParityBit";
            this.cbParityBit.Size = new System.Drawing.Size(70, 20);
            this.cbParityBit.TabIndex = 22;
            this.cbParityBit.Text = "无";
            // 
            // lblParityBit
            // 
            this.lblParityBit.AutoSize = true;
            this.lblParityBit.Location = new System.Drawing.Point(224, 72);
            this.lblParityBit.Name = "lblParityBit";
            this.lblParityBit.Size = new System.Drawing.Size(53, 12);
            this.lblParityBit.TabIndex = 21;
            this.lblParityBit.Text = "校验位：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(7, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 91);
            this.panel1.TabIndex = 41;
            // 
            // txtIP
            // 
            // 
            // 
            // 
            this.txtIP.Border.Class = "TextBoxBorder";
            this.txtIP.Location = new System.Drawing.Point(46, 37);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(129, 21);
            this.txtIP.TabIndex = 33;
            this.txtIP.TabStop = false;
            this.txtIP.Text = "192.168.1.233";
            this.txtIP.WatermarkText = "192.168.1.233";
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPort.Location = new System.Drawing.Point(253, 37);
            this.txtPort.MinValue = 10001;
            this.txtPort.Name = "txtPort";
            this.txtPort.ShowUpDown = true;
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 32;
            this.txtPort.TabStop = false;
            this.txtPort.Value = 10001;
            this.txtPort.WatermarkText = "10001";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "(形如：192.168.1.233)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "(形如：10001)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "端口号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "请选择你通信方式";
            // 
            // btnSet
            // 
            this.btnSet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSet.Location = new System.Drawing.Point(200, 275);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 39;
            this.btnSet.Text = "确定设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // BaseSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 310);
            this.Controls.Add(this.panelEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "通讯管理";
            this.Load += new System.EventHandler(this.BaseSet_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.RadioButton rbtN;
        private System.Windows.Forms.RadioButton rbtS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbSerialName;
        private System.Windows.Forms.Label lblDataBit;
        private System.Windows.Forms.ComboBox cbDataBit;
        private System.Windows.Forms.Label lblTimeX;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbParityBit;
        private System.Windows.Forms.Label lblParityBit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSet;
        private DevComponents.Editors.IntegerInput txtPort;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIP;

    }
}