using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class IDCardLog
    {
        public String Type { get; set; }
        public String CID { get; set; }
        public String CPH { get; set; }
        public DateTime RQ { get; set; }
        public String CC { get; set; }
        public DateTime CreateDT { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        //读取日志列表
        public static List<IDCardLog> Reads(SqlConnection conn, String cid)
        {
            try
            {
                List<IDCardLog> list = new List<IDCardLog>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM IDCardLog WHERE [CID] = @CID ORDER BY SN";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            IDCardLog log = new IDCardLog();

                            log.Type = rdr["Type"].ToString();
                            log.CID = rdr["CID"].ToString();
                            log.CPH = rdr["CPH"].ToString();
                            log.RQ = Convert.ToDateTime(rdr["RQ"]);
                            log.CC = rdr["CC"].ToString();
                            log.CreateDT = Convert.ToDateTime(rdr["CreateDT"]);

                            list.Add(log);
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

        //读取全部日志列表
        public static List<IDCardLog> Reads(SqlConnection conn)
        {
            try
            {
                List<IDCardLog> list = new List<IDCardLog>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM IDCardLog ORDER BY SN";
                    cmd.Parameters.Clear();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            IDCardLog log = new IDCardLog();

                            log.Type = rdr["Type"].ToString();
                            log.CID = rdr["CID"].ToString();
                            log.CPH = rdr["CPH"].ToString();
                            log.RQ = Convert.ToDateTime(rdr["RQ"]);
                            log.CC = rdr["CC"].ToString();
                            log.CreateDT = Convert.ToDateTime(rdr["CreateDT"]);

                            list.Add(log);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取全部日志列表异常：" + ex.Message);
            }
        }

        //插入日志
        public static bool Insert(SqlConnection conn, IDCardLog log)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO IDCardLog ([Type], [CID], [CPH], [RQ], [CC]) VALUES(@Type, @CID, @CPH, @RQ, @CC)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = log.Type;
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = log.CID;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = log.CPH;
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = log.RQ;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = log.CC;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入日志异常：" + ex.Message);
            }
        }

        //获取最后一次指定操作时间
        public static DateTime GetCreateDT(SqlConnection conn, String cid, String type)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT CreateDT FROM IDCardLog WHERE [CID] = @CID AND [Type] = @Type ORDER BY CreateDT DESC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = type;

                    return Convert.ToDateTime(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取最后一次指定操作时间：" + ex.Message);
            }
        }
    }
}
