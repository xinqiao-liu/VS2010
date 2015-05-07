using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class AuthorizeCustomForm : Form
    {
        public WLDataModelLayer.Authorize AuthorizeRecord { get; set; }

        public AuthorizeCustomForm()
        {
            InitializeComponent();
        }

        private void AuthorizeCustomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.txtServerAddress.Text == string.Empty)
                    {
                        MessageBox.Show("未指定服务器地址！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtServerAddress.Focus();
                        return;
                    }

                    if (this.txtUserid.Text == string.Empty)
                    {
                        MessageBox.Show("未指定用户名称！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtUserid.Focus();
                        return;
                    }

                    if (this.txtUserPassword.Text != this.txtVerifyPassword.Text)
                    {
                        MessageBox.Show("用户密码验证失败，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtVerifyPassword.Text = string.Empty;
                        this.txtUserPassword.Text = string.Empty;
                        this.txtUserPassword.Focus();
                        return;
                    }

                    if (this.txtDatabaseName.Text == string.Empty)
                    {
                        MessageBox.Show("未指定数据库名称！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtDatabaseName.Focus();
                        return;
                    }

                    Common.ConnectionInfo connectionInfo = new Common.ConnectionInfo();
                    connectionInfo.ServerAddress = this.txtServerAddress.Text;
                    connectionInfo.Userid = this.txtUserid.Text;
                    connectionInfo.UserPassword = this.txtUserPassword.Text;
                    connectionInfo.DatabaseName = this.txtDatabaseName.Text;
                    connectionInfo.ConnectionTimeout = Convert.ToInt32(this.txtConnectionTimeout.Value);
                    connectionInfo.PingEnabled = this.chkPingEnabled.Checked;
                    connectionInfo.PingTimeout = Convert.ToInt32(this.txtPingTimeout.Value);

                    this.AuthorizeRecord.Content = Common.ConnectionInfo.ToSqlBinary(connectionInfo);

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AuthorizeCustomForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("自定义授权[{0}-{1}]", this.AuthorizeRecord.Code, this.AuthorizeRecord.Name);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void chkPingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPingTimeout.Enabled = this.chkPingEnabled.Checked;
        }
    }
}
