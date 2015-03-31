using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class UserEditForm : Form
    {
        public string Userid { get; set; }
        public WLDataModelLayer.User Item { get; set; }
        public Common.OPMode OPMode { get; set; }

        public UserEditForm()
        {
            InitializeComponent();
        }

        private void UserEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.txtUserid.Text == string.Empty)
                    {
                        MessageBox.Show("用户工号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtUserid.Focus();
                        return;
                    }

                    switch (this.OPMode)
                    {
                        case Common.OPMode.Append:
                            if (WLDataLogicLayer.User.Exists(this.txtUserid.Text))
                            {
                                MessageBox.Show("指定用户工号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtUserid.SelectAll();
                                this.txtUserid.Focus();
                                return;
                            }                            

                            if (this.txtUsername.Text == string.Empty)
                            {
                                MessageBox.Show("用户姓名不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtUsername.Focus();
                                return;
                            }

                            if (this.txtPassword.Text != this.txtValidate.Text)
                            {
                                MessageBox.Show("用户密码验证失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtPassword.Clear();
                                this.txtPassword.Focus();
                                this.txtValidate.Clear();

                                return;
                            }

                            Item.Password = this.txtPassword.Text;
                            break;
                        case Common.OPMode.Edit:
                            if (this.txtUserid.Text != this.Userid && WLDataLogicLayer.User.Exists(this.txtUserid.Text))
                            {
                                MessageBox.Show("指定用户工号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtUserid.SelectAll();
                                this.txtUserid.Focus();
                                return;
                            }          
 
                            if (this.txtUsername.Text == string.Empty)
                            {
                                MessageBox.Show("用户姓名不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtUsername.Focus();
                                return;
                            }             
                            break;
                        default:
                            break;
                    }

                    WLDataModelLayer.Node node = this.cboNode.SelectedItem as WLDataModelLayer.Node;

                    Item.NodeCode = (node != null) ? node.Code : string.Empty;
                    Item.NodeName = (node != null) ? node.Name : string.Empty;

                    Item.Userid = this.txtUserid.Text;
                    Item.Username = this.txtUsername.Text;

                    Item.MP = this.chkManagePriv.Checked;
                    Item.SP = this.chkSelectPriv.Checked;
                    Item.IP = this.chkInsertPriv.Checked;
                    Item.UP = this.chkUpdatePriv.Checked;
                    Item.DP = this.chkDeletePriv.Checked;
                    Item.Enable = this.chkEnable.Checked;
      
                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void UserEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Node.Refresh(this.cboNode);

                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        this.Text = "添加用户";
                        this.txtPassword.Enabled = true;
                        this.txtValidate.Enabled = true;
                        break;
                    case Common.OPMode.Edit:
                        this.Text = "编辑用户";
                        this.btnCheckUserExists.Enabled = false;

                        if (this.Item != null)
                        {
                            this.cboNode.SelectedIndex = this.cboNode.FindStringExact(this.Item.NodeCode + "-" + this.Item.NodeName);

                            this.txtUserid.Text = this.Item.Userid;
                            this.txtUsername.Text = this.Item.Username;

                            this.chkManagePriv.Checked = this.Item.MP;
                            this.chkSelectPriv.Checked = this.Item.SP;
                            this.chkInsertPriv.Checked = this.Item.IP;
                            this.chkUpdatePriv.Checked = this.Item.UP;
                            this.chkDeletePriv.Checked = this.Item.DP;
                            this.chkEnable.Checked = this.Item.Enable;
                        }
                        else
                        {
                            this.tabControl.Enabled = false;
                            this.btnOK.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCheckUserExists_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (this.txtUserid.Text == string.Empty)
                {
                    MessageBox.Show("用户工号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtUserid.Focus();
                    return;
                }

                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        if (WLDataLogicLayer.User.Exists(this.txtUserid.Text))
                            MessageBox.Show("指定用户工号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("指定用户工号未使用，可以添加。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case Common.OPMode.Edit:
                        if (this.txtUserid.Text != this.Userid)
                        {
                            if (WLDataLogicLayer.User.Exists(this.txtUserid.Text))
                                MessageBox.Show("指定用户工号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show("指定用户工号未使用，可以修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    default:
                        break;
                }

                this.txtUserid.SelectAll();
                this.txtUserid.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtUserid_TextChanged(object sender, EventArgs e)
        {
            switch (this.OPMode)
            {
                case Common.OPMode.Append: break;
                case Common.OPMode.Edit:
                    this.btnCheckUserExists.Enabled = (this.txtUserid.Text != this.Userid); break;
                default: break;
            }
        }
    }
}
