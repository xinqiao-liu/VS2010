using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    public sealed class JSDMXB
    {
        public DateTime RQ { get; set; }
        public String CC { get; set; }
        public String DZ { get; set; }
        public String PZ { get; set; }
        public Decimal PJ { get; set; }
        public Decimal BXF { get; set; }
        public Int32 JSS { get; set; }
        public Decimal JSK { get; set; }
        public String SFDM { get; set; }
        public String DZDM { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        //插入结算单明细
        public static Boolean Insert(SqlCommand cmd, List<JSDMXB> list)
        {
            try
            {
                foreach (JSDMXB item in list)
                {
                    cmd.CommandText = "INSERT INTO JSDMXB ([CC], [RQ], [DZ], [PZ], [PJ], [BXF], [JSS], [JSK], [SFDM], [DZDM]) VALUES( @CC, @RQ, @DZ, @PZ, @PJ, @BXF, @JSS, @JSK, @SFDM, @DZDM) ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = item.RQ;
                    cmd.Parameters.Add("@CC", SqlDbType.Char).Value = item.CC;
                    cmd.Parameters.Add("@DZ", SqlDbType.Char).Value = item.DZ;
                    cmd.Parameters.Add("@PZ", SqlDbType.Char).Value = item.PZ;
                    cmd.Parameters.Add("@PJ", SqlDbType.Decimal).Value = item.PJ;
                    cmd.Parameters.Add("@BXF", SqlDbType.Decimal).Value = item.BXF;
                    cmd.Parameters.Add("@JSS", SqlDbType.Int).Value = item.JSS;
                    cmd.Parameters.Add("@JSK", SqlDbType.Decimal).Value = item.JSK;
                    cmd.Parameters.Add("@SFDM", SqlDbType.Char).Value = item.SFDM;
                    cmd.Parameters.Add("@DZDM", SqlDbType.Char).Value = item.DZDM;

                    if (cmd.ExecuteNonQuery() <= 0) return false;

                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入结算单明细：" + ex.Message);
            }
        }

        public static Boolean Insert(SqlConnection conn, List<JSDMXB> list)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Insert(cmd, list);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        //删除结算单明细
        public static Boolean Delete(SqlCommand cmd, DateTime date, String cc)
        {
            try
            {
                cmd.CommandText = "DELETE FROM JSDMXB WHERE [RQ] = @RQ AND [CC] = @CC";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除指定绑定车牌异常：" + ex.Message);
            }
        }

        public static Boolean Delete(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Delete(cmd, date, cc);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
