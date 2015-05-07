using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Checkout
{
    public partial class CSXXEditForm : Form
    {
        public WLDataModelLayer.CSXXB Item { get; set; }
        public Common.OPMode OPMode { get; set; }

        public CSXXEditForm()
        {
            InitializeComponent();
        }

        private void CSXXEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (!this.cboCode.Items.Contains(this.cboCode.Text))
                    {
                        MessageBox.Show("结账代码未设或无效！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.cboCode.Focus(); return;
                    }

                    if (this.txtCPH.Text == string.Empty)
                    {
                        MessageBox.Show("车牌号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtCPH.Focus(); return;
                    }

                    switch (OPMode)
                    {
                        case Common.OPMode.Append:
                            if (WLDataLogicLayer.CSXXB.Exists(this.txtCPH.Text))
                            {
                                MessageBox.Show("指定车牌号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtCPH.SelectAll();
                                this.txtCPH.Focus();
                                return;
                            }
                            break;
                        case Common.OPMode.Edit:
                            if (this.txtCPH.Text != this.Item.CPH && WLDataLogicLayer.CSXXB.Exists(this.txtCPH.Text))
                            {
                                MessageBox.Show("指定车牌号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtCPH.SelectAll();
                                this.txtCPH.Focus();
                                return;
                            }
                            break;
                        default: break;
                    }

                    if (this.txtName.Text == string.Empty)
                    {
                        MessageBox.Show("车主名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtName.Focus();
                        return;
                    }

                    Item.Code = this.cboCode.Text;
                    Item.CPH = this.txtCPH.Text.ToUpper();
                    Item.Name = this.txtName.Text;
                    Item.Value = this.numValue.Value;
                    Item.Address = this.txtAddress.Text;
                    Item.Tel = this.txtTel.Text;

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CSXXEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.btnCheckCPHExists.Enabled = false;

                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        this.Text = "添加车属信息"; this.cboCode.Enabled = (string.IsNullOrEmpty(this.Item.Code)); break;
                    case Common.OPMode.Edit:
                        this.Text = "编辑车属信息"; this.btnCheckCPHExists.Enabled = false;
                        this.btnCheckCPHExists.Enabled = false;
                        break;
                    default: break;
                }

                if (this.Item != null)
                {
                    WLDataLogicLayer.JZDMB.Refresh(this.cboCode);

                    this.cboCode.Text = this.Item.Code;
                    this.txtCPH.Text = this.Item.CPH;
                    this.txtName.Text = this.Item.Name;
                    this.numValue.Value = this.Item.Value;
                    this.txtAddress.Text = this.Item.Address;
                    this.txtTel.Text = this.Item.Tel;
                }
                else this.btnOK.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCheckCPHExists_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (this.txtCPH.Text == string.Empty)
                {
                    MessageBox.Show("车牌号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtCPH.Focus();
                    return;
                }

                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        if (WLDataLogicLayer.CSXXB.Exists(this.txtCPH.Text))
                            MessageBox.Show("指定车牌号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("指定车牌号未使用，可以添加。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case Common.OPMode.Edit:
                        if (this.txtCPH.Text != this.Item.CPH)
                        {
                            if (WLDataLogicLayer.CSXXB.Exists(this.txtCPH.Text))
                                MessageBox.Show("指定车牌号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show("指定车牌号未使用，可以修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    default: break;
                }

                this.txtCPH.SelectAll();
                this.txtCPH.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtCPH_TextChanged(object sender, EventArgs e)
        {
            switch (this.OPMode)
            {
                case Common.OPMode.Append: 
                    this.btnCheckCPHExists.Enabled = true; break;
                case Common.OPMode.Edit:
                    this.btnCheckCPHExists.Enabled = (this.txtCPH.Text != this.Item.CPH); break;
                default: break;
            }

            string cph = this.txtCPH.Text.ToUpper();

            if (cph != string.Empty && WLDataLogicLayer.Mapping.Array.ContainsKey(cph))
            {
                this.txtCPH.Text = WLDataLogicLayer.Mapping.Array[cph];
                this.txtCPH.Select(cph.Length, 0);
            }
        }
    }
}
