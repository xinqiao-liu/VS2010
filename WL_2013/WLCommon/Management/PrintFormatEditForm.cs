using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class PrintFormatEditForm : Form
    {
        public WLDataModelLayer.PrintFormat Item { get; set; }
        public Common.OPMode OPMode { get; set; }

        private void InitFontNameList()
        {
            this.cboFontName.Items.Add("宋体");
            this.cboFontName.Items.Add("黑体");
            this.cboFontName.Items.Add("楷体");
        }

        public PrintFormatEditForm()
        {
            InitializeComponent();
        }

        private void PrintFormatEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    this.Item.Name = this.txtName.Text;
                    this.Item.X = Convert.ToInt32(this.numX.Value);
                    this.Item.Y = Convert.ToInt32(this.numY.Value);
                    this.Item.FontName = this.cboFontName.Text;
                    this.Item.FontSize = Convert.ToInt32(this.numFontSize.Value);
                    this.Item.FontMode = this.cboFontMode.Text;
                    this.Item.Enable = this.chkEnable.Checked;

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PrintFormatEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.InitFontNameList();

                if (this.Item != null)
                {
                    this.txtCode.Text = this.Item.Code;
                    this.txtName.Text = this.Item.Name;
                    this.numX.Value = this.Item.X;
                    this.numY.Value = this.Item.Y;
                    this.cboFontName.SelectedIndex = this.cboFontName.FindStringExact(this.Item.FontName);
                    this.numFontSize.Value = this.Item.FontSize;
                    this.cboFontMode.SelectedIndex = this.cboFontMode.FindStringExact(this.Item.FontMode);
                    this.chkEnable.Checked = this.Item.Enable;
                }
                else
                    this.btnOK.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
