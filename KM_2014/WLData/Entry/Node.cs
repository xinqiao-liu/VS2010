using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class Node
    {
        //读取器输出网点信息
        private static Model.Node ToNode(SqlDataReader rdr)
        {
            Model.Node node = new Model.Node();
            node.Code = rdr["code"].ToString();
            node.Name = rdr["name"].ToString();
            node.CityCode = rdr["citycode"].ToString();
            node.CityName = rdr["cityname"].ToString();
            node.Enable = Convert.ToChar(rdr["enable"]) == 'Y' ? true : false; ;
            node.Address = rdr["address"].ToString();
            node.Tel = rdr["tel"].ToString();
            return node;
        }

        //检测指定网点是否存在
        public static bool Exists(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM NODE WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        //插入网点信息
        public static bool Insert(SqlCommand cmd, Model.Node node)
        {
            cmd.CommandText = "INSERT INTO LWB ([code], [name], [citycode], [cityname], [address], [tel], [enable]) "
                + "VALUES (@code, @name, @citycode, @cityname, @address, @tel, @enable)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = node.Code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = node.Name;
            cmd.Parameters.Add("@citycode", SqlDbType.VarChar).Value = node.CityCode;
            cmd.Parameters.Add("@cityname", SqlDbType.VarChar).Value = node.CityName;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = node.Address;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = node.Tel;
            cmd.Parameters.Add("@enable", SqlDbType.Char).Value = node.Enable ? "Y" : "N";

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //删除全部网点
        public static bool Delete(SqlCommand cmd)
        {
            cmd.CommandText = "DELETE FROM NODE";
            cmd.Parameters.Clear();

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //删除指定网点
        public static bool Delete(SqlCommand cmd, string code)
        {
            cmd.CommandText = "DELETE FROM NODE WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //更新网点信息
        public static bool Update(SqlCommand cmd, Model.Node node)
        {
            cmd.CommandText = "UPDATE NODE SET [name] = @name, [citycode] = @citycode, [cityname] = @cityname, "
                + "[address] = @address, [tel] = @tel, [enable] = @enable WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = node.Code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = node.Name;
            cmd.Parameters.Add("@citycode", SqlDbType.VarChar).Value = node.CityCode;
            cmd.Parameters.Add("@cityname", SqlDbType.VarChar).Value = node.CityName;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = node.Address;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = node.Tel;
            cmd.Parameters.Add("@enable", SqlDbType.Char).Value = node.Enable ? "Y" : "N"; ;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //读取指定网点信息
        public static Model.Node Read(SqlCommand cmd, string code)
        {
            cmd.CommandText = "SELECT * FROM NODE WHERE [code] = @code";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return ToNode(rdr);
            }
            return null;
        }


        //读取全部网点信息
        public static List<Model.Node> Reads(SqlCommand cmd)
        {
            List<Model.Node> list = new List<Model.Node>();

            cmd.CommandText = "SELECT * FROM NODE";
            cmd.Parameters.Clear();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToNode(rdr)); }
            }
            return list;
        }

        //读取网点-根据启用状态
        public static List<Model.Node> Reads(SqlCommand cmd, bool enable)
        {
            List<Model.Node> list = new List<Model.Node>();

            if(enable)
                cmd.CommandText = "SELECT * FROM NODE WHERE [enable] = 'Y'";
            else
                cmd.CommandText = "SELECT * FROM NODE";
            cmd.Parameters.Clear();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToNode(rdr)); }
            }
            return list;
        }
    }
}
