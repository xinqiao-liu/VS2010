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
    public partial class MappingForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (MappingForm mappingForm = new MappingForm())
            {
                return mappingForm.ShowDialog();
            }
        }

        public MappingForm()
        {
            InitializeComponent();
        }

        private void MappingForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Mapping.Refresh(this.list);
                this.btnAppend.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0) this.btnEdit_Click(sender, e);
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnDelete.Enabled = (this.list.SelectedItems.Count > 0);
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (MappingEditForm mappingEditForm = new MappingEditForm())
                {
                    mappingEditForm.OPMode = Common.OPMode.Append;
                    if (mappingEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.Mapping.Insert(mappingEditForm.Code, mappingEditForm.Value))
                        {
                            ListViewItem item = new ListViewItem(mappingEditForm.Code);
                            item.Tag = new WLDataModelLayer.Mapping() { Code = mappingEditForm.Code, Value = mappingEditForm.Value };
                            item.SubItems.Add(mappingEditForm.Value);

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
                    using (MappingEditForm mappingEditForm = new MappingEditForm())
                    {
                        mappingEditForm.Code = this.list.SelectedItems[0].Text;
                        mappingEditForm.Value = this.list.SelectedItems[0].SubItems[1].Text;
                        mappingEditForm.OPMode = Common.OPMode.Edit;
                        if (mappingEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.Mapping.Update(mappingEditForm.Code, mappingEditForm.Value))
                            {
                                this.list.SelectedItems[0].SubItems[1].Text = mappingEditForm.Value;
                                this.list.SelectedItems[0].Tag = new WLDataModelLayer.Mapping() { Code = mappingEditForm.Code, Value = mappingEditForm.Value };
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
                    string code = this.list.SelectedItems[0].Text;
                    string msg = string.Format("是否删除代码为 {0} 的映射代码？", code);
                    if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (WLDataLogicLayer.Mapping.Delete(code)) this.list.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
