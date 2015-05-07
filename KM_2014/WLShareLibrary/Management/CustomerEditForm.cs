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
    public partial class CustomerEditForm : Form
    {
        public WLDataModelLayer.Customer Item { get; set; }
        public Common.OPMode OPMode { get; set; }

        private bool ValidateInput()
        {
            if (this.txtName.Text == string.Empty)
            {
                MessageBox.Show("客户名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtName.Focus();
                return false;
            }

            if (this.txtTel.Text == string.Empty)
            {
                MessageBox.Show("客户电话不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTel.Focus();
                return false;
            }

            return true;
        }

        public CustomerEditForm()
        {
            InitializeComponent();
        }

        private void CustomerEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (!this.ValidateInput()) return;

                    switch (this.OPMode)
                    {
                        case Common.OPMode.Append:
                            if (WLDataLogicLayer.Customer.Exists(this.txtTel.Text))
                            {
                                MessageBox.Show("指定客户已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtName.SelectAll();
                                this.txtName.Focus();
                                return;
                            }                            
                            break;
                        case Common.OPMode.Edit:
                            if ((this.txtName.Text != this.Item.Name || this.txtTel.Text != this.Item.Tel)
                                && WLDataLogicLayer.Customer.Exists(this.txtTel.Text))
                            {
                                MessageBox.Show("指定客户已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtName.SelectAll();
                                this.txtName.Focus();
                                return;
                            }           
                            break;
                        default:
                            break;
                    }

                    Item.Name = this.txtName.Text;
                    Item.Tel = this.txtTel.Text;
                    Item.Address = this.txtAddress.Text;
                    Item.Enable = this.chkEnable.Checked;
      
                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CustomerEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        this.Text = "添加客户";
                        break;
                    case Common.OPMode.Edit:
                        this.Text = "编辑客户";
                        this.btnCheckCustomerExists.Enabled = false;

                        if (this.Item != null)
                        {
                            this.txtName.Text = this.Item.Name;
                            this.txtTel.Text = this.Item.Tel;
                            this.txtAddress.Text = this.Item.Address;
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

        private void btnCheckCustomerExists_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!this.ValidateInput()) return;

                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        if (WLDataLogicLayer.Customer.Exists(this.txtTel.Text))
                            MessageBox.Show("指定客户已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("指定客户不存在，可以添加。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case Common.OPMode.Edit:
                        if (this.txtName.Text != this.Item.Name || this.txtTel.Text != this.Item.Tel)
                        {
                            if (WLDataLogicLayer.Customer.Exists(this.txtTel.Text))
                                MessageBox.Show("指定客户已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show("指定客户不存在，可以修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    default:
                        break;
                }

                this.txtName.SelectAll();
                this.txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            switch (this.OPMode)
            {
                case Common.OPMode.Append:
                    break;
                case Common.OPMode.Edit:
                    this.btnCheckCustomerExists.Enabled = (this.txtName.Text != this.Item.Name || this.txtTel.Text != this.Item.Tel);
                    break;
                default:
                    break;
            }
        }
    }
}
