#region Code File Comment
// SOLUTION   ： AWIOT
// PROJECT    ： AWIOT.IOTClient.Core
// FILENAME   ： TransportFactory.cs
// AUTHOR     ： soft-cq
// CREATE TIME： 2015-07-27 23:22
// COPYRIGHT  ： 版权所有 (C) 安徽斯玛特物联网科技有限公司 http://www.smartah.cc/ 2011~2015
#endregion

using System;
using System.Dynamic;
using NewLife.Net;
using NewLife.Reflection;

namespace ModbusDebugTool.Core
{
    public class TransportFactory
    {
        public static ITransport CreateTransport(dynamic args, TransportEnum type = TransportEnum.Tcp)
        {
            if (type == TransportEnum.Rs232)
            {
                return new SerialTransport { PortName = args.Args1, BaudRate = args.Args2 };
            }
            else if (type == TransportEnum.Tcp || type == TransportEnum.Udp)
            {
                var session = NetService.CreateSession(
                        new NetUri(string.Format("{0}://{1}:{2}", type.ToString(), NetHelper.ParseAddress(args.Args1 + ""),
                            args.Args2)));
                return session as ITransport;
            }
            return null;
        }
    }
}