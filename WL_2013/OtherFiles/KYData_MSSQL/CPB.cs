using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    public sealed class CPB
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
        public int LC { get; set; }
        public Decimal BXF { get; set; }
        public Decimal RYFJF { get; set; }
        public Decimal BXJE { get; set; }
        public Decimal BXBZ { get; set; }
        public String BXRXM { get; set; }
        public String SFZHM { get; set; }
        public String TFBRY { get; set; }
        public DateTime TFBSJ { get; set; }
        public String BDLSH { get; set; }
        public Decimal TBF { get; set; }

        public override String ToString()
        {
            return " 票号：" + this.PH + "日期：" + this.RQ.ToString("yyyy-MM-dd") + " 班次：" + this.CC + " 发车时间：" + this.FCSJ + " 座号：" + this.ZH + " 票价：" + this.PJ.ToString("N2");
        }

        //检测车票
        public static Boolean Exists(SqlConnection conn, DateTime date, String ph)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM CPB WHERE [RQ] = @RQ AND [PH] = @PH";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@PH", SqlDbType.Char).Value = ph;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测车票异常：" + ex.Message);
            }
        }

        //获取客票班次
        public static String GetCC(SqlConnection conn, DateTime date, String ph)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT [CC] FROM CPB WHERE [RQ] = @RQ AND [PH] = @PH";
                    cmd.Parameters.Add("@PH", SqlDbType.Char).Value = ph;
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;

                    return Convert.ToString(cmd.ExecuteScalar()).Trim();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取客票班次：" + ex.Message);
            }
        }

        //获取状态
        public static String GetState(SqlConnection conn, DateTime date, String cc, String ph)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    if (cc == String.Empty)
                    {
                        cmd.CommandText = "SELECT [BZ] FROM CPB WHERE [RQ] = @RQ AND [PH] = @PH";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT [BZ] FROM CPB WHERE [RQ] = @RQ AND [CC] = @CC AND [PH] = @PH";
                        cmd.Parameters.Add("@PH", SqlDbType.Char).Value = ph;
                    }
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;                    
                    cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;                    

                    return Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取状态异常：" + ex.Message);
            }
        }

        public static String GetState(SqlConnection conn, DateTime date, String ph)
        {
            return GetState(conn, date, String.Empty, ph);
        }

        //设置状态
        public static Boolean SetState(SqlCommand cmd, DateTime date, String cc, String ph, String bz)
        {
            try
            {
                cmd.Parameters.Clear();
                if (cc == String.Empty)
                {
                    cmd.CommandText = "UPDATE CPB SET [BZ] = @BZ WHERE [RQ] = @RQ AND [PH] = @PH";
                }
                else
                {
                    cmd.CommandText = "UPDATE CPB SET [BZ] = @BZ WHERE [RQ] = @RQ AND [CC] = @CC AND [PH] = @PH";
                    cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
                }
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                cmd.Parameters.Add("@PH", SqlDbType.Char).Value = ph;
                cmd.Parameters.Add("@BZ", SqlDbType.Char).Value = bz;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("设置状态异常：" + ex.Message);
            }
        }

        public static Boolean SetState(SqlConnection conn, DateTime date, String cc, String ph, String bz)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return SetState(cmd, date, cc, ph, bz);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public static Boolean SetState(SqlCommand cmd, DateTime date, String ph, String bz)
        {
            return SetState(cmd, date, String.Empty, ph, bz);
        }

        public static Boolean SetState(SqlConnection conn, DateTime date, String ph, String bz)
        {
            return SetState(conn, date, String.Empty, ph, bz);
        }

        //获取票数
        public static Int32 GetCount(SqlConnection conn, DateTime date, String cc, String bz)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM CPB WHERE [RQ] = @RQ AND [CC] = @CC AND [BZ] = @BZ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
                    cmd.Parameters.Add("@BZ", SqlDbType.Char).Value = bz;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取票数异常：" + ex.Message);
            }
        }


        //设置热票班次
        public static Boolean SetHotCC(SqlCommand cmd, DateTime date, String ph, String cc)
        {
            try
            {
                cmd.CommandText = "UPDATE CPB SET [CC] = @CC WHERE [RQ] = @RQ AND [PH] = @PH";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                cmd.Parameters.Add("@PH", SqlDbType.Char).Value = ph;
                cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("设置热线票班次异常：" + ex.Message);
            }
        }

        public static Boolean SetHotCC(SqlConnection conn, DateTime date, String ph, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return SetHotCC(cmd, date, ph, cc);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        //检测热线客票
        public static Boolean IsHot(SqlConnection conn, DateTime date, String ph)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM CPB WHERE [RQ] = @RQ AND [CC] = '未定' AND [PH] = @PH";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@PH", SqlDbType.Char).Value = ph;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测热线客票异常：" + ex.Message);
            }
        }

        //读取车票信息
        public static CPB Read(SqlConnection conn, DateTime date, String ph)
        {
            try
            {
                CPB item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CPB WHERE [RQ] = @RQ AND [PH] = @PH";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@PH", SqlDbType.Char).Value = ph;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new CPB();

                            item.RQ = Convert.ToDateTime(rdr["rq"]);
                            item.CC = rdr["cc"].ToString().Trim();
                            item.PH = rdr["ph"].ToString().Trim();

                            if (rdr["zh"] != DBNull.Value) item.ZH = rdr["zh"].ToString().Trim();
                            if (rdr["pz"] != DBNull.Value) item.PZ = rdr["pz"].ToString().Trim();
                            if (rdr["pj"] != DBNull.Value) item.PJ = Convert.ToDecimal(rdr["pj"]);
                            if (rdr["fcsj"] != DBNull.Value) item.FCSJ = rdr["fcsj"].ToString().Trim();
                            if (rdr["bpf"] != DBNull.Value) item.BPF = Convert.ToDecimal(rdr["bpf"]);
                            if (rdr["zwf"] != DBNull.Value) item.ZWF = Convert.ToDecimal(rdr["zwf"]);
                            if (rdr["bz"] != DBNull.Value) item.BZ = rdr["bz"].ToString();
                            if (rdr["spy"] != DBNull.Value) item.SPY = rdr["spy"].ToString().Trim();
                            if (rdr["ydbz"] != DBNull.Value) item.YDBZ = rdr["ydbz"].ToString();
                            if (rdr["hpzbz"] != DBNull.Value) item.HPZBZ = rdr["hpzbz"].ToString();
                            if (rdr["dzbz"] != DBNull.Value) item.DZBZ = rdr["dzbz"].ToString().Trim();
                            if (rdr["cczbz"] != DBNull.Value) item.CCZBZ = rdr["cczbz"].ToString().Trim();
                            if (rdr["dz"] != DBNull.Value) item.DZ = rdr["dz"].ToString().Trim();
                            if (rdr["sprq"] != DBNull.Value) item.SPRQ = Convert.ToDateTime(rdr["sprq"]);
                            if (rdr["lc"] != DBNull.Value) item.LC = Convert.ToInt32(rdr["lc"]);
                            if (rdr["bxf"] != DBNull.Value) item.BXF = Convert.ToDecimal(rdr["bxf"]);
                        }
                    }
                }

                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取车票信息异常：" + ex.Message);
            }
        }

        public static List<CPB> Reads(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                List<CPB> list = new List<CPB>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT * FROM CPB WHERE [RQ] = @RQ AND [CC] = @CC ORDER BY sprq"; // CONVERT(int, zh)";
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            CPB item = new CPB();

                            item.RQ = Convert.ToDateTime(rdr["rq"]);
                            item.CC = rdr["cc"].ToString().Trim();
                            item.PH = rdr["ph"].ToString().Trim();

                            if (rdr["zh"] != DBNull.Value) item.ZH = rdr["zh"].ToString().Trim();
                            if (rdr["pz"] != DBNull.Value) item.PZ = rdr["pz"].ToString().Trim();
                            if (rdr["pj"] != DBNull.Value) item.PJ = Convert.ToDecimal(rdr["pj"]);
                            if (rdr["fcsj"] != DBNull.Value) item.FCSJ = rdr["fcsj"].ToString().Trim();
                            if (rdr["bpf"] != DBNull.Value) item.BPF = Convert.ToDecimal(rdr["bpf"]);
                            if (rdr["zwf"] != DBNull.Value) item.ZWF = Convert.ToDecimal(rdr["zwf"]);
                            if (rdr["bz"] != DBNull.Value) item.BZ = rdr["bz"].ToString();
                            if (rdr["spy"] != DBNull.Value) item.SPY = rdr["spy"].ToString().Trim();
                            if (rdr["ydbz"] != DBNull.Value) item.YDBZ = rdr["ydbz"].ToString();
                            if (rdr["hpzbz"] != DBNull.Value) item.HPZBZ = rdr["hpzbz"].ToString();
                            if (rdr["dzbz"] != DBNull.Value) item.DZBZ = rdr["dzbz"].ToString().Trim();
                            if (rdr["cczbz"] != DBNull.Value) item.CCZBZ = rdr["cczbz"].ToString().Trim();
                            if (rdr["dz"] != DBNull.Value) item.DZ = rdr["dz"].ToString().Trim();
                            if (rdr["sprq"] != DBNull.Value) item.SPRQ = Convert.ToDateTime(rdr["sprq"]);
                            if (rdr["lc"] != DBNull.Value) item.LC = Convert.ToInt32(rdr["lc"]);
                            if (rdr["bxf"] != DBNull.Value) item.BXF = Convert.ToDecimal(rdr["bxf"]);

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取车票信息异常：" + ex.Message);
            }
        }

        public static List<CPB> Reads(SqlConnection conn, DateTime date, String cc, String bz)
        {
            try
            {
                List<CPB> list = new List<CPB>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT * FROM CPB WHERE [RQ] = @RQ AND [CC] = @CC AND [BZ] = @BZ ORDER BY sprq";
                    cmd.Parameters.Add("@BZ", SqlDbType.Char).Value = bz;
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
                    
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            CPB item = new CPB();

                            item.RQ = Convert.ToDateTime(rdr["rq"]);
                            item.CC = rdr["cc"].ToString().Trim();
                            item.PH = rdr["ph"].ToString().Trim();

                            if (rdr["zh"] != DBNull.Value) item.ZH = rdr["zh"].ToString().Trim();
                            if (rdr["pz"] != DBNull.Value) item.PZ = rdr["pz"].ToString().Trim();
                            if (rdr["pj"] != DBNull.Value) item.PJ = Convert.ToDecimal(rdr["pj"]);
                            if (rdr["fcsj"] != DBNull.Value) item.FCSJ = rdr["fcsj"].ToString().Trim();
                            if (rdr["bpf"] != DBNull.Value) item.BPF = Convert.ToDecimal(rdr["bpf"]);
                            if (rdr["zwf"] != DBNull.Value) item.ZWF = Convert.ToDecimal(rdr["zwf"]);
                            if (rdr["bz"] != DBNull.Value) item.BZ = rdr["bz"].ToString();
                            if (rdr["spy"] != DBNull.Value) item.SPY = rdr["spy"].ToString().Trim();
                            if (rdr["ydbz"] != DBNull.Value) item.YDBZ = rdr["ydbz"].ToString();
                            if (rdr["hpzbz"] != DBNull.Value) item.HPZBZ = rdr["hpzbz"].ToString();
                            if (rdr["dzbz"] != DBNull.Value) item.DZBZ = rdr["dzbz"].ToString().Trim();
                            if (rdr["cczbz"] != DBNull.Value) item.CCZBZ = rdr["cczbz"].ToString().Trim();
                            if (rdr["dz"] != DBNull.Value) item.DZ = rdr["dz"].ToString().Trim();
                            if (rdr["sprq"] != DBNull.Value) item.SPRQ = Convert.ToDateTime(rdr["sprq"]);
                            if (rdr["lc"] != DBNull.Value) item.LC = Convert.ToInt32(rdr["lc"]);
                            if (rdr["bxf"] != DBNull.Value) item.BXF = Convert.ToDecimal(rdr["bxf"]);

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取车票信息异常：" + ex.Message);
            }
        }

        //获取结算单明细
        public static List<JSDMXB> Reads_JSDMX(SqlCommand cmd, DateTime rq, String cc)
        {
            try
            {
                List<JSDMXB> list = new List<JSDMXB>();

                cmd.CommandText = "SELECT [DZ], [PZ], [PJ], SUM(BXF) AS BXF, COUNT(*) AS JSS, SUM(PJ) AS JSK, CCZBZ, DZBZ FROM CPB WHERE [RQ] = @RQ AND [CC] = @CC AND [BZ] = 'J' GROUP BY [CC], [DZ], [PZ], [PJ], [CCZBZ], [DZBZ] ORDER BY [DZ], [PZ]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
                cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        JSDMXB item = new JSDMXB();

                        item.RQ = rq;
                        item.CC = cc;

                        if (rdr["DZ"] != DBNull.Value) item.DZ = rdr["DZ"].ToString().Trim();
                        if (rdr["PZ"] != DBNull.Value) item.PZ = rdr["PZ"].ToString().Trim();
                        if (rdr["PJ"] != DBNull.Value) item.PJ = Convert.ToDecimal(rdr["PJ"]);
                        if (rdr["BXF"] != DBNull.Value) item.BXF = Convert.ToDecimal(rdr["BXF"]);
                        if (rdr["JSS"] != DBNull.Value) item.JSS = Convert.ToInt32(rdr["JSS"]);
                        if (rdr["JSK"] != DBNull.Value) item.JSK = Convert.ToDecimal(rdr["JSK"]);
                        if (rdr["CCZBZ"] != DBNull.Value) item.SFDM = rdr["CCZBZ"].ToString().Trim();
                        if (rdr["DZBZ"] != DBNull.Value) item.DZDM = rdr["DZBZ"].ToString().Trim();

                        list.Add(item);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取结算单明细异常：" + ex.Message);
            }
        }

        public static List<JSDMXB> Reads_JSDMX(SqlConnection conn, DateTime rq, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Reads_JSDMX(cmd, rq, cc);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        //插入车票
        public static Boolean Insert(SqlCommand cmd, CPB item)
        {
            try
            {
                //cmd.CommandText = "INSERT INTO CPB ([PH], [CC], [RQ], [ZH], [PZ], [PJ], [FCSJ], [BPF], [ZWF], [BZ], [SPY], [YDBZ], [HPZBZ], [DZBZ], [CCZBZ], [DZ], [SPRQ], [LC], [BXF], [RYFJF], [BXJE], [BXBZ], [BXRXM], [SFZHM], [TFBRY], [TFBSJ], [BDLSH], [TBF]) "
                //    + "VALUES(@PH,  @CC,  @RQ,  @ZH,  @PZ,  @PJ,  @FCSJ,  @BPF,  @ZWF,  @BZ,  @SPY,  @YDBZ,  @HPZBZ,  @DZBZ,  @CCZBZ,  @DZ,  @SPRQ,  @LC,  @BXF,  @RYFJF,  @BXJE,  @BXBZ,  @BXRXM,  @SFZHM,  @TFBRY,  @TFBSJ,  @BDLSH,  @TBF)";
                cmd.CommandText = "INSERT INTO CPB ([PH], [CC], [RQ], [ZH], [PZ], [PJ], [FCSJ], [BPF], [ZWF], [BZ], [SPY], [YDBZ], [HPZBZ], [DZBZ], [CCZBZ], [DZ], [SPRQ], [LC], [BXF], [RYFJF]) "
                                          + "VALUES(@PH,  @CC,  @RQ,  @ZH,  @PZ,  @PJ,  @FCSJ,  @BPF,  @ZWF,  @BZ,  @SPY,  @YDBZ,  @HPZBZ,  @DZBZ,  @CCZBZ,  @DZ,  @SPRQ,  @LC,  @BXF,  @RYFJF)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@PH", SqlDbType.Char).Value = item.PH;
                cmd.Parameters.Add("@CC", SqlDbType.Char).Value = item.CC;
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = item.RQ;
                cmd.Parameters.Add("@ZH", SqlDbType.Char).Value = item.ZH;
                cmd.Parameters.Add("@PZ", SqlDbType.Char).Value = item.PZ;
                cmd.Parameters.Add("@PJ", SqlDbType.Decimal).Value = item.PJ;
                cmd.Parameters.Add("@FCSJ", SqlDbType.Char).Value = item.FCSJ;
                cmd.Parameters.Add("@BPF", SqlDbType.Decimal).Value = item.BPF;
                cmd.Parameters.Add("@ZWF", SqlDbType.Decimal).Value = item.ZWF;
                cmd.Parameters.Add("@BZ", SqlDbType.Char).Value = item.BZ;
                cmd.Parameters.Add("@SPY", SqlDbType.VarChar).Value = item.SPY;
                cmd.Parameters.Add("@YDBZ", SqlDbType.Char).Value = item.YDBZ;
                cmd.Parameters.Add("@HPZBZ", SqlDbType.Char).Value = item.HPZBZ;
                cmd.Parameters.Add("@DZBZ", SqlDbType.Char).Value = item.DZBZ;
                cmd.Parameters.Add("@CCZBZ", SqlDbType.Char).Value = item.CCZBZ;
                cmd.Parameters.Add("@DZ", SqlDbType.Char).Value = item.DZ;
                cmd.Parameters.Add("@SPRQ", SqlDbType.DateTime).Value = item.SPRQ;
                cmd.Parameters.Add("@LC", SqlDbType.Int).Value = item.LC;
                cmd.Parameters.Add("@BXF", SqlDbType.Decimal).Value = item.BXF;
                cmd.Parameters.Add("@RYFJF", SqlDbType.Decimal).Value = item.RYFJF;

                //cmd.Parameters.Add("@BXJE", SqlDbType.Decimal).Value = item.BXJE;
                //cmd.Parameters.Add("@BXBZ", SqlDbType.Char).Value = item.BXBZ;
                //cmd.Parameters.Add("@BXRXM", SqlDbType.VarChar).Value = item.BXRXM;
                //cmd.Parameters.Add("@SFZHM", SqlDbType.VarChar).Value = item.SFZHM;
                //cmd.Parameters.Add("@TFBRY", SqlDbType.VarChar).Value = item.TFBRY;
                //cmd.Parameters.Add("@TFBSJ", SqlDbType.DateTime).Value = item.TFBSJ;
                //cmd.Parameters.Add("@BDLSH", SqlDbType.VarChar).Value = item.BDLSH;
                //cmd.Parameters.Add("@TBF", SqlDbType.Decimal).Value = item.TBF;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入车票异常：" + ex.Message);
            }
        }

        public static Boolean Insert(SqlConnection conn, CPB item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return Insert(cmd, item);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
