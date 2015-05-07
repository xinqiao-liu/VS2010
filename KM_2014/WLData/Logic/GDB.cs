using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class GDB
    {
        public static WLDataModelLayer.GDB Check(string prefix, WLDataModelLayer.GDB item)
        {
            Common.Validate.ValidString(prefix, "网点编号", 12, item.Node);
            Common.Validate.ValidString(prefix, "运单编号", 12, item.SN);
            Common.Validate.ValidString(prefix, "原车牌号", 8, item.OldCPH);
            Common.Validate.ValidString(prefix, "原班次", 8, item.OldBC);
            Common.Validate.ValidString(prefix, "新车牌号", 8, item.NewCPH);
            Common.Validate.ValidString(prefix, "新班次", 8, item.NewBC);
            Common.Validate.ValidString(prefix, "记录类型", "MS", item.RecordType);
            Common.Validate.ValidString(prefix, "用户编号", 8, item.UID);
            return item;
        }

        //public static void Refresh(ListView list, DateTime date, string recordtype)
        //{
        //    list.Items.Clear();
        //    foreach (WLDataModelLayer.GDB i in Reads(User.Item.NodeCode, date))
        //    {
        //        ListViewItem item = new ListViewItem(i.SN);
        //        item.Tag = i;
        //        item.SubItems.Add(i.OldCPH);
        //        item.SubItems.Add(i.OldRQ.ToString("yyyy-MM-dd"));
        //        item.SubItems.Add(i.OldBC);
        //        item.SubItems.Add(i.NewCPH);
        //        item.SubItems.Add(i.NewRQ.ToString("yyyy-MM-dd"));
        //        item.SubItems.Add(i.NewBC);
        //        item.SubItems.Add(i.UID);
        //        item.SubItems.Add(i.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

        //        list.Items.Add(item);
        //    }
        //    if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true;}
        //}

        public static bool Insert(WLDataModelLayer.GDB item)
        {
            return WLDataAccessLayer.GDB.Insert(Runtime.B_CreateCommand(), Check("改单废单记录", item));
        }

        public static List<DateTime> GetDates(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Ascending)
        {
            return WLDataAccessLayer.GDB.GetDates(Runtime.B_CreateCommand(), mode);
        }

        public static List<WLDataModelLayer.GDB> Reads(string node, DateTime date)
        {
            Common.Validate.ValidString("读取改单记录", "网点编号", 12, node);
            return WLDataAccessLayer.GDB.Reads(Runtime.B_CreateCommand(), node, date);
        }
    }
}
