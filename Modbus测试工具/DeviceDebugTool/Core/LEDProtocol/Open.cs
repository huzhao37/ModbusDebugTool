using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceDebugTool.Core.LEDProtocol
{
    public class Open
    {
        public const UInt16 Command = (UInt16)SubCmdType.开机;
        public const Byte Response = 0x1B;

        /// <summary>
        /// 485地址
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public Byte[] GetBytes(byte addr = 1)
        {
            var list = new List<byte> { 0xAA, addr, 0xBB };
            //功能码
            if (Command > 0xFF)
            {
                list.Add(Convert.ToByte(Command >> 8));
            }
            list.Add(Convert.ToByte(Command & 0xFF));

            return list.ToArray();
        }
    }
}
