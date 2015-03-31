using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static partial class WLB
    {
        //读取中心指定承运日期全部运单
        public static List<WLDataModelLayer.WLB> ReadCentralByCZRQ(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE ([node] = @node OR [jh_code] = @node) AND [cz_rq] = @date AND [yd_type] = 'R' ORDER BY [fh_code], [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //读取本站等待上传中心运单
        public static List<WLDataModelLayer.WLB> ReadLocalUploadCentral(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [date] = @date AND [jh_code] <> '00000000000' AND [yd_type] <> 'R' AND [zt_type] <> 'F' AND [synced] = 'N' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //读取中心指定单号运单
        public static WLDataModelLayer.WLB ReadCentral(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [sn] = @sn AND [yd_type] = 'R'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return ToWLB(rdr);
            }
            return null;
        }

        //获取本站已同步/未同步运单数
        public static int GetLocalSynchronizedNumber(SqlCommand cmd, string node, DateTime date, bool synchronized)
        {
            if (synchronized)
                cmd.CommandText = "SELECT COUNT(*) FROM WLB WHERE [node] = @node AND [date] = @date AND [jh_code] <> '00000000000' AND [yd_type] <> 'R' AND [zt_type] <> 'F' AND [synced] = 'Y'";
            else
                cmd.CommandText = "SELECT COUNT(*) FROM WLB WHERE [node] = @node AND [date] = @date AND [jh_code] <> '00000000000' AND [yd_type] <> 'R' AND [zt_type] <> 'F' AND [synced] = 'N'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //获取中心全部日期列表
        public static List<DateTime> GetCentralAllCZRQ(SqlCommand cmd, string node, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE ([node] = @node OR [jh_code] = @node) AND [yd_type] = 'R' GROUP BY [cz_rq] ORDER BY [cz_rq] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE ([node] = @node OR [jh_code] = @node) AND [yd_type] = 'R' GROUP BY [cz_rq] ORDER BY [cz_rq] DESC";
                    break;
                default: throw new DataException("未指定有效排序顺序！");
            }
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["cz_rq"]));
            }
            return list;
        }

        //获取本站已卸车日期列表
        public static List<DateTime> GetLocalXCDates(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [yd_type] = 'R' AND [zt_type] = 'X' GROUP BY [cz_rq] ORDER BY [cz_rq] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [yd_type] = 'R' AND [zt_type] = 'X' GROUP BY [cz_rq] ORDER BY [cz_rq] DESC";
                    break;
                default: throw new DataException("未指定有效排序顺序！");
            }

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["cz_rq"]));
            }
            return list;
        }

        //获取本站已取货日期列表
        public static List<DateTime> GetLocalSHDates(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [yd_type] = 'R' AND [zt_type] = 'S' GROUP BY [cz_rq] ORDER BY [cz_rq] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [yd_type] = 'R' AND [zt_type] = 'S' GROUP BY [cz_rq] ORDER BY [cz_rq] DESC";
                    break;
                default: throw new DataException("未指定有效排序顺序！");
            }

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["cz_rq"]));
            }
            return list;
        }

        //------------------------------------------------------------------------------------
        //中心功能
        //------------------------------------------------------------------------------------

        #region 装车处理
        public static bool WaitingZCExists(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM WLB WHERE [fh_code] = @node AND [sn] = @sn AND [yd_type] = 'R' AND [zt_type] = 'J'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static WLDataModelLayer.WLB ReadWaitingZCItem(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT * FROM WLB WHERE [fh_code] = @node AND [sn] = @sn AND [yd_type] = 'R' AND [zt_type] = 'J'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return WLB.ToWLB(rdr);
            }
            return null;
        }

        public static List<WLDataModelLayer.WLB> ReadWaitingZCList(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [fh_code] = @node AND [cz_rq] = @date AND [yd_type] = 'R' AND [zt_type] = 'J' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(WLB.ToWLB(rdr));
            }
            return list;
        }

        public static List<WLDataModelLayer.WLB> ReadAlreadyZCList(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [fh_code] = @node AND [cz_rq] = @date AND [yd_type] = 'R' AND [zt_type] = 'Z' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(WLB.ToWLB(rdr));
            }
            return list;
        }

        public static List<DateTime> ReadWaitingZCDates(SqlCommand cmd, string node, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [fh_code] = @node AND [yd_type] = 'R' AND [zt_type] = 'J' GROUP BY [cz_rq] ORDER BY [cz_rq] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [fh_code] = @node AND [yd_type] = 'R' AND [zt_type] = 'J' GROUP BY [cz_rq] ORDER BY [cz_rq] DESC";
                    break;
                default: break;
            }            
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(Convert.ToDateTime(rdr["cz_rq"])); }
            }
            return list;
        }
        #endregion

        #region 卸车处理
        public static bool WaitingXCExists(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM WLB WHERE [jh_code] = @node AND [sn] = @sn AND [yd_type] = 'R' AND [zt_type] = 'Z'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static WLDataModelLayer.WLB ReadWaitingXCItem(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT * FROM WLB WHERE [jh_code] = @node AND [sn] = @sn AND [yd_type] = 'R' AND [zt_type] = 'Z'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return WLB.ToWLB(rdr);
            }
            return null;
        }

        public static List<WLDataModelLayer.WLB> ReadWaitingXCList(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [jh_code] = @node AND [cz_rq] = @date AND [yd_type] = 'R' AND [zt_type] = 'Z' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(WLB.ToWLB(rdr));
            }
            return list;
        }

        public static List<WLDataModelLayer.WLB> ReadAlreadyXCList(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [jh_code] = @node AND [cz_rq] = @date AND [yd_type] = 'R' AND [zt_type] = 'X' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(WLB.ToWLB(rdr));
            }
            return list;
        }

        public static List<DateTime> ReadWaitingXCDates(SqlCommand cmd, string node, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [fh_code] = @node AND [yd_type] = 'R' AND [zt_type] = 'Z' GROUP BY [cz_rq] ORDER BY [cz_rq] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [fh_code] = @node AND [yd_type] = 'R' AND [zt_type] = 'Z' GROUP BY [cz_rq] ORDER BY [cz_rq] DESC";
                    break;
                default: break;
            }
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(Convert.ToDateTime(rdr["cz_rq"])); }
            }
            return list;
        }
        #endregion

        #region 取货处理
        public static bool WaitingQHExists(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM WLB WHERE [jh_code] = @node AND [sn] = @sn AND [yd_type] = 'R' AND [zt_type] = 'X'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static WLDataModelLayer.WLB ReadWaitingQHItem(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT * FROM WLB WHERE [jh_code] = @node AND [sn] = @sn AND [yd_type] = 'R' AND [zt_type] = 'X'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return WLB.ToWLB(rdr);
            }
            return null;
        }

        public static List<WLDataModelLayer.WLB> ReadWaitingQHList(SqlCommand cmd, string node, DateTime date)
        {
            return ReadAlreadyXCList(cmd, node, date);
        }

        public static List<WLDataModelLayer.WLB> ReadAlreadyQHList(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [jh_code] = @node AND [cz_rq] = @date AND [yd_type] = 'R' AND [zt_type] = 'S' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(WLB.ToWLB(rdr));
            }
            return list;
        }

        public static List<DateTime> ReadWaitingQHDates(SqlCommand cmd, string node, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {              
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [fh_code] = @node AND [yd_type] = 'R' AND [zt_type] = 'X' GROUP BY [cz_rq] ORDER BY [cz_rq] DESC";
                    break;
                case SortOrder.Ascending:                     
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [fh_code] = @node AND [yd_type] = 'R' AND [zt_type] = 'X' GROUP BY [cz_rq] ORDER BY [cz_rq] ASC";
                    break;
                default: break;
            }
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(Convert.ToDateTime(rdr["cz_rq"])); }
            }
            return list;
        }
        #endregion
    }
}
