using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class ZDB
    {
        public static bool Exists(SqlCommand cmd, WLDataModelLayer.ZDB item)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM ZDB WHERE [year] = @year AND [month] = @month";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, WLDataModelLayer.ZDB item)
        {
            cmd.CommandText = "INSERT INTO ZDB ([year], [month], [name], [sdt], [edt], [uid]) "
                + "VALUES (@year, @month, @name, @sdt, @edt, @uid)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@sdt", SqlDbType.DateTime).Value = item.SDT;
            cmd.Parameters.Add("@edt", SqlDbType.DateTime).Value = item.EDT;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, WLDataModelLayer.ZDB item)
        {
            cmd.CommandText = "DELETE FROM ZDB WHERE [year] = @year AND [month] = @month";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<WLDataModelLayer.ZDB> Reads(SqlCommand cmd)
        {
            List<WLDataModelLayer.ZDB> list = new List<WLDataModelLayer.ZDB>();

            cmd.CommandText = "SELECT * FROM ZDB ORDER BY [cdt] DESC";

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.ZDB item = new WLDataModelLayer.ZDB();

                    item.Year = Convert.ToInt32(rdr["year"]);
                    item.Month = Convert.ToInt32(rdr["month"]);
                    item.Name = rdr["name"].ToString();
                    item.SDT = Convert.ToDateTime(rdr["sdt"]);
                    item.EDT = Convert.ToDateTime(rdr["edt"]);
                    item.UID = rdr["uid"].ToString();
                    item.CDT = Convert.ToDateTime(rdr["cdt"]);

                    list.Add(item);
                }
            }
            return list;
        }

        /// <summary>
        /// 获取结账明细记录
        /// 2014-09-22 修改为运单类型为‘S’，‘C’废弃
        /// </summary>
        /// <param name="cmd">SqlCommand对象</param>
        /// <param name="item">账单记录</param>
        /// <returns>返回结账明细</returns>
        public static List<WLDataModelLayer.ZDMXB> GetCheckoutMX(SqlCommand cmd, WLDataModelLayer.ZDB item)
        {
            List<WLDataModelLayer.ZDMXB> list = new List<WLDataModelLayer.ZDMXB>();

            cmd.CommandText = "SELECT [cz_cph] AS [cph], COUNT(*) AS [count], SUM(total) AS [total] "
                + "FROM WLB WHERE [date] >= @fromDate AND [date] <= @toDate AND [yd_type] <> 'R' AND [zt_type] <> 'F' "
                + "GROUP BY [cz_cph] ORDER BY [cz_cph] ";

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = item.SDT;
            cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = item.EDT;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.ZDMXB i = new WLDataModelLayer.ZDMXB();
                    i.Year = item.Year;
                    i.Month = item.Month;
                    i.Code = "";
                    i.CPH = rdr["cph"].ToString();
                    i.Count = Convert.ToInt32(rdr["count"]);
                    i.Total = Convert.ToDecimal(rdr["total"]);
                    i.Ratio = 0;
                    i.Money = 0;

                    list.Add(i);
                }
            }
            return list;
        }

        //获取结账汇总记录
        public static List<WLDataModelLayer.ZDHZB> GetCheckoutHZ(SqlCommand cmd, WLDataModelLayer.ZDB item, string userid)
        {
            List<WLDataModelLayer.ZDHZB> list = new List<WLDataModelLayer.ZDHZB>();

            cmd.CommandText = "SELECT [code], COUNT(*) AS [cars], SUM([count]) AS [count], SUM([total]) AS [total], SUM([money]) AS [money] "
                + " FROM ZDMXB WHERE [year] = @year AND [month] = @month GROUP BY [code] ORDER BY [code]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.ZDHZB i = new WLDataModelLayer.ZDHZB();
                    i.Year = item.Year;
                    i.Month = item.Month;
                    i.Code = rdr["code"].ToString();
                    i.Cars = Convert.ToInt32(rdr["cars"]);
                    i.Count = Convert.ToInt32(rdr["count"]);
                    i.Total = Convert.ToDecimal(rdr["total"]);
                    i.Money = Convert.ToDecimal(rdr["money"]);
                    i.UID = userid;

                    list.Add(i);
                }
            }

            return list;
        }
    }
}
