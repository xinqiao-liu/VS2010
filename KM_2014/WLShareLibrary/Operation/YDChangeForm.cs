using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Operation
{
    public partial class YDChangeForm : Form
    {
        private WLDataModelLayer.WLB OriginalItem { get; set; }

        #region 检查运单信息
        private void Check()
        {
            if (this.cboCZ_DZ.Text == string.Empty)
            {
                this.cboCZ_DZ.Focus(); throw new ApplicationException("班次到站不能为空！");
            }

            if (this.lstCZ.SelectedItems.Count <= 0)
            {
                this.lstCZ.Focus(); throw new ApplicationException("未选择承载班次！");
            }
        }
        #endregion

        #region 构建运单记录
        private WLDataModelLayer.WLB Build()
        {
            WLDataModelLayer.WLB item = new WLDataModelLayer.WLB();

            item.Node = OriginalItem.Node;
            item.Date = OriginalItem.Date;
            item.SN = OriginalItem.SN;
            item.UID = OriginalItem.UID;
            item.CDT = OriginalItem.CDT;

            item.SK_Type = OriginalItem.SK_Type;
            item.YD_Type = OriginalItem.YD_Type;
            item.ZT_Type = OriginalItem.ZT_Type;

            item.FH_Code = OriginalItem.FH_Code;
            item.FH_Name = OriginalItem.FH_Name;
            item.FH_CityName = OriginalItem.FH_CityName;
            item.JH_Code = (this.cboJH_List.SelectedIndex >= 0) ? (this.cboJH_List.SelectedItem as WLDataModelLayer.Node).Code : "";
            item.JH_Name = (this.cboJH_List.SelectedIndex >= 0) ? (this.cboJH_List.SelectedItem as WLDataModelLayer.Node).Name : "";

            item.CZ_RQ = OriginalItem.CZ_RQ;
            item.CZ_DZ = this.cboCZ_DZ.Text;
            item.CZ_CPH = this.lstCZ.SelectedItems[0].SubItems[0].Text.ToUpper();
            item.CZ_BC = this.lstCZ.SelectedItems[0].SubItems[1].Text;
            item.CZ_SJ = this.lstCZ.SelectedItems[0].SubItems[2].Text;
            item.CZ_LC = Convert.ToInt32(this.lstCZ.SelectedItems[0].SubItems[3].Text);
            item.CZ_YX = "00:00";

            item.HW_MC = OriginalItem.HW_MC;
            item.HW_LX = OriginalItem.HW_LX;
            item.HW_JS = OriginalItem.HW_JS;
            item.HW_BJ = OriginalItem.HW_BJ;
            item.BXD_SN = OriginalItem.BXD_SN;

            item.FHR_Name = OriginalItem.FHR_Name;
            item.FHR_Mobile = OriginalItem.FHR_Mobile;
            item.FHR_Remark = OriginalItem.FHR_Remark;
            item.JHR_Name = OriginalItem.JHR_Name;
            item.JHR_Mobile = OriginalItem.JHR_Mobile;

            item.JFZL = OriginalItem.JFZL;
            item.JFTJ = OriginalItem.JFTJ;
            item.TYF = OriginalItem.TYF;
            item.BXF = OriginalItem.BXF;
            item.BZF = OriginalItem.BZF;
            item.Total = OriginalItem.Total;
            item.Money = OriginalItem.Money;

            item.Synced =(this.chkSyncToCentral.Enabled && this.chkSyncToCentral.Checked);
            item.Sets = OriginalItem.Sets;

            return item;
        }
        #endregion

        #region 初始运单信息
        private void Init(WLDataModelLayer.WLB item)
        {
            this.OriginalItem = item;

            this.txtDT.Text = item.CDT.ToString("yyyy-MM-dd HH:mm:ss");
            this.txtSN.Text = item.SN;

            this.chkSecurityCheck.Checked = item.Sets[0] == '1' ? true : false;
            this.chkTelService.Checked = item.Sets[1] == '1' ? true : false;
            this.chkSMSService.Checked = item.Sets[2] == '1' ? true : false;
            this.chkSyncToCentral.Checked = item.Synced;
            
            this.cboFH_List.SelectedIndex = this.cboFH_List.FindStringExact(item.FH_Code + "-" + item.FH_Name);
            this.cboJH_List.SelectedIndex = this.cboJH_List.FindStringExact(item.JH_Code + "-" + item.JH_Name);
            this.cboJH_List.Enabled = !item.Synced;

            this.txtCZ_RQ.Text = item.CZ_RQ.ToString("yyyy-MM-dd");
            this.cboCZ_DZ.Text = item.CZ_DZ;
            ListViewItem cz_item = new ListViewItem(item.CZ_CPH);
            cz_item.SubItems.Add(item.CZ_BC);
            cz_item.SubItems.Add(item.CZ_SJ);
            cz_item.SubItems.Add(item.CZ_LC.ToString());
            this.lstCZ.Items.Add(cz_item);

            this.txtHW_MC.Text = item.HW_MC;
            this.txtHW_LX.Text = item.HW_LX;
            this.numHW_BJ.Value = item.HW_BJ;
            this.txtBXD_SN.Text = item.BXD_SN;
            this.txtFHR_Name.Text = item.FHR_Name;
            this.txtFHR_Mobile.Text = item.FHR_Mobile;
            this.txtJHR_Name.Text = item.JHR_Name;
            this.txtJHR_Mobile.Text = item.JHR_Mobile;
            this.txtFHR_Remark.Text = item.FHR_Remark;

            this.numHW_JS.Value = item.HW_JS;
            this.numJFZL.Value = item.JFZL;
            this.numJFTJ.Value = item.JFTJ;
            this.numTYF.Value = item.TYF;
            this.numBXF.Value = item.BXF;
            this.numBZF.Value = item.BZF;
            this.txtSK_Type.Text = item.SK_Type.ToString();
            this.txtTotal.Text = item.Total.ToString("N2");
            this.txtMoney.Text = item.Money.ToString("N2");
        }
        #endregion

        private void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Open)
            {
                this.cboCZ_DZ.Enabled = true;
                this.cboCZ_DZ.SelectAll();
                this.cboCZ_DZ.Focus();
                this.btnOk.Enabled = true;

                this.grpBase.Text = "基础信息（客运连接：打开）";
            }
            else
            {
                this.cboCZ_DZ.Enabled = false;
                this.btnOk.Enabled = false;

                this.grpBase.Text = "基础信息（客运连接：关闭）";
            }
        }

        public static WLDataModelLayer.WLB InitAndShowDialog(WLDataModelLayer.WLB item)
        {
            if (item == null) throw new ApplicationException("指定运单记录无效！");

            using (YDChangeForm ydEditForm = new YDChangeForm())
            {
                ydEditForm.Init(item);
                if (ydEditForm.ShowDialog() == DialogResult.OK)
                    return ydEditForm.OriginalItem;
                else
                    return null;
            }
        }

        public YDChangeForm()
        {
            InitializeComponent();

            this.Text = string.Format("编辑运单（当前网点：{0}-{1}）", WLDataLogicLayer.Setting.NodeCode, WLDataLogicLayer.Setting.NodeName);

            WLDataLogicLayer.Authorize.Refresh(this.cboFH_List);                            //发货网点初始化（未授权网点不包括）
            WLDataLogicLayer.Node.Refresh(this.cboJH_List, this.cboFH_List);                //接货网点初始化（不含发货网点列表存在的网点）
        }

        private void YDEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                    
                    this.Check();
                    WLDataLogicLayer.WLB.Change(this.Build(), OriginalItem);
                    this.OriginalItem = this.Build();

                    KYDataLogicLayer.Runtime.B_ConnectionClose();;
                    
                    e.Cancel = false;
                }
            }
            catch { }
        }

        private void YDEditForm_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void cboFH_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cboFH_List.SelectedIndex >= 0)
                {
                    //初始化客运连接
                    KYDataLogicLayer.Runtime.B_ConnectionInit(Common.ConnectionInfo.ToConnectionInfo((this.cboFH_List.SelectedItem as WLDataModelLayer.Authorize).Content),
                        new StateChangeEventHandler(ConnectionStateChange));
                    KYDataLogicLayer.Runtime.B_ConnectionOpen();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cboJH_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.chkSyncToCentral.Enabled = !this.OriginalItem.Synced && this.cboJH_List.SelectedIndex > 0;

                this.cboCZ_DZ.SelectAll();
                this.cboCZ_DZ.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cboCZ_DZ_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (this.cboCZ_DZ.Text == string.Empty) return;

                        //到站不为空，且首字符为英文字母，刷新承载列表
                        if (Char.IsLower(this.cboCZ_DZ.Text[0]) || Char.IsUpper(this.cboCZ_DZ.Text[0]))
                        {
                            KYDataLogicLayer.ZMPJB_Simple.Refresh(this.cboCZ_DZ, Convert.ToDateTime(this.txtCZ_RQ.Text), this.cboCZ_DZ.Text);
                        }
                        this.SelectNextControl((Control)sender, true, true, true, true);
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cboCZ_DZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.lstCZ.Enabled = false;

                string code = (this.cboCZ_DZ.SelectedIndex < 0) ? "" : (this.cboCZ_DZ.SelectedItem as KYDataModelLayer.ZMPJB_Simple).Code;
                //根据日期、到站代码刷新承载班次列表
                KYDataLogicLayer.BCK.RefreshAllByZDDM(this.lstCZ, Convert.ToDateTime(this.txtCZ_RQ.Text), code);

                this.lstCZ.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }     
        }

        private void chkSyncToCentral_EnabledChanged(object sender, EventArgs e)
        {
            this.chkSyncToCentral.ForeColor = this.chkSyncToCentral.Enabled ? Color.Red : Color.Gray;
        }
    }
}
