using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Checkout
{
    public partial class CSXXForm : Form
    {
        public string Code { get; set; }
       
        public static void InitAndShowDialog(string code)
        {
            using (CSXXForm csxxForm = new CSXXForm())
            {
                if (code != string.Empty)
                {
                    csxxForm.Code = code;
                    csxxForm.Text = string.Format("隶属车辆(结帐代码：{0})", code);
                }
                csxxForm.ShowDialog();
            }
        }

        public CSXXForm()
        {
            InitializeComponent();
        }

        private void CSXXForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.Code))
                {
                    WLDataLogicLayer.CSXXB.Refresh(this.list);
                    this.btnMove.Enabled = false;
                }
                else
                    WLDataLogicLayer.CSXXB.Refresh(this.list, this.Code);
                
                this.btnAppend.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0 && this.btnEdit.Enabled) this.btnEdit_Click(sender, e);
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnDelete.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnMove.Enabled = (this.list.SelectedItems.Count > 0) && (!string.IsNullOrEmpty(this.Code));
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (CSXXEditForm csxxEditForm = new CSXXEditForm())
                {
                    csxxEditForm.Item = new WLDataModelLayer.CSXXB() { 
                        Name = "未确定", 
                        Code = this.Code,
                        Value = WLDataLogicLayer.Setting.CSDefValue 
                    };
                    csxxEditForm.OPMode = Common.OPMode.Append;
                    if (csxxEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.CSXXB.Insert(csxxEditForm.Item))
                        {
                            ListViewItem item = new ListViewItem(csxxEditForm.Item.CPH);
                            item.Tag = csxxEditForm.Item;
                            item.SubItems.Add(csxxEditForm.Item.Name);
                            item.SubItems.Add(csxxEditForm.Item.Value.ToString("N2"));
                            item.SubItems.Add(csxxEditForm.Item.Tel);
                            item.SubItems.Add(csxxEditForm.Item.Address);
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
                using (CSXXEditForm csxxEditForm = new CSXXEditForm())
                {
                    csxxEditForm.Item = this.list.SelectedItems[0].Tag as WLDataModelLayer.CSXXB;
                    csxxEditForm.OPMode = Common.OPMode.Edit;
                    if (csxxEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.CSXXB.Update(this.list.SelectedItems[0].Text, csxxEditForm.Item))
                        {
                            if (!string.IsNullOrEmpty(this.Code) && this.Code != csxxEditForm.Item.Code)
                                this.list.SelectedItems[0].Remove();
                            else
                            {
                                this.list.SelectedItems[0].Text = csxxEditForm.Item.CPH;
                                this.list.SelectedItems[0].Tag = csxxEditForm.Item;
                                this.list.SelectedItems[0].SubItems[1].Text = csxxEditForm.Item.Name;
                                this.list.SelectedItems[0].SubItems[2].Text = csxxEditForm.Item.Value.ToString("N2");
                                this.list.SelectedItems[0].SubItems[3].Text = csxxEditForm.Item.Tel;
                                this.list.SelectedItems[0].SubItems[4].Text = csxxEditForm.Item.Address;
                            }
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
                string cph = this.list.SelectedItems[0].Text;
                string msg = string.Format("是否删除车牌号 {0} ？", cph);
                if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (WLDataLogicLayer.CSXXB.Delete(cph)) this.list.SelectedItems[0].Remove();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                using (InputForm inputForm = new InputForm())
                {
                    WLDataLogicLayer.JZDMB.Refresh(inputForm.List);
                    inputForm.Text = "移动";
                    inputForm.MustContain = true;
                    inputForm.MustInput = true;
                    inputForm.InputCaption = "目标结账代码：";
                    inputForm.InputMaxLength = 8;
                    inputForm.InputValue = this.Code;
                    if (inputForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (inputForm.InputValue == this.Code) return;

                        WLDataModelLayer.CSXXB item = this.list.SelectedItems[0].Tag as WLDataModelLayer.CSXXB; item.Code = inputForm.InputValue;

                        if (WLDataLogicLayer.CSXXB.Update(item.CPH, item)) 
                            this.list.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
