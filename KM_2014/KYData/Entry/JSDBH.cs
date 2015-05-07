using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class JSDBH
    {
        //计划分解成递增和读取
        //递增并读取结算单编号
        public static int Read(SqlCommand cmd)
        {
            cmd.CommandText = "UPDATE JSDBH SET [BH] = [BH] + 1; SELECT [BH] FROM JSDBH;";
            cmd.Parameters.Clear();

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
