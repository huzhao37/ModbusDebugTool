namespace ModbusDebugTool
{
    partial class DIManageWindow
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
            this.btnGetAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbOff3 = new System.Windows.Forms.RadioButton();
            this.rbOn3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbOff2 = new System.Windows.Forms.RadioButton();
            this.rbOn2 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbOff4 = new System.Windows.Forms.RadioButton();
            this.rbOn4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOn1 = new System.Windows.Forms.RadioButton();
            this.rbOff1 = new System.Windows.Forms.RadioButton();
            this.btnReadCount4 = new System.Windows.Forms.Button();
            this.btnReadCount3 = new System.Windows.Forms.Button();
            this.btnReadCount2 = new System.Windows.Forms.Button();
            this.btnReadCount1 = new System.Windows.Forms.Button();
            this.txtCount4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCount3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCount2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCount1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelEx1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.button1);
            this.panelEx1.Controls.Add(this.button2);
            this.panelEx1.Controls.Add(this.button3);
            this.panelEx1.Controls.Add(this.button4);
            this.panelEx1.Controls.Add(this.btnGetAll);
            this.panelEx1.Controls.Add(this.panel3);
            this.panelEx1.Controls.Add(this.panel2);
            this.panelEx1.Controls.Add(this.panel4);
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Controls.Add(this.btnReadCount4);
            this.panelEx1.Controls.Add(this.btnReadCount3);
            this.panelEx1.Controls.Add(this.btnReadCount2);
            this.panelEx1.Controls.Add(this.btnReadCount1);
            this.panelEx1.Controls.Add(this.txtCount4);
            this.panelEx1.Controls.Add(this.label10);
            this.panelEx1.Controls.Add(this.txtCount3);
            this.panelEx1.Controls.Add(this.label9);
            this.panelEx1.Controls.Add(this.label8);
            this.panelEx1.Controls.Add(this.txtCount2);
            this.panelEx1.Controls.Add(this.label6);
            this.panelEx1.Controls.Add(this.label5);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.label7);
            this.panelEx1.Controls.Add(this.txtCount1);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(929, 456);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(409, 364);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(154, 23);
            this.btnGetAll.TabIndex = 198;
            this.btnGetAll.Text = "获取当前所有计数";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbOff3);
            this.panel3.Controls.Add(this.rbOn3);
            this.panel3.Location = new System.Drawing.Point(592, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 31);
            this.panel3.TabIndex = 197;
            // 
            // rbOff3
            // 
            this.rbOff3.AutoSize = true;
            this.rbOff3.Location = new System.Drawing.Point(3, 9);
            this.rbOff3.Name = "rbOff3";
            this.rbOff3.Size = new System.Drawing.Size(47, 16);
            this.rbOff3.TabIndex = 14;
            this.rbOff3.Text = "断开";
            this.rbOff3.UseVisualStyleBackColor = true;
            // 
            // rbOn3
            // 
            this.rbOn3.AutoSize = true;
            this.rbOn3.Location = new System.Drawing.Point(59, 7);
            this.rbOn3.Name = "rbOn3";
            this.rbOn3.Size = new System.Drawing.Size(47, 16);
            this.rbOn3.TabIndex = 15;
            this.rbOn3.Text = "闭合";
            this.rbOn3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbOff2);
            this.panel2.Controls.Add(this.rbOn2);
            this.panel2.Location = new System.Drawing.Point(592, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 31);
            this.panel2.TabIndex = 195;
            // 
            // rbOff2
            // 
            this.rbOff2.AutoSize = true;
            this.rbOff2.Location = new System.Drawing.Point(6, 7);
            this.rbOff2.Name = "rbOff2";
            this.rbOff2.Size = new System.Drawing.Size(47, 16);
            this.rbOff2.TabIndex = 11;
            this.rbOff2.Text = "断开";
            this.rbOff2.UseVisualStyleBackColor = true;
            // 
            // rbOn2
            // 
            this.rbOn2.AutoSize = true;
            this.rbOn2.Location = new System.Drawing.Point(59, 8);
            this.rbOn2.Name = "rbOn2";
            this.rbOn2.Size = new System.Drawing.Size(47, 16);
            this.rbOn2.TabIndex = 12;
            this.rbOn2.Text = "闭合";
            this.rbOn2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbOff4);
            this.panel4.Controls.Add(this.rbOn4);
            this.panel4.Location = new System.Drawing.Point(592, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 31);
            this.panel4.TabIndex = 196;
            // 
            // rbOff4
            // 
            this.rbOff4.AutoSize = true;
            this.rbOff4.Location = new System.Drawing.Point(3, 7);
            this.rbOff4.Name = "rbOff4";
            this.rbOff4.Size = new System.Drawing.Size(47, 16);
            this.rbOff4.TabIndex = 17;
            this.rbOff4.Text = "断开";
            this.rbOff4.UseVisualStyleBackColor = true;
            // 
            // rbOn4
            // 
            this.rbOn4.AutoSize = true;
            this.rbOn4.Location = new System.Drawing.Point(59, 7);
            this.rbOn4.Name = "rbOn4";
            this.rbOn4.Size = new System.Drawing.Size(47, 16);
            this.rbOn4.TabIndex = 18;
            this.rbOn4.Text = "闭合";
            this.rbOn4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOn1);
            this.panel1.Controls.Add(this.rbOff1);
            this.panel1.Location = new System.Drawing.Point(592, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 31);
            this.panel1.TabIndex = 194;
            // 
            // rbOn1
            // 
            this.rbOn1.AutoSize = true;
            this.rbOn1.Cursor = System.Windows.Forms.Cursors.No;
            this.rbOn1.Location = new System.Drawing.Point(59, 9);
            this.rbOn1.Name = "rbOn1";
            this.rbOn1.Size = new System.Drawing.Size(47, 16);
            this.rbOn1.TabIndex = 11;
            this.rbOn1.Text = "闭合";
            this.rbOn1.UseVisualStyleBackColor = true;
            // 
            // rbOff1
            // 
            this.rbOff1.AutoSize = true;
            this.rbOff1.Location = new System.Drawing.Point(6, 8);
            this.rbOff1.Name = "rbOff1";
            this.rbOff1.Size = new System.Drawing.Size(47, 16);
            this.rbOff1.TabIndex = 10;
            this.rbOff1.Text = "断开";
            this.rbOff1.UseVisualStyleBackColor = true;
            // 
            // btnReadCount4
            // 
            this.btnReadCount4.Location = new System.Drawing.Point(379, 265);
            this.btnReadCount4.Name = "btnReadCount4";
            this.btnReadCount4.Size = new System.Drawing.Size(75, 23);
            this.btnReadCount4.TabIndex = 193;
            this.btnReadCount4.Text = "读取计数";
            this.btnReadCount4.UseVisualStyleBackColor = true;
            this.btnReadCount4.Click += new System.EventHandler(this.btnReadCount4_Click);
            // 
            // btnReadCount3
            // 
            this.btnReadCount3.Location = new System.Drawing.Point(379, 218);
            this.btnReadCount3.Name = "btnReadCount3";
            this.btnReadCount3.Size = new System.Drawing.Size(75, 23);
            this.btnReadCount3.TabIndex = 192;
            this.btnReadCount3.Text = "读取计数";
            this.btnReadCount3.UseVisualStyleBackColor = true;
            this.btnReadCount3.Click += new System.EventHandler(this.btnReadCount3_Click);
            // 
            // btnReadCount2
            // 
            this.btnReadCount2.Location = new System.Drawing.Point(379, 171);
            this.btnReadCount2.Name = "btnReadCount2";
            this.btnReadCount2.Size = new System.Drawing.Size(75, 23);
            this.btnReadCount2.TabIndex = 191;
            this.btnReadCount2.Text = "读取计数";
            this.btnReadCount2.UseVisualStyleBackColor = true;
            this.btnReadCount2.Click += new System.EventHandler(this.btnReadCount2_Click);
            // 
            // btnReadCount1
            // 
            this.btnReadCount1.Location = new System.Drawing.Point(379, 125);
            this.btnReadCount1.Name = "btnReadCount1";
            this.btnReadCount1.Size = new System.Drawing.Size(75, 23);
            this.btnReadCount1.TabIndex = 190;
            this.btnReadCount1.Text = "读取计数";
            this.btnReadCount1.UseVisualStyleBackColor = true;
            this.btnReadCount1.Click += new System.EventHandler(this.btnReadCount1_Click);
            // 
            // txtCount4
            // 
            this.txtCount4.Location = new System.Drawing.Point(296, 265);
            this.txtCount4.Name = "txtCount4";
            this.txtCount4.Size = new System.Drawing.Size(61, 21);
            this.txtCount4.TabIndex = 189;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 188;
            this.label10.Text = "第3路DI计数：";
            // 
            // txtCount3
            // 
            this.txtCount3.Location = new System.Drawing.Point(296, 218);
            this.txtCount3.Name = "txtCount3";
            this.txtCount3.Size = new System.Drawing.Size(61, 21);
            this.txtCount3.TabIndex = 186;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 187;
            this.label9.Text = "第4路DI计数：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 185;
            this.label8.Text = "第2路DI计数：";
            // 
            // txtCount2
            // 
            this.txtCount2.Location = new System.Drawing.Point(296, 174);
            this.txtCount2.Name = "txtCount2";
            this.txtCount2.Size = new System.Drawing.Size(61, 21);
            this.txtCount2.TabIndex = 184;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 182;
            this.label6.Text = "第4路DI状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 181;
            this.label5.Text = "第3路DI状态：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 180;
            this.label4.Text = "第2路DI状态：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 183;
            this.label7.Text = "第1路DI计数：";
            // 
            // txtCount1
            // 
            this.txtCount1.Location = new System.Drawing.Point(296, 125);
            this.txtCount1.Name = "txtCount1";
            this.txtCount1.Size = new System.Drawing.Size(61, 21);
            this.txtCount1.TabIndex = 179;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 178;
            this.label3.Text = "第1路DI状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(509, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 177;
            this.label2.Text = "输入寄存器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(200, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 176;
            this.label1.Text = "保持寄存器";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 202;
            this.button1.Text = "读取状态";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReadStatus4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 201;
            this.button2.Text = "读取状态";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReadStatus3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(733, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 200;
            this.button3.Text = "读取状态";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnReadStatus2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(733, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 199;
            this.button4.Text = "读取状态";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnReadStatus1_Click);
            // 
            // DIManageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 456);
            this.Controls.Add(this.panelEx1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DIManageWindow";
            this.Text = "DI管理";
            this.Load += new System.EventHandler(this.DIManageWindow_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbOff3;
        private System.Windows.Forms.RadioButton rbOn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbOff2;
        private System.Windows.Forms.RadioButton rbOn2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbOff4;
        private System.Windows.Forms.RadioButton rbOn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOn1;
        private System.Windows.Forms.RadioButton rbOff1;
        private System.Windows.Forms.Button btnReadCount4;
        private System.Windows.Forms.Button btnReadCount3;
        private System.Windows.Forms.Button btnReadCount2;
        private System.Windows.Forms.Button btnReadCount1;
        private System.Windows.Forms.TextBox txtCount4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCount3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCount2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCount1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}