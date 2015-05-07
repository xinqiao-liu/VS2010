using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class Mapping
    {
        public static bool Exists(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM MAPPING WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, string code, string value)
        {
            cmd.CommandText = "INSERT INTO MAPPING VALUES (@code, @value)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
            cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = value;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string code)
        {
            cmd.CommandText = "DELETE FROM MAPPING WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, string code, string value)
        {
            cmd.CommandText = "UPDATE MAPPING SET [value] = @value WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
            cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = value;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<Model.Mapping> Reads(SqlCommand cmd)
        {
            List<Model.Mapping> list = new List<Model.Mapping>();

            cmd.CommandText = "SELECT * FROM MAPPING ORDER BY [code]";
            cmd.Parameters.Clear();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.Mapping item = new Model.Mapping();

                    item.Code = rdr["code"].ToString();
                    item.Value = rdr["value"].ToString();

                    list.Add(item);
                }
            }
            return list;
        }
    }
}
