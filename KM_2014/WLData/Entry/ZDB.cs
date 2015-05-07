using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class ZDB
    {
        public static bool Exists(SqlCommand cmd, Model.ZDB item)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM ZDB WHERE [year] = @year AND [month] = @month";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.ZDB item)
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

        public static bool Delete(SqlCommand cmd, Model.ZDB item)
        {
            cmd.CommandText = "DELETE FROM ZDB WHERE [year] = @year AND [month] = @month";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<Model.ZDB> Reads(SqlCommand cmd)
        {
            List<Model.ZDB> list = new List<Model.ZDB>();

            cmd.CommandText = "SELECT * FROM ZDB ORDER BY [cdt] DESC";

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.ZDB item = new Model.ZDB();

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

        //获取结账明细记录
        public static List<Model.ZDMXB> GetCheckoutMX(SqlCommand cmd, Model.ZDB item)
        {
            List<Model.ZDMXB> list = new List<Model.ZDMXB>();

            cmd.CommandText = "SELECT [cz_cph] AS [cph], COUNT(*) AS [count], SUM(total) AS [total] "
                + " FROM WLB WHERE [date] >= @fromDate AND [date] <= @toDate AND [yd_type] = 'C' AND [zt_type] <> 'F' GROUP BY [cz_cph] ORDER BY [cz_cph] ";

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = item.SDT;
            cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = item.EDT;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.ZDMXB i = new Model.ZDMXB();
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
        public static List<Model.ZDHZB> GetCheckoutHZ(SqlCommand cmd, Model.ZDB item, string userid)
        {
            List<Model.ZDHZB> list = new List<Model.ZDHZB>();

            cmd.CommandText = "SELECT [code], COUNT(*) AS [cars], SUM([count]) AS [count], SUM([total]) AS [total], SUM([money]) AS [money] "
                + " FROM ZDMXB WHERE [year] = @year AND [month] = @month GROUP BY [code] ORDER BY [code]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.ZDHZB i = new Model.ZDHZB();
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
