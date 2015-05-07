using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class ZMPJB
    {
        //获取站点信息
        //public static ZMPJB Read(SqlConnection conn, String zddm, String lb)
        //{
        //    try
        //    {
        //        String temp = lb[0].ToString();
        //        ZMPJB item = null;

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT [ZM], L" + temp + ", " + temp + ", [ZWF], [NM] FROM ZMPJB WHERE [ZDDM] = @ZDDM";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@ZDDM", SqlDbType.Char).Value = zddm;
        //            //cmd.Parameters.Add("@LB", SqlDbType.Char).Value = temp;

        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.Read())
        //                {
        //                    item = new ZMPJB();

        //                    item.ZDDM = zddm;

        //                    if (rdr["zm"] != DBNull.Value) item.ZM = rdr["zm"].ToString().Trim();
        //                    if (rdr["l" + temp] != DBNull.Value) item.LC = Convert.ToInt32(rdr["l" + temp]);
        //                    if (rdr[temp] != DBNull.Value) item.PJ = Convert.ToDecimal(rdr[temp]);
        //                    if (rdr["zwf"] != DBNull.Value) item.ZWF = Convert.ToDecimal(rdr["zwf"]);
        //                    if (rdr["nm"] != DBNull.Value) item.NM = rdr["nm"].ToString().Trim();
        //                }
        //            }
        //        }

        //        return item;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取站点信息异常：" + ex.Message);
        //    }
        //}

        //获取站点名称
        //public static String GetName(SqlConnection conn, String nm)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT [ZM] FROM ZMPJB WHERE [NM] = @NM";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@NM", SqlDbType.Char).Value = nm;

        //            return Convert.ToString(cmd.ExecuteScalar()).Trim();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取站点名称异常：" + ex.Message);
        //    }
        //}

        //获取站点代码
        //public static String GetCode(SqlConnection conn, String nm)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT [ZDDM] FROM ZMPJB WHERE [NM] = @NM";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@NM", SqlDbType.Char).Value = nm;

        //            return Convert.ToString(cmd.ExecuteScalar()).Trim();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取站点代码异常：" + ex.Message);
        //    }
        //}
    }
}
