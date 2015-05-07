using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class BZFLEditForm : Form
    {
        public string EditName { get; set; }
        public decimal Value { get; set; }

        public BZFLEditForm()
        {
            InitializeComponent();
        }

        private void BZFLEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    this.Value = this.numValue.Value;

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BZFLEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.txtName.Text = this.EditName;
                this.numValue.Value = this.Value;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
