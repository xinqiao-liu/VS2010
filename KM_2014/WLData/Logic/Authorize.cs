using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class Authorize
    {
        public static void Refresh(ComboBox list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.Authorize i in WLDataAccessLayer.Authorize.Reads(Runtime.B_CreateCommand()))
            {
                if(!i.Content.IsNull) list.Items.Add(i);
            }
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.Authorize i in WLDataAccessLayer.Authorize.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem item = new ListViewItem(i.Code);
                item.Tag = i;
                item.SubItems.Add(i.Name);
                item.SubItems.Add(i.CityCode);
                item.SubItems.Add(i.CityName);
                item.SubItems.Add(i.Content.IsNull ? "未授权" : "已授权");
                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static bool Exists(string code)
        {
            return WLDataAccessLayer.Authorize.Exists(Runtime.B_CreateCommand(), 
                Common.Validate.ValidString("检测授权记录是否存在", "网点代码", 12, code));
        }

        public static bool Insert(WLDataModelLayer.Authorize item)
        {
            return WLDataAccessLayer.Authorize.Insert(Runtime.B_CreateCommand(), item);
        }

        public static bool Delete(string code)
        {
            return WLDataAccessLayer.Authorize.Delete(Runtime.B_CreateCommand(), 
                Common.Validate.ValidString("删除授权记录", "网点代码", 12, code));
        }
        
        public static WLDataModelLayer.Authorize Read(string code)
        {
            return WLDataAccessLayer.Authorize.Read(Runtime.B_CreateCommand(), code);
        }

        public static System.Data.SqlTypes.SqlBinary GetContent(string code)
        {
            return WLDataAccessLayer.Authorize.GetContent(Runtime.B_CreateCommand(), 
                Common.Validate.ValidString("获取授权信息", "网点代码", 12, code));
        }

        public static bool SetContent(WLDataModelLayer.Authorize item)
        {
            return Authorize.SetContent(item.Code, item.Content);
        }

        public static bool SetContent(string code, System.Data.SqlTypes.SqlBinary content)
        {
            return WLDataAccessLayer.Authorize.SetContent(Runtime.B_CreateCommand(), 
                Common.Validate.ValidString("设置授权信息", "网点代码", 12, code), content);
        }
    }
}
