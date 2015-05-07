using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KM.Common
{
    public static class JP
    {
        public static void RJP(SqlConnection conn, DateTime rq, String cc, String ph)
        {
            if (cc == string.Empty) throw new ApplicationException("热线检票须指定热线班次");

            Int32 dy = KM.Data.BCK.GetFixedNumber(conn, rq, cc);
            Int32 sc = KM.Data.BCK.GetSaleNumber(conn, rq, cc);

            if (sc >= dy) throw new ApplicationException("班次'" + cc + "'已定员");

            using (SqlTransaction trn = conn.BeginTransaction())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Transaction = trn;
                    try
                    {
                        if (!KM.Data.CPB.SetState(cmd, rq, ph, CPState.已检)) throw new ApplicationException("不能办理客票'" + ph + "'热线检票");
                        if (!KM.Data.CPB.SetHotCC(cmd, rq, ph, cc)) throw new ApplicationException("不能设置客票'" + ph + "'班次信息");
                        if (!KM.Data.BCK.SetSaleNumber(cmd, rq, cc, 1)) throw new ApplicationException("不能递增班次'" + cc + "售出数");

                        trn.Commit();
                    }
                    catch (Exception ex)
                    {
                        trn.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void RTJ(SqlConnection conn, DateTime rq, String cc, String ph)
        {
            if (cc == string.Empty) throw new ApplicationException("热线退检须指定热线班次");

            using (SqlTransaction trn = conn.BeginTransaction())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Transaction = trn;
                    try
                    {
                        if (!KM.Data.CPB.SetState(cmd, rq, ph, CPState.未检)) throw new ApplicationException("不能办理客票'" + ph + "'热线退检");
                        if (!KM.Data.CPB.SetHotCC(cmd, rq, ph, "未定")) throw new ApplicationException("不能设置客票'" + ph + "'班次信息");
                        if (!KM.Data.BCK.SetSaleNumber(cmd, rq, cc, -1)) throw new ApplicationException("不能递减班次'" + cc + "售出数");

                        trn.Commit();
                    }
                    catch (Exception ex)
                    {
                        trn.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void PJP(SqlConnection conn, DateTime rq, String ph)
        {
            if (!KM.Data.CPB.SetState(conn, rq, ph, CPState.已检)) throw new ApplicationException("不能办理客票'" + ph + "'普通检票");
        }

        public static void PTJ(SqlConnection conn, DateTime rq, String ph)
        {
            if (!KM.Data.CPB.SetState(conn, rq, ph, CPState.未检)) throw new ApplicationException("不能办理客票'" + ph + "'普通退检");
        }

        public static void TransactJP(SqlConnection conn, String cc, String ph, Int32 time)
        {
            TransactJP(conn, KM.Common.Runtime.QueryDate, cc, ph, time);
        }

        public static void TransactJP(SqlConnection conn, DateTime rq, String cc, String ph, Int32 time)
        {
            KM.Data.CPB cpItem = KM.Data.CPB.Read(conn, rq, ph);
            if (cpItem != null)
            {
                KM.Data.BCK bcItem = KM.Data.BCK.Read(conn, rq, cc);;

                if (bcItem != null)
                {
                    if (cpItem.BZ == CPState.废票) throw new ApplicationException("客票 " + ph + " 已废");
                    if (cpItem.BZ == CPState.退票) throw new ApplicationException("客票 " + ph + " 已退");
                    if (cpItem.BZ == CPState.已检) throw new ApplicationException("客票 " + ph + " 已检（班次：" + cpItem.CC + "）");

                    if (cpItem.CC == "未定")
                    {
                        if (!KM.Data.JYB.Exists(conn, rq, cc, KM.Data.ZMPJB.GetCode(conn, cpItem.DZBZ)))
                            throw new ApplicationException("客票 " + ph + " 非当前热线班次客票");
                        if (bcItem.FCSJ != "循环")
                            throw new ApplicationException("客票 " + ph + " 为热线客票，检票钱须先选择热线班次");

                        RJP(conn, rq, cc, ph);
                    }
                    else
                    {
                        //检测客票是否过期，补票除外（2010-05-28）
                        //----------------------------------------------------------------------------------
                        DateTime cdt = KM.Data.Common.GetDate(conn);
                        DateTime pdt = Convert.ToDateTime(cpItem.RQ.ToString("yyyy-MM-dd") + " " + cpItem.FCSJ + ":00");
                        DateTime sdt = cpItem.SPRQ;

                        if (cdt.Date > cpItem.RQ)
                        {
                            throw new ApplicationException("客票 " + ph + " 为过期客票！");
                        }

                        if (time > 0 && cdt >= pdt && sdt < pdt.AddMinutes(-time))
                        {
                            throw new ApplicationException("客票 " + ph + " 已过检票时间！");
                        }
                        //----------------------------------------------------------------------------------

                        PJP(conn, rq, ph);
                    }

                }
                else
                    throw new ApplicationException("无法读取班次 " + ((cpItem.CC == "未定") ? cc : cpItem.CC) + " 数据");
            }
            else
                throw new ApplicationException("无法读取客票 " + ph + " 数据");
        }
         
        public static void TransactTJ(SqlConnection conn, String cc, String ph)
        {
            TransactTJ(conn, KM.Common.Runtime.QueryDate, cc, ph);
        }

        public static void TransactTJ(SqlConnection conn, DateTime rq, String cc, String ph)
        {
            if (KM.Data.CPB.Exists(conn,rq,ph))
            {
                KM.Data.CPB item = KM.Data.CPB.Read(conn, rq, ph);
                if (item != null)
                {
                    if (item.FCSJ == "未定" && cc == string.Empty) throw new ApplicationException("热线退检须指定热线班次");

                    if (item.BZ == CPState.废票) throw new ApplicationException("客票 " + ph + " 已废");
                    if (item.BZ == CPState.退票) throw new ApplicationException("客票 " + ph + " 已退");
                    if (item.BZ == CPState.未检) throw new ApplicationException("客票 " + ph + " 未检");

                    if (item.FCSJ == "未定")
                        RTJ(conn,rq,cc,ph);                        
                    else
                        PTJ(conn,rq,ph);
                }
                else
                    throw new ApplicationException("无法读取客票 " + ph + " 数据");
            }
            else
                throw new ApplicationException("客票 " + ph + " 无效");
        }

        public static void RefreshBC(SqlConnection conn, ListView list, List<String> jpbcList, String jpk)
        {
            List<KM.Data.BCK> bcList;
            if (jpk == "全部")
                bcList = KM.Data.BCK.Reads(conn, Runtime.QueryDate, "00:00");
            else
                bcList = KM.Data.BCK.Reads_JPK(conn, Runtime.QueryDate, jpk, "00:00");
            list.Items.Clear();
            foreach (KM.Data.BCK bcItem in bcList)
            {
                list.Items.Add(new ListViewItem(new String[] { jpbcList.Contains(bcItem.CC) ? "[检票]" : "", bcItem.CC, bcItem.ZDZ, bcItem.FCSJ, bcItem.CPH, bcItem.DY.ToString() }));
            }
        }

        //2014-1-24 加入 zdz ，用于区别热线
        public static void RefreshCP(SqlConnection conn, ListView list, String cc, String zdz, String bz)
        {
            List<KM.Data.CPB> cpList;
            if(cc == "未定")
                cpList = KM.Data.CPB.Reads(conn, Runtime.QueryDate, cc, zdz, bz);
            else
                cpList = KM.Data.CPB.Reads(conn, Runtime.QueryDate, cc, bz);

            list.Items.Clear();
            foreach (KM.Data.CPB cpItem in cpList)
            {
                list.Items.Add(new ListViewItem(new String[] { cpItem.PH, cpItem.CC, cpItem.ZH, cpItem.DZ, cpItem.PZ }));
            }
        }

        public static String GetCPCC(SqlConnection conn, String ph)
        {
            return KM.Data.CPB.GetCC(conn, KM.Common.Runtime.QueryDate, ph);
        }

        public static Boolean CPExists(SqlConnection conn, String ph)
        {
            return KM.Data.CPB.Exists(conn, KM.Common.Runtime.QueryDate, ph);
        }

        public static Boolean IsHotCP(SqlConnection conn, String ph)
        {
            return KM.Data.CPB.IsHot(conn, KM.Common.Runtime.QueryDate, ph);
        }

        public static Boolean IsHotBC(SqlConnection conn, String cc)
        {
            return KM.Data.BCK.IsHot(conn, KM.Common.Runtime.QueryDate, cc);
        }
    }
}
