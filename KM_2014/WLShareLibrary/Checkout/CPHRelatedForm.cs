using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Checkout
{
    public partial class CPHRelatedForm : Form
    {
        public static void InitAndShowDialog(string cph, DateTime fromDate, DateTime toDate)
        {
            using (CPHRelatedForm cphRelatedForm = new CPHRelatedForm())
            {
                WLDataLogicLayer.WLB.RefreshCollectByCPH_S(cphRelatedForm.list, cph, fromDate, toDate);
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
