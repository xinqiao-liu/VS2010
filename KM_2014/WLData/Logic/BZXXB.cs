using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class BZXXB
    {
        public static void Refresh(ComboBox list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.BZXXB i in WLDataAccessLayer.BZXXB.Reads(Runtime.B_CreateCommand()))
            {
                list.Items.Add(i.ToString());
            }
        }

        public static void Refresh(ListView list)
        {
            ListViewItem item;
            list.Items.Clear();
            foreach (WLDataModelLayer.BZXXB i in WLDataAccessLayer.BZXXB.Reads(Runtime.B_CreateCommand()))
            {
                item = new ListViewItem(i.Name);
                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static bool Exists(string name)
        {
            return WLDataAccessLayer.BZXXB.Exists(Runtime.B_CreateCommand(), 
                Common.Validate.ValidString("检测备注信息", "备注信息", 32, name));
        }

        public static bool Insert(string name)
        {
            return WLDataAccessLayer.BZXXB.Insert(Runtime.B_CreateCommand(), 
                Common.Validate.ValidString("插入备注信息", "备注信息", 32, name));
        }

        public static bool Delete(string name)
        {
            return WLDataAccessLayer.BZXXB.Delete(Runtime.B_CreateCommand(), 
                Common.Validate.ValidString("删除备注信息", "备注信息", 32, name));
        }

        public static bool Update(string old_name, string new_name)
        {
            return WLDataAccessLayer.BZXXB.Update(Runtime.B_CreateCommand(),
                Common.Validate.ValidString("更新备注信息", "原备注信息", 32, old_name),
                Common.Validate.ValidString("更新备注信息", "新备注信息", 32, new_name));
        }
    }
}
