using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.PrintJSD
{
    public partial class SettingDialog : Form
    {
        public SettingDialog()
        {
            InitializeComponent();
        }

        private void SettingDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Path = txtPath.Text;

            Properties.Settings.Default.CheckIdIsNull = chkIdIsNull.Checked;
            Properties.Settings.Default.CheckIdNonInt = chkIdNonInt.Checked;
            Properties.Settings.Default.CheckTotalIsNull = chkTotalIsNull.Checked;
            Properties.Settings.Default.CheckTotalNonDec = chkTotalNonDec.Checked;
            Properties.Settings.Default.CheckTotalIsZero = chkTotalIsZero.Checked;            
        }

        private void SettingDialog_Load(object sender, EventArgs e)
        {
            txtPath.Text = Properties.Settings.Default.Path;

            chkIdIsNull.Checked = Properties.Settings.Default.CheckIdIsNull;
            chkIdNonInt.Checked = Properties.Settings.Default.CheckIdNonInt;
            chkTotalIsNull.Checked = Properties.Settings.Default.CheckTotalIsNull;
            chkTotalNonDec.Checked = Properties.Settings.Default.CheckTotalNonDec;
            chkTotalIsZero.Checked = Properties.Settings.Default.CheckTotalIsZero;
        }
    }
}
