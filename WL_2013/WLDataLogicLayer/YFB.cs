using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class YFB
    {
        public static WLDataModelLayer.YFB Check(string prefix, WLDataModelLayer.YFB item)
        {
            Common.Validate.ValidString(prefix, "运费名称", 32, item.Name);
            Common.Validate.ValidDecimal(prefix, "按文件收费", item.BF);
            Common.Validate.ValidDecimal(prefix, "按重量起价", item.BW);
            Common.Validate.ValidPositiveInt(prefix, "起始重量", item.Weight);
            Common.Validate.ValidDecimal(prefix, "续重单价", item.Excess);
            Common.Validate.ValidDecimal(prefix, "折算系数", item.Factor);
            Common.Validate.ValidPositiveInt(prefix, "起始里程", item.SM);
            Common.Validate.ValidPositiveInt(prefix, "截止里程", item.EM);
            return item;
        }

        public static void Refresh(ComboBox list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.YFB i in WLDataAccessLayer.YFB.Reads(Runtime.B_CreateCommand()))
            {
                list.Items.Add(i);
            }
        }

        public static void Refresh(ListView list)
        {
            ListViewItem item;
            foreach (WLDataModelLayer.YFB i in WLDataAccessLayer.YFB.Reads(Runtime.B_CreateCommand()))
            {
                item = new ListViewItem(i.Name);
                item.Tag = i;
                item.SubItems.Add(i.SM.ToString());
                item.SubItems.Add(i.EM.ToString());
                item.SubItems.Add(i.BF.ToString("N2"));
                item.SubItems.Add(i.BW.ToString("N2"));
                item.SubItems.Add(i.Weight.ToString());
                item.SubItems.Add(i.Excess.ToString("N2"));
                item.SubItems.Add(i.Factor.ToString("N2"));

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        //通过里程获取运费标准索引
        public static int FindYFFromCBO(ComboBox list, int mileage)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                WLDataModelLayer.YFB item = list.Items[i] as WLDataModelLayer.YFB;
                if (item != null && item.SM <= mileage && item.EM > mileage)
                    return i;
            }
            return 0;
        }

        public static bool Update(string old_name, WLDataModelLayer.YFB item)
        {
            return WLDataAccessLayer.YFB.Update(Runtime.B_CreateCommand(), old_name,
                Check("更新费标标准", item));
        }
    }
}
