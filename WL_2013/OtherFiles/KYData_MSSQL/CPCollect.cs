using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    public sealed class CPCollect
    {
        public Int32 JSZS { get; set; }
        public Decimal KPPK { get; set; }
        public Decimal KBXF { get; set; }
        public Decimal KRYF { get; set; }

        //读取车票汇总
        public static CPCollect Read(SqlCommand cmd, DateTime rq, String cc)
        {
            CPCollect item = null;

            try
            {
                cmd.CommandText = "SELECT COUNT(*) AS JSZS, SUM(PJ) AS KPPK, SUM(BXF) AS KBXF, SUM(RYFJF) AS KRYF FROM CPB WHERE [RQ] = @RQ AND [CC] = @CC AND [BZ] = 'J' GROUP BY [RQ],[CC]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
                cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        item = new CPCollect();

                        if (rdr["JSZS"] != DBNull.Value) item.JSZS = Convert.ToInt32(rdr["JSZS"]);
                        if (rdr["KPPK"] != DBNull.Value) item.KPPK = Convert.ToDecimal(rdr["KPPK"]);
                        if (rdr["KBXF"] != DBNull.Value) item.KBXF = Convert.ToDecimal(rdr["KBXF"]);
                        if (rdr["KRYF"] != DBNull.Value) item.KRYF = Convert.ToDecimal(rdr["KRYF"]);
                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取车票汇总异常：" + ex.Message);
            }
        }

        public static CPCollect Read(SqlConnection conn, DateTime rq, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Read(cmd, rq, cc);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
