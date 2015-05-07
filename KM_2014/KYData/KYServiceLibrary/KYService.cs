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

        /// <summary>
        /// 获取客运站名称列表
        /// </summary>
        /// <returns>返回客运站名称列表</returns>
        public List<string> GetKyzList()
        {
            return kyz_List.Keys.ToList<string>();
        }

        /// <summary>
        /// 连售张数查询(NEW)
        /// </summary>
        /// <param name="kyz_name">客运站名称</param>
        /// <param name="rq">查询日期</param>
        /// <param name="value">连售张数</param>
        /// <param name="isCurrent">是否在当前票表查询</param>
        /// <returns>返回符合指定连售张数记录列表</returns>
        public List<KM.KYData.Model.CPB_CT> GetWicketCTQuery(string kyz_name, DateTime rq, int value, bool isCurrent)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(this.GetConnectionString(kyz_name), null, pingEnabled, pingTimeout))
            {
                return KM.KYData.Entry.CPB.Query_CT(conn.CreateCommand(), rq, value, isCurrent);
            }
        }

        /// <summary>
        /// 班次售票查询(NEW)
        /// </summary>
        /// <param name="kyz_name"></param>
        /// <param name="rq"></param>
        /// <param name="bc"></param>
        /// <param name="isCurrent"></param>
        /// <returns></returns>
        public List<KM.KYData.Model.CPB_CT> GetWicketBCQuery(string kyz_name, DateTime rq, string bc, bool isCurrent)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(this.GetConnectionString(kyz_name), null, pingEnabled, pingTimeout))
            {
                return KM.KYData.Entry.CPB.Query_BC(conn.CreateCommand(), rq, bc, isCurrent);
            }
        }

        /// <summary>
        /// 获取检票统计记录列表
        /// </summary>
        /// <param name="kyz_name">客运站名称</param>
        /// <param name="fromDate">起始日期</param>
        /// <param name="toDate">截止日期</param>
        /// <param name="mode">排序模式默认降序</param>
        /// <returns>返回检票统计记录列表</returns>
        public List<WicketStatistics> GetWicketStatistics(string kyz_name, DateTime fromDate, DateTime toDate, SortOrder mode = SortOrder.Descending)
        {
            using (Common.BaseConnection conn = new Common.BaseConnection(this.GetConnectionString(kyz_name), null, pingEnabled, pingTimeout))
            {
                return WicketStatistics.GetWicketStatistics(conn.CreateCommand(), fromDate, toDate, mode);
            }            
        }
    }
}

