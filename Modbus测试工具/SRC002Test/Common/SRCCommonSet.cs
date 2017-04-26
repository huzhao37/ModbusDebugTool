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
    public partial class SRCCommonSet : Form
    {
        public SRCCommonSet()
        {
            InitializeComponent();
        }
        private void SRCCommonSet_Load(object sender, EventArgs e)
        {
            BaseConfig._deviceAddress= this.cbDeviceAddress.SelectedItem.ToString();
            //modbus.Communication(BaseConfig._deviceAddress, "06", "0000", "000" + this.cbBaudRate.SelectedIndex); //设置波特率
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (BaseConfig._recvData != null)
            {
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
            if (int.TryParse(this.txtTimeX.Text,out a))
            {
                BaseConfig.timer = Convert.ToInt32(this.txtTimeX.Text);
            }
            else
            {
                MessageBox.Show("输入的时间有误!输入整数！");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Timers.Timer t = new System.Timers.Timer(Convert.ToDouble(this.txtTimeX.Text));
            ////实例化Timer类，设置间隔时间为10000毫秒；   
            //t.Elapsed += new System.Timers.ElapsedEventHandler(e);
            ////到达时间的时候执行事件；    
            //t.AutoReset = true;
            ////设置是执行一次（false）还是一直执行(true)；    
            //t.Enabled = true;
            ////是否执行System.Timers.Timer.Elapsed事件；  
        }
    }
}
