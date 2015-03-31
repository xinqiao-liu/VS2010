using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public class WSLog
    {
        //public Int32 ID { get; set; }
        public String UserCode { get; set; }
        public DateTime CDT { get; set; }
        public String Content { get; set; }

        //读取日志列表
        public static List<WSLog> Reads(SqlConnection conn)
        {
            try
            {
                List<WSLog> list = new List<WSLog>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [UserCode], [CDT], [Content] FROM WSLog ORDER BY [UserCode], [CDT]";
                    cmd.Parameters.Clear();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            WSLog item = new WSLog();

                            item.UserCode = rdr["UserCode"].ToString();
                            item.CDT = Convert.ToDateTime(rdr["CDT"]);
                            item.Content = rdr["Content"].ToString();

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取日志列表异常：" + ex.Message);
            }
        }

        public static List<WSLog> Reads(SqlConnection conn, String usercode)
        {
            try
            {
                List<WSLog> list = new List<WSLog>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [CDT], [Content] FROM WSLog WHERE [UserCode] = @UserCode ORDER BY [CDT]";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@UserCode", SqlDbType.VarChar).Value = usercode;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            WSLog item = new WSLog();

                            item.UserCode = usercode;
                            item.CDT = Convert.ToDateTime(rdr["CDT"]);
                            item.Content = rdr["Content"].ToString();

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取日志列表异常：" + ex.Message);
            }
        }

        //插入日志
        public static Boolean Insert(SqlCommand cmd, WSLog item)
        {
            try
            {
                cmd.CommandText = "INSERT INTO WSLog ([UserCode], [CDT], [Content]) VALUES(@UserCode, @CDT, @Content)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@UserCode", SqlDbType.VarChar).Value = item.UserCode;
                cmd.Parameters.Add("@CDT", SqlDbType.DateTime).Value = item.CDT;
                cmd.Parameters.Add("@Content", SqlDbType.NVarChar).Value = item.Content;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入日志异常：" + ex.Message);
            }
        }
        
        public static Boolean Insert(SqlCommand cmd, String usercode, DateTime cdt, String content)
        {
            return Insert(cmd, new WSLog() { UserCode = usercode, CDT = cdt, Content = content });
        }

        public static Boolean Insert(SqlConnection conn, WSLog item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Insert(cmd, item);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public static Boolean Insert(SqlConnection conn, String usercode, DateTime cdt, String content)
        {
            return Insert(conn, new WSLog() { UserCode = usercode, CDT = cdt, Content = content });
        }
    }
}
