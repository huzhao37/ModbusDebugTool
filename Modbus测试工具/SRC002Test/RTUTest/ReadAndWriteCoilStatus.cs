using ModbusDebugTool.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusDebugTool
{
    public partial class ReadAndWriteCoilStatus : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public ReadAndWriteCoilStatus()
        {
            InitializeComponent();
            
        }

        #region 写线圈状态
        private void btnOnOrOff1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0000", this.cbOnOrOff1.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff2_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0001", this.cbOnOrOff2.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0002", this.cbOnOrOff3.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff4_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0003", this.cbOnOrOff4.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0004", this.cbOnOrOff5.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0005", this.cbOnOrOff6.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0006", this.cbOnOrOff7.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0007", this.cbOnOrOff8.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff9_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0008", this.cbOnOrOff9.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff10_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0009", this.cbOnOrOff10.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff11_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000A", this.cbOnOrOff11.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff12_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000B", this.cbOnOrOff12.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff13_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000C", this.cbOnOrOff13.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff14_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000D", this.cbOnOrOff14.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff15_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000E", this.cbOnOrOff15.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff16_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000F", this.cbOnOrOff16.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff17_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0010", this.cbOnOrOff17.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff18_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0011", this.cbOnOrOff18.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff19_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0012", this.cbOnOrOff19.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff20_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0013", this.cbOnOrOff20.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        #endregion
        private void ReadAndWriteCoilStatus_Load(object sender, EventArgs e)
        {
            var list = new[]{ 
                new {
                    SelectedText = "断开",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "闭合",
                    SelectedValue="FF00"
                }
            };
            //绑定自定义数据源
            cbOnOrOff1.DataSource = list.Clone();//防止一个改变时，其他也跟着变化
            cbOnOrOff1.DisplayMember = "SelectedText";
            cbOnOrOff1.ValueMember = "SelectedValue";
            cbOnOrOff2.DataSource = list.Clone();
            cbOnOrOff2.DisplayMember = "SelectedText";
            cbOnOrOff2.ValueMember = "SelectedValue";
            cbOnOrOff3.DataSource = list.Clone();
            cbOnOrOff3.DisplayMember = "SelectedText";
            cbOnOrOff3.ValueMember = "SelectedValue";
            cbOnOrOff4.DataSource = list.Clone();
            cbOnOrOff4.DisplayMember = "SelectedText";
            cbOnOrOff4.ValueMember = "SelectedValue";
            cbOnOrOff5.DataSource = list.Clone();
            cbOnOrOff5.DisplayMember = "SelectedText";
            cbOnOrOff5.ValueMember = "SelectedValue";
            cbOnOrOff6.DataSource = list.Clone();
            cbOnOrOff6.DisplayMember = "SelectedText";
            cbOnOrOff6.ValueMember = "SelectedValue";
            cbOnOrOff7.DataSource = list.Clone();
            cbOnOrOff7.DisplayMember = "SelectedText";
            cbOnOrOff7.ValueMember = "SelectedValue";
            cbOnOrOff8.DataSource = list.Clone();
            cbOnOrOff8.DisplayMember = "SelectedText";
            cbOnOrOff8.ValueMember = "SelectedValue";
            cbOnOrOff9.DataSource = list.Clone();
            cbOnOrOff9.DisplayMember = "SelectedText";
            cbOnOrOff9.ValueMember = "SelectedValue";
            cbOnOrOff10.DataSource = list.Clone();
            cbOnOrOff10.DisplayMember = "SelectedText";
            cbOnOrOff10.ValueMember = "SelectedValue";
            cbOnOrOff11.DataSource = list.Clone();
            cbOnOrOff11.DisplayMember = "SelectedText";
            cbOnOrOff11.ValueMember = "SelectedValue";
            cbOnOrOff12.DataSource = list.Clone();
            cbOnOrOff12.DisplayMember = "SelectedText";
            cbOnOrOff12.ValueMember = "SelectedValue";
            cbOnOrOff13.DataSource = list.Clone();
            cbOnOrOff13.DisplayMember = "SelectedText";
            cbOnOrOff13.ValueMember = "SelectedValue";
            cbOnOrOff14.DataSource = list.Clone();
            cbOnOrOff14.DisplayMember = "SelectedText";
            cbOnOrOff14.ValueMember = "SelectedValue";
            cbOnOrOff15.DataSource = list.Clone();
            cbOnOrOff15.DisplayMember = "SelectedText";
            cbOnOrOff15.ValueMember = "SelectedValue";
            cbOnOrOff16.DataSource = list.Clone();
            cbOnOrOff16.DisplayMember = "SelectedText";
            cbOnOrOff16.ValueMember = "SelectedValue";
            cbOnOrOff17.DataSource = list.Clone();
            cbOnOrOff17.DisplayMember = "SelectedText";
            cbOnOrOff17.ValueMember = "SelectedValue";
            cbOnOrOff18.DataSource = list.Clone();
            cbOnOrOff18.DisplayMember = "SelectedText";
            cbOnOrOff18.ValueMember = "SelectedValue";
            cbOnOrOff19.DataSource = list.Clone();
            cbOnOrOff19.DisplayMember = "SelectedText";
            cbOnOrOff19.ValueMember = "SelectedValue";
            cbOnOrOff20.DataSource = list.Clone();
            cbOnOrOff20.DisplayMember = "SelectedText";
            cbOnOrOff20.ValueMember = "SelectedValue";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] onOrOffChar = new string[20];//存放线圈状态的字符数组
            //高低位反过来
            onOrOffChar[7] = cbOnOrOff1.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[6] = cbOnOrOff2.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[5] = cbOnOrOff3.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[4] = cbOnOrOff4.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[3] = cbOnOrOff5.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[2] = cbOnOrOff6.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[1] = cbOnOrOff7.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[0] = cbOnOrOff8.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[15] = cbOnOrOff9.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[14] = cbOnOrOff10.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[13] = cbOnOrOff11.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[12] = cbOnOrOff12.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[11] = cbOnOrOff13.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[10] = cbOnOrOff14.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[9] = cbOnOrOff15.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[8] = cbOnOrOff16.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[19] = cbOnOrOff17.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[18] = cbOnOrOff18.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[17] = cbOnOrOff19.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[16] = cbOnOrOff20.SelectedValue.ToString().Substring(0, 1);
            for (int i = 0; i < 20; i++)
            {
                if (onOrOffChar[i] == "F")
                {
                    onOrOffChar[i] = "1";
                }
                else
                {
                    onOrOffChar[i] = "0";
                }
            }
            string str1 = onOrOffChar[0] + onOrOffChar[1] + onOrOffChar[2] + onOrOffChar[3];
            string str2 = onOrOffChar[4] + onOrOffChar[5] + onOrOffChar[6] + onOrOffChar[7];
            string str3 = onOrOffChar[8] + onOrOffChar[9] + onOrOffChar[10] + onOrOffChar[11];
            string str4 = onOrOffChar[12] + onOrOffChar[13] + onOrOffChar[14] + onOrOffChar[15];
            string str5 = onOrOffChar[16] + onOrOffChar[17] + onOrOffChar[18] + onOrOffChar[19];

            string statusStr = string.Format("{0:x}", Convert.ToInt32(str1, 2)) + string.Format("{0:x}", Convert.ToInt32(str2, 2)) + string.Format("{0:x}", Convert.ToInt32(str3, 2)) + string.Format("{0:x}", Convert.ToInt32(str4, 2)) + string.Format("{0:x}", "0" + Convert.ToInt32(str5, 2));
            modbus.Communication(BaseConfig._deviceAddress, "0F", "0000", "001403" + statusStr);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                modbus.Communication(BaseConfig._deviceAddress, "01", "0000", "0014");
                if (modbus.RecvDeal() != null)
                {


                    string statusStr = modbus.RecvDeal();
                    string statusStr1 = statusStr.Substring(0, 1);
                    string statusStr2 = statusStr.Substring(1, 1);
                    string statusStr3 = statusStr.Substring(2, 1);
                    string statusStr4 = statusStr.Substring(3, 1);
                    string statusStr5 = statusStr.Substring(5, 1);
                    string status1 = Convert.ToString(Int32.Parse(statusStr1, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status2 = Convert.ToString(Int32.Parse(statusStr2, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status3 = Convert.ToString(Int32.Parse(statusStr3, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status4 = Convert.ToString(Int32.Parse(statusStr4, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status5 = Convert.ToString(Int32.Parse(statusStr5, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制

                    string[] coilChar = new string[20];//存放线圈状态的字符数组
                    //判断status1的情况
                    if (status1.Length == 1)
                    {
                        status1 = "000" + status1;
                    }
                    if (status1.Length == 2)
                    {
                        status1 = "00" + status1;
                    }
                    if (status1.Length == 3)
                    {
                        status1 = "0" + status1;
                    }

                    //判断status2的情况
                    if (status2.Length == 1)
                    {
                        status2 = "000" + status2;
                    }
                    if (status2.Length == 2)
                    {
                        status2 = "00" + status2;
                    }
                    if (status2.Length == 3)
                    {
                        status2 = "0" + status2;
                    }

                    //判断status3的情况
                    if (status3.Length == 1)
                    {
                        status3 = "000" + status3;
                    }
                    if (status3.Length == 2)
                    {
                        status3 = "00" + status3;
                    }
                    if (status3.Length == 3)
                    {
                        status3 = "0" + status3;
                    }

                    //判断status4的情况
                    if (status4.Length == 1)
                    {
                        status4 = "000" + status4;
                    }
                    if (status4.Length == 2)
                    {
                        status4 = "00" + status4;
                    }
                    if (status4.Length == 3)
                    {
                        status4 = "0" + status4;
                    }

                    //判断status5的情况
                    if (status5.Length == 1)
                    {
                        status5 = "000" + status5;
                    }
                    if (status5.Length == 2)
                    {
                        status5 = "00" + status5;
                    }
                    if (status5.Length == 3)
                    {
                        status5 = "0" + status5;
                    }

                    string status = status1 + status2 + status3 + status4 + status5;//存放线圈状态的字符串
                    for (int i = 0; i < status.Length; i++)
                    {
                        coilChar[i] = status.Substring(i, 1);
                        if (coilChar[i].Equals("1"))
                        {
                            coilChar[i] = "FF";
                        }
                        else
                        {
                            coilChar[i] = "00";
                        }
                    }
                    cbOnOrOff1.SelectedValue = coilChar[7] + "00";
                    cbOnOrOff2.SelectedValue = coilChar[6] + "00";
                    cbOnOrOff3.SelectedValue = coilChar[5] + "00";
                    cbOnOrOff4.SelectedValue = coilChar[4] + "00";
                    cbOnOrOff5.SelectedValue = coilChar[3] + "00";
                    cbOnOrOff6.SelectedValue = coilChar[2] + "00";
                    cbOnOrOff7.SelectedValue = coilChar[1] + "00";
                    cbOnOrOff8.SelectedValue = coilChar[0] + "00";
                    cbOnOrOff9.SelectedValue = coilChar[15] + "00";
                    cbOnOrOff10.SelectedValue = coilChar[14] + "00";
                    cbOnOrOff11.SelectedValue = coilChar[13] + "00";
                    cbOnOrOff12.SelectedValue = coilChar[12] + "00";
                    cbOnOrOff13.SelectedValue = coilChar[11] + "00";
                    cbOnOrOff14.SelectedValue = coilChar[10] + "00";
                    cbOnOrOff15.SelectedValue = coilChar[9] + "00";
                    cbOnOrOff16.SelectedValue = coilChar[8] + "00";
                    cbOnOrOff17.SelectedValue = coilChar[19] + "00";
                    cbOnOrOff18.SelectedValue = coilChar[18] + "00";
                    cbOnOrOff19.SelectedValue = coilChar[17] + "00";
                    cbOnOrOff20.SelectedValue = coilChar[16] + "00";
                }
                else
                {
                    //MessageBox.Show("通讯异常！"); 
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("通讯异常！");
            }
        }
    }
}
