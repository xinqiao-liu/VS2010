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
        public DateTime MinDate
        {
            get { return this.GetMinDate(); }
            private set
            {
                this.txtMinDate.MinDate = value;
                this.txtMaxDate.MinDate = value;
            }
        }

        public DateTime MaxDate
        {
            get { return this.GetMaxDate(); }
            private set
            {
                this.txtMinDate.Value = value;
                this.txtMaxDate.Value = value;
                this.txtMinDate.MaxDate = value;
                this.txtMinDate.MaxDate = value;
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
            List<DateTime> dateList = WLDataLogicLayer.WLB.GetDateList(WLDataLogicLayer.Setting.NodeCode, System.Data.SqlClient.SortOrder.Descending, 0);
            if (dateList.Count <= 0)
            {
                MessageBox.Show("不存在可汇总运单数据！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.MinDate = dateList[dateList.Count - 1];
            this.MaxDate = dateList[0];
            this.btnOK.Enabled = true;
        }
    }
}
