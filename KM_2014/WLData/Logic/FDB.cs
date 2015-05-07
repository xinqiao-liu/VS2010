using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class FDB
    {
        public static WLDataModelLayer.FDB Check(string prefix, WLDataModelLayer.FDB item)
        {
            Common.Validate.ValidString(prefix, "网点编号", 12, item.Node);
            Common.Validate.ValidString(prefix, "运单编号", 12, item.SN);
            Common.Validate.ValidString(prefix, "用户编号", 8, item.UID);
            return item;
        }

        //public static void Refresh(ListView list, DateTime date)
        //{
        //    list.Items.Clear();
        //    foreach (WLDataModelLayer.FDB i in Reads(User.Item.NodeCode, date))
        //    {
        //        ListViewItem item = new ListViewItem(i.SN);
        //        item.Tag = i;
        //        item.SubItems.Add(i.UID);
        //        item.SubItems.Add(i.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

        //        list.Items.Add(item);
        //    }
        //    if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        //}

        public static bool Insert(WLDataModelLayer.FDB item)
        {
            return WLDataAccessLayer.FDB.Insert(Runtime.B_CreateCommand(), Check("插入废单记录", item));
        }

        public static List<DateTime> GetDates(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Ascending)
        {
            return WLDataAccessLayer.FDB.GetDates(Runtime.B_CreateCommand(), mode);
        }

        public static List<WLDataModelLayer.FDB> Reads(string node, DateTime date)
        {
            Common.Validate.ValidString("读取废单记录", "网点编号", 12, node);
            return WLDataAccessLayer.FDB.Reads(Runtime.B_CreateCommand(), node, date);
        }
    }
}
