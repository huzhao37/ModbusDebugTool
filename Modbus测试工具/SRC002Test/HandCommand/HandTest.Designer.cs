namespace ModbusDebugTool
{
    partial class HandTest
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
            this.txtTime = new System.Windows.Forms.NumericUpDown();
            this.lstReturnCommand = new System.Windows.Forms.ListBox();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.btnParity3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommand3 = new System.Windows.Forms.TextBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnParity2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommand2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.CheckBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnParity1 = new System.Windows.Forms.Button();
            this.lblPreBaudRate = new System.Windows.Forms.Label();
            this.lblPreDeviceAddress = new System.Windows.Forms.Label();
            this.txtCommand1 = new System.Windows.Forms.TextBox();
            this.panelEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
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
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.lstReturnCommand);
            this.panel1.Controls.Add(this.btnOpenLog);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnSend3);
            this.panel1.Controls.Add(this.btnParity3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCommand3);
            this.panel1.Controls.Add(this.btnSend2);
            this.panel1.Controls.Add(this.btnParity2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCommand2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTimer);
            this.panel1.Controls.Add(this.btnSend1);
            this.panel1.Controls.Add(this.btnParity1);
            this.panel1.Controls.Add(this.lblPreBaudRate);
            this.panel1.Controls.Add(this.lblPreDeviceAddress);
            this.panel1.Controls.Add(this.txtCommand1);
            this.panel1.Location = new System.Drawing.Point(95, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 408);
            this.panel1.TabIndex = 60;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Location = new System.Drawing.Point(481, 192);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(75, 26);
            this.txtTime.TabIndex = 5;
            this.txtTime.TabStop = false;
            this.txtTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lstReturnCommand
            // 
            this.lstReturnCommand.FormattingEnabled = true;
            this.lstReturnCommand.ItemHeight = 12;
            this.lstReturnCommand.Location = new System.Drawing.Point(117, 191);
            this.lstReturnCommand.Name = "lstReturnCommand";
            this.lstReturnCommand.Size = new System.Drawing.Size(238, 208);
            this.lstReturnCommand.TabIndex = 3;
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenLog.Location = new System.Drawing.Point(594, 299);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(87, 23);
            this.btnOpenLog.TabIndex = 85;
            this.btnOpenLog.Text = "打开日志";
            this.btnOpenLog.UseVisualStyleBackColor = true;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(594, 80);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 23);
            this.btnStop.TabIndex = 84;
            this.btnStop.Text = "关闭定时";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSend3
            // 
            this.btnSend3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend3.Location = new System.Drawing.Point(481, 136);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(75, 23);
            this.btnSend3.TabIndex = 83;
            this.btnSend3.Text = "发送";
            this.btnSend3.UseVisualStyleBackColor = true;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            // 
            // btnParity3
            // 
            this.btnParity3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParity3.Location = new System.Drawing.Point(371, 136);
            this.btnParity3.Name = "btnParity3";
            this.btnParity3.Size = new System.Drawing.Size(75, 23);
            this.btnParity3.TabIndex = 82;
            this.btnParity3.Text = "CRC校验";
            this.btnParity3.UseVisualStyleBackColor = true;
            this.btnParity3.Click += new System.EventHandler(this.btnParity3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "输入命令3：";
            // 
            // txtCommand3
            // 
            this.txtCommand3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCommand3.Location = new System.Drawing.Point(117, 136);
            this.txtCommand3.Name = "txtCommand3";
            this.txtCommand3.Size = new System.Drawing.Size(238, 26);
            this.txtCommand3.TabIndex = 2;
            // 
            // btnSend2
            // 
            this.btnSend2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend2.Location = new System.Drawing.Point(481, 80);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(75, 23);
            this.btnSend2.TabIndex = 78;
            this.btnSend2.Text = "发送";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // btnParity2
            // 
            this.btnParity2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParity2.Location = new System.Drawing.Point(371, 80);
            this.btnParity2.Name = "btnParity2";
            this.btnParity2.Size = new System.Drawing.Size(75, 23);
            this.btnParity2.TabIndex = 77;
            this.btnParity2.Text = "CRC校验";
            this.btnParity2.UseVisualStyleBackColor = true;
            this.btnParity2.Click += new System.EventHandler(this.btnParity2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "输入命令2：";
            // 
            // txtCommand2
            // 
            this.txtCommand2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCommand2.Location = new System.Drawing.Point(117, 80);
            this.txtCommand2.Name = "txtCommand2";
            this.txtCommand2.Size = new System.Drawing.Size(238, 26);
            this.txtCommand2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(371, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 23);
            this.btnClear.TabIndex = 74;
            this.btnClear.Text = "清空窗口";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "*100ms";
            // 
            // cbTimer
            // 
            this.cbTimer.AutoSize = true;
            this.cbTimer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTimer.Location = new System.Drawing.Point(371, 197);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(59, 20);
            this.cbTimer.TabIndex = 4;
            this.cbTimer.Text = "定时";
            this.cbTimer.UseVisualStyleBackColor = true;
            // 
            // btnSend1
            // 
            this.btnSend1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend1.Location = new System.Drawing.Point(481, 23);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(75, 23);
            this.btnSend1.TabIndex = 69;
            this.btnSend1.Text = "发送";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // btnParity1
            // 
            this.btnParity1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParity1.Location = new System.Drawing.Point(371, 23);
            this.btnParity1.Name = "btnParity1";
            this.btnParity1.Size = new System.Drawing.Size(75, 23);
            this.btnParity1.TabIndex = 68;
            this.btnParity1.Text = "CRC校验";
            this.btnParity1.UseVisualStyleBackColor = true;
            this.btnParity1.Click += new System.EventHandler(this.btnParity1_Click);
            // 
            // lblPreBaudRate
            // 
            this.lblPreBaudRate.AutoSize = true;
            this.lblPreBaudRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPreBaudRate.Location = new System.Drawing.Point(15, 194);
            this.lblPreBaudRate.Name = "lblPreBaudRate";
            this.lblPreBaudRate.Size = new System.Drawing.Size(88, 16);
            this.lblPreBaudRate.TabIndex = 56;
            this.lblPreBaudRate.Text = "返回命令：";
            // 
            // lblPreDeviceAddress
            // 
            this.lblPreDeviceAddress.AutoSize = true;
            this.lblPreDeviceAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPreDeviceAddress.Location = new System.Drawing.Point(15, 26);
            this.lblPreDeviceAddress.Name = "lblPreDeviceAddress";
            this.lblPreDeviceAddress.Size = new System.Drawing.Size(96, 16);
            this.lblPreDeviceAddress.TabIndex = 52;
            this.lblPreDeviceAddress.Text = "输入命令1：";
            // 
            // txtCommand1
            // 
            this.txtCommand1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCommand1.Location = new System.Drawing.Point(117, 23);
            this.txtCommand1.Name = "txtCommand1";
            this.txtCommand1.Size = new System.Drawing.Size(238, 26);
            this.txtCommand1.TabIndex = 0;
            // 
            // HandTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 510);
            this.Controls.Add(this.panelEx1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HandTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "手动测试";
            this.Load += new System.EventHandler(this.HandTest_Load);
            this.panelEx1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtTime;
        private System.Windows.Forms.ListBox lstReturnCommand;
        private System.Windows.Forms.Button btnOpenLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.Button btnParity3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCommand3;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button btnParity2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommand2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTimer;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnParity1;
        private System.Windows.Forms.Label lblPreBaudRate;
        private System.Windows.Forms.Label lblPreDeviceAddress;
        private System.Windows.Forms.TextBox txtCommand1;

    }
}