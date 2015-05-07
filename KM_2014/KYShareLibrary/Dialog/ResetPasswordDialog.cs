using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KM.Common
{
    public partial class ResetPasswordDialog : Form
    {
        private String m_UserID;
        private bool m_OccurError;

        public String UserID
        {
            get { return m_UserID; }
            set
            {
                if (this.m_UserID != value)
                {
                    this.m_UserID = value;
                    this.Text = "修改口令 - [" + value + "]";
                }
            }
        }

        public ResetPasswordDialog()
        {
            InitializeComponent();
        }

        private void ResetPasswordDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.OldPasswordText.Text != Runtime.User.Password)
                    {
                        this.OldPasswordText.Focus();
                        this.OldPasswordText.SelectAll();
                        throw new ApplicationException("用户原口令验证失败，请重新输入！");
                    }

                    if (this.NewPasswordText.Text != this.ValidateText.Text)
                    {
                        this.NewPasswordText.Focus();
                        this.NewPasswordText.SelectAll();
                        throw new ApplicationException("用户新口令验证失败，请重新输入！");
                    }

                    if (!KM.Data.KYZ_User.ResetPassword(Connections.OneConnection, this.UserID, this.OldPasswordText.Text, this.NewPasswordText.Text))
                    {
                        this.OldPasswordText.Focus();
                        this.OldPasswordText.SelectAll();
                        throw new ApplicationException("修改口令失败！");
                    }

                    Runtime.User.Password = this.NewPasswordText.Text;

                    e.Cancel = false;
                }

                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == "osk") p.Kill();
                }
            }
            catch (Exception ex)
            {
                this.m_OccurError = true;
                MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 3);
            }
        }

        private void ResetPasswordDialog_Shown(object sender, EventArgs e)
        {
            try
            {
                if (UserID == String.Empty) throw new ApplicationException("用户编号未指定！");
            }
            catch (Exception ex)
            {
                MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 3);
            }
        }

        private void m_OldPasswordText_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.m_OccurError) { this.m_OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.OldPasswordText.Text = String.Empty;
                    break;
                case Keys.Enter:
                    this.NewPasswordText.Focus();
                    this.NewPasswordText.SelectAll();
                    break;
            }
        }

        private void m_NewPasswordText_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.m_OccurError) { this.m_OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.NewPasswordText.Text = String.Empty;
                    break;
                case Keys.Space:
                    this.OldPasswordText.Focus();
                    this.OldPasswordText.SelectAll();
                    break;
                case Keys.Enter:
                    this.ValidateText.Focus();
                    this.ValidateText.SelectAll();
                    break;
            }
        }

        private void m_ValidateText_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.m_OccurError) { this.m_OccurError = false; return; }

            if (this.NewPasswordText.Text == this.ValidateText.Text)
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.ValidateText.Text = String.Empty;
                        break;
                    case Keys.Space:
                        this.NewPasswordText.Focus();
                        this.NewPasswordText.SelectAll();
                        break;
                    case Keys.Enter:
                        this.btnOk.Focus();
                        break;
                }
            }
        }

        private void KeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == "osk") return;
                }

                Process.Start(new ProcessStartInfo() { FileName = "osk.exe", Verb = "open", WindowStyle = ProcessWindowStyle.Normal });
            }
            catch (Exception ex)
            {
                MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 3);
            }
        }
    }
}
