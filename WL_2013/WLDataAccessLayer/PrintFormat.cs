using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class PrintFormat
    {
        public static bool Update(SqlCommand cmd, WLDataModelLayer.PrintFormat format)
        {
            cmd.CommandText = "UPDATE PRINT_FORMAT SET [name] = @name, [x] = @x, [y] = @y, [font_name] = @font_name, [font_size] = @font_size, [font_mode] = @font_mode, [enable] = @enable "
                + "WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = format.Code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = format.Name;
            cmd.Parameters.Add("@x", SqlDbType.Int).Value = format.X;
            cmd.Parameters.Add("@y", SqlDbType.Int).Value = format.Y;
            cmd.Parameters.Add("@font_name", SqlDbType.VarChar).Value = format.FontName;
            cmd.Parameters.Add("@font_size", SqlDbType.Int).Value = format.FontSize;
            cmd.Parameters.Add("@font_mode", SqlDbType.VarChar).Value = format.FontMode;
            cmd.Parameters.Add("@enable", SqlDbType.Char).Value = format.Enable ? "Y" : "N";

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<WLDataModelLayer.PrintFormat> Reads(SqlCommand cmd)
        {
            List<WLDataModelLayer.PrintFormat> list = new List<WLDataModelLayer.PrintFormat>();

            cmd.CommandText = "SELECT * FROM PRINT_FORMAT ORDER BY [id]";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.PrintFormat format = new WLDataModelLayer.PrintFormat();

                    format.Code = rdr["code"].ToString();
                    format.Name = rdr["name"].ToString();
                    format.X = Convert.ToInt32(rdr["x"]);
                    format.Y = Convert.ToInt32(rdr["y"]);
                    format.FontName = rdr["font_name"].ToString();
                    format.FontSize = Convert.ToInt32(rdr["font_size"]);
                    format.FontMode = rdr["font_mode"].ToString();
                    format.Enable = Convert.ToChar(rdr["enable"]) == 'Y' ? true : false; ;

                    list.Add(format);
                }
            }
            return list;
        }
    }
}
