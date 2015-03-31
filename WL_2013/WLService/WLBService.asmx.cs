using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WLService
{
    /// <summary>
    /// WLBService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WLBService : System.Web.Services.WebService
    {
        [WebMethod]
        public DateTime GetMinDate(string nodecode)
        {
            using (SqlConnection conn = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings[nodecode].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return WLDataAccessLayer.WLB.GetMinDate(cmd, nodecode);
                }
            }
        }

        [WebMethod]
        public DateTime GetMaxDate(string nodecode)
        {
            using (SqlConnection conn = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings[nodecode].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return WLDataAccessLayer.WLB.GetMaxDate(cmd, nodecode);
                }
            }
        }

        [WebMethod]
        public List<WLDataModelLayer.CollectByDateRange> GetCollectByDateRange(string nodecode, DateTime minDate, DateTime maxDate)
        {
            using (SqlConnection conn = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings[nodecode].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return WLDataAccessLayer.WLB.GetCollectByDateRange(cmd, nodecode, minDate, maxDate);
                }
            }
        }

        [WebMethod]
        public List<WLDataModelLayer.WLB> ReadByDate(string nodecode, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings[nodecode].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    return WLDataAccessLayer.WLB.ReadByDate(cmd, nodecode, date);
                }
            }
        }
    }
}