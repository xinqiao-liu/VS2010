using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class BZXXForm : Form
    {       
        public static DialogResult InitAndShowDialog()
        {
            using (BZXXForm bzxxForm = new BZXXForm())
            {
                return bzxxForm.ShowDialog();
            }
        }

        public BZXXForm()
        {
            InitializeComponent();
        }

        private void BZXXForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.BZXXB.Refresh(this.list);
                this.btnAppend.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lstBZXX_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0) this.btnEdit_Click(sender, e);
        }

        private void lstBZXX_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnDelete.Enabled = (this.list.SelectedItems.Count > 0);
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (BZXXEditForm bzxxEditForm = new BZXXEditForm())
                {
                    bzxxEditForm.OPMode = Common.OPMode.Append;
                    if (bzxxEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.BZXXB.Insert(bzxxEditForm.NewName))
                        {
                            ListViewItem item = new ListViewItem(bzxxEditForm.NewName);

                            this.list.Items.Add(item);
                        }
                    }
                }
                this.list.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    using (BZXXEditForm bzxxEditForm = new BZXXEditForm())
                    {
                        bzxxEditForm.OldName = this.list.SelectedItems[0].Text;
                        bzxxEditForm.OPMode = Common.OPMode.Edit;
                        if (bzxxEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.BZXXB.Update(bzxxEditForm.OldName, bzxxEditForm.NewName))
                            {
                                this.list.SelectedItems[0].Text = bzxxEditForm.NewName;
                            }
                        }
                    }

                    this.list.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    string name = this.list.SelectedItems[0].Text;
                    string msg = string.Format("是否名称 {0} 的备注信息？", name);
                    if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (WLDataLogicLayer.BZXXB.Delete(name)) this.list.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
