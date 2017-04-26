using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceDebugTool.Core.LEDProtocol
{
   public class Helper
    {
        public static byte Xor(Byte[] bytes)
        {
            // xorResult 存放校验结果。注意：初值去首元素值！
            int xorResult = bytes[0];
            // 求xor校验和。注意：XOR运算从第二元素开始
            for (int i = 1; i < bytes.Length; i++)
            {
                xorResult ^= bytes[i];
            }

            return (byte) xorResult;
        }
    }
}
