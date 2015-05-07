using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class WLT
    {
        public static bool Exists(SqlCommand cmd, string node, string sn)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM [WLT] WHERE [node] = @node AND [sn] = @sn";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.WLT item)
        {
            cmd.CommandText = "INSERT INTO WLT ([node] ,[date] ,[sn] ,[content]) VALUES (@node, @date, @sn, @content)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = item.Node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = item.SN;
            cmd.Parameters.Add("@content", SqlDbType.VarChar).Value = item.Content;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<Model.WLT> Reads(SqlCommand cmd, string node, DateTime date, string sn)
        {
            List<Model.WLT> list = new List<Model.WLT>();

            cmd.CommandText = "SELECT * FROM WLT WHERE [node] = @node AND [date] = @date AND [sn] = @sn ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.WLT item = new Model.WLT();

                    item.Node = rdr["node"].ToString();
                    item.Date = Convert.ToDateTime(rdr["date"]);
                    item.SN = rdr["sn"].ToString();
                    item.Content = rdr["content"].ToString();
                    item.CDT = Convert.ToDateTime(rdr["cdt"]);

                    list.Add(item);
                }
            }
            return list;
        }

        public static List<Model.WLT> Reads(SqlCommand cmd, string node, string sn)
        {
            List<Model.WLT> list = new List<Model.WLT>();

            cmd.CommandText = "SELECT * FROM WLT WHERE [node] = @node AND [sn] = @sn ORDER BY [cdt]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@node", SqlDbType.VarChar).Value = node;
            cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = sn;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.WLT item = new Model.WLT();

                    item.Node = rdr["node"].ToString();
                    item.Date = Convert.ToDateTime(rdr["date"]);
                    item.SN = rdr["sn"].ToString();
                    item.Content = rdr["content"].ToString();
                    item.CDT = Convert.ToDateTime(rdr["cdt"]);

                    list.Add(item);
                }
            }
            return list;
        }
    }
}
