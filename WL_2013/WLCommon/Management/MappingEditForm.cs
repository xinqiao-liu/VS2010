using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class MappingEditForm : Form
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public Common.OPMode OPMode { get; set; }

        public MappingEditForm()
        {
            InitializeComponent();
        }

        private void MappingEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    switch (this.OPMode)
                    {
                        case Common.OPMode.Append:
                            if (this.txtCode.Text == string.Empty)
                            {
                                MessageBox.Show("映射代码不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtCode.Focus();
                                return;
                            }

                            if (WLDataLogicLayer.Mapping.Exists(this.txtCode.Text))
                            {
                                MessageBox.Show("指定映射代码已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtCode.SelectAll();
                                this.txtCode.Focus();
                                return;
                            }

                            this.Code = this.txtCode.Text.ToUpper();
                            break;
                        case Common.OPMode.Edit:
                            break;
                        default:
                            break;
                    }

                    if (this.txtValue.Text == string.Empty)
                    {
                        MessageBox.Show("映射值不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtValue.Focus();
                        return;
                    }

                    this.Value = this.txtValue.Text.ToUpper();

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MappingEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        this.Text = "添加";
                        break;
                    case Common.OPMode.Edit:
                        this.Text = "编辑";
                        if (this.Code != null && this.Value != null)
                        {
                            this.txtCode.Text = this.Code;
                            this.txtCode.ReadOnly = true;
                            this.txtValue.Text = this.Value;
                            this.txtValue.SelectAll();
                            this.txtValue.Focus();
                        }
                        else
                        {
                            this.txtCode.Enabled = false;
                            this.txtValue.Enabled = false;
                            this.btnOK.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
