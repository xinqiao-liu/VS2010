using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCheckout
{
    public partial class CPHRelatedForm : Form
    {
        public void RefreshList(ListView list, string cph, DateTime sdt, DateTime edt)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataLogicLayer.WLB.ReadByCPHAndDateRange(cph, sdt, edt))
            {
                ListViewItem item = new ListViewItem(i.Node);
                item.Tag = i;
                item.SubItems.Add(i.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(i.SN);
                item.SubItems.Add(i.UID);

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) list.Items[0].Selected = true;
        }

        public static void InitAndShowDialog(string cph, DateTime fromDate, DateTime toDate)
        {
            using (CPHRelatedForm cphRelatedForm = new CPHRelatedForm())
            {
                cphRelatedForm.RefreshList(cphRelatedForm.list, cph, fromDate, toDate);
                cphRelatedForm.Text = string.Format("车牌号'{0}'关联运单", cph);
                cphRelatedForm.ShowDialog();                    
            }
        }

        private void AddItems(List<WLDataModelLayer.WLB> items)
        {
            foreach (WLDataModelLayer.WLB i in items)
            {

            }
        }

        public CPHRelatedForm()
        {
            InitializeComponent();
        }
    }
}
