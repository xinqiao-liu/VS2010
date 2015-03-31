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
    public partial class ZCConfirmForm : Form
    {
        private WLDataModelLayer.WLB OriginalRecord { get; set; }

        public static void InitAndShowDialog()
        {
            using (ZCConfirmForm zcConfirmForm = new ZCConfirmForm())
            {
                zcConfirmForm.Text = string.Format("办理装车（当前网点：{0}-{1}）", WLDataLogicLayer.Setting.NodeCode, WLDataLogicLayer.Setting.NodeName);
                zcConfirmForm.ShowDialog();
            }
        }

        private void Init(WLDataModelLayer.WLB item)
        {
            this.txtSN.Text = item.SN;
            this.txtCDT.Text = item.CDT.ToString("yyyy-MM-dd HH:mm:ss");

            this.txtFH_Node.Text = item.FH_Code + "-" + item.FH_Name;
            this.txtJH_Node.Text = item.JH_Code + "-" + item.JH_Name;

            this.txtCZ_RQ.Text = item.CZ_RQ.ToString("yyyy-MM-dd");
            this.txtCZ_DZ.Text = item.CZ_DZ;
            ListViewItem cz_item = new ListViewItem(item.CZ_CPH);
            cz_item.SubItems.Add(item.CZ_BC);
            cz_item.SubItems.Add(item.CZ_SJ);
            cz_item.SubItems.Add(item.CZ_LC.ToString());
            this.lstCZ.Items.Clear();
            this.lstCZ.Items.Add(cz_item);

            this.txtHW_MC.Text = item.HW_MC;
            this.txtHW_LX.Text = item.HW_LX;
            this.txtHW_BJ.Text = item.HW_BJ.ToString("N2");
            this.txtBXD_SN.Text = item.BXD_SN;
            this.txtFHR_Name.Text = item.FHR_Name;
            this.txtFHR_Mobile.Text = item.FHR_Mobile;
            this.txtJHR_Name.Text = item.JHR_Name;
            this.txtJHR_Mobile.Text = item.JHR_Mobile;
            this.txtFHR_Remark.Text = item.FHR_Remark;

            this.txtHW_JS.Text = item.HW_JS.ToString();
            this.txtJFZL.Text = item.JFZL.ToString("N1");
            this.txtJFTJ.Text = item.JFTJ.ToString("N1");
            this.txtTYF.Text = item.TYF.ToString("N2");
            this.txtBXF.Text = item.BXF.ToString("N2");
            this.txtBZF.Text = item.BZF.ToString("N2");
            this.txtSK_Type.Text = item.SK_Type.ToString();

            this.chkSecurityCheck.Checked = item.Sets[0] == '1' ? true : false;
            this.chkTelService.Checked = item.Sets[1] == '1' ? true : false;
            this.chkSMSService.Checked = item.Sets[2] == '1' ? true : false;

            this.OriginalRecord = item;
            this.btnConfirm.Enabled = true;
        }

        public ZCConfirmForm()
        {
            InitializeComponent();
        }

        private void ZCConfirmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ZCConfirmForm_Shown(object sender, EventArgs e)
        {
            try 
            {
                WLDataLogicLayer.WLB.RefreshCentralZCDateList(this.cboDate);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (this.tabControl.SelectedIndex)
                {
                    case 0: this.btnRefresh.Enabled = false; break;
                    case 1: this.btnRefresh.Enabled = true; this.btnRefresh_Click(sender, e); break;
                    case 2: this.btnRefresh.Enabled = true; this.btnRefresh_Click(sender, e); break;
                    default: break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listWaiting_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.listWaiting.SelectedItems.Count > 0)
                {
                    this.tabControl.SelectedIndex = 0;
                    this.Init(WLDataModelLayer.WLB.ToTarget(this.listWaiting.SelectedItems[0].Tag));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.WLB.CentralZC(this.OriginalRecord);

                this.txtSN.Text = string.Empty;
                this.txtSN.Focus();
                this.btnConfirm.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cboDate.Enabled && this.cboDate.SelectedIndex >= 0)
                {
                    switch (this.tabControl.SelectedIndex)
                    {
                        case 1: WLDataLogicLayer.WLB.RefreshCentralZCWaitingList(this.listWaiting, Convert.ToDateTime(this.cboDate.SelectedItem)); break;
                        case 2: WLDataLogicLayer.WLB.RefreshCentralZCAlreadyList(this.listAlready, Convert.ToDateTime(this.cboDate.SelectedItem)); break;
                    }
                }
                else throw new ApplicationException("办理日期不存在，无法获取待装车/已装车列表！");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtSN_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.txtSN.Clear();
                        break;
                    case Keys.Enter:
                        if (this.txtSN.Text != string.Empty)
                        {
                            WLDataModelLayer.WLB item = WLDataLogicLayer.WLB.CentralZCRead(WLDataLogicLayer.Bill.Format(this.txtSN.Text));
                            if (item == null)
                                throw new ApplicationException(string.Format("不存在等待装车运单'{0}'！", this.txtSN.Text));
                            else
                                this.Init(item);                                
                        }
                        break;
                }
            }
            catch (Exception ex) { this.txtSN.Text = string.Empty; MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
