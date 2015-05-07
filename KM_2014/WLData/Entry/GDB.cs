using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class GDB
    {
        private static Model.GDB ToGDB(SqlDataReader rdr)
        {
            Model.GDB item = new Model.GDB();

            item.Node = rdr["node"].ToString();
            item.Date = Convert.ToDateTime(rdr["date"]);
            item.SN = rdr["sn"].ToString();
            item.OldCPH = rdr["old_cph"].ToString();
            item.OldRQ = Convert.ToDateTime(rdr["old_rq"]);
            item.OldBC = rdr["old_bc"].ToString();
            item.NewCPH = rdr["new_cph"].ToString();
            item.NewRQ = Convert.ToDateTime(rdr["new_rq"]);
            item.NewBC = rdr["new_bc"].ToString();
            item.RecordType = rdr["record_type"].ToString();
            item.UID = rdr["uid"].ToString();
            item.CDT = Convert.ToDateTime(rdr["cdt"]);
            return item;
        }

        public static bool Exists(SqlCommand cmd, string node, DateTime date, string sn, string old_cph, string new_cph)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM GDB WHERE [node] = @node AND [date] = @date AND [sn] = @sn AND [old_cph] = @old_cph AND [new_cph] = @new_cph";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            cmd.Parameters.Add("@old_cph", SqlDbType.VarChar).Value = old_cph;
            cmd.Parameters.Add("@new_cph", SqlDbType.VarChar).Value = new_cph;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.GDB item)
        {
            cmd.CommandText = "INSERT INTO GDB ([node], [date], [sn], [old_cph], [old_rq], [old_bc], [new_cph], [new_rq], [new_bc], [record_type], [uid]) "
                + " VALUES (@node, @date, @sn, @old_cph, @old_rq, @old_bc, @new_cph, @new_rq, @new_bc, @record_type, @uid)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = item.Node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = item.SN;
            cmd.Parameters.Add("@old_cph", SqlDbType.VarChar).Value = item.OldCPH;
            cmd.Parameters.Add("@old_rq", SqlDbType.DateTime).Value = item.OldRQ;
            cmd.Parameters.Add("@old_bc", SqlDbType.VarChar).Value = item.OldBC;
            cmd.Parameters.Add("@new_cph", SqlDbType.VarChar).Value = item.NewCPH;
            cmd.Parameters.Add("@new_rq", SqlDbType.DateTime).Value = item.NewRQ;
            cmd.Parameters.Add("@new_bc", SqlDbType.VarChar).Value = item.NewBC;
            cmd.Parameters.Add("@record_type", SqlDbType.Char).Value = item.RecordType;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = item.UID;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<DateTime> GetDates(SqlCommand cmd, SortOrder mode)
        {
            List<DateTime> list = new List<DateTime>();

            switch (mode)
            {
                case SortOrder.Ascending:
                    cmd.CommandText = "SELECT [date] FROM GDB GROUP BY [date] ORDER BY [date] ASC";
                    break;
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT [date] FROM GDB GROUP BY [date] ORDER BY [date] DESC";
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

        public static List<Model.GDB> Reads(SqlCommand cmd, string node, DateTime date)
        {
            List<Model.GDB> list = new List<Model.GDB>();

            cmd.CommandText = "SELECT * FROM GDB WHERE [node] = @node AND [date] = @date ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToGDB(rdr));
                }
            }
            return list;
        }

        public static List<Model.GDB> ReadByUID(SqlCommand cmd, string node, DateTime date, string uid)
        {
            List<Model.GDB> list = new List<Model.GDB>();

            cmd.CommandText = "SELECT * FROM GDB WHERE [node] = @node AND [date] = @date AND [uid] = @uid ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToGDB(rdr));
                }
            }
            return list;
        }

        public static List<Model.GDB> ReadByRecordType(SqlCommand cmd, string node, DateTime date, string record_type)
        {
            List<Model.GDB> list = new List<Model.GDB>();

            cmd.CommandText = "SELECT * FROM GDB WHERE [node] = @node AND [date] = @date AND [record_type] = @record_type ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@record_type", SqlDbType.VarChar).Value = record_type;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToGDB(rdr));
                }
            }
            return list;
        }
    }
}
