using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataLogicLayer
{
    public static class Setting
    {
        private static List<WLDataModelLayer.Setting> m_Array= null;

        public static List<WLDataModelLayer.Setting> Array
        {
            get
            {
                if (Setting.m_Array == null)
                    throw new ApplicationException("运行配置数据未初始化！");
                else
                    return Setting.m_Array;
            }
            private set { Setting.m_Array = value; }
        }

        public static void Init()
        {
            Setting.Array = Setting.Reads();
        }

        #region 配置项只读常量
        
        private static readonly string NODECODE = "NodeCode";
        private static readonly string NODENAME = "NodeName";
        private static readonly string CITYCODE = "CityCode";
        private static readonly string CITYNAME = "CityName";

        //管理平台
        private static readonly string BILLBITS = "BillBits";
        private static readonly string BILLZEROIZE = "BillZeroize";
        private static readonly string SYNCCENTRAL = "SyncCentral";
        private static readonly string SECURITYCGECJ = "SecurityCheck";

        private static readonly string HWJSJOINCALC = "HWJSJoinCalc";
        private static readonly string MANUALMODIFY = "ManualModify";
        private static readonly string SAVECUSTOMER = "SaveCustomer";
        private static readonly string ONLYTODAY = "OnlyToday";
        private static readonly string CHARGEBZF = "ChargeBZF";
        private static readonly string ALLOWDF = "AllowDF";
        private static readonly string ALLOWJZ = "AllowJZ";
        private static readonly string AUTOSELECTYF = "AutoSelectYF";
        private static readonly string GDCHECKCPH = "GDCheckCPH";

        private static readonly string CHARGEBXF = "ChargeBXF";
        private static readonly string BXFAUTOCALC = "BXFAutoCalc";
        private static readonly string BXFROUND = "BXFRound";
        private static readonly string BXFMIN = "BXFMin";
        private static readonly string BXFMAX = "BXFMax";
        private static readonly string BXFRATIO = "BXFRatio";

        //结账平台
        private static readonly string JZDAY = "JZDay";
        private static readonly string JZDEFVALUE = "JZDefValue";
        private static readonly string CSDEFVALUE = "CSDefValue";

        #endregion

        #region 配置项访问属性

        public static string NodeCode
        {
            get
            {
                string nodecode = Setting.GetStringValue(Setting.Array, Setting.NODECODE);
                if (string.IsNullOrEmpty(nodecode))
                    throw new ApplicationException("运行配置中未指定当前网点代码！");
                else
                    return nodecode;
            }
            set { Setting.SetStringValue(Setting.Array, Setting.NODECODE, value); }
        }

        public static string NodeName
        {
            get
            {
                string nodename = Setting.GetStringValue(Setting.Array, Setting.NODENAME);
                if (string.IsNullOrEmpty(nodename))
                    throw new ApplicationException("运行配置中未指定当前网点名称！");
                else
                    return nodename;
            }
            set { Setting.SetStringValue(Setting.Array, Setting.NODENAME, value); }
        }

        public static string CityCode
        {
            get { return Setting.GetStringValue(Setting.Array, Setting.CITYCODE); }
            set { Setting.SetStringValue(Setting.Array, Setting.CITYCODE, value); }
        }

        public static string CityName
        {
            get { return Setting.GetStringValue(Setting.Array, Setting.CITYNAME); }
            set { Setting.SetStringValue(Setting.Array, Setting.CITYNAME, value); }
        }

        public static int BillBits
        {
            get { return Setting.GetIntValue(Setting.Array, Setting.BILLBITS); }
            set { Setting.SetStringValue(Setting.Array, Setting.BILLBITS, value.ToString()); }
        }

        public static bool BillZeroize
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.BILLZEROIZE); }
            set { Setting.SetStringValue(Setting.Array, Setting.BILLZEROIZE, value.ToString()); }
        }

        public static bool SyncCentral
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.SYNCCENTRAL); }
            set { Setting.SetStringValue(Setting.Array, Setting.SYNCCENTRAL, value.ToString()); }
        }

        public static bool SecurityCheck
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.SECURITYCGECJ); }
            set { Setting.SetStringValue(Setting.Array, Setting.SECURITYCGECJ, value.ToString()); }
        }

        public static bool HWJSJoinCalc
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.HWJSJOINCALC); }
            set { Setting.SetStringValue(Setting.Array, Setting.HWJSJOINCALC, value.ToString()); }
        }

        public static bool ManualModify
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.MANUALMODIFY); }
            set { Setting.SetStringValue(Setting.Array, Setting.MANUALMODIFY, value.ToString()); }
        }

        public static bool SaveCustomer
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.SAVECUSTOMER); }
            set { Setting.SetStringValue(Setting.Array, Setting.SAVECUSTOMER, value.ToString()); }
        }

        public static bool OnlyToday
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.ONLYTODAY); }
            set { Setting.SetStringValue(Setting.Array, Setting.ONLYTODAY, value.ToString()); }
        }

        public static bool ChargeBZF
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.CHARGEBZF); }
            set { Setting.SetStringValue(Setting.Array, Setting.CHARGEBZF, value.ToString()); }
        }

        public static bool AllowDF
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.ALLOWDF); }
            set { Setting.SetStringValue(Setting.Array, Setting.ALLOWDF, value.ToString()); }
        }

        public static bool AllowJZ
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.ALLOWJZ); }
            set { Setting.SetStringValue(Setting.Array, Setting.ALLOWJZ, value.ToString()); }
        }

        public static bool AutoSelectYF
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.AUTOSELECTYF); }
            set { Setting.SetStringValue(Setting.Array, Setting.AUTOSELECTYF, value.ToString()); }
        }

        public static bool GDCheckCPH
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.GDCHECKCPH); }
            set { Setting.SetStringValue(Setting.Array, Setting.GDCHECKCPH, value.ToString()); }
        }

        public static bool ChargeBXF
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.CHARGEBXF); }
            set { Setting.SetStringValue(Setting.Array, Setting.CHARGEBXF, value.ToString()); }
        }

        public static bool BXFAutoCalc
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.BXFAUTOCALC); }
            set { Setting.SetStringValue(Setting.Array, Setting.BXFAUTOCALC, value.ToString()); }
        }

        public static bool BXFRound
        {
            get { return Setting.GetBoolValue(Setting.Array, Setting.BXFROUND); }
            set { Setting.SetStringValue(Setting.Array, Setting.BXFROUND, value.ToString()); }
        }

        public static Decimal BXFMin
        {
            get { return Setting.GetDecimalValue(Setting.Array, Setting.BXFMIN); }
            set { Setting.SetStringValue(Setting.Array, Setting.BXFMIN, value.ToString()); }
        }

        public static Decimal BXFMax
        {
            get { return Setting.GetDecimalValue(Setting.Array, Setting.BXFMAX); }
            set { Setting.SetStringValue(Setting.Array, Setting.BXFMAX, value.ToString()); }
        }

        public static Decimal BXFRatio
        {
            get { return Setting.GetDecimalValue(Setting.Array, Setting.BXFRATIO); }
            set { Setting.SetStringValue(Setting.Array, Setting.BXFRATIO, value.ToString()); }
        }

        public static int JZDay
        {
            get { return Setting.GetIntValue(Setting.Array, Setting.JZDAY); }
            set { Setting.SetStringValue(Setting.Array, Setting.JZDAY, value.ToString()); }
        }

        public static Decimal JZDefValue
        {
            get { return Setting.GetDecimalValue(Setting.Array, Setting.JZDEFVALUE); }
            set { Setting.SetStringValue(Setting.Array, Setting.JZDEFVALUE, value.ToString()); }
        }

        public static Decimal CSDefValue
        {
            get { return Setting.GetDecimalValue(Setting.Array, Setting.CSDEFVALUE); }
            set { Setting.SetStringValue(Setting.Array, Setting.CSDEFVALUE, value.ToString()); }
        }

        #endregion

        #region 配置项访问方法

        private static string GetStringValue(List<WLDataModelLayer.Setting> items, string id)
        {
            if (items == null) throw new ArgumentNullException("items");
            foreach (WLDataModelLayer.Setting item in items)
            {
                if (item.Id == id) return item.Value;
            }
            throw new ArgumentOutOfRangeException(id);
        }

        private static bool GetBoolValue(List<WLDataModelLayer.Setting> items, string id)
        {
            if (items == null) throw new ArgumentNullException("items");
            foreach (WLDataModelLayer.Setting item in items)
            {
                if (item.Id == id) return Convert.ToBoolean(item.Value);
            }
            throw new ArgumentOutOfRangeException(id);
        }

        private static Int32 GetIntValue(List<WLDataModelLayer.Setting> items, string id)
        {
            if (items == null) throw new ArgumentNullException("items");
            foreach (WLDataModelLayer.Setting item in items)
            {
                if (item.Id == id) return Convert.ToInt32(item.Value);
            }
            throw new ArgumentOutOfRangeException(id);
        }

        private static Decimal GetDecimalValue(List<WLDataModelLayer.Setting> items, string id)
        {
            if (items == null) throw new ArgumentNullException("items");
            foreach (WLDataModelLayer.Setting item in items)
            {
                if (item.Id == id) return Convert.ToDecimal(item.Value);
            }
            throw new ArgumentOutOfRangeException(id);
        }

        private static void SetStringValue(List<WLDataModelLayer.Setting> items, string id, string value)
        {
            if (items == null) throw new ArgumentNullException("items");
            foreach (WLDataModelLayer.Setting item in items)
            {
                if (item.Id == id) { item.Value = value; return; }
            }
            throw new ArgumentOutOfRangeException(id);
        }

        #endregion

        #region 配置数据库操作

        public static void UpdateItems(List<WLDataModelLayer.Setting> items)
        {
            Common.Validate.NonOverflow("更新运行配置", "网点代码", 12, Setting.GetStringValue(items, Setting.NODECODE));
            Common.Validate.NonOverflow("更新运行配置", "网点名称", 32, Setting.GetStringValue(items, Setting.NODENAME));

            using (SqlTransaction tran = Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;

                    try
                    {
                        foreach (WLDataModelLayer.Setting item in items)
                        {
                            if (!WLDataAccessLayer.Setting.Update(cmd, item)) throw new DataException(String.Format("更新配置项{0} = {1} 失败！", item.Id, item.Value));
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }

        public static List<WLDataModelLayer.Setting> Reads()
        {
            return WLDataAccessLayer.Setting.Reads(Runtime.B_CreateCommand());
        }

        #endregion
    }
}
