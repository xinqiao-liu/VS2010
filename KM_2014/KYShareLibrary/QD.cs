using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KM.Common
{
    public static class QD
    {
        /*
        public static bool QDRecordExists(SqlConnection conn, DateTime rq)
        {
            return KM.Data.QDRecord.Exists(conn, rq);
        }

        public static bool QDRecordDelete(SqlConnection conn, DateTime rq)
        {
            return KM.Data.QDRecord.Delete(conn, rq);
        }

        //生成签到记录
        public static void QDRecordMake(SqlConnection conn, DateTime rq, ListView list)
        {
            String dtStr = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            String rqStr = rq.ToString("yyyy-MM-dd");
            String cid;

            List<KM.Data.BCK> items = KM.Data.BCK.Reads_ZT(conn, rq, "结算");
            foreach (KM.Data.BCK item in items)
            {
                //检测班次是否签到
                if (item.BDSJ == DateTime.MaxValue)
                {
                    list.Items.Add(new ListViewItem(new string[] { dtStr, rqStr, "班次 " + item.CC + " 未签到！" }));
                }

                //获取车牌号对应ID卡号
                cid = (KM.Data.IDCard.CPHExist(conn, item.CPH) ? KM.Data.IDCard.GetCID(conn, item.CPH) : String.Empty);
                if (cid == String.Empty)
                {
                    list.Items.Add(new ListViewItem(new string[] { dtStr, rqStr, "班次 " + item.CC + " 对应车牌号 " + item.CPH + " 无关联ID卡号！" }));
                }

                //插入签到记录
                KM.Data.QDRecord.Insert(conn, new KM.Data.QDRecord() { 
                    RQ = rq, 
                    CC = item.CC, 
                    ZDZ = item.ZDZ, 
                    FCSJ = item.FCSJ, 
                    CPH = item.CPH, 
                    CID = cid,
                    IDT = item.BDSJ, 
                    ODT = DateTime.MaxValue, 
                    WDT = DateTime.MaxValue });

                //list.Items.Add(new ListViewItem(new string[] { dtStr, rqStr, "班次 " + item.CC + " 对应车牌号 " + item.CPH }));
            }

            list.Items.Add(new ListViewItem(new string[] { dtStr, rqStr, "共计生成 " + items.Count + " 条签到记录。" }));
        }

        //刷新签到数据
        public static void RefreshQD(OleDbConnection conn, ListBox list, DateTime sd, DateTime ed)
        {
            List<KM.Data.OleDb.QDItem> items = KM.Data.OleDb.QDItem.Reads(conn, sd, ed);

            list.Items.Clear();
            foreach (KM.Data.OleDb.QDItem item in items)
            {
                list.Items.Add("ID卡：" + item.CID + " 签到时间：" + item.CDT.ToString("yyyy-MM-dd hh:mm:ss") + " 标志：" + item.Sign);
            }
        }

        //办理签到
        public static Boolean TransactQD(OleDbConnection conn, String cid, DateTime cdt, String sign, String make)
        {
            return KM.Data.OleDb.QDItem.Insert(conn, new KM.Data.OleDb.QDItem() { CID = cid, CDT = cdt, Sign = sign, Make = make });
        }

        //获取指定卡号最后签到时间
        public static DateTime GetLastQDTime(OleDbConnection conn, String cid)
        {
            KM.Data.OleDb.QDItem item = KM.Data.OleDb.QDItem.Read(conn,cid);
            if (item != null)
                return item.CDT;
            else
                return DateTime.MinValue;
        }

        //获取指定非Make最小日期
        public static DateTime GetMinDT(OleDbConnection conn, String nonMake)
        {
            return KM.Data.OleDb.QDItem.GetMinDT(conn, nonMake);
        }

        //获取指定非Make最大日期
        public static DateTime GetMaxDT(OleDbConnection conn, String nonMake)
        {
            return KM.Data.OleDb.QDItem.GetMaxDT(conn, nonMake);
        }

        //导出数据到文件
        public static Int32 ExportData(OleDbConnection conn, String filename, DateTime sd, DateTime ed, String state)
        {
            List<KM.Data.OleDb.QDItem> items = KM.Data.OleDb.QDItem.Reads(conn,
                Convert.ToDateTime(sd.ToString("yyyy-MM-dd") + " 00:00:00"), 
                Convert.ToDateTime(ed.ToString("yyyy-MM-dd") + " 23:59:59"));

            KM.Common.Serializable.ExportQDDataToFile(filename, items);

            //设置签到项导出状态
            foreach (KM.Data.OleDb.QDItem item in items)
            {
                KM.Data.OleDb.QDItem.SetMake(conn, item, state);
            }

            return items.Count;
        }

        //导入数据自文件
        public static Int32 ImportData(OleDbConnection conn, String filename, Boolean replace, String state)
        {
            int count = 0;
            List<KM.Data.OleDb.QDItem> items = KM.Common.Serializable.ImportQDDataFromFile(filename);

            foreach (KM.Data.OleDb.QDItem item in items)
            {
                //设置签到项导入状态
                item.Make = state;

                //检测是否存在指定签到项
                if (!KM.Data.OleDb.QDItem.Exists(conn, item))
                {
                    KM.Data.OleDb.QDItem.Insert(conn, item); count++;
                }
            }

            return count;
        }

        //生成签到记录
        public static Int32 MakeQDData(OleDbConnection oleConn, SqlConnection sqlConn, DateTime sd, DateTime ed, String state, ListBox list)
        {
            int count = 0;

            //获取 sd - ed 签到记录
            List<KM.Data.QDRecord> items = KM.Data.QDRecord.Reads(sqlConn, sd, ed);

            foreach (KM.Data.QDRecord item in items)
            { 
                //KM.Data.OleDb.QDItem qtItem = KM.Data.OleDb.QDItem.Read(oleConn, item.CID, );
            }
            
            return count;
        }
        */
    }
}
