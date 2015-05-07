using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLAuthorize
{
    public partial class MainForm : Form
    {
        private void Clean()
        {
            this.txtServerAddress.Text = "";
            this.txtServerAddress.Focus();
            this.txtUserid.Text = "";
            this.txtUserPassword.Text = "";
            this.txtVerifyPassword.Text = "";
            this.txtDatabaseName.Text = "";
            this.txtConnectionTimeout.Value = 0;
            this.chkPingEnabled.Checked = true;
            this.txtPingTimeout.Value = 0;
        }

        private void Check()
        {
            if (this.txtServerAddress.Text == string.Empty)
            {
                this.txtServerAddress.Focus();
                throw new ApplicationException("未指定服务器地址！");
            }

            if (this.txtUserid.Text == string.Empty)
            {
                this.txtUserid.Focus();
                throw new ApplicationException("未指定用户名称！");
            }

            if (this.txtUserPassword.Text != this.txtVerifyPassword.Text)
            {
                MessageBox.Show("", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtVerifyPassword.Text = string.Empty;
                this.txtUserPassword.Text = string.Empty;
                this.txtUserPassword.Focus();
                throw new ApplicationException("用户密码验证失败，请重新输入！");
            }

            if (this.txtDatabaseName.Text == string.Empty)
            {
                this.txtDatabaseName.Focus();
                throw new ApplicationException("未指定数据库名称！");
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.AddExtension = true;
                    openFileDialog.CheckFileExists = true;
                    openFileDialog.CheckPathExists = true;
                    openFileDialog.DefaultExt = ".auth";
                    openFileDialog.Filter = "网点授权文件|*.auth";
                    openFileDialog.FilterIndex = 0;
                    openFileDialog.InitialDirectory = Application.StartupPath;
                    openFileDialog.Title = "导入网点授权信息";

                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        System.Data.SqlTypes.SqlBinary importContent = WLDataModelLayer.Authorize.Import(openFileDialog.FileName);
                        if (!importContent.IsNull)
                        {
                            Common.ConnectionInfo connInfo = Common.ConnectionInfo.ToConnectionInfo(importContent);
                            if (connInfo != null)
                            {
                                this.txtServerAddress.Text = connInfo.ServerAddress;
                                this.txtUserid.Text = connInfo.Userid;
                                this.txtUserPassword.Text = connInfo.UserPassword;
                                this.txtVerifyPassword.Text = connInfo.UserPassword;
                                this.txtDatabaseName.Text = connInfo.DatabaseName;
                                this.txtConnectionTimeout.Value = connInfo.ConnectionTimeout;
                                this.chkPingEnabled.Checked = connInfo.PingEnabled;
                                this.txtPingTimeout.Value = connInfo.PingTimeout;
                            }
                            else throw new ApplicationException("连接信息无效！");

                        }
                        else throw new ApplicationException("授权信息无效！");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                this.Check();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.DefaultExt = ".auth";                    
                    saveFileDialog.Filter = "网点授权文件|*.auth";
                    saveFileDialog.FilterIndex = 0;
                    saveFileDialog.InitialDirectory = Application.StartupPath;
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.Title = "导出网点授权信息";

                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Common.ConnectionInfo connInfo = new Common.ConnectionInfo();
                        connInfo.ServerAddress = this.txtServerAddress.Text;
                        connInfo.Userid = this.txtUserid.Text;
                        connInfo.UserPassword = this.txtUserPassword.Text;
                        connInfo.DatabaseName = this.txtDatabaseName.Text;
                        connInfo.ConnectionTimeout = Convert.ToInt32(this.txtConnectionTimeout.Value);
                        connInfo.PingEnabled = this.chkPingEnabled.Checked;
                        connInfo.PingTimeout = Convert.ToInt32(this.txtPingTimeout.Value);

                        WLDataModelLayer.Authorize.Export(saveFileDialog.FileName, Common.ConnectionInfo.ToSqlBinary(connInfo));
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            try
            {
                this.Clean();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }            
        }

        private void chkPingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPingTimeout.Enabled = this.chkPingEnabled.Checked;
        }
    }
}
