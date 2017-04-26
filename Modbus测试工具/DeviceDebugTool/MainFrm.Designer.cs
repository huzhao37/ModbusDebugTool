namespace DeviceDebugTool
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("读写线圈");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("设置组合");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("设置工作和延迟");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SRC0001", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("AI");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("DI");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("DO");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("读写线圈");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("SRC0002", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel18 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel57 = new MetroFramework.Controls.MetroLabel();
            this.cbTimer1 = new System.Windows.Forms.CheckBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnOpenLog = new MetroFramework.Controls.MetroButton();
            this.btnSend2 = new MetroFramework.Controls.MetroButton();
            this.btnSend3 = new MetroFramework.Controls.MetroButton();
            this.btnSend1 = new MetroFramework.Controls.MetroButton();
            this.btnParity2 = new MetroFramework.Controls.MetroButton();
            this.btnParity3 = new MetroFramework.Controls.MetroButton();
            this.btnParity1 = new MetroFramework.Controls.MetroButton();
            this.txtCommand3 = new MetroFramework.Controls.MetroTextBox();
            this.txtCommand2 = new MetroFramework.Controls.MetroTextBox();
            this.txtCommand1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel56 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel55 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel54 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel53 = new MetroFramework.Controls.MetroLabel();
            this.txtTime1 = new System.Windows.Forms.NumericUpDown();
            this.lstReturnCommand = new System.Windows.Forms.ListBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel52 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel51 = new MetroFramework.Controls.MetroLabel();
            this.txtTimeOut = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new MetroFramework.Controls.MetroPanel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new MetroFramework.Controls.MetroPanel();
            this.cbSerialName = new MetroFramework.Controls.MetroComboBox();
            this.cbBaudRate = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.rbtN = new MetroFramework.Controls.MetroRadioButton();
            this.rbtS = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel23 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel25 = new MetroFramework.Controls.MetroPanel();
            this.seacherPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel50 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel48 = new MetroFramework.Controls.MetroLabel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.txtEnd = new MetroFramework.Controls.MetroTextBox();
            this.txtStart = new MetroFramework.Controls.MetroTextBox();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.cacl = new MetroFramework.Controls.MetroPanel();
            this.metroPanel19 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel22 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel21 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel20 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel17 = new MetroFramework.Controls.MetroPanel();
            this.btnmAValue = new MetroFramework.Controls.MetroButton();
            this.metroLabel46 = new MetroFramework.Controls.MetroLabel();
            this.cbReg = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel44 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel45 = new MetroFramework.Controls.MetroLabel();
            this.txtCollectAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel49 = new MetroFramework.Controls.MetroLabel();
            this.txtCollectValue = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOnOrOff20 = new System.Windows.Forms.Button();
            this.btnOnOrOff19 = new System.Windows.Forms.Button();
            this.cbOnOrOff20 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff19 = new System.Windows.Forms.ComboBox();
            this.btnOnOrOff18 = new System.Windows.Forms.Button();
            this.btnOnOrOff17 = new System.Windows.Forms.Button();
            this.btnOnOrOff16 = new System.Windows.Forms.Button();
            this.btnOnOrOff15 = new System.Windows.Forms.Button();
            this.btnOnOrOff13 = new System.Windows.Forms.Button();
            this.btnOnOrOff14 = new System.Windows.Forms.Button();
            this.btnOnOrOff12 = new System.Windows.Forms.Button();
            this.btnOnOrOff11 = new System.Windows.Forms.Button();
            this.cbOnOrOff18 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff17 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff16 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff15 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff14 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff13 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff12 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff11 = new System.Windows.Forms.ComboBox();
            this.btnOnOrOff10 = new System.Windows.Forms.Button();
            this.btnOnOrOff9 = new System.Windows.Forms.Button();
            this.cbOnOrOff10 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff9 = new System.Windows.Forms.ComboBox();
            this.btnOnOrOff8 = new System.Windows.Forms.Button();
            this.btnOnOrOff7 = new System.Windows.Forms.Button();
            this.btnOnOrOff6 = new System.Windows.Forms.Button();
            this.btnOnOrOff5 = new System.Windows.Forms.Button();
            this.btnOnOrOff3 = new System.Windows.Forms.Button();
            this.btnOnOrOff4 = new System.Windows.Forms.Button();
            this.btnOnOrOff2 = new System.Windows.Forms.Button();
            this.btnOnOrOff1 = new System.Windows.Forms.Button();
            this.cbOnOrOff8 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff7 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff6 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff5 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff4 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff3 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff2 = new System.Windows.Forms.ComboBox();
            this.cbOnOrOff1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.metroTabPage9 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCombination20 = new System.Windows.Forms.Button();
            this.cbCombination20 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCombination19 = new System.Windows.Forms.Button();
            this.cbCombination19 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCombination9 = new System.Windows.Forms.Button();
            this.cbCombination9 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCombination8 = new System.Windows.Forms.Button();
            this.cbCombination8 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCombination18 = new System.Windows.Forms.Button();
            this.cbCombination18 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCombination17 = new System.Windows.Forms.Button();
            this.cbCombination17 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCombination16 = new System.Windows.Forms.Button();
            this.cbCombination16 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCombination15 = new System.Windows.Forms.Button();
            this.cbCombination15 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnCombination14 = new System.Windows.Forms.Button();
            this.cbCombination14 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnCombination13 = new System.Windows.Forms.Button();
            this.cbCombination13 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnCombination12 = new System.Windows.Forms.Button();
            this.cbCombination12 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnCombination11 = new System.Windows.Forms.Button();
            this.cbCombination11 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnCombination10 = new System.Windows.Forms.Button();
            this.cbCombination10 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnCombination7 = new System.Windows.Forms.Button();
            this.cbCombination7 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnCombination6 = new System.Windows.Forms.Button();
            this.cbCombination6 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnCombination5 = new System.Windows.Forms.Button();
            this.cbCombination5 = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.btnCombination4 = new System.Windows.Forms.Button();
            this.cbCombination4 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.btnCombination3 = new System.Windows.Forms.Button();
            this.cbCombination3 = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btnCombination2 = new System.Windows.Forms.Button();
            this.cbCombination2 = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.btnCombination1 = new System.Windows.Forms.Button();
            this.cbCombination1 = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.metroTabPage10 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.txtDelayTime13 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnDelay20 = new System.Windows.Forms.Button();
            this.btnDelay19 = new System.Windows.Forms.Button();
            this.txtDelayTime20 = new System.Windows.Forms.TextBox();
            this.txtDelayTime19 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.btnDelay18 = new System.Windows.Forms.Button();
            this.btnDelay17 = new System.Windows.Forms.Button();
            this.btnDelay16 = new System.Windows.Forms.Button();
            this.btnDelay15 = new System.Windows.Forms.Button();
            this.btnDelay13 = new System.Windows.Forms.Button();
            this.btnDelay14 = new System.Windows.Forms.Button();
            this.btnDelay12 = new System.Windows.Forms.Button();
            this.btnDelay11 = new System.Windows.Forms.Button();
            this.txtDelayTime18 = new System.Windows.Forms.TextBox();
            this.txtDelayTime17 = new System.Windows.Forms.TextBox();
            this.txtDelayTime16 = new System.Windows.Forms.TextBox();
            this.txtDelayTime15 = new System.Windows.Forms.TextBox();
            this.txtDelayTime14 = new System.Windows.Forms.TextBox();
            this.txtDelayTime12 = new System.Windows.Forms.TextBox();
            this.txtDelayTime11 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.btnDelay10 = new System.Windows.Forms.Button();
            this.btnDelay9 = new System.Windows.Forms.Button();
            this.txtDelayTime10 = new System.Windows.Forms.TextBox();
            this.txtDelayTime9 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.btnMode20 = new System.Windows.Forms.Button();
            this.btnMode19 = new System.Windows.Forms.Button();
            this.cbMode20 = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.cbMode19 = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.btnMode18 = new System.Windows.Forms.Button();
            this.btnMode17 = new System.Windows.Forms.Button();
            this.btnMode16 = new System.Windows.Forms.Button();
            this.btnMode15 = new System.Windows.Forms.Button();
            this.btnMode13 = new System.Windows.Forms.Button();
            this.btnMode14 = new System.Windows.Forms.Button();
            this.btnMode12 = new System.Windows.Forms.Button();
            this.btnMode11 = new System.Windows.Forms.Button();
            this.cbMode18 = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.cbMode17 = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.cbMode16 = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.cbMode15 = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.cbMode14 = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.cbMode13 = new System.Windows.Forms.ComboBox();
            this.label66 = new System.Windows.Forms.Label();
            this.cbMode12 = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.cbMode11 = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.btnMode10 = new System.Windows.Forms.Button();
            this.btnMode9 = new System.Windows.Forms.Button();
            this.cbMode10 = new System.Windows.Forms.ComboBox();
            this.label69 = new System.Windows.Forms.Label();
            this.cbMode9 = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.btnDelay8 = new System.Windows.Forms.Button();
            this.btnDelay7 = new System.Windows.Forms.Button();
            this.btnDelay6 = new System.Windows.Forms.Button();
            this.btnDelay5 = new System.Windows.Forms.Button();
            this.btnDelay3 = new System.Windows.Forms.Button();
            this.btnDelay4 = new System.Windows.Forms.Button();
            this.btnDelay2 = new System.Windows.Forms.Button();
            this.btnDelay1 = new System.Windows.Forms.Button();
            this.btnMode8 = new System.Windows.Forms.Button();
            this.btnMode7 = new System.Windows.Forms.Button();
            this.btnMode6 = new System.Windows.Forms.Button();
            this.btnMode5 = new System.Windows.Forms.Button();
            this.btnMode3 = new System.Windows.Forms.Button();
            this.btnMode4 = new System.Windows.Forms.Button();
            this.btnMode2 = new System.Windows.Forms.Button();
            this.btnMode1 = new System.Windows.Forms.Button();
            this.txtDelayTime8 = new System.Windows.Forms.TextBox();
            this.txtDelayTime7 = new System.Windows.Forms.TextBox();
            this.txtDelayTime6 = new System.Windows.Forms.TextBox();
            this.txtDelayTime5 = new System.Windows.Forms.TextBox();
            this.txtDelayTime4 = new System.Windows.Forms.TextBox();
            this.txtDelayTime3 = new System.Windows.Forms.TextBox();
            this.txtDelayTime2 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.txtDelayTime1 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.cbMode8 = new System.Windows.Forms.ComboBox();
            this.label81 = new System.Windows.Forms.Label();
            this.cbMode7 = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.cbMode6 = new System.Windows.Forms.ComboBox();
            this.label83 = new System.Windows.Forms.Label();
            this.cbMode5 = new System.Windows.Forms.ComboBox();
            this.label84 = new System.Windows.Forms.Label();
            this.cbMode4 = new System.Windows.Forms.ComboBox();
            this.label85 = new System.Windows.Forms.Label();
            this.cbMode3 = new System.Windows.Forms.ComboBox();
            this.label86 = new System.Windows.Forms.Label();
            this.cbMode2 = new System.Windows.Forms.ComboBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.cbMode1 = new System.Windows.Forms.ComboBox();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.metroTabPage11 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel9 = new MetroFramework.Controls.MetroPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnMarkAD8 = new System.Windows.Forms.Button();
            this.btnMarkAD7 = new System.Windows.Forms.Button();
            this.btnMarkAD6 = new System.Windows.Forms.Button();
            this.btnMarkAD5 = new System.Windows.Forms.Button();
            this.btnMarkAD4 = new System.Windows.Forms.Button();
            this.btnMarkAD3 = new System.Windows.Forms.Button();
            this.btnMarkAD2 = new System.Windows.Forms.Button();
            this.btnMarkAD1 = new System.Windows.Forms.Button();
            this.btnADExtent8 = new System.Windows.Forms.Button();
            this.cbADExtent8 = new System.Windows.Forms.ComboBox();
            this.label91 = new System.Windows.Forms.Label();
            this.btnADExtent7 = new System.Windows.Forms.Button();
            this.cbADExtent7 = new System.Windows.Forms.ComboBox();
            this.label92 = new System.Windows.Forms.Label();
            this.btnADExtent6 = new System.Windows.Forms.Button();
            this.cbADExtent6 = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.btnADExtent5 = new System.Windows.Forms.Button();
            this.cbADExtent5 = new System.Windows.Forms.ComboBox();
            this.label94 = new System.Windows.Forms.Label();
            this.btnADExtent4 = new System.Windows.Forms.Button();
            this.cbADExtent4 = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.btnADExtent3 = new System.Windows.Forms.Button();
            this.cbADExtent3 = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.btnADExtent2 = new System.Windows.Forms.Button();
            this.cbADExtent2 = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.btnADExtent1 = new System.Windows.Forms.Button();
            this.label98 = new System.Windows.Forms.Label();
            this.cbADExtent1 = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.cbCurrentMax8 = new System.Windows.Forms.ComboBox();
            this.cbCurrentMax7 = new System.Windows.Forms.ComboBox();
            this.cbCurrentMax6 = new System.Windows.Forms.ComboBox();
            this.cbCurrentMax5 = new System.Windows.Forms.ComboBox();
            this.cbCurrentMax4 = new System.Windows.Forms.ComboBox();
            this.cbCurrentMax3 = new System.Windows.Forms.ComboBox();
            this.cbCurrentMax2 = new System.Windows.Forms.ComboBox();
            this.btnCurrent8 = new System.Windows.Forms.Button();
            this.label100 = new System.Windows.Forms.Label();
            this.btnCurrent7 = new System.Windows.Forms.Button();
            this.label101 = new System.Windows.Forms.Label();
            this.btnCurrent6 = new System.Windows.Forms.Button();
            this.label102 = new System.Windows.Forms.Label();
            this.btnCurrent5 = new System.Windows.Forms.Button();
            this.label103 = new System.Windows.Forms.Label();
            this.btnCurrent4 = new System.Windows.Forms.Button();
            this.label104 = new System.Windows.Forms.Label();
            this.btnCurrent3 = new System.Windows.Forms.Button();
            this.label105 = new System.Windows.Forms.Label();
            this.btnCurrent2 = new System.Windows.Forms.Button();
            this.label106 = new System.Windows.Forms.Label();
            this.btnCurrent1 = new System.Windows.Forms.Button();
            this.label107 = new System.Windows.Forms.Label();
            this.cbCurrentMax1 = new System.Windows.Forms.ComboBox();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.metroTabPage12 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel10 = new MetroFramework.Controls.MetroPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbOff3 = new System.Windows.Forms.RadioButton();
            this.rbOn3 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbOff2 = new System.Windows.Forms.RadioButton();
            this.rbOn2 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbOn1 = new System.Windows.Forms.RadioButton();
            this.rbOff1 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rbOff4 = new System.Windows.Forms.RadioButton();
            this.rbOn4 = new System.Windows.Forms.RadioButton();
            this.btnReadCount4 = new System.Windows.Forms.Button();
            this.btnReadCount3 = new System.Windows.Forms.Button();
            this.btnReadCount2 = new System.Windows.Forms.Button();
            this.btnReadCount1 = new System.Windows.Forms.Button();
            this.txtCount4 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.txtCount3 = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.txtCount2 = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.txtCount1 = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.metroTabPage13 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel11 = new MetroFramework.Controls.MetroPanel();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label122 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label123 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label124 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label125 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label126 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label127 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label128 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label129 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.label130 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label131 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label132 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label133 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label134 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label135 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label136 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label137 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label148 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label149 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label150 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label151 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label152 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label153 = new System.Windows.Forms.Label();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.metroTabPage14 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel12 = new MetroFramework.Controls.MetroPanel();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label158 = new System.Windows.Forms.Label();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txtCmd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lstReceiveData = new System.Windows.Forms.ListBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel16 = new MetroFramework.Controls.MetroPanel();
            this.cbWeaFunction = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            this.btnWea = new MetroFramework.Controls.MetroButton();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel40 = new MetroFramework.Controls.MetroLabel();
            this.txtWeaPreAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel41 = new MetroFramework.Controls.MetroLabel();
            this.txtWeaFolAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel42 = new MetroFramework.Controls.MetroLabel();
            this.txtWeaPreBaudRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel43 = new MetroFramework.Controls.MetroLabel();
            this.txtWeaFolBaudRate = new MetroFramework.Controls.MetroTextBox();
            this.txtWeaValue = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel15 = new MetroFramework.Controls.MetroPanel();
            this.cbTempHumFuction = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.btnTempHum = new MetroFramework.Controls.MetroButton();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.txtTempHumPreAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.txtTempHumFolAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.txtTempHumPreBaudRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel37 = new MetroFramework.Controls.MetroLabel();
            this.txtTempHumFolBaudRate = new MetroFramework.Controls.MetroTextBox();
            this.txtTempHumValue = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel14 = new MetroFramework.Controls.MetroPanel();
            this.cbPoisonFunction = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.btnPio = new MetroFramework.Controls.MetroButton();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.txtPioPreAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.txtPioFolAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.txtPioPreBaudRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.txtPioFolBaudRate = new MetroFramework.Controls.MetroTextBox();
            this.txtPioValue = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel13 = new MetroFramework.Controls.MetroPanel();
            this.cbCo2Function = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.btnCo2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.txtCo2PreAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.txtCo2FolAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.txtCo2PreBaudRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtCo2FolBaudRate = new MetroFramework.Controls.MetroTextBox();
            this.txtCo2Value = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtLedAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel58 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.lblResult = new MetroFramework.Controls.MetroLabel();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.txtMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtNum = new MetroFramework.Controls.MetroTextBox();
            this.txtPage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.cbSendMethod = new MetroFramework.Controls.MetroComboBox();
            this.cbCardType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.lblTtsMessage = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cbTimer = new MetroFramework.Controls.MetroCheckBox();
            this.btnSendTts = new MetroFramework.Controls.MetroButton();
            this.txtInfo = new MetroFramework.Controls.MetroTextBox();
            this.txtTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HKWSPanel = new MetroFramework.Controls.MetroPanel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtDataport = new MetroFramework.Controls.MetroTextBox();
            this.txtI = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginPwd = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginName = new MetroFramework.Controls.MetroTextBox();
            this.btnOn = new MetroFramework.Controls.MetroToggle();
            this.btnTelnet = new MetroFramework.Controls.MetroButton();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.theme = new MetroFramework.Controls.MetroTile();
            this.skin = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroTabPage7.SuspendLayout();
            this.metroPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeOut)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabPage6.SuspendLayout();
            this.metroPanel23.SuspendLayout();
            this.metroPanel25.SuspendLayout();
            this.metroPanel19.SuspendLayout();
            this.metroPanel17.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage8.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroTabPage9.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroTabPage10.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroTabPage11.SuspendLayout();
            this.metroPanel9.SuspendLayout();
            this.metroTabPage12.SuspendLayout();
            this.metroPanel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.metroTabPage13.SuspendLayout();
            this.metroPanel11.SuspendLayout();
            this.metroTabPage14.SuspendLayout();
            this.metroPanel12.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel16.SuspendLayout();
            this.metroPanel15.SuspendLayout();
            this.metroPanel14.SuspendLayout();
            this.metroPanel13.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
            this.HKWSPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage7.Controls.Add(this.metroPanel18);
            this.metroTabPage7.Controls.Add(this.metroPanel1);
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(885, 390);
            this.metroTabPage7.TabIndex = 6;
            this.metroTabPage7.Text = "&设置";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // metroPanel18
            // 
            this.metroPanel18.Controls.Add(this.metroLabel57);
            this.metroPanel18.Controls.Add(this.cbTimer1);
            this.metroPanel18.Controls.Add(this.btnClear);
            this.metroPanel18.Controls.Add(this.btnOpenLog);
            this.metroPanel18.Controls.Add(this.btnSend2);
            this.metroPanel18.Controls.Add(this.btnSend3);
            this.metroPanel18.Controls.Add(this.btnSend1);
            this.metroPanel18.Controls.Add(this.btnParity2);
            this.metroPanel18.Controls.Add(this.btnParity3);
            this.metroPanel18.Controls.Add(this.btnParity1);
            this.metroPanel18.Controls.Add(this.txtCommand3);
            this.metroPanel18.Controls.Add(this.txtCommand2);
            this.metroPanel18.Controls.Add(this.txtCommand1);
            this.metroPanel18.Controls.Add(this.metroLabel56);
            this.metroPanel18.Controls.Add(this.metroLabel55);
            this.metroPanel18.Controls.Add(this.metroLabel54);
            this.metroPanel18.Controls.Add(this.metroLabel53);
            this.metroPanel18.Controls.Add(this.txtTime1);
            this.metroPanel18.Controls.Add(this.lstReturnCommand);
            this.metroPanel18.HorizontalScrollbarBarColor = true;
            this.metroPanel18.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel18.HorizontalScrollbarSize = 10;
            this.metroPanel18.Location = new System.Drawing.Point(209, 3);
            this.metroPanel18.Name = "metroPanel18";
            this.metroPanel18.Size = new System.Drawing.Size(672, 383);
            this.metroPanel18.TabIndex = 3;
            this.metroPanel18.VerticalScrollbarBarColor = true;
            this.metroPanel18.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel18.VerticalScrollbarSize = 10;
            // 
            // metroLabel57
            // 
            this.metroLabel57.AutoSize = true;
            this.metroLabel57.Location = new System.Drawing.Point(555, 194);
            this.metroLabel57.Name = "metroLabel57";
            this.metroLabel57.Size = new System.Drawing.Size(58, 20);
            this.metroLabel57.TabIndex = 123;
            this.metroLabel57.Text = "*100ms";
            this.metroLabel57.UseStyleColors = true;
            // 
            // cbTimer1
            // 
            this.cbTimer1.AutoSize = true;
            this.cbTimer1.Location = new System.Drawing.Point(374, 198);
            this.cbTimer1.Name = "cbTimer1";
            this.cbTimer1.Size = new System.Drawing.Size(48, 16);
            this.cbTimer1.TabIndex = 122;
            this.cbTimer1.Text = "定时";
            this.cbTimer1.UseVisualStyleBackColor = true;
            this.cbTimer1.CheckedChanged += new System.EventHandler(this.cbTimer1_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(374, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 121;
            this.btnClear.Text = "清空窗口";
            this.btnClear.UseSelectable = true;
            this.btnClear.UseStyleColors = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.Location = new System.Drawing.Point(579, 281);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenLog.TabIndex = 120;
            this.btnOpenLog.Text = "打开日志";
            this.btnOpenLog.UseSelectable = true;
            this.btnOpenLog.UseStyleColors = true;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(474, 78);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(75, 23);
            this.btnSend2.TabIndex = 118;
            this.btnSend2.Text = "发送";
            this.btnSend2.UseSelectable = true;
            this.btnSend2.UseStyleColors = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // btnSend3
            // 
            this.btnSend3.Location = new System.Drawing.Point(474, 131);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(75, 23);
            this.btnSend3.TabIndex = 117;
            this.btnSend3.Text = "发送";
            this.btnSend3.UseSelectable = true;
            this.btnSend3.UseStyleColors = true;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(474, 18);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(75, 23);
            this.btnSend1.TabIndex = 116;
            this.btnSend1.Text = "发送";
            this.btnSend1.UseSelectable = true;
            this.btnSend1.UseStyleColors = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // btnParity2
            // 
            this.btnParity2.Location = new System.Drawing.Point(374, 78);
            this.btnParity2.Name = "btnParity2";
            this.btnParity2.Size = new System.Drawing.Size(75, 23);
            this.btnParity2.TabIndex = 115;
            this.btnParity2.Text = "CRC校验";
            this.btnParity2.UseSelectable = true;
            this.btnParity2.UseStyleColors = true;
            this.btnParity2.Click += new System.EventHandler(this.btnParity2_Click);
            // 
            // btnParity3
            // 
            this.btnParity3.Location = new System.Drawing.Point(374, 131);
            this.btnParity3.Name = "btnParity3";
            this.btnParity3.Size = new System.Drawing.Size(75, 23);
            this.btnParity3.TabIndex = 114;
            this.btnParity3.Text = "CRC校验";
            this.btnParity3.UseSelectable = true;
            this.btnParity3.UseStyleColors = true;
            this.btnParity3.Click += new System.EventHandler(this.btnParity3_Click);
            // 
            // btnParity1
            // 
            this.btnParity1.Location = new System.Drawing.Point(374, 18);
            this.btnParity1.Name = "btnParity1";
            this.btnParity1.Size = new System.Drawing.Size(75, 23);
            this.btnParity1.TabIndex = 113;
            this.btnParity1.Text = "CRC校验";
            this.btnParity1.UseSelectable = true;
            this.btnParity1.UseStyleColors = true;
            this.btnParity1.Click += new System.EventHandler(this.btnParity1_Click);
            // 
            // txtCommand3
            // 
            this.txtCommand3.IconRight = true;
            this.txtCommand3.Lines = new string[] {
        "01 03 00 00 00 01"};
            this.txtCommand3.Location = new System.Drawing.Point(120, 131);
            this.txtCommand3.MaxLength = 32767;
            this.txtCommand3.Name = "txtCommand3";
            this.txtCommand3.PasswordChar = '\0';
            this.txtCommand3.PromptText = "01 03 00 00 00 01";
            this.txtCommand3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCommand3.SelectedText = "";
            this.txtCommand3.Size = new System.Drawing.Size(238, 23);
            this.txtCommand3.TabIndex = 112;
            this.txtCommand3.Text = "01 03 00 00 00 01";
            this.txtCommand3.UseSelectable = true;
            this.txtCommand3.UseStyleColors = true;
            // 
            // txtCommand2
            // 
            this.txtCommand2.IconRight = true;
            this.txtCommand2.Lines = new string[] {
        "01 03 00 00 00 01"};
            this.txtCommand2.Location = new System.Drawing.Point(120, 77);
            this.txtCommand2.MaxLength = 32767;
            this.txtCommand2.Name = "txtCommand2";
            this.txtCommand2.PasswordChar = '\0';
            this.txtCommand2.PromptText = "01 03 00 00 00 01";
            this.txtCommand2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCommand2.SelectedText = "";
            this.txtCommand2.Size = new System.Drawing.Size(238, 23);
            this.txtCommand2.TabIndex = 111;
            this.txtCommand2.Text = "01 03 00 00 00 01";
            this.txtCommand2.UseSelectable = true;
            this.txtCommand2.UseStyleColors = true;
            // 
            // txtCommand1
            // 
            this.txtCommand1.IconRight = true;
            this.txtCommand1.Lines = new string[] {
        "8C 04 00 00 00 01 2F 17"};
            this.txtCommand1.Location = new System.Drawing.Point(120, 18);
            this.txtCommand1.MaxLength = 32767;
            this.txtCommand1.Name = "txtCommand1";
            this.txtCommand1.PasswordChar = '\0';
            this.txtCommand1.PromptText = "01 03 00 00 00 01";
            this.txtCommand1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCommand1.SelectedText = "";
            this.txtCommand1.Size = new System.Drawing.Size(238, 23);
            this.txtCommand1.TabIndex = 110;
            this.txtCommand1.Text = "8C 04 00 00 00 01 2F 17";
            this.txtCommand1.UseSelectable = true;
            this.txtCommand1.UseStyleColors = true;
            // 
            // metroLabel56
            // 
            this.metroLabel56.AutoSize = true;
            this.metroLabel56.Location = new System.Drawing.Point(27, 184);
            this.metroLabel56.Name = "metroLabel56";
            this.metroLabel56.Size = new System.Drawing.Size(79, 20);
            this.metroLabel56.TabIndex = 109;
            this.metroLabel56.Text = "返回命令：";
            this.metroLabel56.UseStyleColors = true;
            // 
            // metroLabel55
            // 
            this.metroLabel55.AutoSize = true;
            this.metroLabel55.Location = new System.Drawing.Point(19, 75);
            this.metroLabel55.Name = "metroLabel55";
            this.metroLabel55.Size = new System.Drawing.Size(87, 20);
            this.metroLabel55.TabIndex = 108;
            this.metroLabel55.Text = "输入命令2：";
            this.metroLabel55.UseStyleColors = true;
            // 
            // metroLabel54
            // 
            this.metroLabel54.AutoSize = true;
            this.metroLabel54.Location = new System.Drawing.Point(19, 134);
            this.metroLabel54.Name = "metroLabel54";
            this.metroLabel54.Size = new System.Drawing.Size(87, 20);
            this.metroLabel54.TabIndex = 107;
            this.metroLabel54.Text = "输入命令3：";
            this.metroLabel54.UseStyleColors = true;
            // 
            // metroLabel53
            // 
            this.metroLabel53.AutoSize = true;
            this.metroLabel53.Location = new System.Drawing.Point(19, 18);
            this.metroLabel53.Name = "metroLabel53";
            this.metroLabel53.Size = new System.Drawing.Size(87, 20);
            this.metroLabel53.TabIndex = 106;
            this.metroLabel53.Text = "输入命令1：";
            this.metroLabel53.UseStyleColors = true;
            // 
            // txtTime1
            // 
            this.txtTime1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime1.Location = new System.Drawing.Point(474, 188);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.Size = new System.Drawing.Size(75, 26);
            this.txtTime1.TabIndex = 91;
            this.txtTime1.TabStop = false;
            this.txtTime1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lstReturnCommand
            // 
            this.lstReturnCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstReturnCommand.FormattingEnabled = true;
            this.lstReturnCommand.ItemHeight = 12;
            this.lstReturnCommand.Location = new System.Drawing.Point(120, 183);
            this.lstReturnCommand.Name = "lstReturnCommand";
            this.lstReturnCommand.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstReturnCommand.Size = new System.Drawing.Size(238, 182);
            this.lstReturnCommand.TabIndex = 89;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLabel52);
            this.metroPanel1.Controls.Add(this.metroLabel51);
            this.metroPanel1.Controls.Add(this.txtTimeOut);
            this.metroPanel1.Controls.Add(this.btnSet);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.panel2);
            this.metroPanel1.Controls.Add(this.rbtN);
            this.metroPanel1.Controls.Add(this.rbtS);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(203, 388);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(102, 161);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 100;
            this.metroButton1.Text = "设置";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel52
            // 
            this.metroLabel52.AutoSize = true;
            this.metroLabel52.Location = new System.Drawing.Point(3, 328);
            this.metroLabel52.Name = "metroLabel52";
            this.metroLabel52.Size = new System.Drawing.Size(65, 20);
            this.metroLabel52.TabIndex = 99;
            this.metroLabel52.Text = "超时时间";
            this.metroLabel52.UseStyleColors = true;
            // 
            // metroLabel51
            // 
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.Location = new System.Drawing.Point(74, 357);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(58, 20);
            this.metroLabel51.TabIndex = 98;
            this.metroLabel51.Text = "*100ms";
            this.metroLabel51.UseStyleColors = true;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTimeOut.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtTimeOut.Location = new System.Drawing.Point(74, 328);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(75, 26);
            this.txtTimeOut.TabIndex = 97;
            this.txtTimeOut.TabStop = false;
            this.txtTimeOut.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(12, 283);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 64;
            this.btnSet.Text = "连接";
            this.btnSet.UseSelectable = true;
            this.btnSet.UseStyleColors = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(102, 283);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(74, 23);
            this.metroButton2.TabIndex = 63;
            this.metroButton2.Text = "Ping";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.HorizontalScrollbarBarColor = true;
            this.panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1.HorizontalScrollbarSize = 10;
            this.panel1.Location = new System.Drawing.Point(9, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 74);
            this.panel1.TabIndex = 61;
            this.panel1.VerticalScrollbarBarColor = true;
            this.panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel1.VerticalScrollbarSize = 10;
            // 
            // txtPort
            // 
            this.txtPort.IconRight = true;
            this.txtPort.Lines = new string[] {
        "10004"};
            this.txtPort.Location = new System.Drawing.Point(74, 47);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PromptText = "10001";
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.Size = new System.Drawing.Size(108, 23);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "10004";
            this.txtPort.UseSelectable = true;
            this.txtPort.UseStyleColors = true;
            // 
            // txtIP
            // 
            this.txtIP.IconRight = true;
            this.txtIP.Lines = new string[] {
        "183.167.214.155"};
            this.txtIP.Location = new System.Drawing.Point(74, 3);
            this.txtIP.MaxLength = 32767;
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.PromptText = "192.168.1.233";
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.SelectedText = "";
            this.txtIP.Size = new System.Drawing.Size(108, 23);
            this.txtIP.TabIndex = 4;
            this.txtIP.Text = "183.167.214.155";
            this.txtIP.UseSelectable = true;
            this.txtIP.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 47);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "端口号：";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "IP：";
            this.metroLabel2.UseStyleColors = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSerialName);
            this.panel2.Controls.Add(this.cbBaudRate);
            this.panel2.Controls.Add(this.metroLabel4);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.HorizontalScrollbarBarColor = true;
            this.panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel2.HorizontalScrollbarSize = 10;
            this.panel2.Location = new System.Drawing.Point(9, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 80);
            this.panel2.TabIndex = 60;
            this.panel2.VerticalScrollbarBarColor = true;
            this.panel2.VerticalScrollbarHighlightOnWheel = false;
            this.panel2.VerticalScrollbarSize = 10;
            // 
            // cbSerialName
            // 
            this.cbSerialName.DisplayMember = "SelectedText";
            this.cbSerialName.FormattingEnabled = true;
            this.cbSerialName.ItemHeight = 24;
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
            this.cbSerialName.Location = new System.Drawing.Point(74, 47);
            this.cbSerialName.Name = "cbSerialName";
            this.cbSerialName.PromptText = "COM1";
            this.cbSerialName.Size = new System.Drawing.Size(108, 30);
            this.cbSerialName.TabIndex = 62;
            this.cbSerialName.UseSelectable = true;
            this.cbSerialName.ValueMember = "SelectedText";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DisplayMember = "SelectedText";
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.ItemHeight = 24;
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
            this.cbBaudRate.Location = new System.Drawing.Point(74, 3);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.PromptText = "9600";
            this.cbBaudRate.Size = new System.Drawing.Size(108, 30);
            this.cbBaudRate.TabIndex = 62;
            this.cbBaudRate.UseSelectable = true;
            this.cbBaudRate.UseStyleColors = true;
            this.cbBaudRate.ValueMember = "SelectedText";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 47);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 20);
            this.metroLabel4.TabIndex = 39;
            this.metroLabel4.Text = "串口名：";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 20);
            this.metroLabel5.TabIndex = 38;
            this.metroLabel5.Text = "波特率：";
            this.metroLabel5.UseStyleColors = true;
            // 
            // rbtN
            // 
            this.rbtN.AutoSize = true;
            this.rbtN.Location = new System.Drawing.Point(9, 167);
            this.rbtN.Name = "rbtN";
            this.rbtN.Size = new System.Drawing.Size(72, 17);
            this.rbtN.TabIndex = 59;
            this.rbtN.Text = "网络通信";
            this.rbtN.UseSelectable = true;
            this.rbtN.UseStyleColors = true;
            // 
            // rbtS
            // 
            this.rbtS.AutoSize = true;
            this.rbtS.Location = new System.Drawing.Point(9, 46);
            this.rbtS.Name = "rbtS";
            this.rbtS.Size = new System.Drawing.Size(72, 17);
            this.rbtS.TabIndex = 58;
            this.rbtS.Text = "串口通信";
            this.rbtS.UseSelectable = true;
            this.rbtS.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 20);
            this.metroLabel1.TabIndex = 57;
            this.metroLabel1.Text = "选择通讯方式";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage6.Controls.Add(this.metroPanel23);
            this.metroTabPage6.Controls.Add(this.metroPanel19);
            this.metroTabPage6.Controls.Add(this.metroPanel17);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(885, 390);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "&工具";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroPanel23
            // 
            this.metroPanel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel23.Controls.Add(this.metroPanel25);
            this.metroPanel23.Controls.Add(this.cacl);
            this.metroPanel23.HorizontalScrollbarBarColor = true;
            this.metroPanel23.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel23.HorizontalScrollbarSize = 10;
            this.metroPanel23.Location = new System.Drawing.Point(292, 4);
            this.metroPanel23.Name = "metroPanel23";
            this.metroPanel23.Size = new System.Drawing.Size(361, 382);
            this.metroPanel23.TabIndex = 71;
            this.metroPanel23.VerticalScrollbarBarColor = true;
            this.metroPanel23.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel23.VerticalScrollbarSize = 10;
            // 
            // metroPanel25
            // 
            this.metroPanel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel25.Controls.Add(this.seacherPanel);
            this.metroPanel25.Controls.Add(this.metroLabel50);
            this.metroPanel25.Controls.Add(this.metroLabel48);
            this.metroPanel25.Controls.Add(this.listBox3);
            this.metroPanel25.Controls.Add(this.progressBar1);
            this.metroPanel25.Controls.Add(this.txtEnd);
            this.metroPanel25.Controls.Add(this.txtStart);
            this.metroPanel25.Controls.Add(this.btnStart);
            this.metroPanel25.HorizontalScrollbarBarColor = true;
            this.metroPanel25.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel25.HorizontalScrollbarSize = 10;
            this.metroPanel25.Location = new System.Drawing.Point(3, 150);
            this.metroPanel25.Name = "metroPanel25";
            this.metroPanel25.Size = new System.Drawing.Size(356, 230);
            this.metroPanel25.TabIndex = 5;
            this.metroPanel25.VerticalScrollbarBarColor = true;
            this.metroPanel25.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel25.VerticalScrollbarSize = 10;
            // 
            // seacherPanel
            // 
            this.seacherPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seacherPanel.BackgroundImage")));
            this.seacherPanel.HorizontalScrollbarBarColor = true;
            this.seacherPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.seacherPanel.HorizontalScrollbarSize = 10;
            this.seacherPanel.Location = new System.Drawing.Point(220, 62);
            this.seacherPanel.Name = "seacherPanel";
            this.seacherPanel.Size = new System.Drawing.Size(23, 23);
            this.seacherPanel.TabIndex = 11;
            this.seacherPanel.VerticalScrollbarBarColor = true;
            this.seacherPanel.VerticalScrollbarHighlightOnWheel = false;
            this.seacherPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel50
            // 
            this.metroLabel50.AutoSize = true;
            this.metroLabel50.Location = new System.Drawing.Point(178, 27);
            this.metroLabel50.Name = "metroLabel50";
            this.metroLabel50.Size = new System.Drawing.Size(65, 20);
            this.metroLabel50.TabIndex = 10;
            this.metroLabel50.Text = "结束地址";
            this.metroLabel50.UseStyleColors = true;
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.Location = new System.Drawing.Point(7, 27);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(65, 20);
            this.metroLabel48.TabIndex = 9;
            this.metroLabel48.Text = "起始地址";
            this.metroLabel48.UseStyleColors = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(7, 91);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(336, 136);
            this.listBox3.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 62);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(193, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 1;
            // 
            // txtEnd
            // 
            this.txtEnd.Lines = new string[] {
        "192.168.1.255"};
            this.txtEnd.Location = new System.Drawing.Point(258, 27);
            this.txtEnd.MaxLength = 32767;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.PasswordChar = '\0';
            this.txtEnd.PromptText = "结束地址";
            this.txtEnd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnd.SelectedText = "";
            this.txtEnd.Size = new System.Drawing.Size(85, 23);
            this.txtEnd.TabIndex = 5;
            this.txtEnd.Text = "192.168.1.255";
            this.txtEnd.UseSelectable = true;
            this.txtEnd.UseStyleColors = true;
            // 
            // txtStart
            // 
            this.txtStart.Lines = new string[] {
        "192.168.1.1"};
            this.txtStart.Location = new System.Drawing.Point(78, 27);
            this.txtStart.MaxLength = 32767;
            this.txtStart.Name = "txtStart";
            this.txtStart.PasswordChar = '\0';
            this.txtStart.PromptText = "起始地址";
            this.txtStart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStart.SelectedText = "";
            this.txtStart.Size = new System.Drawing.Size(83, 23);
            this.txtStart.TabIndex = 4;
            this.txtStart.Text = "192.168.1.1";
            this.txtStart.UseSelectable = true;
            this.txtStart.UseStyleColors = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(258, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseSelectable = true;
            this.btnStart.UseStyleColors = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cacl
            // 
            this.cacl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cacl.BackgroundImage")));
            this.cacl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cacl.HorizontalScrollbarBarColor = true;
            this.cacl.HorizontalScrollbarHighlightOnWheel = false;
            this.cacl.HorizontalScrollbarSize = 10;
            this.cacl.Location = new System.Drawing.Point(3, 3);
            this.cacl.Name = "cacl";
            this.cacl.Size = new System.Drawing.Size(354, 143);
            this.cacl.TabIndex = 4;
            this.cacl.VerticalScrollbarBarColor = true;
            this.cacl.VerticalScrollbarHighlightOnWheel = false;
            this.cacl.VerticalScrollbarSize = 10;
            this.cacl.Click += new System.EventHandler(this.cacl_Click);
            // 
            // metroPanel19
            // 
            this.metroPanel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel19.Controls.Add(this.metroPanel22);
            this.metroPanel19.Controls.Add(this.metroPanel21);
            this.metroPanel19.Controls.Add(this.metroPanel20);
            this.metroPanel19.HorizontalScrollbarBarColor = true;
            this.metroPanel19.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel19.HorizontalScrollbarSize = 10;
            this.metroPanel19.Location = new System.Drawing.Point(3, 4);
            this.metroPanel19.Name = "metroPanel19";
            this.metroPanel19.Size = new System.Drawing.Size(283, 381);
            this.metroPanel19.TabIndex = 70;
            this.metroPanel19.VerticalScrollbarBarColor = true;
            this.metroPanel19.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel19.VerticalScrollbarSize = 10;
            // 
            // metroPanel22
            // 
            this.metroPanel22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel22.BackgroundImage")));
            this.metroPanel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel22.HorizontalScrollbarBarColor = true;
            this.metroPanel22.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel22.HorizontalScrollbarSize = 10;
            this.metroPanel22.Location = new System.Drawing.Point(3, 270);
            this.metroPanel22.Name = "metroPanel22";
            this.metroPanel22.Size = new System.Drawing.Size(275, 106);
            this.metroPanel22.TabIndex = 7;
            this.metroPanel22.VerticalScrollbarBarColor = true;
            this.metroPanel22.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel22.VerticalScrollbarSize = 10;
            this.metroPanel22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroPanel22_MouseClick);
            // 
            // metroPanel21
            // 
            this.metroPanel21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel21.BackgroundImage")));
            this.metroPanel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel21.HorizontalScrollbarBarColor = true;
            this.metroPanel21.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel21.HorizontalScrollbarSize = 10;
            this.metroPanel21.Location = new System.Drawing.Point(3, 148);
            this.metroPanel21.Name = "metroPanel21";
            this.metroPanel21.Size = new System.Drawing.Size(275, 116);
            this.metroPanel21.TabIndex = 6;
            this.metroPanel21.VerticalScrollbarBarColor = true;
            this.metroPanel21.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel21.VerticalScrollbarSize = 10;
            this.metroPanel21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroPanel21_MouseClick);
            // 
            // metroPanel20
            // 
            this.metroPanel20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel20.BackgroundImage")));
            this.metroPanel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel20.HorizontalScrollbarBarColor = true;
            this.metroPanel20.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel20.HorizontalScrollbarSize = 10;
            this.metroPanel20.Location = new System.Drawing.Point(3, 3);
            this.metroPanel20.Name = "metroPanel20";
            this.metroPanel20.Size = new System.Drawing.Size(275, 143);
            this.metroPanel20.TabIndex = 5;
            this.metroPanel20.VerticalScrollbarBarColor = true;
            this.metroPanel20.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel20.VerticalScrollbarSize = 10;
            this.metroPanel20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroPanel20_MouseClick);
            // 
            // metroPanel17
            // 
            this.metroPanel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel17.Controls.Add(this.btnmAValue);
            this.metroPanel17.Controls.Add(this.metroLabel46);
            this.metroPanel17.Controls.Add(this.cbReg);
            this.metroPanel17.Controls.Add(this.metroLabel44);
            this.metroPanel17.Controls.Add(this.metroLabel45);
            this.metroPanel17.Controls.Add(this.txtCollectAddress);
            this.metroPanel17.Controls.Add(this.metroLabel49);
            this.metroPanel17.Controls.Add(this.txtCollectValue);
            this.metroPanel17.HorizontalScrollbarBarColor = true;
            this.metroPanel17.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel17.HorizontalScrollbarSize = 10;
            this.metroPanel17.Location = new System.Drawing.Point(659, 4);
            this.metroPanel17.Name = "metroPanel17";
            this.metroPanel17.Size = new System.Drawing.Size(221, 382);
            this.metroPanel17.TabIndex = 69;
            this.metroPanel17.VerticalScrollbarBarColor = true;
            this.metroPanel17.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel17.VerticalScrollbarSize = 10;
            // 
            // btnmAValue
            // 
            this.btnmAValue.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnmAValue.Location = new System.Drawing.Point(135, 290);
            this.btnmAValue.Name = "btnmAValue";
            this.btnmAValue.Size = new System.Drawing.Size(75, 23);
            this.btnmAValue.TabIndex = 83;
            this.btnmAValue.Text = "读取";
            this.btnmAValue.UseSelectable = true;
            this.btnmAValue.UseStyleColors = true;
            this.btnmAValue.Click += new System.EventHandler(this.btnmAValue_Click);
            // 
            // metroLabel46
            // 
            this.metroLabel46.AutoSize = true;
            this.metroLabel46.Location = new System.Drawing.Point(9, 154);
            this.metroLabel46.Name = "metroLabel46";
            this.metroLabel46.Size = new System.Drawing.Size(79, 20);
            this.metroLabel46.TabIndex = 82;
            this.metroLabel46.Text = "寄存器地址";
            this.metroLabel46.UseStyleColors = true;
            // 
            // cbReg
            // 
            this.cbReg.FormattingEnabled = true;
            this.cbReg.ItemHeight = 24;
            this.cbReg.Items.AddRange(new object[] {
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
            "0010"});
            this.cbReg.Location = new System.Drawing.Point(9, 195);
            this.cbReg.Name = "cbReg";
            this.cbReg.PromptText = "接入第几路";
            this.cbReg.Size = new System.Drawing.Size(103, 30);
            this.cbReg.TabIndex = 81;
            this.cbReg.UseSelectable = true;
            this.cbReg.UseStyleColors = true;
            // 
            // metroLabel44
            // 
            this.metroLabel44.AutoSize = true;
            this.metroLabel44.Location = new System.Drawing.Point(9, 256);
            this.metroLabel44.Name = "metroLabel44";
            this.metroLabel44.Size = new System.Drawing.Size(79, 20);
            this.metroLabel44.TabIndex = 79;
            this.metroLabel44.Text = "当前设备值";
            this.metroLabel44.UseStyleColors = true;
            // 
            // metroLabel45
            // 
            this.metroLabel45.AutoSize = true;
            this.metroLabel45.Location = new System.Drawing.Point(67, 10);
            this.metroLabel45.Name = "metroLabel45";
            this.metroLabel45.Size = new System.Drawing.Size(90, 20);
            this.metroLabel45.TabIndex = 69;
            this.metroLabel45.Text = "4-20mA采集";
            this.metroLabel45.UseStyleColors = true;
            // 
            // txtCollectAddress
            // 
            this.txtCollectAddress.Lines = new string[0];
            this.txtCollectAddress.Location = new System.Drawing.Point(9, 106);
            this.txtCollectAddress.MaxLength = 32767;
            this.txtCollectAddress.Name = "txtCollectAddress";
            this.txtCollectAddress.PasswordChar = '\0';
            this.txtCollectAddress.PromptText = "请输入十进制整数";
            this.txtCollectAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCollectAddress.SelectedText = "";
            this.txtCollectAddress.Size = new System.Drawing.Size(103, 23);
            this.txtCollectAddress.TabIndex = 70;
            this.txtCollectAddress.UseSelectable = true;
            this.txtCollectAddress.UseStyleColors = true;
            // 
            // metroLabel49
            // 
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.Location = new System.Drawing.Point(9, 70);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(121, 20);
            this.metroLabel49.TabIndex = 75;
            this.metroLabel49.Text = "当前设备装置地址";
            this.metroLabel49.UseStyleColors = true;
            // 
            // txtCollectValue
            // 
            this.txtCollectValue.Lines = new string[0];
            this.txtCollectValue.Location = new System.Drawing.Point(9, 290);
            this.txtCollectValue.MaxLength = 32767;
            this.txtCollectValue.Name = "txtCollectValue";
            this.txtCollectValue.PasswordChar = '\0';
            this.txtCollectValue.PromptText = "显示设备原始值";
            this.txtCollectValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCollectValue.SelectedText = "";
            this.txtCollectValue.Size = new System.Drawing.Size(103, 23);
            this.txtCollectValue.TabIndex = 74;
            this.txtCollectValue.UseSelectable = true;
            this.txtCollectValue.UseStyleColors = true;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage5.Controls.Add(this.metroTabControl2);
            this.metroTabPage5.Controls.Add(this.treeView1);
            this.metroTabPage5.Controls.Add(this.metroPanel5);
            this.metroTabPage5.HorizontalScrollbar = true;
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(885, 390);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "&其他设备";
            this.metroTabPage5.VerticalScrollbar = true;
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage8);
            this.metroTabControl2.Controls.Add(this.metroTabPage9);
            this.metroTabControl2.Controls.Add(this.metroTabPage10);
            this.metroTabControl2.Controls.Add(this.metroTabPage11);
            this.metroTabControl2.Controls.Add(this.metroTabPage12);
            this.metroTabControl2.Controls.Add(this.metroTabPage13);
            this.metroTabControl2.Controls.Add(this.metroTabPage14);
            this.metroTabControl2.Location = new System.Drawing.Point(141, 3);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
            this.metroTabControl2.Size = new System.Drawing.Size(565, 386);
            this.metroTabControl2.TabIndex = 4;
            this.metroTabControl2.UseSelectable = true;
            this.metroTabControl2.UseStyleColors = true;
            this.metroTabControl2.Enter += new System.EventHandler(this.metroTabControl2_Enter);
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.Controls.Add(this.metroPanel6);
            this.metroTabPage8.HorizontalScrollbar = true;
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(557, 343);
            this.metroTabPage8.TabIndex = 0;
            this.metroTabPage8.Text = "读写线圈";
            this.metroTabPage8.VerticalScrollbar = true;
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
            // metroPanel6
            // 
            this.metroPanel6.AutoScroll = true;
            this.metroPanel6.Controls.Add(this.btnGetAll);
            this.metroPanel6.Controls.Add(this.btnSave);
            this.metroPanel6.Controls.Add(this.btnOnOrOff20);
            this.metroPanel6.Controls.Add(this.btnOnOrOff19);
            this.metroPanel6.Controls.Add(this.cbOnOrOff20);
            this.metroPanel6.Controls.Add(this.cbOnOrOff19);
            this.metroPanel6.Controls.Add(this.btnOnOrOff18);
            this.metroPanel6.Controls.Add(this.btnOnOrOff17);
            this.metroPanel6.Controls.Add(this.btnOnOrOff16);
            this.metroPanel6.Controls.Add(this.btnOnOrOff15);
            this.metroPanel6.Controls.Add(this.btnOnOrOff13);
            this.metroPanel6.Controls.Add(this.btnOnOrOff14);
            this.metroPanel6.Controls.Add(this.btnOnOrOff12);
            this.metroPanel6.Controls.Add(this.btnOnOrOff11);
            this.metroPanel6.Controls.Add(this.cbOnOrOff18);
            this.metroPanel6.Controls.Add(this.cbOnOrOff17);
            this.metroPanel6.Controls.Add(this.cbOnOrOff16);
            this.metroPanel6.Controls.Add(this.cbOnOrOff15);
            this.metroPanel6.Controls.Add(this.cbOnOrOff14);
            this.metroPanel6.Controls.Add(this.cbOnOrOff13);
            this.metroPanel6.Controls.Add(this.cbOnOrOff12);
            this.metroPanel6.Controls.Add(this.cbOnOrOff11);
            this.metroPanel6.Controls.Add(this.btnOnOrOff10);
            this.metroPanel6.Controls.Add(this.btnOnOrOff9);
            this.metroPanel6.Controls.Add(this.cbOnOrOff10);
            this.metroPanel6.Controls.Add(this.cbOnOrOff9);
            this.metroPanel6.Controls.Add(this.btnOnOrOff8);
            this.metroPanel6.Controls.Add(this.btnOnOrOff7);
            this.metroPanel6.Controls.Add(this.btnOnOrOff6);
            this.metroPanel6.Controls.Add(this.btnOnOrOff5);
            this.metroPanel6.Controls.Add(this.btnOnOrOff3);
            this.metroPanel6.Controls.Add(this.btnOnOrOff4);
            this.metroPanel6.Controls.Add(this.btnOnOrOff2);
            this.metroPanel6.Controls.Add(this.btnOnOrOff1);
            this.metroPanel6.Controls.Add(this.cbOnOrOff8);
            this.metroPanel6.Controls.Add(this.cbOnOrOff7);
            this.metroPanel6.Controls.Add(this.cbOnOrOff6);
            this.metroPanel6.Controls.Add(this.cbOnOrOff5);
            this.metroPanel6.Controls.Add(this.cbOnOrOff4);
            this.metroPanel6.Controls.Add(this.cbOnOrOff3);
            this.metroPanel6.Controls.Add(this.cbOnOrOff2);
            this.metroPanel6.Controls.Add(this.cbOnOrOff1);
            this.metroPanel6.Controls.Add(this.label5);
            this.metroPanel6.Controls.Add(this.label31);
            this.metroPanel6.Controls.Add(this.label32);
            this.metroPanel6.Controls.Add(this.label33);
            this.metroPanel6.Controls.Add(this.label34);
            this.metroPanel6.Controls.Add(this.label35);
            this.metroPanel6.Controls.Add(this.label36);
            this.metroPanel6.Controls.Add(this.label37);
            this.metroPanel6.Controls.Add(this.label38);
            this.metroPanel6.Controls.Add(this.label39);
            this.metroPanel6.Controls.Add(this.label40);
            this.metroPanel6.Controls.Add(this.label12);
            this.metroPanel6.Controls.Add(this.label30);
            this.metroPanel6.Controls.Add(this.label10);
            this.metroPanel6.Controls.Add(this.label9);
            this.metroPanel6.Controls.Add(this.label8);
            this.metroPanel6.Controls.Add(this.label7);
            this.metroPanel6.Controls.Add(this.label6);
            this.metroPanel6.Controls.Add(this.label11);
            this.metroPanel6.Controls.Add(this.label13);
            this.metroPanel6.Controls.Add(this.label14);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel6.HorizontalScrollbar = true;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 0);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(557, 343);
            this.metroPanel6.TabIndex = 2;
            this.metroPanel6.VerticalScrollbar = true;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(46, 326);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(172, 23);
            this.btnGetAll.TabIndex = 378;
            this.btnGetAll.Text = "获取当前所有线圈的状态";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 23);
            this.btnSave.TabIndex = 377;
            this.btnSave.Text = "保存当前所有线圈状态";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOnOrOff20
            // 
            this.btnOnOrOff20.Location = new System.Drawing.Point(675, 226);
            this.btnOnOrOff20.Name = "btnOnOrOff20";
            this.btnOnOrOff20.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff20.TabIndex = 376;
            this.btnOnOrOff20.Text = "写开断";
            this.btnOnOrOff20.UseVisualStyleBackColor = true;
            this.btnOnOrOff20.Click += new System.EventHandler(this.btnOnOrOff20_Click);
            // 
            // btnOnOrOff19
            // 
            this.btnOnOrOff19.Location = new System.Drawing.Point(675, 190);
            this.btnOnOrOff19.Name = "btnOnOrOff19";
            this.btnOnOrOff19.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff19.TabIndex = 375;
            this.btnOnOrOff19.Text = "写开断";
            this.btnOnOrOff19.UseVisualStyleBackColor = true;
            this.btnOnOrOff19.Click += new System.EventHandler(this.btnOnOrOff19_Click);
            // 
            // cbOnOrOff20
            // 
            this.cbOnOrOff20.FormattingEnabled = true;
            this.cbOnOrOff20.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff20.Location = new System.Drawing.Point(601, 228);
            this.cbOnOrOff20.Name = "cbOnOrOff20";
            this.cbOnOrOff20.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff20.TabIndex = 374;
            // 
            // cbOnOrOff19
            // 
            this.cbOnOrOff19.FormattingEnabled = true;
            this.cbOnOrOff19.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff19.Location = new System.Drawing.Point(601, 191);
            this.cbOnOrOff19.Name = "cbOnOrOff19";
            this.cbOnOrOff19.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff19.TabIndex = 373;
            // 
            // btnOnOrOff18
            // 
            this.btnOnOrOff18.Location = new System.Drawing.Point(675, 155);
            this.btnOnOrOff18.Name = "btnOnOrOff18";
            this.btnOnOrOff18.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff18.TabIndex = 372;
            this.btnOnOrOff18.Text = "写开断";
            this.btnOnOrOff18.UseVisualStyleBackColor = true;
            this.btnOnOrOff18.Click += new System.EventHandler(this.btnOnOrOff18_Click);
            // 
            // btnOnOrOff17
            // 
            this.btnOnOrOff17.Location = new System.Drawing.Point(675, 119);
            this.btnOnOrOff17.Name = "btnOnOrOff17";
            this.btnOnOrOff17.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff17.TabIndex = 371;
            this.btnOnOrOff17.Text = "写开断";
            this.btnOnOrOff17.UseVisualStyleBackColor = true;
            this.btnOnOrOff17.Click += new System.EventHandler(this.btnOnOrOff17_Click);
            // 
            // btnOnOrOff16
            // 
            this.btnOnOrOff16.Location = new System.Drawing.Point(675, 82);
            this.btnOnOrOff16.Name = "btnOnOrOff16";
            this.btnOnOrOff16.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff16.TabIndex = 370;
            this.btnOnOrOff16.Text = "写开断";
            this.btnOnOrOff16.UseVisualStyleBackColor = true;
            this.btnOnOrOff16.Click += new System.EventHandler(this.btnOnOrOff16_Click);
            // 
            // btnOnOrOff15
            // 
            this.btnOnOrOff15.Location = new System.Drawing.Point(675, 50);
            this.btnOnOrOff15.Name = "btnOnOrOff15";
            this.btnOnOrOff15.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff15.TabIndex = 369;
            this.btnOnOrOff15.Text = "写开断";
            this.btnOnOrOff15.UseVisualStyleBackColor = true;
            this.btnOnOrOff15.Click += new System.EventHandler(this.btnOnOrOff15_Click);
            // 
            // btnOnOrOff13
            // 
            this.btnOnOrOff13.Location = new System.Drawing.Point(427, 226);
            this.btnOnOrOff13.Name = "btnOnOrOff13";
            this.btnOnOrOff13.Size = new System.Drawing.Size(53, 23);
            this.btnOnOrOff13.TabIndex = 368;
            this.btnOnOrOff13.Text = "写开断";
            this.btnOnOrOff13.UseVisualStyleBackColor = true;
            this.btnOnOrOff13.Click += new System.EventHandler(this.btnOnOrOff13_Click);
            // 
            // btnOnOrOff14
            // 
            this.btnOnOrOff14.Location = new System.Drawing.Point(427, 263);
            this.btnOnOrOff14.Name = "btnOnOrOff14";
            this.btnOnOrOff14.Size = new System.Drawing.Size(53, 23);
            this.btnOnOrOff14.TabIndex = 367;
            this.btnOnOrOff14.Text = "写开断";
            this.btnOnOrOff14.UseVisualStyleBackColor = true;
            this.btnOnOrOff14.Click += new System.EventHandler(this.btnOnOrOff14_Click);
            // 
            // btnOnOrOff12
            // 
            this.btnOnOrOff12.Location = new System.Drawing.Point(427, 189);
            this.btnOnOrOff12.Name = "btnOnOrOff12";
            this.btnOnOrOff12.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff12.TabIndex = 366;
            this.btnOnOrOff12.Text = "写开断";
            this.btnOnOrOff12.UseVisualStyleBackColor = true;
            this.btnOnOrOff12.Click += new System.EventHandler(this.btnOnOrOff12_Click);
            // 
            // btnOnOrOff11
            // 
            this.btnOnOrOff11.Location = new System.Drawing.Point(427, 155);
            this.btnOnOrOff11.Name = "btnOnOrOff11";
            this.btnOnOrOff11.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff11.TabIndex = 365;
            this.btnOnOrOff11.Text = "写开断";
            this.btnOnOrOff11.UseVisualStyleBackColor = true;
            this.btnOnOrOff11.Click += new System.EventHandler(this.btnOnOrOff11_Click);
            // 
            // cbOnOrOff18
            // 
            this.cbOnOrOff18.FormattingEnabled = true;
            this.cbOnOrOff18.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff18.Location = new System.Drawing.Point(601, 156);
            this.cbOnOrOff18.Name = "cbOnOrOff18";
            this.cbOnOrOff18.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff18.TabIndex = 364;
            // 
            // cbOnOrOff17
            // 
            this.cbOnOrOff17.FormattingEnabled = true;
            this.cbOnOrOff17.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff17.Location = new System.Drawing.Point(601, 119);
            this.cbOnOrOff17.Name = "cbOnOrOff17";
            this.cbOnOrOff17.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff17.TabIndex = 363;
            // 
            // cbOnOrOff16
            // 
            this.cbOnOrOff16.FormattingEnabled = true;
            this.cbOnOrOff16.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff16.Location = new System.Drawing.Point(601, 84);
            this.cbOnOrOff16.Name = "cbOnOrOff16";
            this.cbOnOrOff16.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff16.TabIndex = 362;
            // 
            // cbOnOrOff15
            // 
            this.cbOnOrOff15.FormattingEnabled = true;
            this.cbOnOrOff15.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff15.Location = new System.Drawing.Point(601, 53);
            this.cbOnOrOff15.Name = "cbOnOrOff15";
            this.cbOnOrOff15.Size = new System.Drawing.Size(65, 20);
            this.cbOnOrOff15.TabIndex = 361;
            // 
            // cbOnOrOff14
            // 
            this.cbOnOrOff14.FormattingEnabled = true;
            this.cbOnOrOff14.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff14.Location = new System.Drawing.Point(352, 264);
            this.cbOnOrOff14.Name = "cbOnOrOff14";
            this.cbOnOrOff14.Size = new System.Drawing.Size(65, 20);
            this.cbOnOrOff14.TabIndex = 360;
            // 
            // cbOnOrOff13
            // 
            this.cbOnOrOff13.FormattingEnabled = true;
            this.cbOnOrOff13.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff13.Location = new System.Drawing.Point(352, 230);
            this.cbOnOrOff13.Name = "cbOnOrOff13";
            this.cbOnOrOff13.Size = new System.Drawing.Size(65, 20);
            this.cbOnOrOff13.TabIndex = 359;
            // 
            // cbOnOrOff12
            // 
            this.cbOnOrOff12.FormattingEnabled = true;
            this.cbOnOrOff12.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff12.Location = new System.Drawing.Point(351, 191);
            this.cbOnOrOff12.Name = "cbOnOrOff12";
            this.cbOnOrOff12.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff12.TabIndex = 358;
            // 
            // cbOnOrOff11
            // 
            this.cbOnOrOff11.FormattingEnabled = true;
            this.cbOnOrOff11.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff11.Location = new System.Drawing.Point(351, 156);
            this.cbOnOrOff11.Name = "cbOnOrOff11";
            this.cbOnOrOff11.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff11.TabIndex = 357;
            // 
            // btnOnOrOff10
            // 
            this.btnOnOrOff10.Location = new System.Drawing.Point(427, 118);
            this.btnOnOrOff10.Name = "btnOnOrOff10";
            this.btnOnOrOff10.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff10.TabIndex = 356;
            this.btnOnOrOff10.Text = "写开断";
            this.btnOnOrOff10.UseVisualStyleBackColor = true;
            this.btnOnOrOff10.Click += new System.EventHandler(this.btnOnOrOff10_Click);
            // 
            // btnOnOrOff9
            // 
            this.btnOnOrOff9.Location = new System.Drawing.Point(427, 82);
            this.btnOnOrOff9.Name = "btnOnOrOff9";
            this.btnOnOrOff9.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff9.TabIndex = 355;
            this.btnOnOrOff9.Text = "写开断";
            this.btnOnOrOff9.UseVisualStyleBackColor = true;
            this.btnOnOrOff9.Click += new System.EventHandler(this.btnOnOrOff9_Click);
            // 
            // cbOnOrOff10
            // 
            this.cbOnOrOff10.FormattingEnabled = true;
            this.cbOnOrOff10.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff10.Location = new System.Drawing.Point(351, 119);
            this.cbOnOrOff10.Name = "cbOnOrOff10";
            this.cbOnOrOff10.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff10.TabIndex = 354;
            // 
            // cbOnOrOff9
            // 
            this.cbOnOrOff9.FormattingEnabled = true;
            this.cbOnOrOff9.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff9.Location = new System.Drawing.Point(351, 84);
            this.cbOnOrOff9.Name = "cbOnOrOff9";
            this.cbOnOrOff9.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff9.TabIndex = 353;
            // 
            // btnOnOrOff8
            // 
            this.btnOnOrOff8.Location = new System.Drawing.Point(427, 48);
            this.btnOnOrOff8.Name = "btnOnOrOff8";
            this.btnOnOrOff8.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff8.TabIndex = 352;
            this.btnOnOrOff8.Text = "写开断";
            this.btnOnOrOff8.UseVisualStyleBackColor = true;
            this.btnOnOrOff8.Click += new System.EventHandler(this.btnOnOrOff8_Click);
            // 
            // btnOnOrOff7
            // 
            this.btnOnOrOff7.Location = new System.Drawing.Point(180, 266);
            this.btnOnOrOff7.Name = "btnOnOrOff7";
            this.btnOnOrOff7.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff7.TabIndex = 351;
            this.btnOnOrOff7.Text = "写开断";
            this.btnOnOrOff7.UseVisualStyleBackColor = true;
            this.btnOnOrOff7.Click += new System.EventHandler(this.btnOnOrOff7_Click);
            // 
            // btnOnOrOff6
            // 
            this.btnOnOrOff6.Location = new System.Drawing.Point(180, 226);
            this.btnOnOrOff6.Name = "btnOnOrOff6";
            this.btnOnOrOff6.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff6.TabIndex = 350;
            this.btnOnOrOff6.Text = "写开断";
            this.btnOnOrOff6.UseVisualStyleBackColor = true;
            this.btnOnOrOff6.Click += new System.EventHandler(this.btnOnOrOff6_Click);
            // 
            // btnOnOrOff5
            // 
            this.btnOnOrOff5.Location = new System.Drawing.Point(180, 190);
            this.btnOnOrOff5.Name = "btnOnOrOff5";
            this.btnOnOrOff5.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff5.TabIndex = 349;
            this.btnOnOrOff5.Text = "写开断";
            this.btnOnOrOff5.UseVisualStyleBackColor = true;
            this.btnOnOrOff5.Click += new System.EventHandler(this.btnOnOrOff5_Click);
            // 
            // btnOnOrOff3
            // 
            this.btnOnOrOff3.Location = new System.Drawing.Point(180, 119);
            this.btnOnOrOff3.Name = "btnOnOrOff3";
            this.btnOnOrOff3.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff3.TabIndex = 348;
            this.btnOnOrOff3.Text = "写开断";
            this.btnOnOrOff3.UseVisualStyleBackColor = true;
            this.btnOnOrOff3.Click += new System.EventHandler(this.btnOnOrOff3_Click);
            // 
            // btnOnOrOff4
            // 
            this.btnOnOrOff4.Location = new System.Drawing.Point(180, 154);
            this.btnOnOrOff4.Name = "btnOnOrOff4";
            this.btnOnOrOff4.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff4.TabIndex = 347;
            this.btnOnOrOff4.Text = "写开断";
            this.btnOnOrOff4.UseVisualStyleBackColor = true;
            this.btnOnOrOff4.Click += new System.EventHandler(this.btnOnOrOff4_Click);
            // 
            // btnOnOrOff2
            // 
            this.btnOnOrOff2.Location = new System.Drawing.Point(180, 86);
            this.btnOnOrOff2.Name = "btnOnOrOff2";
            this.btnOnOrOff2.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff2.TabIndex = 346;
            this.btnOnOrOff2.Text = "写开断";
            this.btnOnOrOff2.UseVisualStyleBackColor = true;
            this.btnOnOrOff2.Click += new System.EventHandler(this.btnOnOrOff2_Click);
            // 
            // btnOnOrOff1
            // 
            this.btnOnOrOff1.Location = new System.Drawing.Point(180, 51);
            this.btnOnOrOff1.Name = "btnOnOrOff1";
            this.btnOnOrOff1.Size = new System.Drawing.Size(50, 23);
            this.btnOnOrOff1.TabIndex = 345;
            this.btnOnOrOff1.Text = "写开断";
            this.btnOnOrOff1.UseVisualStyleBackColor = true;
            this.btnOnOrOff1.Click += new System.EventHandler(this.btnOnOrOff1_Click);
            // 
            // cbOnOrOff8
            // 
            this.cbOnOrOff8.FormattingEnabled = true;
            this.cbOnOrOff8.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff8.Location = new System.Drawing.Point(351, 52);
            this.cbOnOrOff8.Name = "cbOnOrOff8";
            this.cbOnOrOff8.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff8.TabIndex = 344;
            // 
            // cbOnOrOff7
            // 
            this.cbOnOrOff7.FormattingEnabled = true;
            this.cbOnOrOff7.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff7.Location = new System.Drawing.Point(102, 267);
            this.cbOnOrOff7.Name = "cbOnOrOff7";
            this.cbOnOrOff7.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff7.TabIndex = 343;
            // 
            // cbOnOrOff6
            // 
            this.cbOnOrOff6.FormattingEnabled = true;
            this.cbOnOrOff6.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff6.Location = new System.Drawing.Point(102, 229);
            this.cbOnOrOff6.Name = "cbOnOrOff6";
            this.cbOnOrOff6.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff6.TabIndex = 342;
            // 
            // cbOnOrOff5
            // 
            this.cbOnOrOff5.FormattingEnabled = true;
            this.cbOnOrOff5.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff5.Location = new System.Drawing.Point(102, 193);
            this.cbOnOrOff5.Name = "cbOnOrOff5";
            this.cbOnOrOff5.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff5.TabIndex = 341;
            // 
            // cbOnOrOff4
            // 
            this.cbOnOrOff4.FormattingEnabled = true;
            this.cbOnOrOff4.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff4.Location = new System.Drawing.Point(102, 157);
            this.cbOnOrOff4.Name = "cbOnOrOff4";
            this.cbOnOrOff4.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff4.TabIndex = 340;
            // 
            // cbOnOrOff3
            // 
            this.cbOnOrOff3.FormattingEnabled = true;
            this.cbOnOrOff3.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff3.Location = new System.Drawing.Point(102, 121);
            this.cbOnOrOff3.Name = "cbOnOrOff3";
            this.cbOnOrOff3.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff3.TabIndex = 339;
            // 
            // cbOnOrOff2
            // 
            this.cbOnOrOff2.FormattingEnabled = true;
            this.cbOnOrOff2.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff2.Location = new System.Drawing.Point(102, 89);
            this.cbOnOrOff2.Name = "cbOnOrOff2";
            this.cbOnOrOff2.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff2.TabIndex = 338;
            // 
            // cbOnOrOff1
            // 
            this.cbOnOrOff1.FormattingEnabled = true;
            this.cbOnOrOff1.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbOnOrOff1.Location = new System.Drawing.Point(102, 54);
            this.cbOnOrOff1.Name = "cbOnOrOff1";
            this.cbOnOrOff1.Size = new System.Drawing.Size(62, 20);
            this.cbOnOrOff1.TabIndex = 337;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 336;
            this.label5.Text = "读写线圈状态";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(506, 231);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(101, 12);
            this.label31.TabIndex = 335;
            this.label31.Text = "第20路线圈状态：";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(506, 196);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(101, 12);
            this.label32.TabIndex = 334;
            this.label32.Text = "第19路线圈状态：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(506, 160);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(101, 12);
            this.label33.TabIndex = 333;
            this.label33.Text = "第18路线圈状态：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(506, 125);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(101, 12);
            this.label34.TabIndex = 332;
            this.label34.Text = "第17路线圈状态：";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(506, 89);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(101, 12);
            this.label35.TabIndex = 331;
            this.label35.Text = "第16路线圈状态：";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(506, 57);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(101, 12);
            this.label36.TabIndex = 330;
            this.label36.Text = "第15路线圈状态：";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(254, 268);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(101, 12);
            this.label37.TabIndex = 329;
            this.label37.Text = "第14路线圈状态：";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(254, 232);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(101, 12);
            this.label38.TabIndex = 328;
            this.label38.Text = "第13路线圈状态：";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(254, 195);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(101, 12);
            this.label39.TabIndex = 327;
            this.label39.Text = "第12路线圈状态：";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(252, 159);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(101, 12);
            this.label40.TabIndex = 326;
            this.label40.Text = "第11路线圈状态：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 325;
            this.label12.Text = "第10路线圈状态：";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(254, 89);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 12);
            this.label30.TabIndex = 324;
            this.label30.Text = "第9路线圈状态：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 323;
            this.label10.Text = "第8路线圈状态：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 322;
            this.label9.Text = "第7路线圈状态：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 321;
            this.label8.Text = "第6路线圈状态：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 320;
            this.label7.Text = "第5路线圈状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 319;
            this.label6.Text = "第4路线圈状态：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 318;
            this.label11.Text = "第3路线圈状态：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 12);
            this.label13.TabIndex = 317;
            this.label13.Text = "第2路线圈状态：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 12);
            this.label14.TabIndex = 316;
            this.label14.Text = "第1路线圈状态：";
            // 
            // metroTabPage9
            // 
            this.metroTabPage9.Controls.Add(this.metroPanel7);
            this.metroTabPage9.HorizontalScrollbar = true;
            this.metroTabPage9.HorizontalScrollbarBarColor = true;
            this.metroTabPage9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage9.HorizontalScrollbarSize = 10;
            this.metroTabPage9.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage9.Name = "metroTabPage9";
            this.metroTabPage9.Size = new System.Drawing.Size(557, 343);
            this.metroTabPage9.TabIndex = 1;
            this.metroTabPage9.Text = "设置组合";
            this.metroTabPage9.VerticalScrollbar = true;
            this.metroTabPage9.VerticalScrollbarBarColor = true;
            this.metroTabPage9.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage9.VerticalScrollbarSize = 10;
            // 
            // metroPanel7
            // 
            this.metroPanel7.AutoScroll = true;
            this.metroPanel7.Controls.Add(this.button5);
            this.metroPanel7.Controls.Add(this.button6);
            this.metroPanel7.Controls.Add(this.btnCombination20);
            this.metroPanel7.Controls.Add(this.cbCombination20);
            this.metroPanel7.Controls.Add(this.label15);
            this.metroPanel7.Controls.Add(this.btnCombination19);
            this.metroPanel7.Controls.Add(this.cbCombination19);
            this.metroPanel7.Controls.Add(this.label16);
            this.metroPanel7.Controls.Add(this.btnCombination9);
            this.metroPanel7.Controls.Add(this.cbCombination9);
            this.metroPanel7.Controls.Add(this.label17);
            this.metroPanel7.Controls.Add(this.btnCombination8);
            this.metroPanel7.Controls.Add(this.cbCombination8);
            this.metroPanel7.Controls.Add(this.label18);
            this.metroPanel7.Controls.Add(this.btnCombination18);
            this.metroPanel7.Controls.Add(this.cbCombination18);
            this.metroPanel7.Controls.Add(this.label19);
            this.metroPanel7.Controls.Add(this.btnCombination17);
            this.metroPanel7.Controls.Add(this.cbCombination17);
            this.metroPanel7.Controls.Add(this.label20);
            this.metroPanel7.Controls.Add(this.btnCombination16);
            this.metroPanel7.Controls.Add(this.cbCombination16);
            this.metroPanel7.Controls.Add(this.label21);
            this.metroPanel7.Controls.Add(this.btnCombination15);
            this.metroPanel7.Controls.Add(this.cbCombination15);
            this.metroPanel7.Controls.Add(this.label22);
            this.metroPanel7.Controls.Add(this.btnCombination14);
            this.metroPanel7.Controls.Add(this.cbCombination14);
            this.metroPanel7.Controls.Add(this.label23);
            this.metroPanel7.Controls.Add(this.btnCombination13);
            this.metroPanel7.Controls.Add(this.cbCombination13);
            this.metroPanel7.Controls.Add(this.label24);
            this.metroPanel7.Controls.Add(this.btnCombination12);
            this.metroPanel7.Controls.Add(this.cbCombination12);
            this.metroPanel7.Controls.Add(this.label25);
            this.metroPanel7.Controls.Add(this.btnCombination11);
            this.metroPanel7.Controls.Add(this.cbCombination11);
            this.metroPanel7.Controls.Add(this.label26);
            this.metroPanel7.Controls.Add(this.btnCombination10);
            this.metroPanel7.Controls.Add(this.cbCombination10);
            this.metroPanel7.Controls.Add(this.label27);
            this.metroPanel7.Controls.Add(this.btnCombination7);
            this.metroPanel7.Controls.Add(this.cbCombination7);
            this.metroPanel7.Controls.Add(this.label28);
            this.metroPanel7.Controls.Add(this.btnCombination6);
            this.metroPanel7.Controls.Add(this.cbCombination6);
            this.metroPanel7.Controls.Add(this.label29);
            this.metroPanel7.Controls.Add(this.btnCombination5);
            this.metroPanel7.Controls.Add(this.cbCombination5);
            this.metroPanel7.Controls.Add(this.label41);
            this.metroPanel7.Controls.Add(this.btnCombination4);
            this.metroPanel7.Controls.Add(this.cbCombination4);
            this.metroPanel7.Controls.Add(this.label42);
            this.metroPanel7.Controls.Add(this.btnCombination3);
            this.metroPanel7.Controls.Add(this.cbCombination3);
            this.metroPanel7.Controls.Add(this.label43);
            this.metroPanel7.Controls.Add(this.btnCombination2);
            this.metroPanel7.Controls.Add(this.cbCombination2);
            this.metroPanel7.Controls.Add(this.label44);
            this.metroPanel7.Controls.Add(this.btnCombination1);
            this.metroPanel7.Controls.Add(this.cbCombination1);
            this.metroPanel7.Controls.Add(this.label45);
            this.metroPanel7.Controls.Add(this.label46);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel7.HorizontalScrollbar = true;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(0, 0);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(557, 343);
            this.metroPanel7.TabIndex = 2;
            this.metroPanel7.VerticalScrollbar = true;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 298;
            this.button5.Text = "获取当前设置";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(271, 373);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 23);
            this.button6.TabIndex = 297;
            this.button6.Text = "保存当前设置";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCombination20
            // 
            this.btnCombination20.Location = new System.Drawing.Point(861, 279);
            this.btnCombination20.Name = "btnCombination20";
            this.btnCombination20.Size = new System.Drawing.Size(50, 23);
            this.btnCombination20.TabIndex = 296;
            this.btnCombination20.Text = "确定";
            this.btnCombination20.UseVisualStyleBackColor = true;
            this.btnCombination20.Click += new System.EventHandler(this.btnCombination20_Click);
            // 
            // cbCombination20
            // 
            this.cbCombination20.FormattingEnabled = true;
            this.cbCombination20.Location = new System.Drawing.Point(725, 281);
            this.cbCombination20.Name = "cbCombination20";
            this.cbCombination20.Size = new System.Drawing.Size(130, 20);
            this.cbCombination20.TabIndex = 295;
            this.cbCombination20.Text = "无";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(629, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 12);
            this.label15.TabIndex = 294;
            this.label15.Text = "20选择组合方式：";
            // 
            // btnCombination19
            // 
            this.btnCombination19.Location = new System.Drawing.Point(861, 236);
            this.btnCombination19.Name = "btnCombination19";
            this.btnCombination19.Size = new System.Drawing.Size(50, 23);
            this.btnCombination19.TabIndex = 293;
            this.btnCombination19.Text = "确定";
            this.btnCombination19.UseVisualStyleBackColor = true;
            this.btnCombination19.Click += new System.EventHandler(this.btnCombination19_Click);
            // 
            // cbCombination19
            // 
            this.cbCombination19.FormattingEnabled = true;
            this.cbCombination19.Location = new System.Drawing.Point(725, 238);
            this.cbCombination19.Name = "cbCombination19";
            this.cbCombination19.Size = new System.Drawing.Size(130, 20);
            this.cbCombination19.TabIndex = 292;
            this.cbCombination19.Text = "无";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(629, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 12);
            this.label16.TabIndex = 291;
            this.label16.Text = "19选择组合方式：";
            // 
            // btnCombination9
            // 
            this.btnCombination9.Location = new System.Drawing.Point(564, 108);
            this.btnCombination9.Name = "btnCombination9";
            this.btnCombination9.Size = new System.Drawing.Size(50, 23);
            this.btnCombination9.TabIndex = 290;
            this.btnCombination9.Text = "确定";
            this.btnCombination9.UseVisualStyleBackColor = true;
            this.btnCombination9.Click += new System.EventHandler(this.btnCombination9_Click);
            // 
            // cbCombination9
            // 
            this.cbCombination9.FormattingEnabled = true;
            this.cbCombination9.Location = new System.Drawing.Point(428, 110);
            this.cbCombination9.Name = "cbCombination9";
            this.cbCombination9.Size = new System.Drawing.Size(130, 20);
            this.cbCombination9.TabIndex = 289;
            this.cbCombination9.Text = "无";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(327, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 12);
            this.label17.TabIndex = 288;
            this.label17.Text = "9选择组合方式：";
            // 
            // btnCombination8
            // 
            this.btnCombination8.Location = new System.Drawing.Point(564, 69);
            this.btnCombination8.Name = "btnCombination8";
            this.btnCombination8.Size = new System.Drawing.Size(50, 23);
            this.btnCombination8.TabIndex = 287;
            this.btnCombination8.Text = "确定";
            this.btnCombination8.UseVisualStyleBackColor = true;
            this.btnCombination8.Click += new System.EventHandler(this.btnCombination8_Click);
            // 
            // cbCombination8
            // 
            this.cbCombination8.FormattingEnabled = true;
            this.cbCombination8.Location = new System.Drawing.Point(428, 71);
            this.cbCombination8.Name = "cbCombination8";
            this.cbCombination8.Size = new System.Drawing.Size(130, 20);
            this.cbCombination8.TabIndex = 286;
            this.cbCombination8.Text = "无";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(327, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 12);
            this.label18.TabIndex = 285;
            this.label18.Text = "8选择组合方式：";
            // 
            // btnCombination18
            // 
            this.btnCombination18.Location = new System.Drawing.Point(861, 194);
            this.btnCombination18.Name = "btnCombination18";
            this.btnCombination18.Size = new System.Drawing.Size(50, 23);
            this.btnCombination18.TabIndex = 284;
            this.btnCombination18.Text = "确定";
            this.btnCombination18.UseVisualStyleBackColor = true;
            this.btnCombination18.Click += new System.EventHandler(this.btnCombination18_Click);
            // 
            // cbCombination18
            // 
            this.cbCombination18.FormattingEnabled = true;
            this.cbCombination18.Location = new System.Drawing.Point(725, 196);
            this.cbCombination18.Name = "cbCombination18";
            this.cbCombination18.Size = new System.Drawing.Size(130, 20);
            this.cbCombination18.TabIndex = 283;
            this.cbCombination18.Text = "无";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(629, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 12);
            this.label19.TabIndex = 282;
            this.label19.Text = "18选择组合方式：";
            // 
            // btnCombination17
            // 
            this.btnCombination17.Location = new System.Drawing.Point(861, 151);
            this.btnCombination17.Name = "btnCombination17";
            this.btnCombination17.Size = new System.Drawing.Size(50, 23);
            this.btnCombination17.TabIndex = 281;
            this.btnCombination17.Text = "确定";
            this.btnCombination17.UseVisualStyleBackColor = true;
            this.btnCombination17.Click += new System.EventHandler(this.btnCombination17_Click);
            // 
            // cbCombination17
            // 
            this.cbCombination17.FormattingEnabled = true;
            this.cbCombination17.Location = new System.Drawing.Point(725, 153);
            this.cbCombination17.Name = "cbCombination17";
            this.cbCombination17.Size = new System.Drawing.Size(130, 20);
            this.cbCombination17.TabIndex = 280;
            this.cbCombination17.Text = "无";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(629, 156);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 12);
            this.label20.TabIndex = 279;
            this.label20.Text = "17选择组合方式：";
            // 
            // btnCombination16
            // 
            this.btnCombination16.Location = new System.Drawing.Point(861, 108);
            this.btnCombination16.Name = "btnCombination16";
            this.btnCombination16.Size = new System.Drawing.Size(50, 23);
            this.btnCombination16.TabIndex = 278;
            this.btnCombination16.Text = "确定";
            this.btnCombination16.UseVisualStyleBackColor = true;
            this.btnCombination16.Click += new System.EventHandler(this.btnCombination16_Click);
            // 
            // cbCombination16
            // 
            this.cbCombination16.FormattingEnabled = true;
            this.cbCombination16.Location = new System.Drawing.Point(725, 110);
            this.cbCombination16.Name = "cbCombination16";
            this.cbCombination16.Size = new System.Drawing.Size(130, 20);
            this.cbCombination16.TabIndex = 277;
            this.cbCombination16.Text = "无";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(629, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 12);
            this.label21.TabIndex = 276;
            this.label21.Text = "16选择组合方式：";
            // 
            // btnCombination15
            // 
            this.btnCombination15.Location = new System.Drawing.Point(861, 69);
            this.btnCombination15.Name = "btnCombination15";
            this.btnCombination15.Size = new System.Drawing.Size(50, 23);
            this.btnCombination15.TabIndex = 275;
            this.btnCombination15.Text = "确定";
            this.btnCombination15.UseVisualStyleBackColor = true;
            this.btnCombination15.Click += new System.EventHandler(this.btnCombination15_Click);
            // 
            // cbCombination15
            // 
            this.cbCombination15.FormattingEnabled = true;
            this.cbCombination15.Location = new System.Drawing.Point(725, 71);
            this.cbCombination15.Name = "cbCombination15";
            this.cbCombination15.Size = new System.Drawing.Size(130, 20);
            this.cbCombination15.TabIndex = 274;
            this.cbCombination15.Text = "无";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(629, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 12);
            this.label22.TabIndex = 273;
            this.label22.Text = "15选择组合方式：";
            // 
            // btnCombination14
            // 
            this.btnCombination14.Location = new System.Drawing.Point(564, 325);
            this.btnCombination14.Name = "btnCombination14";
            this.btnCombination14.Size = new System.Drawing.Size(50, 23);
            this.btnCombination14.TabIndex = 272;
            this.btnCombination14.Text = "确定";
            this.btnCombination14.UseVisualStyleBackColor = true;
            this.btnCombination14.Click += new System.EventHandler(this.btnCombination14_Click);
            // 
            // cbCombination14
            // 
            this.cbCombination14.FormattingEnabled = true;
            this.cbCombination14.Location = new System.Drawing.Point(428, 327);
            this.cbCombination14.Name = "cbCombination14";
            this.cbCombination14.Size = new System.Drawing.Size(130, 20);
            this.cbCombination14.TabIndex = 271;
            this.cbCombination14.Text = "无";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(327, 330);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 12);
            this.label23.TabIndex = 270;
            this.label23.Text = "14选择组合方式：";
            // 
            // btnCombination13
            // 
            this.btnCombination13.Location = new System.Drawing.Point(564, 283);
            this.btnCombination13.Name = "btnCombination13";
            this.btnCombination13.Size = new System.Drawing.Size(50, 23);
            this.btnCombination13.TabIndex = 269;
            this.btnCombination13.Text = "确定";
            this.btnCombination13.UseVisualStyleBackColor = true;
            this.btnCombination13.Click += new System.EventHandler(this.btnCombination13_Click);
            // 
            // cbCombination13
            // 
            this.cbCombination13.FormattingEnabled = true;
            this.cbCombination13.Location = new System.Drawing.Point(428, 285);
            this.cbCombination13.Name = "cbCombination13";
            this.cbCombination13.Size = new System.Drawing.Size(130, 20);
            this.cbCombination13.TabIndex = 268;
            this.cbCombination13.Text = "无";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(327, 288);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 12);
            this.label24.TabIndex = 267;
            this.label24.Text = "13选择组合方式：";
            // 
            // btnCombination12
            // 
            this.btnCombination12.Location = new System.Drawing.Point(564, 236);
            this.btnCombination12.Name = "btnCombination12";
            this.btnCombination12.Size = new System.Drawing.Size(50, 23);
            this.btnCombination12.TabIndex = 266;
            this.btnCombination12.Text = "确定";
            this.btnCombination12.UseVisualStyleBackColor = true;
            this.btnCombination12.Click += new System.EventHandler(this.btnCombination12_Click);
            // 
            // cbCombination12
            // 
            this.cbCombination12.FormattingEnabled = true;
            this.cbCombination12.Location = new System.Drawing.Point(428, 238);
            this.cbCombination12.Name = "cbCombination12";
            this.cbCombination12.Size = new System.Drawing.Size(130, 20);
            this.cbCombination12.TabIndex = 265;
            this.cbCombination12.Text = "无";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(327, 241);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 12);
            this.label25.TabIndex = 264;
            this.label25.Text = "12选择组合方式：";
            // 
            // btnCombination11
            // 
            this.btnCombination11.Location = new System.Drawing.Point(564, 194);
            this.btnCombination11.Name = "btnCombination11";
            this.btnCombination11.Size = new System.Drawing.Size(50, 23);
            this.btnCombination11.TabIndex = 263;
            this.btnCombination11.Text = "确定";
            this.btnCombination11.UseVisualStyleBackColor = true;
            this.btnCombination11.Click += new System.EventHandler(this.btnCombination11_Click);
            // 
            // cbCombination11
            // 
            this.cbCombination11.FormattingEnabled = true;
            this.cbCombination11.Location = new System.Drawing.Point(428, 196);
            this.cbCombination11.Name = "cbCombination11";
            this.cbCombination11.Size = new System.Drawing.Size(130, 20);
            this.cbCombination11.TabIndex = 262;
            this.cbCombination11.Text = "无";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(327, 199);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 12);
            this.label26.TabIndex = 261;
            this.label26.Text = "11选择组合方式：";
            // 
            // btnCombination10
            // 
            this.btnCombination10.Location = new System.Drawing.Point(564, 151);
            this.btnCombination10.Name = "btnCombination10";
            this.btnCombination10.Size = new System.Drawing.Size(50, 23);
            this.btnCombination10.TabIndex = 260;
            this.btnCombination10.Text = "确定";
            this.btnCombination10.UseVisualStyleBackColor = true;
            this.btnCombination10.Click += new System.EventHandler(this.btnCombination10_Click);
            // 
            // cbCombination10
            // 
            this.cbCombination10.FormattingEnabled = true;
            this.cbCombination10.Location = new System.Drawing.Point(428, 153);
            this.cbCombination10.Name = "cbCombination10";
            this.cbCombination10.Size = new System.Drawing.Size(130, 20);
            this.cbCombination10.TabIndex = 259;
            this.cbCombination10.Text = "无";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(327, 156);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 12);
            this.label27.TabIndex = 258;
            this.label27.Text = "10选择组合方式：";
            // 
            // btnCombination7
            // 
            this.btnCombination7.Location = new System.Drawing.Point(271, 317);
            this.btnCombination7.Name = "btnCombination7";
            this.btnCombination7.Size = new System.Drawing.Size(50, 23);
            this.btnCombination7.TabIndex = 257;
            this.btnCombination7.Text = "确定";
            this.btnCombination7.UseVisualStyleBackColor = true;
            this.btnCombination7.Click += new System.EventHandler(this.btnCombination7_Click);
            // 
            // cbCombination7
            // 
            this.cbCombination7.FormattingEnabled = true;
            this.cbCombination7.Location = new System.Drawing.Point(135, 319);
            this.cbCombination7.Name = "cbCombination7";
            this.cbCombination7.Size = new System.Drawing.Size(130, 20);
            this.cbCombination7.TabIndex = 256;
            this.cbCombination7.Text = "无";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(34, 330);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 12);
            this.label28.TabIndex = 255;
            this.label28.Text = "7选择组合方式：";
            // 
            // btnCombination6
            // 
            this.btnCombination6.Location = new System.Drawing.Point(271, 278);
            this.btnCombination6.Name = "btnCombination6";
            this.btnCombination6.Size = new System.Drawing.Size(50, 23);
            this.btnCombination6.TabIndex = 254;
            this.btnCombination6.Text = "确定";
            this.btnCombination6.UseVisualStyleBackColor = true;
            this.btnCombination6.Click += new System.EventHandler(this.btnCombination6_Click);
            // 
            // cbCombination6
            // 
            this.cbCombination6.FormattingEnabled = true;
            this.cbCombination6.Location = new System.Drawing.Point(135, 280);
            this.cbCombination6.Name = "cbCombination6";
            this.cbCombination6.Size = new System.Drawing.Size(130, 20);
            this.cbCombination6.TabIndex = 253;
            this.cbCombination6.Text = "无";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(34, 288);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 12);
            this.label29.TabIndex = 252;
            this.label29.Text = "6选择组合方式：";
            // 
            // btnCombination5
            // 
            this.btnCombination5.Location = new System.Drawing.Point(271, 231);
            this.btnCombination5.Name = "btnCombination5";
            this.btnCombination5.Size = new System.Drawing.Size(50, 23);
            this.btnCombination5.TabIndex = 251;
            this.btnCombination5.Text = "确定";
            this.btnCombination5.UseVisualStyleBackColor = true;
            this.btnCombination5.Click += new System.EventHandler(this.btnCombination5_Click);
            // 
            // cbCombination5
            // 
            this.cbCombination5.FormattingEnabled = true;
            this.cbCombination5.Location = new System.Drawing.Point(135, 233);
            this.cbCombination5.Name = "cbCombination5";
            this.cbCombination5.Size = new System.Drawing.Size(130, 20);
            this.cbCombination5.TabIndex = 250;
            this.cbCombination5.Text = "无";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(34, 241);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(95, 12);
            this.label41.TabIndex = 249;
            this.label41.Text = "5选择组合方式：";
            // 
            // btnCombination4
            // 
            this.btnCombination4.Location = new System.Drawing.Point(271, 189);
            this.btnCombination4.Name = "btnCombination4";
            this.btnCombination4.Size = new System.Drawing.Size(50, 23);
            this.btnCombination4.TabIndex = 248;
            this.btnCombination4.Text = "确定";
            this.btnCombination4.UseVisualStyleBackColor = true;
            this.btnCombination4.Click += new System.EventHandler(this.btnCombination4_Click);
            // 
            // cbCombination4
            // 
            this.cbCombination4.FormattingEnabled = true;
            this.cbCombination4.Location = new System.Drawing.Point(135, 191);
            this.cbCombination4.Name = "cbCombination4";
            this.cbCombination4.Size = new System.Drawing.Size(130, 20);
            this.cbCombination4.TabIndex = 247;
            this.cbCombination4.Text = "无";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(34, 199);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(95, 12);
            this.label42.TabIndex = 246;
            this.label42.Text = "4选择组合方式：";
            // 
            // btnCombination3
            // 
            this.btnCombination3.Location = new System.Drawing.Point(271, 146);
            this.btnCombination3.Name = "btnCombination3";
            this.btnCombination3.Size = new System.Drawing.Size(50, 23);
            this.btnCombination3.TabIndex = 245;
            this.btnCombination3.Text = "确定";
            this.btnCombination3.UseVisualStyleBackColor = true;
            this.btnCombination3.Click += new System.EventHandler(this.btnCombination3_Click);
            // 
            // cbCombination3
            // 
            this.cbCombination3.FormattingEnabled = true;
            this.cbCombination3.Location = new System.Drawing.Point(135, 148);
            this.cbCombination3.Name = "cbCombination3";
            this.cbCombination3.Size = new System.Drawing.Size(130, 20);
            this.cbCombination3.TabIndex = 244;
            this.cbCombination3.Text = "无";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(34, 156);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(95, 12);
            this.label43.TabIndex = 243;
            this.label43.Text = "3选择组合方式：";
            // 
            // btnCombination2
            // 
            this.btnCombination2.Location = new System.Drawing.Point(271, 103);
            this.btnCombination2.Name = "btnCombination2";
            this.btnCombination2.Size = new System.Drawing.Size(50, 23);
            this.btnCombination2.TabIndex = 242;
            this.btnCombination2.Text = "确定";
            this.btnCombination2.UseVisualStyleBackColor = true;
            this.btnCombination2.Click += new System.EventHandler(this.btnCombination2_Click);
            // 
            // cbCombination2
            // 
            this.cbCombination2.FormattingEnabled = true;
            this.cbCombination2.Location = new System.Drawing.Point(135, 105);
            this.cbCombination2.Name = "cbCombination2";
            this.cbCombination2.Size = new System.Drawing.Size(130, 20);
            this.cbCombination2.TabIndex = 241;
            this.cbCombination2.Text = "无";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(34, 113);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(95, 12);
            this.label44.TabIndex = 240;
            this.label44.Text = "2选择组合方式：";
            // 
            // btnCombination1
            // 
            this.btnCombination1.Location = new System.Drawing.Point(271, 64);
            this.btnCombination1.Name = "btnCombination1";
            this.btnCombination1.Size = new System.Drawing.Size(50, 23);
            this.btnCombination1.TabIndex = 239;
            this.btnCombination1.Text = "确定";
            this.btnCombination1.UseVisualStyleBackColor = true;
            this.btnCombination1.Click += new System.EventHandler(this.btnCombination1_Click);
            // 
            // cbCombination1
            // 
            this.cbCombination1.FormattingEnabled = true;
            this.cbCombination1.Location = new System.Drawing.Point(135, 66);
            this.cbCombination1.Name = "cbCombination1";
            this.cbCombination1.Size = new System.Drawing.Size(130, 20);
            this.cbCombination1.TabIndex = 238;
            this.cbCombination1.Text = "无";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(34, 74);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(95, 12);
            this.label45.TabIndex = 237;
            this.label45.Text = "1选择组合方式：";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label46.Location = new System.Drawing.Point(33, 20);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(110, 16);
            this.label46.TabIndex = 236;
            this.label46.Text = "设置组合方式";
            // 
            // metroTabPage10
            // 
            this.metroTabPage10.Controls.Add(this.metroPanel8);
            this.metroTabPage10.HorizontalScrollbar = true;
            this.metroTabPage10.HorizontalScrollbarBarColor = true;
            this.metroTabPage10.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage10.HorizontalScrollbarSize = 10;
            this.metroTabPage10.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage10.Name = "metroTabPage10";
            this.metroTabPage10.Size = new System.Drawing.Size(557, 343);
            this.metroTabPage10.TabIndex = 2;
            this.metroTabPage10.Text = "设置工作和延迟";
            this.metroTabPage10.VerticalScrollbar = true;
            this.metroTabPage10.VerticalScrollbarBarColor = true;
            this.metroTabPage10.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage10.VerticalScrollbarSize = 10;
            // 
            // metroPanel8
            // 
            this.metroPanel8.AutoScroll = true;
            this.metroPanel8.Controls.Add(this.txtDelayTime13);
            this.metroPanel8.Controls.Add(this.button7);
            this.metroPanel8.Controls.Add(this.button8);
            this.metroPanel8.Controls.Add(this.btnDelay20);
            this.metroPanel8.Controls.Add(this.btnDelay19);
            this.metroPanel8.Controls.Add(this.txtDelayTime20);
            this.metroPanel8.Controls.Add(this.txtDelayTime19);
            this.metroPanel8.Controls.Add(this.label47);
            this.metroPanel8.Controls.Add(this.label48);
            this.metroPanel8.Controls.Add(this.btnDelay18);
            this.metroPanel8.Controls.Add(this.btnDelay17);
            this.metroPanel8.Controls.Add(this.btnDelay16);
            this.metroPanel8.Controls.Add(this.btnDelay15);
            this.metroPanel8.Controls.Add(this.btnDelay13);
            this.metroPanel8.Controls.Add(this.btnDelay14);
            this.metroPanel8.Controls.Add(this.btnDelay12);
            this.metroPanel8.Controls.Add(this.btnDelay11);
            this.metroPanel8.Controls.Add(this.txtDelayTime18);
            this.metroPanel8.Controls.Add(this.txtDelayTime17);
            this.metroPanel8.Controls.Add(this.txtDelayTime16);
            this.metroPanel8.Controls.Add(this.txtDelayTime15);
            this.metroPanel8.Controls.Add(this.txtDelayTime14);
            this.metroPanel8.Controls.Add(this.txtDelayTime12);
            this.metroPanel8.Controls.Add(this.txtDelayTime11);
            this.metroPanel8.Controls.Add(this.label57);
            this.metroPanel8.Controls.Add(this.label58);
            this.metroPanel8.Controls.Add(this.label59);
            this.metroPanel8.Controls.Add(this.label60);
            this.metroPanel8.Controls.Add(this.label61);
            this.metroPanel8.Controls.Add(this.label62);
            this.metroPanel8.Controls.Add(this.label63);
            this.metroPanel8.Controls.Add(this.label64);
            this.metroPanel8.Controls.Add(this.btnDelay10);
            this.metroPanel8.Controls.Add(this.btnDelay9);
            this.metroPanel8.Controls.Add(this.txtDelayTime10);
            this.metroPanel8.Controls.Add(this.txtDelayTime9);
            this.metroPanel8.Controls.Add(this.label49);
            this.metroPanel8.Controls.Add(this.label50);
            this.metroPanel8.Controls.Add(this.btnMode20);
            this.metroPanel8.Controls.Add(this.btnMode19);
            this.metroPanel8.Controls.Add(this.cbMode20);
            this.metroPanel8.Controls.Add(this.label51);
            this.metroPanel8.Controls.Add(this.cbMode19);
            this.metroPanel8.Controls.Add(this.label52);
            this.metroPanel8.Controls.Add(this.btnMode18);
            this.metroPanel8.Controls.Add(this.btnMode17);
            this.metroPanel8.Controls.Add(this.btnMode16);
            this.metroPanel8.Controls.Add(this.btnMode15);
            this.metroPanel8.Controls.Add(this.btnMode13);
            this.metroPanel8.Controls.Add(this.btnMode14);
            this.metroPanel8.Controls.Add(this.btnMode12);
            this.metroPanel8.Controls.Add(this.btnMode11);
            this.metroPanel8.Controls.Add(this.cbMode18);
            this.metroPanel8.Controls.Add(this.label53);
            this.metroPanel8.Controls.Add(this.cbMode17);
            this.metroPanel8.Controls.Add(this.label54);
            this.metroPanel8.Controls.Add(this.cbMode16);
            this.metroPanel8.Controls.Add(this.label55);
            this.metroPanel8.Controls.Add(this.cbMode15);
            this.metroPanel8.Controls.Add(this.label56);
            this.metroPanel8.Controls.Add(this.cbMode14);
            this.metroPanel8.Controls.Add(this.label65);
            this.metroPanel8.Controls.Add(this.cbMode13);
            this.metroPanel8.Controls.Add(this.label66);
            this.metroPanel8.Controls.Add(this.cbMode12);
            this.metroPanel8.Controls.Add(this.label67);
            this.metroPanel8.Controls.Add(this.cbMode11);
            this.metroPanel8.Controls.Add(this.label68);
            this.metroPanel8.Controls.Add(this.btnMode10);
            this.metroPanel8.Controls.Add(this.btnMode9);
            this.metroPanel8.Controls.Add(this.cbMode10);
            this.metroPanel8.Controls.Add(this.label69);
            this.metroPanel8.Controls.Add(this.cbMode9);
            this.metroPanel8.Controls.Add(this.label70);
            this.metroPanel8.Controls.Add(this.btnDelay8);
            this.metroPanel8.Controls.Add(this.btnDelay7);
            this.metroPanel8.Controls.Add(this.btnDelay6);
            this.metroPanel8.Controls.Add(this.btnDelay5);
            this.metroPanel8.Controls.Add(this.btnDelay3);
            this.metroPanel8.Controls.Add(this.btnDelay4);
            this.metroPanel8.Controls.Add(this.btnDelay2);
            this.metroPanel8.Controls.Add(this.btnDelay1);
            this.metroPanel8.Controls.Add(this.btnMode8);
            this.metroPanel8.Controls.Add(this.btnMode7);
            this.metroPanel8.Controls.Add(this.btnMode6);
            this.metroPanel8.Controls.Add(this.btnMode5);
            this.metroPanel8.Controls.Add(this.btnMode3);
            this.metroPanel8.Controls.Add(this.btnMode4);
            this.metroPanel8.Controls.Add(this.btnMode2);
            this.metroPanel8.Controls.Add(this.btnMode1);
            this.metroPanel8.Controls.Add(this.txtDelayTime8);
            this.metroPanel8.Controls.Add(this.txtDelayTime7);
            this.metroPanel8.Controls.Add(this.txtDelayTime6);
            this.metroPanel8.Controls.Add(this.txtDelayTime5);
            this.metroPanel8.Controls.Add(this.txtDelayTime4);
            this.metroPanel8.Controls.Add(this.txtDelayTime3);
            this.metroPanel8.Controls.Add(this.txtDelayTime2);
            this.metroPanel8.Controls.Add(this.label71);
            this.metroPanel8.Controls.Add(this.txtDelayTime1);
            this.metroPanel8.Controls.Add(this.label72);
            this.metroPanel8.Controls.Add(this.label73);
            this.metroPanel8.Controls.Add(this.label74);
            this.metroPanel8.Controls.Add(this.label75);
            this.metroPanel8.Controls.Add(this.label76);
            this.metroPanel8.Controls.Add(this.label77);
            this.metroPanel8.Controls.Add(this.label78);
            this.metroPanel8.Controls.Add(this.label79);
            this.metroPanel8.Controls.Add(this.label80);
            this.metroPanel8.Controls.Add(this.cbMode8);
            this.metroPanel8.Controls.Add(this.label81);
            this.metroPanel8.Controls.Add(this.cbMode7);
            this.metroPanel8.Controls.Add(this.label82);
            this.metroPanel8.Controls.Add(this.cbMode6);
            this.metroPanel8.Controls.Add(this.label83);
            this.metroPanel8.Controls.Add(this.cbMode5);
            this.metroPanel8.Controls.Add(this.label84);
            this.metroPanel8.Controls.Add(this.cbMode4);
            this.metroPanel8.Controls.Add(this.label85);
            this.metroPanel8.Controls.Add(this.cbMode3);
            this.metroPanel8.Controls.Add(this.label86);
            this.metroPanel8.Controls.Add(this.cbMode2);
            this.metroPanel8.Controls.Add(this.label87);
            this.metroPanel8.Controls.Add(this.label88);
            this.metroPanel8.Controls.Add(this.cbMode1);
            this.metroPanel8.Controls.Add(this.label89);
            this.metroPanel8.Controls.Add(this.label90);
            this.metroPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel8.HorizontalScrollbar = true;
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(0, 0);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(557, 343);
            this.metroPanel8.TabIndex = 2;
            this.metroPanel8.VerticalScrollbar = true;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            this.metroPanel8.Enter += new System.EventHandler(this.metroPanel8_Enter);
            // 
            // txtDelayTime13
            // 
            this.txtDelayTime13.Location = new System.Drawing.Point(598, 302);
            this.txtDelayTime13.Name = "txtDelayTime13";
            this.txtDelayTime13.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime13.TabIndex = 493;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(731, 399);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 23);
            this.button7.TabIndex = 492;
            this.button7.Text = "获取当前值";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(731, 465);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 23);
            this.button8.TabIndex = 491;
            this.button8.Text = "保存当前设置";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnDelay20
            // 
            this.btnDelay20.Location = new System.Drawing.Point(866, 336);
            this.btnDelay20.Name = "btnDelay20";
            this.btnDelay20.Size = new System.Drawing.Size(50, 23);
            this.btnDelay20.TabIndex = 490;
            this.btnDelay20.Text = "确定";
            this.btnDelay20.UseVisualStyleBackColor = true;
            this.btnDelay20.Click += new System.EventHandler(this.btnDelay20_Click);
            // 
            // btnDelay19
            // 
            this.btnDelay19.Location = new System.Drawing.Point(866, 300);
            this.btnDelay19.Name = "btnDelay19";
            this.btnDelay19.Size = new System.Drawing.Size(50, 23);
            this.btnDelay19.TabIndex = 489;
            this.btnDelay19.Text = "确定";
            this.btnDelay19.UseVisualStyleBackColor = true;
            this.btnDelay19.Click += new System.EventHandler(this.btnDelay19_Click);
            // 
            // txtDelayTime20
            // 
            this.txtDelayTime20.Location = new System.Drawing.Point(825, 337);
            this.txtDelayTime20.Name = "txtDelayTime20";
            this.txtDelayTime20.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime20.TabIndex = 488;
            // 
            // txtDelayTime19
            // 
            this.txtDelayTime19.Location = new System.Drawing.Point(825, 302);
            this.txtDelayTime19.Name = "txtDelayTime19";
            this.txtDelayTime19.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime19.TabIndex = 487;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(729, 340);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(101, 12);
            this.label47.TabIndex = 486;
            this.label47.Text = "第20路延迟时间：";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(729, 305);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(101, 12);
            this.label48.TabIndex = 485;
            this.label48.Text = "第19路延迟时间：";
            // 
            // btnDelay18
            // 
            this.btnDelay18.Location = new System.Drawing.Point(639, 473);
            this.btnDelay18.Name = "btnDelay18";
            this.btnDelay18.Size = new System.Drawing.Size(50, 23);
            this.btnDelay18.TabIndex = 484;
            this.btnDelay18.Text = "确定";
            this.btnDelay18.UseVisualStyleBackColor = true;
            this.btnDelay18.Click += new System.EventHandler(this.btnDelay18_Click);
            // 
            // btnDelay17
            // 
            this.btnDelay17.Location = new System.Drawing.Point(639, 440);
            this.btnDelay17.Name = "btnDelay17";
            this.btnDelay17.Size = new System.Drawing.Size(50, 23);
            this.btnDelay17.TabIndex = 483;
            this.btnDelay17.Text = "确定";
            this.btnDelay17.UseVisualStyleBackColor = true;
            this.btnDelay17.Click += new System.EventHandler(this.btnDelay17_Click);
            // 
            // btnDelay16
            // 
            this.btnDelay16.Location = new System.Drawing.Point(639, 405);
            this.btnDelay16.Name = "btnDelay16";
            this.btnDelay16.Size = new System.Drawing.Size(50, 23);
            this.btnDelay16.TabIndex = 482;
            this.btnDelay16.Text = "确定";
            this.btnDelay16.UseVisualStyleBackColor = true;
            this.btnDelay16.Click += new System.EventHandler(this.btnDelay16_Click);
            // 
            // btnDelay15
            // 
            this.btnDelay15.Location = new System.Drawing.Point(639, 369);
            this.btnDelay15.Name = "btnDelay15";
            this.btnDelay15.Size = new System.Drawing.Size(50, 23);
            this.btnDelay15.TabIndex = 481;
            this.btnDelay15.Text = "确定";
            this.btnDelay15.UseVisualStyleBackColor = true;
            this.btnDelay15.Click += new System.EventHandler(this.btnDelay15_Click);
            // 
            // btnDelay13
            // 
            this.btnDelay13.Location = new System.Drawing.Point(639, 298);
            this.btnDelay13.Name = "btnDelay13";
            this.btnDelay13.Size = new System.Drawing.Size(50, 23);
            this.btnDelay13.TabIndex = 480;
            this.btnDelay13.Text = "确定";
            this.btnDelay13.UseVisualStyleBackColor = true;
            this.btnDelay13.Click += new System.EventHandler(this.btnDelay13_Click);
            // 
            // btnDelay14
            // 
            this.btnDelay14.Location = new System.Drawing.Point(639, 335);
            this.btnDelay14.Name = "btnDelay14";
            this.btnDelay14.Size = new System.Drawing.Size(50, 23);
            this.btnDelay14.TabIndex = 479;
            this.btnDelay14.Text = "确定";
            this.btnDelay14.UseVisualStyleBackColor = true;
            this.btnDelay14.Click += new System.EventHandler(this.btnDelay14_Click);
            // 
            // btnDelay12
            // 
            this.btnDelay12.Location = new System.Drawing.Point(432, 471);
            this.btnDelay12.Name = "btnDelay12";
            this.btnDelay12.Size = new System.Drawing.Size(50, 23);
            this.btnDelay12.TabIndex = 478;
            this.btnDelay12.Text = "确定";
            this.btnDelay12.UseVisualStyleBackColor = true;
            this.btnDelay12.Click += new System.EventHandler(this.btnDelay12_Click);
            // 
            // btnDelay11
            // 
            this.btnDelay11.Location = new System.Drawing.Point(432, 435);
            this.btnDelay11.Name = "btnDelay11";
            this.btnDelay11.Size = new System.Drawing.Size(50, 23);
            this.btnDelay11.TabIndex = 477;
            this.btnDelay11.Text = "确定";
            this.btnDelay11.UseVisualStyleBackColor = true;
            this.btnDelay11.Click += new System.EventHandler(this.btnDelay11_Click);
            // 
            // txtDelayTime18
            // 
            this.txtDelayTime18.Location = new System.Drawing.Point(598, 473);
            this.txtDelayTime18.Name = "txtDelayTime18";
            this.txtDelayTime18.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime18.TabIndex = 476;
            // 
            // txtDelayTime17
            // 
            this.txtDelayTime17.Location = new System.Drawing.Point(598, 442);
            this.txtDelayTime17.Name = "txtDelayTime17";
            this.txtDelayTime17.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime17.TabIndex = 475;
            // 
            // txtDelayTime16
            // 
            this.txtDelayTime16.Location = new System.Drawing.Point(598, 407);
            this.txtDelayTime16.Name = "txtDelayTime16";
            this.txtDelayTime16.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime16.TabIndex = 474;
            // 
            // txtDelayTime15
            // 
            this.txtDelayTime15.Location = new System.Drawing.Point(598, 371);
            this.txtDelayTime15.Name = "txtDelayTime15";
            this.txtDelayTime15.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime15.TabIndex = 473;
            // 
            // txtDelayTime14
            // 
            this.txtDelayTime14.Location = new System.Drawing.Point(598, 337);
            this.txtDelayTime14.Name = "txtDelayTime14";
            this.txtDelayTime14.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime14.TabIndex = 472;
            // 
            // txtDelayTime12
            // 
            this.txtDelayTime12.Location = new System.Drawing.Point(391, 472);
            this.txtDelayTime12.Name = "txtDelayTime12";
            this.txtDelayTime12.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime12.TabIndex = 471;
            // 
            // txtDelayTime11
            // 
            this.txtDelayTime11.Location = new System.Drawing.Point(391, 437);
            this.txtDelayTime11.Name = "txtDelayTime11";
            this.txtDelayTime11.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime11.TabIndex = 470;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(504, 478);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(101, 12);
            this.label57.TabIndex = 469;
            this.label57.Text = "第18路延迟时间：";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(504, 445);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(101, 12);
            this.label58.TabIndex = 468;
            this.label58.Text = "第17路延迟时间：";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(504, 410);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(101, 12);
            this.label59.TabIndex = 467;
            this.label59.Text = "第16路延迟时间：";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(502, 375);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(101, 12);
            this.label60.TabIndex = 466;
            this.label60.Text = "第15路延迟时间：";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(502, 340);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(101, 12);
            this.label61.TabIndex = 465;
            this.label61.Text = "第14路延迟时间：";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(504, 305);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(101, 12);
            this.label62.TabIndex = 464;
            this.label62.Text = "第13路延迟时间：";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(295, 476);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(101, 12);
            this.label63.TabIndex = 463;
            this.label63.Text = "第12路延迟时间：";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(295, 440);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(101, 12);
            this.label64.TabIndex = 462;
            this.label64.Text = "第11路延迟时间：";
            // 
            // btnDelay10
            // 
            this.btnDelay10.Location = new System.Drawing.Point(432, 403);
            this.btnDelay10.Name = "btnDelay10";
            this.btnDelay10.Size = new System.Drawing.Size(50, 23);
            this.btnDelay10.TabIndex = 461;
            this.btnDelay10.Text = "确定";
            this.btnDelay10.UseVisualStyleBackColor = true;
            this.btnDelay10.Click += new System.EventHandler(this.btnDelay10_Click);
            // 
            // btnDelay9
            // 
            this.btnDelay9.Location = new System.Drawing.Point(432, 368);
            this.btnDelay9.Name = "btnDelay9";
            this.btnDelay9.Size = new System.Drawing.Size(50, 23);
            this.btnDelay9.TabIndex = 460;
            this.btnDelay9.Text = "确定";
            this.btnDelay9.UseVisualStyleBackColor = true;
            this.btnDelay9.Click += new System.EventHandler(this.btnDelay9_Click);
            // 
            // txtDelayTime10
            // 
            this.txtDelayTime10.Location = new System.Drawing.Point(391, 405);
            this.txtDelayTime10.Name = "txtDelayTime10";
            this.txtDelayTime10.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime10.TabIndex = 459;
            // 
            // txtDelayTime9
            // 
            this.txtDelayTime9.Location = new System.Drawing.Point(391, 370);
            this.txtDelayTime9.Name = "txtDelayTime9";
            this.txtDelayTime9.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime9.TabIndex = 458;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(295, 408);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(101, 12);
            this.label49.TabIndex = 457;
            this.label49.Text = "第10路延迟时间：";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(295, 373);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(95, 12);
            this.label50.TabIndex = 456;
            this.label50.Text = "第9路延迟时间：";
            // 
            // btnMode20
            // 
            this.btnMode20.Location = new System.Drawing.Point(890, 219);
            this.btnMode20.Name = "btnMode20";
            this.btnMode20.Size = new System.Drawing.Size(50, 23);
            this.btnMode20.TabIndex = 455;
            this.btnMode20.Text = "确定";
            this.btnMode20.UseVisualStyleBackColor = true;
            this.btnMode20.Click += new System.EventHandler(this.btnMode20_Click);
            // 
            // btnMode19
            // 
            this.btnMode19.Location = new System.Drawing.Point(890, 184);
            this.btnMode19.Name = "btnMode19";
            this.btnMode19.Size = new System.Drawing.Size(50, 23);
            this.btnMode19.TabIndex = 454;
            this.btnMode19.Text = "确定";
            this.btnMode19.UseVisualStyleBackColor = true;
            this.btnMode19.Click += new System.EventHandler(this.btnMode19_Click);
            // 
            // cbMode20
            // 
            this.cbMode20.FormattingEnabled = true;
            this.cbMode20.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode20.Location = new System.Drawing.Point(836, 220);
            this.cbMode20.Name = "cbMode20";
            this.cbMode20.Size = new System.Drawing.Size(48, 20);
            this.cbMode20.TabIndex = 453;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(729, 226);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(101, 12);
            this.label51.TabIndex = 452;
            this.label51.Text = "第20路工作模式：";
            // 
            // cbMode19
            // 
            this.cbMode19.FormattingEnabled = true;
            this.cbMode19.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode19.Location = new System.Drawing.Point(836, 185);
            this.cbMode19.Name = "cbMode19";
            this.cbMode19.Size = new System.Drawing.Size(48, 20);
            this.cbMode19.TabIndex = 451;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(729, 191);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(101, 12);
            this.label52.TabIndex = 450;
            this.label52.Text = "第19路工作模式：";
            // 
            // btnMode18
            // 
            this.btnMode18.Location = new System.Drawing.Point(890, 148);
            this.btnMode18.Name = "btnMode18";
            this.btnMode18.Size = new System.Drawing.Size(50, 23);
            this.btnMode18.TabIndex = 449;
            this.btnMode18.Text = "确定";
            this.btnMode18.UseVisualStyleBackColor = true;
            this.btnMode18.Click += new System.EventHandler(this.btnMode18_Click);
            // 
            // btnMode17
            // 
            this.btnMode17.Location = new System.Drawing.Point(890, 111);
            this.btnMode17.Name = "btnMode17";
            this.btnMode17.Size = new System.Drawing.Size(50, 23);
            this.btnMode17.TabIndex = 448;
            this.btnMode17.Text = "确定";
            this.btnMode17.UseVisualStyleBackColor = true;
            this.btnMode17.Click += new System.EventHandler(this.btnMode17_Click);
            // 
            // btnMode16
            // 
            this.btnMode16.Location = new System.Drawing.Point(890, 78);
            this.btnMode16.Name = "btnMode16";
            this.btnMode16.Size = new System.Drawing.Size(50, 23);
            this.btnMode16.TabIndex = 447;
            this.btnMode16.Text = "确定";
            this.btnMode16.UseVisualStyleBackColor = true;
            this.btnMode16.Click += new System.EventHandler(this.btnMode16_Click);
            // 
            // btnMode15
            // 
            this.btnMode15.Location = new System.Drawing.Point(659, 217);
            this.btnMode15.Name = "btnMode15";
            this.btnMode15.Size = new System.Drawing.Size(50, 23);
            this.btnMode15.TabIndex = 446;
            this.btnMode15.Text = "确定";
            this.btnMode15.UseVisualStyleBackColor = true;
            this.btnMode15.Click += new System.EventHandler(this.btnMode15_Click);
            // 
            // btnMode13
            // 
            this.btnMode13.Location = new System.Drawing.Point(659, 148);
            this.btnMode13.Name = "btnMode13";
            this.btnMode13.Size = new System.Drawing.Size(50, 23);
            this.btnMode13.TabIndex = 445;
            this.btnMode13.Text = "确定";
            this.btnMode13.UseVisualStyleBackColor = true;
            this.btnMode13.Click += new System.EventHandler(this.btnMode13_Click);
            // 
            // btnMode14
            // 
            this.btnMode14.Location = new System.Drawing.Point(659, 181);
            this.btnMode14.Name = "btnMode14";
            this.btnMode14.Size = new System.Drawing.Size(50, 23);
            this.btnMode14.TabIndex = 444;
            this.btnMode14.Text = "确定";
            this.btnMode14.UseVisualStyleBackColor = true;
            this.btnMode14.Click += new System.EventHandler(this.btnMode14_Click);
            // 
            // btnMode12
            // 
            this.btnMode12.Location = new System.Drawing.Point(659, 111);
            this.btnMode12.Name = "btnMode12";
            this.btnMode12.Size = new System.Drawing.Size(50, 23);
            this.btnMode12.TabIndex = 443;
            this.btnMode12.Text = "确定";
            this.btnMode12.UseVisualStyleBackColor = true;
            this.btnMode12.Click += new System.EventHandler(this.btnMode12_Click);
            // 
            // btnMode11
            // 
            this.btnMode11.Location = new System.Drawing.Point(659, 77);
            this.btnMode11.Name = "btnMode11";
            this.btnMode11.Size = new System.Drawing.Size(50, 23);
            this.btnMode11.TabIndex = 442;
            this.btnMode11.Text = "确定";
            this.btnMode11.UseVisualStyleBackColor = true;
            this.btnMode11.Click += new System.EventHandler(this.btnMode11_Click);
            // 
            // cbMode18
            // 
            this.cbMode18.FormattingEnabled = true;
            this.cbMode18.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode18.Location = new System.Drawing.Point(836, 149);
            this.cbMode18.Name = "cbMode18";
            this.cbMode18.Size = new System.Drawing.Size(48, 20);
            this.cbMode18.TabIndex = 441;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(729, 156);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(101, 12);
            this.label53.TabIndex = 440;
            this.label53.Text = "第18路工作模式：";
            // 
            // cbMode17
            // 
            this.cbMode17.FormattingEnabled = true;
            this.cbMode17.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode17.Location = new System.Drawing.Point(836, 113);
            this.cbMode17.Name = "cbMode17";
            this.cbMode17.Size = new System.Drawing.Size(48, 20);
            this.cbMode17.TabIndex = 439;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(729, 119);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(101, 12);
            this.label54.TabIndex = 438;
            this.label54.Text = "第17路工作模式：";
            // 
            // cbMode16
            // 
            this.cbMode16.FormattingEnabled = true;
            this.cbMode16.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode16.Location = new System.Drawing.Point(836, 79);
            this.cbMode16.Name = "cbMode16";
            this.cbMode16.Size = new System.Drawing.Size(48, 20);
            this.cbMode16.TabIndex = 437;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(729, 84);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(101, 12);
            this.label55.TabIndex = 436;
            this.label55.Text = "第16路工作模式：";
            // 
            // cbMode15
            // 
            this.cbMode15.FormattingEnabled = true;
            this.cbMode15.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode15.Location = new System.Drawing.Point(605, 219);
            this.cbMode15.Name = "cbMode15";
            this.cbMode15.Size = new System.Drawing.Size(48, 20);
            this.cbMode15.TabIndex = 435;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(504, 223);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(101, 12);
            this.label56.TabIndex = 434;
            this.label56.Text = "第15路工作模式：";
            // 
            // cbMode14
            // 
            this.cbMode14.FormattingEnabled = true;
            this.cbMode14.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode14.Location = new System.Drawing.Point(605, 185);
            this.cbMode14.Name = "cbMode14";
            this.cbMode14.Size = new System.Drawing.Size(48, 20);
            this.cbMode14.TabIndex = 433;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(504, 190);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(101, 12);
            this.label65.TabIndex = 432;
            this.label65.Text = "第14路工作模式：";
            // 
            // cbMode13
            // 
            this.cbMode13.FormattingEnabled = true;
            this.cbMode13.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode13.Location = new System.Drawing.Point(605, 151);
            this.cbMode13.Name = "cbMode13";
            this.cbMode13.Size = new System.Drawing.Size(48, 20);
            this.cbMode13.TabIndex = 431;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(504, 154);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(101, 12);
            this.label66.TabIndex = 430;
            this.label66.Text = "第13路工作模式：";
            // 
            // cbMode12
            // 
            this.cbMode12.FormattingEnabled = true;
            this.cbMode12.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode12.Location = new System.Drawing.Point(605, 114);
            this.cbMode12.Name = "cbMode12";
            this.cbMode12.Size = new System.Drawing.Size(48, 20);
            this.cbMode12.TabIndex = 429;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(504, 119);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(101, 12);
            this.label67.TabIndex = 428;
            this.label67.Text = "第12路工作模式：";
            // 
            // cbMode11
            // 
            this.cbMode11.FormattingEnabled = true;
            this.cbMode11.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode11.Location = new System.Drawing.Point(605, 80);
            this.cbMode11.Name = "cbMode11";
            this.cbMode11.Size = new System.Drawing.Size(48, 20);
            this.cbMode11.TabIndex = 427;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(504, 84);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(101, 12);
            this.label68.TabIndex = 426;
            this.label68.Text = "第11路工作模式：";
            // 
            // btnMode10
            // 
            this.btnMode10.Location = new System.Drawing.Point(444, 218);
            this.btnMode10.Name = "btnMode10";
            this.btnMode10.Size = new System.Drawing.Size(50, 23);
            this.btnMode10.TabIndex = 425;
            this.btnMode10.Text = "确定";
            this.btnMode10.UseVisualStyleBackColor = true;
            this.btnMode10.Click += new System.EventHandler(this.btnMode10_Click);
            // 
            // btnMode9
            // 
            this.btnMode9.Location = new System.Drawing.Point(444, 183);
            this.btnMode9.Name = "btnMode9";
            this.btnMode9.Size = new System.Drawing.Size(50, 23);
            this.btnMode9.TabIndex = 424;
            this.btnMode9.Text = "确定";
            this.btnMode9.UseVisualStyleBackColor = true;
            this.btnMode9.Click += new System.EventHandler(this.btnMode9_Click);
            // 
            // cbMode10
            // 
            this.cbMode10.FormattingEnabled = true;
            this.cbMode10.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode10.Location = new System.Drawing.Point(390, 220);
            this.cbMode10.Name = "cbMode10";
            this.cbMode10.Size = new System.Drawing.Size(48, 20);
            this.cbMode10.TabIndex = 423;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(289, 222);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(101, 12);
            this.label69.TabIndex = 422;
            this.label69.Text = "第10路工作模式：";
            // 
            // cbMode9
            // 
            this.cbMode9.FormattingEnabled = true;
            this.cbMode9.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode9.Location = new System.Drawing.Point(390, 184);
            this.cbMode9.Name = "cbMode9";
            this.cbMode9.Size = new System.Drawing.Size(48, 20);
            this.cbMode9.TabIndex = 421;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(289, 186);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(95, 12);
            this.label70.TabIndex = 420;
            this.label70.Text = "第9路工作模式：";
            // 
            // btnDelay8
            // 
            this.btnDelay8.Location = new System.Drawing.Point(432, 330);
            this.btnDelay8.Name = "btnDelay8";
            this.btnDelay8.Size = new System.Drawing.Size(50, 23);
            this.btnDelay8.TabIndex = 419;
            this.btnDelay8.Text = "确定";
            this.btnDelay8.UseVisualStyleBackColor = true;
            this.btnDelay8.Click += new System.EventHandler(this.btnDelay8_Click);
            // 
            // btnDelay7
            // 
            this.btnDelay7.Location = new System.Drawing.Point(432, 300);
            this.btnDelay7.Name = "btnDelay7";
            this.btnDelay7.Size = new System.Drawing.Size(50, 23);
            this.btnDelay7.TabIndex = 418;
            this.btnDelay7.Text = "确定";
            this.btnDelay7.UseVisualStyleBackColor = true;
            this.btnDelay7.Click += new System.EventHandler(this.btnDelay7_Click);
            // 
            // btnDelay6
            // 
            this.btnDelay6.Location = new System.Drawing.Point(204, 474);
            this.btnDelay6.Name = "btnDelay6";
            this.btnDelay6.Size = new System.Drawing.Size(50, 23);
            this.btnDelay6.TabIndex = 417;
            this.btnDelay6.Text = "确定";
            this.btnDelay6.UseVisualStyleBackColor = true;
            this.btnDelay6.Click += new System.EventHandler(this.btnDelay6_Click);
            // 
            // btnDelay5
            // 
            this.btnDelay5.Location = new System.Drawing.Point(204, 437);
            this.btnDelay5.Name = "btnDelay5";
            this.btnDelay5.Size = new System.Drawing.Size(50, 23);
            this.btnDelay5.TabIndex = 416;
            this.btnDelay5.Text = "确定";
            this.btnDelay5.UseVisualStyleBackColor = true;
            this.btnDelay5.Click += new System.EventHandler(this.btnDelay5_Click);
            // 
            // btnDelay3
            // 
            this.btnDelay3.Location = new System.Drawing.Point(204, 366);
            this.btnDelay3.Name = "btnDelay3";
            this.btnDelay3.Size = new System.Drawing.Size(50, 23);
            this.btnDelay3.TabIndex = 415;
            this.btnDelay3.Text = "确定";
            this.btnDelay3.UseVisualStyleBackColor = true;
            this.btnDelay3.Click += new System.EventHandler(this.btnDelay3_Click);
            // 
            // btnDelay4
            // 
            this.btnDelay4.Location = new System.Drawing.Point(204, 401);
            this.btnDelay4.Name = "btnDelay4";
            this.btnDelay4.Size = new System.Drawing.Size(50, 23);
            this.btnDelay4.TabIndex = 414;
            this.btnDelay4.Text = "确定";
            this.btnDelay4.UseVisualStyleBackColor = true;
            this.btnDelay4.Click += new System.EventHandler(this.btnDelay4_Click);
            // 
            // btnDelay2
            // 
            this.btnDelay2.Location = new System.Drawing.Point(204, 333);
            this.btnDelay2.Name = "btnDelay2";
            this.btnDelay2.Size = new System.Drawing.Size(50, 23);
            this.btnDelay2.TabIndex = 413;
            this.btnDelay2.Text = "确定";
            this.btnDelay2.UseVisualStyleBackColor = true;
            this.btnDelay2.Click += new System.EventHandler(this.btnDelay2_Click);
            // 
            // btnDelay1
            // 
            this.btnDelay1.Location = new System.Drawing.Point(204, 298);
            this.btnDelay1.Name = "btnDelay1";
            this.btnDelay1.Size = new System.Drawing.Size(50, 23);
            this.btnDelay1.TabIndex = 412;
            this.btnDelay1.Text = "确定";
            this.btnDelay1.UseVisualStyleBackColor = true;
            this.btnDelay1.Click += new System.EventHandler(this.btnDelay1_Click);
            // 
            // btnMode8
            // 
            this.btnMode8.Location = new System.Drawing.Point(444, 148);
            this.btnMode8.Name = "btnMode8";
            this.btnMode8.Size = new System.Drawing.Size(50, 23);
            this.btnMode8.TabIndex = 411;
            this.btnMode8.Text = "确定";
            this.btnMode8.UseVisualStyleBackColor = true;
            this.btnMode8.Click += new System.EventHandler(this.btnMode8_Click);
            // 
            // btnMode7
            // 
            this.btnMode7.Location = new System.Drawing.Point(444, 112);
            this.btnMode7.Name = "btnMode7";
            this.btnMode7.Size = new System.Drawing.Size(50, 23);
            this.btnMode7.TabIndex = 410;
            this.btnMode7.Text = "确定";
            this.btnMode7.UseVisualStyleBackColor = true;
            this.btnMode7.Click += new System.EventHandler(this.btnMode7_Click);
            // 
            // btnMode6
            // 
            this.btnMode6.Location = new System.Drawing.Point(444, 79);
            this.btnMode6.Name = "btnMode6";
            this.btnMode6.Size = new System.Drawing.Size(50, 23);
            this.btnMode6.TabIndex = 409;
            this.btnMode6.Text = "确定";
            this.btnMode6.UseVisualStyleBackColor = true;
            this.btnMode6.Click += new System.EventHandler(this.btnMode6_Click);
            // 
            // btnMode5
            // 
            this.btnMode5.Location = new System.Drawing.Point(227, 218);
            this.btnMode5.Name = "btnMode5";
            this.btnMode5.Size = new System.Drawing.Size(50, 23);
            this.btnMode5.TabIndex = 408;
            this.btnMode5.Text = "确定";
            this.btnMode5.UseVisualStyleBackColor = true;
            this.btnMode5.Click += new System.EventHandler(this.btnMode5_Click);
            // 
            // btnMode3
            // 
            this.btnMode3.Location = new System.Drawing.Point(227, 147);
            this.btnMode3.Name = "btnMode3";
            this.btnMode3.Size = new System.Drawing.Size(50, 23);
            this.btnMode3.TabIndex = 407;
            this.btnMode3.Text = "确定";
            this.btnMode3.UseVisualStyleBackColor = true;
            this.btnMode3.Click += new System.EventHandler(this.btnMode3_Click);
            // 
            // btnMode4
            // 
            this.btnMode4.Location = new System.Drawing.Point(227, 182);
            this.btnMode4.Name = "btnMode4";
            this.btnMode4.Size = new System.Drawing.Size(50, 23);
            this.btnMode4.TabIndex = 406;
            this.btnMode4.Text = "确定";
            this.btnMode4.UseVisualStyleBackColor = true;
            this.btnMode4.Click += new System.EventHandler(this.btnMode4_Click);
            // 
            // btnMode2
            // 
            this.btnMode2.Location = new System.Drawing.Point(227, 114);
            this.btnMode2.Name = "btnMode2";
            this.btnMode2.Size = new System.Drawing.Size(50, 23);
            this.btnMode2.TabIndex = 405;
            this.btnMode2.Text = "确定";
            this.btnMode2.UseVisualStyleBackColor = true;
            this.btnMode2.Click += new System.EventHandler(this.btnMode2_Click);
            // 
            // btnMode1
            // 
            this.btnMode1.Location = new System.Drawing.Point(227, 79);
            this.btnMode1.Name = "btnMode1";
            this.btnMode1.Size = new System.Drawing.Size(50, 23);
            this.btnMode1.TabIndex = 404;
            this.btnMode1.Text = "确定";
            this.btnMode1.UseVisualStyleBackColor = true;
            this.btnMode1.Click += new System.EventHandler(this.btnMode1_Click);
            // 
            // txtDelayTime8
            // 
            this.txtDelayTime8.Location = new System.Drawing.Point(391, 332);
            this.txtDelayTime8.Name = "txtDelayTime8";
            this.txtDelayTime8.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime8.TabIndex = 403;
            // 
            // txtDelayTime7
            // 
            this.txtDelayTime7.Location = new System.Drawing.Point(391, 302);
            this.txtDelayTime7.Name = "txtDelayTime7";
            this.txtDelayTime7.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime7.TabIndex = 402;
            // 
            // txtDelayTime6
            // 
            this.txtDelayTime6.Location = new System.Drawing.Point(163, 476);
            this.txtDelayTime6.Name = "txtDelayTime6";
            this.txtDelayTime6.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime6.TabIndex = 401;
            // 
            // txtDelayTime5
            // 
            this.txtDelayTime5.Location = new System.Drawing.Point(163, 439);
            this.txtDelayTime5.Name = "txtDelayTime5";
            this.txtDelayTime5.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime5.TabIndex = 400;
            // 
            // txtDelayTime4
            // 
            this.txtDelayTime4.Location = new System.Drawing.Point(163, 403);
            this.txtDelayTime4.Name = "txtDelayTime4";
            this.txtDelayTime4.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime4.TabIndex = 399;
            // 
            // txtDelayTime3
            // 
            this.txtDelayTime3.Location = new System.Drawing.Point(163, 367);
            this.txtDelayTime3.Name = "txtDelayTime3";
            this.txtDelayTime3.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime3.TabIndex = 398;
            // 
            // txtDelayTime2
            // 
            this.txtDelayTime2.Location = new System.Drawing.Point(163, 335);
            this.txtDelayTime2.Name = "txtDelayTime2";
            this.txtDelayTime2.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime2.TabIndex = 397;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(188, 271);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(95, 12);
            this.label71.TabIndex = 396;
            this.label71.Text = "（单位：100ms）";
            // 
            // txtDelayTime1
            // 
            this.txtDelayTime1.Location = new System.Drawing.Point(163, 300);
            this.txtDelayTime1.Name = "txtDelayTime1";
            this.txtDelayTime1.Size = new System.Drawing.Size(35, 21);
            this.txtDelayTime1.TabIndex = 395;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(295, 338);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(95, 12);
            this.label72.TabIndex = 394;
            this.label72.Text = "第8路延迟时间：";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(295, 305);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(95, 12);
            this.label73.TabIndex = 393;
            this.label73.Text = "第7路延迟时间：";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(74, 479);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(95, 12);
            this.label74.TabIndex = 392;
            this.label74.Text = "第6路延迟时间：";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(74, 444);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(95, 12);
            this.label75.TabIndex = 391;
            this.label75.Text = "第5路延迟时间：";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(74, 408);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(95, 12);
            this.label76.TabIndex = 390;
            this.label76.Text = "第4路延迟时间：";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(74, 372);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(95, 12);
            this.label77.TabIndex = 389;
            this.label77.Text = "第3路延迟时间：";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(74, 340);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(95, 12);
            this.label78.TabIndex = 388;
            this.label78.Text = "第2路延迟时间：";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(74, 305);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(95, 12);
            this.label79.TabIndex = 387;
            this.label79.Text = "第1路延迟时间：";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label80.Location = new System.Drawing.Point(71, 269);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(110, 16);
            this.label80.TabIndex = 386;
            this.label80.Text = "设置延迟时间";
            // 
            // cbMode8
            // 
            this.cbMode8.FormattingEnabled = true;
            this.cbMode8.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode8.Location = new System.Drawing.Point(390, 149);
            this.cbMode8.Name = "cbMode8";
            this.cbMode8.Size = new System.Drawing.Size(48, 20);
            this.cbMode8.TabIndex = 385;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(289, 154);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(95, 12);
            this.label81.TabIndex = 384;
            this.label81.Text = "第8路工作模式：";
            // 
            // cbMode7
            // 
            this.cbMode7.FormattingEnabled = true;
            this.cbMode7.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode7.Location = new System.Drawing.Point(390, 114);
            this.cbMode7.Name = "cbMode7";
            this.cbMode7.Size = new System.Drawing.Size(48, 20);
            this.cbMode7.TabIndex = 383;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(289, 117);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(95, 12);
            this.label82.TabIndex = 382;
            this.label82.Text = "第7路工作模式：";
            // 
            // cbMode6
            // 
            this.cbMode6.FormattingEnabled = true;
            this.cbMode6.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode6.Location = new System.Drawing.Point(390, 81);
            this.cbMode6.Name = "cbMode6";
            this.cbMode6.Size = new System.Drawing.Size(48, 20);
            this.cbMode6.TabIndex = 381;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(289, 84);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(95, 12);
            this.label83.TabIndex = 380;
            this.label83.Text = "第6路工作模式：";
            // 
            // cbMode5
            // 
            this.cbMode5.FormattingEnabled = true;
            this.cbMode5.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode5.Location = new System.Drawing.Point(173, 220);
            this.cbMode5.Name = "cbMode5";
            this.cbMode5.Size = new System.Drawing.Size(48, 20);
            this.cbMode5.TabIndex = 379;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(72, 223);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(95, 12);
            this.label84.TabIndex = 378;
            this.label84.Text = "第5路工作模式：";
            // 
            // cbMode4
            // 
            this.cbMode4.FormattingEnabled = true;
            this.cbMode4.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode4.Location = new System.Drawing.Point(173, 184);
            this.cbMode4.Name = "cbMode4";
            this.cbMode4.Size = new System.Drawing.Size(48, 20);
            this.cbMode4.TabIndex = 377;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(72, 187);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(95, 12);
            this.label85.TabIndex = 376;
            this.label85.Text = "第4路工作模式：";
            // 
            // cbMode3
            // 
            this.cbMode3.FormattingEnabled = true;
            this.cbMode3.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode3.Location = new System.Drawing.Point(173, 148);
            this.cbMode3.Name = "cbMode3";
            this.cbMode3.Size = new System.Drawing.Size(48, 20);
            this.cbMode3.TabIndex = 375;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(72, 151);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(95, 12);
            this.label86.TabIndex = 374;
            this.label86.Text = "第3路工作模式：";
            // 
            // cbMode2
            // 
            this.cbMode2.FormattingEnabled = true;
            this.cbMode2.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode2.Location = new System.Drawing.Point(173, 111);
            this.cbMode2.Name = "cbMode2";
            this.cbMode2.Size = new System.Drawing.Size(48, 20);
            this.cbMode2.TabIndex = 373;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(72, 119);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(95, 12);
            this.label87.TabIndex = 372;
            this.label87.Text = "第2路工作模式：";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(187, 56);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(197, 12);
            this.label88.TabIndex = 371;
            this.label88.Text = "（00：保持，01：延迟，10：组合）";
            // 
            // cbMode1
            // 
            this.cbMode1.FormattingEnabled = true;
            this.cbMode1.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.cbMode1.Location = new System.Drawing.Point(173, 81);
            this.cbMode1.Name = "cbMode1";
            this.cbMode1.Size = new System.Drawing.Size(48, 20);
            this.cbMode1.TabIndex = 370;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(72, 84);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(95, 12);
            this.label89.TabIndex = 369;
            this.label89.Text = "第1路工作模式：";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.BackColor = System.Drawing.Color.Transparent;
            this.label90.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label90.Location = new System.Drawing.Point(71, 52);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(110, 16);
            this.label90.TabIndex = 368;
            this.label90.Text = "设置工作模式";
            // 
            // metroTabPage11
            // 
            this.metroTabPage11.Controls.Add(this.metroPanel9);
            this.metroTabPage11.HorizontalScrollbar = true;
            this.metroTabPage11.HorizontalScrollbarBarColor = true;
            this.metroTabPage11.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage11.HorizontalScrollbarSize = 10;
            this.metroTabPage11.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage11.Name = "metroTabPage11";
            this.metroTabPage11.Size = new System.Drawing.Size(557, 343);
            this.metroTabPage11.TabIndex = 3;
            this.metroTabPage11.Text = "AI";
            this.metroTabPage11.VerticalScrollbar = true;
            this.metroTabPage11.VerticalScrollbarBarColor = true;
            this.metroTabPage11.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage11.VerticalScrollbarSize = 10;
            // 
            // metroPanel9
            // 
            this.metroPanel9.AutoScroll = true;
            this.metroPanel9.Controls.Add(this.button9);
            this.metroPanel9.Controls.Add(this.button10);
            this.metroPanel9.Controls.Add(this.btnMarkAD8);
            this.metroPanel9.Controls.Add(this.btnMarkAD7);
            this.metroPanel9.Controls.Add(this.btnMarkAD6);
            this.metroPanel9.Controls.Add(this.btnMarkAD5);
            this.metroPanel9.Controls.Add(this.btnMarkAD4);
            this.metroPanel9.Controls.Add(this.btnMarkAD3);
            this.metroPanel9.Controls.Add(this.btnMarkAD2);
            this.metroPanel9.Controls.Add(this.btnMarkAD1);
            this.metroPanel9.Controls.Add(this.btnADExtent8);
            this.metroPanel9.Controls.Add(this.cbADExtent8);
            this.metroPanel9.Controls.Add(this.label91);
            this.metroPanel9.Controls.Add(this.btnADExtent7);
            this.metroPanel9.Controls.Add(this.cbADExtent7);
            this.metroPanel9.Controls.Add(this.label92);
            this.metroPanel9.Controls.Add(this.btnADExtent6);
            this.metroPanel9.Controls.Add(this.cbADExtent6);
            this.metroPanel9.Controls.Add(this.label93);
            this.metroPanel9.Controls.Add(this.btnADExtent5);
            this.metroPanel9.Controls.Add(this.cbADExtent5);
            this.metroPanel9.Controls.Add(this.label94);
            this.metroPanel9.Controls.Add(this.btnADExtent4);
            this.metroPanel9.Controls.Add(this.cbADExtent4);
            this.metroPanel9.Controls.Add(this.label95);
            this.metroPanel9.Controls.Add(this.btnADExtent3);
            this.metroPanel9.Controls.Add(this.cbADExtent3);
            this.metroPanel9.Controls.Add(this.label96);
            this.metroPanel9.Controls.Add(this.btnADExtent2);
            this.metroPanel9.Controls.Add(this.cbADExtent2);
            this.metroPanel9.Controls.Add(this.label97);
            this.metroPanel9.Controls.Add(this.btnADExtent1);
            this.metroPanel9.Controls.Add(this.label98);
            this.metroPanel9.Controls.Add(this.cbADExtent1);
            this.metroPanel9.Controls.Add(this.label99);
            this.metroPanel9.Controls.Add(this.cbCurrentMax8);
            this.metroPanel9.Controls.Add(this.cbCurrentMax7);
            this.metroPanel9.Controls.Add(this.cbCurrentMax6);
            this.metroPanel9.Controls.Add(this.cbCurrentMax5);
            this.metroPanel9.Controls.Add(this.cbCurrentMax4);
            this.metroPanel9.Controls.Add(this.cbCurrentMax3);
            this.metroPanel9.Controls.Add(this.cbCurrentMax2);
            this.metroPanel9.Controls.Add(this.btnCurrent8);
            this.metroPanel9.Controls.Add(this.label100);
            this.metroPanel9.Controls.Add(this.btnCurrent7);
            this.metroPanel9.Controls.Add(this.label101);
            this.metroPanel9.Controls.Add(this.btnCurrent6);
            this.metroPanel9.Controls.Add(this.label102);
            this.metroPanel9.Controls.Add(this.btnCurrent5);
            this.metroPanel9.Controls.Add(this.label103);
            this.metroPanel9.Controls.Add(this.btnCurrent4);
            this.metroPanel9.Controls.Add(this.label104);
            this.metroPanel9.Controls.Add(this.btnCurrent3);
            this.metroPanel9.Controls.Add(this.label105);
            this.metroPanel9.Controls.Add(this.btnCurrent2);
            this.metroPanel9.Controls.Add(this.label106);
            this.metroPanel9.Controls.Add(this.btnCurrent1);
            this.metroPanel9.Controls.Add(this.label107);
            this.metroPanel9.Controls.Add(this.cbCurrentMax1);
            this.metroPanel9.Controls.Add(this.label108);
            this.metroPanel9.Controls.Add(this.label109);
            this.metroPanel9.Controls.Add(this.label110);
            this.metroPanel9.Controls.Add(this.label111);
            this.metroPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel9.HorizontalScrollbar = true;
            this.metroPanel9.HorizontalScrollbarBarColor = true;
            this.metroPanel9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel9.HorizontalScrollbarSize = 10;
            this.metroPanel9.Location = new System.Drawing.Point(0, 0);
            this.metroPanel9.Name = "metroPanel9";
            this.metroPanel9.Size = new System.Drawing.Size(557, 343);
            this.metroPanel9.TabIndex = 2;
            this.metroPanel9.VerticalScrollbar = true;
            this.metroPanel9.VerticalScrollbarBarColor = true;
            this.metroPanel9.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel9.VerticalScrollbarSize = 10;
            this.metroPanel9.Enter += new System.EventHandler(this.metroPanel9_Enter);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(763, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 23);
            this.button9.TabIndex = 297;
            this.button9.Text = "获取当前设置";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(763, 277);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 23);
            this.button10.TabIndex = 296;
            this.button10.Text = "保存当前设置";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnMarkAD8
            // 
            this.btnMarkAD8.Location = new System.Drawing.Point(632, 429);
            this.btnMarkAD8.Name = "btnMarkAD8";
            this.btnMarkAD8.Size = new System.Drawing.Size(88, 23);
            this.btnMarkAD8.TabIndex = 295;
            this.btnMarkAD8.Text = "标定第8路AD";
            this.btnMarkAD8.UseVisualStyleBackColor = true;
            this.btnMarkAD8.Click += new System.EventHandler(this.btnMarkAD8_Click);
            // 
            // btnMarkAD7
            // 
            this.btnMarkAD7.Location = new System.Drawing.Point(632, 382);
            this.btnMarkAD7.Name = "btnMarkAD7";
            this.btnMarkAD7.Size = new System.Drawing.Size(88, 23);
            this.btnMarkAD7.TabIndex = 294;
            this.btnMarkAD7.Text = "标定第7路AD";
            this.btnMarkAD7.UseVisualStyleBackColor = true;
            this.btnMarkAD7.Click += new System.EventHandler(this.btnMarkAD7_Click);
            // 
            // btnMarkAD6
            // 
            this.btnMarkAD6.Location = new System.Drawing.Point(632, 337);
            this.btnMarkAD6.Name = "btnMarkAD6";
            this.btnMarkAD6.Size = new System.Drawing.Size(88, 23);
            this.btnMarkAD6.TabIndex = 293;
            this.btnMarkAD6.Text = "标定第6路AD";
            this.btnMarkAD6.UseVisualStyleBackColor = true;
            this.btnMarkAD6.Click += new System.EventHandler(this.btnMarkAD6_Click);
            // 
            // btnMarkAD5
            // 
            this.btnMarkAD5.Location = new System.Drawing.Point(632, 292);
            this.btnMarkAD5.Name = "btnMarkAD5";
            this.btnMarkAD5.Size = new System.Drawing.Size(88, 23);
            this.btnMarkAD5.TabIndex = 292;
            this.btnMarkAD5.Text = "标定第5路AD";
            this.btnMarkAD5.UseVisualStyleBackColor = true;
            this.btnMarkAD5.Click += new System.EventHandler(this.btnMarkAD5_Click);
            // 
            // btnMarkAD4
            // 
            this.btnMarkAD4.Location = new System.Drawing.Point(632, 250);
            this.btnMarkAD4.Name = "btnMarkAD4";
            this.btnMarkAD4.Size = new System.Drawing.Size(88, 23);
            this.btnMarkAD4.TabIndex = 291;
            this.btnMarkAD4.Text = "标定第4路AD";
            this.btnMarkAD4.UseVisualStyleBackColor = true;
            this.btnMarkAD4.Click += new System.EventHandler(this.btnMarkAD4_Click);
            // 
            // btnMarkAD3
            // 
            this.btnMarkAD3.Location = new System.Drawing.Point(632, 203);
            this.btnMarkAD3.Name = "btnMarkAD3";
            this.btnMarkAD3.Size = new System.Drawing.Size(88, 23);
            this.btnMarkAD3.TabIndex = 290;
            this.btnMarkAD3.Text = "标定第3路AD";
            this.btnMarkAD3.UseVisualStyleBackColor = true;
            this.btnMarkAD3.Click += new System.EventHandler(this.btnMarkAD3_Click);
            // 
            // btnMarkAD2
            // 
            this.btnMarkAD2.Location = new System.Drawing.Point(632, 157);
            this.btnMarkAD2.Name = "btnMarkAD2";
            this.btnMarkAD2.Size = new System.Drawing.Size(88, 23);
            this.btnMarkAD2.TabIndex = 289;
            this.btnMarkAD2.Text = "标定第2路AD";
            this.btnMarkAD2.UseVisualStyleBackColor = true;
            this.btnMarkAD2.Click += new System.EventHandler(this.btnMarkAD2_Click);
            // 
            // btnMarkAD1
            // 
            this.btnMarkAD1.Location = new System.Drawing.Point(632, 113);
            this.btnMarkAD1.Name = "btnMarkAD1";
            this.btnMarkAD1.Size = new System.Drawing.Size(88, 23);
            this.btnMarkAD1.TabIndex = 288;
            this.btnMarkAD1.Text = "标定第1路AD";
            this.btnMarkAD1.UseVisualStyleBackColor = true;
            this.btnMarkAD1.Click += new System.EventHandler(this.btnMarkAD1_Click);
            // 
            // btnADExtent8
            // 
            this.btnADExtent8.Location = new System.Drawing.Point(560, 430);
            this.btnADExtent8.Name = "btnADExtent8";
            this.btnADExtent8.Size = new System.Drawing.Size(50, 23);
            this.btnADExtent8.TabIndex = 287;
            this.btnADExtent8.Text = "确定";
            this.btnADExtent8.UseVisualStyleBackColor = true;
            this.btnADExtent8.Click += new System.EventHandler(this.btnADExtent8_Click);
            // 
            // cbADExtent8
            // 
            this.cbADExtent8.FormattingEnabled = true;
            this.cbADExtent8.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbADExtent8.Location = new System.Drawing.Point(468, 432);
            this.cbADExtent8.Name = "cbADExtent8";
            this.cbADExtent8.Size = new System.Drawing.Size(76, 20);
            this.cbADExtent8.TabIndex = 286;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(336, 435);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(131, 12);
            this.label91.TabIndex = 285;
            this.label91.Text = "第8路模拟量AD值范围：";
            // 
            // btnADExtent7
            // 
            this.btnADExtent7.Location = new System.Drawing.Point(560, 383);
            this.btnADExtent7.Name = "btnADExtent7";
            this.btnADExtent7.Size = new System.Drawing.Size(50, 23);
            this.btnADExtent7.TabIndex = 284;
            this.btnADExtent7.Text = "确定";
            this.btnADExtent7.UseVisualStyleBackColor = true;
            this.btnADExtent7.Click += new System.EventHandler(this.btnADExtent7_Click);
            // 
            // cbADExtent7
            // 
            this.cbADExtent7.FormattingEnabled = true;
            this.cbADExtent7.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbADExtent7.Location = new System.Drawing.Point(468, 385);
            this.cbADExtent7.Name = "cbADExtent7";
            this.cbADExtent7.Size = new System.Drawing.Size(76, 20);
            this.cbADExtent7.TabIndex = 283;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(336, 388);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(131, 12);
            this.label92.TabIndex = 282;
            this.label92.Text = "第7路模拟量AD值范围：";
            // 
            // btnADExtent6
            // 
            this.btnADExtent6.Location = new System.Drawing.Point(560, 338);
            this.btnADExtent6.Name = "btnADExtent6";
            this.btnADExtent6.Size = new System.Drawing.Size(50, 23);
            this.btnADExtent6.TabIndex = 281;
            this.btnADExtent6.Text = "确定";
            this.btnADExtent6.UseVisualStyleBackColor = true;
            this.btnADExtent6.Click += new System.EventHandler(this.btnADExtent6_Click);
            // 
            // cbADExtent6
            // 
            this.cbADExtent6.FormattingEnabled = true;
            this.cbADExtent6.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbADExtent6.Location = new System.Drawing.Point(468, 340);
            this.cbADExtent6.Name = "cbADExtent6";
            this.cbADExtent6.Size = new System.Drawing.Size(76, 20);
            this.cbADExtent6.TabIndex = 280;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(336, 343);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(131, 12);
            this.label93.TabIndex = 279;
            this.label93.Text = "第6路模拟量AD值范围：";
            // 
            // btnADExtent5
            // 
            this.btnADExtent5.Location = new System.Drawing.Point(560, 293);
            this.btnADExtent5.Name = "btnADExtent5";
            this.btnADExtent5.Size = new System.Drawing.Size(50, 23);
            this.btnADExtent5.TabIndex = 278;
            this.btnADExtent5.Text = "确定";
            this.btnADExtent5.UseVisualStyleBackColor = true;
            this.btnADExtent5.Click += new System.EventHandler(this.btnADExtent5_Click);
            // 
            // cbADExtent5
            // 
            this.cbADExtent5.FormattingEnabled = true;
            this.cbADExtent5.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbADExtent5.Location = new System.Drawing.Point(468, 295);
            this.cbADExtent5.Name = "cbADExtent5";
            this.cbADExtent5.Size = new System.Drawing.Size(76, 20);
            this.cbADExtent5.TabIndex = 277;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(336, 298);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(131, 12);
            this.label94.TabIndex = 276;
            this.label94.Text = "第5路模拟量AD值范围：";
            // 
            // btnADExtent4
            // 
            this.btnADExtent4.Location = new System.Drawing.Point(560, 251);
            this.btnADExtent4.Name = "btnADExtent4";
            this.btnADExtent4.Size = new System.Drawing.Size(50, 23);
            this.btnADExtent4.TabIndex = 275;
            this.btnADExtent4.Text = "确定";
            this.btnADExtent4.UseVisualStyleBackColor = true;
            this.btnADExtent4.Click += new System.EventHandler(this.btnADExtent4_Click);
            // 
            // cbADExtent4
            // 
            this.cbADExtent4.FormattingEnabled = true;
            this.cbADExtent4.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbADExtent4.Location = new System.Drawing.Point(468, 253);
            this.cbADExtent4.Name = "cbADExtent4";
            this.cbADExtent4.Size = new System.Drawing.Size(76, 20);
            this.cbADExtent4.TabIndex = 274;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(336, 256);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(131, 12);
            this.label95.TabIndex = 273;
            this.label95.Text = "第4路模拟量AD值范围：";
            // 
            // btnADExtent3
            // 
            this.btnADExtent3.Location = new System.Drawing.Point(560, 204);
            this.btnADExtent3.Name = "btnADExtent3";
            this.btnADExtent3.Size = new System.Drawing.Size(50, 23);
            this.btnADExtent3.TabIndex = 272;
            this.btnADExtent3.Text = "确定";
            this.btnADExtent3.UseVisualStyleBackColor = true;
            this.btnADExtent3.Click += new System.EventHandler(this.btnADExtent3_Click);
            // 
            // cbADExtent3
            // 
            this.cbADExtent3.FormattingEnabled = true;
            this.cbADExtent3.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbADExtent3.Location = new System.Drawing.Point(468, 206);
            this.cbADExtent3.Name = "cbADExtent3";
            this.cbADExtent3.Size = new System.Drawing.Size(76, 20);
            this.cbADExtent3.TabIndex = 271;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(336, 209);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(131, 12);
            this.label96.TabIndex = 270;
            this.label96.Text = "第3路模拟量AD值范围：";
            // 
            // btnADExtent2
            // 
            this.btnADExtent2.Location = new System.Drawing.Point(560, 158);
            this.btnADExtent2.Name = "btnADExtent2";
            this.btnADExtent2.Size = new System.Drawing.Size(50, 23);
            this.btnADExtent2.TabIndex = 269;
            this.btnADExtent2.Text = "确定";
            this.btnADExtent2.UseVisualStyleBackColor = true;
            this.btnADExtent2.Click += new System.EventHandler(this.btnADExtent2_Click);
            // 
            // cbADExtent2
            // 
            this.cbADExtent2.FormattingEnabled = true;
            this.cbADExtent2.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbADExtent2.Location = new System.Drawing.Point(468, 160);
            this.cbADExtent2.Name = "cbADExtent2";
            this.cbADExtent2.Size = new System.Drawing.Size(76, 20);
            this.cbADExtent2.TabIndex = 268;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(336, 163);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(131, 12);
            this.label97.TabIndex = 267;
            this.label97.Text = "第2路模拟量AD值范围：";
            // 
            // btnADExtent1
            // 
            this.btnADExtent1.Location = new System.Drawing.Point(560, 114);
            this.btnADExtent1.Name = "btnADExtent1";
            this.btnADExtent1.Size = new System.Drawing.Size(50, 23);
            this.btnADExtent1.TabIndex = 266;
            this.btnADExtent1.Text = "确定";
            this.btnADExtent1.UseVisualStyleBackColor = true;
            this.btnADExtent1.Click += new System.EventHandler(this.btnADExtent1_Click);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(336, 84);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(221, 12);
            this.label98.TabIndex = 265;
            this.label98.Text = "（0：0-2000，1：0-5000，2：0-10000）";
            // 
            // cbADExtent1
            // 
            this.cbADExtent1.FormattingEnabled = true;
            this.cbADExtent1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbADExtent1.Location = new System.Drawing.Point(468, 116);
            this.cbADExtent1.Name = "cbADExtent1";
            this.cbADExtent1.Size = new System.Drawing.Size(76, 20);
            this.cbADExtent1.TabIndex = 264;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(336, 119);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(131, 12);
            this.label99.TabIndex = 263;
            this.label99.Text = "第1路模拟量AD值范围：";
            // 
            // cbCurrentMax8
            // 
            this.cbCurrentMax8.FormattingEnabled = true;
            this.cbCurrentMax8.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCurrentMax8.Location = new System.Drawing.Point(192, 433);
            this.cbCurrentMax8.Name = "cbCurrentMax8";
            this.cbCurrentMax8.Size = new System.Drawing.Size(76, 20);
            this.cbCurrentMax8.TabIndex = 262;
            // 
            // cbCurrentMax7
            // 
            this.cbCurrentMax7.FormattingEnabled = true;
            this.cbCurrentMax7.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCurrentMax7.Location = new System.Drawing.Point(192, 386);
            this.cbCurrentMax7.Name = "cbCurrentMax7";
            this.cbCurrentMax7.Size = new System.Drawing.Size(76, 20);
            this.cbCurrentMax7.TabIndex = 261;
            // 
            // cbCurrentMax6
            // 
            this.cbCurrentMax6.FormattingEnabled = true;
            this.cbCurrentMax6.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCurrentMax6.Location = new System.Drawing.Point(192, 341);
            this.cbCurrentMax6.Name = "cbCurrentMax6";
            this.cbCurrentMax6.Size = new System.Drawing.Size(76, 20);
            this.cbCurrentMax6.TabIndex = 260;
            // 
            // cbCurrentMax5
            // 
            this.cbCurrentMax5.FormattingEnabled = true;
            this.cbCurrentMax5.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCurrentMax5.Location = new System.Drawing.Point(192, 296);
            this.cbCurrentMax5.Name = "cbCurrentMax5";
            this.cbCurrentMax5.Size = new System.Drawing.Size(76, 20);
            this.cbCurrentMax5.TabIndex = 259;
            // 
            // cbCurrentMax4
            // 
            this.cbCurrentMax4.FormattingEnabled = true;
            this.cbCurrentMax4.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCurrentMax4.Location = new System.Drawing.Point(192, 254);
            this.cbCurrentMax4.Name = "cbCurrentMax4";
            this.cbCurrentMax4.Size = new System.Drawing.Size(76, 20);
            this.cbCurrentMax4.TabIndex = 258;
            // 
            // cbCurrentMax3
            // 
            this.cbCurrentMax3.FormattingEnabled = true;
            this.cbCurrentMax3.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCurrentMax3.Location = new System.Drawing.Point(192, 207);
            this.cbCurrentMax3.Name = "cbCurrentMax3";
            this.cbCurrentMax3.Size = new System.Drawing.Size(76, 20);
            this.cbCurrentMax3.TabIndex = 257;
            // 
            // cbCurrentMax2
            // 
            this.cbCurrentMax2.FormattingEnabled = true;
            this.cbCurrentMax2.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCurrentMax2.Location = new System.Drawing.Point(192, 160);
            this.cbCurrentMax2.Name = "cbCurrentMax2";
            this.cbCurrentMax2.Size = new System.Drawing.Size(76, 20);
            this.cbCurrentMax2.TabIndex = 256;
            // 
            // btnCurrent8
            // 
            this.btnCurrent8.Location = new System.Drawing.Point(278, 430);
            this.btnCurrent8.Name = "btnCurrent8";
            this.btnCurrent8.Size = new System.Drawing.Size(50, 23);
            this.btnCurrent8.TabIndex = 255;
            this.btnCurrent8.Text = "确定";
            this.btnCurrent8.UseVisualStyleBackColor = true;
            this.btnCurrent8.Click += new System.EventHandler(this.btnCurrent8_Click);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(60, 435);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(131, 12);
            this.label100.TabIndex = 254;
            this.label100.Text = "第8路模拟量电流范围：";
            // 
            // btnCurrent7
            // 
            this.btnCurrent7.Location = new System.Drawing.Point(278, 383);
            this.btnCurrent7.Name = "btnCurrent7";
            this.btnCurrent7.Size = new System.Drawing.Size(50, 23);
            this.btnCurrent7.TabIndex = 253;
            this.btnCurrent7.Text = "确定";
            this.btnCurrent7.UseVisualStyleBackColor = true;
            this.btnCurrent7.Click += new System.EventHandler(this.btnCurrent7_Click);
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(60, 388);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(131, 12);
            this.label101.TabIndex = 252;
            this.label101.Text = "第7路模拟量电流范围：";
            // 
            // btnCurrent6
            // 
            this.btnCurrent6.Location = new System.Drawing.Point(278, 338);
            this.btnCurrent6.Name = "btnCurrent6";
            this.btnCurrent6.Size = new System.Drawing.Size(50, 23);
            this.btnCurrent6.TabIndex = 251;
            this.btnCurrent6.Text = "确定";
            this.btnCurrent6.UseVisualStyleBackColor = true;
            this.btnCurrent6.Click += new System.EventHandler(this.btnCurrent6_Click);
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(60, 343);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(131, 12);
            this.label102.TabIndex = 250;
            this.label102.Text = "第6路模拟量电流范围：";
            // 
            // btnCurrent5
            // 
            this.btnCurrent5.Location = new System.Drawing.Point(278, 293);
            this.btnCurrent5.Name = "btnCurrent5";
            this.btnCurrent5.Size = new System.Drawing.Size(50, 23);
            this.btnCurrent5.TabIndex = 249;
            this.btnCurrent5.Text = "确定";
            this.btnCurrent5.UseVisualStyleBackColor = true;
            this.btnCurrent5.Click += new System.EventHandler(this.btnCurrent5_Click);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(60, 298);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(131, 12);
            this.label103.TabIndex = 248;
            this.label103.Text = "第5路模拟量电流范围：";
            // 
            // btnCurrent4
            // 
            this.btnCurrent4.Location = new System.Drawing.Point(278, 251);
            this.btnCurrent4.Name = "btnCurrent4";
            this.btnCurrent4.Size = new System.Drawing.Size(50, 23);
            this.btnCurrent4.TabIndex = 247;
            this.btnCurrent4.Text = "确定";
            this.btnCurrent4.UseVisualStyleBackColor = true;
            this.btnCurrent4.Click += new System.EventHandler(this.btnCurrent4_Click);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(60, 256);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(131, 12);
            this.label104.TabIndex = 246;
            this.label104.Text = "第4路模拟量电流范围：";
            // 
            // btnCurrent3
            // 
            this.btnCurrent3.Location = new System.Drawing.Point(278, 204);
            this.btnCurrent3.Name = "btnCurrent3";
            this.btnCurrent3.Size = new System.Drawing.Size(50, 23);
            this.btnCurrent3.TabIndex = 245;
            this.btnCurrent3.Text = "确定";
            this.btnCurrent3.UseVisualStyleBackColor = true;
            this.btnCurrent3.Click += new System.EventHandler(this.btnCurrent3_Click);
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(60, 209);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(131, 12);
            this.label105.TabIndex = 244;
            this.label105.Text = "第3路模拟量电流范围：";
            // 
            // btnCurrent2
            // 
            this.btnCurrent2.Location = new System.Drawing.Point(278, 158);
            this.btnCurrent2.Name = "btnCurrent2";
            this.btnCurrent2.Size = new System.Drawing.Size(50, 23);
            this.btnCurrent2.TabIndex = 243;
            this.btnCurrent2.Text = "确定";
            this.btnCurrent2.UseVisualStyleBackColor = true;
            this.btnCurrent2.Click += new System.EventHandler(this.btnCurrent2_Click);
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(60, 163);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(131, 12);
            this.label106.TabIndex = 242;
            this.label106.Text = "第2路模拟量电流范围：";
            // 
            // btnCurrent1
            // 
            this.btnCurrent1.Location = new System.Drawing.Point(278, 114);
            this.btnCurrent1.Name = "btnCurrent1";
            this.btnCurrent1.Size = new System.Drawing.Size(50, 23);
            this.btnCurrent1.TabIndex = 241;
            this.btnCurrent1.Text = "确定";
            this.btnCurrent1.UseVisualStyleBackColor = true;
            this.btnCurrent1.Click += new System.EventHandler(this.btnCurrent1_Click);
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(60, 84);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(197, 12);
            this.label107.TabIndex = 240;
            this.label107.Text = "（0：4-20mA，1：0-20mA（0-5V））";
            // 
            // cbCurrentMax1
            // 
            this.cbCurrentMax1.FormattingEnabled = true;
            this.cbCurrentMax1.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCurrentMax1.Location = new System.Drawing.Point(192, 116);
            this.cbCurrentMax1.Name = "cbCurrentMax1";
            this.cbCurrentMax1.Size = new System.Drawing.Size(76, 20);
            this.cbCurrentMax1.TabIndex = 239;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(60, 119);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(131, 12);
            this.label108.TabIndex = 238;
            this.label108.Text = "第1路模拟量电流范围：";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label109.Location = new System.Drawing.Point(629, 39);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(76, 16);
            this.label109.TabIndex = 237;
            this.label109.Text = "配置零点";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label110.Location = new System.Drawing.Point(344, 39);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(144, 16);
            this.label110.TabIndex = 236;
            this.label110.Text = "选择采样信号量程";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label111.Location = new System.Drawing.Point(115, 39);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(76, 16);
            this.label111.TabIndex = 235;
            this.label111.Text = "配置上限";
            // 
            // metroTabPage12
            // 
            this.metroTabPage12.Controls.Add(this.metroPanel10);
            this.metroTabPage12.HorizontalScrollbar = true;
            this.metroTabPage12.HorizontalScrollbarBarColor = true;
            this.metroTabPage12.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage12.HorizontalScrollbarSize = 10;
            this.metroTabPage12.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage12.Name = "metroTabPage12";
            this.metroTabPage12.Size = new System.Drawing.Size(557, 343);
            this.metroTabPage12.TabIndex = 4;
            this.metroTabPage12.Text = "DI";
            this.metroTabPage12.VerticalScrollbar = true;
            this.metroTabPage12.VerticalScrollbarBarColor = true;
            this.metroTabPage12.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage12.VerticalScrollbarSize = 10;
            // 
            // metroPanel10
            // 
            this.metroPanel10.AutoScroll = true;
            this.metroPanel10.Controls.Add(this.button11);
            this.metroPanel10.Controls.Add(this.button12);
            this.metroPanel10.Controls.Add(this.button13);
            this.metroPanel10.Controls.Add(this.button14);
            this.metroPanel10.Controls.Add(this.button15);
            this.metroPanel10.Controls.Add(this.panel4);
            this.metroPanel10.Controls.Add(this.panel5);
            this.metroPanel10.Controls.Add(this.panel6);
            this.metroPanel10.Controls.Add(this.panel7);
            this.metroPanel10.Controls.Add(this.btnReadCount4);
            this.metroPanel10.Controls.Add(this.btnReadCount3);
            this.metroPanel10.Controls.Add(this.btnReadCount2);
            this.metroPanel10.Controls.Add(this.btnReadCount1);
            this.metroPanel10.Controls.Add(this.txtCount4);
            this.metroPanel10.Controls.Add(this.label112);
            this.metroPanel10.Controls.Add(this.txtCount3);
            this.metroPanel10.Controls.Add(this.label113);
            this.metroPanel10.Controls.Add(this.label114);
            this.metroPanel10.Controls.Add(this.txtCount2);
            this.metroPanel10.Controls.Add(this.label115);
            this.metroPanel10.Controls.Add(this.label116);
            this.metroPanel10.Controls.Add(this.label117);
            this.metroPanel10.Controls.Add(this.label118);
            this.metroPanel10.Controls.Add(this.txtCount1);
            this.metroPanel10.Controls.Add(this.label119);
            this.metroPanel10.Controls.Add(this.label120);
            this.metroPanel10.Controls.Add(this.label121);
            this.metroPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel10.HorizontalScrollbar = true;
            this.metroPanel10.HorizontalScrollbarBarColor = true;
            this.metroPanel10.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel10.HorizontalScrollbarSize = 10;
            this.metroPanel10.Location = new System.Drawing.Point(0, 0);
            this.metroPanel10.Name = "metroPanel10";
            this.metroPanel10.Size = new System.Drawing.Size(557, 343);
            this.metroPanel10.TabIndex = 2;
            this.metroPanel10.VerticalScrollbar = true;
            this.metroPanel10.VerticalScrollbarBarColor = true;
            this.metroPanel10.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel10.VerticalScrollbarSize = 10;
            this.metroPanel10.Enter += new System.EventHandler(this.metroPanel10_Enter);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(578, 230);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 229;
            this.button11.Text = "读取状态";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(578, 183);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 228;
            this.button12.Text = "读取状态";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(578, 136);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 227;
            this.button13.Text = "读取状态";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(578, 90);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 226;
            this.button14.Text = "读取状态";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(254, 329);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(154, 23);
            this.button15.TabIndex = 225;
            this.button15.Text = "获取当前所有计数";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbOff3);
            this.panel4.Controls.Add(this.rbOn3);
            this.panel4.Location = new System.Drawing.Point(437, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 31);
            this.panel4.TabIndex = 224;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.rbOff2);
            this.panel5.Controls.Add(this.rbOn2);
            this.panel5.Location = new System.Drawing.Point(437, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 31);
            this.panel5.TabIndex = 222;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.rbOn1);
            this.panel6.Controls.Add(this.rbOff1);
            this.panel6.Location = new System.Drawing.Point(437, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(115, 31);
            this.panel6.TabIndex = 221;
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
            // panel7
            // 
            this.panel7.Controls.Add(this.rbOff4);
            this.panel7.Controls.Add(this.rbOn4);
            this.panel7.Location = new System.Drawing.Point(437, 230);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(115, 31);
            this.panel7.TabIndex = 223;
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
            // btnReadCount4
            // 
            this.btnReadCount4.Location = new System.Drawing.Point(224, 230);
            this.btnReadCount4.Name = "btnReadCount4";
            this.btnReadCount4.Size = new System.Drawing.Size(75, 23);
            this.btnReadCount4.TabIndex = 220;
            this.btnReadCount4.Text = "读取计数";
            this.btnReadCount4.UseVisualStyleBackColor = true;
            this.btnReadCount4.Click += new System.EventHandler(this.btnReadCount4_Click);
            // 
            // btnReadCount3
            // 
            this.btnReadCount3.Location = new System.Drawing.Point(224, 183);
            this.btnReadCount3.Name = "btnReadCount3";
            this.btnReadCount3.Size = new System.Drawing.Size(75, 23);
            this.btnReadCount3.TabIndex = 219;
            this.btnReadCount3.Text = "读取计数";
            this.btnReadCount3.UseVisualStyleBackColor = true;
            this.btnReadCount3.Click += new System.EventHandler(this.btnReadCount3_Click);
            // 
            // btnReadCount2
            // 
            this.btnReadCount2.Location = new System.Drawing.Point(224, 136);
            this.btnReadCount2.Name = "btnReadCount2";
            this.btnReadCount2.Size = new System.Drawing.Size(75, 23);
            this.btnReadCount2.TabIndex = 218;
            this.btnReadCount2.Text = "读取计数";
            this.btnReadCount2.UseVisualStyleBackColor = true;
            this.btnReadCount2.Click += new System.EventHandler(this.btnReadCount2_Click);
            // 
            // btnReadCount1
            // 
            this.btnReadCount1.Location = new System.Drawing.Point(224, 90);
            this.btnReadCount1.Name = "btnReadCount1";
            this.btnReadCount1.Size = new System.Drawing.Size(75, 23);
            this.btnReadCount1.TabIndex = 217;
            this.btnReadCount1.Text = "读取计数";
            this.btnReadCount1.UseVisualStyleBackColor = true;
            this.btnReadCount1.Click += new System.EventHandler(this.btnReadCount1_Click);
            // 
            // txtCount4
            // 
            this.txtCount4.Location = new System.Drawing.Point(141, 230);
            this.txtCount4.Name = "txtCount4";
            this.txtCount4.Size = new System.Drawing.Size(61, 21);
            this.txtCount4.TabIndex = 216;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(46, 192);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(83, 12);
            this.label112.TabIndex = 215;
            this.label112.Text = "第3路DI计数：";
            // 
            // txtCount3
            // 
            this.txtCount3.Location = new System.Drawing.Point(141, 183);
            this.txtCount3.Name = "txtCount3";
            this.txtCount3.Size = new System.Drawing.Size(61, 21);
            this.txtCount3.TabIndex = 213;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(46, 242);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(83, 12);
            this.label113.TabIndex = 214;
            this.label113.Text = "第4路DI计数：";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(46, 143);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(83, 12);
            this.label114.TabIndex = 212;
            this.label114.Text = "第2路DI计数：";
            // 
            // txtCount2
            // 
            this.txtCount2.Location = new System.Drawing.Point(141, 139);
            this.txtCount2.Name = "txtCount2";
            this.txtCount2.Size = new System.Drawing.Size(61, 21);
            this.txtCount2.TabIndex = 211;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(354, 239);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(83, 12);
            this.label115.TabIndex = 209;
            this.label115.Text = "第4路DI状态：";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(354, 190);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(83, 12);
            this.label116.TabIndex = 208;
            this.label116.Text = "第3路DI状态：";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(354, 140);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(83, 12);
            this.label117.TabIndex = 207;
            this.label117.Text = "第2路DI状态：";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(46, 99);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(83, 12);
            this.label118.TabIndex = 210;
            this.label118.Text = "第1路DI计数：";
            // 
            // txtCount1
            // 
            this.txtCount1.Location = new System.Drawing.Point(141, 90);
            this.txtCount1.Name = "txtCount1";
            this.txtCount1.Size = new System.Drawing.Size(61, 21);
            this.txtCount1.TabIndex = 206;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(354, 96);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(83, 12);
            this.label119.TabIndex = 205;
            this.label119.Text = "第1路DI状态：";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label120.Location = new System.Drawing.Point(354, 36);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(93, 16);
            this.label120.TabIndex = 204;
            this.label120.Text = "输入寄存器";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label121.Location = new System.Drawing.Point(45, 36);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(93, 16);
            this.label121.TabIndex = 203;
            this.label121.Text = "保持寄存器";
            // 
            // metroTabPage13
            // 
            this.metroTabPage13.Controls.Add(this.metroPanel11);
            this.metroTabPage13.HorizontalScrollbar = true;
            this.metroTabPage13.HorizontalScrollbarBarColor = true;
            this.metroTabPage13.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage13.HorizontalScrollbarSize = 10;
            this.metroTabPage13.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage13.Name = "metroTabPage13";
            this.metroTabPage13.Size = new System.Drawing.Size(557, 343);
            this.metroTabPage13.TabIndex = 5;
            this.metroTabPage13.Text = "DO";
            this.metroTabPage13.VerticalScrollbar = true;
            this.metroTabPage13.VerticalScrollbarBarColor = true;
            this.metroTabPage13.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage13.VerticalScrollbarSize = 10;
            // 
            // metroPanel11
            // 
            this.metroPanel11.AutoScroll = true;
            this.metroPanel11.Controls.Add(this.button16);
            this.metroPanel11.Controls.Add(this.button17);
            this.metroPanel11.Controls.Add(this.button18);
            this.metroPanel11.Controls.Add(this.comboBox2);
            this.metroPanel11.Controls.Add(this.label122);
            this.metroPanel11.Controls.Add(this.button19);
            this.metroPanel11.Controls.Add(this.comboBox3);
            this.metroPanel11.Controls.Add(this.label123);
            this.metroPanel11.Controls.Add(this.button20);
            this.metroPanel11.Controls.Add(this.comboBox4);
            this.metroPanel11.Controls.Add(this.label124);
            this.metroPanel11.Controls.Add(this.button21);
            this.metroPanel11.Controls.Add(this.comboBox5);
            this.metroPanel11.Controls.Add(this.label125);
            this.metroPanel11.Controls.Add(this.button22);
            this.metroPanel11.Controls.Add(this.comboBox6);
            this.metroPanel11.Controls.Add(this.label126);
            this.metroPanel11.Controls.Add(this.button23);
            this.metroPanel11.Controls.Add(this.comboBox7);
            this.metroPanel11.Controls.Add(this.label127);
            this.metroPanel11.Controls.Add(this.button24);
            this.metroPanel11.Controls.Add(this.comboBox8);
            this.metroPanel11.Controls.Add(this.label128);
            this.metroPanel11.Controls.Add(this.button25);
            this.metroPanel11.Controls.Add(this.comboBox9);
            this.metroPanel11.Controls.Add(this.label129);
            this.metroPanel11.Controls.Add(this.button26);
            this.metroPanel11.Controls.Add(this.button27);
            this.metroPanel11.Controls.Add(this.button28);
            this.metroPanel11.Controls.Add(this.button29);
            this.metroPanel11.Controls.Add(this.button30);
            this.metroPanel11.Controls.Add(this.button31);
            this.metroPanel11.Controls.Add(this.button32);
            this.metroPanel11.Controls.Add(this.button33);
            this.metroPanel11.Controls.Add(this.button34);
            this.metroPanel11.Controls.Add(this.button35);
            this.metroPanel11.Controls.Add(this.button36);
            this.metroPanel11.Controls.Add(this.button37);
            this.metroPanel11.Controls.Add(this.button38);
            this.metroPanel11.Controls.Add(this.button39);
            this.metroPanel11.Controls.Add(this.button40);
            this.metroPanel11.Controls.Add(this.button41);
            this.metroPanel11.Controls.Add(this.label130);
            this.metroPanel11.Controls.Add(this.textBox1);
            this.metroPanel11.Controls.Add(this.label131);
            this.metroPanel11.Controls.Add(this.textBox2);
            this.metroPanel11.Controls.Add(this.label132);
            this.metroPanel11.Controls.Add(this.textBox3);
            this.metroPanel11.Controls.Add(this.label133);
            this.metroPanel11.Controls.Add(this.textBox4);
            this.metroPanel11.Controls.Add(this.label134);
            this.metroPanel11.Controls.Add(this.textBox5);
            this.metroPanel11.Controls.Add(this.label135);
            this.metroPanel11.Controls.Add(this.textBox6);
            this.metroPanel11.Controls.Add(this.label136);
            this.metroPanel11.Controls.Add(this.textBox7);
            this.metroPanel11.Controls.Add(this.label137);
            this.metroPanel11.Controls.Add(this.textBox8);
            this.metroPanel11.Controls.Add(this.label138);
            this.metroPanel11.Controls.Add(this.label139);
            this.metroPanel11.Controls.Add(this.label140);
            this.metroPanel11.Controls.Add(this.label141);
            this.metroPanel11.Controls.Add(this.label142);
            this.metroPanel11.Controls.Add(this.label143);
            this.metroPanel11.Controls.Add(this.label144);
            this.metroPanel11.Controls.Add(this.label145);
            this.metroPanel11.Controls.Add(this.label146);
            this.metroPanel11.Controls.Add(this.label147);
            this.metroPanel11.Controls.Add(this.comboBox10);
            this.metroPanel11.Controls.Add(this.label148);
            this.metroPanel11.Controls.Add(this.comboBox11);
            this.metroPanel11.Controls.Add(this.label149);
            this.metroPanel11.Controls.Add(this.comboBox12);
            this.metroPanel11.Controls.Add(this.label150);
            this.metroPanel11.Controls.Add(this.comboBox13);
            this.metroPanel11.Controls.Add(this.label151);
            this.metroPanel11.Controls.Add(this.comboBox14);
            this.metroPanel11.Controls.Add(this.label152);
            this.metroPanel11.Controls.Add(this.comboBox15);
            this.metroPanel11.Controls.Add(this.label153);
            this.metroPanel11.Controls.Add(this.comboBox16);
            this.metroPanel11.Controls.Add(this.label154);
            this.metroPanel11.Controls.Add(this.label155);
            this.metroPanel11.Controls.Add(this.comboBox17);
            this.metroPanel11.Controls.Add(this.label156);
            this.metroPanel11.Controls.Add(this.label157);
            this.metroPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel11.HorizontalScrollbar = true;
            this.metroPanel11.HorizontalScrollbarBarColor = true;
            this.metroPanel11.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel11.HorizontalScrollbarSize = 10;
            this.metroPanel11.Location = new System.Drawing.Point(0, 0);
            this.metroPanel11.Name = "metroPanel11";
            this.metroPanel11.Size = new System.Drawing.Size(557, 343);
            this.metroPanel11.TabIndex = 2;
            this.metroPanel11.VerticalScrollbar = true;
            this.metroPanel11.VerticalScrollbarBarColor = true;
            this.metroPanel11.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel11.VerticalScrollbarSize = 10;
            this.metroPanel11.Enter += new System.EventHandler(this.metroPanel11_Enter);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(341, 430);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 23);
            this.button16.TabIndex = 344;
            this.button16.Text = "获取当前设置";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(524, 430);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(120, 23);
            this.button17.TabIndex = 343;
            this.button17.Text = "保存当前设置";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(855, 366);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 23);
            this.button18.TabIndex = 342;
            this.button18.Text = "确定";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(718, 368);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 20);
            this.comboBox2.TabIndex = 341;
            this.comboBox2.Text = "无";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(617, 371);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(95, 12);
            this.label122.TabIndex = 340;
            this.label122.Text = "8选择组合方式：";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(855, 325);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 23);
            this.button19.TabIndex = 339;
            this.button19.Text = "确定";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(718, 327);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(131, 20);
            this.comboBox3.TabIndex = 338;
            this.comboBox3.Text = "无";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(617, 330);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(95, 12);
            this.label123.TabIndex = 337;
            this.label123.Text = "7选择组合方式：";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(855, 285);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 23);
            this.button20.TabIndex = 336;
            this.button20.Text = "确定";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(718, 287);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(131, 20);
            this.comboBox4.TabIndex = 335;
            this.comboBox4.Text = "无";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(617, 290);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(95, 12);
            this.label124.TabIndex = 334;
            this.label124.Text = "6选择组合方式：";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(855, 250);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 23);
            this.button21.TabIndex = 333;
            this.button21.Text = "确定";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(718, 252);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(131, 20);
            this.comboBox5.TabIndex = 332;
            this.comboBox5.Text = "无";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(617, 255);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(95, 12);
            this.label125.TabIndex = 331;
            this.label125.Text = "5选择组合方式：";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(855, 214);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 23);
            this.button22.TabIndex = 330;
            this.button22.Text = "确定";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(718, 216);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(131, 20);
            this.comboBox6.TabIndex = 329;
            this.comboBox6.Text = "无";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(617, 219);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(95, 12);
            this.label126.TabIndex = 328;
            this.label126.Text = "4选择组合方式：";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(855, 178);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 23);
            this.button23.TabIndex = 327;
            this.button23.Text = "确定";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(718, 180);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(131, 20);
            this.comboBox7.TabIndex = 326;
            this.comboBox7.Text = "无";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(617, 183);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(95, 12);
            this.label127.TabIndex = 325;
            this.label127.Text = "3选择组合方式：";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(855, 146);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 23);
            this.button24.TabIndex = 324;
            this.button24.Text = "确定";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(718, 148);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(131, 20);
            this.comboBox8.TabIndex = 323;
            this.comboBox8.Text = "无";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(617, 151);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(95, 12);
            this.label128.TabIndex = 322;
            this.label128.Text = "2选择组合方式：";
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(855, 111);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(50, 23);
            this.button25.TabIndex = 321;
            this.button25.Text = "确定";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(718, 113);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(131, 20);
            this.comboBox9.TabIndex = 320;
            this.comboBox9.Text = "无";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(617, 116);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(95, 12);
            this.label129.TabIndex = 319;
            this.label129.Text = "1选择组合方式：";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(523, 366);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(50, 23);
            this.button26.TabIndex = 318;
            this.button26.Text = "确定";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(523, 325);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(50, 23);
            this.button27.TabIndex = 317;
            this.button27.Text = "确定";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(523, 285);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(50, 23);
            this.button28.TabIndex = 316;
            this.button28.Text = "确定";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(523, 250);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(50, 23);
            this.button29.TabIndex = 315;
            this.button29.Text = "确定";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(523, 179);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(50, 23);
            this.button30.TabIndex = 314;
            this.button30.Text = "确定";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(523, 214);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(50, 23);
            this.button31.TabIndex = 313;
            this.button31.Text = "确定";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(523, 146);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(50, 23);
            this.button32.TabIndex = 312;
            this.button32.Text = "确定";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(523, 111);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(50, 23);
            this.button33.TabIndex = 311;
            this.button33.Text = "确定";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(255, 369);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(50, 23);
            this.button34.TabIndex = 310;
            this.button34.Text = "确定";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(255, 328);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(50, 23);
            this.button35.TabIndex = 309;
            this.button35.Text = "确定";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(255, 288);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(50, 23);
            this.button36.TabIndex = 308;
            this.button36.Text = "确定";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(255, 253);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(50, 23);
            this.button37.TabIndex = 307;
            this.button37.Text = "确定";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(255, 182);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(50, 23);
            this.button38.TabIndex = 306;
            this.button38.Text = "确定";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(255, 217);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(50, 23);
            this.button39.TabIndex = 305;
            this.button39.Text = "确定";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(255, 149);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(50, 23);
            this.button40.TabIndex = 304;
            this.button40.Text = "确定";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(255, 114);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(50, 23);
            this.button41.TabIndex = 303;
            this.button41.Text = "确定";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(452, 371);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(65, 12);
            this.label130.TabIndex = 302;
            this.label130.Text = "（*100ms）";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 21);
            this.textBox1.TabIndex = 301;
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(452, 333);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(65, 12);
            this.label131.TabIndex = 300;
            this.label131.Text = "（*100ms）";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 330);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 21);
            this.textBox2.TabIndex = 299;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(452, 290);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(65, 12);
            this.label132.TabIndex = 298;
            this.label132.Text = "（*100ms）";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(411, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 21);
            this.textBox3.TabIndex = 297;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(452, 255);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(65, 12);
            this.label133.TabIndex = 296;
            this.label133.Text = "（*100ms）";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(411, 252);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(35, 21);
            this.textBox4.TabIndex = 295;
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(452, 219);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(65, 12);
            this.label134.TabIndex = 294;
            this.label134.Text = "（*100ms）";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(411, 216);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 21);
            this.textBox5.TabIndex = 293;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(452, 183);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(65, 12);
            this.label135.TabIndex = 292;
            this.label135.Text = "（*100ms）";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(411, 180);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(35, 21);
            this.textBox6.TabIndex = 291;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(452, 151);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(65, 12);
            this.label136.TabIndex = 290;
            this.label136.Text = "（*100ms）";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(411, 148);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(35, 21);
            this.textBox7.TabIndex = 289;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(452, 116);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(65, 12);
            this.label137.TabIndex = 288;
            this.label137.Text = "（*100ms）";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(411, 113);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(35, 21);
            this.textBox8.TabIndex = 287;
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(322, 371);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(95, 12);
            this.label138.TabIndex = 286;
            this.label138.Text = "第8路延迟时间：";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(322, 330);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(95, 12);
            this.label139.TabIndex = 285;
            this.label139.Text = "第7路延迟时间：";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(322, 290);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(95, 12);
            this.label140.TabIndex = 284;
            this.label140.Text = "第6路延迟时间：";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(322, 255);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(95, 12);
            this.label141.TabIndex = 283;
            this.label141.Text = "第5路延迟时间：";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(322, 219);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(95, 12);
            this.label142.TabIndex = 282;
            this.label142.Text = "第4路延迟时间：";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(322, 183);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(95, 12);
            this.label143.TabIndex = 281;
            this.label143.Text = "第3路延迟时间：";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(322, 151);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(95, 12);
            this.label144.TabIndex = 280;
            this.label144.Text = "第2路延迟时间：";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(322, 116);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(95, 12);
            this.label145.TabIndex = 279;
            this.label145.Text = "第1路延迟时间：";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label146.Location = new System.Drawing.Point(613, 70);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(110, 16);
            this.label146.TabIndex = 278;
            this.label146.Text = "设置组合方式";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label147.Location = new System.Drawing.Point(321, 70);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(110, 16);
            this.label147.TabIndex = 277;
            this.label147.Text = "设置延迟时间";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.comboBox10.Location = new System.Drawing.Point(186, 371);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(63, 20);
            this.comboBox10.TabIndex = 276;
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(85, 379);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(95, 12);
            this.label148.TabIndex = 275;
            this.label148.Text = "第8路工作模式：";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.comboBox11.Location = new System.Drawing.Point(186, 330);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(63, 20);
            this.comboBox11.TabIndex = 274;
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(85, 338);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(95, 12);
            this.label149.TabIndex = 273;
            this.label149.Text = "第7路工作模式：";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.comboBox12.Location = new System.Drawing.Point(186, 290);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(63, 20);
            this.comboBox12.TabIndex = 272;
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(85, 298);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(95, 12);
            this.label150.TabIndex = 271;
            this.label150.Text = "第6路工作模式：";
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.comboBox13.Location = new System.Drawing.Point(186, 255);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(63, 20);
            this.comboBox13.TabIndex = 270;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(85, 263);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(95, 12);
            this.label151.TabIndex = 269;
            this.label151.Text = "第5路工作模式：";
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.comboBox14.Location = new System.Drawing.Point(186, 219);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(63, 20);
            this.comboBox14.TabIndex = 268;
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(85, 227);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(95, 12);
            this.label152.TabIndex = 267;
            this.label152.Text = "第4路工作模式：";
            // 
            // comboBox15
            // 
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.comboBox15.Location = new System.Drawing.Point(186, 184);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(63, 20);
            this.comboBox15.TabIndex = 266;
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(85, 191);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(95, 12);
            this.label153.TabIndex = 265;
            this.label153.Text = "第3路工作模式：";
            // 
            // comboBox16
            // 
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.comboBox16.Location = new System.Drawing.Point(186, 152);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(63, 20);
            this.comboBox16.TabIndex = 264;
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(85, 159);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(95, 12);
            this.label154.TabIndex = 263;
            this.label154.Text = "第2路工作模式：";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(85, 98);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(197, 12);
            this.label155.TabIndex = 262;
            this.label155.Text = "（00：保持，01：延迟，10：组合）";
            // 
            // comboBox17
            // 
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Items.AddRange(new object[] {
            "00",
            "01",
            "10"});
            this.comboBox17.Location = new System.Drawing.Point(186, 116);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(63, 20);
            this.comboBox17.TabIndex = 261;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(85, 124);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(95, 12);
            this.label156.TabIndex = 260;
            this.label156.Text = "第1路工作模式：";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label157.Location = new System.Drawing.Point(84, 70);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(110, 16);
            this.label157.TabIndex = 259;
            this.label157.Text = "设置工作模式";
            // 
            // metroTabPage14
            // 
            this.metroTabPage14.Controls.Add(this.metroPanel12);
            this.metroTabPage14.HorizontalScrollbar = true;
            this.metroTabPage14.HorizontalScrollbarBarColor = true;
            this.metroTabPage14.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage14.HorizontalScrollbarSize = 10;
            this.metroTabPage14.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage14.Name = "metroTabPage14";
            this.metroTabPage14.Size = new System.Drawing.Size(557, 343);
            this.metroTabPage14.TabIndex = 6;
            this.metroTabPage14.Text = "读写线圈-2";
            this.metroTabPage14.VerticalScrollbar = true;
            this.metroTabPage14.VerticalScrollbarBarColor = true;
            this.metroTabPage14.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage14.VerticalScrollbarSize = 10;
            // 
            // metroPanel12
            // 
            this.metroPanel12.AutoScroll = true;
            this.metroPanel12.Controls.Add(this.button42);
            this.metroPanel12.Controls.Add(this.button43);
            this.metroPanel12.Controls.Add(this.button44);
            this.metroPanel12.Controls.Add(this.comboBox18);
            this.metroPanel12.Controls.Add(this.label158);
            this.metroPanel12.Controls.Add(this.button45);
            this.metroPanel12.Controls.Add(this.button46);
            this.metroPanel12.Controls.Add(this.button47);
            this.metroPanel12.Controls.Add(this.comboBox19);
            this.metroPanel12.Controls.Add(this.comboBox20);
            this.metroPanel12.Controls.Add(this.comboBox21);
            this.metroPanel12.Controls.Add(this.label159);
            this.metroPanel12.Controls.Add(this.label160);
            this.metroPanel12.Controls.Add(this.label161);
            this.metroPanel12.Controls.Add(this.button48);
            this.metroPanel12.Controls.Add(this.button49);
            this.metroPanel12.Controls.Add(this.button50);
            this.metroPanel12.Controls.Add(this.button51);
            this.metroPanel12.Controls.Add(this.comboBox22);
            this.metroPanel12.Controls.Add(this.comboBox23);
            this.metroPanel12.Controls.Add(this.comboBox24);
            this.metroPanel12.Controls.Add(this.comboBox25);
            this.metroPanel12.Controls.Add(this.label162);
            this.metroPanel12.Controls.Add(this.label163);
            this.metroPanel12.Controls.Add(this.label164);
            this.metroPanel12.Controls.Add(this.label165);
            this.metroPanel12.Controls.Add(this.label166);
            this.metroPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel12.HorizontalScrollbar = true;
            this.metroPanel12.HorizontalScrollbarBarColor = true;
            this.metroPanel12.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel12.HorizontalScrollbarSize = 10;
            this.metroPanel12.Location = new System.Drawing.Point(0, 0);
            this.metroPanel12.Name = "metroPanel12";
            this.metroPanel12.Size = new System.Drawing.Size(557, 343);
            this.metroPanel12.TabIndex = 2;
            this.metroPanel12.VerticalScrollbar = true;
            this.metroPanel12.VerticalScrollbarBarColor = true;
            this.metroPanel12.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel12.VerticalScrollbarSize = 10;
            this.metroPanel12.Enter += new System.EventHandler(this.metroPanel12_Enter);
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(187, 248);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(172, 23);
            this.button42.TabIndex = 310;
            this.button42.Text = "获取当前线圈开断状态";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(187, 302);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(172, 23);
            this.button43.TabIndex = 309;
            this.button43.Text = "保存当前所有线圈状态";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(459, 83);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(50, 23);
            this.button44.TabIndex = 308;
            this.button44.Text = "写开断";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button48_Click);
            // 
            // comboBox18
            // 
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "0000",
            "FF00"});
            this.comboBox18.Location = new System.Drawing.Point(393, 188);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(60, 20);
            this.comboBox18.TabIndex = 307;
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(303, 88);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(95, 12);
            this.label158.TabIndex = 306;
            this.label158.Text = "第5路线圈状态：";
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(459, 187);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(50, 23);
            this.button45.TabIndex = 305;
            this.button45.Text = "写开断";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button51_Click);
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(459, 151);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(50, 23);
            this.button46.TabIndex = 304;
            this.button46.Text = "写开断";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.button50_Click);
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(459, 118);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(50, 23);
            this.button47.TabIndex = 303;
            this.button47.Text = "写开断";
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.button49_Click);
            // 
            // comboBox19
            // 
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Items.AddRange(new object[] {
            "0000",
            "FF00"});
            this.comboBox19.Location = new System.Drawing.Point(393, 153);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(60, 20);
            this.comboBox19.TabIndex = 302;
            // 
            // comboBox20
            // 
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Items.AddRange(new object[] {
            "0000",
            "FF00"});
            this.comboBox20.Location = new System.Drawing.Point(393, 120);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(60, 20);
            this.comboBox20.TabIndex = 301;
            // 
            // comboBox21
            // 
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Items.AddRange(new object[] {
            "0000",
            "FF00"});
            this.comboBox21.Location = new System.Drawing.Point(393, 85);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(60, 20);
            this.comboBox21.TabIndex = 300;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(303, 193);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(95, 12);
            this.label159.TabIndex = 299;
            this.label159.Text = "第8路线圈状态：";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(303, 156);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(95, 12);
            this.label160.TabIndex = 298;
            this.label160.Text = "第7路线圈状态：";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(303, 123);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(95, 12);
            this.label161.TabIndex = 297;
            this.label161.Text = "第6路线圈状态：";
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(205, 151);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(50, 23);
            this.button48.TabIndex = 296;
            this.button48.Text = "写开断";
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.button46_Click);
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(205, 186);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(50, 23);
            this.button49.TabIndex = 295;
            this.button49.Text = "写开断";
            this.button49.UseVisualStyleBackColor = true;
            this.button49.Click += new System.EventHandler(this.button47_Click);
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(205, 118);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(50, 23);
            this.button50.TabIndex = 294;
            this.button50.Text = "写开断";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button45_Click);
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(205, 83);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(50, 23);
            this.button51.TabIndex = 293;
            this.button51.Text = "写开断";
            this.button51.UseVisualStyleBackColor = true;
            this.button51.Click += new System.EventHandler(this.button44_Click);
            // 
            // comboBox22
            // 
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Items.AddRange(new object[] {
            "0000",
            "FF00"});
            this.comboBox22.Location = new System.Drawing.Point(139, 188);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(60, 20);
            this.comboBox22.TabIndex = 292;
            // 
            // comboBox23
            // 
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Items.AddRange(new object[] {
            "0000",
            "FF00"});
            this.comboBox23.Location = new System.Drawing.Point(139, 152);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(60, 20);
            this.comboBox23.TabIndex = 291;
            // 
            // comboBox24
            // 
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Items.AddRange(new object[] {
            "0000",
            "FF00"});
            this.comboBox24.Location = new System.Drawing.Point(139, 120);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(60, 20);
            this.comboBox24.TabIndex = 290;
            // 
            // comboBox25
            // 
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Items.AddRange(new object[] {
            "0000",
            "FF00"});
            this.comboBox25.Location = new System.Drawing.Point(139, 85);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(60, 20);
            this.comboBox25.TabIndex = 289;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(49, 191);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(95, 12);
            this.label162.TabIndex = 288;
            this.label162.Text = "第4路线圈状态：";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(49, 155);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(95, 12);
            this.label163.TabIndex = 287;
            this.label163.Text = "第3路线圈状态：";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(49, 123);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(95, 12);
            this.label164.TabIndex = 286;
            this.label164.Text = "第2路线圈状态：";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(49, 88);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(95, 12);
            this.label165.TabIndex = 285;
            this.label165.Text = "第1路线圈状态：";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label166.Location = new System.Drawing.Point(226, 16);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(110, 16);
            this.label166.TabIndex = 284;
            this.label166.Text = "读写线圈状态";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "读写线圈";
            treeNode2.Name = "节点4";
            treeNode2.Text = "设置组合";
            treeNode3.Name = "节点2";
            treeNode3.Text = "设置工作和延迟";
            treeNode4.Name = "节点0";
            treeNode4.Text = "SRC0001";
            treeNode5.Name = "节点7";
            treeNode5.Text = "AI";
            treeNode6.Name = "节点8";
            treeNode6.Text = "DI";
            treeNode7.Name = "节点9";
            treeNode7.Text = "DO";
            treeNode8.Name = "节点6";
            treeNode8.Text = "读写线圈";
            treeNode9.Name = "节点5";
            treeNode9.Text = "SRC0002";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(135, 388);
            this.treeView1.TabIndex = 3;
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.txtCmd);
            this.metroPanel5.Controls.Add(this.metroLabel7);
            this.metroPanel5.Controls.Add(this.metroLabel6);
            this.metroPanel5.Controls.Add(this.button1);
            this.metroPanel5.Controls.Add(this.button2);
            this.metroPanel5.Controls.Add(this.comboBox1);
            this.metroPanel5.Controls.Add(this.button3);
            this.metroPanel5.Controls.Add(this.lstReceiveData);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(712, 0);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(171, 388);
            this.metroPanel5.TabIndex = 2;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // txtCmd
            // 
            this.txtCmd.Lines = new string[0];
            this.txtCmd.Location = new System.Drawing.Point(18, 139);
            this.txtCmd.MaxLength = 32767;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.PasswordChar = '\0';
            this.txtCmd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCmd.SelectedText = "";
            this.txtCmd.Size = new System.Drawing.Size(133, 23);
            this.txtCmd.TabIndex = 146;
            this.txtCmd.UseSelectable = true;
            this.txtCmd.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(19, 76);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(135, 20);
            this.metroLabel7.TabIndex = 145;
            this.metroLabel7.Text = "返回数据如下所示：";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 19);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(121, 20);
            this.metroLabel6.TabIndex = 144;
            this.metroLabel6.Text = "请选择设备地址：";
            this.metroLabel6.UseStyleColors = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 143;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 142;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(17, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 20);
            this.comboBox1.TabIndex = 139;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "01";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 141;
            this.button3.Text = "hex显示";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstReceiveData
            // 
            this.lstReceiveData.FormattingEnabled = true;
            this.lstReceiveData.ItemHeight = 12;
            this.lstReceiveData.Location = new System.Drawing.Point(17, 173);
            this.lstReceiveData.Name = "lstReceiveData";
            this.lstReceiveData.Size = new System.Drawing.Size(138, 148);
            this.lstReceiveData.TabIndex = 140;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage2.Controls.Add(this.metroPanel16);
            this.metroTabPage2.Controls.Add(this.metroPanel15);
            this.metroTabPage2.Controls.Add(this.metroPanel14);
            this.metroTabPage2.Controls.Add(this.metroPanel13);
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(885, 390);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "&485采集设备";
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel16
            // 
            this.metroPanel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel16.Controls.Add(this.cbWeaFunction);
            this.metroPanel16.Controls.Add(this.metroLabel38);
            this.metroPanel16.Controls.Add(this.btnWea);
            this.metroPanel16.Controls.Add(this.metroLabel39);
            this.metroPanel16.Controls.Add(this.metroLabel40);
            this.metroPanel16.Controls.Add(this.txtWeaPreAddress);
            this.metroPanel16.Controls.Add(this.metroLabel41);
            this.metroPanel16.Controls.Add(this.txtWeaFolAddress);
            this.metroPanel16.Controls.Add(this.metroLabel42);
            this.metroPanel16.Controls.Add(this.txtWeaPreBaudRate);
            this.metroPanel16.Controls.Add(this.metroLabel43);
            this.metroPanel16.Controls.Add(this.txtWeaFolBaudRate);
            this.metroPanel16.Controls.Add(this.txtWeaValue);
            this.metroPanel16.HorizontalScrollbarBarColor = true;
            this.metroPanel16.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel16.HorizontalScrollbarSize = 10;
            this.metroPanel16.Location = new System.Drawing.Point(726, 4);
            this.metroPanel16.Name = "metroPanel16";
            this.metroPanel16.Size = new System.Drawing.Size(223, 382);
            this.metroPanel16.TabIndex = 71;
            this.metroPanel16.VerticalScrollbarBarColor = true;
            this.metroPanel16.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel16.VerticalScrollbarSize = 10;
            // 
            // cbWeaFunction
            // 
            this.cbWeaFunction.FormattingEnabled = true;
            this.cbWeaFunction.ItemHeight = 24;
            this.cbWeaFunction.Items.AddRange(new object[] {
            "读设备地址",
            "写设备地址",
            "读波特率",
            "写波特率",
            "读取数据值",
            "读波特率和地址"});
            this.cbWeaFunction.Location = new System.Drawing.Point(9, 59);
            this.cbWeaFunction.Name = "cbWeaFunction";
            this.cbWeaFunction.PromptText = "读取数据值";
            this.cbWeaFunction.Size = new System.Drawing.Size(103, 30);
            this.cbWeaFunction.TabIndex = 81;
            this.cbWeaFunction.UseSelectable = true;
            this.cbWeaFunction.UseStyleColors = true;
            // 
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.Location = new System.Drawing.Point(9, 272);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(79, 20);
            this.metroLabel38.TabIndex = 79;
            this.metroLabel38.Text = "当前设备值";
            this.metroLabel38.UseStyleColors = true;
            // 
            // btnWea
            // 
            this.btnWea.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnWea.Location = new System.Drawing.Point(136, 63);
            this.btnWea.Name = "btnWea";
            this.btnWea.Size = new System.Drawing.Size(75, 23);
            this.btnWea.TabIndex = 80;
            this.btnWea.Text = "确定";
            this.btnWea.UseSelectable = true;
            this.btnWea.UseStyleColors = true;
            this.btnWea.Click += new System.EventHandler(this.btnWea_Click);
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.Location = new System.Drawing.Point(83, 9);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(51, 20);
            this.metroLabel39.TabIndex = 69;
            this.metroLabel39.Text = "气象站";
            this.metroLabel39.UseStyleColors = true;
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.Location = new System.Drawing.Point(136, 190);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(79, 20);
            this.metroLabel40.TabIndex = 78;
            this.metroLabel40.Text = "设置波特率";
            this.metroLabel40.UseStyleColors = true;
            // 
            // txtWeaPreAddress
            // 
            this.txtWeaPreAddress.Lines = new string[0];
            this.txtWeaPreAddress.Location = new System.Drawing.Point(9, 145);
            this.txtWeaPreAddress.MaxLength = 32767;
            this.txtWeaPreAddress.Name = "txtWeaPreAddress";
            this.txtWeaPreAddress.PasswordChar = '\0';
            this.txtWeaPreAddress.PromptText = "请输入十进制整数";
            this.txtWeaPreAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeaPreAddress.SelectedText = "";
            this.txtWeaPreAddress.Size = new System.Drawing.Size(103, 23);
            this.txtWeaPreAddress.TabIndex = 70;
            this.txtWeaPreAddress.UseSelectable = true;
            this.txtWeaPreAddress.UseStyleColors = true;
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.Location = new System.Drawing.Point(9, 190);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(79, 20);
            this.metroLabel41.TabIndex = 77;
            this.metroLabel41.Text = "当前波特率";
            this.metroLabel41.UseStyleColors = true;
            // 
            // txtWeaFolAddress
            // 
            this.txtWeaFolAddress.Lines = new string[] {
        "2"};
            this.txtWeaFolAddress.Location = new System.Drawing.Point(136, 145);
            this.txtWeaFolAddress.MaxLength = 32767;
            this.txtWeaFolAddress.Name = "txtWeaFolAddress";
            this.txtWeaFolAddress.PasswordChar = '\0';
            this.txtWeaFolAddress.PromptText = "请输入十进制整数";
            this.txtWeaFolAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeaFolAddress.SelectedText = "";
            this.txtWeaFolAddress.Size = new System.Drawing.Size(75, 23);
            this.txtWeaFolAddress.TabIndex = 71;
            this.txtWeaFolAddress.Text = "2";
            this.txtWeaFolAddress.UseSelectable = true;
            this.txtWeaFolAddress.UseStyleColors = true;
            // 
            // metroLabel42
            // 
            this.metroLabel42.AutoSize = true;
            this.metroLabel42.Location = new System.Drawing.Point(136, 113);
            this.metroLabel42.Name = "metroLabel42";
            this.metroLabel42.Size = new System.Drawing.Size(89, 20);
            this.metroLabel42.TabIndex = 76;
            this.metroLabel42.Text = "设置485地址";
            this.metroLabel42.UseStyleColors = true;
            // 
            // txtWeaPreBaudRate
            // 
            this.txtWeaPreBaudRate.Lines = new string[0];
            this.txtWeaPreBaudRate.Location = new System.Drawing.Point(9, 226);
            this.txtWeaPreBaudRate.MaxLength = 32767;
            this.txtWeaPreBaudRate.Name = "txtWeaPreBaudRate";
            this.txtWeaPreBaudRate.PasswordChar = '\0';
            this.txtWeaPreBaudRate.PromptText = "请输入十进制整数";
            this.txtWeaPreBaudRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeaPreBaudRate.SelectedText = "";
            this.txtWeaPreBaudRate.Size = new System.Drawing.Size(103, 23);
            this.txtWeaPreBaudRate.TabIndex = 72;
            this.txtWeaPreBaudRate.UseSelectable = true;
            this.txtWeaPreBaudRate.UseStyleColors = true;
            // 
            // metroLabel43
            // 
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.Location = new System.Drawing.Point(9, 113);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(89, 20);
            this.metroLabel43.TabIndex = 75;
            this.metroLabel43.Text = "当前485地址";
            this.metroLabel43.UseStyleColors = true;
            // 
            // txtWeaFolBaudRate
            // 
            this.txtWeaFolBaudRate.Lines = new string[] {
        "9600"};
            this.txtWeaFolBaudRate.Location = new System.Drawing.Point(136, 226);
            this.txtWeaFolBaudRate.MaxLength = 32767;
            this.txtWeaFolBaudRate.Name = "txtWeaFolBaudRate";
            this.txtWeaFolBaudRate.PasswordChar = '\0';
            this.txtWeaFolBaudRate.PromptText = "请输入十进制整数";
            this.txtWeaFolBaudRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeaFolBaudRate.SelectedText = "";
            this.txtWeaFolBaudRate.Size = new System.Drawing.Size(75, 23);
            this.txtWeaFolBaudRate.TabIndex = 73;
            this.txtWeaFolBaudRate.Text = "9600";
            this.txtWeaFolBaudRate.UseSelectable = true;
            this.txtWeaFolBaudRate.UseStyleColors = true;
            // 
            // txtWeaValue
            // 
            this.txtWeaValue.Lines = new string[0];
            this.txtWeaValue.Location = new System.Drawing.Point(17, 294);
            this.txtWeaValue.MaxLength = 32767;
            this.txtWeaValue.Multiline = true;
            this.txtWeaValue.Name = "txtWeaValue";
            this.txtWeaValue.PasswordChar = '\0';
            this.txtWeaValue.PromptText = "显示设备原始值";
            this.txtWeaValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeaValue.SelectedText = "";
            this.txtWeaValue.Size = new System.Drawing.Size(194, 69);
            this.txtWeaValue.TabIndex = 74;
            this.txtWeaValue.UseSelectable = true;
            this.txtWeaValue.UseStyleColors = true;
            // 
            // metroPanel15
            // 
            this.metroPanel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel15.Controls.Add(this.cbTempHumFuction);
            this.metroPanel15.Controls.Add(this.metroLabel32);
            this.metroPanel15.Controls.Add(this.btnTempHum);
            this.metroPanel15.Controls.Add(this.metroLabel33);
            this.metroPanel15.Controls.Add(this.metroLabel34);
            this.metroPanel15.Controls.Add(this.txtTempHumPreAddress);
            this.metroPanel15.Controls.Add(this.metroLabel35);
            this.metroPanel15.Controls.Add(this.txtTempHumFolAddress);
            this.metroPanel15.Controls.Add(this.metroLabel36);
            this.metroPanel15.Controls.Add(this.txtTempHumPreBaudRate);
            this.metroPanel15.Controls.Add(this.metroLabel37);
            this.metroPanel15.Controls.Add(this.txtTempHumFolBaudRate);
            this.metroPanel15.Controls.Add(this.txtTempHumValue);
            this.metroPanel15.HorizontalScrollbarBarColor = true;
            this.metroPanel15.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel15.HorizontalScrollbarSize = 10;
            this.metroPanel15.Location = new System.Drawing.Point(485, 4);
            this.metroPanel15.Name = "metroPanel15";
            this.metroPanel15.Size = new System.Drawing.Size(235, 382);
            this.metroPanel15.TabIndex = 70;
            this.metroPanel15.VerticalScrollbarBarColor = true;
            this.metroPanel15.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel15.VerticalScrollbarSize = 10;
            // 
            // cbTempHumFuction
            // 
            this.cbTempHumFuction.FormattingEnabled = true;
            this.cbTempHumFuction.ItemHeight = 24;
            this.cbTempHumFuction.Items.AddRange(new object[] {
            "读设备地址",
            "写设备地址",
            "读波特率",
            "写波特率",
            "读取数据值",
            "读波特率和地址"});
            this.cbTempHumFuction.Location = new System.Drawing.Point(9, 59);
            this.cbTempHumFuction.Name = "cbTempHumFuction";
            this.cbTempHumFuction.PromptText = "读取数据值";
            this.cbTempHumFuction.Size = new System.Drawing.Size(103, 30);
            this.cbTempHumFuction.TabIndex = 81;
            this.cbTempHumFuction.UseSelectable = true;
            this.cbTempHumFuction.UseStyleColors = true;
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.Location = new System.Drawing.Point(9, 295);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(79, 20);
            this.metroLabel32.TabIndex = 79;
            this.metroLabel32.Text = "当前设备值";
            this.metroLabel32.UseStyleColors = true;
            // 
            // btnTempHum
            // 
            this.btnTempHum.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTempHum.Location = new System.Drawing.Point(136, 63);
            this.btnTempHum.Name = "btnTempHum";
            this.btnTempHum.Size = new System.Drawing.Size(75, 23);
            this.btnTempHum.TabIndex = 80;
            this.btnTempHum.Text = "确定";
            this.btnTempHum.UseSelectable = true;
            this.btnTempHum.UseStyleColors = true;
            this.btnTempHum.Click += new System.EventHandler(this.btnTempHum_Click);
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Location = new System.Drawing.Point(83, 9);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(65, 20);
            this.metroLabel33.TabIndex = 69;
            this.metroLabel33.Text = "设施农业";
            this.metroLabel33.UseStyleColors = true;
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Location = new System.Drawing.Point(136, 190);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(79, 20);
            this.metroLabel34.TabIndex = 78;
            this.metroLabel34.Text = "设置波特率";
            this.metroLabel34.UseStyleColors = true;
            // 
            // txtTempHumPreAddress
            // 
            this.txtTempHumPreAddress.Lines = new string[0];
            this.txtTempHumPreAddress.Location = new System.Drawing.Point(9, 145);
            this.txtTempHumPreAddress.MaxLength = 32767;
            this.txtTempHumPreAddress.Name = "txtTempHumPreAddress";
            this.txtTempHumPreAddress.PasswordChar = '\0';
            this.txtTempHumPreAddress.PromptText = "请输入十进制整数";
            this.txtTempHumPreAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempHumPreAddress.SelectedText = "";
            this.txtTempHumPreAddress.Size = new System.Drawing.Size(103, 23);
            this.txtTempHumPreAddress.TabIndex = 70;
            this.txtTempHumPreAddress.UseSelectable = true;
            this.txtTempHumPreAddress.UseStyleColors = true;
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.Location = new System.Drawing.Point(9, 190);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(79, 20);
            this.metroLabel35.TabIndex = 77;
            this.metroLabel35.Text = "当前波特率";
            this.metroLabel35.UseStyleColors = true;
            // 
            // txtTempHumFolAddress
            // 
            this.txtTempHumFolAddress.Lines = new string[] {
        "20"};
            this.txtTempHumFolAddress.Location = new System.Drawing.Point(136, 145);
            this.txtTempHumFolAddress.MaxLength = 32767;
            this.txtTempHumFolAddress.Name = "txtTempHumFolAddress";
            this.txtTempHumFolAddress.PasswordChar = '\0';
            this.txtTempHumFolAddress.PromptText = "请输入十进制整数";
            this.txtTempHumFolAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempHumFolAddress.SelectedText = "";
            this.txtTempHumFolAddress.Size = new System.Drawing.Size(75, 23);
            this.txtTempHumFolAddress.TabIndex = 71;
            this.txtTempHumFolAddress.Text = "20";
            this.txtTempHumFolAddress.UseSelectable = true;
            this.txtTempHumFolAddress.UseStyleColors = true;
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.Location = new System.Drawing.Point(136, 113);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(89, 20);
            this.metroLabel36.TabIndex = 76;
            this.metroLabel36.Text = "设置485地址";
            this.metroLabel36.UseStyleColors = true;
            // 
            // txtTempHumPreBaudRate
            // 
            this.txtTempHumPreBaudRate.Lines = new string[0];
            this.txtTempHumPreBaudRate.Location = new System.Drawing.Point(9, 226);
            this.txtTempHumPreBaudRate.MaxLength = 32767;
            this.txtTempHumPreBaudRate.Name = "txtTempHumPreBaudRate";
            this.txtTempHumPreBaudRate.PasswordChar = '\0';
            this.txtTempHumPreBaudRate.PromptText = "请输入十进制整数";
            this.txtTempHumPreBaudRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempHumPreBaudRate.SelectedText = "";
            this.txtTempHumPreBaudRate.Size = new System.Drawing.Size(103, 23);
            this.txtTempHumPreBaudRate.TabIndex = 72;
            this.txtTempHumPreBaudRate.UseSelectable = true;
            this.txtTempHumPreBaudRate.UseStyleColors = true;
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.Location = new System.Drawing.Point(9, 113);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(89, 20);
            this.metroLabel37.TabIndex = 75;
            this.metroLabel37.Text = "当前485地址";
            this.metroLabel37.UseStyleColors = true;
            // 
            // txtTempHumFolBaudRate
            // 
            this.txtTempHumFolBaudRate.Lines = new string[] {
        "9600"};
            this.txtTempHumFolBaudRate.Location = new System.Drawing.Point(136, 226);
            this.txtTempHumFolBaudRate.MaxLength = 32767;
            this.txtTempHumFolBaudRate.Name = "txtTempHumFolBaudRate";
            this.txtTempHumFolBaudRate.PasswordChar = '\0';
            this.txtTempHumFolBaudRate.PromptText = "请输入十进制整数";
            this.txtTempHumFolBaudRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempHumFolBaudRate.SelectedText = "";
            this.txtTempHumFolBaudRate.Size = new System.Drawing.Size(75, 23);
            this.txtTempHumFolBaudRate.TabIndex = 73;
            this.txtTempHumFolBaudRate.Text = "9600";
            this.txtTempHumFolBaudRate.UseSelectable = true;
            this.txtTempHumFolBaudRate.UseStyleColors = true;
            // 
            // txtTempHumValue
            // 
            this.txtTempHumValue.Lines = new string[0];
            this.txtTempHumValue.Location = new System.Drawing.Point(114, 295);
            this.txtTempHumValue.MaxLength = 32767;
            this.txtTempHumValue.Name = "txtTempHumValue";
            this.txtTempHumValue.PasswordChar = '\0';
            this.txtTempHumValue.PromptText = "显示设备原始值";
            this.txtTempHumValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempHumValue.SelectedText = "";
            this.txtTempHumValue.Size = new System.Drawing.Size(97, 23);
            this.txtTempHumValue.TabIndex = 74;
            this.txtTempHumValue.UseSelectable = true;
            this.txtTempHumValue.UseStyleColors = true;
            // 
            // metroPanel14
            // 
            this.metroPanel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel14.Controls.Add(this.cbPoisonFunction);
            this.metroPanel14.Controls.Add(this.metroLabel26);
            this.metroPanel14.Controls.Add(this.btnPio);
            this.metroPanel14.Controls.Add(this.metroLabel27);
            this.metroPanel14.Controls.Add(this.metroLabel28);
            this.metroPanel14.Controls.Add(this.txtPioPreAddress);
            this.metroPanel14.Controls.Add(this.metroLabel29);
            this.metroPanel14.Controls.Add(this.txtPioFolAddress);
            this.metroPanel14.Controls.Add(this.metroLabel30);
            this.metroPanel14.Controls.Add(this.txtPioPreBaudRate);
            this.metroPanel14.Controls.Add(this.metroLabel31);
            this.metroPanel14.Controls.Add(this.txtPioFolBaudRate);
            this.metroPanel14.Controls.Add(this.txtPioValue);
            this.metroPanel14.HorizontalScrollbarBarColor = true;
            this.metroPanel14.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel14.HorizontalScrollbarSize = 10;
            this.metroPanel14.Location = new System.Drawing.Point(244, 3);
            this.metroPanel14.Name = "metroPanel14";
            this.metroPanel14.Size = new System.Drawing.Size(235, 382);
            this.metroPanel14.TabIndex = 69;
            this.metroPanel14.VerticalScrollbarBarColor = true;
            this.metroPanel14.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel14.VerticalScrollbarSize = 10;
            // 
            // cbPoisonFunction
            // 
            this.cbPoisonFunction.FormattingEnabled = true;
            this.cbPoisonFunction.ItemHeight = 24;
            this.cbPoisonFunction.Items.AddRange(new object[] {
            "读取数据值"});
            this.cbPoisonFunction.Location = new System.Drawing.Point(9, 59);
            this.cbPoisonFunction.Name = "cbPoisonFunction";
            this.cbPoisonFunction.PromptText = "读取数据值";
            this.cbPoisonFunction.Size = new System.Drawing.Size(103, 30);
            this.cbPoisonFunction.TabIndex = 81;
            this.cbPoisonFunction.UseSelectable = true;
            this.cbPoisonFunction.UseStyleColors = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(9, 295);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(79, 20);
            this.metroLabel26.TabIndex = 79;
            this.metroLabel26.Text = "当前设备值";
            this.metroLabel26.UseStyleColors = true;
            // 
            // btnPio
            // 
            this.btnPio.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPio.Location = new System.Drawing.Point(136, 63);
            this.btnPio.Name = "btnPio";
            this.btnPio.Size = new System.Drawing.Size(75, 23);
            this.btnPio.TabIndex = 80;
            this.btnPio.Text = "确定";
            this.btnPio.UseSelectable = true;
            this.btnPio.UseStyleColors = true;
            this.btnPio.Click += new System.EventHandler(this.btnPio_Click);
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(83, 9);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(65, 20);
            this.metroLabel27.TabIndex = 69;
            this.metroLabel27.Text = "有毒气体";
            this.metroLabel27.UseStyleColors = true;
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Location = new System.Drawing.Point(136, 190);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(79, 20);
            this.metroLabel28.TabIndex = 78;
            this.metroLabel28.Text = "设置波特率";
            this.metroLabel28.UseStyleColors = true;
            // 
            // txtPioPreAddress
            // 
            this.txtPioPreAddress.Lines = new string[0];
            this.txtPioPreAddress.Location = new System.Drawing.Point(9, 145);
            this.txtPioPreAddress.MaxLength = 32767;
            this.txtPioPreAddress.Name = "txtPioPreAddress";
            this.txtPioPreAddress.PasswordChar = '\0';
            this.txtPioPreAddress.PromptText = "请输入十进制整数";
            this.txtPioPreAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPioPreAddress.SelectedText = "";
            this.txtPioPreAddress.Size = new System.Drawing.Size(103, 23);
            this.txtPioPreAddress.TabIndex = 70;
            this.txtPioPreAddress.UseSelectable = true;
            this.txtPioPreAddress.UseStyleColors = true;
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(9, 190);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(79, 20);
            this.metroLabel29.TabIndex = 77;
            this.metroLabel29.Text = "当前波特率";
            this.metroLabel29.UseStyleColors = true;
            // 
            // txtPioFolAddress
            // 
            this.txtPioFolAddress.Lines = new string[] {
        "3"};
            this.txtPioFolAddress.Location = new System.Drawing.Point(136, 145);
            this.txtPioFolAddress.MaxLength = 32767;
            this.txtPioFolAddress.Name = "txtPioFolAddress";
            this.txtPioFolAddress.PasswordChar = '\0';
            this.txtPioFolAddress.PromptText = "请输入十进制整数";
            this.txtPioFolAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPioFolAddress.SelectedText = "";
            this.txtPioFolAddress.Size = new System.Drawing.Size(75, 23);
            this.txtPioFolAddress.TabIndex = 71;
            this.txtPioFolAddress.Text = "3";
            this.txtPioFolAddress.UseSelectable = true;
            this.txtPioFolAddress.UseStyleColors = true;
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Location = new System.Drawing.Point(136, 113);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(89, 20);
            this.metroLabel30.TabIndex = 76;
            this.metroLabel30.Text = "设置485地址";
            this.metroLabel30.UseStyleColors = true;
            // 
            // txtPioPreBaudRate
            // 
            this.txtPioPreBaudRate.Lines = new string[0];
            this.txtPioPreBaudRate.Location = new System.Drawing.Point(9, 226);
            this.txtPioPreBaudRate.MaxLength = 32767;
            this.txtPioPreBaudRate.Name = "txtPioPreBaudRate";
            this.txtPioPreBaudRate.PasswordChar = '\0';
            this.txtPioPreBaudRate.PromptText = "请输入十进制整数";
            this.txtPioPreBaudRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPioPreBaudRate.SelectedText = "";
            this.txtPioPreBaudRate.Size = new System.Drawing.Size(103, 23);
            this.txtPioPreBaudRate.TabIndex = 72;
            this.txtPioPreBaudRate.UseSelectable = true;
            this.txtPioPreBaudRate.UseStyleColors = true;
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.Location = new System.Drawing.Point(9, 113);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(89, 20);
            this.metroLabel31.TabIndex = 75;
            this.metroLabel31.Text = "当前485地址";
            this.metroLabel31.UseStyleColors = true;
            // 
            // txtPioFolBaudRate
            // 
            this.txtPioFolBaudRate.Lines = new string[] {
        "9600"};
            this.txtPioFolBaudRate.Location = new System.Drawing.Point(136, 226);
            this.txtPioFolBaudRate.MaxLength = 32767;
            this.txtPioFolBaudRate.Name = "txtPioFolBaudRate";
            this.txtPioFolBaudRate.PasswordChar = '\0';
            this.txtPioFolBaudRate.PromptText = "请输入十进制整数";
            this.txtPioFolBaudRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPioFolBaudRate.SelectedText = "";
            this.txtPioFolBaudRate.Size = new System.Drawing.Size(75, 23);
            this.txtPioFolBaudRate.TabIndex = 73;
            this.txtPioFolBaudRate.Text = "9600";
            this.txtPioFolBaudRate.UseSelectable = true;
            this.txtPioFolBaudRate.UseStyleColors = true;
            // 
            // txtPioValue
            // 
            this.txtPioValue.Lines = new string[0];
            this.txtPioValue.Location = new System.Drawing.Point(114, 295);
            this.txtPioValue.MaxLength = 32767;
            this.txtPioValue.Name = "txtPioValue";
            this.txtPioValue.PasswordChar = '\0';
            this.txtPioValue.PromptText = "显示设备原始值";
            this.txtPioValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPioValue.SelectedText = "";
            this.txtPioValue.Size = new System.Drawing.Size(97, 23);
            this.txtPioValue.TabIndex = 74;
            this.txtPioValue.UseSelectable = true;
            this.txtPioValue.UseStyleColors = true;
            // 
            // metroPanel13
            // 
            this.metroPanel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel13.Controls.Add(this.cbCo2Function);
            this.metroPanel13.Controls.Add(this.metroLabel25);
            this.metroPanel13.Controls.Add(this.btnCo2);
            this.metroPanel13.Controls.Add(this.metroLabel16);
            this.metroPanel13.Controls.Add(this.metroLabel23);
            this.metroPanel13.Controls.Add(this.txtCo2PreAddress);
            this.metroPanel13.Controls.Add(this.metroLabel24);
            this.metroPanel13.Controls.Add(this.txtCo2FolAddress);
            this.metroPanel13.Controls.Add(this.metroLabel22);
            this.metroPanel13.Controls.Add(this.txtCo2PreBaudRate);
            this.metroPanel13.Controls.Add(this.metroLabel21);
            this.metroPanel13.Controls.Add(this.txtCo2FolBaudRate);
            this.metroPanel13.Controls.Add(this.txtCo2Value);
            this.metroPanel13.HorizontalScrollbarBarColor = true;
            this.metroPanel13.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel13.HorizontalScrollbarSize = 10;
            this.metroPanel13.Location = new System.Drawing.Point(3, 3);
            this.metroPanel13.Name = "metroPanel13";
            this.metroPanel13.Size = new System.Drawing.Size(235, 382);
            this.metroPanel13.TabIndex = 68;
            this.metroPanel13.VerticalScrollbarBarColor = true;
            this.metroPanel13.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel13.VerticalScrollbarSize = 10;
            // 
            // cbCo2Function
            // 
            this.cbCo2Function.FormattingEnabled = true;
            this.cbCo2Function.ItemHeight = 24;
            this.cbCo2Function.Items.AddRange(new object[] {
            "读设备地址",
            "写设备地址",
            "读波特率",
            "写波特率",
            "读取数据值",
            "读波特率和地址"});
            this.cbCo2Function.Location = new System.Drawing.Point(9, 59);
            this.cbCo2Function.Name = "cbCo2Function";
            this.cbCo2Function.PromptText = "读取数据值";
            this.cbCo2Function.Size = new System.Drawing.Size(103, 30);
            this.cbCo2Function.TabIndex = 81;
            this.cbCo2Function.UseSelectable = true;
            this.cbCo2Function.UseStyleColors = true;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(9, 295);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(79, 20);
            this.metroLabel25.TabIndex = 79;
            this.metroLabel25.Text = "当前设备值";
            this.metroLabel25.UseStyleColors = true;
            // 
            // btnCo2
            // 
            this.btnCo2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCo2.Location = new System.Drawing.Point(136, 63);
            this.btnCo2.Name = "btnCo2";
            this.btnCo2.Size = new System.Drawing.Size(75, 23);
            this.btnCo2.TabIndex = 80;
            this.btnCo2.Text = "确定";
            this.btnCo2.UseSelectable = true;
            this.btnCo2.UseStyleColors = true;
            this.btnCo2.Click += new System.EventHandler(this.btnCo2_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(100, 9);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(35, 20);
            this.metroLabel16.TabIndex = 69;
            this.metroLabel16.Text = "CO₂";
            this.metroLabel16.UseStyleColors = true;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(136, 190);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(79, 20);
            this.metroLabel23.TabIndex = 78;
            this.metroLabel23.Text = "设置波特率";
            this.metroLabel23.UseStyleColors = true;
            // 
            // txtCo2PreAddress
            // 
            this.txtCo2PreAddress.Lines = new string[0];
            this.txtCo2PreAddress.Location = new System.Drawing.Point(9, 145);
            this.txtCo2PreAddress.MaxLength = 32767;
            this.txtCo2PreAddress.Name = "txtCo2PreAddress";
            this.txtCo2PreAddress.PasswordChar = '\0';
            this.txtCo2PreAddress.PromptText = "请输入十进制整数";
            this.txtCo2PreAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCo2PreAddress.SelectedText = "";
            this.txtCo2PreAddress.Size = new System.Drawing.Size(103, 23);
            this.txtCo2PreAddress.TabIndex = 70;
            this.txtCo2PreAddress.UseSelectable = true;
            this.txtCo2PreAddress.UseStyleColors = true;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(9, 190);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(79, 20);
            this.metroLabel24.TabIndex = 77;
            this.metroLabel24.Text = "当前波特率";
            this.metroLabel24.UseStyleColors = true;
            // 
            // txtCo2FolAddress
            // 
            this.txtCo2FolAddress.Lines = new string[] {
        "60"};
            this.txtCo2FolAddress.Location = new System.Drawing.Point(136, 145);
            this.txtCo2FolAddress.MaxLength = 32767;
            this.txtCo2FolAddress.Name = "txtCo2FolAddress";
            this.txtCo2FolAddress.PasswordChar = '\0';
            this.txtCo2FolAddress.PromptText = "请输入十进制整数";
            this.txtCo2FolAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCo2FolAddress.SelectedText = "";
            this.txtCo2FolAddress.Size = new System.Drawing.Size(75, 23);
            this.txtCo2FolAddress.TabIndex = 71;
            this.txtCo2FolAddress.Text = "60";
            this.txtCo2FolAddress.UseSelectable = true;
            this.txtCo2FolAddress.UseStyleColors = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(136, 113);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(89, 20);
            this.metroLabel22.TabIndex = 76;
            this.metroLabel22.Text = "设置485地址";
            this.metroLabel22.UseStyleColors = true;
            // 
            // txtCo2PreBaudRate
            // 
            this.txtCo2PreBaudRate.Lines = new string[0];
            this.txtCo2PreBaudRate.Location = new System.Drawing.Point(9, 226);
            this.txtCo2PreBaudRate.MaxLength = 32767;
            this.txtCo2PreBaudRate.Name = "txtCo2PreBaudRate";
            this.txtCo2PreBaudRate.PasswordChar = '\0';
            this.txtCo2PreBaudRate.PromptText = "请输入十进制整数";
            this.txtCo2PreBaudRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCo2PreBaudRate.SelectedText = "";
            this.txtCo2PreBaudRate.Size = new System.Drawing.Size(103, 23);
            this.txtCo2PreBaudRate.TabIndex = 72;
            this.txtCo2PreBaudRate.UseSelectable = true;
            this.txtCo2PreBaudRate.UseStyleColors = true;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(9, 113);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(89, 20);
            this.metroLabel21.TabIndex = 75;
            this.metroLabel21.Text = "当前485地址";
            this.metroLabel21.UseStyleColors = true;
            // 
            // txtCo2FolBaudRate
            // 
            this.txtCo2FolBaudRate.Lines = new string[] {
        "9600"};
            this.txtCo2FolBaudRate.Location = new System.Drawing.Point(136, 226);
            this.txtCo2FolBaudRate.MaxLength = 32767;
            this.txtCo2FolBaudRate.Name = "txtCo2FolBaudRate";
            this.txtCo2FolBaudRate.PasswordChar = '\0';
            this.txtCo2FolBaudRate.PromptText = "请输入十进制整数";
            this.txtCo2FolBaudRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCo2FolBaudRate.SelectedText = "";
            this.txtCo2FolBaudRate.Size = new System.Drawing.Size(75, 23);
            this.txtCo2FolBaudRate.TabIndex = 73;
            this.txtCo2FolBaudRate.Text = "9600";
            this.txtCo2FolBaudRate.UseSelectable = true;
            this.txtCo2FolBaudRate.UseStyleColors = true;
            // 
            // txtCo2Value
            // 
            this.txtCo2Value.Lines = new string[0];
            this.txtCo2Value.Location = new System.Drawing.Point(114, 295);
            this.txtCo2Value.MaxLength = 32767;
            this.txtCo2Value.Name = "txtCo2Value";
            this.txtCo2Value.PasswordChar = '\0';
            this.txtCo2Value.PromptText = "显示设备原始值";
            this.txtCo2Value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCo2Value.SelectedText = "";
            this.txtCo2Value.Size = new System.Drawing.Size(97, 23);
            this.txtCo2Value.TabIndex = 74;
            this.txtCo2Value.UseSelectable = true;
            this.txtCo2Value.UseStyleColors = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage4.Controls.Add(this.metroPanel3);
            this.metroTabPage4.Controls.Add(this.metroPanel4);
            this.metroTabPage4.Controls.Add(this.HKWSPanel);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(885, 390);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "&展示设备";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.txtLedAddress);
            this.metroPanel3.Controls.Add(this.metroLabel58);
            this.metroPanel3.Controls.Add(this.metroLabel13);
            this.metroPanel3.Controls.Add(this.lblResult);
            this.metroPanel3.Controls.Add(this.btnSend);
            this.metroPanel3.Controls.Add(this.txtMessage);
            this.metroPanel3.Controls.Add(this.metroLabel12);
            this.metroPanel3.Controls.Add(this.txtNum);
            this.metroPanel3.Controls.Add(this.txtPage);
            this.metroPanel3.Controls.Add(this.metroLabel11);
            this.metroPanel3.Controls.Add(this.metroLabel10);
            this.metroPanel3.Controls.Add(this.cbSendMethod);
            this.metroPanel3.Controls.Add(this.cbCardType);
            this.metroPanel3.Controls.Add(this.metroLabel9);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(275, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(313, 390);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txtLedAddress
            // 
            this.txtLedAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLedAddress.Lines = new string[] {
        "1"};
            this.txtLedAddress.Location = new System.Drawing.Point(150, 157);
            this.txtLedAddress.MaxLength = 32767;
            this.txtLedAddress.Name = "txtLedAddress";
            this.txtLedAddress.PasswordChar = '\0';
            this.txtLedAddress.PromptText = "输入整数";
            this.txtLedAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLedAddress.SelectedText = "";
            this.txtLedAddress.Size = new System.Drawing.Size(120, 23);
            this.txtLedAddress.TabIndex = 158;
            this.txtLedAddress.Text = "1";
            this.txtLedAddress.UseSelectable = true;
            this.txtLedAddress.UseStyleColors = true;
            // 
            // metroLabel58
            // 
            this.metroLabel58.AutoSize = true;
            this.metroLabel58.Location = new System.Drawing.Point(27, 157);
            this.metroLabel58.Name = "metroLabel58";
            this.metroLabel58.Size = new System.Drawing.Size(79, 20);
            this.metroLabel58.TabIndex = 157;
            this.metroLabel58.Text = "设备地址：";
            this.metroLabel58.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.ForeColor = System.Drawing.Color.Red;
            this.metroLabel13.Location = new System.Drawing.Point(108, 15);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(79, 24);
            this.metroLabel13.TabIndex = 156;
            this.metroLabel13.Text = "圆心LED";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(150, 348);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 20);
            this.lblResult.TabIndex = 155;
            this.lblResult.Text = "结果：";
            this.lblResult.UseStyleColors = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(62, 345);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 154;
            this.btnSend.Text = "确定发送";
            this.btnSend.UseSelectable = true;
            this.btnSend.UseStyleColors = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Lines = new string[] {
        "安徽斯玛特物联网欢迎您！"};
            this.txtMessage.Location = new System.Drawing.Point(27, 211);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(244, 123);
            this.txtMessage.TabIndex = 153;
            this.txtMessage.Text = "安徽斯玛特物联网欢迎您！";
            this.txtMessage.UseSelectable = true;
            this.txtMessage.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(27, 188);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(135, 20);
            this.metroLabel12.TabIndex = 152;
            this.metroLabel12.Text = "输入要发送的信息：";
            this.metroLabel12.UseStyleColors = true;
            // 
            // txtNum
            // 
            this.txtNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNum.Lines = new string[] {
        "1"};
            this.txtNum.Location = new System.Drawing.Point(150, 128);
            this.txtNum.MaxLength = 32767;
            this.txtNum.Name = "txtNum";
            this.txtNum.PasswordChar = '\0';
            this.txtNum.PromptText = "输入整数";
            this.txtNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNum.SelectedText = "";
            this.txtNum.Size = new System.Drawing.Size(120, 23);
            this.txtNum.TabIndex = 151;
            this.txtNum.Text = "1";
            this.txtNum.UseSelectable = true;
            this.txtNum.UseStyleColors = true;
            // 
            // txtPage
            // 
            this.txtPage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPage.Lines = new string[] {
        "1"};
            this.txtPage.Location = new System.Drawing.Point(27, 128);
            this.txtPage.MaxLength = 32767;
            this.txtPage.Name = "txtPage";
            this.txtPage.PasswordChar = '\0';
            this.txtPage.PromptText = "输入整数";
            this.txtPage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPage.SelectedText = "";
            this.txtPage.Size = new System.Drawing.Size(110, 23);
            this.txtPage.TabIndex = 150;
            this.txtPage.Text = "1";
            this.txtPage.UseSelectable = true;
            this.txtPage.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(150, 105);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(51, 20);
            this.metroLabel11.TabIndex = 149;
            this.metroLabel11.Text = "位置：";
            this.metroLabel11.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(27, 105);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(65, 20);
            this.metroLabel10.TabIndex = 148;
            this.metroLabel10.Text = "节目页：";
            this.metroLabel10.UseStyleColors = true;
            // 
            // cbSendMethod
            // 
            this.cbSendMethod.FormattingEnabled = true;
            this.cbSendMethod.ItemHeight = 24;
            this.cbSendMethod.Items.AddRange(new object[] {
            "SendRom",
            "SendRam"});
            this.cbSendMethod.Location = new System.Drawing.Point(150, 72);
            this.cbSendMethod.Name = "cbSendMethod";
            this.cbSendMethod.PromptText = "SendRom";
            this.cbSendMethod.Size = new System.Drawing.Size(121, 30);
            this.cbSendMethod.TabIndex = 147;
            this.cbSendMethod.UseSelectable = true;
            // 
            // cbCardType
            // 
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.ItemHeight = 24;
            this.cbCardType.Items.AddRange(new object[] {
            "圆心小卡",
            "圆心大卡"});
            this.cbCardType.Location = new System.Drawing.Point(27, 72);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.PromptText = "圆心小卡";
            this.cbCardType.Size = new System.Drawing.Size(110, 30);
            this.cbCardType.TabIndex = 146;
            this.cbCardType.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(149, 49);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(135, 20);
            this.metroLabel9.TabIndex = 145;
            this.metroLabel9.Text = "发送方式（小卡）：";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(27, 49);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(65, 20);
            this.metroLabel8.TabIndex = 144;
            this.metroLabel8.Text = "卡类型：";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.lblTtsMessage);
            this.metroPanel4.Controls.Add(this.metroLabel14);
            this.metroPanel4.Controls.Add(this.cbTimer);
            this.metroPanel4.Controls.Add(this.btnSendTts);
            this.metroPanel4.Controls.Add(this.txtInfo);
            this.metroPanel4.Controls.Add(this.txtTime);
            this.metroPanel4.Controls.Add(this.label1);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(269, 390);
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // lblTtsMessage
            // 
            this.lblTtsMessage.AutoSize = true;
            this.lblTtsMessage.Location = new System.Drawing.Point(70, 345);
            this.lblTtsMessage.Name = "lblTtsMessage";
            this.lblTtsMessage.Size = new System.Drawing.Size(81, 20);
            this.lblTtsMessage.TabIndex = 159;
            this.lblTtsMessage.Text = "tts发送结果";
            this.lblTtsMessage.UseStyleColors = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(70, 15);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(130, 24);
            this.metroLabel14.TabIndex = 158;
            this.metroLabel14.Text = "TTS语音播报器";
            // 
            // cbTimer
            // 
            this.cbTimer.AutoSize = true;
            this.cbTimer.Location = new System.Drawing.Point(186, 80);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(48, 17);
            this.cbTimer.TabIndex = 157;
            this.cbTimer.Text = "定时";
            this.cbTimer.UseSelectable = true;
            // 
            // btnSendTts
            // 
            this.btnSendTts.Location = new System.Drawing.Point(37, 145);
            this.btnSendTts.Name = "btnSendTts";
            this.btnSendTts.Size = new System.Drawing.Size(75, 23);
            this.btnSendTts.TabIndex = 156;
            this.btnSendTts.Text = "发送语音";
            this.btnSendTts.UseSelectable = true;
            this.btnSendTts.UseStyleColors = true;
            this.btnSendTts.Click += new System.EventHandler(this.btnSendTts_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Lines = new string[] {
        "安徽斯玛特物联网欢迎您！"};
            this.txtInfo.Location = new System.Drawing.Point(12, 209);
            this.txtInfo.MaxLength = 32767;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.PasswordChar = '\0';
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo.SelectedText = "";
            this.txtInfo.Size = new System.Drawing.Size(244, 123);
            this.txtInfo.TabIndex = 154;
            this.txtInfo.Text = "安徽斯玛特物联网欢迎您！";
            this.txtInfo.UseSelectable = true;
            this.txtInfo.UseStyleColors = true;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Location = new System.Drawing.Point(37, 74);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(75, 26);
            this.txtTime.TabIndex = 89;
            this.txtTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 90;
            this.label1.Text = "*100ms";
            // 
            // HKWSPanel
            // 
            this.HKWSPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HKWSPanel.BackgroundImage")));
            this.HKWSPanel.Controls.Add(this.btnLogin);
            this.HKWSPanel.Controls.Add(this.txtDataport);
            this.HKWSPanel.Controls.Add(this.txtI);
            this.HKWSPanel.Controls.Add(this.txtLoginPwd);
            this.HKWSPanel.Controls.Add(this.txtLoginName);
            this.HKWSPanel.Controls.Add(this.btnOn);
            this.HKWSPanel.Controls.Add(this.btnTelnet);
            this.HKWSPanel.Controls.Add(this.RealPlayWnd);
            this.HKWSPanel.Controls.Add(this.metroLabel17);
            this.HKWSPanel.Controls.Add(this.metroLabel18);
            this.HKWSPanel.Controls.Add(this.metroLabel19);
            this.HKWSPanel.Controls.Add(this.metroLabel20);
            this.HKWSPanel.Controls.Add(this.metroLabel15);
            this.HKWSPanel.HorizontalScrollbarBarColor = true;
            this.HKWSPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.HKWSPanel.HorizontalScrollbarSize = 10;
            this.HKWSPanel.Location = new System.Drawing.Point(594, 3);
            this.HKWSPanel.Name = "HKWSPanel";
            this.HKWSPanel.Size = new System.Drawing.Size(291, 384);
            this.HKWSPanel.TabIndex = 3;
            this.HKWSPanel.VerticalScrollbarBarColor = true;
            this.HKWSPanel.VerticalScrollbarHighlightOnWheel = false;
            this.HKWSPanel.VerticalScrollbarSize = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(13, 357);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(51, 24);
            this.btnLogin.TabIndex = 186;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtDataport
            // 
            this.txtDataport.Lines = new string[] {
        "30000"};
            this.txtDataport.Location = new System.Drawing.Point(136, 148);
            this.txtDataport.MaxLength = 32767;
            this.txtDataport.Name = "txtDataport";
            this.txtDataport.PasswordChar = '\0';
            this.txtDataport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDataport.SelectedText = "";
            this.txtDataport.Size = new System.Drawing.Size(93, 23);
            this.txtDataport.TabIndex = 185;
            this.txtDataport.Text = "30000";
            this.txtDataport.UseSelectable = true;
            this.txtDataport.UseStyleColors = true;
            // 
            // txtI
            // 
            this.txtI.Lines = new string[] {
        "61.190.174.70"};
            this.txtI.Location = new System.Drawing.Point(13, 148);
            this.txtI.MaxLength = 32767;
            this.txtI.Name = "txtI";
            this.txtI.PasswordChar = '\0';
            this.txtI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtI.SelectedText = "";
            this.txtI.Size = new System.Drawing.Size(93, 23);
            this.txtI.TabIndex = 184;
            this.txtI.Text = "61.190.174.70";
            this.txtI.UseSelectable = true;
            this.txtI.UseStyleColors = true;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Lines = new string[] {
        "smt12345"};
            this.txtLoginPwd.Location = new System.Drawing.Point(136, 78);
            this.txtLoginPwd.MaxLength = 32767;
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginPwd.SelectedText = "";
            this.txtLoginPwd.Size = new System.Drawing.Size(93, 23);
            this.txtLoginPwd.TabIndex = 183;
            this.txtLoginPwd.Text = "smt12345";
            this.txtLoginPwd.UseSelectable = true;
            this.txtLoginPwd.UseStyleColors = true;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Lines = new string[] {
        "admin"};
            this.txtLoginName.Location = new System.Drawing.Point(13, 82);
            this.txtLoginName.MaxLength = 32767;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginName.SelectedText = "";
            this.txtLoginName.Size = new System.Drawing.Size(93, 23);
            this.txtLoginName.TabIndex = 182;
            this.txtLoginName.Text = "admin";
            this.txtLoginName.UseSelectable = true;
            this.txtLoginName.UseStyleColors = true;
            // 
            // btnOn
            // 
            this.btnOn.AutoSize = true;
            this.btnOn.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnOn.Location = new System.Drawing.Point(106, 357);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(80, 16);
            this.btnOn.TabIndex = 181;
            this.btnOn.Text = "Off";
            this.btnOn.UseSelectable = true;
            this.btnOn.UseStyleColors = true;
            this.btnOn.CheckedChanged += new System.EventHandler(this.btnOn_CheckedChanged);
            // 
            // btnTelnet
            // 
            this.btnTelnet.Location = new System.Drawing.Point(219, 357);
            this.btnTelnet.Name = "btnTelnet";
            this.btnTelnet.Size = new System.Drawing.Size(56, 24);
            this.btnTelnet.TabIndex = 180;
            this.btnTelnet.Text = "Telnet";
            this.btnTelnet.UseSelectable = true;
            this.btnTelnet.UseStyleColors = true;
            this.btnTelnet.Click += new System.EventHandler(this.btnTelnet_Click);
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd.Location = new System.Drawing.Point(13, 177);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(262, 174);
            this.RealPlayWnd.TabIndex = 179;
            this.RealPlayWnd.TabStop = false;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel17.Location = new System.Drawing.Point(136, 125);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(93, 20);
            this.metroLabel17.TabIndex = 178;
            this.metroLabel17.Text = "数据端口号：";
            this.metroLabel17.UseStyleColors = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(13, 125);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(64, 20);
            this.metroLabel18.TabIndex = 177;
            this.metroLabel18.Text = "IP地址：";
            this.metroLabel18.UseStyleColors = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(135, 55);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(51, 20);
            this.metroLabel19.TabIndex = 176;
            this.metroLabel19.Text = "密码：";
            this.metroLabel19.UseStyleColors = true;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(13, 55);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(65, 20);
            this.metroLabel20.TabIndex = 175;
            this.metroLabel20.Text = "登录名：";
            this.metroLabel20.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.ForeColor = System.Drawing.Color.Red;
            this.metroLabel15.Location = new System.Drawing.Point(58, 12);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(146, 32);
            this.metroLabel15.TabIndex = 157;
            this.metroLabel15.Text = "海康威视";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage7);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Controls.Add(this.metroTabPage6);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(893, 433);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // theme
            // 
            this.theme.ActiveControl = null;
            this.theme.BackColor = System.Drawing.SystemColors.Control;
            this.theme.Location = new System.Drawing.Point(338, 31);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(46, 23);
            this.theme.Style = MetroFramework.MetroColorStyle.Silver;
            this.theme.TabIndex = 1;
            this.theme.Text = "主题";
            this.theme.UseSelectable = true;
            this.theme.UseStyleColors = true;
            this.theme.Click += new System.EventHandler(this.theme_Click);
            // 
            // skin
            // 
            this.skin.ActiveControl = null;
            this.skin.Location = new System.Drawing.Point(392, 31);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(48, 23);
            this.skin.Style = MetroFramework.MetroColorStyle.Silver;
            this.skin.TabIndex = 2;
            this.skin.Text = "皮肤";
            this.skin.UseSelectable = true;
            this.skin.Click += new System.EventHandler(this.skin_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainFrm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(260, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(933, 511);
            this.Controls.Add(this.skin);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "设备调试精灵";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.metroTabPage7.ResumeLayout(false);
            this.metroPanel18.ResumeLayout(false);
            this.metroPanel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeOut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabPage6.ResumeLayout(false);
            this.metroPanel23.ResumeLayout(false);
            this.metroPanel25.ResumeLayout(false);
            this.metroPanel25.PerformLayout();
            this.metroPanel19.ResumeLayout(false);
            this.metroPanel17.ResumeLayout(false);
            this.metroPanel17.PerformLayout();
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage8.ResumeLayout(false);
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroTabPage9.ResumeLayout(false);
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            this.metroTabPage10.ResumeLayout(false);
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel8.PerformLayout();
            this.metroTabPage11.ResumeLayout(false);
            this.metroPanel9.ResumeLayout(false);
            this.metroPanel9.PerformLayout();
            this.metroTabPage12.ResumeLayout(false);
            this.metroPanel10.ResumeLayout(false);
            this.metroPanel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.metroTabPage13.ResumeLayout(false);
            this.metroPanel11.ResumeLayout(false);
            this.metroPanel11.PerformLayout();
            this.metroTabPage14.ResumeLayout(false);
            this.metroPanel12.ResumeLayout(false);
            this.metroPanel12.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroPanel16.ResumeLayout(false);
            this.metroPanel16.PerformLayout();
            this.metroPanel15.ResumeLayout(false);
            this.metroPanel15.PerformLayout();
            this.metroPanel14.ResumeLayout(false);
            this.metroPanel14.PerformLayout();
            this.metroPanel13.ResumeLayout(false);
            this.metroPanel13.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            this.HKWSPanel.ResumeLayout(false);
            this.HKWSPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel panel1;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel panel2;
        private MetroFramework.Controls.MetroComboBox cbSerialName;
        private MetroFramework.Controls.MetroComboBox cbBaudRate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroRadioButton rbtN;
        private MetroFramework.Controls.MetroRadioButton rbtS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroPanel HKWSPanel;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroCheckBox cbTimer;
        private MetroFramework.Controls.MetroButton btnSendTts;
        private MetroFramework.Controls.MetroTextBox txtInfo;
        private System.Windows.Forms.NumericUpDown txtTime;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel lblResult;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroTextBox txtMessage;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtNum;
        private MetroFramework.Controls.MetroTextBox txtPage;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox cbSendMethod;
        private MetroFramework.Controls.MetroComboBox cbCardType;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstReceiveData;
        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private MetroFramework.Controls.MetroTabPage metroTabPage9;
        private MetroFramework.Controls.MetroTabPage metroTabPage10;
        private MetroFramework.Controls.MetroTabPage metroTabPage11;
        private MetroFramework.Controls.MetroTabPage metroTabPage12;
        private MetroFramework.Controls.MetroTabPage metroTabPage13;
        private MetroFramework.Controls.MetroTabPage metroTabPage14;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOnOrOff20;
        private System.Windows.Forms.Button btnOnOrOff19;
        private System.Windows.Forms.ComboBox cbOnOrOff20;
        private System.Windows.Forms.ComboBox cbOnOrOff19;
        private System.Windows.Forms.Button btnOnOrOff18;
        private System.Windows.Forms.Button btnOnOrOff17;
        private System.Windows.Forms.Button btnOnOrOff16;
        private System.Windows.Forms.Button btnOnOrOff15;
        private System.Windows.Forms.Button btnOnOrOff13;
        private System.Windows.Forms.Button btnOnOrOff14;
        private System.Windows.Forms.Button btnOnOrOff12;
        private System.Windows.Forms.Button btnOnOrOff11;
        private System.Windows.Forms.ComboBox cbOnOrOff18;
        private System.Windows.Forms.ComboBox cbOnOrOff17;
        private System.Windows.Forms.ComboBox cbOnOrOff16;
        private System.Windows.Forms.ComboBox cbOnOrOff15;
        private System.Windows.Forms.ComboBox cbOnOrOff14;
        private System.Windows.Forms.ComboBox cbOnOrOff13;
        private System.Windows.Forms.ComboBox cbOnOrOff12;
        private System.Windows.Forms.ComboBox cbOnOrOff11;
        private System.Windows.Forms.Button btnOnOrOff10;
        private System.Windows.Forms.Button btnOnOrOff9;
        private System.Windows.Forms.ComboBox cbOnOrOff10;
        private System.Windows.Forms.ComboBox cbOnOrOff9;
        private System.Windows.Forms.Button btnOnOrOff8;
        private System.Windows.Forms.Button btnOnOrOff7;
        private System.Windows.Forms.Button btnOnOrOff6;
        private System.Windows.Forms.Button btnOnOrOff5;
        private System.Windows.Forms.Button btnOnOrOff3;
        private System.Windows.Forms.Button btnOnOrOff4;
        private System.Windows.Forms.Button btnOnOrOff2;
        private System.Windows.Forms.Button btnOnOrOff1;
        private System.Windows.Forms.ComboBox cbOnOrOff8;
        private System.Windows.Forms.ComboBox cbOnOrOff7;
        private System.Windows.Forms.ComboBox cbOnOrOff6;
        private System.Windows.Forms.ComboBox cbOnOrOff5;
        private System.Windows.Forms.ComboBox cbOnOrOff4;
        private System.Windows.Forms.ComboBox cbOnOrOff3;
        private System.Windows.Forms.ComboBox cbOnOrOff2;
        private System.Windows.Forms.ComboBox cbOnOrOff1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnCombination20;
        private System.Windows.Forms.ComboBox cbCombination20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCombination19;
        private System.Windows.Forms.ComboBox cbCombination19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCombination9;
        private System.Windows.Forms.ComboBox cbCombination9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCombination8;
        private System.Windows.Forms.ComboBox cbCombination8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCombination18;
        private System.Windows.Forms.ComboBox cbCombination18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCombination17;
        private System.Windows.Forms.ComboBox cbCombination17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCombination16;
        private System.Windows.Forms.ComboBox cbCombination16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCombination15;
        private System.Windows.Forms.ComboBox cbCombination15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnCombination14;
        private System.Windows.Forms.ComboBox cbCombination14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnCombination13;
        private System.Windows.Forms.ComboBox cbCombination13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnCombination12;
        private System.Windows.Forms.ComboBox cbCombination12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnCombination11;
        private System.Windows.Forms.ComboBox cbCombination11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnCombination10;
        private System.Windows.Forms.ComboBox cbCombination10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnCombination7;
        private System.Windows.Forms.ComboBox cbCombination7;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnCombination6;
        private System.Windows.Forms.ComboBox cbCombination6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnCombination5;
        private System.Windows.Forms.ComboBox cbCombination5;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btnCombination4;
        private System.Windows.Forms.ComboBox cbCombination4;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnCombination3;
        private System.Windows.Forms.ComboBox cbCombination3;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnCombination2;
        private System.Windows.Forms.ComboBox cbCombination2;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btnCombination1;
        private System.Windows.Forms.ComboBox cbCombination1;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnDelay20;
        private System.Windows.Forms.Button btnDelay19;
        private System.Windows.Forms.TextBox txtDelayTime20;
        private System.Windows.Forms.TextBox txtDelayTime19;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btnDelay18;
        private System.Windows.Forms.Button btnDelay17;
        private System.Windows.Forms.Button btnDelay16;
        private System.Windows.Forms.Button btnDelay15;
        private System.Windows.Forms.Button btnDelay13;
        private System.Windows.Forms.Button btnDelay14;
        private System.Windows.Forms.Button btnDelay12;
        private System.Windows.Forms.Button btnDelay11;
        private System.Windows.Forms.TextBox txtDelayTime18;
        private System.Windows.Forms.TextBox txtDelayTime17;
        private System.Windows.Forms.TextBox txtDelayTime16;
        private System.Windows.Forms.TextBox txtDelayTime15;
        private System.Windows.Forms.TextBox txtDelayTime14;
        private System.Windows.Forms.TextBox txtDelayTime12;
        private System.Windows.Forms.TextBox txtDelayTime11;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Button btnDelay10;
        private System.Windows.Forms.Button btnDelay9;
        private System.Windows.Forms.TextBox txtDelayTime10;
        private System.Windows.Forms.TextBox txtDelayTime9;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button btnMode20;
        private System.Windows.Forms.Button btnMode19;
        private System.Windows.Forms.ComboBox cbMode20;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox cbMode19;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button btnMode18;
        private System.Windows.Forms.Button btnMode17;
        private System.Windows.Forms.Button btnMode16;
        private System.Windows.Forms.Button btnMode15;
        private System.Windows.Forms.Button btnMode13;
        private System.Windows.Forms.Button btnMode14;
        private System.Windows.Forms.Button btnMode12;
        private System.Windows.Forms.Button btnMode11;
        private System.Windows.Forms.ComboBox cbMode18;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.ComboBox cbMode17;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox cbMode16;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox cbMode15;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox cbMode14;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox cbMode13;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.ComboBox cbMode12;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.ComboBox cbMode11;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Button btnMode10;
        private System.Windows.Forms.Button btnMode9;
        private System.Windows.Forms.ComboBox cbMode10;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ComboBox cbMode9;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Button btnDelay8;
        private System.Windows.Forms.Button btnDelay7;
        private System.Windows.Forms.Button btnDelay6;
        private System.Windows.Forms.Button btnDelay5;
        private System.Windows.Forms.Button btnDelay3;
        private System.Windows.Forms.Button btnDelay4;
        private System.Windows.Forms.Button btnDelay2;
        private System.Windows.Forms.Button btnDelay1;
        private System.Windows.Forms.Button btnMode8;
        private System.Windows.Forms.Button btnMode7;
        private System.Windows.Forms.Button btnMode6;
        private System.Windows.Forms.Button btnMode5;
        private System.Windows.Forms.Button btnMode3;
        private System.Windows.Forms.Button btnMode4;
        private System.Windows.Forms.Button btnMode2;
        private System.Windows.Forms.Button btnMode1;
        private System.Windows.Forms.TextBox txtDelayTime8;
        private System.Windows.Forms.TextBox txtDelayTime7;
        private System.Windows.Forms.TextBox txtDelayTime6;
        private System.Windows.Forms.TextBox txtDelayTime5;
        private System.Windows.Forms.TextBox txtDelayTime4;
        private System.Windows.Forms.TextBox txtDelayTime3;
        private System.Windows.Forms.TextBox txtDelayTime2;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox txtDelayTime1;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.ComboBox cbMode8;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.ComboBox cbMode7;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.ComboBox cbMode6;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.ComboBox cbMode5;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.ComboBox cbMode4;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.ComboBox cbMode3;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.ComboBox cbMode2;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.ComboBox cbMode1;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private MetroFramework.Controls.MetroPanel metroPanel9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnMarkAD8;
        private System.Windows.Forms.Button btnMarkAD7;
        private System.Windows.Forms.Button btnMarkAD6;
        private System.Windows.Forms.Button btnMarkAD5;
        private System.Windows.Forms.Button btnMarkAD4;
        private System.Windows.Forms.Button btnMarkAD3;
        private System.Windows.Forms.Button btnMarkAD2;
        private System.Windows.Forms.Button btnMarkAD1;
        private System.Windows.Forms.Button btnADExtent8;
        private System.Windows.Forms.ComboBox cbADExtent8;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Button btnADExtent7;
        private System.Windows.Forms.ComboBox cbADExtent7;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Button btnADExtent6;
        private System.Windows.Forms.ComboBox cbADExtent6;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Button btnADExtent5;
        private System.Windows.Forms.ComboBox cbADExtent5;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Button btnADExtent4;
        private System.Windows.Forms.ComboBox cbADExtent4;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Button btnADExtent3;
        private System.Windows.Forms.ComboBox cbADExtent3;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Button btnADExtent2;
        private System.Windows.Forms.ComboBox cbADExtent2;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Button btnADExtent1;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.ComboBox cbADExtent1;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox cbCurrentMax8;
        private System.Windows.Forms.ComboBox cbCurrentMax7;
        private System.Windows.Forms.ComboBox cbCurrentMax6;
        private System.Windows.Forms.ComboBox cbCurrentMax5;
        private System.Windows.Forms.ComboBox cbCurrentMax4;
        private System.Windows.Forms.ComboBox cbCurrentMax3;
        private System.Windows.Forms.ComboBox cbCurrentMax2;
        private System.Windows.Forms.Button btnCurrent8;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Button btnCurrent7;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Button btnCurrent6;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Button btnCurrent5;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Button btnCurrent4;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Button btnCurrent3;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Button btnCurrent2;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Button btnCurrent1;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.ComboBox cbCurrentMax1;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private MetroFramework.Controls.MetroPanel metroPanel10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbOff3;
        private System.Windows.Forms.RadioButton rbOn3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbOff2;
        private System.Windows.Forms.RadioButton rbOn2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rbOn1;
        private System.Windows.Forms.RadioButton rbOff1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rbOff4;
        private System.Windows.Forms.RadioButton rbOn4;
        private System.Windows.Forms.Button btnReadCount4;
        private System.Windows.Forms.Button btnReadCount3;
        private System.Windows.Forms.Button btnReadCount2;
        private System.Windows.Forms.Button btnReadCount1;
        private System.Windows.Forms.TextBox txtCount4;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox txtCount3;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TextBox txtCount2;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox txtCount1;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private MetroFramework.Controls.MetroPanel metroPanel11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private MetroFramework.Controls.MetroPanel metroPanel12;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.ComboBox comboBox23;
        private System.Windows.Forms.ComboBox comboBox24;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private MetroFramework.Controls.MetroPanel metroPanel13;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txtCo2PreAddress;
        private MetroFramework.Controls.MetroTextBox txtCo2FolAddress;
        private MetroFramework.Controls.MetroTextBox txtCo2FolBaudRate;
        private MetroFramework.Controls.MetroTextBox txtCo2PreBaudRate;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txtCo2Value;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroButton btnCo2;
        private MetroFramework.Controls.MetroComboBox cbCo2Function;
        private MetroFramework.Controls.MetroPanel metroPanel14;
        private MetroFramework.Controls.MetroComboBox cbPoisonFunction;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroButton btnPio;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroTextBox txtPioPreAddress;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroTextBox txtPioFolAddress;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroTextBox txtPioPreBaudRate;
        private MetroFramework.Controls.MetroLabel metroLabel31;
        private MetroFramework.Controls.MetroTextBox txtPioFolBaudRate;
        private MetroFramework.Controls.MetroTextBox txtPioValue;
        private MetroFramework.Controls.MetroPanel metroPanel15;
        private MetroFramework.Controls.MetroComboBox cbTempHumFuction;
        private MetroFramework.Controls.MetroLabel metroLabel32;
        private MetroFramework.Controls.MetroButton btnTempHum;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroLabel metroLabel34;
        private MetroFramework.Controls.MetroTextBox txtTempHumPreAddress;
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroTextBox txtTempHumFolAddress;
        private MetroFramework.Controls.MetroLabel metroLabel36;
        private MetroFramework.Controls.MetroTextBox txtTempHumPreBaudRate;
        private MetroFramework.Controls.MetroLabel metroLabel37;
        private MetroFramework.Controls.MetroTextBox txtTempHumFolBaudRate;
        private MetroFramework.Controls.MetroTextBox txtTempHumValue;
        private MetroFramework.Controls.MetroPanel metroPanel16;
        private MetroFramework.Controls.MetroComboBox cbWeaFunction;
        private MetroFramework.Controls.MetroLabel metroLabel38;
        private MetroFramework.Controls.MetroButton btnWea;
        private MetroFramework.Controls.MetroLabel metroLabel39;
        private MetroFramework.Controls.MetroLabel metroLabel40;
        private MetroFramework.Controls.MetroTextBox txtWeaPreAddress;
        private MetroFramework.Controls.MetroLabel metroLabel41;
        private MetroFramework.Controls.MetroTextBox txtWeaFolAddress;
        private MetroFramework.Controls.MetroLabel metroLabel42;
        private MetroFramework.Controls.MetroTextBox txtWeaPreBaudRate;
        private MetroFramework.Controls.MetroLabel metroLabel43;
        private MetroFramework.Controls.MetroTextBox txtWeaFolBaudRate;
        private MetroFramework.Controls.MetroTextBox txtWeaValue;
        private MetroFramework.Controls.MetroPanel metroPanel17;
        private MetroFramework.Controls.MetroComboBox cbReg;
        private MetroFramework.Controls.MetroLabel metroLabel44;
        private MetroFramework.Controls.MetroLabel metroLabel45;
        private MetroFramework.Controls.MetroTextBox txtCollectAddress;
        private MetroFramework.Controls.MetroLabel metroLabel49;
        private MetroFramework.Controls.MetroTextBox txtCollectValue;
        private MetroFramework.Controls.MetroLabel metroLabel46;
        private MetroFramework.Controls.MetroButton btnmAValue;
        private MetroFramework.Controls.MetroTile theme;
        private MetroFramework.Controls.MetroTile skin;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Controls.MetroPanel metroPanel18;
        private System.Windows.Forms.NumericUpDown txtTime1;
        private System.Windows.Forms.ListBox lstReturnCommand;
        private MetroFramework.Controls.MetroPanel metroPanel19;
        private MetroFramework.Controls.MetroPanel metroPanel20;
        private MetroFramework.Controls.MetroPanel metroPanel22;
        private MetroFramework.Controls.MetroPanel metroPanel21;
        private MetroFramework.Controls.MetroPanel metroPanel23;
        private MetroFramework.Controls.MetroPanel cacl;
        private MetroFramework.Controls.MetroPanel metroPanel25;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private MetroFramework.Controls.MetroTextBox txtEnd;
        private MetroFramework.Controls.MetroTextBox txtStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox3;
        private MetroFramework.Controls.MetroLabel metroLabel50;
        private MetroFramework.Controls.MetroLabel metroLabel48;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnSet;
        private System.Windows.Forms.NumericUpDown txtTimeOut;
        private MetroFramework.Controls.MetroLabel metroLabel51;
        private MetroFramework.Controls.MetroLabel metroLabel52;
        private MetroFramework.Controls.MetroLabel metroLabel56;
        private MetroFramework.Controls.MetroLabel metroLabel55;
        private MetroFramework.Controls.MetroLabel metroLabel54;
        private MetroFramework.Controls.MetroLabel metroLabel53;
        private MetroFramework.Controls.MetroTextBox txtCommand3;
        private MetroFramework.Controls.MetroTextBox txtCommand2;
        private MetroFramework.Controls.MetroTextBox txtCommand1;
        private MetroFramework.Controls.MetroButton btnParity1;
        private MetroFramework.Controls.MetroButton btnSend2;
        private MetroFramework.Controls.MetroButton btnSend3;
        private MetroFramework.Controls.MetroButton btnSend1;
        private MetroFramework.Controls.MetroButton btnParity2;
        private MetroFramework.Controls.MetroButton btnParity3;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnOpenLog;
        private System.Windows.Forms.CheckBox cbTimer1;
        private MetroFramework.Controls.MetroLabel metroLabel57;
        private MetroFramework.Controls.MetroLabel lblTtsMessage;
        private MetroFramework.Controls.MetroTextBox txtLedAddress;
        private MetroFramework.Controls.MetroLabel metroLabel58;
        private System.Windows.Forms.TextBox txtDelayTime13;
        private MetroFramework.Controls.MetroPanel seacherPanel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtDataport;
        private MetroFramework.Controls.MetroTextBox txtI;
        private MetroFramework.Controls.MetroTextBox txtLoginPwd;
        private MetroFramework.Controls.MetroTextBox txtLoginName;
        private MetroFramework.Controls.MetroToggle btnOn;
        private MetroFramework.Controls.MetroButton btnTelnet;
        private System.Windows.Forms.PictureBox RealPlayWnd;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.ComboBox comboBox17;
        private MetroFramework.Controls.MetroTextBox txtCmd;
        private System.Windows.Forms.Timer timer2;
    }
}