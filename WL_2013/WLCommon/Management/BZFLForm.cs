using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class BZFLForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (BZFLForm bzflForm = new BZFLForm())
            {
                return bzflForm.ShowDialog();
            }
        }

        public BZFLForm()
        {
            InitializeComponent();
        }

        private void BZFLForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.BZFLB.Refresh(this.list);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lstFL_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0) this.btnEdit_Click(sender, e);
        }

        private void lstFL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = (this.list.SelectedItems.Count > 0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    if (this.list.SelectedItems[0].Text == "自理包装")
                    {
                        MessageBox.Show("自理包装项不能编辑！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    using (BZFLEditForm bzflEditForm = new BZFLEditForm())
                    {
                        bzflEditForm.EditName = this.list.SelectedItems[0].Text;
                        bzflEditForm.Value = Convert.ToDecimal(this.list.SelectedItems[0].SubItems[1].Text);
                        if (bzflEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.BZFLB.Update(new WLDataModelLayer.BZFLB() { Name = bzflEditForm.EditName, Value = bzflEditForm.Value }))
                            {
                                this.list.SelectedItems[0].SubItems[1].Text = bzflEditForm.Value.ToString("N2");
                            }
                        }
                    }

                    this.list.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
