using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class Setting
    {
        public static bool Exists(SqlCommand cmd, string id)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM SETTING WHERE [id] = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, WLDataModelLayer.Setting item)
        {
            cmd.CommandText = "UPDATE SETTING SET [value] = @value WHERE [id] = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = item.Id;
            cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = item.Value;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<WLDataModelLayer.Setting> Reads(SqlCommand cmd)
        {
            List<WLDataModelLayer.Setting> items = new List<WLDataModelLayer.Setting>();

            cmd.CommandText = "SELECT * FROM SETTING";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.Setting item = new WLDataModelLayer.Setting();

                    item.Id = rdr["id"].ToString();
                    item.Value = rdr["value"].ToString();

                    items.Add(item);
                }
            }

            return items;
        }
    }
}
