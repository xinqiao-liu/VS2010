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
    public partial class YDViewForm : Form
    {
        public static void InitAndShowDialog(string cph, DateTime fromDate, DateTime toDate)
        {
            using (YDViewForm ydViewForm = new YDViewForm())
            {                               
                WLDataLogicLayer.WLB.RefreshCollectByCPH_L(ydViewForm.list, cph, fromDate, toDate);
                ydViewForm.ShowDialog();                
            }
        }

        public YDViewForm()
        {
            InitializeComponent();
        }
    }
}
