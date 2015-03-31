using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class BZFLB
    {
        public static bool Update(SqlCommand cmd, WLDataModelLayer.BZFLB item)
        {
            cmd.CommandText = "UPDATE BZFLB SET [value] = @value WHERE [name] = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = item.Value;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<WLDataModelLayer.BZFLB> Reads(SqlCommand cmd)
        {
            List<WLDataModelLayer.BZFLB> list = new List<WLDataModelLayer.BZFLB>();

            cmd.CommandText = "SELECT [name], [value] FROM BZFLB ORDER BY [id]";

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.BZFLB item = new WLDataModelLayer.BZFLB();

                    item.Name = rdr["name"].ToString();
                    item.Value = Convert.ToDecimal(rdr["value"]);

                    list.Add(item);
                }
            }
            return list;
        }

        public static decimal GetValue(SqlCommand cmd, string name)
        {
            cmd.CommandText = "SELECT [value] FROM BZFLB WHERE [name] = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public static string GetName(SqlCommand cmd, decimal value)
        {
            cmd.CommandText = "SELECT [name] FROM BZFLB WHERE [value] = @value";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = value;

            return Convert.ToString(cmd.ExecuteScalar());
        }
    }
}
