using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class LSCPB
    {
        public String PH { get; set; }
        public String CC { get; set; }
        public DateTime RQ { get; set; }
        public String ZH { get; set; }
        public String PZ { get; set; }
        public Decimal PJ { get; set; }
        public String FCSJ { get; set; }
        public Decimal BPF { get; set; }
        public Decimal ZWF { get; set; }
        public String BZ { get; set; }
        public String SPY { get; set; }
        public String YDBZ { get; set; }
        public String HPZBZ { get; set; }
        public String DZBZ { get; set; }
        public String CCZBZ { get; set; }
        public String DZ { get; set; }
        public DateTime SPRQ { get; set; }
        public Int32 LC { get; set; }
        public Decimal BXF { get; set; }
        public Decimal RYFJF { get; set; }
        public Decimal BXJE { get; set; }
        public String BXBZ { get; set; }
        public String BXRXM { get; set; }
        public String SFZHM { get; set; }
        public String TFBRY { get; set; }
        public DateTime TFBSJ { get; set; }
        public String BDLSH { get; set; }
        public Decimal TBF { get; set; }

        public override String ToString()
        {
            return String.Format(" {0}{1,07}{2,04}{3,04}{4,08}{5,08}{6,24}{7,08}", this.PH, this.FCSJ, this.ZH, this.PZ, this.PJ.ToString("N2"), this.ZWF.ToString("N2"), this.SPRQ.ToString("yyyy-MM-dd HH:mm:dd"), this.DZ);
        }

        //读取历史车票信息
        public static List<LSCPB> Reads(SqlConnection conn, DateTime rq, String cc)
        {
            try
            {
                List<LSCPB> list = new List<LSCPB>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM LSCPB WHERE [RQ] = @RQ AND [CC] = @CC AND ([BZ] <> 'T' OR [BZ] <> 'F') ORDER BY SPRQ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@rq", SqlDbType.DateTime).Value = rq;
                    cmd.Parameters.Add("@cc", SqlDbType.Char).Value = cc;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            LSCPB lscpb = new LSCPB();

                            lscpb.RQ = rq;
                            lscpb.CC = cc;

                            if (rdr["ph"] != DBNull.Value) lscpb.PH = rdr["ph"].ToString().Trim();
                            if (rdr["fcsj"] != DBNull.Value) lscpb.FCSJ = rdr["fcsj"].ToString().Trim();
                            if (rdr["dz"] != DBNull.Value) lscpb.DZ = rdr["dz"].ToString().Trim();
                            if (rdr["zh"] != DBNull.Value) lscpb.ZH = rdr["zh"].ToString().Trim();
                            if (rdr["pz"] != DBNull.Value) lscpb.PZ = rdr["pz"].ToString().Trim();
                            if (rdr["pj"] != DBNull.Value) lscpb.PJ = Convert.ToDecimal(rdr["pj"]);
                            if (rdr["zwf"] != DBNull.Value) lscpb.ZWF = Convert.ToDecimal(rdr["zwf"]);
                            if (rdr["sprq"] != DBNull.Value) lscpb.SPRQ = Convert.ToDateTime(rdr["sprq"]);

                            list.Add(lscpb);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取历史车票信息异常：" + ex.Message);
            }
        }
    }
}
