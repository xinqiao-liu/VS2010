using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class KYZ
    {
        public String DM { get; set; }
        public String MC { get; set; }
        public String SM { get; set; }
        public String Server { get; set; }
        public String BZ { get; set; }
        public String DMDM { get; set; }
        public String DWBZ { get; set; }
        public String DTSPBZ { get; set; }
        public int TQSPSJ { get; set; }

        public override String ToString()
        {
            return String.Format("{0}-{1}", this.DM, this.MC);
        }

        public static List<KYZ> Reads(SqlConnection conn)
        {
            try
            {
                List<KYZ> list = new List<KYZ>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM KYZ ORDER BY DM";

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            KYZ item = new KYZ();

                            if (rdr["dm"] != DBNull.Value) item.DM = rdr["dm"].ToString().Trim();
                            if (rdr["mc"] != DBNull.Value) item.MC = rdr["mc"].ToString().Trim();
                            if (rdr["sm"] != DBNull.Value) item.SM = rdr["sm"].ToString().Trim();
                            if (rdr["server"] != DBNull.Value) item.Server = rdr["server"].ToString().Trim();
                            if (rdr["bz"] != DBNull.Value) item.BZ = rdr["bz"].ToString().Trim();
                            if (rdr["dmdm"] != DBNull.Value) item.DMDM = rdr["dmdm"].ToString().Trim();
                            if (rdr["dwbz"] != DBNull.Value) item.DWBZ = rdr["dwbz"].ToString().Trim();
                            if (rdr["dtspbz"] != DBNull.Value) item.DTSPBZ = rdr["dtspbz"].ToString().Trim();
                            if (rdr["tqspsj"] != DBNull.Value) item.TQSPSJ = Convert.ToInt32(rdr["tqspsj"]);

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取客运站信息异常：" + ex.Message);
            }
        }
    }
}
