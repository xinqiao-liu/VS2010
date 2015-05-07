using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Operation
{
    public partial class EndOfDayForm : Form
    {
        public static void InitAndShowDialog()
        {
            using (EndOfDayForm endOfDayForm = new EndOfDayForm()) { endOfDayForm.ShowDialog(); }
        }

        public EndOfDayForm()
        {
            InitializeComponent();
        }

        private void EndOfDayForm_Load(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.WLB.RefreshLocalNotEndOfDayDates(this.cboRQ, System.Data.SqlClient.SortOrder.Ascending);
               
                this.btnEOFD.Enabled = this.cboRQ.Items.Count > 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEOFD_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnEOFD.Enabled = false;

                DateTime selectDate = Convert.ToDateTime(this.cboRQ.Text);
                if (!WLDataLogicLayer.EndOfDay.Exists(selectDate))
                {
                    WLDataLogicLayer.EndOfDay.Insert(new WLDataModelLayer.EndOfDay { UID = WLDataLogicLayer.User.LoginUser.Userid, Date = selectDate });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { 
                this.EndOfDayForm_Load(sender, e); 
            }
        }
    }
}
