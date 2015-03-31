using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class QDRecord
    {
        public DateTime RQ { get; set; }
        public String CC { get; set; }
        public String ZDZ { get; set; }
        public String FCSJ { get; set; }
        public String CPH { get; set; }
        public String CID { get; set; }
        public DateTime IDT { get; set; }
        public DateTime ODT { get; set; }
        public DateTime WDT { get; set; }

        //检测
        public static Boolean Exists(SqlConnection conn, DateTime date)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM QDRecord WHERE [RQ] = @RQ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测签到记录异常：" + ex.Message);
            }
        }

        public static Boolean Exists(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM QDRecord WHERE [RQ] = @RQ AND [CC] = @CC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测签到记录异常：" + ex.Message);
            }
        }

        public static List<QDRecord> Reads(SqlConnection conn, DateTime sd, DateTime ed)
        {
            try
            {
                List<QDRecord> list = new List<QDRecord>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM QDRecord WHERE RQ >= @SD AND RQ <= @ED";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@SD", SqlDbType.DateTime).Value = sd;
                    cmd.Parameters.Add("@ED", SqlDbType.DateTime).Value = ed;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            QDRecord item = new QDRecord();

                            if (rdr["RQ"] != DBNull.Value) item.RQ = Convert.ToDateTime(rdr["RQ"]);
                            if (rdr["CC"] != DBNull.Value) item.CC = rdr["CC"].ToString().Trim();
                            if (rdr["ZDZ"] != DBNull.Value) item.ZDZ = rdr["ZDZ"].ToString().Trim();
                            if (rdr["FCSJ"] != DBNull.Value) item.FCSJ = rdr["FCSJ"].ToString().Trim();
                            if (rdr["CPH"] != DBNull.Value) item.CPH = rdr["CPH"].ToString().Trim();
                            if (rdr["CID"] != DBNull.Value) item.CID = rdr["CID"].ToString().Trim();
                            if (rdr["IDT"] != DBNull.Value) item.IDT = Convert.ToDateTime(rdr["IDT"]);
                            if (rdr["ODT"] != DBNull.Value) item.ODT = Convert.ToDateTime(rdr["ODT"]);
                            if (rdr["WDT"] != DBNull.Value) item.WDT = Convert.ToDateTime(rdr["WDT"]);

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取签到记录异常：" + ex.Message);
            }
        }

        public static bool Delete(SqlConnection conn, DateTime date)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM QDRecord WHERE [RQ] = @RQ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除签到记录异常：" + ex.Message);
            }
        }

        public static bool Delete(SqlConnection conn, DateTime sd, DateTime ed)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM QDRecord WHERE [RQ] >= @SD AND [RQ] <= @ED";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@SD", SqlDbType.DateTime).Value = sd;
                    cmd.Parameters.Add("@ED", SqlDbType.DateTime).Value = ed;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除签到记录异常：" + ex.Message);
            }
        }

        public static bool Insert(SqlConnection conn, QDRecord item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO QDRecord ([RQ], [CC], [ZDZ], [FCSJ], [CPH], [CID], [IDT], [ODT], [WDT]) VALUES( @RQ, @CC, @ZDZ, @FCSJ, @CPH, @CID, @IDT, @ODT, @WDT) ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = item.RQ;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = item.CC;
                    cmd.Parameters.Add("@ZDZ", SqlDbType.VarChar).Value = item.ZDZ;
                    cmd.Parameters.Add("@FCSJ", SqlDbType.Char).Value = item.FCSJ;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = item.CPH;
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = item.CID;
                    cmd.Parameters.Add("@IDT", SqlDbType.DateTime).Value = item.IDT;
                    cmd.Parameters.Add("@ODT", SqlDbType.DateTime).Value = item.ODT;
                    cmd.Parameters.Add("@WDT", SqlDbType.DateTime).Value = item.WDT;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入签到记录异常：" + ex.Message);
            }
        }

        public static bool SetODT(SqlConnection conn, DateTime rq, String cc, DateTime odt)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE QDRecord SET [ODT] = @ODT WHERE [RQ] = @RQ AND [CC] = @CC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;
                    cmd.Parameters.Add("@ODT", SqlDbType.DateTime).Value = odt;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("设置出站签到时间异常：" + ex.Message);
            }
        }

        public static bool SetWDT(SqlConnection conn, DateTime rq, String cc, DateTime wdt)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE QDRecord SET [WDT] = @WDT WHERE [RQ] = @RQ AND [CC] = @CC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;
                    cmd.Parameters.Add("@WDT", SqlDbType.DateTime).Value = wdt;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("设置外环签到时间异常：" + ex.Message);
            }
        }
    }
}
