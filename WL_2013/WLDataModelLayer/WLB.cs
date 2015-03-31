using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WLDataModelLayer
{
    public enum SKType { 现金 = 'X', 到付 = 'D', 记账 = 'A' }
    public enum YDType { 本地 = 'S', 中心 = 'R', 结账 = 'C' }
    public enum ZTType { 接货 = 'J', 装车 = 'Z', 卸车 = 'X', 取货 = 'S', 作废 = 'F' }

    [DataContract]
    [Serializable]
    public sealed class WLB
    {
        [DataMember]
        public string Node { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string SN { get; set; }
        [DataMember]
        public string UID { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public DateTime CDT { get; set; }

        [DataMember]
        public SKType SK_Type { get; set; }
        [DataMember]
        public YDType YD_Type { get; set; }
        [DataMember]
        public ZTType ZT_Type { get; set; }

        [DataMember]
        public string FH_Code { get; set; }
        [DataMember]
        public string FH_Name { get; set; }
        [DataMember]
        public string FH_CityName { get; set; }
        [DataMember]
        public string JH_Code { get; set; }
        [DataMember]
        public string JH_Name { get; set; }

        [DataMember]
        public DateTime CZ_RQ { get; set; }
        [DataMember]
        public string CZ_BC { get; set; }
        [DataMember]
        public string CZ_DZ { get; set; }
        [DataMember]
        public string CZ_SJ { get; set; }
        [DataMember]
        public string CZ_CPH { get; set; }
        [DataMember]
        public int CZ_LC { get; set; }
        [DataMember]
        public string CZ_YX { get; set; }

        [DataMember]
        public string HW_MC { get; set; }
        [DataMember]
        public string HW_LX { get; set; }
        [DataMember]
        public int HW_JS { get; set; }
        [DataMember]
        public decimal HW_BJ { get; set; }

        [DataMember]
        public string FHR_Name { get; set; }
        [DataMember]
        public string FHR_Mobile { get; set; }
        [DataMember]
        public string FHR_Remark { get; set; }
        [DataMember]
        public string JHR_Name { get; set; }
        [DataMember]
        public string JHR_Mobile { get; set; }

        [DataMember]
        public decimal JFZL { get; set; }
        [DataMember]
        public decimal JFTJ { get; set; }
        [DataMember]
        public decimal TYF { get; set; }
        [DataMember]
        public decimal BZF { get; set; }
        [DataMember]
        public decimal BXF { get; set; }
        [DataMember]
        public decimal Total { get; set; }
        [DataMember]
        public decimal Money { get; set; }

        [DataMember]
        public string BXD_SN { get; set; }

        [DataMember]
        public bool Freeze { get; set; }
        [DataMember]
        public bool Synced { get; set; }

        [DataMember]
        public string Sets { get; set; }

        public override string ToString()
        {
            return this.Node + ":" + this.Date.ToString("yyyy-MM-dd") + "-" + this.SN;
        }

        public WLB Clone()
        {
            WLB item = new WLB();

            item.Node = this.Node;
            item.Date = this.Date;
            item.SN = this.SN;
            item.UID = this.UID;
            item.Username = this.Username;
            item.CDT = this.CDT;

            item.SK_Type = this.SK_Type;
            item.YD_Type = this.YD_Type;
            item.ZT_Type = this.ZT_Type;

            item.FH_Code = this.FH_Code;
            item.FH_Name = this.FH_Name;
            item.FH_CityName = this.FH_CityName;
            item.JH_Code = this.JH_Code;
            item.JH_Name = this.JH_Name;

            item.CZ_RQ = this.CZ_RQ;
            item.CZ_BC = this.CZ_BC;
            item.CZ_DZ = this.CZ_DZ;
            item.CZ_SJ = this.CZ_SJ;
            item.CZ_CPH = this.CZ_CPH;
            item.CZ_LC = this.CZ_LC;
            item.CZ_YX = this.CZ_YX;

            item.HW_MC = this.HW_MC;
            item.HW_LX = this.HW_LX;
            item.HW_JS = this.HW_JS;
            item.HW_BJ = this.HW_BJ;

            item.FHR_Name = this.FHR_Name;
            item.FHR_Mobile = this.FHR_Mobile;
            item.FHR_Remark = this.FHR_Remark;
            item.JHR_Name = this.JHR_Name;
            item.JHR_Mobile = this.JHR_Mobile;

            item.JFZL = this.JFZL;
            item.JFTJ = this.JFTJ;
            item.TYF = this.TYF;
            item.BZF = this.BZF;
            item.BXF = this.BXF;
            item.Total = this.Total;
            item.Money = this.Money;

            item.BXD_SN = this.BXD_SN;

            item.Freeze = this.Freeze;
            item.Synced = this.Synced;

            item.Sets = this.Sets;

            return item;
        }

        //创建测试物流数据
        public static WLDataModelLayer.WLB CreateTestItem()
        {
            WLDataModelLayer.WLB item = new WLDataModelLayer.WLB();

            item.Node = "网点代码";
            item.Date = DateTime.Now.Date;
            item.SN = "1";
            item.UID = "用户编号";
            item.Username = "用户名称";
            item.CDT = DateTime.Now;

            item.SK_Type = SKType.现金;
            item.YD_Type = YDType.本地;
            item.ZT_Type = ZTType.接货;

            item.FH_Code = "发货网点代码";
            item.FH_Name = "发货网点名称";
            item.FH_CityName = "发货城市名称";
            item.JH_Code = "接货网点代码";
            item.JH_Name = "接货网点名称";

            item.CZ_RQ = DateTime.Now.Date;
            item.CZ_DZ = "到站";
            item.CZ_CPH = "车牌号";
            item.CZ_BC = "班次";
            item.CZ_SJ = "发车时间";
            item.CZ_LC = 0;
            item.CZ_YX = "运行时间";

            item.HW_MC = "货物名称";
            item.HW_LX = "货物类型";
            item.HW_JS = 1;
            item.HW_BJ = 1000.00m;

            item.FHR_Name = "发货人名称";
            item.FHR_Mobile = "发货人手机";
            item.FHR_Remark = "备注";
            item.JHR_Name = "接货人姓名";
            item.JHR_Mobile = "接货人手机";

            item.BXD_SN = "保险单编号";

            item.JFZL = 0m;
            item.JFTJ = 0m;
            item.TYF = 10.00m;
            item.BZF = 5.00m;
            item.BXF = 1.00m;
            item.Total = 21.00m;
            item.Money = 21.00m;

            return item;
        }

        public static WLB ToTarget(object o)
        {
            if (o == null) throw new ArgumentNullException("参数为空引用！");

            if (o is WLDataModelLayer.WLB)
                return (o as WLDataModelLayer.WLB);
            else
                throw new ArgumentException("参数非指定对象！");
        }

        public static void SKTypeList(ComboBox list, bool allowDF, bool allowJZ)
        {
            list.Items.Clear();
            list.Items.Add(WLDataModelLayer.SKType.现金);
            if (allowDF) list.Items.Add(WLDataModelLayer.SKType.到付);
            if (allowJZ) list.Items.Add(WLDataModelLayer.SKType.记账);
            list.SelectedIndex = 0;
        }

        public static void YDTypeList(ComboBox list)
        {
            list.Items.Clear();
            list.Items.Add(WLDataModelLayer.YDType.本地);
        }

        public static void ZTTypeList(ComboBox list)
        {
            list.Items.Clear();
            list.Items.Add(WLDataModelLayer.ZTType.接货);
            list.Items.Add(WLDataModelLayer.ZTType.装车);
            list.Items.Add(WLDataModelLayer.ZTType.卸车);
            list.Items.Add(WLDataModelLayer.ZTType.取货);
            list.Items.Add(WLDataModelLayer.ZTType.作废);
        }
    }
}
