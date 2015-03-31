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
        //------------------------------------------------------------------------------------
        //基础功能
        //------------------------------------------------------------------------------------

        #region DataReader创建运单记录
        private static WLDataModelLayer.WLB ToWLB(SqlDataReader rdr)
        {
            WLDataModelLayer.WLB item = new WLDataModelLayer.WLB();

            item.Node = rdr["node"].ToString();
            item.Date = Convert.ToDateTime(rdr["date"]);
            item.SN = rdr["sn"].ToString();
            item.UID = rdr["uid"].ToString();
            item.CDT = Convert.ToDateTime(rdr["cdt"]);

            item.SK_Type = (WLDataModelLayer.SKType)Convert.ToChar(rdr["sk_type"]);
            item.YD_Type = (WLDataModelLayer.YDType)Convert.ToChar(rdr["yd_type"]);
            item.ZT_Type = (WLDataModelLayer.ZTType)Convert.ToChar(rdr["zt_type"]);

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
        private static void InitParameters(SqlParameterCollection parameters, WLDataModelLayer.WLB item)
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

        #region 检测运单
        /// <summary>
        /// 检查运单是否存在
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">日期</param>
        /// <param name="sn">运单编号</param>
        /// <returns>存在返回True，不存在返回False</returns>
        public static bool Exists(SqlCommand cmd, string node, DateTime date, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM WLB WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        /// <summary>
        /// 检查运单是否存在
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="sn">运单编号</param>
        /// <returns>存在返回True，不存在返回False</returns>
        public static bool Exists(SqlCommand cmd, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM WLB WHERE [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }
        #endregion

        #region 删除运单
        /// <summary>
        /// 删除运单
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">日期</param>
        /// <param name="sn">运单编号</param>
        /// <returns>成功返回True，失败返回False</returns>
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
        /// <summary>
        /// 插入运单
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="item">运单对象</param>
        /// <returns>成功返回True，失败返回False</returns>
        public static bool Insert(SqlCommand cmd, WLDataModelLayer.WLB item)
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
        /// <summary>
        /// 更新运单
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="item">运单对象</param>
        /// <returns>成功返回True，失败返回False</returns>
        public static bool Update(SqlCommand cmd, WLDataModelLayer.WLB item)
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
        /// <summary>
        /// 设置运单状态
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">日期</param>
        /// <param name="sn">运单编号</param>
        /// <param name="zt_type">状态类型</param>
        /// <returns>成功返回True，失败返回False</returns>
        public static bool SetZTType(SqlCommand cmd, string node, DateTime date, string sn, WLDataModelLayer.ZTType zt_type)
        {
            cmd.CommandText = "UPDATE WLB SET [zt_type] = @zt_type WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            cmd.Parameters.Add("@zt_type", SqlDbType.Char).Value = Convert.ToChar(zt_type);

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        /// <summary>
        /// 设置运单承运车牌号
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">日期</param>
        /// <param name="sn">运单编号</param>
        /// <param name="cz_cph">承运车牌号</param>
        /// <returns>成功返回True，失败返回False</returns>
        public static bool SetCZCPH(SqlCommand cmd, string node, DateTime date, string sn, string cz_cph)
        {
            cmd.CommandText = "UPDATE WLB SET [cz_cph] = @cz_cph WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            cmd.Parameters.Add("@cz_cph", SqlDbType.VarChar).Value = cz_cph;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
        #endregion

        //------------------------------------------------------------------------------------
        //常用功能
        //------------------------------------------------------------------------------------

        #region 获取数据
        /// <summary>
        /// 获取日期列表
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="nodecode">网点代码</param>
        /// <param name="mode">排序模式</param>
        /// <param name="top">选择前面几行，0选择全部</param>
        /// <returns>返回日期列表</returns>
        public static List<DateTime> GetDateList(SqlCommand cmd, string nodecode, SortOrder mode, int top)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [date] FROM WLB WHERE [node] = @node GROUP BY [date] ORDER BY [date] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [date] FROM WLB WHERE [node] = @node GROUP BY [date] ORDER BY [date] DESC";
                    break;
                default:
                    cmd.CommandText = "SELECT [date] FROM WLB WHERE [node] = @node GROUP BY [date]";
                    break;
            }
            if (top > 0) cmd.CommandText = cmd.CommandText.Insert(6, " TOP " + top.ToString() + " ");

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["date"]));
            }
            return list;
        }

        public static List<DateTime> GetDateList(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();
            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [date] FROM WLB GROUP BY [date] ORDER BY [date] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [date] FROM WLB GROUP BY [date] ORDER BY [date] DESC";
                    break;
                default:
                    cmd.CommandText = "SELECT [date] FROM WLB GROUP BY [date]";
                    break;
            }
            using (SqlDataReader rdr = cmd.ExecuteReader()) { while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["date"])); }

            return list;
        }

        /// <summary>
        /// 获取用户办单合计金额
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">日期</param>
        /// <param name="uid">用户编号</param>
        /// <returns>返回用户办单合计</returns>
        public static Decimal GetUserTotal(SqlCommand cmd, string node, DateTime date, string uid)
        {
            cmd.CommandText = "SELECT SUM(total) as Total FROM WLB WHERE [node] = @node AND [date] = @date AND [uid] = @uid AND [zt_type] <> 'F' GROUP BY [date], [uid]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid;

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        /// <summary>
        /// 2014-09-17 获取最小办单日期
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <returns>最小办单日期</returns>
        public static DateTime GetMinDate(SqlCommand cmd, string nodecode)
        {
            cmd.CommandText = "SELECT MIN(CDT) FROM [WLB] WHERE [node] = @node";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;

            return Convert.ToDateTime(cmd.ExecuteScalar()).Date;
        }

        /// <summary>
        /// 2014-09-17 获取最大办单日期
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <returns>最大办单日期</returns>
        public static DateTime GetMaxDate(SqlCommand cmd, string nodecode)
        {
            cmd.CommandText = "SELECT MAX(CDT) FROM [WLB] WHERE [node] = @node";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;

            return Convert.ToDateTime(cmd.ExecuteScalar()).Date;
        }

        /// <summary>
        /// 2014-09-18 获取汇总数据通过日期范围
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="minDate">起始日期</param>
        /// <param name="maxDate">截止日期</param>
        /// <returns>返回汇总数据</returns>
        public static List<WLDataModelLayer.CollectByDateRange> GetCollectByDateRange(SqlCommand cmd, string nodecode, DateTime minDate, DateTime maxDate)
        {
            List<WLDataModelLayer.CollectByDateRange> list = new List<WLDataModelLayer.CollectByDateRange>();
            cmd.CommandText = "SELECT date, COUNT(*) as counts, SUM(hw_js) as packages, SUM(total) as total FROM [wlserver].[dbo].[WLB] "
                + "where [node] = @node and [date] >= @minDate and [date] <= @maxDate GROUP BY [date] ORDER BY [date]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;
            cmd.Parameters.Add("@minDate", SqlDbType.DateTime).Value = minDate;
            cmd.Parameters.Add("@maxDate", SqlDbType.DateTime).Value = maxDate;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.CollectByDateRange item = new WLDataModelLayer.CollectByDateRange();
                    item.Date = Convert.ToDateTime(rdr["date"]);
                    item.Counts = Convert.ToInt32(rdr["counts"]);
                    item.Packages = Convert.ToInt32(rdr["packages"]);
                    item.Total = Convert.ToDecimal(rdr["total"]);
                    list.Add(item);
                }
            }
            return list;
        }

        /// <summary>
        /// 获取指定日期范围车辆列表
        /// 2014-09-22 运单类型改为‘S’，‘C’废弃，添加废单过滤
        /// 2014-09-22 改名 GetCollectCPHList->GetCPHList
        /// </summary>
        /// <param name="cmd">SqlCommand对象</param>
        /// <param name="fromDate">起始日期</param>
        /// <param name="toDate">截止日期</param>
        /// <returns>返回指定日期范围车辆列表</returns>
        public static List<string> GetCPHList(SqlCommand cmd, DateTime fromDate, DateTime toDate)
        {
            List<String> list = new List<String>();
            cmd.CommandText = "SELECT [cz_cph] FROM WLB WHERE [date] >= @fromDate AND [date] <= @toDate AND [yd_type] <> 'R' AND [zt_type] <> 'F' "
                + "GROUP BY [cz_cph] ORDER BY [cz_cph]";
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

        #region 读取运单

        /// <summary>
        /// 读取本站指定单号运单（本地改单废单时使用）
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="sn">运单编号</param>
        /// <returns>读取本站指定单号运单</returns>        
        public static WLDataModelLayer.WLB Read(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return ToWLB(rdr);
            }
            return null;
        }

        /// <summary>
        /// 2014-09-17 读取指定日期运单列表
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">办单日期</param>
        /// <returns>返回指定日期运单列表</returns>
        public static List<WLDataModelLayer.WLB> ReadByDate(SqlCommand cmd, string nodecode, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [date] = @date ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        /// <summary>
        /// 查找运单-读取指定单号运单列表
        /// 2014-09-23 删除运单类型、运单状态等查询条件，取消按创建日期排序
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="sn">运单编号</param>
        /// <returns>返回指定编号运单列表</returns>        
        public static List<WLDataModelLayer.WLB> ReadBySN(SqlCommand cmd, string nodecode, string sn)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        /// <summary>
        /// 查找运单-获取指定发货人电话运单列表
        /// 2014-09-23 删除运单类型、运单状态等查询条件
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="nodecode">网点代码</param>
        /// <param name="fhr_mobile">发货人电话</param>
        /// <returns>返回指定发货人电话运单</returns>
        public static List<WLDataModelLayer.WLB> ReadByFHRTel(SqlCommand cmd, string nodecode, string fhr_tel)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [fhr_mobile] = @fhr_mobile ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;
            cmd.Parameters.Add("@fhr_mobile", SqlDbType.VarChar).Value = fhr_tel;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        /// <summary>
        /// 查找运单-获取指定发货人姓名运单
        /// 2014-09-23 删除运单类型、运单状态等查询条件
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="nodecode">网点代码</param>
        /// <param name="fhr_name">发货人姓名</param>
        /// <returns>返回指定发货人姓名运单列表</returns>
        public static List<WLDataModelLayer.WLB> ReadByFHRName(SqlCommand cmd, string nodecode, string fhr_name)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [fhr_name] = @fhr_name ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;
            cmd.Parameters.Add("@fhr_name", SqlDbType.VarChar).Value = fhr_name;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        /// <summary>
        /// 获取指定用户运单列表（包含废单）
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">日期</param>
        /// <param name="uid">用户编号</param>
        /// <returns>返回指定用户运单</returns>
        public static List<WLDataModelLayer.WLB> ReadByUID(SqlCommand cmd, string node, DateTime date, string uid)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [date] = @date AND [uid] = @uid ORDER BY [cdt]";
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

        /// <summary>
        /// 读取指定承运日期运单列表
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">承运日期</param>
        /// <returns>返回指定承运日期运单列表</returns>
        public static List<WLDataModelLayer.WLB> ReadByCZRQ(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            //使用 [fh_code] 排序后的数据在同步车牌号时避免不必要的客运数据连接切换
            cmd.CommandText = "SELECT * FROM WLB WHERE [node] = @node AND [cz_rq] = @date ORDER BY [fh_code], [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToWLB(rdr));
            }
            return list;
        }

        /// <summary>
        /// 读取指定车牌号及日期运单列表
        /// 2014-09-22 运单类型改为‘S’，‘C’废弃，添加废单过滤
        /// 2014-09-22 改名 ReadCollectByCPH->ReadByCPHAndDateRange
        /// </summary>
        /// <param name="cmd">SqlCommand对象</param>
        /// <param name="cph">车牌号</param>
        /// <param name="fromDate">起始日期</param>
        /// <param name="toDate">截止日期</param>
        /// <returns>返回指定车牌号及日期运单列表</returns>
        public static List<WLDataModelLayer.WLB> ReadByCPHAndDateRange(SqlCommand cmd, string cph, DateTime fromDate, DateTime toDate)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();

            cmd.CommandText = "SELECT * FROM WLB WHERE [cz_cph] = @cz_cph AND [date] >= @fromDate AND [date] <= @toDate AND [yd_type] <> 'R' AND [zt_type] <> 'F' "
                + "ORDER BY [cdt]";
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

        //---------------------------------------------------------------------------------------------------
        //报表专用
        //---------------------------------------------------------------------------------------------------
        //读取本站指定营运日期预办运单
        public static List<WLDataModelLayer.WLB> ReadLocalAdvanceRecord(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();
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
        public static List<WLDataModelLayer.WLB> ReadLocalXCRecord(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();
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
        public static List<WLDataModelLayer.WLB> ReadLocalSHRecord(SqlCommand cmd, string node, DateTime date)
        {
            List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();
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

        /// <summary>
        /// 生成日报表
        /// </summary>
        /// <param name="cmd">SQLCommand 对象</param>
        /// <param name="node">网点代码</param>
        /// <param name="date">生成日期</param>
        /// <returns>返回日报表</returns>
        public static WLDataModelLayer.DailyReport CreateDailyReport(SqlCommand cmd, string nodecode, DateTime date)
        {
            WLDataModelLayer.DailyReport item = new WLDataModelLayer.DailyReport();
            item.Date = date;
            item.NodeCode = nodecode;

            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = nodecode;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.CommandText = "SELECT COUNT(*) AS Counts, SUM(hw_js) AS Packages, SUM(total) AS Total FROM WLB "
                + " WHERE [node] = @node AND [date] = @date AND [date] = [cz_rq] AND [zt_type] <> 'F' GROUP BY [node], [date]";
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
                + " WHERE [node] = @node AND [date] = @date AND [date] < [cz_rq] AND [zt_type] <> 'F' GROUP BY [node], [date]";
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

        /// <summary>
        /// 读取日报表
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<WLDataModelLayer.ReportDay> ReadReport(SqlCommand cmd, DateTime date)
        {
            List<WLDataModelLayer.ReportDay> list = new List<WLDataModelLayer.ReportDay>();
            cmd.CommandText = "SELECT WLB.[node] AS nodecode, NODE.[name] AS nodename, COUNT(*) AS counts, SUM(WLB.[hw_js]) AS packages, SUM(WLB.[total]) AS total "
                + "FROM WLB left outer join NODE on WLB.[node] = NODE.[code] "
                + "WHERE WLB.[date] = @date AND WLB.[zt_type] <> 'F' "
                + "GROUP BY WLB.[node], NODE.[name] "
                + "ORDER BY WLB.[node] ";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.ReportDay item = new WLDataModelLayer.ReportDay();
                    item.NodeCode = rdr["nodecode"].ToString();
                    item.NodeName = rdr["nodename"].ToString();
                    item.Counts = Convert.ToInt32(rdr["counts"]);
                    item.Packages = Convert.ToInt32(rdr["packages"]);
                    item.Total = Convert.ToDecimal(rdr["total"]);

                    list.Add(item);
                }
            }
            return list;
        }

        /// <summary>
        /// 读取月报表
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="SD"></param>
        /// <param name="ED"></param>
        /// <returns></returns>
        public static List<WLDataModelLayer.ReportMonth> ReadReport(SqlCommand cmd, DateTime fromDate, DateTime toDate)
        {
            List<WLDataModelLayer.ReportMonth> list = new List<WLDataModelLayer.ReportMonth>();
            cmd.CommandText = "SELECT WLB.[date] AS date, WLB.[node] AS nodecode, NODE.[name] AS nodename, COUNT(*) AS counts, SUM(WLB.[hw_js]) AS packages, SUM(WLB.[total]) AS total "
                + "FROM WLB left outer join NODE on WLB.[node] = NODE.[code] "
                + "WHERE WLB.[date] >= @fromdate AND WLB.[date] <= @todate AND WLB.[zt_type] <> 'F' "
                + "GROUP BY WLB.[date], WLB.[node], NODE.[name] "
                + "ORDER BY WLB.[date], WLB.[node] ";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@fromdate", SqlDbType.DateTime).Value = fromDate;
            cmd.Parameters.Add("@todate", SqlDbType.DateTime).Value = toDate;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.ReportMonth item = new WLDataModelLayer.ReportMonth();
                    item.Date = Convert.ToDateTime(rdr["date"]);
                    item.NodeCode = rdr["nodecode"].ToString();
                    item.NodeName = rdr["nodename"].ToString();
                    item.Counts = Convert.ToInt32(rdr["counts"]);
                    item.Packages = Convert.ToInt32(rdr["packages"]);
                    item.Total = Convert.ToDecimal(rdr["total"]);

                    list.Add(item);
                }
            }
            return list;
        }
    }
}
