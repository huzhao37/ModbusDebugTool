namespace SRC0002Test
{
    partial class SRC0002
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSendData = new System.Windows.Forms.Label();
            this.lblReceiveData = new System.Windows.Forms.Label();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.lstReceiveData = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.cbSelectMode = new System.Windows.Forms.ComboBox();
            this.lblSelectMode = new System.Windows.Forms.Label();
            this.lblSelectOnOrOff = new System.Windows.Forms.Label();
            this.cbOnOrOff = new System.Windows.Forms.ComboBox();
            this.cbReadRegNum = new System.Windows.Forms.ComboBox();
            this.lblReadRegNuM = new System.Windows.Forms.Label();
            this.lblStartRegAddress = new System.Windows.Forms.Label();
            this.cbStartRegAddress = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbDeviceAddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.funcPanel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFirst = new System.Windows.Forms.ComboBox();
            this.cbSecond = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbThird = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFourth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFifth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSixth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSenven = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEighth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtThird = new System.Windows.Forms.TextBox();
            this.txtFourth = new System.Windows.Forms.TextBox();
            this.txtFifth = new System.Windows.Forms.TextBox();
            this.txtSixth = new System.Windows.Forms.TextBox();
            this.txtSeven = new System.Windows.Forms.TextBox();
            this.txtEight = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbSetBaudRate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.funcPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSendData
            // 
            this.lblSendData.AutoSize = true;
            this.lblSendData.Location = new System.Drawing.Point(497, 41);
            this.lblSendData.Name = "lblSendData";
            this.lblSendData.Size = new System.Drawing.Size(53, 12);
            this.lblSendData.TabIndex = 4;
            this.lblSendData.Text = "发送数据";
            // 
            // lblReceiveData
            // 
            this.lblReceiveData.AutoSize = true;
            this.lblReceiveData.Location = new System.Drawing.Point(654, 44);
            this.lblReceiveData.Name = "lblReceiveData";
            this.lblReceiveData.Size = new System.Drawing.Size(53, 12);
            this.lblReceiveData.TabIndex = 5;
            this.lblReceiveData.Text = "接收数据";
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(499, 70);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(145, 21);
            this.txtSendData.TabIndex = 13;
            // 
            // lstReceiveData
            // 
            this.lstReceiveData.FormattingEnabled = true;
            this.lstReceiveData.ItemHeight = 12;
            this.lstReceiveData.Location = new System.Drawing.Point(650, 70);
            this.lstReceiveData.Name = "lstReceiveData";
            this.lstReceiveData.Size = new System.Drawing.Size(169, 388);
            this.lstReceiveData.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(522, 121);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(522, 171);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 20;
            this.btnReceive.Text = "接收";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // cbSelectMode
            // 
            this.cbSelectMode.FormattingEnabled = true;
            this.cbSelectMode.Items.AddRange(new object[] {
            "第1路工作模式",
            "第2路工作模式",
            "第3路工作模式",
            "第4路工作模式",
            "第5路工作模式",
            "第6路工作模式",
            "第7路工作模式",
            "第8路工作模式"});
            this.cbSelectMode.Location = new System.Drawing.Point(347, 38);
            this.cbSelectMode.Name = "cbSelectMode";
            this.cbSelectMode.Size = new System.Drawing.Size(124, 20);
            this.cbSelectMode.TabIndex = 21;
            this.cbSelectMode.Text = "第1路工作模式";
            // 
            // lblSelectMode
            // 
            this.lblSelectMode.AutoSize = true;
            this.lblSelectMode.Location = new System.Drawing.Point(243, 44);
            this.lblSelectMode.Name = "lblSelectMode";
            this.lblSelectMode.Size = new System.Drawing.Size(89, 12);
            this.lblSelectMode.TabIndex = 22;
            this.lblSelectMode.Text = "选择工作模式：";
            // 
            // lblSelectOnOrOff
            // 
            this.lblSelectOnOrOff.AutoSize = true;
            this.lblSelectOnOrOff.Location = new System.Drawing.Point(243, 96);
            this.lblSelectOnOrOff.Name = "lblSelectOnOrOff";
            this.lblSelectOnOrOff.Size = new System.Drawing.Size(53, 12);
            this.lblSelectOnOrOff.TabIndex = 23;
            this.lblSelectOnOrOff.Text = "开  关：";
            // 
            // cbOnOrOff
            // 
            this.cbOnOrOff.FormattingEnabled = true;
            this.cbOnOrOff.Items.AddRange(new object[] {
            "开",
            "关"});
            this.cbOnOrOff.Location = new System.Drawing.Point(347, 88);
            this.cbOnOrOff.Name = "cbOnOrOff";
            this.cbOnOrOff.Size = new System.Drawing.Size(124, 20);
            this.cbOnOrOff.TabIndex = 24;
            this.cbOnOrOff.Text = "开";
            // 
            // cbReadRegNum
            // 
            this.cbReadRegNum.FormattingEnabled = true;
            this.cbReadRegNum.Items.AddRange(new object[] {
            "0001",
            "0002",
            "0003",
            "0004",
            "0005",
            "0006",
            "0007",
            "0008"});
            this.cbReadRegNum.Location = new System.Drawing.Point(350, 179);
            this.cbReadRegNum.Name = "cbReadRegNum";
            this.cbReadRegNum.Size = new System.Drawing.Size(121, 20);
            this.cbReadRegNum.TabIndex = 29;
            this.cbReadRegNum.Text = "0001";
            // 
            // lblReadRegNuM
            // 
            this.lblReadRegNuM.AutoSize = true;
            this.lblReadRegNuM.Location = new System.Drawing.Point(243, 182);
            this.lblReadRegNuM.Name = "lblReadRegNuM";
            this.lblReadRegNuM.Size = new System.Drawing.Size(101, 12);
            this.lblReadRegNuM.TabIndex = 30;
            this.lblReadRegNuM.Text = "读取的寄存器数：";
            // 
            // lblStartRegAddress
            // 
            this.lblStartRegAddress.AutoSize = true;
            this.lblStartRegAddress.Location = new System.Drawing.Point(243, 132);
            this.lblStartRegAddress.Name = "lblStartRegAddress";
            this.lblStartRegAddress.Size = new System.Drawing.Size(101, 12);
            this.lblStartRegAddress.TabIndex = 31;
            this.lblStartRegAddress.Text = "起始寄存器地址：";
            // 
            // cbStartRegAddress
            // 
            this.cbStartRegAddress.FormattingEnabled = true;
            this.cbStartRegAddress.Items.AddRange(new object[] {
            "0000",
            "0001",
            "0002",
            "0003",
            "0004",
            "0005",
            "0006",
            "0007",
            "0008",
            "0009",
            "000A",
            "000B",
            "000C",
            "000D",
            "000E",
            "000F",
            "0010",
            "0011",
            "0012",
            "0013",
            "0014",
            "0015",
            "0016",
            "0017",
            "0018",
            "0019",
            "001A",
            "001B",
            "001C",
            "001D",
            "001E",
            "001F",
            "0020",
            "0021",
            "0022",
            "0023",
            "0024",
            "0025",
            "0026",
            "0027"});
            this.cbStartRegAddress.Location = new System.Drawing.Point(350, 124);
            this.cbStartRegAddress.Name = "cbStartRegAddress";
            this.cbStartRegAddress.Size = new System.Drawing.Size(121, 20);
            this.cbStartRegAddress.TabIndex = 32;
            this.cbStartRegAddress.Text = "0000";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
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
            this.cbDeviceAddress.Location = new System.Drawing.Point(3, 131);
            this.cbDeviceAddress.Name = "cbDeviceAddress";
            this.cbDeviceAddress.Size = new System.Drawing.Size(121, 20);
            this.cbDeviceAddress.TabIndex = 28;
            this.cbDeviceAddress.Text = "01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "请选择设备地址：";
            // 
            // cbFunction
            // 
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Items.AddRange(new object[] {
            "读可读写数字量寄存器（DI状态）",
            "读只读数字量寄存器（输入状态）",
            "读可读写数字量寄存器（保持寄存器）",
            "读只可读模拟量寄存器（输入寄存器）",
            "写数字量（DO单个开关）",
            "写单个模拟量寄存器（保持寄存器）",
            "写数字量（DO多路开关）",
            "写模拟量（AI多路状态）"});
            this.cbFunction.Location = new System.Drawing.Point(3, 53);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(185, 20);
            this.cbFunction.TabIndex = 26;
            this.cbFunction.Text = "写数字量（DO单个开关）";
            // 
            // lblFunction
            // 
            this.lblFunction.Location = new System.Drawing.Point(3, 6);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(98, 30);
            this.lblFunction.TabIndex = 25;
            this.lblFunction.Text = "选择你所需要的功能：";
            // 
            // funcPanel2
            // 
            this.funcPanel2.Controls.Add(this.lblFunction);
            this.funcPanel2.Controls.Add(this.cbFunction);
            this.funcPanel2.Controls.Add(this.label1);
            this.funcPanel2.Controls.Add(this.cbDeviceAddress);
            this.funcPanel2.Location = new System.Drawing.Point(12, 43);
            this.funcPanel2.Name = "funcPanel2";
            this.funcPanel2.Size = new System.Drawing.Size(194, 156);
            this.funcPanel2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "第一路开关：";
            // 
            // cbFirst
            // 
            this.cbFirst.FormattingEnabled = true;
            this.cbFirst.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cbFirst.Location = new System.Drawing.Point(245, 296);
            this.cbFirst.Name = "cbFirst";
            this.cbFirst.Size = new System.Drawing.Size(51, 20);
            this.cbFirst.TabIndex = 36;
            this.cbFirst.Text = "开";
            // 
            // cbSecond
            // 
            this.cbSecond.FormattingEnabled = true;
            this.cbSecond.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cbSecond.Location = new System.Drawing.Point(328, 296);
            this.cbSecond.Name = "cbSecond";
            this.cbSecond.Size = new System.Drawing.Size(51, 20);
            this.cbSecond.TabIndex = 38;
            this.cbSecond.Text = "开";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "第二路开关：";
            // 
            // cbThird
            // 
            this.cbThird.FormattingEnabled = true;
            this.cbThird.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cbThird.Location = new System.Drawing.Point(411, 296);
            this.cbThird.Name = "cbThird";
            this.cbThird.Size = new System.Drawing.Size(51, 20);
            this.cbThird.TabIndex = 40;
            this.cbThird.Text = "开";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "第三路开关：";
            // 
            // cbFourth
            // 
            this.cbFourth.FormattingEnabled = true;
            this.cbFourth.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cbFourth.Location = new System.Drawing.Point(494, 296);
            this.cbFourth.Name = "cbFourth";
            this.cbFourth.Size = new System.Drawing.Size(51, 20);
            this.cbFourth.TabIndex = 42;
            this.cbFourth.Text = "开";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "第四路开关：";
            // 
            // cbFifth
            // 
            this.cbFifth.FormattingEnabled = true;
            this.cbFifth.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cbFifth.Location = new System.Drawing.Point(245, 381);
            this.cbFifth.Name = "cbFifth";
            this.cbFifth.Size = new System.Drawing.Size(51, 20);
            this.cbFifth.TabIndex = 44;
            this.cbFifth.Text = "开";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 43;
            this.label6.Text = "第五路开关：";
            // 
            // cbSixth
            // 
            this.cbSixth.FormattingEnabled = true;
            this.cbSixth.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cbSixth.Location = new System.Drawing.Point(328, 381);
            this.cbSixth.Name = "cbSixth";
            this.cbSixth.Size = new System.Drawing.Size(51, 20);
            this.cbSixth.TabIndex = 46;
            this.cbSixth.Text = "开";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 45;
            this.label7.Text = "第六路开关：";
            // 
            // cbSenven
            // 
            this.cbSenven.FormattingEnabled = true;
            this.cbSenven.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cbSenven.Location = new System.Drawing.Point(411, 381);
            this.cbSenven.Name = "cbSenven";
            this.cbSenven.Size = new System.Drawing.Size(51, 20);
            this.cbSenven.TabIndex = 48;
            this.cbSenven.Text = "开";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 47;
            this.label8.Text = "第七路开关：";
            // 
            // cbEighth
            // 
            this.cbEighth.FormattingEnabled = true;
            this.cbEighth.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cbEighth.Location = new System.Drawing.Point(494, 381);
            this.cbEighth.Name = "cbEighth";
            this.cbEighth.Size = new System.Drawing.Size(51, 20);
            this.cbEighth.TabIndex = 50;
            this.cbEighth.Text = "开";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 49;
            this.label9.Text = "第八路开关：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 51;
            this.label10.Text = "第一路数据：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 52;
            this.label11.Text = "第二路数据：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 53;
            this.label12.Text = "第三路数据：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(98, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 54;
            this.label13.Text = "第四路数据：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 55;
            this.label14.Text = "第五路数据：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(98, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 56;
            this.label15.Text = "第六路数据：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 57;
            this.label16.Text = "第七路数据：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(98, 439);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 12);
            this.label17.TabIndex = 58;
            this.label17.Text = "第八路数据：";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(15, 283);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(62, 21);
            this.txtFirst.TabIndex = 59;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(100, 283);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(62, 21);
            this.txtSecond.TabIndex = 60;
            // 
            // txtThird
            // 
            this.txtThird.Location = new System.Drawing.Point(12, 342);
            this.txtThird.Name = "txtThird";
            this.txtThird.Size = new System.Drawing.Size(62, 21);
            this.txtThird.TabIndex = 61;
            // 
            // txtFourth
            // 
            this.txtFourth.Location = new System.Drawing.Point(100, 342);
            this.txtFourth.Name = "txtFourth";
            this.txtFourth.Size = new System.Drawing.Size(62, 21);
            this.txtFourth.TabIndex = 62;
            // 
            // txtFifth
            // 
            this.txtFifth.Location = new System.Drawing.Point(12, 399);
            this.txtFifth.Name = "txtFifth";
            this.txtFifth.Size = new System.Drawing.Size(62, 21);
            this.txtFifth.TabIndex = 63;
            // 
            // txtSixth
            // 
            this.txtSixth.Location = new System.Drawing.Point(100, 399);
            this.txtSixth.Name = "txtSixth";
            this.txtSixth.Size = new System.Drawing.Size(62, 21);
            this.txtSixth.TabIndex = 64;
            // 
            // txtSeven
            // 
            this.txtSeven.Location = new System.Drawing.Point(12, 454);
            this.txtSeven.Name = "txtSeven";
            this.txtSeven.Size = new System.Drawing.Size(62, 21);
            this.txtSeven.TabIndex = 65;
            // 
            // txtEight
            // 
            this.txtEight.Location = new System.Drawing.Point(100, 454);
            this.txtEight.Name = "txtEight";
            this.txtEight.Size = new System.Drawing.Size(62, 21);
            this.txtEight.TabIndex = 66;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(209, 12);
            this.label18.TabIndex = 67;
            this.label18.Text = "*请输入十六进制数据（形如：0000）*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(243, 228);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 68;
            this.label19.Text = "数字量计数：";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(328, 225);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(75, 21);
            this.txtCount.TabIndex = 69;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(418, 228);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 12);
            this.label20.TabIndex = 70;
            this.label20.Text = "设置波特率为：";
            // 
            // cbSetBaudRate
            // 
            this.cbSetBaudRate.FormattingEnabled = true;
            this.cbSetBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "11520"});
            this.cbSetBaudRate.Location = new System.Drawing.Point(499, 226);
            this.cbSetBaudRate.Name = "cbSetBaudRate";
            this.cbSetBaudRate.Size = new System.Drawing.Size(75, 20);
            this.cbSetBaudRate.TabIndex = 71;
            this.cbSetBaudRate.Text = "9600";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 72;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SRC0002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSetBaudRate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtEight);
            this.Controls.Add(this.txtSeven);
            this.Controls.Add(this.txtSixth);
            this.Controls.Add(this.txtFifth);
            this.Controls.Add(this.txtFourth);
            this.Controls.Add(this.txtThird);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbEighth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSenven);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSixth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFifth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFourth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbThird);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.funcPanel2);
            this.Controls.Add(this.cbStartRegAddress);
            this.Controls.Add(this.lblStartRegAddress);
            this.Controls.Add(this.lblReadRegNuM);
            this.Controls.Add(this.cbReadRegNum);
            this.Controls.Add(this.cbOnOrOff);
            this.Controls.Add(this.lblSelectOnOrOff);
            this.Controls.Add(this.lblSelectMode);
            this.Controls.Add(this.cbSelectMode);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstReceiveData);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.lblReceiveData);
            this.Controls.Add(this.lblSendData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SRC0002";
            this.Text = "SRC0002Test";
            this.funcPanel2.ResumeLayout(false);
            this.funcPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSendData;
        private System.Windows.Forms.Label lblReceiveData;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.ListBox lstReceiveData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.ComboBox cbSelectMode;
        private System.Windows.Forms.Label lblSelectMode;
        private System.Windows.Forms.Label lblSelectOnOrOff;
        private System.Windows.Forms.ComboBox cbOnOrOff;
        private System.Windows.Forms.ComboBox cbReadRegNum;
        private System.Windows.Forms.Label lblReadRegNuM;
        private System.Windows.Forms.Label lblStartRegAddress;
        private System.Windows.Forms.ComboBox cbStartRegAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cbDeviceAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Panel funcPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFirst;
        private System.Windows.Forms.ComboBox cbSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbThird;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFourth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFifth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSixth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSenven;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEighth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtThird;
        private System.Windows.Forms.TextBox txtFourth;
        private System.Windows.Forms.TextBox txtFifth;
        private System.Windows.Forms.TextBox txtSixth;
        private System.Windows.Forms.TextBox txtSeven;
        private System.Windows.Forms.TextBox txtEight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbSetBaudRate;
        private System.Windows.Forms.Button button1;
    }
}

