using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class ZDMXB
    {
        public static bool Exists(SqlCommand cmd, int year, int month, string code)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM ZDMXB WHERE [year] = @year AND [month] = @month AND [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.ZDMXB item)
        {
            cmd.CommandText = "INSERT INTO ZDMXB ([year], [month], [code], [cph], [count], [total], [ratio], [money]) "
                + "VALUES (@year, @month, @code, @cph, @count, @total, @ratio, @money)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = item.Year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = item.Month;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = item.Code;
            cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = item.CPH;
            cmd.Parameters.Add("@count", SqlDbType.Int).Value = item.Count;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = item.Total;
            cmd.Parameters.Add("@ratio", SqlDbType.Decimal).Value = item.Ratio;
            cmd.Parameters.Add("@money", SqlDbType.Decimal).Value = item.Money;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, int year, int month)
        {
            cmd.CommandText = "DELETE FROM ZDMXB WHERE [year] = @year AND [month] = @month";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<Model.ZDMXB> Reads(SqlCommand cmd, int year, int month, string code)
        {
            List<Model.ZDMXB> list = new List<Model.ZDMXB>();

            cmd.CommandText = "SELECT * FROM ZDMXB WHERE [year] = @year AND [month] = @month AND [code] = @code ORDER BY [cph]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.ZDMXB item = new Model.ZDMXB();

                    item.Year = year;
                    item.Month = month;
                    item.Code = code;
                    item.CPH = rdr["cph"].ToString();
                    item.Count = Convert.ToInt32(rdr["count"]);
                    item.Total = Convert.ToDecimal(rdr["total"]);
                    item.Ratio = Convert.ToDecimal(rdr["ratio"]);
                    item.Money = Convert.ToDecimal(rdr["money"]);

                    list.Add(item);
                }
            }

            return list;
        }
    }
}
