using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace KYServiceLibrary
{
    public class KYService : IKYService
    {
        private Dictionary<string, string> kyz_List;
        private bool pingEnabled;
        private int pingTimeout;
        private SqlConnectionStringBuilder csb;

        private string GetConnectionString(string kyz_name)
        {
            this.csb.DataSource = this.kyz_List[kyz_name];
            return this.csb.ConnectionString;    
        }

        public KYService()
        {
            kyz_List = new Dictionary<string, string>();
            kyz_List.Add("凯旋客运站", "172.26.9.240");
            kyz_List.Add("中心客运站", "172.26.5.240");
            kyz_List.Add("高速客运站", "172.26.3.240");

            csb = new SqlConnectionStringBuilder("Data Source=localhost;Initial Catalog=kyz_bs;Persist Security Info=True;User ID=net;Password=net2008");
            pingEnabled = true;
            pingTimeout = 2000;
        }

        public List<string> GetKyzList()
        {
            return kyz_List.Keys.ToList<string>();
        }

        public List<WicketStatistics> GetWicketStatistics(string kyz_name, DateTime fromDate, DateTime toDate, SortOrder mode = SortOrder.Descending)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(this.GetConnectionString(kyz_name), null, pingEnabled, pingTimeout))
            {
                return WicketStatistics.GetWicketStatistics(conn.CreateCommand(), fromDate, toDate, mode);
            }            
        }
    }
}
