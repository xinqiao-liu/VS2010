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
    public partial class IDEditDialog : Form
    {
        private String m_CID;

        public String CID
        {
            get { return m_CID; }
            set
            {
                m_CID = value;
                this.txtCID.Text = value;
            }
        }

        public String UID
        {
            set { this.txtUID.Text = value; }
        }

        public IDEditDialog()
        {
            InitializeComponent();
        }

        private void IDEditDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.txtCID.Text == String.Empty)
                    {
                        this.txtCID.Focus();
                        throw new ApplicationException("ID卡编号不能为空！");
                    }

                    if (this.txtCID.Text != this.CID)
                    {
                        if (KM.Data.KYZ_User.CIDExists(Connections.OneConnection, this.txtCID.Text))                            
                        {
                            this.txtCID.Focus();
                            this.txtCID.SelectAll();
                            throw new ApplicationException("ID卡编号已被使用，请更换新卡！");
                        }

                        if (KM.Data.KYZ_User.SetCID(Connections.OneConnection, this.txtUID.Text, this.txtCID.Text))
                            this.CID = this.txtCID.Text;
                        else
                            throw new ApplicationException("ID卡编号更新失败！");
                    }

                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 5);
            }
        }
    }
}
