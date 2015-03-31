using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCheckout
{
    public partial class ClientSettingForm : Form
    {
        private bool ConfirmClose
        {
            get { return this.chkConfirmClose.Checked; }
            set { this.chkConfirmClose.Checked = value; }
        }

        private bool AutoSyncServerDT
        {
            get { return this.chkAutoSyncServerDT.Checked; }
            set { this.chkAutoSyncServerDT.Checked = value; }
        }

        private bool PingEnabled
        {
            get { return this.chkPingEnabled.Checked; }
            set { this.chkPingEnabled.Checked = value; }
        }

        private int PingTimeout
        {
            get { return Convert.ToInt32(this.txtPingTimeout.Value); }
            set { this.txtPingTimeout.Value = value; }
        }

        private bool AutoLogin
        {
            get { return this.chkAutoLogin.Checked; }
            set { this.chkAutoLogin.Checked = value; }
        }

        private string Userid
        {
            get { return (this.txtUserid.Enabled) ? this.txtUserid.Text : string.Empty; }
            set { this.txtUserid.Text = (this.chkAutoLogin.Checked) ? value : string.Empty; }
        }

        private string Password
        {
            get { return (this.txtPassword.Enabled) ? this.txtPassword.Text : string.Empty; }
            set { this.txtPassword.Text = (this.chkAutoLogin.Checked) ? value : string.Empty; }
        }

        private WLDataModelLayer.CollectByCustomerSortMode CustomerSortMode
        {
            get { return (this.cboCustomerSortMode.SelectedIndex == 0) ? WLDataModelLayer.CollectByCustomerSortMode.Count : WLDataModelLayer.CollectByCustomerSortMode.Total; }
            set { this.cboCustomerSortMode.SelectedIndex = (value == WLDataModelLayer.CollectByCustomerSortMode.Count) ? 0 : 1; }
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

                    Properties.Settings.Default.ConfirmClose = this.ConfirmClose;
                    Properties.Settings.Default.AutoSyncServerDT = this.AutoSyncServerDT;
                    Properties.Settings.Default.PingEnabled = this.PingEnabled;
                    Properties.Settings.Default.PingTimeout = this.PingTimeout;
                    Properties.Settings.Default.AutoLogin = this.AutoLogin;
                    Properties.Settings.Default.Userid = this.Userid;
                    Properties.Settings.Default.Password = this.Password;

                    Properties.Settings.Default.CollectByCustomerSortMode = this.CustomerSortMode.ToString();

                    Properties.Settings.Default.Save();

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void ClientSettingForm_Shown(object sender, EventArgs e)
        {
            this.ConfirmClose = Properties.Settings.Default.ConfirmClose;
            this.AutoSyncServerDT = Properties.Settings.Default.AutoSyncServerDT;
            this.PingEnabled = Properties.Settings.Default.PingEnabled;
            this.PingTimeout = Properties.Settings.Default.PingTimeout;
            this.AutoLogin = Properties.Settings.Default.AutoLogin;
            this.Userid = Properties.Settings.Default.Userid;
            this.Password = Properties.Settings.Default.Password;

            this.CustomerSortMode = WLDataModelLayer.CollectByCustomer.ToSortMode(Properties.Settings.Default.CollectByCustomerSortMode);
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