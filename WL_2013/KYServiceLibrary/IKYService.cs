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
        List<WicketStatistics> GetWicketStatistics(string kyz_name, DateTime fromDate, DateTime toDate, SortOrder mode);
    }
}
