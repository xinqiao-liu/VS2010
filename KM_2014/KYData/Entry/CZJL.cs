using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class CZJL
    {
        //插入操作记录
        public static bool Insert(SqlCommand cmd, Model.CZJL item)
        {
            cmd.CommandText = "INSERT INTO CZJL ([SJ], [XM], [CC], [JS]) VALUES(@SJ, @XM, @CC, @JS)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@SJ", SqlDbType.DateTime).Value = item.SJ;
            cmd.Parameters.Add("@XM", SqlDbType.Char).Value = item.XM;
            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = item.CC;
            cmd.Parameters.Add("@JS", SqlDbType.Char).Value = item.JS;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
    }
}
