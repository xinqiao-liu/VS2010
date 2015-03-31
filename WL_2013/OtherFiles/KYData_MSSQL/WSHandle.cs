using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public class WSHandle
    {
        public String Handle { get; set; }
        public String UserCode { get; set; }
        public DateTime ODT { get; set; }
        public DateTime SDT { get; set; }
        public DateTime CDT { get; set; }

        //检测用户是否存在有效句柄
        public static Boolean Exists(SqlConnection conn, String usercode)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM WSHandle WHERE [UserCode] = @UserCode AND [SDT] > GetDate() AND [CDT] = @CDT";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@UserCode", SqlDbType.VarChar).Value = usercode;
                    cmd.Parameters.Add("@CDT", SqlDbType.DateTime).Value = DateTime.MaxValue;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测句柄异常：" + ex.Message);
            }
        }

        //检测句柄是否有效
        public static Boolean Check(SqlConnection conn, String handle)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM WSHandle WHERE [Handle] = @Handle AND [SDT] > GetDate() AND [CDT] = @CDT";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Handle", SqlDbType.VarChar).Value = handle;
                    cmd.Parameters.Add("@CDT", SqlDbType.DateTime).Value = DateTime.MaxValue;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测句柄异常：" + ex.Message);
            }
        }

        //关闭句柄
        public static Boolean Close(SqlConnection conn, String handle)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE WSHandle SET [CDT] = GETDATE() WHERE [Handle] = @Handle AND [CDT] = @CDT";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Handle", SqlDbType.VarChar).Value = handle;
                    cmd.Parameters.Add("@CDT", SqlDbType.DateTime).Value = DateTime.MaxValue;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("关闭句柄异常：" + ex.Message);
            }
        }

        //清理无效句柄
        public static Boolean Dispose(SqlConnection conn, String usercode)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE WSHandle SET [CDT] = GETDATE() WHERE [UserCode] = @UserCode AND [SDT] < GetDate() AND [CDT] = @CDT";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@UserCode", SqlDbType.VarChar).Value = usercode;
                    cmd.Parameters.Add("@CDT", SqlDbType.DateTime).Value = DateTime.MaxValue;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("清理无效句柄异常：" + ex.Message);
            }
        }

        //读取句柄
        public static WSHandle Read(SqlConnection conn, String handle)
        {
            try
            {
                WSHandle item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WSHandle WHERE [Handle] = @Handle";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Handle", SqlDbType.VarChar).Value = handle;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new WSHandle();

                            item.Handle = handle;
                            item.UserCode = rdr["UserCode"].ToString();
                            item.ODT = Convert.ToDateTime(rdr["ODT"]);
                            item.SDT = Convert.ToDateTime(rdr["SDT"]);
                            item.CDT = Convert.ToDateTime(rdr["CDT"]);
                        }
                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取句柄异常：" + ex.Message);
            }
        }

        //读取用户代码
        public static String ReadUserCode(SqlConnection conn, String handle)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [UserCode] FROM WSHandle WHERE [Handle] = @Handle";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Handle", SqlDbType.VarChar).Value = handle;

                    return Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取用户代码异常：" + ex.Message);
            }
        }

        //插入句柄
        public static Boolean Insert(SqlConnection conn, WSHandle item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WSHandle ([Handle], [UserCode], [ODT], [SDT], [CDT]) VALUES(@Handle, @UserCode, @ODT, @SDT, @CDT)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Handle", SqlDbType.VarChar).Value = item.Handle;
                    cmd.Parameters.Add("@UserCode", SqlDbType.VarChar).Value = item.UserCode;
                    cmd.Parameters.Add("@ODT", SqlDbType.DateTime).Value = item.ODT;
                    cmd.Parameters.Add("@SDT", SqlDbType.DateTime).Value = item.SDT;
                    cmd.Parameters.Add("@CDT", SqlDbType.DateTime).Value = item.CDT;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入句柄异常：" + ex.Message);
            }
        }
    }
}
