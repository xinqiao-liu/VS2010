using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYDataLogicLayer
{
    public static class Runtime
    {
        private static Common.BaseConnection B_Connection { get; set; }

        public static void B_ConnectionInit(Common.ConnectionInfo connInfo, StateChangeEventHandler handler)
        {
            Runtime.B_ConnectionClose();
            Runtime.B_Connection = new Common.BaseConnection(Common.ConnectionInfo.ToConnectionString(connInfo), handler, connInfo.PingEnabled, connInfo.PingTimeout);
        }

        public static void B_ConnectionOpen()
        {
            if (Runtime.B_Connection == null)
                throw new ApplicationException("客运数据连接未初始化！");
            else
                Runtime.B_Connection.Open();
        }

        public static void B_ConnectionClose()
        {
            if (Runtime.B_Connection != null) Runtime.B_Connection.Close();
        }

        public static SqlCommand B_CreateCommand()
        {
            if (Runtime.B_Connection == null)
                throw new ApplicationException("客运数据连接未初始化！");
            else
                return Runtime.B_Connection.CreateCommand();
        }

        public static SqlTransaction B_CreateTransaction()
        {
            if (Runtime.B_Connection == null)
                throw new ApplicationException("客运数据连接未初始化！");
            else
                return Runtime.B_Connection.CreateTransaction();
        }

        public static bool B_Compare(string connStr)
        {
            if (Runtime.B_Connection == null)
                return false;
            else
                return Runtime.B_Connection.Compare(connStr);
        }
    }
}