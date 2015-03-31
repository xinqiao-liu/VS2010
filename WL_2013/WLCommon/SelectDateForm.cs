using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon
{
    public partial class SelectDateForm : Form
    {
        public DateTime SelectDate
        {
            get { return Convert.ToDateTime(this.cboDate.Text); }
        }

        public List<DateTime> Dates
        {
            set
            {
                foreach(DateTime item in value) this.cboDate.Items.Add(item.ToString("yyyy-MM-dd"));

                if (this.cboDate.Items.Count > 0)
                {
                    this.cboDate.SelectedIndex = 0;
                    this.btnOK.Enabled = true;
                }
            }
        }

        public SelectDateForm()
        {
            InitializeComponent();
        }
    }
}
