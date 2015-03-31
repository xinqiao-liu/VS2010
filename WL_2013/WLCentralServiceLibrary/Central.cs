using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace WLCentralServiceLibrary
{
    public class Central : ICentral
    {
        private string connStr;
        private bool pingEnabled;
        private int pingTimeout;

        public Central()
        {
            connStr = "Data Source=localhost;Initial Catalog=wlserver_central;Persist Security Info=True;User ID=net;Password=net2008";
            pingEnabled = true;
            pingTimeout = 2000;
        }

        public string GetServiceInfo()
        {
            return "WLCentralService";
        }

        //检测运单是否存在
        public bool WLB_Exist(WLDataModelLayer.WLB item)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.Exists(conn.CreateCommand(), item.Node, item.Date, item.SN);
            }
        }

        //插入运单
        public bool WLB_Insert(WLDataModelLayer.WLB item)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.Insert(conn.CreateCommand(), item);
            }
        }

        //更新运单
        public bool WLB_Update(WLDataModelLayer.WLB item)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.Update(conn.CreateCommand(), item);
            }
        }

        //读取运单
        public WLDataModelLayer.WLB WLB_Read(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadCentral(conn.CreateCommand(), node, sn);
            }
        }

        //读取指定网点、日期运单
        public List<WLDataModelLayer.WLB> WLB_ReadByCZRQ(string node, DateTime date)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadCentralByCZRQ(conn.CreateCommand(), node, date);
            }
        }

        //读取日期列表
        public List<DateTime> WLB_GetAllCZRQ(string node, SortOrder mode)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.GetCentralAllCZRQ(conn.CreateCommand(), node, mode);
            }
        }

        //设置运单状态
        public bool WLB_SetZTType(string node, DateTime date, string sn, WLDataModelLayer.ZTType type)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.SetZTType(conn.CreateCommand(), node, date, sn, type);
            }
        }

        //检测等待装车运单是否存在
        public bool WLB_ExistWaitingZC(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.WaitingZCExists(conn.CreateCommand(), node, sn);
            }
        }

        //读取指定网点所有等待装车运单
        public List<WLDataModelLayer.WLB> WLB_ReadWaitingZCList(string node, DateTime date)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingZCList(conn.CreateCommand(), node, date);
            }
        }

        //读取指定网点所有已经装车运单
        public List<WLDataModelLayer.WLB> WLB_ReadAlreadyZCList(string node, DateTime date)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadAlreadyZCList(conn.CreateCommand(), node, date);
            }
        }

        //读取指定网点、单号待装车运单
        public WLDataModelLayer.WLB WLB_ReadWaitingZCItem(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingZCItem(conn.CreateCommand(), node, sn);
            }
        }

        //读取指定网点等待装车日期列表
        public List<DateTime> WLB_ReadWaitingZCDates(string node, SortOrder mode)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingZCDates(conn.CreateCommand(), node, mode);
            }
        }

        //检测等待卸车运单是否存在
        public bool WLB_ExistWaitingXC(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.WaitingXCExists(conn.CreateCommand(), node, sn);
            }
        }

        //读取指定网点所有等待卸车运单
        public List<WLDataModelLayer.WLB> WLB_ReadWaitingXCList(string node, DateTime date)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingXCList(conn.CreateCommand(), node, date);
            }
        }

        //读取指定网点所有已经卸车运单
        public List<WLDataModelLayer.WLB> WLB_ReadAlreadyXCList(string node, DateTime date)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadAlreadyXCList(conn.CreateCommand(), node, date);
            }
        }

        //读取指定网点、单号待卸车运单
        public WLDataModelLayer.WLB WLB_ReadWaitingXCItem(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingXCItem(conn.CreateCommand(), node, sn);
            }
        }

        //读取指定网点等待卸车日期列表
        public List<DateTime> WLB_ReadWaitingXCDates(string node, SortOrder mode)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingXCDates(conn.CreateCommand(), node, mode);
            }
        }

        //检测等待取货运单是否存在
        public bool WLB_ExistWaitingSH(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.WaitingQHExists(conn.CreateCommand(), node, sn);
            }
        }

        //读取指定网点所有等待取货运单
        public List<WLDataModelLayer.WLB> WLB_ReadWaitingSHList(string node, DateTime date)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingQHList(conn.CreateCommand(), node, date);
            }
        }

        //读取指定网点所有已经取货运单
        public List<WLDataModelLayer.WLB> WLB_ReadAlreadySHList(string node, DateTime date)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadAlreadyQHList(conn.CreateCommand(), node, date);
            }
        }

        //读取指定网点、单号待取货运单
        public WLDataModelLayer.WLB WLB_ReadWaitingSHItem(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingQHItem(conn.CreateCommand(), node, sn);
            }
        }

        //读取指定网点等待取货日期列表
        public List<DateTime> WLB_ReadWaitingSHDates(string node, SortOrder mode)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLB.ReadWaitingQHDates(conn.CreateCommand(), node, mode);
            }
        }

        //检测运单跟踪记录是否存在
        public bool WLT_Exist(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLT.Exists(conn.CreateCommand(), node, sn);
            }
        }

        //插入运单跟踪记录
        public bool WLT_Insert(WLDataModelLayer.WLT item)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLT.Insert(conn.CreateCommand(), item);
            }
        }

        //获取运单跟踪记录
        public List<WLDataModelLayer.WLT> WLT_Reads(string node, string sn)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                return WLDataAccessLayer.WLT.Reads(conn.CreateCommand(), node, sn);         
            }
        }

        //指定接货、装车、卸车、取货及废单
        public void Execute(WLDataModelLayer.WLB item, string content)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                using (SqlTransaction tran = conn.CreateTransaction())
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = tran;
                        try
                        {
                            WLDataAccessLayer.WLB.Update(cmd, item);
                            WLDataAccessLayer.WLT.Insert(cmd, new WLDataModelLayer.WLT() { Node = item.Node, Date = item.Date, SN = item.SN, Content = content });

                            tran.Commit();
                        }
                        catch (Exception ex) { tran.Rollback(); throw ex; }
                    }
                }
            }
        }
    }
}
    
