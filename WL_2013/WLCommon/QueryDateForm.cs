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
    public partial class QueryDateForm : Form
    {
        public DateTime QueryDate 
        {
            get { return MonthCalendar.SelectionStart; }            
        }

        public List<DateTime> ValidDate
        {
            set
            {
                if (value.Count > 0)
                {
                    this.MonthCalendar.MinDate = value.Min();
                    this.MonthCalendar.MaxDate = value.Max();
                    this.MonthCalendar.BoldedDates = value.ToArray();

                    this.btnOK.Enabled = (this.MonthCalendar.BoldedDates.Contains(value.Max()));
                }
            }
        }

        public QueryDateForm()
        {
            InitializeComponent();
        }

        private void QueryDateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;

                    if (!this.MonthCalendar.BoldedDates.Contains(QueryDate))
                    {
                        MessageBox.Show("指定日期不存在可用数据！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                //this.btnOK.Enabled = (this.MonthCalendar.BoldedDates.Contains(QueryDate));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
