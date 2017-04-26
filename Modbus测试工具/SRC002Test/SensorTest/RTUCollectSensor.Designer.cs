namespace ModbusDebugTool
{
    partial class RTUCollectSensor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPreBaudRate = new DevComponents.Editors.IntegerInput();
            this.txtPreDeviceAddress = new DevComponents.Editors.IntegerInput();
            this.cbRegisterAddress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSure = new System.Windows.Forms.Button();
            this.lblCO2Concentration = new System.Windows.Forms.Label();
            this.lblPreBaudRate = new System.Windows.Forms.Label();
            this.lblPreDeviceAddress = new System.Windows.Forms.Label();
            this.funcPanel1 = new System.Windows.Forms.Panel();
            this.cbDeviceAddress = new System.Windows.Forms.ComboBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.txtCO2Concentration = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreBaudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreDeviceAddress)).BeginInit();
            this.funcPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Controls.Add(this.funcPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(892, 510);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCO2Concentration);
            this.panel1.Controls.Add(this.txtPreBaudRate);
            this.panel1.Controls.Add(this.txtPreDeviceAddress);
            this.panel1.Controls.Add(this.cbRegisterAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSure);
            this.panel1.Controls.Add(this.lblCO2Concentration);
            this.panel1.Controls.Add(this.lblPreBaudRate);
            this.panel1.Controls.Add(this.lblPreDeviceAddress);
            this.panel1.Location = new System.Drawing.Point(159, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 241);
            this.panel1.TabIndex = 60;
            // 
            // txtPreBaudRate
            // 
            // 
            // 
            // 
            this.txtPreBaudRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPreBaudRate.Increment = 1200;
            this.txtPreBaudRate.Location = new System.Drawing.Point(98, 82);
            this.txtPreBaudRate.MinValue = 1200;
            this.txtPreBaudRate.Name = "txtPreBaudRate";
            this.txtPreBaudRate.ShowUpDown = true;
            this.txtPreBaudRate.Size = new System.Drawing.Size(114, 21);
            this.txtPreBaudRate.TabIndex = 2;
            this.txtPreBaudRate.TabStop = false;
            this.txtPreBaudRate.Value = 1200;
            // 
            // txtPreDeviceAddress
            // 
            // 
            // 
            // 
            this.txtPreDeviceAddress.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPreDeviceAddress.Location = new System.Drawing.Point(98, 22);
            this.txtPreDeviceAddress.MinValue = 1;
            this.txtPreDeviceAddress.Name = "txtPreDeviceAddress";
            this.txtPreDeviceAddress.ShowUpDown = true;
            this.txtPreDeviceAddress.Size = new System.Drawing.Size(114, 21);
            this.txtPreDeviceAddress.TabIndex = 0;
            this.txtPreDeviceAddress.TabStop = false;
            this.txtPreDeviceAddress.Value = 1;
            // 
            // cbRegisterAddress
            // 
            this.cbRegisterAddress.FormattingEnabled = true;
            this.cbRegisterAddress.Location = new System.Drawing.Point(388, 23);
            this.cbRegisterAddress.Name = "cbRegisterAddress";
            this.cbRegisterAddress.Size = new System.Drawing.Size(114, 20);
            this.cbRegisterAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 68;
            this.label2.Text = "当前设备接入：";
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(350, 153);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 27;
            this.btnSure.Text = "读取";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // lblCO2Concentration
            // 
            this.lblCO2Concentration.AutoSize = true;
            this.lblCO2Concentration.Location = new System.Drawing.Point(135, 158);
            this.lblCO2Concentration.Name = "lblCO2Concentration";
            this.lblCO2Concentration.Size = new System.Drawing.Size(77, 12);
            this.lblCO2Concentration.TabIndex = 60;
            this.lblCO2Concentration.Text = "当前数据值：";
            // 
            // lblPreBaudRate
            // 
            this.lblPreBaudRate.AutoSize = true;
            this.lblPreBaudRate.Location = new System.Drawing.Point(3, 82);
            this.lblPreBaudRate.Name = "lblPreBaudRate";
            this.lblPreBaudRate.Size = new System.Drawing.Size(77, 12);
            this.lblPreBaudRate.TabIndex = 56;
            this.lblPreBaudRate.Text = "当前波特率：";
            // 
            // lblPreDeviceAddress
            // 
            this.lblPreDeviceAddress.AutoSize = true;
            this.lblPreDeviceAddress.Location = new System.Drawing.Point(3, 26);
            this.lblPreDeviceAddress.Name = "lblPreDeviceAddress";
            this.lblPreDeviceAddress.Size = new System.Drawing.Size(89, 12);
            this.lblPreDeviceAddress.TabIndex = 52;
            this.lblPreDeviceAddress.Text = "当前设备地址：";
            // 
            // funcPanel1
            // 
            this.funcPanel1.Controls.Add(this.cbDeviceAddress);
            this.funcPanel1.Controls.Add(this.lblFunction);
            this.funcPanel1.Location = new System.Drawing.Point(159, 63);
            this.funcPanel1.Name = "funcPanel1";
            this.funcPanel1.Size = new System.Drawing.Size(575, 101);
            this.funcPanel1.TabIndex = 59;
            // 
            // cbDeviceAddress
            // 
            this.cbDeviceAddress.FormattingEnabled = true;
            this.cbDeviceAddress.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "0A",
            "0B",
            "0C",
            "0D",
            "0E",
            "0F",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "1A",
            "1B",
            "1C",
            "1D",
            "1E",
            "1F"});
            this.cbDeviceAddress.Location = new System.Drawing.Point(98, 52);
            this.cbDeviceAddress.Name = "cbDeviceAddress";
            this.cbDeviceAddress.Size = new System.Drawing.Size(124, 20);
            this.cbDeviceAddress.TabIndex = 38;
            this.cbDeviceAddress.Text = "01";
            // 
            // lblFunction
            // 
            this.lblFunction.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFunction.Location = new System.Drawing.Point(3, 6);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(178, 30);
            this.lblFunction.TabIndex = 25;
            this.lblFunction.Text = "选择设备装置地址：";
            // 
            // txtCO2Concentration
            // 
            // 
            // 
            // 
            this.txtCO2Concentration.Border.Class = "TextBoxBorder";
            this.txtCO2Concentration.Location = new System.Drawing.Point(228, 155);
            this.txtCO2Concentration.Name = "txtCO2Concentration";
            this.txtCO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.txtCO2Concentration.TabIndex = 69;
            // 
            // RTUCollectSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 510);
            this.Controls.Add(this.panelEx1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RTUCollectSensor";
            this.Text = "4-20mA采集传感器";
            this.Load += new System.EventHandler(this.RTUCollectSensor_Load);
            this.panelEx1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreBaudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreDeviceAddress)).EndInit();
            this.funcPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbRegisterAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label lblCO2Concentration;
        private System.Windows.Forms.Label lblPreBaudRate;
        private System.Windows.Forms.Label lblPreDeviceAddress;
        private System.Windows.Forms.Panel funcPanel1;
        private System.Windows.Forms.ComboBox cbDeviceAddress;
        private System.Windows.Forms.Label lblFunction;
        private DevComponents.Editors.IntegerInput txtPreBaudRate;
        private DevComponents.Editors.IntegerInput txtPreDeviceAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCO2Concentration;

    }
}