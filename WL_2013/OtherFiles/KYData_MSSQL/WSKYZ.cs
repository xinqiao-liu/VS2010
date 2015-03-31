using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public class WSKYZ
    {
        public String Code { get; set; }
        public String Name { get; set; }
        //public String IP { get; set; }
        //public Char Stop { get; set; }

        //读取客运站列表
        public static List<WSKYZ> Reads(SqlConnection conn)
        {
            try
            {
                List<WSKYZ> list = new List<WSKYZ>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [Code], [Name] FROM WSKYZ WHERE [Stop] = 'N' ORDER BY [Code]";
                    cmd.Parameters.Clear();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            WSKYZ item = new WSKYZ();

                            item.Code = rdr["Code"].ToString();
                            item.Name = rdr["Name"].ToString();

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取客运站列表异常：" + ex.Message);
            }
        }

        //通过客运站代码获取客运站名称
        public static String ReadName(SqlConnection conn, String code)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [Name] FROM WSKYZ WHERE [Code] = @Code";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = code;

                    return Convert.ToString(cmd.ExecuteScalar()).Trim();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取客运站名称异常：" + ex.Message);
            }
        }

        //通过客运站代码获取客运站IP地址
        public static String ReadIP(SqlConnection conn, String code)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [IP] FROM WSKYZ WHERE [Code] = @Code AND [Stop] = 'N'";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = code;

                    //如果指定客运站代码返回空字符串，可能该客运站已停用
                    return Convert.ToString(cmd.ExecuteScalar()).Trim();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取客运站IP地址异常：" + ex.Message);
            }
        }
    }
}
