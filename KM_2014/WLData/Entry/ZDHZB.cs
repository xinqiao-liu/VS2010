using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{    
    public static class ZDHZB
    {
        public static bool Exists(SqlCommand cmd, int year, int month, string code)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM ZDHZB WHERE [year] = @year AND [month] = @month AND [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.ZDHZB item)
        {
            cmd.CommandText = "INSERT INTO ZDHZB ([year], [month], [code], [count], [cars], [total], [money], [uid]) "
                + "VALUES (@year, @month, @code, @count, @cars, @total, @money, @uid)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = item.Code;
            cmd.Parameters.Add("@cars", SqlDbType.Int).Value = item.Cars;
            cmd.Parameters.Add("@count", SqlDbType.Int).Value = item.Count;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = item.Total;
            cmd.Parameters.Add("@money", SqlDbType.Decimal).Value = item.Money;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, int year, int month)
        {
            cmd.CommandText = "DELETE FROM ZDHZB WHERE [year] = @year AND [month] = @month";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<String> Reads(SqlCommand cmd)
        {
            List<String> list = new List<String>();

            cmd.CommandText = "SELECT [year], [month] FROM ZDHZB GROUP BY [year], [month] ORDER BY [year], [month]";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(rdr["year"].ToString() + ":" + rdr["month"].ToString().PadLeft(2, '0'));
                }
            }

            return list;
        }

        public static List<Model.ZDHZB> Reads(SqlCommand cmd, int year, int month)
        {
            List<Model.ZDHZB> list = new List<Model.ZDHZB>();

            cmd.CommandText = "SELECT z.[code], j.[name], z.[cars], z.[count], z.[total], z.[money], z.[uid], z.[cdt] "
                + "FROM ZDHZB z INNER JOIN JZDMB j ON z.[code] = j.[code] WHERE [year] = @year AND [month] = @month ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.ZDHZB item = new Model.ZDHZB();

                    item.Year = year;
                    item.Month = month;
                    item.Code = rdr["code"].ToString();
                    item.Name = rdr["name"].ToString();
                    item.Cars = Convert.ToInt32(rdr["cars"]);
                    item.Count = Convert.ToInt32(rdr["count"]);
                    item.Total = Convert.ToDecimal(rdr["total"]);
                    item.Money = Convert.ToDecimal(rdr["money"]);
                    item.UID = rdr["uid"].ToString();
                    item.CDT = Convert.ToDateTime(rdr["cdt"]);

                    list.Add(item);
                }
            }

            return list;
        }
    }
}
