using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace KM.Common
{
    public static class BSY_JP
    {
        public static void TransactJP(SqlConnection conn, String cc, String ph, Int32 time)
        {
            TransactJP(conn, KM.Common.Runtime.BM, KM.Common.Runtime.QueryDate, cc, ph, time);
        }

        public static void TransactJP(SqlConnection conn, String bm, DateTime rq, String cc, String ph, Int32 time)
        {
            KM.Data.CPB cpItem = KM.Data.CPB.Read(conn, rq, ph);
            if (cpItem != null)
            {
                KM.Data.BCK bcItem = KM.Data.BCK.Read(conn, rq, cc);;

                if (bcItem != null)
                {
                    if (cpItem.BZ == CPState.废票) throw new ApplicationException("远程客票 " + ph + " 已废");
                    if (cpItem.BZ == CPState.退票) throw new ApplicationException("远程客票 " + ph + " 已退");
                    if (cpItem.BZ == CPState.已检) throw new ApplicationException("远程客票 " + ph + " 已检");

                    if (cpItem.CC == "未定") throw new ApplicationException("热线客票不能办理远程检票");
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

                        JP.PJP(conn, rq, ph);
                    }

                }
                else
                    throw new ApplicationException("无法读取班次 " + ((cpItem.CC == "未定") ? cc : cpItem.CC) + " 数据");
            }
            else
                throw new ApplicationException("无法读取远程客票 " + ph + " 数据");
        }

        public static void TransactTJ(SqlConnection conn, String cc, String ph)
        {
            TransactTJ(conn, KM.Common.Runtime.BM, KM.Common.Runtime.QueryDate, cc, ph);
        }

        public static void TransactTJ(SqlConnection conn, String bm, DateTime rq, String cc, String ph)
        {
            if (KM.Data.CPB.Exists(conn, rq, ph))
            {
                KM.Data.CPB cpItem = KM.Data.CPB.Read(conn, rq, ph);
                if (cpItem != null)
                {
                    if (cpItem.FCSJ == "未定") throw new ApplicationException("热线客票不能办理远程退检");

                    if (cpItem.BZ == CPState.废票) throw new ApplicationException("远程客票 " + ph + " 已废");
                    if (cpItem.BZ == CPState.退票) throw new ApplicationException("远程客票 " + ph + " 已退");
                    if (cpItem.BZ == CPState.未检) throw new ApplicationException("远程客票 " + ph + " 未检");

                    JP.PTJ(conn, rq, ph);
                }
                else
                    throw new ApplicationException("无法读取远程客票 " + ph + " 数据");
            }
            else
                throw new ApplicationException("远程客票 " + ph + " 无效");
        }

        public static void RefreshBC(SqlConnection conn, String dm, ListView list, List<String> jpbcList)
        {
            List<KM.Data.BCK> bcList;
            bcList = KM.Data.BCK.Reads(conn, Runtime.QueryDate, "00:00");
            list.Items.Clear();
            foreach (KM.Data.BCK bcItem in bcList)
            {
                list.Items.Add(new ListViewItem(new String[] { jpbcList.Contains(bcItem.CC) ? "[检票]" : "", bcItem.CC, bcItem.ZDZ, bcItem.FCSJ, bcItem.CPH, bcItem.DY.ToString() }));
            }
        }

        public static void RefreshCP(SqlConnection conn, String dm, ListView list, String cc, String bz)
        {
            List<KM.Data.CPB> cpList = KM.Data.CPB.Reads(conn, Runtime.QueryDate, cc, bz);
            list.Items.Clear();
            foreach (KM.Data.CPB cpItem in cpList)
            {
                list.Items.Add(new ListViewItem(new String[] { cpItem.PH, cpItem.CC, cpItem.ZH, cpItem.DZ, cpItem.PZ }));
            }
        }
    }
}
