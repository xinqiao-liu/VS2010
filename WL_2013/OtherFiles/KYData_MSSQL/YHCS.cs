using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    public sealed class YHCS
    {
        public String BM { get; set; }
        public String MC { get; set; }
        public String Server { get; set; }
        public Decimal KPBL { get; set; }
        public Decimal XBBL { get; set; }
        public Int32 PJWS { get; set; }
        public Int32 JPK { get; set; }
        public Int32 SPTS { get; set; }
        public Int32 TSSJ { get; set; }
        public Int32 BZSJ { get; set; }
        public Int32 DBFK { get; set; }
        public Decimal FKBS { get; set; }
        public Int32 WDJS { get; set; }
        public Int32 WDFK { get; set; }
        public Int32 WDCS { get; set; }
        public Decimal BPF { get; set; }
        public Decimal DPF { get; set; }
        public Decimal XBF { get; set; }
        public Decimal XBFW { get; set; }
        public Decimal GBF { get; set; }
        public String GN01 { get; set; }
        public String GN02 { get; set; }
        public String GN03 { get; set; }
        public String GN04 { get; set; }
        public String GN05 { get; set; }
        public String GN06 { get; set; }
        public String GN07 { get; set; }
        public String GN08 { get; set; }
        public String GN09 { get; set; }
        public String GN10 { get; set; }
        public String GN11 { get; set; }
        public String GN12 { get; set; }
        public String GN13 { get; set; }
        public String GN14 { get; set; }
        public String GN15 { get; set; }
        public String DMDM { get; set; }
        public String DWBZ { get; set; }
        public DateTime SysClock { get; set; }
        public String JZRQ { get; set; }
        public Decimal JBYJ { get; set; }
        public Decimal BXBL { get; set; }
        public Decimal FJBL { get; set; }
        public String BXLC { get; set; }
        public String FJLC { get; set; }
        public String JZCL { get; set; }
        public String JSFS { get; set; }
        public Decimal KPGB { get; set; }
        public String JSDGS { get; set; }
        public String QJBZ { get; set; }
        public String CPJP { get; set; }
        public String XBJP { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        //读取用户参数
        public static YHCS Read(SqlConnection conn)
        {
            try
            {
                YHCS yhcs = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM YHCS";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            yhcs = new YHCS();

                            if (rdr["bm"] != DBNull.Value) yhcs.BM = rdr["bm"].ToString().Trim();
                            if (rdr["mc"] != DBNull.Value) yhcs.MC = rdr["mc"].ToString().Trim();
                            if (rdr["server"] != DBNull.Value) yhcs.Server = rdr["server"].ToString().Trim();
                            if (rdr["kpbl"] != DBNull.Value) yhcs.KPBL = Convert.ToDecimal(rdr["kpbl"]);
                            if (rdr["xbbl"] != DBNull.Value) yhcs.XBBL = Convert.ToDecimal(rdr["xbbl"]);
                            if (rdr["pjws"] != DBNull.Value) yhcs.PJWS = Convert.ToInt32(rdr["pjws"]);
                            if (rdr["jpk"] != DBNull.Value) yhcs.JPK = Convert.ToInt32(rdr["jpk"]);
                            if (rdr["spts"] != DBNull.Value) yhcs.SPTS = Convert.ToInt32(rdr["spts"]);
                            if (rdr["tssj"] != DBNull.Value) yhcs.TSSJ = Convert.ToInt32(rdr["tssj"]);
                            if (rdr["bzsj"] != DBNull.Value) yhcs.BZSJ = Convert.ToInt32(rdr["bzsj"]);
                            if (rdr["dbfk"] != DBNull.Value) yhcs.DBFK = Convert.ToInt32(rdr["dbfk"]);
                            if (rdr["fkbs"] != DBNull.Value) yhcs.FKBS = Convert.ToDecimal(rdr["fkbs"]);
                            if (rdr["wdjs"] != DBNull.Value) yhcs.WDJS = Convert.ToInt32(rdr["wdjs"]);
                            if (rdr["wdfk"] != DBNull.Value) yhcs.WDFK = Convert.ToInt32(rdr["wdfk"]);
                            if (rdr["wdcs"] != DBNull.Value) yhcs.WDCS = Convert.ToInt32(rdr["wdcs"]);
                            if (rdr["bpf"] != DBNull.Value) yhcs.BPF = Convert.ToDecimal(rdr["bpf"]);
                            if (rdr["dpf"] != DBNull.Value) yhcs.DPF = Convert.ToDecimal(rdr["dpf"]);
                            if (rdr["xbf"] != DBNull.Value) yhcs.XBF = Convert.ToDecimal(rdr["xbf"]);
                            if (rdr["xbfw"] != DBNull.Value) yhcs.XBFW = Convert.ToDecimal(rdr["xbfw"]);
                            if (rdr["gbf"] != DBNull.Value) yhcs.GBF = Convert.ToDecimal(rdr["gbf"]);
                            if (rdr["gn01"] != DBNull.Value) yhcs.GN01 = rdr["gn01"].ToString().Trim();
                            if (rdr["gn02"] != DBNull.Value) yhcs.GN02 = rdr["gn02"].ToString().Trim();
                            if (rdr["gn03"] != DBNull.Value) yhcs.GN03 = rdr["gn03"].ToString().Trim();
                            if (rdr["gn04"] != DBNull.Value) yhcs.GN04 = rdr["gn04"].ToString().Trim();
                            if (rdr["gn05"] != DBNull.Value) yhcs.GN05 = rdr["gn05"].ToString().Trim();
                            if (rdr["gn06"] != DBNull.Value) yhcs.GN06 = rdr["gn06"].ToString().Trim();
                            if (rdr["gn07"] != DBNull.Value) yhcs.GN07 = rdr["gn07"].ToString().Trim();
                            if (rdr["gn08"] != DBNull.Value) yhcs.GN08 = rdr["gn08"].ToString().Trim();
                            if (rdr["gn09"] != DBNull.Value) yhcs.GN09 = rdr["gn09"].ToString().Trim();
                            if (rdr["gn10"] != DBNull.Value) yhcs.GN10 = rdr["gn10"].ToString().Trim();
                            if (rdr["gn11"] != DBNull.Value) yhcs.GN11 = rdr["gn11"].ToString().Trim();
                            if (rdr["gn12"] != DBNull.Value) yhcs.GN12 = rdr["gn12"].ToString().Trim();
                            if (rdr["gn13"] != DBNull.Value) yhcs.GN13 = rdr["gn13"].ToString().Trim();
                            if (rdr["gn14"] != DBNull.Value) yhcs.GN14 = rdr["gn14"].ToString().Trim();
                            if (rdr["gn15"] != DBNull.Value) yhcs.GN15 = rdr["gn15"].ToString().Trim();
                            if (rdr["dmdm"] != DBNull.Value) yhcs.DMDM = rdr["dmdm"].ToString().Trim();
                            if (rdr["dwbz"] != DBNull.Value) yhcs.DWBZ = rdr["dwbz"].ToString().Trim();
                            if (rdr["sysclock"] != DBNull.Value) yhcs.SysClock = Convert.ToDateTime(rdr["sysclock"]);
                            if (rdr["jzrq"] != DBNull.Value) yhcs.JZRQ = rdr["jzrq"].ToString().Trim();
                            if (rdr["jbyj"] != DBNull.Value) yhcs.JBYJ = Convert.ToDecimal(rdr["jbyj"]);
                            if (rdr["bxbl"] != DBNull.Value) yhcs.BXBL = Convert.ToDecimal(rdr["bxbl"]);
                            if (rdr["fjbl"] != DBNull.Value) yhcs.FJBL = Convert.ToDecimal(rdr["fjbl"]);
                            if (rdr["bxlc"] != DBNull.Value) yhcs.BXLC = rdr["bxlc"].ToString().Trim();
                            if (rdr["fjlc"] != DBNull.Value) yhcs.FJLC = rdr["fjlc"].ToString().Trim();
                            if (rdr["jzcl"] != DBNull.Value) yhcs.JZCL = rdr["jzcl"].ToString().Trim();
                            if (rdr["jsfs"] != DBNull.Value) yhcs.JSFS = rdr["jsfs"].ToString().Trim();
                            if (rdr["kpgb"] != DBNull.Value) yhcs.KPGB = Convert.ToDecimal(rdr["kpgb"]);
                            if (rdr["jsdgs"] != DBNull.Value) yhcs.JSDGS = rdr["jsdgs"].ToString();
                            if (rdr["qjbz"] != DBNull.Value) yhcs.QJBZ = rdr["qjbz"].ToString().Trim();
                            if (rdr["cpjp"] != DBNull.Value) yhcs.CPJP = rdr["cpjp"].ToString().Trim();
                            if (rdr["xbjp"] != DBNull.Value) yhcs.XBJP = rdr["xbjp"].ToString().Trim();
                        }
                    }
                }
                return yhcs;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取用户参数异常：" + ex.Message);
            }
        }
    }
}
