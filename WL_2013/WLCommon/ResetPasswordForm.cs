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
    public partial class ResetPasswordForm : Form
    {
        public String Userid { get; set; }
        public bool OccurError { get; set; }

        public static DialogResult InitAndShowDialog(string userid)
        {
            using (ResetPasswordForm resetPasswordForm = new ResetPasswordForm())
            {
                resetPasswordForm.Userid = userid;
                return resetPasswordForm.ShowDialog();
            }
        }

        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.txtNewPassword.Text != this.txtValidate.Text)
                    {
                        this.txtNewPassword.Focus();
                        this.txtNewPassword.SelectAll();
                        throw new ApplicationException("用户新口令验证失败，请重新输入！");
                    }

                    if (!WLDataLogicLayer.User.Validate(this.Userid, this.txtOldPassword.Text))
                    {
                        this.txtOldPassword.Focus();
                        this.txtOldPassword.SelectAll();
                        throw new ApplicationException("指定用户口令验证失败！");
                    }

                    if (!WLDataLogicLayer.User.ResetPassword(this.Userid, this.txtOldPassword.Text, this.txtNewPassword.Text))
                    {
                        this.txtOldPassword.Focus();
                        this.txtOldPassword.SelectAll();
                        throw new ApplicationException("指定用户口令修改失败！");
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

        private void ResetPasswordForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.Userid == String.Empty) throw new ApplicationException("用户工号未指定！");

                this.txtOldPassword.Enabled = true;
                this.txtOldPassword.Focus();
                this.txtNewPassword.Enabled = true;
                this.txtValidate.Enabled = true;
                this.btnOK.Enabled = true;
            }
            catch (Exception ex)
            {
                this.btnCancel.Enabled = true;
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOldPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.OccurError) { this.OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.txtOldPassword.Text = String.Empty;
                    break;
                case Keys.Enter:
                    this.txtNewPassword.Focus();
                    this.txtNewPassword.SelectAll();
                    break;
            }
        }

        private void txtNewPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.OccurError) { this.OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.txtNewPassword.Text = String.Empty;
                    break;
                case Keys.Space:
                    this.txtOldPassword.Focus();
                    this.txtOldPassword.SelectAll();
                    break;
                case Keys.Enter:
                    this.txtValidate.Focus();
                    this.txtValidate.SelectAll();
                    break;
            }
        }

        private void txtValidate_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.OccurError) { this.OccurError = false; return; }

            if (this.txtNewPassword.Text == this.txtValidate.Text)
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.txtValidate.Text = String.Empty;
                        break;
                    case Keys.Space:
                        this.txtNewPassword.Focus();
                        this.txtNewPassword.SelectAll();
                        break;
                    case Keys.Enter:
                        this.DialogResult = DialogResult.OK;
                        break;
                }
            }
        }
    }
}
