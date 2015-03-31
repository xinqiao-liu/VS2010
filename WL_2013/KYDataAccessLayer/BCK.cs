using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYDataAccessLayer
{    
    public static class BCK
    {
        public static Boolean Exist(SqlCommand cmd, DateTime date, String cc)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static Boolean ExistByZDDM(SqlCommand cmd, DateTime date, String code)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM BCK INNER JOIN JYB ON BCK.cc = JYB.cc AND BCK.rq = JYB.rq "
                + "WHERE BCK.rq = @rq AND (BCK.zt LIKE '售%' OR BCK.zt LIKE '检%' OR BCK.zt LIKE '待%' OR BCK.zt LIKE '停%') AND JYB.zddm = @zddm AND JYB.zt = 'N'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@rq", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@zddm", SqlDbType.VarChar).Value = code;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static KYDataModelLayer.BCK Read(SqlCommand cmd, DateTime date, String cc)
        {
            KYDataModelLayer.BCK item = null;

            cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    item = new KYDataModelLayer.BCK();

                    item.RQ = date;

                    if (rdr["cc"] != DBNull.Value) item.CC = rdr["cc"].ToString().Trim();
                    if (rdr["zdz"] != DBNull.Value) item.ZDZ = rdr["zdz"].ToString().Trim();
                    if (rdr["yxlb"] != DBNull.Value) item.YXLB = rdr["yxlb"].ToString().Trim();
                    if (rdr["fcsj"] != DBNull.Value) item.FCSJ = rdr["fcsj"].ToString().Trim();
                    if (rdr["jpk"] != DBNull.Value) item.JPK = rdr["jpk"].ToString().Trim();
                    if (rdr["pjlb"] != DBNull.Value) item.PJLB = rdr["pjlb"].ToString().Trim();
                    if (rdr["zt"] != DBNull.Value) item.ZT = rdr["zt"].ToString().Trim();
                    if (rdr["jydm"] != DBNull.Value) item.JYDM = rdr["jydm"].ToString().Trim();
                    if (rdr["dy"] != DBNull.Value) item.DY = Convert.ToInt32(rdr["dy"]);
                    if (rdr["cph"] != DBNull.Value) item.CPH = rdr["cph"].ToString().Trim();
                    if (rdr["cx"] != DBNull.Value) item.CX = rdr["cx"].ToString().Trim();
                    if (rdr["scs"] != DBNull.Value) item.SCS = Convert.ToInt32(rdr["scs"]);
                    if (rdr["ydxs"] != DBNull.Value) item.YDXS = Convert.ToInt32(rdr["ydxs"]);
                    if (rdr["xllb"] != DBNull.Value) item.XLLB = rdr["xllb"].ToString().Trim();
                    if (rdr["sfzdm"] != DBNull.Value) item.SFZDM = rdr["sfzdm"].ToString().Trim();
                    if (rdr["dzdm"] != DBNull.Value) item.DZDM = rdr["dzdm"].ToString().Trim();
                    if (rdr["xljy"] != DBNull.Value) item.XLJY = rdr["xljy"].ToString().Trim();
                    if (rdr["lmdm"] != DBNull.Value) item.LMDM = rdr["lmdm"].ToString().Trim();
                    if (rdr["lcdm"] != DBNull.Value) item.LCDM = rdr["lcdm"].ToString().Trim();
                    if (rdr["zh"] != DBNull.Value) item.ZH = rdr["zh"].ToString().Trim();
                    if (rdr["bdsj"] != DBNull.Value) item.BDSJ = Convert.ToDateTime(rdr["bdsj"]);
                    if (rdr["wdsj"] != DBNull.Value) item.WDSJ = Convert.ToInt32(rdr["wdsj"]);
                    if (rdr["wdfk"] != DBNull.Value) item.WDFK = Convert.ToDecimal(rdr["wdfk"]);
                    if (rdr["wdbz"] != DBNull.Value) item.WDBZ = rdr["wdbz"].ToString().Trim();
                    if (rdr["jcbz"] != DBNull.Value) item.JCBZ = rdr["jcbz"].ToString().Trim();
                    if (rdr["sfbz"] != DBNull.Value) item.SFBZ = rdr["sfbz"].ToString().Trim();
                    if (rdr["qzlc"] != DBNull.Value) item.QZLC = Convert.ToInt32(rdr["qzlc"]);
                    if (rdr["yxsj"] != DBNull.Value) item.YXSJ = rdr["yxsj"].ToString().Trim();
                    if (rdr["server"] != DBNull.Value) item.Server = rdr["server"].ToString().Trim();
                    if (rdr["dhbz"] != DBNull.Value) item.DHBZ = rdr["dhbz"].ToString().Trim();
                    if (rdr["tpbz"] != DBNull.Value) item.TPBZ = rdr["tpbz"].ToString().Trim();
                    if (rdr["zwfbz"] != DBNull.Value) item.ZWFBZ = rdr["zwfbz"].ToString().Trim();
                    if (rdr["spbz"] != DBNull.Value) item.SPBZ = rdr["spbz"].ToString().Trim();
                    if (rdr["ylbz"] != DBNull.Value) item.YLBZ = rdr["ylbz"].ToString().Trim();
                    if (rdr["ylsl"] != DBNull.Value) item.YLSL = Convert.ToInt32(rdr["ylsl"]);
                    if (rdr["cyxl"] != DBNull.Value) item.CYXL = Convert.ToInt32(rdr["cyxl"]);
                    if (rdr["ckbz"] != DBNull.Value) item.CKBZ = rdr["ckbz"].ToString().Trim();
                    if (rdr["spck"] != DBNull.Value) item.SPCK = rdr["spck"].ToString().Trim();
                }
            }
            return item;
        }

        public static List<DateTime> GetDates(SqlCommand cmd)
        {
            List<DateTime> list = new List<DateTime>();

            cmd.CommandText = "SELECT [RQ] FROM BCK GROUP BY [RQ] ORDER BY [RQ]";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    if (rdr["RQ"] != DBNull.Value) list.Add(Convert.ToDateTime(rdr["RQ"]));
                }
            }
            return list;
        }

        public static List<KYDataModelLayer.BCK> ReadAllByZDDM(SqlCommand cmd, DateTime rq, string zddm)
        {
            List<KYDataModelLayer.BCK> list = new List<KYDataModelLayer.BCK>();

            cmd.CommandText = "SELECT BCK.rq, BCK.cc, BCK.zdz,BCK.yxlb, BCK.fcsj, BCK.jpk, BCK.pjlb, BCK.zt, BCK.jydm, BCK.cph, BCK.dy, BCK.cx, BCK.scs, "
                + "BCK.ydxs, BCK.xllb, BCK.sfzdm, BCK.dzdm, BCK.xljy, BCK.lmdm, BCK.lcdm, BCK.zh, BCK.bdsj, BCK.wdsj, BCK.wdfk, BCK.wdbz, BCK.jcbz, "
                + "BCK.sfbz, BCK.qzlc, BCK.yxsj, BCK.server, BCK.dhbz, BCK.tpbz, BCK.zwfbz, BCK.spbz, BCK.ylbz, BCK.ylsl, BCK.cyxl, BCK.ckbz, BCK.spck "
                + "FROM BCK INNER JOIN JYB ON BCK.cc = JYB.cc AND BCK.rq = JYB.rq "
                + "WHERE BCK.rq = @rq AND JYB.zddm = @zddm AND JYB.zt = 'N' ORDER BY BCK.fcsj ASC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@rq", SqlDbType.DateTime).Value = rq;
            cmd.Parameters.Add("@zddm", SqlDbType.VarChar).Value = zddm;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    KYDataModelLayer.BCK bck = new KYDataModelLayer.BCK();

                    bck.RQ = Convert.ToDateTime(rdr["rq"]);
                    bck.CC = rdr["cc"].ToString().Trim();

                    if (rdr["zdz"] != DBNull.Value) bck.ZDZ = rdr["zdz"].ToString().Trim();
                    if (rdr["yxlb"] != DBNull.Value) bck.YXLB = rdr["yxlb"].ToString().Trim();
                    if (rdr["fcsj"] != DBNull.Value) bck.FCSJ = rdr["fcsj"].ToString().Trim();
                    if (rdr["jpk"] != DBNull.Value) bck.JPK = rdr["jpk"].ToString().Trim();
                    if (rdr["pjlb"] != DBNull.Value) bck.PJLB = rdr["pjlb"].ToString().Trim();
                    if (rdr["zt"] != DBNull.Value) bck.ZT = rdr["zt"].ToString().Trim();
                    if (rdr["jydm"] != DBNull.Value) bck.JYDM = rdr["jydm"].ToString().Trim();
                    if (rdr["cph"] != DBNull.Value) bck.CPH = rdr["cph"].ToString().Trim();
                    if (rdr["dy"] != DBNull.Value) bck.DY = Convert.ToInt32(rdr["dy"]);
                    if (rdr["cx"] != DBNull.Value) bck.CX = rdr["cx"].ToString().Trim();
                    if (rdr["scs"] != DBNull.Value) bck.SCS = Convert.ToInt32(rdr["scs"]);
                    if (rdr["ydxs"] != DBNull.Value) bck.YDXS = Convert.ToInt32(rdr["ydxs"]);
                    if (rdr["xllb"] != DBNull.Value) bck.XLLB = rdr["xllb"].ToString();
                    if (rdr["sfzdm"] != DBNull.Value) bck.SFZDM = rdr["sfzdm"].ToString().Trim();
                    if (rdr["dzdm"] != DBNull.Value) bck.DZDM = rdr["dzdm"].ToString().Trim();
                    if (rdr["xljy"] != DBNull.Value) bck.XLJY = rdr["xljy"].ToString().Trim();
                    if (rdr["lmdm"] != DBNull.Value) bck.LMDM = rdr["lmdm"].ToString();
                    if (rdr["lcdm"] != DBNull.Value) bck.LCDM = rdr["lcdm"].ToString();
                    if (rdr["zh"] != DBNull.Value) bck.ZH = rdr["zh"].ToString().Trim();
                    if (rdr["bdsj"] != DBNull.Value) bck.BDSJ = Convert.ToDateTime(rdr["bdsj"]);
                    if (rdr["wdsj"] != DBNull.Value) bck.WDSJ = Convert.ToInt32(rdr["wdsj"]);
                    if (rdr["wdfk"] != DBNull.Value) bck.WDFK = Convert.ToDecimal(rdr["wdfk"]);
                    if (rdr["wdbz"] != DBNull.Value) bck.WDBZ = rdr["wdbz"].ToString();
                    if (rdr["jcbz"] != DBNull.Value) bck.JCBZ = rdr["jcbz"].ToString();
                    if (rdr["sfbz"] != DBNull.Value) bck.SFBZ = rdr["sfbz"].ToString();
                    if (rdr["qzlc"] != DBNull.Value) bck.QZLC = Convert.ToInt32(rdr["qzlc"]);
                    if (rdr["yxsj"] != DBNull.Value) bck.YXSJ = rdr["yxsj"].ToString().Trim();
                    if (rdr["server"] != DBNull.Value) bck.Server = rdr["server"].ToString().Trim();
                    if (rdr["dhbz"] != DBNull.Value) bck.DHBZ = rdr["dhbz"].ToString();
                    if (rdr["tpbz"] != DBNull.Value) bck.TPBZ = rdr["tpbz"].ToString();
                    if (rdr["zwfbz"] != DBNull.Value) bck.ZWFBZ = rdr["zwfbz"].ToString();
                    if (rdr["spbz"] != DBNull.Value) bck.SPBZ = rdr["spbz"].ToString();
                    if (rdr["ylbz"] != DBNull.Value) bck.YLBZ = rdr["ylbz"].ToString();
                    if (rdr["ylsl"] != DBNull.Value) bck.YLSL = Convert.ToInt32(rdr["ylsl"]);
                    if (rdr["cyxl"] != DBNull.Value) bck.CYXL = Convert.ToInt32(rdr["cyxl"]);
                    if (rdr["ckbz"] != DBNull.Value) bck.CKBZ = rdr["ckbz"].ToString().Trim();
                    if (rdr["spck"] != DBNull.Value) bck.SPCK = rdr["spck"].ToString();

                    list.Add(bck);
                }
            }
            return list;
        }

        public static List<KYDataModelLayer.BCK> ReadByZDDM(SqlCommand cmd, DateTime rq, string zddm)
        {
            List<KYDataModelLayer.BCK> list = new List<KYDataModelLayer.BCK>();

            cmd.CommandText = "SELECT BCK.rq, BCK.cc, BCK.zdz,BCK.yxlb, BCK.fcsj, BCK.jpk, BCK.pjlb, BCK.zt, BCK.jydm, BCK.cph, BCK.dy, BCK.cx, BCK.scs, "
                + "BCK.ydxs, BCK.xllb, BCK.sfzdm, BCK.dzdm, BCK.xljy, BCK.lmdm, BCK.lcdm, BCK.zh, BCK.bdsj, BCK.wdsj, BCK.wdfk, BCK.wdbz, BCK.jcbz, "
                + "BCK.sfbz, BCK.qzlc, BCK.yxsj, BCK.server, BCK.dhbz, BCK.tpbz, BCK.zwfbz, BCK.spbz, BCK.ylbz, BCK.ylsl, BCK.cyxl, BCK.ckbz, BCK.spck "
                + "FROM BCK INNER JOIN JYB ON BCK.cc = JYB.cc AND BCK.rq = JYB.rq "
                + "WHERE BCK.rq = @rq  AND (BCK.zt LIKE '售%' OR BCK.zt LIKE '检%' OR BCK.zt LIKE '待%' OR BCK.zt LIKE '停%') AND JYB.zddm = @zddm AND JYB.zt = 'N' ORDER BY BCK.fcsj ASC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@rq", SqlDbType.DateTime).Value = rq;
            cmd.Parameters.Add("@zddm", SqlDbType.VarChar).Value = zddm;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    KYDataModelLayer.BCK bck = new KYDataModelLayer.BCK();

                    bck.RQ = Convert.ToDateTime(rdr["rq"]);
                    bck.CC = rdr["cc"].ToString().Trim();

                    if (rdr["zdz"] != DBNull.Value) bck.ZDZ = rdr["zdz"].ToString().Trim();
                    if (rdr["yxlb"] != DBNull.Value) bck.YXLB = rdr["yxlb"].ToString().Trim();
                    if (rdr["fcsj"] != DBNull.Value) bck.FCSJ = rdr["fcsj"].ToString().Trim();
                    if (rdr["jpk"] != DBNull.Value) bck.JPK = rdr["jpk"].ToString().Trim();
                    if (rdr["pjlb"] != DBNull.Value) bck.PJLB = rdr["pjlb"].ToString().Trim();
                    if (rdr["zt"] != DBNull.Value) bck.ZT = rdr["zt"].ToString().Trim();
                    if (rdr["jydm"] != DBNull.Value) bck.JYDM = rdr["jydm"].ToString().Trim();
                    if (rdr["cph"] != DBNull.Value) bck.CPH = rdr["cph"].ToString().Trim();
                    if (rdr["dy"] != DBNull.Value) bck.DY = Convert.ToInt32(rdr["dy"]);
                    if (rdr["cx"] != DBNull.Value) bck.CX = rdr["cx"].ToString().Trim();
                    if (rdr["scs"] != DBNull.Value) bck.SCS = Convert.ToInt32(rdr["scs"]);
                    if (rdr["ydxs"] != DBNull.Value) bck.YDXS = Convert.ToInt32(rdr["ydxs"]);
                    if (rdr["xllb"] != DBNull.Value) bck.XLLB = rdr["xllb"].ToString();
                    if (rdr["sfzdm"] != DBNull.Value) bck.SFZDM = rdr["sfzdm"].ToString().Trim();
                    if (rdr["dzdm"] != DBNull.Value) bck.DZDM = rdr["dzdm"].ToString().Trim();
                    if (rdr["xljy"] != DBNull.Value) bck.XLJY = rdr["xljy"].ToString().Trim();
                    if (rdr["lmdm"] != DBNull.Value) bck.LMDM = rdr["lmdm"].ToString();
                    if (rdr["lcdm"] != DBNull.Value) bck.LCDM = rdr["lcdm"].ToString();
                    if (rdr["zh"] != DBNull.Value) bck.ZH = rdr["zh"].ToString().Trim();
                    if (rdr["bdsj"] != DBNull.Value) bck.BDSJ = Convert.ToDateTime(rdr["bdsj"]);
                    if (rdr["wdsj"] != DBNull.Value) bck.WDSJ = Convert.ToInt32(rdr["wdsj"]);
                    if (rdr["wdfk"] != DBNull.Value) bck.WDFK = Convert.ToDecimal(rdr["wdfk"]);
                    if (rdr["wdbz"] != DBNull.Value) bck.WDBZ = rdr["wdbz"].ToString();
                    if (rdr["jcbz"] != DBNull.Value) bck.JCBZ = rdr["jcbz"].ToString();
                    if (rdr["sfbz"] != DBNull.Value) bck.SFBZ = rdr["sfbz"].ToString();
                    if (rdr["qzlc"] != DBNull.Value) bck.QZLC = Convert.ToInt32(rdr["qzlc"]);
                    if (rdr["yxsj"] != DBNull.Value) bck.YXSJ = rdr["yxsj"].ToString().Trim();
                    if (rdr["server"] != DBNull.Value) bck.Server = rdr["server"].ToString().Trim();
                    if (rdr["dhbz"] != DBNull.Value) bck.DHBZ = rdr["dhbz"].ToString();
                    if (rdr["tpbz"] != DBNull.Value) bck.TPBZ = rdr["tpbz"].ToString();
                    if (rdr["zwfbz"] != DBNull.Value) bck.ZWFBZ = rdr["zwfbz"].ToString();
                    if (rdr["spbz"] != DBNull.Value) bck.SPBZ = rdr["spbz"].ToString();
                    if (rdr["ylbz"] != DBNull.Value) bck.YLBZ = rdr["ylbz"].ToString();
                    if (rdr["ylsl"] != DBNull.Value) bck.YLSL = Convert.ToInt32(rdr["ylsl"]);
                    if (rdr["cyxl"] != DBNull.Value) bck.CYXL = Convert.ToInt32(rdr["cyxl"]);
                    if (rdr["ckbz"] != DBNull.Value) bck.CKBZ = rdr["ckbz"].ToString().Trim();
                    if (rdr["spck"] != DBNull.Value) bck.SPCK = rdr["spck"].ToString();

                    list.Add(bck);
                }
            }
            return list;
        }
    }
}
