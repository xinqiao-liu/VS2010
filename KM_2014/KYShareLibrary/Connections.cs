using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace KM.Common
{
    public static class Connections
    {
        private static SqlConnection m_OneConnection = null;
        private static SqlConnection m_TwoConnection = null;
        private static OleDbConnection m_OleConnection = null;

        public static SqlConnection OneConnection
        {
            get 
            {
                if (m_OneConnection == null)
                    throw new NullReferenceException("主数据连接未初始化！");
                return m_OneConnection; 
            }
            set { m_OneConnection = value; }
        }

        public static SqlConnection TwoConnection
        {
            get 
            {
                if (m_TwoConnection == null)
                    throw new NullReferenceException("辅数据连接未初始化！");
                return m_TwoConnection; 
            }
            set { m_TwoConnection = value; }
        }

        public static OleDbConnection OleConnection
        {
            get 
            {
                if (m_OleConnection == null)
                    throw new NullReferenceException("Access 数据连接未初始化！");
                return m_OleConnection; 
            }
            set { m_OleConnection = value; }
        }

        public static Boolean OneConnectionIsNull
        {
            get { return (m_OneConnection == null); }
        }

        public static Boolean TwoConnectionIsNull
        {
            get { return (m_TwoConnection == null); }
        }

        public static Boolean OleConnectionIsNull
        {
            get { return (m_OleConnection == null); }
        }

        public static ConnectionState OneConnectionState
        {
            get { return OneConnection.State; }
        }

        public static ConnectionState TwoConnectionState
        {
            get { return TwoConnection.State; }
        }

        public static ConnectionState OleConnectionState
        {
            get { return OleConnection.State; }
        }

        public static void InitOneConnection(String connStr, StateChangeEventHandler handler)
        {
            try
            {
                if (connStr == String.Empty) throw new NullReferenceException("主数据连接字符串为空！");
                else
                {
                    OneConnection = new SqlConnection(connStr);
                    if (handler != null)
                    {
                        OneConnection.StateChange += handler;
                    }

                    OneConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("初始化主数据连接异常：" + ex.Message);
            }   
        }

        public static void InitTwoConnection(String connStr, StateChangeEventHandler handler)
        {
            try
            {
                if (connStr == String.Empty) throw new NullReferenceException("辅数据连接字符串为空！");
                else
                {
                    TwoConnection = new SqlConnection(connStr);
                    if (handler != null)
                    {
                        TwoConnection.StateChange += handler;
                    }

                    TwoConnection.Open();

                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("初始化辅数据连接异常：" + ex.Message);
            }
        }

        public static void InitOleConnection(String connStr, StateChangeEventHandler handler)
        {
            try
            {
                if (connStr == String.Empty) throw new NullReferenceException("Access 数据连接字符串为空！");
                else
                {
                    OleConnection = new OleDbConnection(connStr);
                    if (handler != null)
                    {
                        OleConnection.StateChange += handler;
                    }

                    OleConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("初始化 Access 数据连接异常：" + ex.Message);
            }
        }

        //public static bool TestIP(String ipAddress, int timeout)
        //{
        //    try
        //    {
        //        if (ipAddress == String.Empty) return false;

        //        using (Ping ping = new Ping())
        //        {
        //            PingReply reply = ping.Send(ipAddress, timeout, Encoding.ASCII.GetBytes("LS Group"), new PingOptions(64, true));

        //            return (reply.Status == IPStatus.Success);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("检测IP地址发生异常：\n\r" + ex.Message);
        //    }
        //}
    }
}
