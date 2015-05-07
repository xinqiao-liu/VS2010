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
    public partial class ClientSettingForm : Form
    {
        public bool ConfirmClose
        {
            get { return this.chkConfirmClose.Checked; }
            set { this.chkConfirmClose.Checked = value; }
        }

        public bool AutoSyncServerDT
        {
            get { return this.chkAutoSyncServerDT.Checked; }
            set { this.chkAutoSyncServerDT.Checked = value; }
        }

        public bool PingEnabled
        {
            get { return this.chkPingEnabled.Checked; }
            set { this.chkPingEnabled.Checked = value; }
        }

        public int PingTimeout
        {
            get { return Convert.ToInt32(this.txtPingTimeout.Value); }
            set { this.txtPingTimeout.Value = value; }
        }

        public bool AutoLogin 
        {
            get { return this.chkAutoLogin.Checked; }
            set { this.chkAutoLogin.Checked = value; }
        }

        public string Userid
        {
            get { return (this.txtUserid.Enabled) ? this.txtUserid.Text : string.Empty; }
            set { this.txtUserid.Text = (this.chkAutoLogin.Checked) ? value : string.Empty; }
        }

        public string Password
        {
            get { return (this.txtPassword.Enabled) ? this.txtPassword.Text : string.Empty; }
            set { this.txtPassword.Text = (this.chkAutoLogin.Checked) ? value : string.Empty; }
        }

        public int PageWidth
        {
            get { return Convert.ToInt32(this.numPageWidth.Value); }
            set { this.numPageWidth.Value = value; }
        }

        public int PageHeight
        {
            get { return Convert.ToInt32(this.numPageHeight.Value); }
            set { this.numPageHeight.Value = value; }
        }

        public int PageOffsetX
        {
            get { return Convert.ToInt32(this.numPageOffsetX.Value); }
            set { this.numPageOffsetX.Value = value; }
        }

        public int PageOffsetY
        {
            get { return Convert.ToInt32(this.numPageOffsetY.Value); }
            set { this.numPageOffsetY.Value = value; }
        }

        public void RemovePrintTab()
        {
            this.tabControl.Controls.Remove(this.tabPrint);
        }

        public ClientSettingForm()
        {
            InitializeComponent();
        }

        private void ClientSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;
                    if (this.chkAutoLogin.Checked && this.txtUserid.Text == string.Empty)
                    {
                        MessageBox.Show("用户工号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtUserid.Focus();
                        return;
                    }
                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void chkAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUserid.Enabled = this.chkAutoLogin.Checked;
            this.txtPassword.Enabled = this.chkAutoLogin.Checked;
        }

        private void chkPingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPingTimeout.Enabled = this.chkPingEnabled.Checked;
        }
    }
}
