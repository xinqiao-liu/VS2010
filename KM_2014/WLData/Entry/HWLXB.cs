using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class HWLXB
    {
        public static bool Exists(SqlCommand cmd, string name)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM HWLXB WHERE [name] = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, string name)
        {
            cmd.CommandText = "INSERT INTO HWLXB ([name]) VALUES (@name)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string name)
        {
            cmd.CommandText = "DELETE FROM HWLXB WHERE [name] = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, string old_name, string new_name)
        {
            cmd.CommandText = "UPDATE HWLXB SET [name] = @new_name WHERE [name] = @old_name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@old_name", SqlDbType.VarChar).Value = old_name;
            cmd.Parameters.Add("@new_name", SqlDbType.VarChar).Value = new_name;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<Model.HWLXB> Reads(SqlCommand cmd)
        {
            List<Model.HWLXB> list = new List<Model.HWLXB>();

            cmd.CommandText = "SELECT [name] FROM HWLXB ORDER BY [id]";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.HWLXB item = new Model.HWLXB();

                    item.Name = rdr["name"].ToString();

                    list.Add(item);
                }
            }
            return list;
        }
    }
}
