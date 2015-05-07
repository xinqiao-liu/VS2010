using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class EndOfDay
    {
        private static Model.EndOfDay ToEndOfDay(SqlDataReader rdr)
        {
            Model.EndOfDay item = new Model.EndOfDay();

            item.Date = Convert.ToDateTime(rdr["date"]);
            item.UID = rdr["uid"].ToString();
            item.CDT = Convert.ToDateTime(rdr["cdt"]);

            return item;
        }

        public static bool Exists(SqlCommand cmd, DateTime date)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM EndOfDay WHERE [date] = @date";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.EndOfDay item)
        {
            cmd.CommandText = "INSERT INTO EndOfDay ([date], [uid]) VALUES (@date, @uid)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<DateTime> GetDates(SqlCommand cmd)
        {
            List<DateTime> list = new List<DateTime>();

            cmd.CommandText = "SELECT [date] FROM EndOfDay GROUP BY [date] ORDER BY [date] DESC";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(Convert.ToDateTime(rdr["date"]));
                }
            }
            return list;
        }

        public static List<Model.EndOfDay> Reads(SqlCommand cmd, DateTime date)
        {
            List<Model.EndOfDay> list = new List<Model.EndOfDay>();

            cmd.CommandText = "SELECT * FROM EndOfDay WHERE [date] = @date ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToEndOfDay(rdr));
                }
            }
            return list;
        }
    }
}
