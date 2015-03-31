using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class Mapping
    {
        private static Dictionary<string, string> m_Array = null;

        public static Dictionary<string, string> Array
        {
            get
            {
                if (Mapping.m_Array == null)
                    throw new ApplicationException("车牌映射数据未初始化！");
                else
                    return Mapping.m_Array;
            }
            private set { Mapping.m_Array = value; }
        }

        public static void Init()
        {
            Mapping.Array = Mapping.GetMappingArray();
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.Mapping i in WLDataAccessLayer.Mapping.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem item = new ListViewItem(i.Code);
                item.Tag = i;
                item.SubItems.Add(i.Value);
                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static Dictionary<string, string> GetMappingArray()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            foreach (WLDataModelLayer.Mapping i in WLDataAccessLayer.Mapping.Reads(Runtime.B_CreateCommand()))
            {
                items.Add(i.Code, i.Value);
            }
            return items;
        }

        public static bool Exists(string code)
        {
            return WLDataAccessLayer.Mapping.Exists(Runtime.B_CreateCommand(), code);                
        }

        public static bool Insert(string code, string value)
        {
            return WLDataAccessLayer.Mapping.Insert(Runtime.B_CreateCommand(), 
                Common.Validate.ValidString("插入映射代码", "映射代码", 16, code),
                Common.Validate.ValidString("插入映射代码", "映射值", 16, value));
        }

        public static bool Delete(string code)
        {
            return WLDataAccessLayer.Mapping.Delete(Runtime.B_CreateCommand(), code);
        }

        public static bool Update(string code, string new_value)
        {
            return WLDataAccessLayer.Mapping.Update(Runtime.B_CreateCommand(), code,
                Common.Validate.ValidString("更新映射代码", "新映射值", 16, new_value));
        }
    }
}
