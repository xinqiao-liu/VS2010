using System;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public class WSUser
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public Char Stop { get; set; }
        public Decimal Money { get; set; }
        public String Tag { get; set; }
        public String ClientIP { get; set; }
        public String K_UID { get; set; }
        public String K_UN { get; set; }
        public String K_UP { get; set; }

        //检测用户
        public static Boolean Exists(SqlConnection conn, String code)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM WSUsers WHERE [Code] = @Code";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = code;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测用户异常：" + ex.Message);
            }
        }

        //验证用户权限
        public static Boolean Check(SqlConnection conn, String code, int right)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [Tag] FROM WSUsers WHERE [Code] = @Code";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = code;

                    return (Convert.ToString(cmd.ExecuteScalar())[right] == '1');
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("验证用户权限异常：" + ex.Message);
            }
        }

        //读取用户信息
        public static WSUser Read(SqlConnection conn, String code)
        {
            try
            {
                WSUser item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WSUsers WHERE [Code] = @Code";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = code;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new WSUser();

                            item.Code = code;
                            item.Name = rdr["Name"].ToString();
                            item.Stop = rdr["Stop"].ToString()[0];
                            item.Money = Convert.ToDecimal(rdr["Money"]);
                            item.Tag = rdr["Tag"].ToString();
                            item.ClientIP = rdr["ClientIP"].ToString();
                            item.K_UID = rdr["K_UID"].ToString();
                            item.K_UN = rdr["K_UN"].ToString();
                            item.K_UP = rdr["K_UP"].ToString();
                        }
                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取用户信息异常：" + ex.Message);
            }
        }

        //读取保证金
        public static Decimal ReadMoney(SqlConnection conn, String code)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [Money] FROM WSUsers WHERE [Code] = @Code";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = code;

                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取保证金异常：" + ex.Message);
            }
        }

        //更新保证金
        public static Boolean SetMoney(SqlCommand cmd, String code, Decimal money)
        {
            try
            {
                cmd.CommandText = "UPDATE WSUsers SET [Money] = [Money] + @Money WHERE [Code] = @Code";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = code;
                cmd.Parameters.Add("@Money", SqlDbType.Decimal).Value = money;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("更新保证金异常：" + ex.Message);
            }
        }

        public static Boolean SetMoney(SqlConnection conn, String code, Decimal money)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return SetMoney(cmd, code, money);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
