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
    public partial class CustomerForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (CustomerForm customerForm = new CustomerForm())
            {
                return customerForm.ShowDialog();
            }
        }

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Customer.Refresh(this.list);
                this.btnAppend.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0)
            {
                this.btnEdit_Click(sender, e);
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = (this.list.SelectedItems.Count > 0);

            this.btnEdit.Enabled = enable;
            this.btnDelete.Enabled = enable;
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (CustomerEditForm customerEditForm = new CustomerEditForm())
                {
                    customerEditForm.Item = new WLDataModelLayer.Customer();
                    customerEditForm.OPMode = Common.OPMode.Append;
                    if (customerEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.Customer.Insert(customerEditForm.Item))
                        {
                            ListViewItem item = new ListViewItem(customerEditForm.Item.Name);
                            item.Tag = customerEditForm.Item;
                            item.SubItems.Add(customerEditForm.Item.Tel);
                            item.SubItems.Add(customerEditForm.Item.Address);
                            item.SubItems.Add(customerEditForm.Item.Enable ? "启用" : "停用");

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
                    using (CustomerEditForm customerEditForm = new CustomerEditForm())
                    {
                        customerEditForm.Item = this.list.SelectedItems[0].Tag as WLDataModelLayer.Customer;
                        customerEditForm.OPMode = Common.OPMode.Edit;
                        if (customerEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.Customer.Update(
                                this.list.SelectedItems[0].Text, 
                                this.list.SelectedItems[0].SubItems[1].Text, 
                                customerEditForm.Item))
                            {
                                this.list.SelectedItems[0].Tag = customerEditForm.Item;
                                this.list.SelectedItems[0].Text = customerEditForm.Item.Name;
                                this.list.SelectedItems[0].SubItems[1].Text = customerEditForm.Item.Tel;
                                this.list.SelectedItems[0].SubItems[2].Text = customerEditForm.Item.Address;
                                this.list.SelectedItems[0].SubItems[3].Text = customerEditForm.Item.Enable ? "启用" : "停用";
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
                    string name = this.list.SelectedItems[0].Text;
                    string tel = this.list.SelectedItems[0].SubItems[1].Text;
                    string msg = string.Format("是否删除 {0}-{1} 客户信息？", name, tel);

                    if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (WLDataLogicLayer.Customer.Delete(name, tel)) this.list.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
