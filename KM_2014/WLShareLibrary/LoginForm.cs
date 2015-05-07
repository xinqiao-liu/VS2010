using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon
{
    public partial class LoginForm : Form
    {
        public String Userid { get; set; }
        public String Password { get; set; }
        public bool OccurError { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.txtUserid.Text == String.Empty)
                    {
                        this.txtUserid.Focus();
                        throw new ApplicationException("用户编号不能为空！");
                    }

                    this.Userid = this.txtUserid.Text;
                    this.Password = this.txtPassword.Text;

                    //检测用户编号是否存在
                    if (!WLDataLogicLayer.User.Exists(this.Userid))
                    {
                        this.txtUserid.Focus();
                        this.txtUserid.SelectAll();
                        throw new ApplicationException("指定用户编号不存在！");
                    }

                    //验证用户编号及口令
                    if (!WLDataLogicLayer.User.Validate(this.Userid, this.Password))
                    {
                        this.txtPassword.Focus();
                        this.txtPassword.SelectAll();
                        throw new ApplicationException("指定用户口令错误！");
                    }

                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                this.OccurError = true;
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.txtUserid.Enabled = true;
                this.txtUserid.Focus();
                this.txtPassword.Enabled = true;
                this.btnOK.Enabled = true;
            }
            catch (Exception ex)
            {
                this.btnCancel.Focus();
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserID_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.OccurError) { this.OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.txtUserid.Text = String.Empty;
                    break;
                case Keys.Enter:
                    if (this.txtUserid.Text != String.Empty)
                    {
                        this.txtPassword.Focus();
                        this.txtPassword.SelectAll();
                        break;
                    }
                    break;
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.OccurError) { this.OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.txtUserid.Focus();
                    this.txtUserid.SelectAll();
                    break;
                case Keys.Space:
                    this.txtPassword.Text = String.Empty;
                    break;
                case Keys.Enter:
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }
    }
}
