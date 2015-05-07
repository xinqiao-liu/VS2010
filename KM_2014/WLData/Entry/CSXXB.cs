using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class CSXXB
    {
        private static Model.CSXXB ToCSXXB(SqlDataReader rdr)
        {
            Model.CSXXB item = new Model.CSXXB();

            item.CPH = rdr["cph"].ToString();
            item.Name = rdr["name"].ToString();
            item.Code = rdr["code"].ToString();
            item.Value = Convert.ToDecimal(rdr["value"]);
            item.Address = rdr["address"].ToString();
            item.Tel = rdr["tel"].ToString();

            return item;
        }

        public static bool Exists(SqlCommand cmd, string cph)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM CSXXB WHERE [cph] = @cph";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = cph;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.CSXXB item)
        {
            cmd.CommandText = "INSERT INTO CSXXB ([cph], [name], [code], [value], [address], [tel]) VALUES (@cph, @name, @code, @value, @address, @tel)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = item.CPH;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = item.Code;
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = item.Value;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = item.Address;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = item.Tel;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string cph)
        {
            cmd.CommandText = "DELETE FROM CSXXB WHERE [cph] = @cph";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = cph;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, string old_cph, Model.CSXXB item)
        {
            cmd.CommandText = "UPDATE CSXXB SET [cph] = @cph, [name] = @name, [code] = @code, [value] = @value, [address] = @address, [tel] = @tel  WHERE [cph] = @old_cph";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = item.CPH;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = item.Code;
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = item.Value;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = item.Address;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = item.Tel;
            cmd.Parameters.Add("@old_cph", SqlDbType.VarChar).Value = old_cph;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static Model.CSXXB Read(SqlCommand cmd, string cph)
        {
            cmd.CommandText = "SELECT * FROM CSXXB WHERE [cph] = @cph";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = cph;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return ToCSXXB(rdr);
            }
            return null;
        }

        public static List<Model.CSXXB> Reads(SqlCommand cmd)
        {
            List<Model.CSXXB> list = new List<Model.CSXXB>();

            cmd.CommandText = "SELECT * FROM CSXXB ORDER BY CPH";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToCSXXB(rdr));
                }
            }
            return list;
        }

        public static List<Model.CSXXB> Reads(SqlCommand cmd, string code)
        {
            List<Model.CSXXB> list = new List<Model.CSXXB>();

            cmd.CommandText = "SELECT * FROM CSXXB WHERE [code] = @code ORDER BY CPH";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToCSXXB(rdr));
                }
            }
            return list;
        }

        public static decimal GetValue(SqlCommand cmd, string cph)
        {
            cmd.CommandText = "SELECT [value] FROM CSXXB WHERE [cph] = @cph";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = cph;

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public static bool SetValue(SqlCommand cmd, string cph, decimal value)
        {
            cmd.CommandText = "UPDATE CSXXB SET [value] = @value WHERE [cph] = @cph";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = cph;
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = value;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static int GetCount(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM CSXXB WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
