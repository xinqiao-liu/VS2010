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
    public partial class SimpleFindForm : Form
    {
        public string ID { set { this.lblID.Text = value; } }
        public string Value { get { return this.txtValue.Text; } }
        public bool NonEmpty { get; set; }

        public SimpleFindForm()
        {
            InitializeComponent();
        }

        private void SimpleFindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    if (this.NonEmpty && string.IsNullOrEmpty(this.txtValue.Text)) { e.Cancel = true; return; }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
