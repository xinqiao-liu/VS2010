using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class HWLXB
    {
        public static void Refresh(ComboBox list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.HWLXB i in WLDataAccessLayer.HWLXB.Reads(Runtime.B_CreateCommand()))
            {
                list.Items.Add(i.ToString());
            }
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.HWLXB i in WLDataAccessLayer.HWLXB.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem item = new ListViewItem(i.Name);
                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static bool Exists(string name)
        {
            return WLDataAccessLayer.HWLXB.Exists(Runtime.B_CreateCommand(), name);
        }

        public static bool Insert(string name)
        {
            return WLDataAccessLayer.HWLXB.Insert(Runtime.B_CreateCommand(),
                Common.Validate.ValidString("插入货物类型", "类型名称", 32, name));
        }

        public static bool Delete(string name)
        {
            return WLDataAccessLayer.HWLXB.Delete(Runtime.B_CreateCommand(), name);
        }

        public static bool Update(string old_name, string new_name)
        {
            return WLDataAccessLayer.HWLXB.Update(Runtime.B_CreateCommand(), old_name,
                Common.Validate.ValidString("更新货物类型", "新类型名称", 32, new_name));
        }
    }
}
