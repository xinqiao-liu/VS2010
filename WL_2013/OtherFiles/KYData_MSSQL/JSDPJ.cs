using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    public sealed class JSDPJ
    {
        public String BH { get; set; }
        public DateTime RQ { get; set; }
        public String CC { get; set; }
        public String BZ { get; set; }
        public String CZ { get; set; }
        public DateTime SJ { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        //插入结算单票据
        public static bool Insert(SqlCommand cmd, JSDPJ jsdpj)
        {
            try
            {
                cmd.CommandText = "INSERT INTO JSDPJ ([BH], [RQ], [CC], [BZ], [CZ], [SJ]) VALUES( @BH, @RQ, @CC, @BZ, @CZ, @SJ) ";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@BH", SqlDbType.Char).Value = jsdpj.BH;
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = jsdpj.RQ;
                cmd.Parameters.Add("@CC", SqlDbType.Char).Value = jsdpj.CC;
                cmd.Parameters.Add("@BZ", SqlDbType.Char).Value = jsdpj.BZ;
                cmd.Parameters.Add("@CZ", SqlDbType.Char).Value = jsdpj.CZ;
                cmd.Parameters.Add("@SJ", SqlDbType.DateTime).Value = jsdpj.SJ;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入结算单票据异常：" + ex.Message);
            }
        }

        public static bool Insert(SqlConnection conn, JSDPJ jsdpj)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Insert(cmd, jsdpj);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        //废弃结算单票据
        public static bool Disable(SqlCommand cmd, String bh, DateTime date, String cc)
        {
            try
            {
                cmd.CommandText = "UPDATE JSDPJ SET [BZ] = 'F' WHERE [BH] = @BH AND [RQ] = @RQ AND [CC] = @CC";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@BH", SqlDbType.Char).Value = bh;
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("废弃结算单票据异常：" + ex.Message);
            }
        }

        public static bool Disable(SqlConnection conn, String bh, DateTime date, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Disable(cmd, bh, date, cc);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
