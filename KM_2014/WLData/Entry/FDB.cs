using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class FDB
    {
        private static Model.FDB ToFDB(SqlDataReader rdr)
        {
            Model.FDB item = new Model.FDB();

            item.Node = rdr["node"].ToString();
            item.Date = Convert.ToDateTime(rdr["date"]);
            item.SN = rdr["sn"].ToString();
            item.UID = rdr["uid"].ToString();
            item.CDT = Convert.ToDateTime(rdr["cdt"]);

            return item;
        }

        public static bool Exists(SqlCommand cmd, string node, DateTime date, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM FDB WHERE [node] = @node AND [date] = @date AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.FDB item)
        {
            cmd.CommandText = "INSERT INTO FDB ([node], [date], [sn], [uid]) VALUES (@node, @date, @sn, @uid)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = item.Node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = item.SN;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<DateTime> GetDates(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();

            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [date] FROM FDB GROUP BY [date] ORDER BY [date] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [date] FROM FDB GROUP BY [date] ORDER BY [date] DESC";
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

        public static List<Model.FDB> Reads(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.FDB> list = new List<Model.FDB>();

            cmd.CommandText = "SELECT * FROM FDB WHERE [node] = @node AND [date] = @date ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToFDB(rdr));
                }
            }
            return list;
        }

        public static List<Model.FDB> ReadByUID(SqlCommand cmd, string node, DateTime date, string uid)
        {
            List<Model.FDB> list = new List<Model.FDB>();

            cmd.CommandText = "SELECT * FROM FDB WHERE [node] = @node AND [date] = @date AND [uid] = @uid ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToFDB(rdr));
                }
            }
            return list;
        }
    }
}
