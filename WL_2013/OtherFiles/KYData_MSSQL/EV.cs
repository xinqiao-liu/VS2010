using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    public sealed class EV
    {
        //检测有效验证表是否存在
        public static Boolean Exists(SqlConnection conn)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM sysobjects WHERE (id = OBJECT_ID(N'[dbo].[EV]'))";

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch
            {
                throw new ApplicationException("检测有效验证异常！");
            }
        }


        //获取有效验证日期
        public static String GetRQ(SqlConnection conn)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [RQ] FROM EV";

                    return Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch
            {
                throw new ApplicationException("获取有效验证异常！");
            }
        }
    }
}
