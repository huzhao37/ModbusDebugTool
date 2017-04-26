namespace ModbusDebugTool
{
    partial class SensorCommonSet
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.lstReceiveData = new System.Windows.Forms.ListBox();
            this.cbDeviceAddress = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTimeX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 23);
            this.btnClear.TabIndex = 107;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(17, 113);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(56, 23);
            this.btnShow.TabIndex = 106;
            this.btnShow.Text = "hex显示";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(15, 46);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(135, 12);
            this.label30.TabIndex = 105;
            this.label30.Text = "返回的数据如下所示：";
            // 
            // lstReceiveData
            // 
            this.lstReceiveData.FormattingEnabled = true;
            this.lstReceiveData.ItemHeight = 12;
            this.lstReceiveData.Location = new System.Drawing.Point(17, 149);
            this.lstReceiveData.Name = "lstReceiveData";
            this.lstReceiveData.Size = new System.Drawing.Size(133, 256);
            this.lstReceiveData.TabIndex = 104;
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
            "05"});
            this.cbDeviceAddress.Location = new System.Drawing.Point(70, -51);
            this.cbDeviceAddress.Name = "cbDeviceAddress";
            this.cbDeviceAddress.Size = new System.Drawing.Size(121, 20);
            this.cbDeviceAddress.TabIndex = 103;
            this.cbDeviceAddress.Text = "01";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(68, -84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 12);
            this.label12.TabIndex = 102;
            this.label12.Text = "请选择当前的设备地址：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(105, 437);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 12);
            this.label24.TabIndex = 110;
            this.label24.Text = "（100ms）";
            // 
            // txtTimeX
            // 
            this.txtTimeX.Location = new System.Drawing.Point(54, 434);
            this.txtTimeX.Name = "txtTimeX";
            this.txtTimeX.Size = new System.Drawing.Size(45, 21);
            this.txtTimeX.TabIndex = 109;
            this.txtTimeX.TextChanged += new System.EventHandler(this.txtTimeX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 108;
            this.label1.Text = "定时：";
            // 
            // SensorCommonSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 475);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtTimeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lstReceiveData);
            this.Controls.Add(this.cbDeviceAddress);
            this.Controls.Add(this.label12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SensorCommonSet";
            this.Text = "传感器配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ListBox lstReceiveData;
        private System.Windows.Forms.ComboBox cbDeviceAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtTimeX;
        private System.Windows.Forms.Label label1;
    }
}