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
    public partial class UserForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (UserForm userForm = new UserForm())
            {
                return userForm.ShowDialog();
            }
        }

        public UserForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.User.Refresh(this.list);
                this.btnAppend.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = (this.list.SelectedItems.Count > 0);

            this.btnEdit.Enabled = enable;
            this.btnDelete.Enabled = enable;
            this.btnClearPassword.Enabled = enable;
        }

        private void lstUser_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0)
            {
                this.btnEdit_Click(sender, e);
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (UserEditForm userEditForm = new UserEditForm())
                {
                    userEditForm.Item = new WLDataModelLayer.User();
                    userEditForm.OPMode = Common.OPMode.Append;
                    if (userEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.User.Insert(userEditForm.Item))
                        {
                            ListViewItem item = new ListViewItem(userEditForm.Item.Userid);
                            item.Tag = userEditForm.Item;
                            item.SubItems.Add(userEditForm.Item.Username);
                            item.SubItems.Add(userEditForm.Item.NodeCode);
                            item.SubItems.Add(userEditForm.Item.NodeName);
                            item.SubItems.Add(userEditForm.Item.Enable ? "启用" : "停用");

                            this.list.Items.Add(item);
                        }
                    }
                }

                this.list.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    using (UserEditForm userEditForm = new UserEditForm())
                    {
                        userEditForm.Item = this.list.SelectedItems[0].Tag as WLDataModelLayer.User;
                        userEditForm.Userid = this.list.SelectedItems[0].Text;
                        userEditForm.OPMode = Common.OPMode.Edit;
                        if (userEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.User.Update(userEditForm.Userid, userEditForm.Item))
                            {
                                this.list.SelectedItems[0].Tag = userEditForm.Item;
                                this.list.SelectedItems[0].Text = userEditForm.Item.Userid;
                                this.list.SelectedItems[0].SubItems[1].Text = userEditForm.Item.Username;
                                this.list.SelectedItems[0].SubItems[2].Text = userEditForm.Item.NodeCode;
                                this.list.SelectedItems[0].SubItems[3].Text = userEditForm.Item.NodeName;
                                this.list.SelectedItems[0].SubItems[4].Text = userEditForm.Item.Enable ? "启用" : "停用";
                            }
                        }
                    }

                    this.list.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    string userid = this.list.SelectedItems[0].Text;
                    string msg = string.Format("是否删除工号 {0} 的用户信息？", userid);
                    if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (WLDataLogicLayer.User.Delete(userid)) this.list.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    string userid = this.list.SelectedItems[0].Text;
                    string msg = string.Format("是否清除工号 {0} 的用户密码？", userid);
                    if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        WLDataLogicLayer.User.ClearPassword(userid);
                    }
                    this.list.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
