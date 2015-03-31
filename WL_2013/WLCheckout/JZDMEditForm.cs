using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCheckout
{
    public partial class JZDMEditForm : Form
    {
        public WLDataModelLayer.JZDMB Item { get; set; }
        public Common.OPMode OPMode { get; set; }

        public JZDMEditForm()
        {
            InitializeComponent();
        }

        private void JZDMEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;
                    if (this.txtCode.Text == string.Empty)
                    {
                        MessageBox.Show("结账代码不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtCode.Focus();
                        return;
                    }

                    switch (this.OPMode)
                    {
                        case Common.OPMode.Append:
                            if (WLDataLogicLayer.JZDMB.Exists(this.txtCode.Text))
                            {
                                MessageBox.Show("指定结账代码已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtCode.SelectAll();
                                this.txtCode.Focus();
                                return;
                            }

                            break;
                        case Common.OPMode.Edit:
                            if (this.txtCode.Text != this.Item.Code && WLDataLogicLayer.JZDMB.Exists(this.txtCode.Text))
                            {
                                MessageBox.Show("指定结账代码已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtCode.SelectAll();
                                this.txtCode.Focus();
                                return;
                            }

                            break;
                        default:
                            break;
                    }

                    if (this.txtName.Text == string.Empty)
                    {
                        MessageBox.Show("结账名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtName.Focus();
                        return;
                    }

                    this.Item.Code = this.txtCode.Text;
                    this.Item.Name = this.txtName.Text;
                    this.Item.Value = this.numValue.Value;
                    this.Item.Mode = (WLDataModelLayer.JZMode)this.cboMode.SelectedItem;
                    this.Item.Address = this.txtAddress.Text;
                    this.Item.Tel = this.txtTel.Text;

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void JZDMEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.JZDMB.JZModeList(this.cboMode);

                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        this.Text = "添加结账代码";
                        this.numValue.Value = WLDataLogicLayer.Setting.JZDefValue;
                        break;
                    case Common.OPMode.Edit:
                        this.Text = "编辑结账代码";
                        this.btnCheckJZDMExists.Enabled = false;

                        if (this.Item != null)
                        {
                            this.txtCode.Text = this.Item.Code;
                            this.txtCode.SelectAll();
                            this.txtName.Text = this.Item.Name;
                            this.numValue.Value = this.Item.Value;
                            this.cboMode.SelectedItem = this.Item.Mode;
                            this.txtAddress.Text = this.Item.Address;
                            this.txtTel.Text = this.Item.Tel;
                        }
                        else
                            this.btnOK.Enabled = false;
                        break;
                    default: break;
                }
                this.txtCode.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCheckJZDMExists_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (this.txtCode.Text == string.Empty)
                {
                    MessageBox.Show("结账代码不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtCode.Focus();
                    return;
                }

                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        if (WLDataLogicLayer.JZDMB.Exists(this.txtCode.Text))
                            MessageBox.Show("指定结账代码已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("指定结账代码未使用，可以添加。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case Common.OPMode.Edit:
                        if (this.txtCode.Text != this.Item.Code)
                        {
                            if (WLDataLogicLayer.JZDMB.Exists(this.txtCode.Text))
                                MessageBox.Show("指定结账代码已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show("指定结账代码未使用，可以修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    default: break;
                }

                this.txtCode.SelectAll();
                this.txtCode.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            switch (this.OPMode)
            {
                case Common.OPMode.Append: break;
                case Common.OPMode.Edit:
                    this.btnCheckJZDMExists.Enabled = (this.txtCode.Text != this.Item.Code);
                    break;
                default: break;
            }
        }
    }
}
