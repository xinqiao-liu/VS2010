using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataLogicLayer
{
    public static class Runtime
    {
        #region 数据连接部分

        private static Common.BaseConnection B_Connection { get; set; }
        private static Common.BaseConnection C_Connection { get; set; }
        public static bool UnifiedDataSource { get; set; }

        public static void B_ConnectionInit(string connStr, StateChangeEventHandler handler, bool pingEnabled, int pingTimeout)
        {
            Runtime.B_ConnectionClose();
            Runtime.B_Connection = new Common.BaseConnection(connStr, handler, pingEnabled, pingTimeout);
        }

        public static void C_ConnectionInit(string connStr, StateChangeEventHandler handler, bool pingEnabled, int pingTimeout)
        {
            Runtime.C_ConnectionClose();
            Runtime.C_Connection = new Common.BaseConnection(connStr, handler, pingEnabled, pingTimeout);
        }

        public static void B_ConnectionOpen()
        {
            if (Runtime.B_Connection == null)
                throw new ApplicationException("基础数据连接未初始化！");
            else
                Runtime.B_Connection.Open();
        }

        public static void C_ConnectionOpen()
        {
            if (Runtime.C_Connection == null)
                throw new ApplicationException("汇总数据连接未初始化！");
            else
                Runtime.C_Connection.Open();
        }

        public static void B_ConnectionClose()
        {
            if (Runtime.B_Connection != null) Runtime.B_Connection.Close();
        }

        public static void C_ConnectionClose()
        {
            if (Runtime.C_Connection != null) Runtime.C_Connection.Close();
        }

        public static SqlCommand B_CreateCommand()
        {
            if (Runtime.B_Connection == null)
                throw new ApplicationException("基础数据连接未初始化！");
            else
                return Runtime.B_Connection.CreateCommand();
        }

        public static SqlCommand C_CreateCommand()
        {
            if (Runtime.C_Connection == null)
                throw new ApplicationException("汇总数据连接未初始化！");
            else
                return Runtime.C_Connection.CreateCommand();
        }

        public static SqlTransaction B_CreateTransaction()
        {
            if (Runtime.B_Connection == null)
                throw new ApplicationException("基础数据连接未初始化！");
            else
                return Runtime.B_Connection.CreateTransaction();
        }

        public static SqlTransaction C_CreateTransaction()
        {
            if (Runtime.C_Connection == null)
                throw new ApplicationException("汇总数据连接未初始化！");
            else
                return Runtime.C_Connection.CreateTransaction();
        }

        #endregion

        #region 系统信息部分

        private static DateTime m_CurrentDate = DateTime.MinValue;

        public static DateTime CurrentDT
        {
            get { return WLDataAccessLayer.ServerInfo.GetServerDT(Runtime.B_CreateCommand()); }
        }

        public static DateTime CurrentDate
        {
            get 
            {
                if (Runtime.m_CurrentDate == DateTime.MinValue)
                    Runtime.m_CurrentDate = Runtime.CurrentDT.Date;

                return Runtime.m_CurrentDate;
            }
        }

        public static void InitSystem(bool syncDT)
        {
            Runtime.InitQueryDate(syncDT);
            Setting.Init();
            PrintFormat.Init();
            Mapping.Init();
        }

        public static void InitQueryDate(bool syncDT)
        {
            if (syncDT) { Common.SystemCall.SetLocalTime(CurrentDT); }
        }

        #endregion
    }
}
