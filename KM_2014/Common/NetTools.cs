using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Common
{
    public static class NetTools
    {
        public static bool Ping(String address, int timeout = 2000)
        {
            if (address == String.Empty) throw new ArgumentException("Ping 地址为空！");

            using (Ping ping = new Ping())
            {
                PingReply reply = ping.Send(address, timeout, Encoding.ASCII.GetBytes("连接测试..."), new PingOptions(64, true));

                return (reply.Status == IPStatus.Success);
            }
        }
    }
}
