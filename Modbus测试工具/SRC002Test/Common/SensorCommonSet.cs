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
    public partial class SensorCommonSet : Form
    {
        public SensorCommonSet()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (BaseConfig._recvData != null)
            {
                //foreach(var item in BaseConfig._receive)
                //{
                //    this.lstReceiveData.Items.Add(item);
                //}
                //this.lstReceiveData.Items.Add(BaseConfig._receive[BaseConfig._receive.l]);
                this.lstReceiveData.Items.Add(BaseConfig._recvData);
            }          
            else
            {
                //MessageBox.Show("通讯异常！");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lstReceiveData.Items.Clear();
        }

        private void txtTimeX_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            if (int.TryParse(this.txtTimeX.Text, out a))
            {
                BaseConfig.timer = Convert.ToInt32(this.txtTimeX.Text);
            }
            else
            {
                MessageBox.Show("输入的时间有误!输入整数！");
            }
        }
    }
}
