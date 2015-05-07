using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class WLT
    {
        public static void RefreshList(ListView list, string node, string sn)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                if (!centralClient.WLT_Exist(node, sn))
                {
                    MessageBox.Show(string.Format("不存在'{0}'运单追踪记录！", sn), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }

                foreach (WLDataModelLayer.WLT item in centralClient.WLT_Reads(node, sn))
                {
                    ListViewItem i = new ListViewItem(item.Node);
                    i.Tag = item;
                    i.SubItems.Add(item.Date.ToString("yyyy-MM-dd"));
                    i.SubItems.Add(item.CDT.ToString("yyyy-MM-dd HH:mm:ss"));
                    i.SubItems.Add(item.Content);

                    list.Items.Add(i);
                }
                if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
            }
        }
    }
}
