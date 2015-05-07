using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class JSDMXB
    {
        //插入结算单明细项
        public static Boolean Insert(SqlCommand cmd, Model.JSDMXB item)
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

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //删除结算单明细项
        public static Boolean Delete(SqlCommand cmd, DateTime rq, String cc)
        {
            cmd.CommandText = "DELETE FROM JSDMXB WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
    }
}
