using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceDebugTool.Core
{
    public class Log
    {
        public static void WriteLog(string param1, string param2)
        {
            String path = @"..\Debug\log.txt";
            System.IO.File.AppendAllText(path, string.Format("\r\n{0}\t{1}\t{2}", DateTime.Now, param1, param2),
             Encoding.Default);// 用制表符 \t 分隔字段
        }
    }
}
