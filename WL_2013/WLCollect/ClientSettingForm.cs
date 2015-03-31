using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCollect
{
    public partial class ClientSettingForm : Form
    {
        public bool ConfirmClose
        {
            get { return this.chkConfirmClose.Checked; }
            set { this.chkConfirmClose.Checked = value; }
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

        public bool CollectFD
        {
            get { return this.chkCollectFD.Checked; }
            set { this.chkCollectFD.Checked = value; }
        }

        public bool CreateDailySheet
        {
            get { return this.chkImportDailySheet.Checked; }
            set { this.chkImportDailySheet.Checked = value; }
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
