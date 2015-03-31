using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class DailyReport
    {
        public static WLDataModelLayer.DailyReport ToDailySheet(SqlDataReader rdr)
        {
            WLDataModelLayer.DailyReport item = new WLDataModelLayer.DailyReport();

            item.Date = Convert.ToDateTime(rdr["date"]);
            item.NodeCode = rdr["nodecode"].ToString();
            item.NodeName = rdr["nodename"].ToString();
            item.Counts1 = Convert.ToInt32(rdr["counts1"]);
            item.Packages1 = Convert.ToInt32(rdr["packages1"]);
            item.Total1 = Convert.ToDecimal(rdr["total1"]);
            item.Counts2 = Convert.ToInt32(rdr["counts2"]);
            item.Packages2 = Convert.ToInt32(rdr["packages2"]);
            item.Total2 = Convert.ToDecimal(rdr["total2"]);
            item.UID = rdr["uid"].ToString();
            item.CDT = Convert.ToDateTime(rdr["cdt"]);

            return item;
        }

        public static bool Exists(SqlCommand cmd, WLDataModelLayer.DailyReport item)
        {
            return Exists(cmd, item.Date, item.NodeCode);
        }

        public static bool Exists(SqlCommand cmd, DateTime date, string nodecode)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM DailySheet WHERE [date] = @date AND [nodecode] = @nodecode";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@nodecode", SqlDbType.VarChar).Value = nodecode;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, WLDataModelLayer.DailyReport item)
        {
            return Delete(cmd, item.Date, item.NodeCode);
        }

        public static bool Delete(SqlCommand cmd, DateTime date, string nodecode)
        {
            cmd.CommandText = "DELETE FROM DailySheet WHERE [date] = @date AND [nodecode] = @nodecode";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@nodecode", SqlDbType.VarChar).Value = nodecode;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, WLDataModelLayer.DailyReport item)
        {
            cmd.CommandText = "INSERT INTO DailySheet ([date], [nodecode], [nodename], [counts1], [packages1], [total1], [counts2], [packages2], [total2], [counts], [packages], [total], [uid]) "
                + "VALUES (@date, @nodecode, @nodename, @counts1, @packages1, @total1, @counts2, @packages2, @total2, @counts, @packages, @total, @uid)";

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            cmd.Parameters.Add("@nodecode", SqlDbType.VarChar).Value = item.NodeCode;
            cmd.Parameters.Add("@nodename", SqlDbType.VarChar).Value = item.NodeName;

            cmd.Parameters.Add("@counts1", SqlDbType.Int).Value = item.Counts1;
            cmd.Parameters.Add("@packages1", SqlDbType.Int).Value = item.Packages1;
            cmd.Parameters.Add("@total1", SqlDbType.Decimal).Value = item.Total1;
            cmd.Parameters.Add("@counts2", SqlDbType.Int).Value = item.Counts2;
            cmd.Parameters.Add("@packages2", SqlDbType.Int).Value = item.Packages2;
            cmd.Parameters.Add("@total2", SqlDbType.Decimal).Value = item.Total2;
            cmd.Parameters.Add("@counts", SqlDbType.Int).Value = item.Counts;
            cmd.Parameters.Add("@packages", SqlDbType.Int).Value = item.Packages;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = item.Total;
            
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, WLDataModelLayer.DailyReport item)
        {
            cmd.CommandText = "UPDATE DailySheet SET [nodename] = @nodename, [counts1] = @counts1, [packages1] = @packages1, [total1] = @total1, "
                + "[counts2] = @counts2, [packages2] = @packages2, [total2] = @total2, [counts] = @counts, [packages] = @packages, [total] = @total, [uid] = @uid "
                + "WHERE [date] = @date AND [nodecode] = @nodecode";

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            cmd.Parameters.Add("@nodecode", SqlDbType.VarChar).Value = item.NodeCode;
            cmd.Parameters.Add("@nodename", SqlDbType.VarChar).Value = item.NodeName;

            cmd.Parameters.Add("@counts1", SqlDbType.Int).Value = item.Counts1;
            cmd.Parameters.Add("@packages1", SqlDbType.Int).Value = item.Packages1;
            cmd.Parameters.Add("@total1", SqlDbType.Decimal).Value = item.Total1;
            cmd.Parameters.Add("@counts2", SqlDbType.Int).Value = item.Counts2;
            cmd.Parameters.Add("@packages2", SqlDbType.Int).Value = item.Packages2;
            cmd.Parameters.Add("@total2", SqlDbType.Decimal).Value = item.Total2;
            cmd.Parameters.Add("@counts", SqlDbType.Int).Value = item.Counts;
            cmd.Parameters.Add("@packages", SqlDbType.Int).Value = item.Packages;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = item.Total;

            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<DateTime> GetDates(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();

            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [date] FROM DailySheet GROUP BY [date] ORDER BY [date] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [date] FROM DailySheet GROUP BY [date] ORDER BY [date] DESC";
                    break;
                default:
                    throw new DataException("未指定有效排序顺序！");
            }   

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(Convert.ToDateTime(rdr["date"]));
            }
            return list;
        }

        public static WLDataModelLayer.DailyReport Read(SqlCommand cmd, string nodecode, DateTime date)
        {
            cmd.CommandText = "SELECT * FROM DailySheet WHERE [date] = @date AND [nodecode] = @nodecode";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nodecode", SqlDbType.VarChar).Value = nodecode;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return ToDailySheet(rdr);
            }
            return null;
        }


        public static List<WLDataModelLayer.DailyReport> Reads(SqlCommand cmd, DateTime date)
        {
            List<WLDataModelLayer.DailyReport> list = new List<WLDataModelLayer.DailyReport>();

            cmd.CommandText = "SELECT * FROM DailySheet WHERE [date] = @date ORDER BY [nodecode]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) list.Add(ToDailySheet(rdr));
            }
            return list;
        }
    }
}
