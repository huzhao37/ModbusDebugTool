// -----------------------------------------------------------------------
// <copyright file="PingHelper.cs" company="南京瀚之显电子科技有限公司">
// PingHelper
// </copyright>
// -----------------------------------------------------------------------

namespace ModbusDebugTool.Core
{
    using System.Net.NetworkInformation;
    using System.Text;

    /// <summary>
    /// PingHelper
    /// </summary>
    public class PingHelper
    { 
        /// <summary>
        /// 测试网络是否能Ping通
        /// </summary>
        /// <param name="ipaddress">IP地址</param>
        /// <returns></returns>
        public static bool PingIpIsConnection(string ipaddress)
        {
            Ping pingSender = new Ping();
            PingOptions pingOption = new PingOptions();
            pingOption.DontFragment = true;
            const string Data = "sendData:testtesttest";
            byte[] buffer = Encoding.ASCII.GetBytes(Data);
            const int Timeout = 3000;
            PingReply reply = pingSender.Send(ipaddress, Timeout, buffer);
            if (reply == null)
            {
                return false;
            }

            if (reply.Status == IPStatus.Success)
            {
                return true;
            }

            return false;
            //return true;
        }
    }
}
