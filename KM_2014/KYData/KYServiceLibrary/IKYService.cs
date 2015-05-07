using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYServiceLibrary
{
    [ServiceContract]
    public interface IKYService
    {
        [OperationContract]
        List<string> GetKyzList();

        [OperationContract]
        List<KM.KYData.Model.CPB_CT> GetWicketCTQuery(string kyz_name, DateTime rq, int value, bool isCurrent);

        [OperationContract]
        List<KM.KYData.Model.CPB_CT> GetWicketBCQuery(string kyz_name, DateTime rq, string bc, bool isCurrent);

        [OperationContract]
        List<WicketStatistics> GetWicketStatistics(string kyz_name, DateTime fromDate, DateTime toDate, SortOrder mode);
    }
}
