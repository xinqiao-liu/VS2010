﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.225
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WLDataLogicLayer.WLCentralServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WLCentralServiceReference.ICentral")]
    public interface ICentral {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/GetServiceInfo", ReplyAction="http://tempuri.org/ICentral/GetServiceInfoResponse")]
        string GetServiceInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_Exist", ReplyAction="http://tempuri.org/ICentral/WLB_ExistResponse")]
        bool WLB_Exist(WLDataModelLayer.WLB item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_Insert", ReplyAction="http://tempuri.org/ICentral/WLB_InsertResponse")]
        bool WLB_Insert(WLDataModelLayer.WLB item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_Update", ReplyAction="http://tempuri.org/ICentral/WLB_UpdateResponse")]
        bool WLB_Update(WLDataModelLayer.WLB item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_Read", ReplyAction="http://tempuri.org/ICentral/WLB_ReadResponse")]
        WLDataModelLayer.WLB WLB_Read(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadByCZRQ", ReplyAction="http://tempuri.org/ICentral/WLB_ReadByCZRQResponse")]
        WLDataModelLayer.WLB[] WLB_ReadByCZRQ(string node, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_GetAllCZRQ", ReplyAction="http://tempuri.org/ICentral/WLB_GetAllCZRQResponse")]
        System.DateTime[] WLB_GetAllCZRQ(string node, System.Data.SqlClient.SortOrder mode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_SetZTType", ReplyAction="http://tempuri.org/ICentral/WLB_SetZTTypeResponse")]
        bool WLB_SetZTType(string node, System.DateTime date, string sn, WLDataModelLayer.ZTType ztType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ExistWaitingZC", ReplyAction="http://tempuri.org/ICentral/WLB_ExistWaitingZCResponse")]
        bool WLB_ExistWaitingZC(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingZCList", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingZCListResponse")]
        WLDataModelLayer.WLB[] WLB_ReadWaitingZCList(string node, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadAlreadyZCList", ReplyAction="http://tempuri.org/ICentral/WLB_ReadAlreadyZCListResponse")]
        WLDataModelLayer.WLB[] WLB_ReadAlreadyZCList(string node, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingZCItem", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingZCItemResponse")]
        WLDataModelLayer.WLB WLB_ReadWaitingZCItem(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingZCDates", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingZCDatesResponse")]
        System.DateTime[] WLB_ReadWaitingZCDates(string node, System.Data.SqlClient.SortOrder mode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ExistWaitingXC", ReplyAction="http://tempuri.org/ICentral/WLB_ExistWaitingXCResponse")]
        bool WLB_ExistWaitingXC(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingXCList", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingXCListResponse")]
        WLDataModelLayer.WLB[] WLB_ReadWaitingXCList(string node, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadAlreadyXCList", ReplyAction="http://tempuri.org/ICentral/WLB_ReadAlreadyXCListResponse")]
        WLDataModelLayer.WLB[] WLB_ReadAlreadyXCList(string node, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingXCItem", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingXCItemResponse")]
        WLDataModelLayer.WLB WLB_ReadWaitingXCItem(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingXCDates", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingXCDatesResponse")]
        System.DateTime[] WLB_ReadWaitingXCDates(string node, System.Data.SqlClient.SortOrder mode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ExistWaitingSH", ReplyAction="http://tempuri.org/ICentral/WLB_ExistWaitingSHResponse")]
        bool WLB_ExistWaitingSH(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingSHList", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingSHListResponse")]
        WLDataModelLayer.WLB[] WLB_ReadWaitingSHList(string node, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadAlreadySHList", ReplyAction="http://tempuri.org/ICentral/WLB_ReadAlreadySHListResponse")]
        WLDataModelLayer.WLB[] WLB_ReadAlreadySHList(string node, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingSHItem", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingSHItemResponse")]
        WLDataModelLayer.WLB WLB_ReadWaitingSHItem(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingSHDates", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingSHDatesResponse")]
        System.DateTime[] WLB_ReadWaitingSHDates(string node, System.Data.SqlClient.SortOrder mode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ExistWaitingEH", ReplyAction="http://tempuri.org/ICentral/WLB_ExistWaitingEHResponse")]
        bool WLB_ExistWaitingEH(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingEHList", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingEHListResponse")]
        WLDataModelLayer.WLB[] WLB_ReadWaitingEHList(string node, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLB_ReadWaitingEHItem", ReplyAction="http://tempuri.org/ICentral/WLB_ReadWaitingEHItemResponse")]
        WLDataModelLayer.WLB WLB_ReadWaitingEHItem(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLT_Exist", ReplyAction="http://tempuri.org/ICentral/WLT_ExistResponse")]
        bool WLT_Exist(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLT_Insert", ReplyAction="http://tempuri.org/ICentral/WLT_InsertResponse")]
        bool WLT_Insert(WLDataModelLayer.WLT item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/WLT_Reads", ReplyAction="http://tempuri.org/ICentral/WLT_ReadsResponse")]
        WLDataModelLayer.WLT[] WLT_Reads(string node, string sn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICentral/Execute", ReplyAction="http://tempuri.org/ICentral/ExecuteResponse")]
        void Execute(WLDataModelLayer.WLB item, string content);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICentralChannel : WLDataLogicLayer.WLCentralServiceReference.ICentral, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CentralClient : System.ServiceModel.ClientBase<WLDataLogicLayer.WLCentralServiceReference.ICentral>, WLDataLogicLayer.WLCentralServiceReference.ICentral {
        
        public CentralClient() {
        }
        
        public CentralClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CentralClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CentralClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CentralClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetServiceInfo() {
            return base.Channel.GetServiceInfo();
        }
        
        public bool WLB_Exist(WLDataModelLayer.WLB item) {
            return base.Channel.WLB_Exist(item);
        }
        
        public bool WLB_Insert(WLDataModelLayer.WLB item) {
            return base.Channel.WLB_Insert(item);
        }
        
        public bool WLB_Update(WLDataModelLayer.WLB item) {
            return base.Channel.WLB_Update(item);
        }
        
        public WLDataModelLayer.WLB WLB_Read(string node, string sn) {
            return base.Channel.WLB_Read(node, sn);
        }
        
        public WLDataModelLayer.WLB[] WLB_ReadByCZRQ(string node, System.DateTime date) {
            return base.Channel.WLB_ReadByCZRQ(node, date);
        }
        
        public System.DateTime[] WLB_GetAllCZRQ(string node, System.Data.SqlClient.SortOrder mode) {
            return base.Channel.WLB_GetAllCZRQ(node, mode);
        }
        
        public bool WLB_SetZTType(string node, System.DateTime date, string sn, WLDataModelLayer.ZTType ztType) {
            return base.Channel.WLB_SetZTType(node, date, sn, ztType);
        }
        
        public bool WLB_ExistWaitingZC(string node, string sn) {
            return base.Channel.WLB_ExistWaitingZC(node, sn);
        }
        
        public WLDataModelLayer.WLB[] WLB_ReadWaitingZCList(string node, System.DateTime date) {
            return base.Channel.WLB_ReadWaitingZCList(node, date);
        }
        
        public WLDataModelLayer.WLB[] WLB_ReadAlreadyZCList(string node, System.DateTime date) {
            return base.Channel.WLB_ReadAlreadyZCList(node, date);
        }
        
        public WLDataModelLayer.WLB WLB_ReadWaitingZCItem(string node, string sn) {
            return base.Channel.WLB_ReadWaitingZCItem(node, sn);
        }
        
        public System.DateTime[] WLB_ReadWaitingZCDates(string node, System.Data.SqlClient.SortOrder mode) {
            return base.Channel.WLB_ReadWaitingZCDates(node, mode);
        }
        
        public bool WLB_ExistWaitingXC(string node, string sn) {
            return base.Channel.WLB_ExistWaitingXC(node, sn);
        }
        
        public WLDataModelLayer.WLB[] WLB_ReadWaitingXCList(string node, System.DateTime date) {
            return base.Channel.WLB_ReadWaitingXCList(node, date);
        }
        
        public WLDataModelLayer.WLB[] WLB_ReadAlreadyXCList(string node, System.DateTime date) {
            return base.Channel.WLB_ReadAlreadyXCList(node, date);
        }
        
        public WLDataModelLayer.WLB WLB_ReadWaitingXCItem(string node, string sn) {
            return base.Channel.WLB_ReadWaitingXCItem(node, sn);
        }
        
        public System.DateTime[] WLB_ReadWaitingXCDates(string node, System.Data.SqlClient.SortOrder mode) {
            return base.Channel.WLB_ReadWaitingXCDates(node, mode);
        }
        
        public bool WLB_ExistWaitingSH(string node, string sn) {
            return base.Channel.WLB_ExistWaitingSH(node, sn);
        }
        
        public WLDataModelLayer.WLB[] WLB_ReadWaitingSHList(string node, System.DateTime date) {
            return base.Channel.WLB_ReadWaitingSHList(node, date);
        }
        
        public WLDataModelLayer.WLB[] WLB_ReadAlreadySHList(string node, System.DateTime date) {
            return base.Channel.WLB_ReadAlreadySHList(node, date);
        }
        
        public WLDataModelLayer.WLB WLB_ReadWaitingSHItem(string node, string sn) {
            return base.Channel.WLB_ReadWaitingSHItem(node, sn);
        }
        
        public System.DateTime[] WLB_ReadWaitingSHDates(string node, System.Data.SqlClient.SortOrder mode) {
            return base.Channel.WLB_ReadWaitingSHDates(node, mode);
        }
        
        public bool WLB_ExistWaitingEH(string node, string sn) {
            return base.Channel.WLB_ExistWaitingEH(node, sn);
        }
        
        public WLDataModelLayer.WLB[] WLB_ReadWaitingEHList(string node, System.DateTime date) {
            return base.Channel.WLB_ReadWaitingEHList(node, date);
        }
        
        public WLDataModelLayer.WLB WLB_ReadWaitingEHItem(string node, string sn) {
            return base.Channel.WLB_ReadWaitingEHItem(node, sn);
        }
        
        public bool WLT_Exist(string node, string sn) {
            return base.Channel.WLT_Exist(node, sn);
        }
        
        public bool WLT_Insert(WLDataModelLayer.WLT item) {
            return base.Channel.WLT_Insert(item);
        }
        
        public WLDataModelLayer.WLT[] WLT_Reads(string node, string sn) {
            return base.Channel.WLT_Reads(node, sn);
        }
        
        public void Execute(WLDataModelLayer.WLB item, string content) {
            base.Channel.Execute(item, content);
        }
    }
}
