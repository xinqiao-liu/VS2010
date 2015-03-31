using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class Payin
    {
        public static bool Exists(SqlCommand cmd, DateTime date, string userid)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM PAYIN WHERE [date] = @date AND [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, WLDataModelLayer.Payin item)
        {
            cmd.CommandText = "INSERT INTO PAYIN ([date], [userid], [bds], [fds], [tyf], [bzf], [bxf], [total], [money], [count], [uid]) "
                + "VALUES (@date, @userid, @bds, @fds, @tyf, @bzf, @bxf, @total, @money, @count, @uid)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = item.Userid;
            cmd.Parameters.Add("@bds", SqlDbType.Int).Value = item.BDS;
            cmd.Parameters.Add("@fds", SqlDbType.Int).Value = item.FDS;
            cmd.Parameters.Add("@tyf", SqlDbType.Decimal).Value = item.TYF;
            cmd.Parameters.Add("@bzf", SqlDbType.Decimal).Value = item.BZF;
            cmd.Parameters.Add("@bxf", SqlDbType.Decimal).Value = item.BXF;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = item.Total;
            cmd.Parameters.Add("@money", SqlDbType.Decimal).Value = item.Money;
            cmd.Parameters.Add("@count", SqlDbType.Int).Value = item.Count;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, DateTime date, string userid)
        {
            cmd.CommandText = "DELETE FROM PAYIN WHERE [date] = @date AND [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, WLDataModelLayer.Payin item)
        {
            cmd.CommandText = "UPDATE PAYIN SET [bds] = @bds, [fds] = @fds, [tyf] = @tyf, [bzf] = @bzf, [bxf] = @bxf, "
                + "[total] = @total, [money] = @money, [count] = [count] + 1, [uid] = @uid, [cdt] = getdate() WHERE  [date] = @date AND [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = item.Userid;
            cmd.Parameters.Add("@bds", SqlDbType.Int).Value = item.BDS;
            cmd.Parameters.Add("@fds", SqlDbType.Int).Value = item.FDS;
            cmd.Parameters.Add("@tyf", SqlDbType.Decimal).Value = item.TYF;
            cmd.Parameters.Add("@bzf", SqlDbType.Decimal).Value = item.BZF;
            cmd.Parameters.Add("@bxf", SqlDbType.Decimal).Value = item.BXF;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = item.Total;
            cmd.Parameters.Add("@money", SqlDbType.Decimal).Value = item.Money;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<DateTime> GetDates(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();

            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [date] FROM PAYIN GROUP BY [date] ORDER BY [date] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [date] FROM PAYIN GROUP BY [date] ORDER BY [date] DESC";
                    break;
                default:
                    throw new DataException("未指定有效排序顺序！");
            }  

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(Convert.ToDateTime(rdr["date"]));
                }
            }
            return list;
        }

        public static List<WLDataModelLayer.Payin> Reads(SqlCommand cmd, DateTime date)
        {
            List<WLDataModelLayer.Payin> list = new List<WLDataModelLayer.Payin>();

            cmd.CommandText = "SELECT * FROM PAYIN WHERE [date] = @date";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.Payin item = new WLDataModelLayer.Payin();

                    item.Date = date;
                    item.Userid = rdr["userid"].ToString();
                    item.BDS = Convert.ToInt32(rdr["bds"]);
                    item.FDS = Convert.ToInt32(rdr["fds"]);
                    item.TYF = Convert.ToDecimal(rdr["tyf"]);
                    item.BZF = Convert.ToDecimal(rdr["bzf"]);
                    item.BXF = Convert.ToDecimal(rdr["bxf"]);
                    item.Total = Convert.ToDecimal(rdr["total"]);
                    item.Money = Convert.ToDecimal(rdr["money"]);
                    item.Count = Convert.ToInt32(rdr["count"]);
                    item.UID = rdr["uid"].ToString();
                    item.CDT = Convert.ToDateTime(rdr["cdt"]);

                    list.Add(item);
                }
            }
            return list;
        }
    }
}
