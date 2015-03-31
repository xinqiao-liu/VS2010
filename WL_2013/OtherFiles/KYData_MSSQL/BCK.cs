using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{    
    public static class BCK
    {
        public static KYData.BCK Read(SqlConnection conn, DateTime date, String cph, String startTime)
        {
            try
            {
                KYData.BCK item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [ZT] <> '结算' AND [ZT] <> '停发' AND [CPH] = @CPH AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CPH", SqlDbType.Char).Value = cph;
                    cmd.Parameters.Add("@TIME", SqlDbType.Char).Value = startTime;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new KYData.BCK();

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
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("通过班次编号获取班次信息异常：" + ex.Message);
            }
        }


        //通过班次编号获取班次信息
        public static BCK Read(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                BCK item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new BCK();

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
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("通过班次编号获取班次信息异常：" + ex.Message);
            }
        }

        //通过车牌号获取班次信息
        public static List<BCK> Reads(SqlConnection conn, DateTime date, String startTime)
        {
            try
            {
                List<BCK> list = new List<BCK>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [ZT] <> '结算' AND [ZT] <> '停发' AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@TIME", SqlDbType.Char).Value = startTime;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            BCK item = new BCK();

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

                            list.Add(item);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取班次列表异常：" + ex.Message);
            }
        }

        //获取班次列表
        public static List<BCK> Reads(SqlConnection conn, DateTime date, String cph, String zdz, String startTime)
        {
            try
            {
                List<BCK> list = new List<BCK>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    if (cph == String.Empty && zdz == String.Empty)
                    {
                        cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [ZT] <> '结算' AND [ZT] <> '停发' AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
                    }

                    if (cph == String.Empty && zdz != String.Empty)
                    {
                        cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [ZDZ] = @ZDZ AND [ZT] <> '结算' AND [ZT] <> '停发' AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
                        cmd.Parameters.Add("@ZDZ", SqlDbType.Char).Value = zdz;
                    }

                    if (cph != String.Empty && zdz == String.Empty)
                    {
                        cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [CPH] = @CPH AND [ZT] <> '结算' AND [ZT] <> '停发' AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
                        cmd.Parameters.Add("@CPH", SqlDbType.Char).Value = cph;
                    }

                    if (cph != String.Empty && zdz != String.Empty) return list;

                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@TIME", SqlDbType.Char).Value = startTime;
                    
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            BCK item = new BCK();

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

                            list.Add(item);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取班次列表异常：" + ex.Message);
            }
        }



        //通过检票口获取班次列表
        public static List<BCK> Reads_JPK(SqlConnection conn, DateTime date, String jpk, String startTime)
        {
            try
            {
                List<BCK> list = new List<BCK>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [JPK] = @JPK AND [ZT] <> '结算' AND [ZT] <> '停发' AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
                    cmd.Parameters.Add("@JPK", SqlDbType.Char).Value = jpk;
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@TIME", SqlDbType.Char).Value = startTime;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            BCK item = new BCK();

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

                            list.Add(item);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取班次列表异常：" + ex.Message);
            }
        }

        //通过状态获取班次信息
        public static List<BCK> Reads_ZT(SqlConnection conn, DateTime date, String zt)
        {
            try
            {
                List<BCK> list = new List<BCK>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [ZT] = @ZT ORDER BY [FCSJ] ASC, [CC]";
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@ZT", SqlDbType.Char).Value = zt;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            BCK item = new BCK();

                            item.RQ = date;
                            item.ZT = zt;

                            if (rdr["cc"] != DBNull.Value) item.CC = rdr["cc"].ToString().Trim();
                            if (rdr["zdz"] != DBNull.Value) item.ZDZ = rdr["zdz"].ToString().Trim();
                            if (rdr["yxlb"] != DBNull.Value) item.YXLB = rdr["yxlb"].ToString().Trim();
                            if (rdr["fcsj"] != DBNull.Value) item.FCSJ = rdr["fcsj"].ToString().Trim();
                            if (rdr["jpk"] != DBNull.Value) item.JPK = rdr["jpk"].ToString().Trim();
                            if (rdr["pjlb"] != DBNull.Value) item.PJLB = rdr["pjlb"].ToString().Trim();
                            //if (rdr["zt"] != DBNull.Value) item.ZT = rdr["zt"].ToString().Trim();
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

                            list.Add(item);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取班次列表异常：" + ex.Message);
            }
        }

        public static List<String> Reads_ZDZ(SqlConnection conn)
        {
            try
            {
                List<String> list = new List<String>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [zdz] FROM BCK GROUP BY [zdz]";

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr["zdz"] != DBNull.Value) list.Add(rdr["zdz"].ToString().Trim());
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取终到站列表异常：" + ex.Message);
            }
        }

        public static List<DateTime> Reads_RQ(SqlConnection conn, int day)
        {
            try
            {
                int i = 0;

                List<DateTime> list = new List<DateTime>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [RQ] FROM BCK WHERE [RQ] >= @RQ GROUP BY [RQ] ORDER BY [RQ]";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = DateTime.Now.Date;
                    
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr["RQ"] != DBNull.Value)
                            {
                                list.Add(Convert.ToDateTime(rdr["RQ"]));
                            }

                            if (day != 0 && day == ++i) break;            
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取营运日期列表异常：" + ex.Message);
            }
        }

        public static List<DateTime> Reads_RQ(SqlConnection conn)
        {
            try
            {
                List<DateTime> list = new List<DateTime>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [RQ] FROM BCK GROUP BY [RQ] ORDER BY [RQ]";
                    cmd.Parameters.Clear();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr["RQ"] != DBNull.Value)
                            {
                                list.Add(Convert.ToDateTime(rdr["RQ"]));
                            }
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取营运日期列表异常：" + ex.Message);
            }
        }

        public static List<BCK> Reads_ZDDM(SqlConnection connection, DateTime rq, string zddm)
        {
            Common.Check.ConnectionException(connection);

            List<BCK> list = new List<BCK>();
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT BCK.rq, BCK.cc, BCK.zdz,BCK.yxlb, BCK.fcsj, BCK.jpk, BCK.pjlb, BCK.zt, BCK.jydm, BCK.cph, BCK.dy, BCK.cx, BCK.scs, "
                    + "BCK.ydxs, BCK.xllb, BCK.sfzdm, BCK.dzdm, BCK.xljy, BCK.lmdm, BCK.lcdm, BCK.zh, BCK.bdsj, BCK.wdsj, BCK.wdfk, BCK.wdbz, BCK.jcbz, "
                    + "BCK.sfbz, BCK.qzlc, BCK.yxsj, BCK.server, BCK.dhbz, BCK.tpbz, BCK.zwfbz, BCK.spbz, BCK.ylbz, BCK.ylsl, BCK.cyxl, BCK.ckbz, BCK.spck "
                    + "FROM BCK INNER JOIN JYB ON BCK.cc = JYB.cc AND BCK.rq = JYB.rq "
                    + "WHERE BCK.rq = @rq  AND (BCK.zt LIKE '售%' OR BCK.zt LIKE '检%' OR BCK.zt LIKE '待发') AND JYB.zddm = @zddm AND JYB.zt = 'N' ORDER BY BCK.fcsj ASC";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@rq", SqlDbType.DateTime).Value = rq;
                cmd.Parameters.Add("@zddm", SqlDbType.VarChar).Value = zddm;

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        BCK bck = new BCK();

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
            }
            return list;
        }

        //检测班次
        public static Boolean Exist(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测班次异常：" + ex.Message);
            }
        }

        //获取状态
        public static String GetState(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [ZT] FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

                    return Convert.ToString(cmd.ExecuteScalar()).Trim();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取状态异常：" + ex.Message);
            }
        }

        //设置状态
        public static Boolean SetState(SqlCommand cmd, DateTime date, String cc, String state)
        {
            try
            {
                cmd.CommandText = "UPDATE BCK SET [ZT] = @ZT WHERE [RQ] = @RQ AND [CC] = @CC";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;
                cmd.Parameters.Add("@ZT", SqlDbType.Char).Value = state;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("设置状态异常：" + ex.Message);
            }
        }

        public static Boolean SetState(SqlConnection conn, DateTime date, String cc, String state)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return SetState(cmd, date, cc, state);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        //获取定员
        public static Int32 GetFixedNumber(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [DY] FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取定员异常：" + ex.Message);
            }
        }

        //获取售出
        public static Int32 GetSaleNumber(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [SCS] FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取售出异常：" + ex.Message);
            }
        }

        //设置售出
        public static Boolean SetSaleNumber(SqlCommand cmd, DateTime date, String cc, Int32 number)
        {
            try
            {
                cmd.CommandText = "UPDATE BCK SET [SCS] = [SCS] + @SCS WHERE [RQ] = @RQ AND [CC] = @CC AND [SCS] + @SCS >= 0 AND [SCS] + @SCS <= [DY]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;
                cmd.Parameters.Add("@SCS", SqlDbType.Int).Value = number;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("设置售出异常：" + ex.Message);
            }

        }

        public static Boolean SetSaleNumber(SqlConnection conn, DateTime date, String cc, Int32 number)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return SetSaleNumber(cmd, date, cc, number);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        //检测热线班次
        public static Boolean IsHot(SqlConnection conn, DateTime date, String cc)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC AND [FCSJ] = '循环'";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                    cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测热线班次异常：" + ex.Message);
            }
        }

        //设置座号状态
        public static Boolean SetZHState(SqlCommand cmd, DateTime date, String cc, Int32 zh, Char state)
        {
            if (state != '0' && state != '1') throw new ApplicationException("指定座号状态无效！");

            try
            {
                switch (state)
                {
                    case '1':
                        cmd.CommandText = "UPDATE BCK SET [SCS] = [SCS] + 1, [ZH] = STUFF([ZH], @ZH, 1, '1') WHERE [RQ] = @RQ AND [CC] = @CC AND SUBSTRING([ZH], @ZH, 1) = '0' AND [SCS] + 1 <= [DY]";
                        break;
                    case '0':
                        cmd.CommandText = "UPDATE BCK SET [SCS] = [SCS] - 1, [ZH] = STUFF([ZH], @ZH, 1, '0') WHERE [RQ] = @RQ AND [CC] = @CC AND SUBSTRING([ZH], @ZH, 1) = '1' AND [SCS] - 1 >= 0 ";
                        break;
                }
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
                cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;
                cmd.Parameters.Add("@ZH", SqlDbType.Int).Value = zh;

                return ((cmd.ExecuteNonQuery() > 0) ? true : false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("设置座号状态异常：" + ex.Message);
            }
        }

        public static Boolean SetZHState(SqlConnection conn, DateTime date, String cc, Int32 zh, Char state)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return SetZHState(cmd, date, cc, zh, state);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
