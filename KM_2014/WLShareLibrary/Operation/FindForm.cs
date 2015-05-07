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
    public partial class FindForm : Form
    {
        public String Keyword 
        {
            get
            {
                if (this.rdoRQ.Checked) return "RQ";
                if (this.rdoSN.Checked) return "SN";
                if (this.rdoFHRName.Checked) return "FHR_Name";
                if (this.rdoFHRMobile.Checked) return "FHR_Mobile";

                throw new InvalidOperationException();
            }        
        }

        public String Content 
        {
            get
            {
                if (this.rdoSN.Checked)
                    return WLDataLogicLayer.Bill.Format(this.cboContent.Text);
                else
                    return this.cboContent.Text;
            }
        }

        public FindForm()
        {
            InitializeComponent();
        }

        private void Keywords_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnOK.Enabled = false;
                this.cboContent.Items.Clear();
                this.cboContent.Text = string.Empty;

                if (this.rdoRQ.Checked)
                {
                    WLDataLogicLayer.WLB.RefreshLocalNotEndOfDayDates(this.cboContent, System.Data.SqlClient.SortOrder.Descending);

                    this.cboContent.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.lblTitle.Text = "办单日期：";                    
                }
                else
                    this.cboContent.DropDownStyle = ComboBoxStyle.Simple;

                if (this.rdoSN.Checked) { this.lblTitle.Text = "运单编号："; this.cboContent.MaxLength = 12; }
                if (this.rdoFHRName.Checked) { this.lblTitle.Text = "发货人姓名："; this.cboContent.MaxLength = 32; }
                if (this.rdoFHRMobile.Checked) { this.lblTitle.Text = "发货人电话："; this.cboContent.MaxLength = 32; }

                this.cboContent.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cboContent_TextChanged(object sender, EventArgs e)
        {
            this.btnOK.Enabled = !string.IsNullOrEmpty(this.cboContent.Text);
        }

    }
}
