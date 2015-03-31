using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class Customer
    {
        public static WLDataModelLayer.Customer Check(string prefix, WLDataModelLayer.Customer item)
        {
            Common.Validate.ValidString(prefix, "客户名称", 8, item.Name);
            Common.Validate.ValidString(prefix, "客户电话", 32, item.Tel);
            Common.Validate.NonOverflow(prefix, "客户地址", 32, item.Address);
            return item;
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.Customer i in WLDataAccessLayer.Customer.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem item = new ListViewItem(i.Name);
                item.Tag = i;
                item.SubItems.Add(i.Tel);
                item.SubItems.Add(i.Address);
                item.SubItems.Add(i.Enable ? "启用" : "停用");

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static bool Exists(string tel)
        {
            return WLDataAccessLayer.Customer.Exists(Runtime.B_CreateCommand(), tel);
        }

        public static bool Insert(WLDataModelLayer.Customer item)
        {
            return WLDataAccessLayer.Customer.Insert(Runtime.B_CreateCommand(), Check("插入客户数据", item));
        }

        public static bool Delete(string name, string tel)
        {
            return WLDataAccessLayer.Customer.Delete(Runtime.B_CreateCommand(), name, tel);
        }

        public static bool Update(string old_name, string old_tel, WLDataModelLayer.Customer item)
        {
            return WLDataAccessLayer.Customer.Update(Runtime.B_CreateCommand(), old_name, old_tel, Check("更新客户数据", item));
        }

        public static string GetName(string tel)
        {
            return WLDataAccessLayer.Customer.GetName(Runtime.B_CreateCommand(), tel);
        }
    }
}
