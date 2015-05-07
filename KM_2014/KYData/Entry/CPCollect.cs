using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public sealed class CPCollect
    {
        /*
        #region 私有字段

        private Int32 m_jszs;
        private Decimal m_kppk;
        private Decimal m_kbxf;
        private Decimal m_kryf;

        #endregion

        #region 共有属性

        public Int32 JSZS
        {
            get { return m_jszs; }
            set { m_jszs = value; }
        }

        public Decimal KPPK
        {
            get { return m_kppk; }
            set { m_kppk = value; }
        }

        public Decimal KBXF
        {
            get { return m_kbxf; }
            set { m_kbxf = value; }
        }

        public Decimal KRYF
        {
            get { return m_kryf; }
            set { m_kryf = value; }
        }

        #endregion
        */

        //读取车票汇总
        //public static CPCollect Read(SqlCommand cmd, DateTime rq, String cc)
        //{
        //    CPCollect item = null;

        //    try
        //    {
        //        cmd.CommandText = "SELECT COUNT(*) AS JSZS, SUM(PJ) AS KPPK, SUM(BXF) AS KBXF, SUM(RYFJF) AS KRYF FROM CPB WHERE [RQ] = @RQ AND [CC] = @CC AND [BZ] = 'J' GROUP BY [RQ],[CC]";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
        //        cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
        //        using (SqlDataReader rdr = cmd.ExecuteReader())
        //        {
        //            if (rdr.Read())
        //            {
        //                item = new CPCollect();

        //                if (rdr["JSZS"] != DBNull.Value) item.JSZS = Convert.ToInt32(rdr["JSZS"]);
        //                if (rdr["KPPK"] != DBNull.Value) item.KPPK = Convert.ToDecimal(rdr["KPPK"]);
        //                if (rdr["KBXF"] != DBNull.Value) item.KBXF = Convert.ToDecimal(rdr["KBXF"]);
        //                if (rdr["KRYF"] != DBNull.Value) item.KRYF = Convert.ToDecimal(rdr["KRYF"]);
        //            }
        //        }
        //        return item;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("读取车票汇总异常：" + ex.Message);
        //    }
        //}
    }
}
