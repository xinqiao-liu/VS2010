using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public sealed class YFB
    {
        public static bool Exists(SqlCommand cmd, string name)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM [YFB] WHERE [name] = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, WLDataModelLayer.YFB item)
        {
            cmd.CommandText = "INSERT INTO [YFB] ([name], [bf], [bw], [weight], [excess], [factor], [sm], [em]) VALUES (@name, @bf, @bw, @weight, @excess, @factor, @sm, @em)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@bf", SqlDbType.Decimal).Value = item.BF;
            cmd.Parameters.Add("@bw", SqlDbType.Decimal).Value = item.BW;
            cmd.Parameters.Add("@weight", SqlDbType.Int).Value = item.Weight;
            cmd.Parameters.Add("@excess", SqlDbType.Decimal).Value = item.Excess;
            cmd.Parameters.Add("@factor", SqlDbType.Decimal).Value = item.Factor;
            cmd.Parameters.Add("@sm", SqlDbType.Int).Value = item.SM;
            cmd.Parameters.Add("@em", SqlDbType.Int).Value = item.EM;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string name)
        {
            cmd.CommandText = "DELETE FROM [YFB] WHERE [name] = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, string old_name, WLDataModelLayer.YFB item)
        {
            cmd.CommandText = "UPDATE YFB SET [name] = @name, [bf] = @bf, [bw] = @bw, [weight] = @weight, [excess] = @excess, [factor] = @factor, [sm] = @sm, [em] = @em  "
                + "WHERE [name] = @old_name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@bf", SqlDbType.Decimal).Value = item.BF;
            cmd.Parameters.Add("@bw", SqlDbType.Decimal).Value = item.BW;
            cmd.Parameters.Add("@weight", SqlDbType.Int).Value = item.Weight;
            cmd.Parameters.Add("@excess", SqlDbType.Decimal).Value = item.Excess;
            cmd.Parameters.Add("@factor", SqlDbType.Decimal).Value = item.Factor;
            cmd.Parameters.Add("@sm", SqlDbType.Int).Value = item.SM;
            cmd.Parameters.Add("@em", SqlDbType.Int).Value = item.EM;
            cmd.Parameters.Add("@old_name", SqlDbType.VarChar).Value = old_name;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static List<WLDataModelLayer.YFB> Reads(SqlCommand cmd)
        {
            List<WLDataModelLayer.YFB> list = new List<WLDataModelLayer.YFB>();

            cmd.CommandText = "SELECT * FROM YFB ORDER BY [id]";

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WLDataModelLayer.YFB item = new WLDataModelLayer.YFB();

                    item.Name = rdr["name"].ToString();
                    item.BF = Convert.ToDecimal(rdr["bf"]);
                    item.BW = Convert.ToDecimal(rdr["bw"]);
                    item.Weight = Convert.ToInt32(rdr["weight"]);
                    item.Excess = Convert.ToDecimal(rdr["excess"]);
                    item.Factor = Convert.ToDecimal(rdr["factor"]);
                    item.SM = Convert.ToInt32(rdr["sm"]);
                    item.EM = Convert.ToInt32(rdr["em"]);

                    list.Add(item);
                }
            }

            return list;
        }
    }
}
