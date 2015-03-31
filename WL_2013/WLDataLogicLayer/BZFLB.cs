using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class BZFLB
    {
        public static WLDataModelLayer.BZFLB Check(string prefix, WLDataModelLayer.BZFLB item)
        {
            Common.Validate.ValidString(prefix, "包装类型", 16, item.Name);
            Common.Validate.ValidDecimal(prefix, "包装费率", item.Value);
            return item;
        }

        public static void Refresh(ComboBox list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.BZFLB i in WLDataAccessLayer.BZFLB.Reads(Runtime.B_CreateCommand()))
            {
                list.Items.Add(i);
            }
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.BZFLB i in WLDataAccessLayer.BZFLB.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem item = new ListViewItem(i.Name);
                item.Tag = i;
                item.SubItems.Add(i.Value.ToString("N2"));

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static bool Update(WLDataModelLayer.BZFLB item)
        {
            return WLDataAccessLayer.BZFLB.Update(Runtime.B_CreateCommand(), Check("更新包装费率", item));
        }

        public static string GetName(decimal value)
        {
            return WLDataAccessLayer.BZFLB.GetName(Runtime.B_CreateCommand(), Common.Validate.ValidDecimal("获取包装类型", "包装费率", value));
        }
    }
}
