using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class Collect
    {
        public static Model.CollectByCP ToCPCollect(SqlDataReader rdr, int index)
        {
            Model.CollectByCP item = new Model.CollectByCP();

            item.SN = index;
            item.CPH = rdr["cph"].ToString();
            item.Name = (rdr["name"] == DBNull.Value) ? "" : rdr["name"].ToString();
            item.Counts = Convert.ToInt32(rdr["counts"]);
            item.Packages = Convert.ToInt32(rdr["packages"]);
            item.Total = Convert.ToDecimal(rdr["total"]);

            return item;
        }

        public static List<Model.CollectByCP> ReadCollectByCP(SqlCommand cmd, DateTime minDate, DateTime maxDate)
        {
            int index = 1;
            List<Model.CollectByCP> list = new List<Model.CollectByCP>();

            cmd.CommandText = "select WLB.cz_cph as cph, (SELECT CSXXB.name FROM CSXXB WHERE CSXXB.cph = WLB.cz_cph) as name, "
                + "COUNT(*) as counts, SUM(WLB.hw_js) as packages, SUM(WLB.total) as total "
                + "FROM WLB WHERE [date] >= @minDate AND [date] <= @maxDate AND [yd_type] = 'C' GROUP BY WLB.cz_cph ORDER BY total DESC";
            cmd.Parameters.Add("@maxDate", SqlDbType.DateTime).Value = maxDate;
            cmd.Parameters.Add("@minDate", SqlDbType.DateTime).Value = minDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToCPCollect(rdr, index++));
                }
            }

            return list;
        }

        public static Model.CollectByWD ToWDCollect(SqlDataReader rdr, int index)
        {
            Model.CollectByWD item = new Model.CollectByWD();

            item.SN = index;
            item.NodeCode = rdr["nodecode"].ToString();
            item.NodeName = rdr["nodename"].ToString();
            item.Counts = Convert.ToInt32(rdr["counts"]);
            item.Packages = Convert.ToInt32(rdr["packages"]);
            item.Total = Convert.ToDecimal(rdr["total"]);

            return item;
        }

        public static List<Model.CollectByWD> ReadCollectByWD(SqlCommand cmd, DateTime minDate, DateTime maxDate)
        {
            int index = 1;
            List<Model.CollectByWD> list = new List<Model.CollectByWD>();

            cmd.CommandText = "select WLB.jh_code as nodecode, (SELECT NODE.name FROM NODE WHERE NODE.code = WLB.jh_code) as nodename, "
                + "COUNT(*) as counts, SUM(WLB.hw_js) as packages, SUM(WLB.total) as total "
                + "FROM WLB WHERE [date] >= @minDate AND [date] <= @maxDate AND [yd_type] = 'C' GROUP BY WLB.jh_code ORDER BY total DESC";
            cmd.Parameters.Add("@maxDate", SqlDbType.DateTime).Value = maxDate;
            cmd.Parameters.Add("@minDate", SqlDbType.DateTime).Value = minDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToWDCollect(rdr, index++));
                }
            }

            return list;
        }

        public static Model.CollectByXL ToXLCollect(SqlDataReader rdr, int index)
        {
            Model.CollectByXL item = new Model.CollectByXL();

            item.SN = index;
            item.Name = rdr["name"].ToString();
            item.Counts = Convert.ToInt32(rdr["counts"]);
            item.Packages = Convert.ToInt32(rdr["packages"]);
            item.Total = Convert.ToDecimal(rdr["total"]);

            return item;
        }

        public static List<Model.CollectByXL> ReadCollectByXL(SqlCommand cmd, DateTime minDate, DateTime maxDate)
        {
            int index = 1;
            List<Model.CollectByXL> list = new List<Model.CollectByXL>();

            cmd.CommandText = "select WLB.cz_dz as name, COUNT(*) as counts, SUM(WLB.hw_js) as packages, SUM(WLB.total) as total "
                + "FROM WLB WHERE [date] >= @minDate AND [date] <= @maxDate AND [yd_type] = 'C' GROUP BY WLB.cz_dz ORDER BY total DESC";
            cmd.Parameters.Add("@maxDate", SqlDbType.DateTime).Value = maxDate;
            cmd.Parameters.Add("@minDate", SqlDbType.DateTime).Value = minDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToXLCollect(rdr, index++)); }
            }

            return list;
        }
    }
}
