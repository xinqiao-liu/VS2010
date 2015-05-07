using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Checkout
{
    public partial class AccountsOpenForm : Form
    {
        public WLDataModelLayer.ZDB Accounts { get; private set; }

        public AccountsOpenForm()
        {
            InitializeComponent();
        }

        private void AccountsOpenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.list.SelectedItems.Count <= 0)
                    {
                        MessageBox.Show("请选择账单！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    if (this.list.SelectedItems[0].Tag is WLDataModelLayer.ZDB)
                        this.Accounts = this.list.SelectedItems[0].Tag as WLDataModelLayer.ZDB;
                    else
                    {                        
                        MessageBox.Show("选择账单无效，该账单信息为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Accounts = null;
                        return;
                    }                        

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AccountsOpenForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.ZDB.Refresh(this.list);                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOk.Enabled = (this.list.SelectedItems.Count > 0);
        }
    }
}
