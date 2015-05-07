using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class JSD
    {
        //增加打印计数
        //public static Boolean AddPrintCount(SqlConnection conn, DateTime date, String cc)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "UPDATE JSD SET [FCBZ] = [FCBZ] + 1 WHERE [RQ] = @RQ AND [CC] = @CC";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

        //            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("增加打印计数异常：" + ex.Message);
        //    }
        //}

        //检测结算单
        //public static Boolean Exists(SqlConnection conn, DateTime date, String cc)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) AS Count FROM JSD WHERE [RQ] = @RQ AND [CC] = @CC";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

        //            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("检测结算单异常：" + ex.Message);
        //    }
        //}

        //public static Boolean Exists(SqlConnection conn, String kyzbm, DateTime date, String cc)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) AS Count FROM JSD WHERE [KYZBM] = @KYZBM AND [RQ] = @RQ AND [CC] = @CC";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@KYZBM", SqlDbType.Char).Value = kyzbm;
        //            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;                    

        //            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("检测结算单异常：" + ex.Message);
        //    }
        //}

        //获取结算信息
        //public static JSD Read(SqlConnection conn, DateTime date, String cc)
        //{
        //    try
        //    {
        //        JSD item = null;

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT * FROM JSD WHERE [RQ] = @RQ AND [CC] = @CC";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.Read())
        //                {
        //                    item = new JSD();

        //                    item.RQ = Convert.ToDateTime(rdr["rq"]);
        //                    item.CC = Convert.ToString(rdr["cc"]).Trim();

        //                    if (rdr["kyzbm"] != DBNull.Value) item.KYZBM = Convert.ToString(rdr["kyzbm"]).Trim();
        //                    if (rdr["kyzmc"] != DBNull.Value) item.KYZMC = Convert.ToString(rdr["kyzmc"]).Trim();
        //                    if (rdr["jsdbh"] != DBNull.Value) item.JSDBH = Convert.ToString(rdr["jsdbh"]).Trim();
        //                    if (rdr["zdz"] != DBNull.Value) item.ZDZ = Convert.ToString(rdr["zdz"]).Trim();
        //                    if (rdr["fcsj"] != DBNull.Value) item.FCSJ = Convert.ToString(rdr["fcsj"]).Trim();
        //                    if (rdr["cph"] != DBNull.Value) item.CPH = Convert.ToString(rdr["cph"]).Trim();
        //                    if (rdr["jsdm"] != DBNull.Value) item.JSDM = Convert.ToString(rdr["jsdm"]).Trim();
        //                    if (rdr["csdw"] != DBNull.Value) item.CSDW = Convert.ToString(rdr["csdw"]).Trim();
        //                    if (rdr["xm"] != DBNull.Value) item.XM = Convert.ToString(rdr["xm"]).Trim();
        //                    if (rdr["xbbs"] != DBNull.Value) item.XBBS = Convert.ToInt32(rdr["xbbs"]);
        //                    if (rdr["xbjs"] != DBNull.Value) item.XBJS = Convert.ToInt32(rdr["xbjs"]);
        //                    if (rdr["jszs"] != DBNull.Value) item.JSZS = Convert.ToInt32(rdr["jszs"]);
        //                    if (rdr["kppk"] != DBNull.Value) item.KPPK = Convert.ToDecimal(rdr["kppk"]);
        //                    if (rdr["kbxf"] != DBNull.Value) item.KBXF = Convert.ToDecimal(rdr["kbxf"]);
        //                    if (rdr["kfjf"] != DBNull.Value) item.KFJF = Convert.ToDecimal(rdr["kfjf"]);
        //                    if (rdr["jspk"] != DBNull.Value) item.JSPK = Convert.ToDecimal(rdr["jspk"]);
        //                    if (rdr["xbyf"] != DBNull.Value) item.XBYF = Convert.ToDecimal(rdr["xbyf"]);
        //                    if (rdr["xbk"] != DBNull.Value) item.XBK = Convert.ToDecimal(rdr["xbk"]);
        //                    if (rdr["hjje"] != DBNull.Value) item.HJJE = Convert.ToDecimal(rdr["hjje"]);
        //                    if (rdr["fcbz"] != DBNull.Value) item.FCBZ = Convert.ToString(rdr["fcbz"]).Trim();
        //                    if (rdr["fkje"] != DBNull.Value) item.FKJE = Convert.ToDecimal(rdr["fkje"]);
        //                    if (rdr["jscz"] != DBNull.Value) item.JSCZ = Convert.ToString(rdr["jscz"]).Trim();
        //                    if (rdr["pkbl"] != DBNull.Value) item.PKBL = Convert.ToDecimal(rdr["pkbl"]);
        //                    if (rdr["xbbl"] != DBNull.Value) item.XBBL = Convert.ToDecimal(rdr["xbbl"]);
        //                    if (rdr["pkdlf"] != DBNull.Value) item.PKDLF = Convert.ToDecimal(rdr["pkdlf"]);
        //                    if (rdr["xbdlf"] != DBNull.Value) item.XBDLF = Convert.ToDecimal(rdr["xbdlf"]);
        //                    if (rdr["bxbz"] != DBNull.Value) item.BXBZ = Convert.ToInt32(rdr["bxbz"]);
        //                    if (rdr["fjbz"] != DBNull.Value) item.FJBZ = Convert.ToInt32(rdr["fjbz"]);
        //                    if (rdr["dbfk"] != DBNull.Value) item.DBFK = Convert.ToDecimal(rdr["dbfk"]);
        //                    if (rdr["jzbz"] != DBNull.Value) item.JZBZ = Convert.ToString(rdr["jzbz"]).Trim();
        //                    if (rdr["jzrq"] != DBNull.Value) item.JZRQ = Convert.ToDateTime(rdr["jzrq"]);
        //                    if (rdr["jzdbh"] != DBNull.Value) item.JZDBH = Convert.ToString(rdr["jzdbh"]).Trim();
        //                    if (rdr["jzdwmc"] != DBNull.Value) item.JZDWMC = Convert.ToString(rdr["jzdwmc"]).Trim();
        //                    if (rdr["jzczy"] != DBNull.Value) item.JZCZY = Convert.ToString(rdr["jzczy"]).Trim();
        //                    if (rdr["ryf"] != DBNull.Value) item.RYF = Convert.ToDecimal(rdr["ryf"]);
        //                }
        //            }
        //        }

        //        return item;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取结算列表异常：" + ex.Message);
        //    }
        //}

        //获取结算列表
        //public static List<JSD> Reads(SqlConnection conn, DateTime date)
        //{
        //    try
        //    {
        //        List<JSD> list = new List<JSD>();

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT JSD.* FROM JSD WHERE [RQ] = @RQ ORDER BY [FCSJ] DESC, [CC]";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    JSD item = new JSD();

        //                    item.RQ = Convert.ToDateTime(rdr["rq"]);
        //                    item.CC = Convert.ToString(rdr["cc"]).Trim();

        //                    if (rdr["kyzbm"] != DBNull.Value) item.KYZBM = Convert.ToString(rdr["kyzbm"]).Trim();
        //                    if (rdr["kyzmc"] != DBNull.Value) item.KYZMC = Convert.ToString(rdr["kyzmc"]).Trim();
        //                    if (rdr["jsdbh"] != DBNull.Value) item.JSDBH = Convert.ToString(rdr["jsdbh"]).Trim();
        //                    if (rdr["zdz"] != DBNull.Value) item.ZDZ = Convert.ToString(rdr["zdz"]).Trim();
        //                    if (rdr["fcsj"] != DBNull.Value) item.FCSJ = Convert.ToString(rdr["fcsj"]).Trim();
        //                    if (rdr["cph"] != DBNull.Value) item.CPH = Convert.ToString(rdr["cph"]).Trim();
        //                    if (rdr["jsdm"] != DBNull.Value) item.JSDM = Convert.ToString(rdr["jsdm"]).Trim();
        //                    if (rdr["csdw"] != DBNull.Value) item.CSDW = Convert.ToString(rdr["csdw"]).Trim();
        //                    if (rdr["xm"] != DBNull.Value) item.XM = Convert.ToString(rdr["xm"]).Trim();
        //                    if (rdr["xbbs"] != DBNull.Value) item.XBBS = Convert.ToInt32(rdr["xbbs"]);
        //                    if (rdr["xbjs"] != DBNull.Value) item.XBJS = Convert.ToInt32(rdr["xbjs"]);
        //                    if (rdr["jszs"] != DBNull.Value) item.JSZS = Convert.ToInt32(rdr["jszs"]);
        //                    if (rdr["kppk"] != DBNull.Value) item.KPPK = Convert.ToDecimal(rdr["kppk"]);
        //                    if (rdr["kbxf"] != DBNull.Value) item.KBXF = Convert.ToDecimal(rdr["kbxf"]);
        //                    if (rdr["kfjf"] != DBNull.Value) item.KFJF = Convert.ToDecimal(rdr["kfjf"]);
        //                    if (rdr["jspk"] != DBNull.Value) item.JSPK = Convert.ToDecimal(rdr["jspk"]);
        //                    if (rdr["xbyf"] != DBNull.Value) item.XBYF = Convert.ToDecimal(rdr["xbyf"]);
        //                    if (rdr["xbk"] != DBNull.Value) item.XBK = Convert.ToDecimal(rdr["xbk"]);
        //                    if (rdr["hjje"] != DBNull.Value) item.HJJE = Convert.ToDecimal(rdr["hjje"]);
        //                    if (rdr["fcbz"] != DBNull.Value) item.FCBZ = Convert.ToString(rdr["fcbz"]).Trim();
        //                    if (rdr["fkje"] != DBNull.Value) item.FKJE = Convert.ToDecimal(rdr["fkje"]);
        //                    if (rdr["jscz"] != DBNull.Value) item.JSCZ = Convert.ToString(rdr["jscz"]).Trim();
        //                    if (rdr["pkbl"] != DBNull.Value) item.PKBL = Convert.ToDecimal(rdr["pkbl"]);
        //                    if (rdr["xbbl"] != DBNull.Value) item.XBBL = Convert.ToDecimal(rdr["xbbl"]);
        //                    if (rdr["pkdlf"] != DBNull.Value) item.PKDLF = Convert.ToDecimal(rdr["pkdlf"]);
        //                    if (rdr["xbdlf"] != DBNull.Value) item.XBDLF = Convert.ToDecimal(rdr["xbdlf"]);
        //                    if (rdr["bxbz"] != DBNull.Value) item.BXBZ = Convert.ToInt32(rdr["bxbz"]);
        //                    if (rdr["fjbz"] != DBNull.Value) item.FJBZ = Convert.ToInt32(rdr["fjbz"]);
        //                    if (rdr["dbfk"] != DBNull.Value) item.DBFK = Convert.ToDecimal(rdr["dbfk"]);
        //                    if (rdr["jzbz"] != DBNull.Value) item.JZBZ = Convert.ToString(rdr["jzbz"]).Trim();
        //                    if (rdr["jzrq"] != DBNull.Value) item.JZRQ = Convert.ToDateTime(rdr["jzrq"]);
        //                    if (rdr["jzdbh"] != DBNull.Value) item.JZDBH = Convert.ToString(rdr["jzdbh"]).Trim();
        //                    if (rdr["jzdwmc"] != DBNull.Value) item.JZDWMC = Convert.ToString(rdr["jzdwmc"]).Trim();
        //                    if (rdr["jzczy"] != DBNull.Value) item.JZCZY = Convert.ToString(rdr["jzczy"]).Trim();
        //                    if (rdr["ryf"] != DBNull.Value) item.RYF = Convert.ToDecimal(rdr["ryf"]);

        //                    list.Add(item);
        //                }
        //            }
        //        }

        //        return list;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取结算列表异常：" + ex.Message);
        //    }
        //}

        //public static List<JSD> Reads_CPH(SqlConnection conn, String cph)
        //{
        //    try
        //    {
        //        List<JSD> list = new List<JSD>();

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT * FROM JSD WHERE [CPH] = @CPH ORDER BY [RQ] DESC";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@CPH", SqlDbType.Char).Value = cph;
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    JSD item = new JSD();

        //                    item.RQ = Convert.ToDateTime(rdr["rq"]);
        //                    item.CC = Convert.ToString(rdr["cc"]).Trim();

        //                    if (rdr["kyzbm"] != DBNull.Value) item.KYZBM = Convert.ToString(rdr["kyzbm"]).Trim();
        //                    if (rdr["kyzmc"] != DBNull.Value) item.KYZMC = Convert.ToString(rdr["kyzmc"]).Trim();
        //                    if (rdr["jsdbh"] != DBNull.Value) item.JSDBH = Convert.ToString(rdr["jsdbh"]).Trim();
        //                    if (rdr["zdz"] != DBNull.Value) item.ZDZ = Convert.ToString(rdr["zdz"]).Trim();
        //                    if (rdr["fcsj"] != DBNull.Value) item.FCSJ = Convert.ToString(rdr["fcsj"]).Trim();
        //                    if (rdr["cph"] != DBNull.Value) item.CPH = Convert.ToString(rdr["cph"]).Trim();
        //                    if (rdr["jsdm"] != DBNull.Value) item.JSDM = Convert.ToString(rdr["jsdm"]).Trim();
        //                    if (rdr["csdw"] != DBNull.Value) item.CSDW = Convert.ToString(rdr["csdw"]).Trim();
        //                    if (rdr["xm"] != DBNull.Value) item.XM = Convert.ToString(rdr["xm"]).Trim();
        //                    if (rdr["xbbs"] != DBNull.Value) item.XBBS = Convert.ToInt32(rdr["xbbs"]);
        //                    if (rdr["xbjs"] != DBNull.Value) item.XBJS = Convert.ToInt32(rdr["xbjs"]);
        //                    if (rdr["jszs"] != DBNull.Value) item.JSZS = Convert.ToInt32(rdr["jszs"]);
        //                    if (rdr["kppk"] != DBNull.Value) item.KPPK = Convert.ToDecimal(rdr["kppk"]);
        //                    if (rdr["kbxf"] != DBNull.Value) item.KBXF = Convert.ToDecimal(rdr["kbxf"]);
        //                    if (rdr["kfjf"] != DBNull.Value) item.KFJF = Convert.ToDecimal(rdr["kfjf"]);
        //                    if (rdr["jspk"] != DBNull.Value) item.JSPK = Convert.ToDecimal(rdr["jspk"]);
        //                    if (rdr["xbyf"] != DBNull.Value) item.XBYF = Convert.ToDecimal(rdr["xbyf"]);
        //                    if (rdr["xbk"] != DBNull.Value) item.XBK = Convert.ToDecimal(rdr["xbk"]);
        //                    if (rdr["hjje"] != DBNull.Value) item.HJJE = Convert.ToDecimal(rdr["hjje"]);
        //                    if (rdr["fcbz"] != DBNull.Value) item.FCBZ = Convert.ToString(rdr["fcbz"]).Trim();
        //                    if (rdr["fkje"] != DBNull.Value) item.FKJE = Convert.ToDecimal(rdr["fkje"]);
        //                    if (rdr["jscz"] != DBNull.Value) item.JSCZ = Convert.ToString(rdr["jscz"]).Trim();
        //                    if (rdr["pkbl"] != DBNull.Value) item.PKBL = Convert.ToDecimal(rdr["pkbl"]);
        //                    if (rdr["xbbl"] != DBNull.Value) item.XBBL = Convert.ToDecimal(rdr["xbbl"]);
        //                    if (rdr["pkdlf"] != DBNull.Value) item.PKDLF = Convert.ToDecimal(rdr["pkdlf"]);
        //                    if (rdr["xbdlf"] != DBNull.Value) item.XBDLF = Convert.ToDecimal(rdr["xbdlf"]);
        //                    if (rdr["bxbz"] != DBNull.Value) item.BXBZ = Convert.ToInt32(rdr["bxbz"]);
        //                    if (rdr["fjbz"] != DBNull.Value) item.FJBZ = Convert.ToInt32(rdr["fjbz"]);
        //                    if (rdr["dbfk"] != DBNull.Value) item.DBFK = Convert.ToDecimal(rdr["dbfk"]);
        //                    if (rdr["jzbz"] != DBNull.Value) item.JZBZ = Convert.ToString(rdr["jzbz"]).Trim();
        //                    if (rdr["jzrq"] != DBNull.Value) item.JZRQ = Convert.ToDateTime(rdr["jzrq"]);
        //                    if (rdr["jzdbh"] != DBNull.Value) item.JZDBH = Convert.ToString(rdr["jzdbh"]).Trim();
        //                    if (rdr["jzdwmc"] != DBNull.Value) item.JZDWMC = Convert.ToString(rdr["jzdwmc"]).Trim();
        //                    if (rdr["jzczy"] != DBNull.Value) item.JZCZY = Convert.ToString(rdr["jzczy"]).Trim();
        //                    if (rdr["ryf"] != DBNull.Value) item.RYF = Convert.ToDecimal(rdr["ryf"]);

        //                    list.Add(item);
        //                }
        //            }
        //        }

        //        return list;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取结算列表异常：" + ex.Message);
        //    }
        //}

        //public static List<JSD> Reads_JPK(SqlConnection conn, DateTime date, String jpk)
        //{
        //    try
        //    {
        //        List<JSD> list = new List<JSD>();

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT JSD.* FROM JSD, BCK WHERE JSD.[RQ] = @RQ AND JSD.[RQ] = BCK.[RQ] AND JSD.[CC] = BCK.[CC] AND BCK.[JPK] = @JPK ORDER BY JSD.[FCSJ] DESC, JSD.[CC]";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //            cmd.Parameters.Add("@JPK", SqlDbType.Char).Value = jpk;
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    JSD item = new JSD();

        //                    item.RQ = Convert.ToDateTime(rdr["rq"]);
        //                    item.CC = Convert.ToString(rdr["cc"]).Trim();

        //                    if (rdr["kyzbm"] != DBNull.Value) item.KYZBM = Convert.ToString(rdr["kyzbm"]).Trim();
        //                    if (rdr["kyzmc"] != DBNull.Value) item.KYZMC = Convert.ToString(rdr["kyzmc"]).Trim();
        //                    if (rdr["jsdbh"] != DBNull.Value) item.JSDBH = Convert.ToString(rdr["jsdbh"]).Trim();
        //                    if (rdr["zdz"] != DBNull.Value) item.ZDZ = Convert.ToString(rdr["zdz"]).Trim();
        //                    if (rdr["fcsj"] != DBNull.Value) item.FCSJ = Convert.ToString(rdr["fcsj"]).Trim();
        //                    if (rdr["cph"] != DBNull.Value) item.CPH = Convert.ToString(rdr["cph"]).Trim();
        //                    if (rdr["jsdm"] != DBNull.Value) item.JSDM = Convert.ToString(rdr["jsdm"]).Trim();
        //                    if (rdr["csdw"] != DBNull.Value) item.CSDW = Convert.ToString(rdr["csdw"]).Trim();
        //                    if (rdr["xm"] != DBNull.Value) item.XM = Convert.ToString(rdr["xm"]).Trim();
        //                    if (rdr["xbbs"] != DBNull.Value) item.XBBS = Convert.ToInt32(rdr["xbbs"]);
        //                    if (rdr["xbjs"] != DBNull.Value) item.XBJS = Convert.ToInt32(rdr["xbjs"]);
        //                    if (rdr["jszs"] != DBNull.Value) item.JSZS = Convert.ToInt32(rdr["jszs"]);
        //                    if (rdr["kppk"] != DBNull.Value) item.KPPK = Convert.ToDecimal(rdr["kppk"]);
        //                    if (rdr["kbxf"] != DBNull.Value) item.KBXF = Convert.ToDecimal(rdr["kbxf"]);
        //                    if (rdr["kfjf"] != DBNull.Value) item.KFJF = Convert.ToDecimal(rdr["kfjf"]);
        //                    if (rdr["jspk"] != DBNull.Value) item.JSPK = Convert.ToDecimal(rdr["jspk"]);
        //                    if (rdr["xbyf"] != DBNull.Value) item.XBYF = Convert.ToDecimal(rdr["xbyf"]);
        //                    if (rdr["xbk"] != DBNull.Value) item.XBK = Convert.ToDecimal(rdr["xbk"]);
        //                    if (rdr["hjje"] != DBNull.Value) item.HJJE = Convert.ToDecimal(rdr["hjje"]);
        //                    if (rdr["fcbz"] != DBNull.Value) item.FCBZ = Convert.ToString(rdr["fcbz"]).Trim();
        //                    if (rdr["fkje"] != DBNull.Value) item.FKJE = Convert.ToDecimal(rdr["fkje"]);
        //                    if (rdr["jscz"] != DBNull.Value) item.JSCZ = Convert.ToString(rdr["jscz"]).Trim();
        //                    if (rdr["pkbl"] != DBNull.Value) item.PKBL = Convert.ToDecimal(rdr["pkbl"]);
        //                    if (rdr["xbbl"] != DBNull.Value) item.XBBL = Convert.ToDecimal(rdr["xbbl"]);
        //                    if (rdr["pkdlf"] != DBNull.Value) item.PKDLF = Convert.ToDecimal(rdr["pkdlf"]);
        //                    if (rdr["xbdlf"] != DBNull.Value) item.XBDLF = Convert.ToDecimal(rdr["xbdlf"]);
        //                    if (rdr["bxbz"] != DBNull.Value) item.BXBZ = Convert.ToInt32(rdr["bxbz"]);
        //                    if (rdr["fjbz"] != DBNull.Value) item.FJBZ = Convert.ToInt32(rdr["fjbz"]);
        //                    if (rdr["dbfk"] != DBNull.Value) item.DBFK = Convert.ToDecimal(rdr["dbfk"]);
        //                    if (rdr["jzbz"] != DBNull.Value) item.JZBZ = Convert.ToString(rdr["jzbz"]).Trim();
        //                    if (rdr["jzrq"] != DBNull.Value) item.JZRQ = Convert.ToDateTime(rdr["jzrq"]);
        //                    if (rdr["jzdbh"] != DBNull.Value) item.JZDBH = Convert.ToString(rdr["jzdbh"]).Trim();
        //                    if (rdr["jzdwmc"] != DBNull.Value) item.JZDWMC = Convert.ToString(rdr["jzdwmc"]).Trim();
        //                    if (rdr["jzczy"] != DBNull.Value) item.JZCZY = Convert.ToString(rdr["jzczy"]).Trim();
        //                    if (rdr["ryf"] != DBNull.Value) item.RYF = Convert.ToDecimal(rdr["ryf"]);

        //                    list.Add(item);
        //                }
        //            }
        //        }

        //        return list;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取结算列表异常：" + ex.Message);
        //    }
        //}

        //插入结算单
        //public static Boolean Insert(SqlCommand cmd, JSD item)
        //{
        //    try
        //    {
        //        cmd.CommandText = "INSERT INTO jsd (kyzbm, kyzmc, jsdbh, rq, cc, zdz, fcsj, cph, jsdm, csdw, xm, xbbs, xbjs, jszs, kppk, kbxf, kfjf, jspk, xbyf, xbk, hjje, fcbz, fkje, jscz, pkbl, xbbl, pkdlf, xbdlf, bxbz, fjbz, dbfk, jzbz, jzdbh, jzdwmc, jzczy, ryf ) "
        //                            + " VALUES(@kyzbm, @kyzmc, @jsdbh, @rq, @cc, @zdz, @fcsj, @cph, @jsdm, @csdw, @xm, @xbbs, @xbjs, @jszs, @kppk, @kbxf, @kfjf, @jspk, @xbyf, @xbk, @hjje, @fcbz, @fkje, @jscz, @pkbl, @xbbl, @pkdlf, @xbdlf, @bxbz, @fjbz, @dbfk, @jzbz, @jzdbh, @jzdwmc, @jzczy, @ryf )";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.Add("@kyzbm", SqlDbType.Char).Value = item.KYZBM;
        //        cmd.Parameters.Add("@kyzmc", SqlDbType.Char).Value = item.KYZMC;
        //        cmd.Parameters.Add("@jsdbh", SqlDbType.Char).Value = item.JSDBH;
        //        cmd.Parameters.Add("@rq", SqlDbType.DateTime).Value = item.RQ;
        //        cmd.Parameters.Add("@cc", SqlDbType.Char).Value = item.CC;
        //        cmd.Parameters.Add("@zdz", SqlDbType.Char).Value = item.ZDZ;
        //        cmd.Parameters.Add("@fcsj", SqlDbType.Char).Value = item.FCSJ;
        //        cmd.Parameters.Add("@cph", SqlDbType.Char).Value = item.CPH;
        //        cmd.Parameters.Add("@jsdm", SqlDbType.Char).Value = item.JSDM;
        //        cmd.Parameters.Add("@csdw", SqlDbType.Char).Value = item.CSDW;
        //        cmd.Parameters.Add("@xm", SqlDbType.Char).Value = item.XM;
        //        cmd.Parameters.Add("@xbbs", SqlDbType.Int).Value = item.XBBS;
        //        cmd.Parameters.Add("@xbjs", SqlDbType.Int).Value = item.XBJS;
        //        cmd.Parameters.Add("@jszs", SqlDbType.Int).Value = item.JSZS;
        //        cmd.Parameters.Add("@kppk", SqlDbType.Decimal).Value = item.KPPK;
        //        cmd.Parameters.Add("@kbxf", SqlDbType.Decimal).Value = item.KBXF;
        //        cmd.Parameters.Add("@kfjf", SqlDbType.Decimal).Value = item.KFJF;
        //        cmd.Parameters.Add("@jspk", SqlDbType.Decimal).Value = item.JSPK;
        //        cmd.Parameters.Add("@xbyf", SqlDbType.Decimal).Value = item.XBYF;
        //        cmd.Parameters.Add("@xbk", SqlDbType.Decimal).Value = item.XBK;
        //        cmd.Parameters.Add("@hjje", SqlDbType.Decimal).Value = item.HJJE;
        //        cmd.Parameters.Add("@fcbz", SqlDbType.Char).Value = item.FCBZ;
        //        cmd.Parameters.Add("@fkje", SqlDbType.Decimal).Value = item.FKJE;
        //        cmd.Parameters.Add("@jscz", SqlDbType.Char).Value = item.JSCZ;
        //        cmd.Parameters.Add("@pkbl", SqlDbType.Decimal).Value = item.PKBL;
        //        cmd.Parameters.Add("@xbbl", SqlDbType.Decimal).Value = item.XBBL;
        //        cmd.Parameters.Add("@pkdlf", SqlDbType.Decimal).Value = item.PKDLF;
        //        cmd.Parameters.Add("@xbdlf", SqlDbType.Decimal).Value = item.XBDLF;
        //        cmd.Parameters.Add("@bxbz", SqlDbType.Char).Value = item.BXBZ;
        //        cmd.Parameters.Add("@fjbz", SqlDbType.Char).Value = item.FJBZ;
        //        cmd.Parameters.Add("@dbfk", SqlDbType.Decimal).Value = item.DBFK;
        //        cmd.Parameters.Add("@jzbz", SqlDbType.Char).Value = item.JZBZ;
        //        cmd.Parameters.Add("@jzdbh", SqlDbType.Char).Value = item.JZDBH;
        //        cmd.Parameters.Add("@jzdwmc", SqlDbType.Char).Value = item.JZDWMC;
        //        cmd.Parameters.Add("@jzczy", SqlDbType.Char).Value = item.JZCZY;
        //        cmd.Parameters.Add("@ryf", SqlDbType.Decimal).Value = item.RYF;

        //        return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("插入结算单异常：" + ex.Message);
        //    }
        //}

        //删除结算单
        //public static Boolean Delete(SqlCommand cmd, DateTime date, String cc)
        //{
        //    try
        //    {
        //        cmd.CommandText = "DELETE FROM JSD WHERE [RQ] = @RQ AND [CC] = @CC";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //        cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

        //        return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("删除结算单异常：" + ex.Message);
        //    }
        //}

        //public static Boolean Delete(SqlCommand cmd, String kyzbm, DateTime date, String cc)
        //{
        //    try
        //    {
        //        cmd.CommandText = "DELETE FROM JSD WHERE [KYZBM] = @KYZBM AND [RQ] = @RQ AND [CC] = @CC";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.Add("@KYZBM", SqlDbType.Char).Value = kyzbm;
        //        cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
        //        cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

        //        return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("删除结算单异常：" + ex.Message);
        //    }
        //}
    }
}
