using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class Authorize
    {
        public static bool Exists(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM AUTHORIZE WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.Authorize item)
        {
            cmd.CommandText = "INSERT INTO AUTHORIZE VALUES (@code, @name, @citycode, @cityname, @content)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = item.Code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@citycode", SqlDbType.VarChar).Value = item.CityCode;
            cmd.Parameters.Add("@cityname", SqlDbType.VarChar).Value = item.CityName;
            cmd.Parameters.Add("@content", SqlDbType.Binary).Value = item.Content;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string code)
        {
            cmd.CommandText = "DELETE FROM AUTHORIZE WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static Model.Authorize Read(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT * FROM AUTHORIZE WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    return new Model.Authorize(
                        rdr["code"].ToString(),
                        rdr["name"].ToString(),
                        rdr["citycode"].ToString(),
                        rdr["cityname"].ToString(),
                        rdr.GetSqlBinary(4)
                        );
                }
            }
            return null;
        }

        public static List<Model.Authorize> Reads(SqlCommand cmd)
        {
            List<Model.Authorize> list = new List<Model.Authorize>();

            cmd.CommandText = "SELECT * FROM AUTHORIZE ORDER BY [code]";
            cmd.Parameters.Clear();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Model.Authorize item = new Model.Authorize(
                        rdr["code"].ToString(),
                        rdr["name"].ToString(),
                        rdr["citycode"].ToString(),
                        rdr["cityname"].ToString(),
                        rdr.GetSqlBinary(4)
                        );

                    list.Add(item);
                }
            }
            return list;
        }

        public static System.Data.SqlTypes.SqlBinary GetContent(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT [content] FROM AUTHORIZE WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return new System.Data.SqlTypes.SqlBinary((System.Byte[])cmd.ExecuteScalar());
        }

        public static bool SetContent(SqlCommand cmd, string code, System.Data.SqlTypes.SqlBinary content)
        {
            cmd.CommandText = "UPDATE AUTHORIZE SET [content] = @content WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
            cmd.Parameters.Add("@content", SqlDbType.Binary).Value = content;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
    }
}
