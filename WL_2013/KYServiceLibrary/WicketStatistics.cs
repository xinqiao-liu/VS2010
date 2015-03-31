using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;

namespace KYServiceLibrary
{
    [DataContract]
    public class WicketStatistics
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public int JSS { get; set; }
        [DataMember]
        public int JPS { get; set; }

        public static List<WicketStatistics> GetWicketStatistics(SqlCommand cmd, DateTime fromDate, DateTime toDate, SortOrder mode)
        {
            List<WicketStatistics> list = new List<WicketStatistics>();

            switch(mode)
            {
                case SortOrder.Descending:
                    cmd.CommandText = "SELECT jscz, COUNT(*) AS jss, SUM(jszs) as jps FROM JSD WHERE rq >= @fromDate AND rq <= @toDate GROUP BY [jscz] ORDER BY [jps] DESC";
                    break;
                case SortOrder.Ascending:
                default:
                    cmd.CommandText = "SELECT jscz, COUNT(*) AS jss, SUM(jszs) as jps FROM JSD WHERE rq >= @fromDate AND rq <= @toDate GROUP BY [jscz] ORDER BY [jps] ASC";             
                    break;
            }
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate;
            cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    WicketStatistics item = new WicketStatistics();
                    item.Username = rdr["jscz"].ToString();
                    item.JSS = Convert.ToInt32(rdr["jss"]);
                    item.JPS = Convert.ToInt32(rdr["jps"]);
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
