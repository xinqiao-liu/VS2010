using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class CZJL
    {
        public DateTime SJ { get; set; }
        public String XM { get; set; }
        public String CC { get; set; }
        public String JS { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        //插入操作记录
        public static bool Insert(SqlCommand cmd, CZJL czjl)
        {
            try
            {
                cmd.CommandText = "INSERT INTO CZJL ([SJ], [XM], [CC], [JS]) VALUES(@SJ, @XM, @CC, @JS)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@SJ", SqlDbType.DateTime).Value = czjl.SJ;
                cmd.Parameters.Add("@XM", SqlDbType.Char).Value = czjl.XM;
                cmd.Parameters.Add("@CC", SqlDbType.Char).Value = czjl.CC;
                cmd.Parameters.Add("@JS", SqlDbType.Char).Value = czjl.JS;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入操作记录异常：" + ex.Message);
            }
        }

        public static bool Insert(SqlConnection conn, CZJL czjl)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Insert(cmd, czjl);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
