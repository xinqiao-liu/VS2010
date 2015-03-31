using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class CLK
    {
        public String CPH { get; set; }
        public String CX { get; set; }
        public Int32 ZWS { get; set; }
        public Int32 DY { get; set; }
        public String CSDW { get; set; }
        public String XM { get; set; }
        public String JSDM { get; set; }
        public String BZ1 { get; set; }
        public String BZ2 { get; set; }
        public String BZ3 { get; set; }
        public String BZ4 { get; set; }
        public String BZ5 { get; set; }
        public String BZ6 { get; set; }
        public decimal BZ7 { get; set; }
        public decimal BZ8 { get; set; }
        public String BTBZ { get; set; }
        public String YYZH { get; set; }
        public DateTime CCRQ { get; set; }
        public DateTime FZRQ { get; set; }
        public String YJBM { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        //获取车辆信息
        public static CLK Read(SqlConnection conn, String cph)
        {
            try
            {
                CLK item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CLK WHERE [CPH] = @CPH";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CPH", SqlDbType.Char).Value = cph;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new CLK();
                            item.CPH = cph;

                            if (rdr["cx"] != DBNull.Value) item.CX = rdr["cx"].ToString().Trim();
                            if (rdr["zws"] != DBNull.Value) item.ZWS = Convert.ToInt32(rdr["zws"]);
                            if (rdr["dy"] != DBNull.Value) item.DY = Convert.ToInt32(rdr["dy"]);
                            if (rdr["csdw"] != DBNull.Value) item.CSDW = rdr["csdw"].ToString().Trim();
                            if (rdr["xm"] != DBNull.Value) item.XM = rdr["xm"].ToString().Trim();
                            if (rdr["jsdm"] != DBNull.Value) item.JSDM = rdr["jsdm"].ToString().Trim();
                            if (rdr["bz1"] != DBNull.Value) item.BZ1 = rdr["bz1"].ToString().Trim();
                            if (rdr["bz2"] != DBNull.Value) item.BZ2 = rdr["bz2"].ToString().Trim();
                            if (rdr["bz3"] != DBNull.Value) item.BZ3 = rdr["bz3"].ToString().Trim();
                            if (rdr["bz4"] != DBNull.Value) item.BZ4 = rdr["bz4"].ToString().Trim();
                            if (rdr["bz5"] != DBNull.Value) item.BZ5 = rdr["bz5"].ToString().Trim();
                            if (rdr["bz6"] != DBNull.Value) item.BZ6 = rdr["bz6"].ToString().Trim();
                            if (rdr["bz7"] != DBNull.Value) item.BZ7 = Convert.ToDecimal(rdr["bz7"]);
                            if (rdr["bz8"] != DBNull.Value) item.BZ8 = Convert.ToDecimal(rdr["bz8"]);
                            if (rdr["btbz"] != DBNull.Value) item.BTBZ = rdr["btbz"].ToString().Trim();
                            if (rdr["yyzh"] != DBNull.Value) item.YYZH = rdr["yyzh"].ToString().Trim();
                            if (rdr["ccrq"] != DBNull.Value) item.CCRQ = Convert.ToDateTime(rdr["ccrq"]);
                            if (rdr["fzrq"] != DBNull.Value) item.FZRQ = Convert.ToDateTime(rdr["fzrq"]);
                            if (rdr["yjbm"] != DBNull.Value) item.YJBM = rdr["yjbm"].ToString().Trim();
                        }
                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取车辆信息异常：" + ex.Message);
            }
        }

        //获取车辆列表
        public static List<CLK> Reads(SqlConnection conn)
        {
            try
            {
                List<CLK> list = new List<CLK>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CLK ORDER BY [CPH]";
                    cmd.Parameters.Clear();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            CLK item = new CLK();

                            item.CPH = rdr["cph"].ToString().Trim();

                            if (rdr["cx"] != DBNull.Value) item.CX = rdr["cx"].ToString().Trim();
                            if (rdr["zws"] != DBNull.Value) item.ZWS = Convert.ToInt32(rdr["zws"]);
                            if (rdr["dy"] != DBNull.Value) item.DY = Convert.ToInt32(rdr["dy"]);
                            if (rdr["csdw"] != DBNull.Value) item.CSDW = rdr["csdw"].ToString().Trim();
                            if (rdr["xm"] != DBNull.Value) item.XM = rdr["xm"].ToString().Trim();
                            if (rdr["jsdm"] != DBNull.Value) item.JSDM = rdr["jsdm"].ToString().Trim();
                            if (rdr["bz1"] != DBNull.Value) item.BZ1 = rdr["bz1"].ToString().Trim();
                            if (rdr["bz2"] != DBNull.Value) item.BZ2 = rdr["bz2"].ToString().Trim();
                            if (rdr["bz3"] != DBNull.Value) item.BZ3 = rdr["bz3"].ToString().Trim();
                            if (rdr["bz4"] != DBNull.Value) item.BZ4 = rdr["bz4"].ToString().Trim();
                            if (rdr["bz5"] != DBNull.Value) item.BZ5 = rdr["bz5"].ToString().Trim();
                            if (rdr["bz6"] != DBNull.Value) item.BZ6 = rdr["bz6"].ToString().Trim();
                            if (rdr["bz7"] != DBNull.Value) item.BZ7 = Convert.ToDecimal(rdr["bz7"]);
                            if (rdr["bz8"] != DBNull.Value) item.BZ8 = Convert.ToDecimal(rdr["bz8"]);
                            if (rdr["btbz"] != DBNull.Value) item.BTBZ = rdr["btbz"].ToString().Trim();
                            if (rdr["yyzh"] != DBNull.Value) item.YYZH = rdr["yyzh"].ToString().Trim();
                            if (rdr["ccrq"] != DBNull.Value) item.CCRQ = Convert.ToDateTime(rdr["ccrq"]);
                            if (rdr["fzrq"] != DBNull.Value) item.FZRQ = Convert.ToDateTime(rdr["fzrq"]);
                            if (rdr["yjbm"] != DBNull.Value) item.YJBM = rdr["yjbm"].ToString().Trim();

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取车辆列表异常：" + ex.Message);
            }
        }
    }
}
