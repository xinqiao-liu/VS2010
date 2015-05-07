using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.IDManage
{
    public partial class MainForm : Form
    {
        private void Init(String connStr)
        {
            this.cboUserType.Items.Clear();   
            this.lstUser.Items.Clear();
            this.txtUserNumber.Text = "0";

            KM.Common.Connections.InitOneConnection(connStr, null);            
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.CopyrightInfo.Text = "长春市公路客运总站-用户ID卡管理 （版本：2010.5）";

                if (Properties.Settings.Default.ConnectionString != String.Empty)
                {
                    this.Init(Properties.Settings.Default.ConnectionString);
                }
            }
            catch (Exception ex)
            {
                KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 5);
            }
        }

        private void ConnectionSettingButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (KM.Common.ConnectionDialog connectionDialog = new KM.Common.ConnectionDialog())
                {
                    connectionDialog.OneConnectionString = Properties.Settings.Default.ConnectionString;
                    if (connectionDialog.ShowDialog() == DialogResult.OK 
                        && connectionDialog.OneConnectionString != String.Empty
                        && connectionDialog.OneConnectionString != Properties.Settings.Default.ConnectionString)
                    {
                        this.Init(connectionDialog.OneConnectionString);

                        Properties.Settings.Default.ConnectionString = connectionDialog.OneConnectionString;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 5);
            }
        }

        private void cboUserType_DropDown(object sender, EventArgs e)
        {
            try
            {
                KM.Common.ID.RefreshUserTypes(KM.Common.Connections.OneConnection, this.cboUserType);
            }
            catch (Exception ex)
            {
                KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 5);
            }
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                KM.Common.ID.RefreshUsers(KM.Common.Connections.OneConnection, this.lstUser, this.cboUserType.Text);
                this.txtUserNumber.Text = this.lstUser.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 5);
            }
        }

        private void lstUser_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.lstUser.SelectedItems.Count > 0)
                {
                    using (KM.Common.IDEditDialog idEditDialog = new KM.Common.IDEditDialog())
                    {
                        idEditDialog.UID = this.lstUser.SelectedItems[0].Text;
                        idEditDialog.CID = this.lstUser.SelectedItems[0].SubItems[3].Text;
                        if (idEditDialog.ShowDialog() == DialogResult.OK)
                        {
                            this.lstUser.SelectedItems[0].SubItems[3].Text = idEditDialog.CID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 5);
            }
        }
    }
}
