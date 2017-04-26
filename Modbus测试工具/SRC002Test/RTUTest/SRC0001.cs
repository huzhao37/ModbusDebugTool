using NewLife.Net;
using NewLife.Threading;
using ModbusDebugTool.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusDebugTool
{
    public partial class SRC0001 : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public SRC0001()
        {
            InitializeComponent();
            // Opacity属性设立窗体的透明程度，只对于视窗2000有效
            //this.Opacity = 0.61;
            ////this.BackColor = System.Drawing.Color.White;
            //// 定义背景色为蓝色
            //this.ForeColor = System.Drawing.SystemColors.Desktop;
            //以桌面的前景色作为窗体的前景色
           
        }

        #region 工作模式设置
        private void btnMode1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0001", this.cbMode1.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void btnMode2_Click(object sender, EventArgs e)
        {

            modbus.Communication(BaseConfig._deviceAddress, "06", "0002",  this.cbMode2.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0003", this.cbMode3.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode4_Click(object sender, EventArgs e)
        {

            modbus.Communication(BaseConfig._deviceAddress, "06", "0004", this.cbMode4.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0005", this.cbMode5.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0006", this.cbMode6.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0007", this.cbMode7.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0008", this.cbMode8.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void btnMode9_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0009", this.cbMode9.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode10_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000A", this.cbMode10.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode11_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000B", this.cbMode11.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode12_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000C", this.cbMode12.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode13_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000D", this.cbMode13.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode14_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000E", this.cbMode14.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode15_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000F", this.cbMode15.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode16_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0010", this.cbMode16.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode17_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0011", this.cbMode17.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode18_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0012",this.cbMode18.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode19_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0013", this.cbMode19.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode20_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0014", this.cbMode20.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        #endregion

        #region 设置延迟时间
        private void btnDelay1_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime1.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "0009", "00" +Convert.ToInt32( this.txtDelayTime1.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay2_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime2.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000A", "00" + Convert.ToInt32(this.txtDelayTime2.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay3_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime3.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000B",  "00" + Convert.ToInt32(this.txtDelayTime3.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay4_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime4.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000C", "00" + Convert.ToInt32(this.txtDelayTime4.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay5_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime5.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000D", "00" + Convert.ToInt32(this.txtDelayTime5.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay6_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime6.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000E", "00" + Convert.ToInt32(this.txtDelayTime6.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay7_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime7.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000F", "00" + Convert.ToInt32(this.txtDelayTime7.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay8_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime8.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0010", "00" + Convert.ToInt32(this.txtDelayTime8.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }
        private void btnDelay9_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime9.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0011", "00" + Convert.ToInt32(this.txtDelayTime9.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay10_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime10.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0012", "00" + Convert.ToInt32(this.txtDelayTime10.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay11_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime11.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0013", "00" + Convert.ToInt32(this.txtDelayTime11.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay12_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime12.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0014", "00" + Convert.ToInt32(this.txtDelayTime12.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay13_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime13.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0015", "00" + Convert.ToInt32(this.txtDelayTime13.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay14_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime14.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0016", "00" + Convert.ToInt32(this.txtDelayTime14.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay15_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime15.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0017", "00" + Convert.ToInt32(this.txtDelayTime15.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay16_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime16.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0018", "00" + Convert.ToInt32(this.txtDelayTime16.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay17_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime17.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0019", "00" + Convert.ToInt32(this.txtDelayTime17.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay18_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime18.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "001A", "00" + Convert.ToInt32(this.txtDelayTime18.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay19_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime19.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "001B", "00" + Convert.ToInt32(this.txtDelayTime19.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay20_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime20.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "001C", "00" + Convert.ToInt32(this.txtDelayTime20.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }
        #endregion

        private void SRC0001_Load(object sender, EventArgs e)
        {

            var list = new[]{ 
                new {
                    SelectedText = "保持",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "延迟",
                    SelectedValue="0001"
                },
                new {
                    SelectedText = "组合",
                    SelectedValue="0002"
                }
            };
            //绑定数据源
            cbMode1.DataSource = list.Clone();//防止一个改变时，其他也跟着变化
            cbMode1.DisplayMember = "SelectedText";
            cbMode1.ValueMember = "SelectedValue";
            cbMode2.DataSource = list.Clone();
            cbMode2.DisplayMember = "SelectedText";
            cbMode2.ValueMember = "SelectedValue";
            cbMode3.DataSource = list.Clone();
            cbMode3.DisplayMember = "SelectedText";
            cbMode3.ValueMember = "SelectedValue";
            cbMode4.DataSource = list.Clone();
            cbMode4.DisplayMember = "SelectedText";
            cbMode4.ValueMember = "SelectedValue";
            cbMode5.DataSource = list.Clone();
            cbMode5.DisplayMember = "SelectedText";
            cbMode5.ValueMember = "SelectedValue";
            cbMode6.DataSource = list.Clone();
            cbMode6.DisplayMember = "SelectedText";
            cbMode6.ValueMember = "SelectedValue";
            cbMode7.DataSource = list.Clone();
            cbMode7.DisplayMember = "SelectedText";
            cbMode7.ValueMember = "SelectedValue";
            cbMode8.DataSource = list.Clone();
            cbMode8.DisplayMember = "SelectedText";
            cbMode8.ValueMember = "SelectedValue";
            cbMode9.DataSource = list.Clone();
            cbMode9.DisplayMember = "SelectedText";
            cbMode9.ValueMember = "SelectedValue";
            cbMode10.DataSource = list.Clone();
            cbMode10.DisplayMember = "SelectedText";
            cbMode10.ValueMember = "SelectedValue";
            cbMode11.DataSource = list.Clone();
            cbMode11.DisplayMember = "SelectedText";
            cbMode11.ValueMember = "SelectedValue";
            cbMode12.DataSource = list.Clone();
            cbMode12.DisplayMember = "SelectedText";
            cbMode12.ValueMember = "SelectedValue";
            cbMode13.DataSource = list.Clone();
            cbMode13.DisplayMember = "SelectedText";
            cbMode13.ValueMember = "SelectedValue";
            cbMode14.DataSource = list.Clone();
            cbMode14.DisplayMember = "SelectedText";
            cbMode14.ValueMember = "SelectedValue";
            cbMode15.DataSource = list.Clone();
            cbMode15.DisplayMember = "SelectedText";
            cbMode15.ValueMember = "SelectedValue";
            cbMode16.DataSource = list.Clone();
            cbMode16.DisplayMember = "SelectedText";
            cbMode16.ValueMember = "SelectedValue";
            cbMode17.DataSource = list.Clone();
            cbMode17.DisplayMember = "SelectedText";
            cbMode17.ValueMember = "SelectedValue";
            cbMode18.DataSource = list.Clone();
            cbMode18.DisplayMember = "SelectedText";
            cbMode18.ValueMember = "SelectedValue";
            cbMode19.DataSource = list.Clone();
            cbMode19.DisplayMember = "SelectedText";
            cbMode19.ValueMember = "SelectedValue";
            cbMode20.DataSource = list.Clone();
            cbMode20.DisplayMember = "SelectedText";
            cbMode20.ValueMember = "SelectedValue";
          
        }

        private void label13_Click(object sender, EventArgs e)
        {
            SRC0001Combination sRC0001Combination = new SRC0001Combination();
            sRC0001Combination.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] modeChar = new string[20];//存放工作模式的字符数组
                string[] delayChar = new string[20];//存放ad状态的字符数组       
                //工作模式
                modeChar[0] = cbMode1.SelectedValue.ToString();
                modeChar[1] = cbMode2.SelectedValue.ToString();
                modeChar[2] = cbMode3.SelectedValue.ToString();
                modeChar[3] = cbMode4.SelectedValue.ToString();
                modeChar[4] = cbMode5.SelectedValue.ToString();
                modeChar[5] = cbMode6.SelectedValue.ToString();
                modeChar[6] = cbMode7.SelectedValue.ToString();
                modeChar[7] = cbMode8.SelectedValue.ToString();
                modeChar[8] = cbMode9.SelectedValue.ToString();
                modeChar[9] = cbMode10.SelectedValue.ToString();
                modeChar[10] = cbMode11.SelectedValue.ToString();
                modeChar[11] = cbMode12.SelectedValue.ToString();
                modeChar[12] = cbMode13.SelectedValue.ToString();
                modeChar[13] = cbMode14.SelectedValue.ToString();
                modeChar[14] = cbMode15.SelectedValue.ToString();
                modeChar[15] = cbMode16.SelectedValue.ToString();
                modeChar[16] = cbMode17.SelectedValue.ToString();
                modeChar[17] = cbMode18.SelectedValue.ToString();
                modeChar[18] = cbMode19.SelectedValue.ToString();
                modeChar[19] = cbMode20.SelectedValue.ToString();

                //延迟时间
                delayChar[0] = "00" + Convert.ToInt32(txtDelayTime1.Text).ToString("X2");//十进制转十六进制
                delayChar[1] = "00" + Convert.ToInt32(txtDelayTime2.Text).ToString("X2");
                delayChar[2] = "00" + Convert.ToInt32(txtDelayTime3.Text).ToString("X2");
                delayChar[3] = "00" + Convert.ToInt32(txtDelayTime4.Text).ToString("X2");
                delayChar[4] = "00" + Convert.ToInt32(txtDelayTime5.Text).ToString("X2");
                delayChar[5] = "00" + Convert.ToInt32(txtDelayTime6.Text).ToString("X2");
                delayChar[6] = "00" + Convert.ToInt32(txtDelayTime7.Text).ToString("X2");
                delayChar[7] = "00" + Convert.ToInt32(txtDelayTime8.Text).ToString("X2");
                delayChar[8] = "00" + Convert.ToInt32(txtDelayTime9.Text).ToString("X2");
                delayChar[9] = "00" + Convert.ToInt32(txtDelayTime10.Text).ToString("X2");
                delayChar[10] = "00" + Convert.ToInt32(txtDelayTime11.Text).ToString("X2");
                delayChar[11] = "00" + Convert.ToInt32(txtDelayTime12.Text).ToString("X2");
                delayChar[12] = "00" + Convert.ToInt32(txtDelayTime13.Text).ToString("X2");
                delayChar[13] = "00" + Convert.ToInt32(txtDelayTime14.Text).ToString("X2");
                delayChar[14] = "00" + Convert.ToInt32(txtDelayTime15.Text).ToString("X2");
                delayChar[15] = "00" + Convert.ToInt32(txtDelayTime16.Text).ToString("X2");
                delayChar[16] = "00" + Convert.ToInt32(txtDelayTime17.Text).ToString("X2");
                delayChar[17] = "00" + Convert.ToInt32(txtDelayTime18.Text).ToString("X2");
                delayChar[18] = "00" + Convert.ToInt32(txtDelayTime19.Text).ToString("X2");
                delayChar[19] = "00" + Convert.ToInt32(txtDelayTime20.Text).ToString("X2");

                string statusStr = String.Join("", modeChar) + String.Join("", delayChar);

                modbus.Communication(BaseConfig._deviceAddress, "10", "0001", "0028" + "50" + statusStr);


            }
            catch (Exception ex) { 
                //MessageBox.Show("通讯异常！");
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "03", "0001", "003C");
            if (modbus.RecvDeal() != null)
            {
                string statusStr = modbus.RecvDeal();
                string modeStatus = statusStr.Substring(0, 80);
                string delayStatus = statusStr.Substring(80, 80);
                string[] modeChar = new string[20];//存放电流状态的字符数组
                string[] delayChar = new string[20];//存放ad状态的字符数组
                for (int i = 0; i < modeStatus.Length / 4; i++)
                {
                    modeChar[i] = modeStatus.Substring(i * 4, 4);
                }
                for (int i = 0; i < delayStatus.Length / 4; i++)
                {
                    delayChar[i] = delayStatus.Substring(i * 4, 4);
                }
                cbMode1.SelectedValue = modeChar[0];
                cbMode2.SelectedValue = modeChar[1];
                cbMode3.SelectedValue = modeChar[2];
                cbMode4.SelectedValue = modeChar[3];
                cbMode5.SelectedValue = modeChar[4];
                cbMode6.SelectedValue = modeChar[5];
                cbMode7.SelectedValue = modeChar[6];
                cbMode8.SelectedValue = modeChar[7];
                cbMode9.SelectedValue = modeChar[8];
                cbMode10.SelectedValue = modeChar[9];
                cbMode11.SelectedValue = modeChar[10];
                cbMode12.SelectedValue = modeChar[11];
                cbMode13.SelectedValue = modeChar[12];
                cbMode14.SelectedValue = modeChar[13];
                cbMode15.SelectedValue = modeChar[14];
                cbMode16.SelectedValue = modeChar[15];
                cbMode17.SelectedValue = modeChar[16];
                cbMode18.SelectedValue = modeChar[17];
                cbMode19.SelectedValue = modeChar[18];
                cbMode20.SelectedValue = modeChar[19];

                txtDelayTime1.Text = Int32.Parse(delayChar[0].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime2.Text = Int32.Parse(delayChar[1].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime3.Text = Int32.Parse(delayChar[2].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime4.Text = Int32.Parse(delayChar[3].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime5.Text = Int32.Parse(delayChar[4].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime6.Text = Int32.Parse(delayChar[5].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime7.Text = Int32.Parse(delayChar[6].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime8.Text = Int32.Parse(delayChar[7].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime9.Text = Int32.Parse(delayChar[8].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime10.Text = Int32.Parse(delayChar[9].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime11.Text = Int32.Parse(delayChar[10].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime12.Text = Int32.Parse(delayChar[11].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime13.Text = Int32.Parse(delayChar[12].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime14.Text = Int32.Parse(delayChar[13].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime15.Text = Int32.Parse(delayChar[14].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime16.Text = Int32.Parse(delayChar[15].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime17.Text = Int32.Parse(delayChar[16].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime18.Text = Int32.Parse(delayChar[17].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime19.Text = Int32.Parse(delayChar[18].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime20.Text = Int32.Parse(delayChar[19].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();


            }
            else
            {
                //MessageBox.Show("通讯异常！");
            }
        }

    }
}
