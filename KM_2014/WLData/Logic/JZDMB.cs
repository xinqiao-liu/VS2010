using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class JZDMB
    {
        public static WLDataModelLayer.JZDMB Check(string prefix, WLDataModelLayer.JZDMB item)
        {
            Common.Validate.ValidString(prefix, "结账代码", 8, item.Code);
            Common.Validate.ValidString(prefix, "代码名称", 32, item.Name);
            Common.Validate.ValidPercent(prefix, "结账比率", item.Value);
            Common.Validate.NonOverflow(prefix, "地址", 64, item.Address);
            Common.Validate.NonOverflow(prefix, "电话", 32, item.Tel);
            return item;
        }

        public static void Refresh(ComboBox list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.JZDMB i in JZDMB.Reads())
            {
                list.Items.Add(i.Code);
            }
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.JZDMB i in JZDMB.Reads())                
            {
                ListViewItem item = new ListViewItem(i.Code);
                item.Tag = i;
                item.SubItems.Add(i.Name);
                item.SubItems.Add(i.Value.ToString("N2"));
                item.SubItems.Add(i.Mode.ToString());
                item.SubItems.Add(i.Tel);
                item.SubItems.Add(i.Address);
                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static bool Exists(string code)
        {
            return WLDataAccessLayer.JZDMB.Exists(Runtime.B_CreateCommand(), code);
        }

        public static bool Insert(WLDataModelLayer.JZDMB item)
        {
            return WLDataAccessLayer.JZDMB.Insert(Runtime.B_CreateCommand(), Check("插入结账代码", item));
        }

        public static bool Delete(string code)
        {
            if (code == null)
                return WLDataAccessLayer.JZDMB.Delete(Runtime.B_CreateCommand());
            else
                return WLDataAccessLayer.JZDMB.Delete(Runtime.B_CreateCommand(), code);
        }

        public static bool Update(string old_code, WLDataModelLayer.JZDMB item)
        {
            return WLDataAccessLayer.JZDMB.Update(Runtime.B_CreateCommand(), old_code, Check("更新结账代码", item));
        }

        public static WLDataModelLayer.JZDMB Read(string code)
        {
            return WLDataAccessLayer.JZDMB.Read(Runtime.B_CreateCommand(), code);
        }

        public static List<WLDataModelLayer.JZDMB> Reads()
        {
            return WLDataAccessLayer.JZDMB.Reads(Runtime.B_CreateCommand());
        }

        public static List<WLDataModelLayer.JZCPH> Read_JZCPH()
        {
            return WLDataAccessLayer.JZDMB.Read_JZCPH(Runtime.B_CreateCommand());
        }
    }
}
