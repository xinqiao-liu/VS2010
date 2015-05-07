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
    public partial class AuthorizetAppendForm : Form
    {
        public WLDataModelLayer.Authorize AuthorizeRecord { get; set; }

        public AuthorizetAppendForm()
        {
            InitializeComponent();
        }

        private void AuthorizetAppendForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.cboNode.SelectedIndex < 0)
                    {
                        MessageBox.Show("未选择网点！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.cboNode.Focus();
                        return;
                    }

                    if (!(this.cboNode.SelectedItem is WLDataModelLayer.Node))
                    {
                        MessageBox.Show("选择网点信息无效，请与程序开发人员联系！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    WLDataModelLayer.Node node = this.cboNode.SelectedItem as WLDataModelLayer.Node;

                    if (WLDataLogicLayer.Authorize.Exists(node.Code))
                    {
                        MessageBox.Show("选择网点已存在授权记录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.cboNode.Focus();
                        return;
                    }
                    this.AuthorizeRecord = new WLDataModelLayer.Authorize(node);

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AuthorizetAppendForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Node.Refresh(this.cboNode);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
