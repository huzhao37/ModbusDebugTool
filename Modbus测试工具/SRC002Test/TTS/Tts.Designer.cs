namespace ModbusDebugTool.TTS
{
    partial class Tts
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
            this.txtInfo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.txtTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.CheckBox();
            this.btnStop = new DevComponents.DotNetBar.ButtonX();
            this.lblMessage = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.lblMessage);
            this.panelEx1.Controls.Add(this.btnStop);
            this.panelEx1.Controls.Add(this.txtTime);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.cbTimer);
            this.panelEx1.Controls.Add(this.btnSend);
            this.panelEx1.Controls.Add(this.txtInfo);
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
            // txtInfo
            // 
            // 
            // 
            // 
            this.txtInfo.Border.Class = "TextBoxBorder";
            this.txtInfo.Location = new System.Drawing.Point(219, 75);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(436, 206);
            this.txtInfo.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(453, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 33);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Location = new System.Drawing.Point(674, 221);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(75, 26);
            this.txtTime.TabIndex = 86;
            this.txtTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 87;
            this.label1.Text = "*100ms";
            // 
            // cbTimer
            // 
            this.cbTimer.AutoSize = true;
            this.cbTimer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTimer.Location = new System.Drawing.Point(674, 175);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(59, 20);
            this.cbTimer.TabIndex = 85;
            this.cbTimer.Text = "定时";
            this.cbTimer.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(293, 310);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 33);
            this.btnStop.TabIndex = 88;
            this.btnStop.Text = "关闭定时";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(219, 403);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(340, 23);
            this.lblMessage.TabIndex = 89;
            // 
            // Tts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 438);
            this.Controls.Add(this.panelEx1);
            this.Name = "Tts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tts";
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInfo;
        private DevComponents.DotNetBar.ButtonX btnSend;
        private DevComponents.DotNetBar.ButtonX btnStop;
        private System.Windows.Forms.NumericUpDown txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTimer;
        private DevComponents.DotNetBar.LabelX lblMessage;
    }
}