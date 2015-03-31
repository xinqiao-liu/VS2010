using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class Collect
    {
        public static WLDataModelLayer.CollectByCP ToCollectByCP(SqlDataReader rdr, int index)
        {
            WLDataModelLayer.CollectByCP item = new WLDataModelLayer.CollectByCP();

            item.SN = index;
            item.CPH = rdr["cph"].ToString();
            item.Name = (rdr["name"] == DBNull.Value) ? "" : rdr["name"].ToString();
            item.Counts = Convert.ToInt32(rdr["counts"]);
            item.Packages = Convert.ToInt32(rdr["packages"]);
            item.Total = Convert.ToDecimal(rdr["total"]);

            return item;
        }

        public static List<WLDataModelLayer.CollectByCP> ReadCollectByCP(SqlCommand cmd, DateTime minDate, DateTime maxDate)
        {
            int index = 1;
            List<WLDataModelLayer.CollectByCP> list = new List<WLDataModelLayer.CollectByCP>();

            cmd.CommandText = "select WLB.cz_cph as cph, (SELECT CSXXB.name FROM CSXXB WHERE CSXXB.cph = WLB.cz_cph) as name, "
                + "COUNT(*) as counts, SUM(WLB.hw_js) as packages, SUM(WLB.total) as total "
                + "FROM WLB WHERE [date] >= @minDate AND [date] <= @maxDate  GROUP BY WLB.cz_cph ORDER BY total DESC";
            cmd.Parameters.Add("@maxDate", SqlDbType.DateTime).Value = maxDate;
            cmd.Parameters.Add("@minDate", SqlDbType.DateTime).Value = minDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToCollectByCP(rdr, index++));
                }
            }

            return list;
        }

        public static WLDataModelLayer.CollectByWD ToCollectByWD(SqlDataReader rdr, int index)
        {
            WLDataModelLayer.CollectByWD item = new WLDataModelLayer.CollectByWD();

            item.SN = index;
            item.NodeCode = rdr["nodecode"].ToString();
            item.NodeName = rdr["nodename"].ToString();
            item.Counts = Convert.ToInt32(rdr["counts"]);
            item.Packages = Convert.ToInt32(rdr["packages"]);
            item.Total = Convert.ToDecimal(rdr["total"]);

            return item;
        }

        public static List<WLDataModelLayer.CollectByWD> ReadCollectByWD(SqlCommand cmd, DateTime minDate, DateTime maxDate)
        {
            int index = 1;
            List<WLDataModelLayer.CollectByWD> list = new List<WLDataModelLayer.CollectByWD>();

            cmd.CommandText = "select WLB.jh_code as nodecode, (SELECT NODE.name FROM NODE WHERE NODE.code = WLB.jh_code) as nodename, "
                + "COUNT(*) as counts, SUM(WLB.hw_js) as packages, SUM(WLB.total) as total "
                + "FROM WLB WHERE [date] >= @minDate AND [date] <= @maxDate GROUP BY WLB.jh_code ORDER BY total DESC";
            cmd.Parameters.Add("@maxDate", SqlDbType.DateTime).Value = maxDate;
            cmd.Parameters.Add("@minDate", SqlDbType.DateTime).Value = minDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToCollectByWD(rdr, index++));
                }
            }

            return list;
        }

        public static WLDataModelLayer.CollectByXL ToCollectByXL(SqlDataReader rdr, int index)
        {
            WLDataModelLayer.CollectByXL item = new WLDataModelLayer.CollectByXL();

            item.SN = index;
            item.Name = rdr["name"].ToString();
            item.Counts = Convert.ToInt32(rdr["counts"]);
            item.Packages = Convert.ToInt32(rdr["packages"]);
            item.Total = Convert.ToDecimal(rdr["total"]);

            return item;
        }

        public static List<WLDataModelLayer.CollectByXL> ReadCollectByXL(SqlCommand cmd, DateTime minDate, DateTime maxDate)
        {
            int index = 1;
            List<WLDataModelLayer.CollectByXL> list = new List<WLDataModelLayer.CollectByXL>();

            cmd.CommandText = "select WLB.cz_dz as name, COUNT(*) as counts, SUM(WLB.hw_js) as packages, SUM(WLB.total) as total "
                + "FROM WLB WHERE [date] >= @minDate AND [date] <= @maxDate GROUP BY WLB.cz_dz ORDER BY total DESC";
            cmd.Parameters.Add("@maxDate", SqlDbType.DateTime).Value = maxDate;
            cmd.Parameters.Add("@minDate", SqlDbType.DateTime).Value = minDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToCollectByXL(rdr, index++)); }
            }

            return list;
        }

        public static WLDataModelLayer.CollectByCustomer ToCollectByCustomer(SqlDataReader rdr, int index)
        {
            WLDataModelLayer.CollectByCustomer item = new WLDataModelLayer.CollectByCustomer();

            item.SN = index;
            item.FHR_Name = rdr["fhr_name"].ToString();
            item.FHR_Tel = rdr["fhr_mobile"].ToString();
            item.Counts = Convert.ToInt32(rdr["count"]);
            item.Packages = Convert.ToInt32(rdr["packages"]);
            item.Total = Convert.ToDecimal(rdr["total"]);

            return item;
        }

        public static List<WLDataModelLayer.CollectByCustomer> ReadCollectByCustomer(SqlCommand cmd, DateTime minDate, DateTime maxDate, WLDataModelLayer.CollectByCustomerSortMode sortMode)
        {
            int index = 1;
            List<WLDataModelLayer.CollectByCustomer> list = new List<WLDataModelLayer.CollectByCustomer>();

            if (sortMode == WLDataModelLayer.CollectByCustomerSortMode.Count)
                cmd.CommandText = "select fhr_name, fhr_mobile, COUNT(*) as count, SUM(WLB.hw_js) as packages, SUM(WLB.total) as total "
                    + "FROM WLB WHERE [date] >= @minDate AND [date] <= @maxDate GROUP BY WLB.fhr_name, WLB.fhr_mobile ORDER BY count DESC";
            else
                cmd.CommandText = "select fhr_name, fhr_mobile, COUNT(*) as count, SUM(WLB.hw_js) as packages, SUM(WLB.total) as total "
                    + "FROM WLB WHERE [date] >= @minDate AND [date] <= @maxDate GROUP BY WLB.fhr_name, WLB.fhr_mobile ORDER BY total DESC";

            cmd.Parameters.Add("@maxDate", SqlDbType.DateTime).Value = maxDate;
            cmd.Parameters.Add("@minDate", SqlDbType.DateTime).Value = minDate;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read()) { list.Add(ToCollectByCustomer(rdr, index++)); }
            }

            return list;
        }
    }
}
