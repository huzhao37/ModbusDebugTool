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
    public partial class ReadAndWriteCoilStatus0002 : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public ReadAndWriteCoilStatus0002()
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
        #endregion


        /// <summary>
        /// 设置所有线圈的当前状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] onOrOffChar = new string[8];//存放线圈状态的字符数组
            //高低位反过来
            onOrOffChar[7] = cbOnOrOff1.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[6] = cbOnOrOff2.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[5] = cbOnOrOff3.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[4] = cbOnOrOff4.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[3] = cbOnOrOff5.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[2] = cbOnOrOff6.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[1] = cbOnOrOff7.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[0] = cbOnOrOff8.SelectedValue.ToString().Substring(0, 2);
            for (int i = 0; i < 8; i++)
            {
                if (onOrOffChar[i] =="FF")
                {
                   onOrOffChar[i]="1" ;
                }
                else
                {
                    onOrOffChar[i] = "0";
                }
            }
            string str1=onOrOffChar[0]+onOrOffChar[1]+onOrOffChar[2]+onOrOffChar[3];
            string str2=onOrOffChar[4]+onOrOffChar[5]+onOrOffChar[6]+onOrOffChar[7];

           
            string statusStr = string.Format("{0:x}",Convert.ToInt32(str1,2))+ string.Format("{0:x}",Convert.ToInt32(str2,2));
            modbus.Communication(BaseConfig._deviceAddress, "0F", "0000", "000801" + statusStr);
        }

        private void ReadAndWriteCoilStatus0002_Load(object sender, EventArgs e)
        {
            
        }

        private void ReadAndWriteCoilStatus0002_Load_1(object sender, EventArgs e)
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
          
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            ///获取所有线圈状态
            try
            {
                modbus.Communication(BaseConfig._deviceAddress, "01", "0000", "0008"); if (modbus.RecvDeal() != null)
                {
                    string statusStr = modbus.RecvDeal();
                    string statusStr1 = statusStr.Substring(0, 1);
                    string statusStr2 = statusStr.Substring(1, 1);
                    string status1 = Convert.ToString(Int32.Parse(statusStr1, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status2 = Convert.ToString(Int32.Parse(statusStr2, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制

                    string[] coilChar = new string[8];//存放线圈状态的字符数组
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

                    string status = status1 + status2;//存放线圈状态的字符串

                    string[] coilStatus = new string[8];
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
