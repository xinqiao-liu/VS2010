using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Checkout
{
    public partial class JZDMForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (JZDMForm jzdmForm = new JZDMForm())
            {
                return jzdmForm.ShowDialog();
            }
        }

        public JZDMForm()
        {
            InitializeComponent();
        }

        private void JZDMForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.JZDMB.Refresh(this.list);
                this.btnAppend.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0 && this.btnCSXX.Enabled) this.btnCSXX_Click(sender, e);
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnDelete.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnMerge.Enabled = (this.list.SelectedItems.Count > 1);
            this.btnCSXX.Enabled = (this.list.SelectedItems.Count > 0);
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (JZDMEditForm jzdmEditForm = new JZDMEditForm())
                {
                    jzdmEditForm.Item = new WLDataModelLayer.JZDMB();
                    jzdmEditForm.OPMode = Common.OPMode.Append;
                    if (jzdmEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.JZDMB.Insert(jzdmEditForm.Item))
                        {
                            ListViewItem item = new ListViewItem(jzdmEditForm.Item.Code);
                            item.Tag = jzdmEditForm.Item;
                            item.SubItems.Add(jzdmEditForm.Item.Name);
                            item.SubItems.Add(jzdmEditForm.Item.Value.ToString("N2"));
                            item.SubItems.Add(jzdmEditForm.Item.Mode.ToString());
                            item.SubItems.Add(jzdmEditForm.Item.Tel);
                            item.SubItems.Add(jzdmEditForm.Item.Address);
                            this.list.Items.Add(item).Selected = true;
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
                using (JZDMEditForm jzdmEditForm = new JZDMEditForm())
                {
                    jzdmEditForm.Item = this.list.SelectedItems[0].Tag as WLDataModelLayer.JZDMB;
                    jzdmEditForm.OPMode = Common.OPMode.Edit;
                    if (jzdmEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.JZDMB.Update(this.list.SelectedItems[0].Text, jzdmEditForm.Item))
                        {
                            this.list.SelectedItems[0].Text = jzdmEditForm.Item.Code;
                            this.list.SelectedItems[0].Tag = jzdmEditForm.Item;
                            this.list.SelectedItems[0].SubItems[1].Text = jzdmEditForm.Item.Name;
                            this.list.SelectedItems[0].SubItems[2].Text = jzdmEditForm.Item.Value.ToString("N2");
                            this.list.SelectedItems[0].SubItems[3].Text = jzdmEditForm.Item.Mode.ToString();
                            this.list.SelectedItems[0].SubItems[4].Text = jzdmEditForm.Item.Tel;
                            this.list.SelectedItems[0].SubItems[5].Text = jzdmEditForm.Item.Address;
                        }
                    }
                }
                this.list.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string code = this.list.SelectedItems[0].Text;
                string msg = string.Format("是否删除结账代码 '{0}' ？", code);
                if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int num = 0;
                    if ((num = WLDataLogicLayer.CSXXB.GetCount(code)) > 0)
                        throw new ApplicationException(string.Format("代码 '{0}' 存在 {1} 条隶属车辆记录，不能删除！", code, num));
                    else
                    {
                        if (WLDataLogicLayer.JZDMB.Delete(code)) this.list.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                using (InputForm inputForm = new InputForm())
                {
                    for (int i = 0; i < this.list.SelectedItems.Count; i++) inputForm.Add(this.list.SelectedItems[i].Text);

                    inputForm.Text = "合并";
                    inputForm.MustContain = true;
                    inputForm.MustInput = true;
                    inputForm.InputCaption = "合并到结账代码：";
                    inputForm.InputMaxLength = 4;
                    inputForm.InputValue = this.list.SelectedItems[0].Text;
                    inputForm.CheckVisible = true;
                    inputForm.CheckCaption = "合并成功后删除被合并结账代码";
                    inputForm.CheckValue = true;
                    //inputForm.ConfirmState = true;
                    //inputForm.ConfirmCaption = "确认";
                    //inputForm.ConfirmString = "合并结账代码到'{0}'？";
                    if (inputForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        for (int i = 0; i < this.list.SelectedItems.Count; i++)
                        {
                            if (this.list.SelectedItems[i].Text == inputForm.InputValue) continue;

                            foreach (WLDataModelLayer.CSXXB item in WLDataLogicLayer.CSXXB.Reads(this.list.SelectedItems[i].Text))
                            {
                                item.Code = inputForm.InputValue;
                                WLDataLogicLayer.CSXXB.Update(item.CPH, item);
                            }

                            if (inputForm.CheckValue && WLDataLogicLayer.JZDMB.Delete(this.list.SelectedItems[i].Text)) this.list.SelectedItems[i].Remove();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                {
                    reportForm.InitReport("JZCPHRecord", "结账车辆表");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCSXX_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Checkout.CSXXForm.InitAndShowDialog(this.list.SelectedItems[0].Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
