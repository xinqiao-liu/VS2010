using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class BillEditForm : Form
    {
        public string Userid { get; set; }
        public WLDataModelLayer.Bill Item { get; set; }
        public Common.OPMode OPMode { get; set; }

        public BillEditForm()
        {
            InitializeComponent();
        }

        private void BillEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    switch (this.OPMode)
                    {
                        case Common.OPMode.Append:
                            string userid;

                            if (string.IsNullOrEmpty(this.Userid))
                            {
                                WLDataModelLayer.User i = this.cboUser.SelectedItem as WLDataModelLayer.User;
                                if (i == null)
                                {
                                    MessageBox.Show("未选择有效用户工号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                                }
                                userid = i.Userid;
                            }
                            else
                                userid = this.Userid;

                            if (WLDataLogicLayer.Bill.Exists(Convert.ToInt32(this.numP_Start.Value)))
                            {
                                MessageBox.Show("指定票据已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                            }

                            this.Item.Userid = userid;
                            this.Item.P_Start = Convert.ToInt32(this.numP_Start.Value);
                            this.Item.P_Count = Convert.ToInt32(this.numP_Count.Value);

                            break;
                        case Common.OPMode.Edit: break;
                        default: break;
                    }

                    this.Item.P_Index = Convert.ToInt32(this.numP_Index.Value);
                    this.Item.P_State = (WLDataModelLayer.BillState) Enum.Parse(typeof(WLDataModelLayer.BillState), this.cboP_State.Text);

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BillEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                switch (this.OPMode)
                {
                    case Common.OPMode.Append:
                        this.Text = "添加票据";
                        if (this.Userid == null)
                        {
                            this.cboUser.Visible = true;
                            WLDataLogicLayer.User.Refresh(this.cboUser);
                        }
                        else
                        {
                            this.txtUserid.Visible = true;
                            this.txtUserid.Text = this.Userid;
                        }
                        this.cboP_State.SelectedIndex = 0;
                        break;
                    case Common.OPMode.Edit:
                        this.Text = "编辑票据";
                        this.numP_Start.Enabled = false;
                        this.numP_Count.Enabled = false;
                        this.btnCheckBillExists.Enabled = false;

                        if (this.Item != null)
                        {
                            this.txtUserid.Visible = true;
                            this.txtUserid.Text = this.Item.Userid;

                            this.numP_Start.Value = this.Item.P_Start;
                            this.numP_Count.Value = this.Item.P_Count;
                            this.numP_Index.Value = this.Item.P_Index;
                            this.cboP_State.SelectedIndex = this.cboP_State.FindStringExact(this.Item.P_State.ToString());
                        }
                        else
                        {
                            this.numP_Index.Enabled = false;
                            this.cboP_State.Enabled = false;
                            this.btnOK.Enabled = false;
                        }

                        break;
                    default: break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }       
        }

        private void btnCheckBillExists_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string userid;
                if (this.Userid == null)
                {
                    WLDataModelLayer.User i = this.cboUser.SelectedItem as WLDataModelLayer.User;
                    if (i == null)
                    {
                        MessageBox.Show("未选择有效用户工号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }
                    userid = i.Userid;
                }
                else userid = this.Userid;

                if (WLDataLogicLayer.Bill.Exists(Convert.ToInt32(this.numP_Start.Value)))
                    MessageBox.Show("指定票据已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("指定票据未使用，可以添加。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
