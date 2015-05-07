using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.Common
{
    public partial class CIDLoginDialog : Form
    {
        private String m_UserID;
        private bool m_OccurError = false;

        public String UserID
        {
            get { return m_UserID; }
            private set { m_UserID = value; }
        }

        public CIDLoginDialog()
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
                        throw new ApplicationException("ID卡号不能为空！");
                    }

                    if (!KM.Data.KYZ_User.CIDExists(Connections.OneConnection, this.UserIDText.Text))
                    {
                        this.UserIDText.Focus();
                        this.UserIDText.SelectAll();
                        throw new ApplicationException("ID卡卡号不存在！");
                    }

                    this.UserID = KM.Data.KYZ_User.CIDToUID(Connections.OneConnection, this.UserIDText.Text);

                    e.Cancel = false;
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
                        this.DialogResult = DialogResult.OK;
                    }
                    break;
            }
        }
    }
}
