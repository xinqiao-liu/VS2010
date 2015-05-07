using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class PrintFormatForm : Form
    {
        public int PageWidth { private get; set; }
        public int PageHeight { private get; set; }
        public int PageOffsetX { private get; set; }
        public int PageOffsetY { private get; set; }

        public PrintFormatForm()
        {
            InitializeComponent();
        }

        private void PrintSettingForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.PrintFormat.Refresh(this.list);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lstPrintFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = (this.list.SelectedItems.Count > 0);
        }

        private void lstPrintFormat_DoubleClick(object sender, EventArgs e)
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
                    using (PrintFormatEditForm printFormatEditForm = new PrintFormatEditForm())
                    {
                        printFormatEditForm.Item = this.list.SelectedItems[0].Tag as WLDataModelLayer.PrintFormat;
                        printFormatEditForm.OPMode = Common.OPMode.Edit;
                        if (printFormatEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.PrintFormat.Update(printFormatEditForm.Item))
                            {
                                this.list.SelectedItems[0].Tag = printFormatEditForm.Item;
                                this.list.SelectedItems[0].SubItems[1].Text = printFormatEditForm.Item.Name;
                                this.list.SelectedItems[0].SubItems[2].Text = printFormatEditForm.Item.X.ToString();
                                this.list.SelectedItems[0].SubItems[3].Text = printFormatEditForm.Item.Y.ToString();
                                this.list.SelectedItems[0].SubItems[4].Text = printFormatEditForm.Item.FontName;
                                this.list.SelectedItems[0].SubItems[5].Text = printFormatEditForm.Item.FontSize.ToString();
                                this.list.SelectedItems[0].SubItems[6].Text = printFormatEditForm.Item.FontMode;
                                this.list.SelectedItems[0].SubItems[7].Text = printFormatEditForm.Item.Enable ? "启用" : "停用";
                            }
                        }
                    }
                    this.list.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.PrintFormat.Init();

                PrintBill.Init(this.PageWidth, this.PageHeight);
                PrintBill.Preview(WLDataModelLayer.WLB.CreateTestItem(), this.PageOffsetX, this.PageOffsetY);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
