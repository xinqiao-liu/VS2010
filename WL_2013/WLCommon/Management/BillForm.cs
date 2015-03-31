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
    public partial class BillForm : Form
    {
        public string Userid { get; set; }

        public static DialogResult InitAndShowDialog()
        {
            using (BillForm billForm = new BillForm())
            {
                if (WLDataLogicLayer.User.LoginUser.MP)
                    billForm.Userid = null;
                else
                    billForm.Userid = WLDataLogicLayer.User.LoginUser.Userid;

                return billForm.ShowDialog();
            }
        }

        public BillForm()
        {
            InitializeComponent();
        }

        private void BillsForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Bill.Refresh(this.list, this.Userid);

                this.btnAppend.Enabled = true;
                this.btnClearHistory.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void billsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = (this.list.SelectedItems.Count > 0);

            this.btnEdit.Enabled = enable;
            this.btnDelete.Enabled = enable;
        }

        private void billsList_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0)
            {
                this.btnEdit_Click(sender, e);
            }
        }

        private void btnAppent_Click(object sender, EventArgs e)
        {
            try
            {
                using (BillEditForm billEditForm = new BillEditForm())
                {
                    billEditForm.Userid = this.Userid;
                    billEditForm.Item = new WLDataModelLayer.Bill();
                    billEditForm.OPMode = Common.OPMode.Append;
                    if (billEditForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.Bill.Insert(billEditForm.Item))
                        {
                            ListViewItem item = new ListViewItem(billEditForm.Item.Userid);
                            item.Tag = billEditForm.Item;
                            item.SubItems.Add(billEditForm.Item.P_Start.ToString());
                            item.SubItems.Add(billEditForm.Item.P_Count.ToString());
                            item.SubItems.Add(billEditForm.Item.P_Index.ToString());
                            item.SubItems.Add(billEditForm.Item.P_State.ToString());
                            item.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                            
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
                    using (BillEditForm billEditForm = new BillEditForm())
                    {
                        billEditForm.Item = this.list.SelectedItems[0].Tag as WLDataModelLayer.Bill;
                        billEditForm.OPMode = Common.OPMode.Edit;
                        if (billEditForm.ShowDialog() == DialogResult.OK)
                        {
                            if (WLDataLogicLayer.Bill.Update(billEditForm.Item))
                            {
                                this.list.SelectedItems[0].Tag = billEditForm.Item;
                                this.list.SelectedItems[0].SubItems[3].Text = billEditForm.Item.P_Index.ToString();
                                this.list.SelectedItems[0].SubItems[4].Text = billEditForm.Item.P_State.ToString();
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
                    WLDataModelLayer.Bill item = this.list.SelectedItems[0].Tag as WLDataModelLayer.Bill;
                    if (item != null)
                    {
                        string msg = string.Format("是否删除工号 {0} 起始票号 {1} 的票据？", item.Userid, item.P_Start);
                        if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (WLDataLogicLayer.Bill.Delete(item.Userid, item.P_Start)) this.list.SelectedItems[0].Remove();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string msg;
                if(this.Userid == null)
                    msg = "是否清除全部历史票据？";
                else
                    msg = string.Format("是否清除工号 {0} 的历史票据？", this.Userid);
                
                if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    WLDataLogicLayer.Bill.ClearHistory(this.Userid);

                    foreach (ListViewItem item in this.list.Items)
                    {
                        if (item.SubItems[4].Text == WLDataModelLayer.BillState.用完.ToString()) item.Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
