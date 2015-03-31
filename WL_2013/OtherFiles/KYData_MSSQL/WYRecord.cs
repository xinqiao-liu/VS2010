using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class WYRecord
    {       
        public String ID { get; set; }
        public String CPH { get; set; }
        public String DW { get; set; }
        public String CZ { get; set; }
        public DateTime RQ { get; set; }
        public String DD { get; set; }
        public String SFZ { get; set; }
        public String ZDZ { get; set; }
        public String WYX { get; set; }
        public decimal WYJ { get; set; }
        public String JBR { get; set; }
        public String LRR { get; set; }
        public DateTime CDT { get; set; }
        public String Print { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        public static bool Exists(SqlConnection conn, String id)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM WYRecord WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测违约信息异常：" + ex.Message);
            }
        }

        //获取违约信息
        public static WYRecord Read(SqlConnection conn, String id)
        {
            try
            {
                WYRecord item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WYRecord WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new WYRecord();
                            item.ID = id;

                            if (rdr["CPH"] != DBNull.Value) item.CPH = rdr["CPH"].ToString().Trim();
                            if (rdr["DW"] != DBNull.Value) item.DW = rdr["DW"].ToString().Trim();
                            if (rdr["CZ"] != DBNull.Value) item.CZ = rdr["CZ"].ToString().Trim();
                            if (rdr["RQ"] != DBNull.Value) item.RQ = Convert.ToDateTime(rdr["RQ"]);
                            if (rdr["DD"] != DBNull.Value) item.DD = rdr["DD"].ToString().Trim();
                            if (rdr["SFZ"] != DBNull.Value) item.SFZ = rdr["SFZ"].ToString().Trim();
                            if (rdr["ZDZ"] != DBNull.Value) item.ZDZ = rdr["ZDZ"].ToString().Trim();
                            if (rdr["WYX"] != DBNull.Value) item.WYX = rdr["WYX"].ToString().Trim();
                            if (rdr["WYJ"] != DBNull.Value) item.WYJ = Convert.ToDecimal(rdr["WYJ"]);
                            if (rdr["JBR"] != DBNull.Value) item.JBR = rdr["JBR"].ToString().Trim();
                            if (rdr["LRR"] != DBNull.Value) item.LRR = rdr["LRR"].ToString().Trim();
                            if (rdr["CDT"] != DBNull.Value) item.CDT = Convert.ToDateTime(rdr["CDT"]);
                            if (rdr["Print"] != DBNull.Value) item.Print = rdr["Print"].ToString().Trim();
                        }
                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取违约信息异常：" + ex.Message);
            }
        }

        //获取违约列表
        public static List<WYRecord> Reads(SqlConnection conn)
        {
            try
            {
                List<WYRecord> list = new List<WYRecord>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WYRecord ORDER BY [CDT] DESC";
                    cmd.Parameters.Clear();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            WYRecord item = new WYRecord();

                            if (rdr["ID"] != DBNull.Value) item.ID = rdr["ID"].ToString().Trim();
                            if (rdr["CPH"] != DBNull.Value) item.CPH = rdr["CPH"].ToString().Trim();
                            if (rdr["DW"] != DBNull.Value) item.DW = rdr["DW"].ToString().Trim();
                            if (rdr["CZ"] != DBNull.Value) item.CZ = rdr["CZ"].ToString().Trim();
                            if (rdr["RQ"] != DBNull.Value) item.RQ = Convert.ToDateTime(rdr["RQ"]);
                            if (rdr["DD"] != DBNull.Value) item.DD = rdr["DD"].ToString().Trim();
                            if (rdr["SFZ"] != DBNull.Value) item.SFZ = rdr["SFZ"].ToString().Trim();
                            if (rdr["ZDZ"] != DBNull.Value) item.ZDZ = rdr["ZDZ"].ToString().Trim();
                            if (rdr["WYX"] != DBNull.Value) item.WYX = rdr["WYX"].ToString().Trim();
                            if (rdr["WYJ"] != DBNull.Value) item.WYJ = Convert.ToDecimal(rdr["WYJ"]);
                            if (rdr["JBR"] != DBNull.Value) item.JBR = rdr["JBR"].ToString().Trim();
                            if (rdr["LRR"] != DBNull.Value) item.LRR = rdr["LRR"].ToString().Trim();
                            if (rdr["CDT"] != DBNull.Value) item.CDT = Convert.ToDateTime(rdr["CDT"]);
                            if (rdr["Print"] != DBNull.Value) item.Print = rdr["Print"].ToString().Trim();

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取违约列表异常：" + ex.Message);
            }
        }

        public static List<WYRecord> Reads(SqlConnection conn, String cph)
        {
            try
            {
                List<WYRecord> list = new List<WYRecord>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WYRecord WHERE [CPH] = @CPH ORDER BY [CDT] DESC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = cph;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            WYRecord item = new WYRecord();

                            if (rdr["ID"] != DBNull.Value) item.ID = rdr["ID"].ToString().Trim();
                            if (rdr["CPH"] != DBNull.Value) item.CPH = rdr["CPH"].ToString().Trim();
                            if (rdr["DW"] != DBNull.Value) item.DW = rdr["DW"].ToString().Trim();
                            if (rdr["CZ"] != DBNull.Value) item.CZ = rdr["CZ"].ToString().Trim();
                            if (rdr["RQ"] != DBNull.Value) item.RQ = Convert.ToDateTime(rdr["RQ"]);
                            if (rdr["DD"] != DBNull.Value) item.DD = rdr["DD"].ToString().Trim();
                            if (rdr["SFZ"] != DBNull.Value) item.SFZ = rdr["SFZ"].ToString().Trim();
                            if (rdr["ZDZ"] != DBNull.Value) item.ZDZ = rdr["ZDZ"].ToString().Trim();
                            if (rdr["WYX"] != DBNull.Value) item.WYX = rdr["WYX"].ToString().Trim();
                            if (rdr["WYJ"] != DBNull.Value) item.WYJ = Convert.ToDecimal(rdr["WYJ"]);
                            if (rdr["JBR"] != DBNull.Value) item.JBR = rdr["JBR"].ToString().Trim();
                            if (rdr["LRR"] != DBNull.Value) item.LRR = rdr["LRR"].ToString().Trim();
                            if (rdr["CDT"] != DBNull.Value) item.CDT = Convert.ToDateTime(rdr["CDT"]);
                            if (rdr["Print"] != DBNull.Value) item.Print = rdr["Print"].ToString().Trim();

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取违约列表异常：" + ex.Message);
            }
        }

        //插入违约信息
        public static bool Insert(SqlConnection conn, WYRecord wyRecord)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WYRecord ([ID], [CPH], [DW], [CZ], [RQ], [DD], [SFZ], [ZDZ], [WYX], [WYJ], [JBR], [LRR], [Print]) "
                        + " VALUES( @ID, @CPH, @DW, @CZ, @RQ, @DD, @SFZ, @ZDZ, @WYX, @WYJ, @JBR, @LRR, @Print) ";
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = wyRecord.ID;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = wyRecord.CPH;
                    cmd.Parameters.Add("@DW", SqlDbType.NVarChar).Value = wyRecord.DW;
                    cmd.Parameters.Add("@CZ", SqlDbType.NVarChar).Value = wyRecord.CZ;
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = wyRecord.RQ;
                    cmd.Parameters.Add("@DD", SqlDbType.NVarChar).Value = wyRecord.DD;
                    cmd.Parameters.Add("@SFZ", SqlDbType.NVarChar).Value = wyRecord.SFZ;
                    cmd.Parameters.Add("@ZDZ", SqlDbType.NVarChar).Value = wyRecord.ZDZ;
                    cmd.Parameters.Add("@WYX", SqlDbType.NVarChar).Value = wyRecord.WYX;
                    cmd.Parameters.Add("@WYJ", SqlDbType.Decimal).Value = wyRecord.WYJ;
                    cmd.Parameters.Add("@JBR", SqlDbType.NVarChar).Value = wyRecord.JBR;
                    cmd.Parameters.Add("@LRR", SqlDbType.NVarChar).Value = wyRecord.LRR;
                    cmd.Parameters.Add("@Print", SqlDbType.Char).Value = wyRecord.Print[0];

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入违约信息异常：" + ex.Message);
            }
        }
    }
}
