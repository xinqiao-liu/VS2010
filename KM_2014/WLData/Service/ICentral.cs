using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace WLCentralServiceLibrary
{
    [ServiceContract]
    public interface ICentral
    {
        //[OperationContract]
        //string GetServiceInfo();

        //[OperationContract]
        //bool WLB_Exist(WLDataModelLayer.WLB item);
        //[OperationContract]
        //bool WLB_Insert(WLDataModelLayer.WLB item);
        //[OperationContract]
        //bool WLB_Update(WLDataModelLayer.WLB item);
        //[OperationContract]
        //WLDataModelLayer.WLB WLB_Read(string node, string sn);
        //[OperationContract]
        //List<WLDataModelLayer.WLB> WLB_ReadByCZRQ(string node, DateTime date);
        //[OperationContract]
        //List<DateTime> WLB_GetAllCZRQ(string node, SortOrder mode);
        //[OperationContract]
        //bool WLB_SetZTType(string node, DateTime date, string sn, WLDataModelLayer.ZTType ztType);

        //[OperationContract]
        //bool WLB_ExistWaitingZC(string node, string sn);
        //[OperationContract]
        //List<WLDataModelLayer.WLB> WLB_ReadWaitingZCList(string node, DateTime date);
        //[OperationContract]
        //List<WLDataModelLayer.WLB> WLB_ReadAlreadyZCList(string node, DateTime date);
        //[OperationContract]
        //WLDataModelLayer.WLB WLB_ReadWaitingZCItem(string node, string sn);
        //[OperationContract]
        //List<DateTime> WLB_ReadWaitingZCDates(string node, SortOrder mode);

        //[OperationContract]
        //bool WLB_ExistWaitingXC(string node, string sn);
        //[OperationContract]
        //List<WLDataModelLayer.WLB> WLB_ReadWaitingXCList(string node, DateTime date);
        //[OperationContract]
        //List<WLDataModelLayer.WLB> WLB_ReadAlreadyXCList(string node, DateTime date);
        //[OperationContract]
        //WLDataModelLayer.WLB WLB_ReadWaitingXCItem(string node, string sn);
        //[OperationContract]
        //List<DateTime> WLB_ReadWaitingXCDates(string node, SortOrder mode);

        //[OperationContract]
        //bool WLB_ExistWaitingSH(string node, string sn);
        //[OperationContract]
        //List<WLDataModelLayer.WLB> WLB_ReadWaitingSHList(string node, DateTime date);
        //[OperationContract]
        //List<WLDataModelLayer.WLB> WLB_ReadAlreadySHList(string node, DateTime date);
        //[OperationContract]
        //WLDataModelLayer.WLB WLB_ReadWaitingSHItem(string node, string sn);
        //[OperationContract]
        //List<DateTime> WLB_ReadWaitingSHDates(string node, SortOrder mode);

        //[OperationContract]
        //bool WLT_Exist(string node, string sn);
        //[OperationContract]
        //bool WLT_Insert(WLDataModelLayer.WLT item);
        //[OperationContract]
        //List<WLDataModelLayer.WLT> WLT_Reads(string node, string sn);

        //[OperationContract]
        //void Execute(WLDataModelLayer.WLB item, string content);
    }
}
