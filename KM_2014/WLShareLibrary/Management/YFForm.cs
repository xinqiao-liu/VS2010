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
    public partial class YFForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (YFForm yfForm = new YFForm())
            {
                return yfForm.ShowDialog();
            }
        }

        public YFForm()
        {
            InitializeComponent();
        }

        private void YFForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.YFB.Refresh(this.list);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = (this.list.SelectedItems.Count > 0);
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0)
            {
                this.btnEdit_Click(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    using (YFEditForm yfEditForm = new YFEditForm())
                    {
                        yfEditForm.Item = this.list.SelectedItems[0].Tag as WLDataModelLayer.YFB;
                        yfEditForm.YFName = this.list.SelectedItems[0].Text;
                        yfEditForm.Text = "编辑";
                        if (yfEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.YFB.Update(yfEditForm.YFName, yfEditForm.Item))
                            {
                                this.list.SelectedItems[0].Tag = yfEditForm.Item;
                                this.list.SelectedItems[0].Text = yfEditForm.Item.Name;
                                this.list.SelectedItems[0].SubItems[1].Text = yfEditForm.Item.SM.ToString();
                                this.list.SelectedItems[0].SubItems[2].Text = yfEditForm.Item.EM.ToString();
                                this.list.SelectedItems[0].SubItems[3].Text = yfEditForm.Item.BF.ToString("N2");
                                this.list.SelectedItems[0].SubItems[4].Text = yfEditForm.Item.BW.ToString("N2");
                                this.list.SelectedItems[0].SubItems[5].Text = yfEditForm.Item.Weight.ToString();
                                this.list.SelectedItems[0].SubItems[6].Text = yfEditForm.Item.Excess.ToString("N2");
                                this.list.SelectedItems[0].SubItems[7].Text = yfEditForm.Item.Factor.ToString("N2");
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
