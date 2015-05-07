using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class JYB
    {
        //检测经由
        //public static Boolean Exists(SqlConnection conn, DateTime date, String cc, String zddm)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) AS Count FROM JYB WHERE [RQ] = @RQ AND [CC] = @CC AND [ZDDM] = @ZDDM";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
        //            cmd.Parameters.Add("@ZDDM", SqlDbType.Char).Value = zddm;

        //            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("检测经由异常：" + ex.Message);
        //    }
        //}

        //读取经由列表
        //public static List<JYB> Reads(SqlConnection conn, DateTime rq, String cc, String lb)
        //{
        //    try
        //    {
        //        List<JYB> list = new List<JYB>();

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT * FROM JYB WHERE [RQ] = @RQ AND [CC] = @CC ORDER BY [XH]";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
        //            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    JYB item = new JYB();

        //                    item.RQ = rq;
        //                    item.CC = cc;
        //                    if (rdr["zddm"] != DBNull.Value) item.ZDDM = rdr["zddm"].ToString().Trim();
        //                    if (rdr["xh"] != DBNull.Value) item.XH = rdr["xh"].ToString().Trim();
        //                    if (rdr["zt"] != DBNull.Value) item.ZT = rdr["zt"].ToString()[0];
        //                    if (rdr["ydbz"] != DBNull.Value) item.YDBZ = rdr["ydbz"].ToString()[0];

        //                    list.Add(item);
        //                }
        //            }
        //        }

        //        //获取票价信息
        //        foreach (JYB item in list)
        //        {
        //            ZMPJB zmItem = ZMPJB.Read(conn, item.ZDDM, lb);
        //            if(zmItem != null)
        //            {
        //                item.ZM = zmItem.ZM;
        //                item.LC = zmItem.LC;
        //                item.PJ = zmItem.PJ;
        //                item.ZWF = zmItem.ZWF;
        //                item.NM = zmItem.NM;
        //            }
        //        }

        //        return list;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("读取经由列表异常：" + ex.Message);
        //    }
        //}
    }
}
