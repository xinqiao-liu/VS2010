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
    public partial class UIDLoginDialog : Form
    {
        private String m_UserID;
        private bool m_OccurError = false;

        public String UserID
        {
            get { return m_UserID; }
            private set { m_UserID = value; }
        }

        public UIDLoginDialog()
        {
            InitializeComponent();
        }

        private void LoginDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.UserIDText.Text == String.Empty)
                    {
                        this.UserIDText.Focus();
                        throw new ApplicationException("用户编号不能为空！");
                    }

                    //检测用户编号是否存在
                    if (!KM.Data.KYZ_User.Exists(Connections.OneConnection, this.UserIDText.Text))
                    {
                        this.UserIDText.Focus();
                        this.UserIDText.SelectAll();
                        throw new ApplicationException("指定用户编号不存在！");
                    }

                    //验证用户编号及口令
                    if (!KM.Data.KYZ_User.Validate(Connections.OneConnection, this.UserIDText.Text, this.PasswordText.Text))
                    {
                        this.PasswordText.Focus();
                        this.PasswordText.SelectAll();
                        throw new ApplicationException("指定用户口令错误！");
                    }

                    this.UserID = this.UserIDText.Text;

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

        private void LoginDialog_Shown(object sender, EventArgs e)
        {
            this.UserIDText.Focus();
        }

        private void UserIDText_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.m_OccurError) { this.m_OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.UserIDText.Text = String.Empty;
                    break;
                case Keys.Enter:
                    if (this.UserIDText.Text != String.Empty)
                    {
                        this.PasswordText.Focus();
                        this.PasswordText.SelectAll();
                        break;
                    }
                    break;
            }
        }

        private void PasswordText_KeyUp(object sender, KeyEventArgs e)

        {
            if (this.m_OccurError) { this.m_OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.UserIDText.Focus();
                    this.UserIDText.SelectAll();
                    break;
                case Keys.Space:
                    this.PasswordText.Text = String.Empty;
                    break;
                case Keys.Enter:
                    this.DialogResult = DialogResult.OK;
                    break;
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
