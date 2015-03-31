using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class Customer
    {
        public static bool Exists(SqlCommand cmd, string tel)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM CUSTOMER WHERE [tel] = @tel";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Exists(SqlCommand cmd, string name, string tel)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM CUSTOMER WHERE [name] = @name AND [tel] = @tel";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, WLDataModelLayer.Customer c)
        {
            cmd.CommandText = "INSERT INTO CUSTOMER ([name], [tel], [address], [enable]) VALUES (@name, @tel, @address, @enable)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = c.Name;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = c.Tel;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = c.Address;
            cmd.Parameters.Add("@enable", SqlDbType.Char).Value = c.Enable ? "Y" : "N";

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string name, string tel)
        {
            cmd.CommandText = "DELETE FROM CUSTOMER WHERE [name] = @name AND [tel] = @tel";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, string old_name, string old_tel, WLDataModelLayer.Customer c)
        {
            cmd.CommandText = "UPDATE CUSTOMER SET [name] = @name, [tel] = @tel, [address] = @address, [enable] = @enable  WHERE [name] = @old_name AND [tel] = @old_tel";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = c.Name;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = c.Tel;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = c.Address;
            cmd.Parameters.Add("@enable", SqlDbType.Char).Value = c.Enable ? "Y" : "N";
            cmd.Parameters.Add("@old_name", SqlDbType.VarChar).Value = old_name;
            cmd.Parameters.Add("@old_tel", SqlDbType.VarChar).Value = old_tel;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<WLDataModelLayer.Customer> Reads(SqlCommand cmd)
        {
            List<WLDataModelLayer.Customer> list = new List<WLDataModelLayer.Customer>();

            cmd.CommandText = "SELECT * FROM CUSTOMER";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.Customer c = new WLDataModelLayer.Customer();

                    c.Name = rdr["name"].ToString();
                    c.Tel = rdr["tel"].ToString();
                    c.Address = rdr["address"].ToString();
                    c.Enable = Convert.ToChar(rdr["enable"]) == 'Y' ? true : false;

                    list.Add(c);
                }
            }
            return list;
        }

        public static string GetName(SqlCommand cmd, string tel)
        {
            cmd.CommandText = "SELECT [name] FROM [CUSTOMER] WHERE [tel] = @tel";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;

            return Convert.ToString(cmd.ExecuteScalar());
        }
    }
}
