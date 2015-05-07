using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace WLDataLogicLayer
{
    public static class Node
    {
        private static WLDataModelLayer.Node Check(string prefix, WLDataModelLayer.Node item)
        {
            Common.Validate.ValidString(prefix, "网点代码", 12, item.Code);
            Common.Validate.ValidString(prefix, "网点名称", 32, item.Name);
            Common.Validate.ValidString(prefix, "隶属代码", 12, item.CityCode);
            Common.Validate.ValidString(prefix, "隶属名称", 32, item.CityName);
            Common.Validate.NonOverflow(prefix, "地址", 64, item.Address);
            Common.Validate.NonOverflow(prefix, "电话", 32, item.Tel);
            return item;
        }

        public static void Refresh(ComboBox list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.Node item in WLDataAccessLayer.Node.Reads(Runtime.B_CreateCommand()))
            {
                list.Items.Add(item);
            }
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.Node item in WLDataAccessLayer.Node.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem i = new ListViewItem(item.Code);
                i.Tag = item;
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.CityCode);
                i.SubItems.Add(item.CityName);
                i.SubItems.Add(item.Enable ? "联网" : "");
                i.SubItems.Add(item.Address);
                i.SubItems.Add(item.Tel);
                list.Items.Add(i);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        //检测列表是否包含指定字符串
        public static bool Contains(ComboBox list, string str)
        {
            for (int index = 0; index < list.Items.Count; index++)
            {
                if (list.Items[index].ToString() == str) return true;
            }
            return false;
        }

        //接货网点初始化（不含发货网点列表存在的网点）
        public static void Refresh( ComboBox jh_list, ComboBox fh_list)
        {
            jh_list.Items.Clear();
            foreach (WLDataModelLayer.Node i in Reads(true))
            {
                if (!Contains(fh_list, i.ToString())) jh_list.Items.Add(i);
            }
        }

        public static bool Insert(WLDataModelLayer.Node item)
        {
            return WLDataAccessLayer.Node.Insert(Runtime.B_CreateCommand(), Check("插入网点记录", item));
        }

        public static bool Delete()
        {
            return WLDataAccessLayer.Node.Delete(Runtime.B_CreateCommand());
        }

        public static WLDataModelLayer.Node Read(string code)
        {
            return WLDataAccessLayer.Node.Read(Runtime.B_CreateCommand(), code);
        }

        //读取网点列表，true 表示获取已联网网点，false 表示获取全部网点
        public static List<WLDataModelLayer.Node> Reads(bool enable)
        {
            return WLDataAccessLayer.Node.Reads(Runtime.B_CreateCommand(), enable);
        }
    }
}
