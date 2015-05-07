using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static partial class WLB
    {
        //------------------------------------------------------------------------------------
        //基础功能
        //------------------------------------------------------------------------------------

        #region DataReader创建运单记录
        public static Model.WLB ToWLB(SqlDataReader rdr)
        {
            Model.WLB item = new Model.WLB();

            item.Node = rdr["node"].ToString();
            item.Date = Convert.ToDateTime(rdr["date"]);
            item.SN = rdr["sn"].ToString();
            item.UID = rdr["uid"].ToString();
            item.CDT = Convert.ToDateTime(rdr["cdt"]);

            item.SK_Type = (Model.SKType)Convert.ToChar(rdr["sk_type"]);
            item.YD_Type = (Model.YDType)Convert.ToChar(rdr["yd_type"]);
            item.ZT_Type = (Model.ZTType)Convert.ToChar(rdr["zt_type"]);

            item.FH_Code = rdr["fh_code"].ToString();
            item.FH_Name = rdr["fh_name"].ToString();
            item.FH_CityName = rdr["fh_cityname"].ToString();
            item.JH_Code = rdr["jh_code"].ToString();
            item.JH_Name = rdr["jh_name"].ToString();

            item.CZ_RQ = Convert.ToDateTime(rdr["cz_rq"]);
            item.CZ_DZ = rdr["cz_dz"].ToString();
            item.CZ_CPH = rdr["cz_cph"].ToString();
            item.CZ_BC = rdr["cz_bc"].ToString();
            item.CZ_SJ = rdr["cz_sj"].ToString();
            item.CZ_LC = Convert.ToInt32(rdr["cz_lc"]);
            item.CZ_YX = rdr["cz_yx"].ToString();

            item.HW_MC = rdr["hw_mc"].ToString();
            item.HW_LX = rdr["hw_lx"].ToString();
            item.HW_JS = Convert.ToInt32(rdr["hw_js"]);
            item.HW_BJ = Convert.ToDecimal(rdr["hw_bj"]);

            item.FHR_Name = rdr["fhr_name"].ToString();
            item.FHR_Mobile = rdr["fhr_mobile"].ToString();
            item.FHR_Remark = rdr["fhr_remark"].ToString();
            item.JHR_Name = rdr["jhr_name"].ToString();
            item.JHR_Mobile = rdr["jhr_mobile"].ToString();

            item.JFZL = Convert.ToDecimal(rdr["jfzl"]);
            item.JFTJ = Convert.ToDecimal(rdr["jftj"]);
            item.TYF = Convert.ToDecimal(rdr["tyf"]);
            item.BZF = Convert.ToDecimal(rdr["bzf"]);
            item.BXF = Convert.ToDecimal(rdr["bxf"]);
            item.Total = Convert.ToDecimal(rdr["total"]);
            item.Money = Convert.ToDecimal(rdr["money"]);

            item.BXD_SN = rdr["bxd_sn"].ToString();

            item.Freeze = rdr["freeze"].ToString()[0] == 'Y' ? true : false;
            item.Synced = rdr["synced"].ToString()[0] == 'Y' ? true : false;

            item.Sets = rdr["sets"].ToString();

            return item;
        }
        #endregion

        #region 使用运单记录初始化参数
        public static void InitParameters(SqlParameterCollection parameters, Model.WLB item)
        {
            parameters.Clear();
            parameters.Add("@node", SqlDbType.VarChar).Value = item.Node;
            parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            parameters.Add("@sn", SqlDbType.VarChar).Value = item.SN;
            parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;
            parameters.Add("@cdt", SqlDbType.DateTime).Value = item.CDT;

            parameters.Add("@sk_type", SqlDbType.Char).Value = Convert.ToChar(item.SK_Type);
            parameters.Add("@yd_type", SqlDbType.Char).Value = Convert.ToChar(item.YD_Type);
            parameters.Add("@zt_type", SqlDbType.Char).Value = Convert.ToChar(item.ZT_Type);

            parameters.Add("@fh_code", SqlDbType.VarChar).Value = item.FH_Code;
            parameters.Add("@fh_name", SqlDbType.VarChar).Value = item.FH_Name;
            parameters.Add("@fh_cityname", SqlDbType.VarChar).Value = item.FH_CityName;
            parameters.Add("@jh_code", SqlDbType.VarChar).Value = item.JH_Code;
            parameters.Add("@jh_name", SqlDbType.VarChar).Value = item.JH_Name;

            parameters.Add("@cz_rq", SqlDbType.DateTime).Value = item.CZ_RQ;
            parameters.Add("@cz_bc", SqlDbType.VarChar).Value = item.CZ_BC;
            parameters.Add("@cz_dz", SqlDbType.VarChar).Value = item.CZ_DZ;
            parameters.Add("@cz_sj", SqlDbType.Char).Value = item.CZ_SJ;
            parameters.Add("@cz_cph", SqlDbType.VarChar).Value = item.CZ_CPH;
            parameters.Add("@cz_lc", SqlDbType.Int).Value = item.CZ_LC;
            parameters.Add("@cz_yx", SqlDbType.Char).Value = item.CZ_YX;

            parameters.Add("@hw_mc", SqlDbType.VarChar).Value = item.HW_MC;
            parameters.Add("@hw_lx", SqlDbType.VarChar).Value = item.HW_LX;
            parameters.Add("@hw_js", SqlDbType.Int).Value = item.HW_JS;
            parameters.Add("@hw_bj", SqlDbType.Decimal).Value = item.HW_BJ;

            parameters.Add("@fhr_name", SqlDbType.VarChar).Value = item.FHR_Name;
            parameters.Add("@fhr_mobile", SqlDbType.VarChar).Value = item.FHR_Mobile;
            parameters.Add("@fhr_remark", SqlDbType.VarChar).Value = item.FHR_Remark;
            parameters.Add("@jhr_name", SqlDbType.VarChar).Value = item.JHR_Name;
            parameters.Add("@jhr_mobile", SqlDbType.VarChar).Value = item.JHR_Mobile;

            parameters.Add("@jfzl", SqlDbType.Decimal).Value = item.JFZL;
            parameters.Add("@jftj", SqlDbType.Decimal).Value = item.JFTJ;
            parameters.Add("@tyf", SqlDbType.Decimal).Value = item.TYF;
            parameters.Add("@bzf", SqlDbType.Decimal).Value = item.BZF;
            parameters.Add("@bxf", SqlDbType.Decimal).Value = item.BXF;
            parameters.Add("@total", SqlDbType.Decimal).Value = item.Total;
            parameters.Add("@money", SqlDbType.Decimal).Value = item.Money;

            parameters.Add("@bxd_sn", SqlDbType.VarChar).Value = item.BXD_SN;

            parameters.Add("@freeze", SqlDbType.Char).Value = item.Freeze ? "Y" : "N";
            parameters.Add("@synced", SqlDbType.Char).Value = item.Synced ? "Y" : "N";

            parameters.Add("@sets", SqlDbType.Char).Value = item.Sets;
        }
        #endregion

        //------------------------------------------------------------------------------------
        //全局功能
        //------------------------------------------------------------------------------------

        #region 检测运单
        public static bool Exists(SqlCommand cmd, string node, DateTime date, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM WLB WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Exists(SqlCommand cmd, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM WLB WHERE [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }
        #endregion

        #region 删除运单
        public static bool Delete(SqlCommand cmd, string node, DateTime date, string sn)
        {
            cmd.CommandText = "DELETE FROM WLB WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
        #endregion

        #region 插入运单
        public static bool Insert(SqlCommand cmd, Model.WLB item)
        {
            cmd.CommandText = "INSERT INTO WLB ([node], [date], [sn], [uid], [cdt], [sk_type], [yd_type], [zt_type], [fh_code], [fh_name], [fh_cityname], [jh_code], [jh_name], "
                + "[cz_rq], [cz_bc], [cz_dz], [cz_sj], [cz_cph], [cz_lc], [cz_yx], "
                + "[hw_mc], [hw_lx], [hw_js], [hw_bj], [fhr_name], [fhr_mobile], [fhr_remark], [jhr_name], [jhr_mobile], "
                + "[jfzl], [jftj], [tyf], [bzf], [bxf], [total], [money], [bxd_sn], [freeze], [synced], [sets]) "
                + "VALUES (@node, @date, @sn, @uid, @cdt, @sk_type, @yd_type, @zt_type, @fh_code, @fh_name, @fh_cityname, @jh_code, @jh_name, "
                + "@cz_rq, @cz_bc, @cz_dz, @cz_sj, @cz_cph, @cz_lc, @cz_yx, "
                + "@hw_mc, @hw_lx, @hw_js, @hw_bj, @fhr_name, @fhr_mobile, @fhr_remark, @jhr_name, @jhr_mobile, "
                + "@jfzl, @jftj, @tyf, @bzf, @bxf, @total, @money, @bxd_sn, @freeze, @synced, @sets)";

            InitParameters(cmd.Parameters, item);

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
        #endregion

        #region 更新运单
        public static bool Update(SqlCommand cmd, Model.WLB item)
        {
            cmd.CommandText = "UPDATE WLB SET [uid] = @uid, "
                + "[sk_type] = @sk_type, [yd_type] = @yd_type, [zt_type] = @zt_type, [fh_code] = @fh_code, [fh_name] = @fh_name, [fh_cityname] = @fh_cityname, "
                + "[jh_code] = @jh_code, [jh_name] = @jh_name, [cz_rq] = @cz_rq, [cz_bc] = @cz_bc, [cz_dz] = @cz_dz, [cz_sj] = @cz_sj, [cz_cph] = @cz_cph, [cz_lc] = @cz_lc, [cz_yx] = @cz_yx, "
                + "[hw_mc] = @hw_mc, [hw_lx] = @hw_lx, [hw_js] = @hw_js, [hw_bj] = @hw_bj, [fhr_name] = @fhr_name, [fhr_mobile] = @fhr_mobile, [fhr_remark] = @fhr_remark, [jhr_name] = @jhr_name, [jhr_mobile] = @jhr_mobile, "
                + "[jfzl] = @jfzl, [jftj] = @jftj, [tyf] = @tyf, [bzf] = @bzf, [bxf] = @bxf, [total] = @total, [money] = @money, [bxd_sn] = @bxd_sn, [freeze] = @freeze, [synced] = @synced, [sets] = @sets "
                + "WHERE [node] = @node AND [date] = @date AND [sn] = @sn";

            InitParameters(cmd.Parameters, item);

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
        #endregion

        #region 设置运单
        public static bool SetZTType(SqlCommand cmd, string node, DateTime date, string sn, Model.ZTType zt_type)
        {
            cmd.CommandText = "UPDATE WLB SET [zt_type] = @zt_type WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            cmd.Parameters.Add("@zt_type", SqlDbType.Char).Value = Convert.ToChar(zt_type);

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //public static bool SetSynced(SqlCommand cmd, Model.WLB item)
        //{
        //    cmd.CommandText = "UPDATE WLB SET [synced] = @synced WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = item.Node;
        //    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
        //    cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = item.SN;
        //    cmd.Parameters.Add("@synced", SqlDbType.Char).Value = item.Synced;

        //    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //}

        //设置运单类型
        //public static bool SetYDType(SqlCommand cmd, string node, DateTime date, string sn, Model.YDType yd_type)
        //{
        //    cmd.CommandText = "UPDATE WLB SET [yd_type] = @yd_type WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
        //    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
        //    cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
        //    cmd.Parameters.Add("@yd_type", SqlDbType.Char).Value = Convert.ToChar(yd_type);

        //    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //}

        //设置冻结状态
        //public static bool SetFreeze(SqlCommand cmd, string node, DateTime date, string sn, bool freeze = true)
        //{
        //    cmd.CommandText = "UPDATE WLB SET [freeze] = @freeze WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
        //    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
        //    cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
        //    cmd.Parameters.Add("@freeze", SqlDbType.Char).Value = freeze ? "Y" : "N";

        //    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //}
        #endregion

        //------------------------------------------------------------------------------------
        //本站功能
        //------------------------------------------------------------------------------------

        #region 获取数据
        //获取本站全部日期列表
        public static List<DateTime> GetLocalAllDates(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [date] FROM WLB WHERE [yd_type] <> 'R' GROUP BY [date] ORDER BY [date] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [date] FROM WLB WHERE [yd_type] <> 'R' GROUP BY [date] ORDER BY [date] DESC";
                    break;
                default: throw new DataException("未指定有效排序顺序！");
            }

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["date"]));
            }
            return list;
        }

        //获取本站全部日期列表
        public static List<DateTime> GetLocalAllCZRQ(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [yd_type] <> 'R' GROUP BY [cz_rq] ORDER BY [cz_rq] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [yd_type] <> 'R' GROUP BY [cz_rq] ORDER BY [cz_rq] DESC";
                    break;
                default: throw new DataException("未指定有效排序顺序！");
            }

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["cz_rq"]));
            }
            return list;
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

        //获取本站未冻结/已冻结日期列表
        //public static List<DateTime> GetLocalFreezeDates(SqlCommand cmd, SortOrder mode, bool freeze)
        //{
        //    List<DateTime> list = new List<DateTime>();
        //    switch (mode)
        //    {
        //        case SortOrder.Ascending:
        //            cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [yd_type] = @yd_type AND [zt_type] <> 'F' AND [freeze] = @freeze GROUP BY [cz_rq] ORDER BY [cz_rq] ASC";
        //            break;
        //        case SortOrder.Descending:
        //            cmd.CommandText = "SELECT [cz_rq] FROM WLB WHERE [yd_type] = @yd_type AND [zt_type] <> 'F' AND [freeze] = @freeze GROUP BY [cz_rq] ORDER BY [cz_rq] DESC";
        //            break;
        //        default: throw new DataException("未指定有效排序顺序！");
        //    }
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.Add("@yd_type", SqlDbType.Char).Value = freeze ? "C" : "S";
        //    cmd.Parameters.Add("@freeze", SqlDbType.Char).Value = freeze ? "Y" : "N";
        //    using (SqlDataReader rdr = cmd.ExecuteReader())
        //    {
        //        while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["cz_rq"]));
        //    }
        //    return list;
        //}

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

        //获取本站用户办单合计金额
        public static Decimal GetLocalUserTotalAmount(SqlCommand cmd, string node, DateTime date, string uid)
        {
            cmd.CommandText = "SELECT SUM(total) as Total FROM WLB WHERE [node] = @node AND [date] = @date AND [uid] = @uid AND [yd_type] <> 'R' AND [zt_type] <> 'F' GROUP BY [date], [uid]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid;

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        //获取本站汇总日报表
        public static Model.DailySheet GetLocalDailySheet(SqlCommand cmd, string node, DateTime date)
        {
            Model.DailySheet item = new Model.DailySheet();
            item.Date = date;
            item.NodeCode = node;

            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.CommandText = "SELECT COUNT(*) AS Counts, SUM(hw_js) AS Packages, SUM(total) AS Total FROM WLB "
                + " WHERE [node] = @node AND [date] = @date AND [date] = [cz_rq] AND [yd_type] <> 'R' AND [zt_type] <> 'F' GROUP BY [node], [date]";
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    item.Counts1 = Convert.ToInt32(rdr["Counts"]);
                    item.Packages1 = Convert.ToInt32(rdr["Packages"]);
                    item.Total1 = Convert.ToDecimal(rdr["Total"]);
                }
            }

            cmd.CommandText = "SELECT COUNT(*) AS Counts, SUM(hw_js) AS Packages, SUM(total) AS Total FROM WLB "
                + " WHERE [node] = @node AND [date] = @date AND ([date] <> [cz_rq]) AND [yd_type] <> 'R' AND [zt_type] <> 'F' GROUP BY [node], [date]";
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    item.Counts2 = Convert.ToInt32(rdr["Counts"]);
                    item.Packages2 = Convert.ToInt32(rdr["Packages"]);
                    item.Total2 = Convert.ToDecimal(rdr["Total"]);
                }
            }           
            return item;
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

        //获取本站已冻结/未冻结运单数
        //public static int GetLocalFreezeNumber(SqlCommand cmd, string node, DateTime date, bool freeze)
        //{
        //    if (freeze)
        //        cmd.CommandText = "SELECT COUNT(*) FROM WLB WHERE [node] = @node AND [cz_rq] = @date AND [yd_type] = 'C' AND [zt_type] <> 'F' AND [freeze] = 'Y'";
        //    else
        //        cmd.CommandText = "SELECT COUNT(*) FROM WLB WHERE [node] = @node AND [cz_rq] = @date AND [yd_type] = 'S' AND [zt_type] <> 'F' AND [freeze] = 'N'";
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
        //    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

        //    return Convert.ToInt32(cmd.ExecuteScalar());
        //}
        #endregion

        #region 读取运单
        //读取本站指定单号运单（本地改单废单时使用）
        public static Model.WLB ReadLocal(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [sn] = @sn AND [yd_type] <> 'R'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            using (SqlDataReader rdr = cmd.ExecuteReader()) 
            { 
                if (rdr.Read()) return ToWLB(rdr); 
            }
            return null;
        }

        //读取中心指定单号运单
        public static Model.WLB ReadCentral(SqlCommand cmd, string node, string sn)
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

        //获取本站指定用户编号运单（包含废单）（可混合计算已冻结及未冻结运单以支持预办单）
        public static List<Model.WLB> ReadLocalByUID(SqlCommand cmd, string node, DateTime date, string uid)
        {
            List<Model.WLB> list = new List<Model.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [date] = @date AND [uid] = @uid AND [yd_type] <> 'R' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //查找运单-获取本站指定办单日期或承运日期运单
        public static List<Model.WLB> ReadLocalByDateOrCZRQ(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND ([date] = @date OR [cz_rq] = @date) AND [yd_type] <> 'R' AND [zt_type] <> 'F' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //查找运单-读取本站指定单号运单
        public static List<Model.WLB> ReadLocalBySN(SqlCommand cmd, string node, string sn)
        {
            List<Model.WLB> list = new List<Model.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [sn] = @sn AND [yd_type] <> 'R' AND [zt_type] <> 'F' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToWLB(rdr)); }
            }
            return list;
        }

        //查找运单-获取本站指定发货人电话运单
        public static List<Model.WLB> ReadLocalByFHR_Mobile(SqlCommand cmd, string node, string fhr_mobile)
        {
            List<Model.WLB> list = new List<Model.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [fhr_mobile] = @fhr_mobile AND [yd_type] <> 'R' AND [zt_type] <> 'F' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@fhr_mobile", SqlDbType.VarChar).Value = fhr_mobile;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //查找运单-获取本站指定发货人姓名运单
        public static List<Model.WLB> ReadLocalByFHR_Name(SqlCommand cmd, string node, string fhr_name)
        {
            List<Model.WLB> list = new List<Model.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [fhr_name] = @fhr_name AND [yd_type] <> 'R' AND [zt_type] <> 'F' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@fhr_name", SqlDbType.VarChar).Value = fhr_name;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //读取本站指定办单日期全部运单
        public static List<Model.WLB> ReadLocalByDate(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [date] = @date AND [yd_type] <> 'R' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //读取本站指定承运日期全部运单
        public static List<Model.WLB> ReadLocalByCZRQ(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

            //使用 [fh_code] 排序后的数据在同步车牌号时避免不必要的客运数据连接切换
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [cz_rq] = @date AND [yd_type] <> 'R' ORDER BY [fh_code], [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //读取中心指定承运日期全部运单
        public static List<Model.WLB> ReadCentralByCZRQ(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

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
        public static List<Model.WLB> ReadLocalUploadCentral(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

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

        //读取本站已冻结/未冻结运单
        public static List<Model.WLB> ReadLocalFreezeByCZRQ(SqlCommand cmd, string node, DateTime date, bool freeze)
        {
            List<Model.WLB> list = new List<Model.WLB>();
            if(freeze)
                cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [cz_rq] = @date AND [yd_type] = 'C' AND [zt_type] <> 'F' AND [freeze] = 'Y' ORDER BY [cdt]";
            else
                cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [cz_rq] = @date AND [yd_type] = 'S' AND [zt_type] <> 'F' AND [freeze] = 'N' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //---------------------------------------------------------------------------------------------------
        //报表专用
        //---------------------------------------------------------------------------------------------------
        //读取本站指定营运日期预办运单
        public static List<Model.WLB> ReadLocalAdvanceRecord(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [date] = @date AND [cz_rq] > @date AND [yd_type] <> 'R' AND [zt_type] <> 'F'ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //读取本站指定营运日期卸车运单
        public static List<Model.WLB> ReadLocalXCRecord(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [cz_rq] = @date AND [yd_type] = 'R' AND [zt_type] = 'X'ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        //读取本站指定营运日期取货运单
        public static List<Model.WLB> ReadLocalSHRecord(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [cz_rq] = @date AND [yd_type] = 'R' AND [zt_type] = 'S'ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }
        #endregion

        //------------------------------------------------------------------------------------
        //汇总功能
        //------------------------------------------------------------------------------------

        #region 汇总-获取车辆列表
        public static List<string> GetCollectCPHList(SqlCommand cmd, DateTime fromDate, DateTime toDate)
        {
            List<String> list = new List<String>();
            cmd.CommandText = "SELECT [cz_cph] FROM WLB WHERE [date] >= @fromDate AND [date] <= @toDate AND [yd_type] = 'C' GROUP BY [cz_cph] ORDER BY [cz_cph]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate;
            cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(rdr["cz_cph"].ToString()); }
            }
            return list;
        }
        #endregion

        #region 汇总-读取车辆运单
        public static List<Model.WLB> ReadCollectByCPH(SqlCommand cmd, string cph, DateTime fromDate, DateTime toDate)
        {
            List<Model.WLB> list = new List<Model.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [cz_cph] = @cz_cph AND [date] >= @fromDate AND [date] <= @toDate AND [yd_type] = 'C' ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cz_cph", SqlDbType.VarChar).Value = cph;
            cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate;
            cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToWLB(rdr)); }
            }

            return list;
        }
        #endregion

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

        public static Model.WLB ReadWaitingZCItem(SqlCommand cmd, string node, string sn)
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

        public static List<Model.WLB> ReadWaitingZCList(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

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

        public static List<Model.WLB> ReadAlreadyZCList(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

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

        public static Model.WLB ReadWaitingXCItem(SqlCommand cmd, string node, string sn)
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

        public static List<Model.WLB> ReadWaitingXCList(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

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

        public static List<Model.WLB> ReadAlreadyXCList(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

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

        public static Model.WLB ReadWaitingQHItem(SqlCommand cmd, string node, string sn)
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

        public static List<Model.WLB> ReadWaitingQHList(SqlCommand cmd, string node, DateTime date)
        {
            return ReadAlreadyXCList(cmd, node, date);
        }

        public static List<Model.WLB> ReadAlreadyQHList(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.WLB> list = new List<Model.WLB>();

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
