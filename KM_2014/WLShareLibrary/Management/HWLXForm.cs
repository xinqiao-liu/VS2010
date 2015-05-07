using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class HWLXForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (HWLXForm hwlxForm = new HWLXForm())
            {
                return hwlxForm.ShowDialog();
            }
        }

        public HWLXForm()
        {
            InitializeComponent();
        }

        private void HWLXForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.HWLXB.Refresh(this.list);
                this.btnAppend.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lstHWLX_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0) this.btnEdit_Click(sender, e);
        }

        private void lstHWLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnDelete.Enabled = (this.list.SelectedItems.Count > 0);
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (HWLXEditForm hwlxEditForm = new HWLXEditForm())
                {
                    hwlxEditForm.OPMode = Common.OPMode.Append;
                    if (hwlxEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.HWLXB.Insert(hwlxEditForm.NewName))
                        {
                            ListViewItem item = new ListViewItem(hwlxEditForm.NewName);

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
                    using (HWLXEditForm hwlxEditForm = new HWLXEditForm())
                    {
                        hwlxEditForm.OldName = this.list.SelectedItems[0].Text;
                        hwlxEditForm.OPMode = Common.OPMode.Edit;
                        if (hwlxEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.HWLXB.Update(hwlxEditForm.OldName, hwlxEditForm.NewName))
                            {
                                this.list.SelectedItems[0].Text = hwlxEditForm.NewName;
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
                    string msg = string.Format("是否删除名称为 {0} 的货物类型？", name);
                    if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (WLDataLogicLayer.HWLXB.Delete(name)) this.list.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
