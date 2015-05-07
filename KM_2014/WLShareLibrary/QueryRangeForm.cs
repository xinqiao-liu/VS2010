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
    public partial class QueryRangeForm : Form
    {
        private bool setMinDate = false;
        private bool setMaxDate = false;

        public DateTime MinDate
        {
            get { return this.GetMinDate(); }
            set
            {
                this.txtMinDate.MinDate = value;
                this.txtMaxDate.MinDate = value;

                this.setMinDate = true;
            }
        }

        public DateTime MaxDate
        {
            get { return this.GetMaxDate(); }
            set
            {
                this.txtMinDate.Value = value;
                this.txtMaxDate.Value = value;
                this.txtMinDate.MaxDate = value;
                this.txtMinDate.MaxDate = value;

                this.setMaxDate = true;
            }
        }

        private DateTime GetMinDate()
        {
            if (this.txtMinDate.Value > this.txtMaxDate.Value)
                return this.txtMaxDate.Value;
            else
                return this.txtMinDate.Value;
        }

        private DateTime GetMaxDate()
        {
            if (this.txtMinDate.Value > this.txtMaxDate.Value)
                return this.txtMinDate.Value;
            else
                return this.txtMaxDate.Value;
        }

        public QueryRangeForm()
        {
            InitializeComponent();
        }

        private void QueryRangeForm_Shown(object sender, EventArgs e)
        {
            this.btnOK.Enabled = (this.setMaxDate && this.setMinDate);
        }
    }
}
