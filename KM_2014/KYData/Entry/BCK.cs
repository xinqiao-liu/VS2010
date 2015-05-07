using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class BCK
    {
        private static Model.BCK ToBCK(SqlDataReader rdr)
        {
            Model.BCK item = new Model.BCK();

            item.RQ = Convert.ToDateTime(rdr["rq"]);
            item.CC = rdr["cc"].ToString().Trim();
            if (rdr["zdz"] != DBNull.Value) item.ZDZ = rdr["zdz"].ToString();
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
            if (rdr["xjc"] != DBNull.Value) item.XJC = Convert.ToInt32(rdr["xjc"]);
            if (rdr["yz"] != DBNull.Value) item.YZ = rdr["yz"].ToString().Trim();

            return item;
        }

        //根据日期、车牌号获取班次信息
        public static Model.BCK Read(SqlCommand cmd, DateTime rq, String cph, String startTime)
        {
            cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [ZT] <> '结算' AND [ZT] <> '停发' AND [CPH] = @CPH AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
            cmd.Parameters.Add("@CPH", SqlDbType.Char).Value = cph;
            cmd.Parameters.Add("@TIME", SqlDbType.Char).Value = startTime;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) { return ToBCK(rdr); }
            }
            return null;
        }


        //根据日期、班次编号获取班次信息
        public static Model.BCK Read(SqlCommand cmd, DateTime rq, String cc)
        {
            cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = rq;
            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) { return ToBCK(rdr); }
            }
            return null;
        }

        //根据日期获取班次信息列表
        public static List<Model.BCK> Reads(SqlCommand cmd, DateTime date, String startTime)
        {
            List<Model.BCK> list = new List<Model.BCK>();

            cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [ZT] <> '结算' AND [ZT] <> '停发' AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@TIME", SqlDbType.Char).Value = startTime;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToBCK(rdr)); }
            }
            return list;
        }

        //获取班次列表
        public static List<Model.BCK> Reads(SqlCommand cmd, DateTime date, String cph, String zdz, String startTime)
        {
            List<Model.BCK> list = new List<Model.BCK>();

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
                while (rdr.Read()) { list.Add(ToBCK(rdr)); }
            }
            return list;
        }

        //通过检票口获取班次列表
        public static List<Model.BCK> Reads_JPK(SqlCommand cmd, DateTime date, String jpk, String startTime)
        {
            List<Model.BCK> list = new List<Model.BCK>();

            cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [JPK] = @JPK AND [ZT] <> '结算' AND [ZT] <> '停发' AND [FCSJ] >= @TIME ORDER BY [FCSJ] ASC, [CC]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@JPK", SqlDbType.Char).Value = jpk;
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@TIME", SqlDbType.Char).Value = startTime;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToBCK(rdr)); }
            }
            return list;
        }

        //通过状态获取班次信息
        public static List<Model.BCK> Reads_ZT(SqlCommand cmd, DateTime date, String zt)
        {
            List<Model.BCK> list = new List<Model.BCK>();

            cmd.CommandText = "SELECT * FROM BCK WHERE [RQ] = @RQ AND [ZT] = @ZT ORDER BY [FCSJ] ASC, [CC]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@ZT", SqlDbType.Char).Value = zt;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToBCK(rdr)); }
            }
            return list;
        }

        //获取终到站列表
        public static List<String> Reads_ZDZ(SqlCommand cmd)
        {
            List<String> list = new List<String>();

            cmd.CommandText = "SELECT [zdz] FROM BCK GROUP BY [zdz]";

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    if (rdr["zdz"] != DBNull.Value) list.Add(rdr["zdz"].ToString().Trim());
                }
            }
            return list;
        }

        public static List<DateTime> Reads_RQ(SqlCommand cmd, int day)
        {
            int i = 0;

            List<DateTime> list = new List<DateTime>();

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
            return list;
        }

        //检测班次
        public static Boolean Exist(SqlCommand cmd, DateTime date, String cc)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        //获取状态
        public static String GetState(SqlCommand cmd, DateTime date, String cc)
        {
            cmd.CommandText = "SELECT [ZT] FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

            return Convert.ToString(cmd.ExecuteScalar()).Trim();
        }

        //设置状态
        public static Boolean SetState(SqlCommand cmd, DateTime date, String cc, String state)
        {
            cmd.CommandText = "UPDATE BCK SET [ZT] = @ZT WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;
            cmd.Parameters.Add("@ZT", SqlDbType.Char).Value = state;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //获取定员
        public static Int32 GetFixedNumber(SqlCommand cmd, DateTime date, String cc)
        {
            cmd.CommandText = "SELECT [DY] FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //获取售出
        public static Int32 GetSaleNumber(SqlCommand cmd, DateTime date, String cc)
        {
            cmd.CommandText = "SELECT [SCS] FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //设置售出
        public static Boolean SetSaleNumber(SqlCommand cmd, DateTime date, String cc, Int32 number)
        {
            cmd.CommandText = "UPDATE BCK SET [SCS] = [SCS] + @SCS WHERE [RQ] = @RQ AND [CC] = @CC AND [SCS] + @SCS >= 0 AND [SCS] + @SCS <= [DY]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.VarChar).Value = cc;
            cmd.Parameters.Add("@SCS", SqlDbType.Int).Value = number;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        //检测热线班次
        public static Boolean IsHot(SqlCommand cmd, DateTime date, String cc)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM BCK WHERE [RQ] = @RQ AND [CC] = @CC AND [FCSJ] = '循环'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@RQ", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@CC", SqlDbType.Char).Value = cc;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        //设置座号状态
        public static Boolean SetZHState(SqlCommand cmd, DateTime date, String cc, Int32 zh, Char state)
        {
            if (state != '0' && state != '1') throw new ApplicationException("指定座号状态无效！");

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
    }
}
