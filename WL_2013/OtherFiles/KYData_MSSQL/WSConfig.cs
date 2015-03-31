using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public class WSConfig
    {
        //检测系统是否停用
        public static Boolean ReadStop(SqlConnection conn)
        {
            return ReadStop(conn, "MainConfig");
        }

        public static Boolean ReadStop(SqlConnection conn, String id)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [Stop] FROM WSConfig WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

                    return (cmd.ExecuteScalar().ToString()[0] == 'N' ? false : true);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测系统是否停用异常：" + ex.Message);
            }
        }

        //获取系统预售天数
        public static Int32 ReadPreSell(SqlConnection conn)
        {
            return ReadPreSell(conn, "MainConfig");
        }

        public static Int32 ReadPreSell(SqlConnection conn, String id)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [PreSell] FROM WSConfig WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取系统预售天数异常：" + ex.Message);
            }
        }
    }
}
