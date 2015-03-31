using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class PrintFormat
    {
        private static List<WLDataModelLayer.PrintFormat> m_Array = null;

        public static List<WLDataModelLayer.PrintFormat> Array
        {
            get
            {
                if (PrintFormat.m_Array == null)
                    throw new ApplicationException("打印格式数据未初始化！");
                else
                    return PrintFormat.m_Array;
            }
            set { PrintFormat.m_Array = value; }
        }

        public static void Init()
        {
            PrintFormat.Array = PrintFormat.Reads();
        }

        private static WLDataModelLayer.PrintFormat Check(string prefix, WLDataModelLayer.PrintFormat item)
        {
            Common.Validate.ValidString(prefix, "格式代码", 16, item.Code);
            Common.Validate.ValidString(prefix, "格式名称", 32, item.Name);
            Common.Validate.ValidString(prefix, "字体名称", 32, item.FontName);
            Common.Validate.ValidString(prefix, "字体模式", 8, item.FontMode);
            Common.Validate.ValidPositiveInt(prefix, "位置X", item.X);
            Common.Validate.ValidPositiveInt(prefix, "位置Y", item.Y);
            Common.Validate.ValidPositiveInt(prefix, "字体大小", item.FontSize);
            return item;
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.PrintFormat i in WLDataAccessLayer.PrintFormat.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem item = new ListViewItem(i.Code);
                item.Tag = i;
                item.SubItems.Add(i.Name);
                item.SubItems.Add(i.X.ToString());
                item.SubItems.Add(i.Y.ToString());
                item.SubItems.Add(i.FontName);
                item.SubItems.Add(i.FontSize.ToString());
                item.SubItems.Add(i.FontMode);
                item.SubItems.Add(i.Enable ? "启用" : "停用");

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static bool Update(WLDataModelLayer.PrintFormat item)
        {
            return WLDataAccessLayer.PrintFormat.Update(Runtime.B_CreateCommand(), Check("更新打印格式", item));
        }

        public static List<WLDataModelLayer.PrintFormat> Reads()
        {
            return WLDataAccessLayer.PrintFormat.Reads(Runtime.B_CreateCommand());
        }
    }
}
