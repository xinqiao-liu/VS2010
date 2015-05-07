using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{    
    public static class JSDPJ
    {
        //插入结算单票据项
        public static bool Insert(SqlCommand cmd, Model.JSDPJ item)
        {
            cmd.CommandText = "INSERT INTO JSDPJ ([BH], [RQ], [CC], [BZ], [CZ], [SJ]) VALUES( @BH, @RQ, @CC, @BZ, @CZ, @SJ) ";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BH", SqlDbType.Char).Value = item.BH;
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = item.RQ;
            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = item.CC;
            cmd.Parameters.Add("@BZ", SqlDbType.Char).Value = item.BZ;
            cmd.Parameters.Add("@CZ", SqlDbType.Char).Value = item.CZ;
            cmd.Parameters.Add("@SJ", SqlDbType.DateTime).Value = item.SJ;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //废弃结算单票据项
        public static bool Discard(SqlCommand cmd, String bh, DateTime rq, String cc)
        {
            cmd.CommandText = "UPDATE JSDPJ SET [BZ] = 'F' WHERE [BH] = @BH AND [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BH", SqlDbType.Char).Value = bh;
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
    }
}
