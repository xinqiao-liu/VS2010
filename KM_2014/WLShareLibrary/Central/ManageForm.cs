using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Central
{
    public partial class ManageForm : Form
    {
        public static void InitAndShowDialog()
        {
            using (ManageForm manageForm = new ManageForm()) { manageForm.ShowDialog(); }
        }

        public void FindSN(string sn)
        {
            for (int i = 0; i < this.list.Items.Count; i++)
            {
                if (this.list.Items[i].Text == sn)
                {
                    this.list.Items[i].EnsureVisible(); 
                    this.list.Items[i].Selected = true;
                }
            }
        }

        public void RefreshList()
        {
            if (this.cboSelectDate.SelectedIndex >= 0)
            {
                WLDataLogicLayer.WLB.RefreshCentralByCZRQ(this.list, WLDataLogicLayer.Setting.NodeCode, Convert.ToDateTime(this.cboSelectDate.Text));
            }            
        }

        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ManageForm_Shown(object sender, EventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (this.list.SelectedItems.Count < 0) e.Cancel = true;
        }
        
        private void cboSelectDate_DropDown(object sender, EventArgs e)
        {
            try 
            {
                WLDataLogicLayer.WLB.RefreshCentralAllCZRQ(this.cboSelectDate);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cboSelectDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnRefresh.Enabled = (this.cboSelectDate.SelectedIndex >= 0);
                this.miRefresh.Enabled = this.btnRefresh.Enabled;

                this.btnRefresh_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void txtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 0x08);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtSN_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (this.txtSN.Text != string.Empty) this.FindSN(WLDataLogicLayer.Bill.Format(this.txtSN.Text));
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据选择运单状态类型配置按钮及菜单
            if (this.list.SelectedItems.Count > 0)
            {
                WLDataModelLayer.WLB item = this.list.SelectedItems[0].Tag as WLDataModelLayer.WLB;
                if (item != null)
                {
                    switch (item.ZT_Type)
                    {
                        case WLDataModelLayer.ZTType.接货:
                            this.btnJH.Enabled = false;
                            this.btnZC.Enabled = (WLDataLogicLayer.Setting.NodeCode == item.Node);
                            this.btnXC.Enabled = false;
                            this.btnQH.Enabled = false;
                            this.btnFD.Enabled = (WLDataLogicLayer.Setting.NodeCode == item.Node);
                            break;
                        case WLDataModelLayer.ZTType.装车:
                            this.btnJH.Enabled = (WLDataLogicLayer.Setting.NodeCode == item.Node);
                            this.btnZC.Enabled = false;
                            this.btnXC.Enabled = (WLDataLogicLayer.Setting.NodeCode == item.JH_Code);
                            this.btnQH.Enabled = false;
                            this.btnFD.Enabled = (WLDataLogicLayer.Setting.NodeCode == item.Node);
                            break;
                        case WLDataModelLayer.ZTType.卸车:
                            this.btnJH.Enabled = false;
                            this.btnZC.Enabled = false;
                            this.btnXC.Enabled = false;
                            this.btnQH.Enabled = (WLDataLogicLayer.Setting.NodeCode == item.JH_Code);
                            this.btnFD.Enabled = false;
                            break;
                        case WLDataModelLayer.ZTType.取货:
                            this.btnJH.Enabled = false;
                            this.btnZC.Enabled = false;
                            this.btnXC.Enabled = false;
                            this.btnQH.Enabled = false;
                            this.btnFD.Enabled = false;
                            break;
                        case WLDataModelLayer.ZTType.作废:
                            this.btnJH.Enabled = (WLDataLogicLayer.Setting.NodeCode == item.Node);
                            this.btnZC.Enabled = (WLDataLogicLayer.Setting.NodeCode == item.Node);
                            this.btnXC.Enabled = false;
                            this.btnQH.Enabled = false;
                            this.btnFD.Enabled = false;
                            break;
                    }
                    this.miJH.Enabled = this.btnJH.Enabled;
                    this.miZC.Enabled = this.btnZC.Enabled;
                    this.miXC.Enabled = this.btnXC.Enabled;
                    this.miQH.Enabled = this.btnQH.Enabled;
                    this.miFD.Enabled = this.btnFD.Enabled;
                }
                else throw new ApplicationException(WLDataLogicLayer.Message.E2000);
            }
            else
            { this.btnJH.Enabled = false; this.btnZC.Enabled = false; this.btnXC.Enabled = false; this.btnQH.Enabled = false; this.btnFD.Enabled = false; }
        }

        //办理前确认运单状态类型是否修改，未修改返回选择运单绑定数据
        private WLDataModelLayer.WLB CheckModify()
        {
            if (this.list.SelectedItems.Count > 0)
            {
                WLDataModelLayer.WLB item = this.list.SelectedItems[0].Tag as WLDataModelLayer.WLB;
                if (item != null)
                {
                    if (WLDataLogicLayer.WLB.CentralModified(item))
                        throw new ApplicationException(WLDataLogicLayer.Message.E2010);
                    else
                        return item;
                }
                else throw new ApplicationException(WLDataLogicLayer.Message.E2000);
            }
            else throw new ApplicationException(WLDataLogicLayer.Message.E1010);
        }

        private void btnJH_Click(object sender, EventArgs e)
        {
            try 
            {
                WLDataModelLayer.WLB item = this.CheckModify();
                WLDataLogicLayer.WLB.CentralJH(item);

                this.RefreshList();
                this.FindSN(item.SN);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnZC_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.WLB item = this.CheckModify();
                WLDataLogicLayer.WLB.CentralZC(item);

                this.RefreshList();
                this.FindSN(item.SN);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnXC_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.WLB item = this.CheckModify();
                WLDataLogicLayer.WLB.CentralXC(item);

                this.RefreshList();
                this.FindSN(item.SN);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnQH_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.WLB item = this.CheckModify();
                WLDataLogicLayer.WLB.CentralQH(item);

                this.RefreshList();
                this.FindSN(item.SN);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnFD_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.WLB item = this.CheckModify();
                WLDataLogicLayer.WLB.CentralFD(item);

                this.RefreshList();
                this.FindSN(item.SN);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.RefreshList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
