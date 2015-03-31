using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class JZDMB
    {
        private static WLDataModelLayer.JZDMB ToJZDMB(SqlDataReader rdr)
        {
            WLDataModelLayer.JZDMB item = new WLDataModelLayer.JZDMB();

            item.Code = rdr["code"].ToString();
            item.Name = rdr["name"].ToString();
            item.Value = Convert.ToDecimal(rdr["value"]);
            item.Mode = (WLDataModelLayer.JZMode) rdr["mode"];
            item.Address = rdr["address"].ToString();
            item.Tel = rdr["tel"].ToString();

            return item;
        }

        public static bool Exists(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM JZDMB WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, WLDataModelLayer.JZDMB item)
        {
            cmd.CommandText = "INSERT INTO JZDMB ([code], [name], [value], [mode], [address], [tel]) VALUES (@code, @name, @value, @mode, @address, @tel)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = item.Code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = item.Value;
            cmd.Parameters.Add("@mode", SqlDbType.Int).Value =  Convert.ToInt32(item.Mode);
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = item.Address;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = item.Tel;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd)
        {
            cmd.CommandText = "DELETE FROM JZDMB";
            cmd.Parameters.Clear();

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string code)
        {
            cmd.CommandText = "DELETE FROM JZDMB WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, string old_code, WLDataModelLayer.JZDMB item)
        {
            cmd.CommandText = "UPDATE JZDMB SET [code] = @code, [name] = @name, [value] = @value, [mode] = @mode, [address] = @address, [tel] = @tel WHERE [code] = @old_code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = item.Code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = item.Value;
            cmd.Parameters.Add("@mode", SqlDbType.Int).Value = Convert.ToInt32(item.Mode);
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = item.Address;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = item.Tel;

            cmd.Parameters.Add("@old_code", SqlDbType.VarChar).Value = old_code;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static WLDataModelLayer.JZDMB Read(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT * FROM JZDMB WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return ToJZDMB(rdr);
            }
            return null;
        }


        public static List<WLDataModelLayer.JZDMB> Reads(SqlCommand cmd)
        {
            List<WLDataModelLayer.JZDMB> list = new List<WLDataModelLayer.JZDMB>();

            cmd.CommandText = "SELECT * FROM JZDMB";
            cmd.Parameters.Clear();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToJZDMB(rdr)); }
            }
            return list;
        }

        public static List<WLDataModelLayer.JZCPH> Read_JZCPH(SqlCommand cmd)
        {
            List<WLDataModelLayer.JZCPH> list = new List<WLDataModelLayer.JZCPH>();

            cmd.CommandText = "SELECT JZDMB.code as code, JZDMB.name as name, CSXXB.cph as cph, CSXXB.name as owner FROM [CSXXB] "
                + "left join [JZDMB] on CSXXB.code = JZDMB.code ORDER BY code, cph";
            cmd.Parameters.Clear();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.JZCPH item = new WLDataModelLayer.JZCPH();
                    item.Code = rdr["code"].ToString();
                    item.Name = rdr["name"].ToString();
                    item.CPH = rdr["cph"].ToString();
                    item.Owner = rdr["owner"].ToString();
                    list.Add(item);
                }
            }
            return list;
        }

        public static decimal GetValue(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT [value] FROM JZDMB WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public static bool SetValue(SqlCommand cmd, string code, decimal value)
        {
            cmd.CommandText = "UPDATE JZDMB SET [value] = @value WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = value;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
    }
}
