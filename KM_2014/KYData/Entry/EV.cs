using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class EV
    {
        //检测有效验证表是否存在
        public static Boolean Exist(SqlCommand cmd)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM sysobjects WHERE (id = OBJECT_ID(N'[dbo].[EV]'))";
            cmd.Parameters.Clear();

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }


        //读取有效验证编码日期
        //EV - VARCHAR(200)
        public static String Read(SqlCommand cmd)
        {
            cmd.CommandText = "SELECT [RQ] FROM EV";
            cmd.Parameters.Clear();

            return Convert.ToString(cmd.ExecuteScalar());
        }
    }
}
