using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class BZXXEditForm : Form
    {
        public string OldName { get; set; }
        public string NewName { get; set; }
        public Common.OPMode OPMode { get; set; }

        public BZXXEditForm()
        {
            InitializeComponent();
        }

        private void HWLXEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.txtName.Text == string.Empty)
                    {
                        MessageBox.Show("备注信息不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtName.Focus();
                        return;
                    }

                    switch (this.OPMode)
                    {
                        case Common.OPMode.Append:
                            if (WLDataLogicLayer.BZXXB.Exists(this.txtName.Text))
                            {
                                MessageBox.Show("指定备注信息已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtName.SelectAll();
                                this.txtName.Focus();
                                return;
                            }

                            break;
                        case Common.OPMode.Edit:
                            if (this.txtName.Text != this.OldName && WLDataLogicLayer.BZXXB.Exists(this.txtName.Text))
                            {
                                MessageBox.Show("指定备注信息已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtName.SelectAll();
                                this.txtName.Focus();
                                return;
                            }

                            break;
                        default:
                            break;
                    }

                    this.NewName = this.txtName.Text;

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void HWLXEditForm_Shown(object sender, EventArgs e)
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

                        if (this.OldName != null)
                        {
                            this.txtName.Text = this.OldName;
                            this.txtName.SelectAll();
                        }
                        else
                        {
                            this.txtName.Enabled = false;
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
