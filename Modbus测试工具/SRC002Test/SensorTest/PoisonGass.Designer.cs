namespace ModbusDebugTool
{
    partial class PoisonGass
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
            this.txtFolBaudRate = new DevComponents.Editors.IntegerInput();
            this.txtFolDeviceAddress = new DevComponents.Editors.IntegerInput();
            this.txtPreBaudRate = new DevComponents.Editors.IntegerInput();
            this.txtPreDeviceAddress = new DevComponents.Editors.IntegerInput();
            this.btnSure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblCO2Concentration = new System.Windows.Forms.Label();
            this.lblFolBaudRate = new System.Windows.Forms.Label();
            this.lblPreBaudRate = new System.Windows.Forms.Label();
            this.lblFolDeviceAddress = new System.Windows.Forms.Label();
            this.lblPreDeviceAddress = new System.Windows.Forms.Label();
            this.txtCO2Concentration = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolBaudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolDeviceAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreBaudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreDeviceAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.panel1);
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
            this.panel1.Controls.Add(this.txtFolBaudRate);
            this.panel1.Controls.Add(this.txtFolDeviceAddress);
            this.panel1.Controls.Add(this.txtPreBaudRate);
            this.panel1.Controls.Add(this.txtPreDeviceAddress);
            this.panel1.Controls.Add(this.btnSure);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lblCO2Concentration);
            this.panel1.Controls.Add(this.lblFolBaudRate);
            this.panel1.Controls.Add(this.lblPreBaudRate);
            this.panel1.Controls.Add(this.lblFolDeviceAddress);
            this.panel1.Controls.Add(this.lblPreDeviceAddress);
            this.panel1.Location = new System.Drawing.Point(159, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 241);
            this.panel1.TabIndex = 58;
            // 
            // txtFolBaudRate
            // 
            // 
            // 
            // 
            this.txtFolBaudRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFolBaudRate.Increment = 1200;
            this.txtFolBaudRate.Location = new System.Drawing.Point(388, 82);
            this.txtFolBaudRate.MinValue = 1200;
            this.txtFolBaudRate.Name = "txtFolBaudRate";
            this.txtFolBaudRate.ShowUpDown = true;
            this.txtFolBaudRate.Size = new System.Drawing.Size(113, 21);
            this.txtFolBaudRate.TabIndex = 4;
            this.txtFolBaudRate.TabStop = false;
            this.txtFolBaudRate.Value = 1200;
            this.txtFolBaudRate.WatermarkText = "9600";
            // 
            // txtFolDeviceAddress
            // 
            // 
            // 
            // 
            this.txtFolDeviceAddress.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFolDeviceAddress.Location = new System.Drawing.Point(388, 20);
            this.txtFolDeviceAddress.MinValue = 1;
            this.txtFolDeviceAddress.Name = "txtFolDeviceAddress";
            this.txtFolDeviceAddress.ShowUpDown = true;
            this.txtFolDeviceAddress.Size = new System.Drawing.Size(113, 21);
            this.txtFolDeviceAddress.TabIndex = 3;
            this.txtFolDeviceAddress.TabStop = false;
            this.txtFolDeviceAddress.Value = 1;
            this.txtFolDeviceAddress.WatermarkText = "11";
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
            this.txtPreDeviceAddress.Location = new System.Drawing.Point(98, 20);
            this.txtPreDeviceAddress.MinValue = 1;
            this.txtPreDeviceAddress.Name = "txtPreDeviceAddress";
            this.txtPreDeviceAddress.ShowUpDown = true;
            this.txtPreDeviceAddress.Size = new System.Drawing.Size(114, 21);
            this.txtPreDeviceAddress.TabIndex = 1;
            this.txtPreDeviceAddress.TabStop = false;
            this.txtPreDeviceAddress.Value = 1;
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(350, 155);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 68;
            this.btnSure.Text = "读取";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 67;
            this.label1.Text = "（请输入十进制数！）";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(386, 47);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(125, 12);
            this.lbl.TabIndex = 66;
            this.lbl.Text = "（请输入十进制数！）";
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
            // lblFolBaudRate
            // 
            this.lblFolBaudRate.AutoSize = true;
            this.lblFolBaudRate.Location = new System.Drawing.Point(281, 82);
            this.lblFolBaudRate.Name = "lblFolBaudRate";
            this.lblFolBaudRate.Size = new System.Drawing.Size(89, 12);
            this.lblFolBaudRate.TabIndex = 58;
            this.lblFolBaudRate.Text = "设置波特率为：";
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
            // lblFolDeviceAddress
            // 
            this.lblFolDeviceAddress.AutoSize = true;
            this.lblFolDeviceAddress.Location = new System.Drawing.Point(281, 26);
            this.lblFolDeviceAddress.Name = "lblFolDeviceAddress";
            this.lblFolDeviceAddress.Size = new System.Drawing.Size(101, 12);
            this.lblFolDeviceAddress.TabIndex = 54;
            this.lblFolDeviceAddress.Text = "设置设备地址为：";
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
            // PoisonGass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 510);
            this.Controls.Add(this.panelEx1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PoisonGass";
            this.Text = "硫化氢、氨气及一氧化碳";
            this.Load += new System.EventHandler(this.PoisonGass_Load);
            this.panelEx1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolBaudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolDeviceAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreBaudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreDeviceAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCO2Concentration;
        private System.Windows.Forms.Label lblFolBaudRate;
        private System.Windows.Forms.Label lblPreBaudRate;
        private System.Windows.Forms.Label lblFolDeviceAddress;
        private System.Windows.Forms.Label lblPreDeviceAddress;
        private DevComponents.Editors.IntegerInput txtFolBaudRate;
        private DevComponents.Editors.IntegerInput txtFolDeviceAddress;
        private DevComponents.Editors.IntegerInput txtPreBaudRate;
        private DevComponents.Editors.IntegerInput txtPreDeviceAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCO2Concentration;


    }
}