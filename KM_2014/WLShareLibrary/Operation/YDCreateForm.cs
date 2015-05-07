using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Operation
{
    public partial class YDCreateForm : Form
    {
        private WLDataModelLayer.Bill Bill = null;

        private bool PingEnabled { set; get; }
        private int PingTimeout { set; get; }
        private int PageOffsetX { set; get; }
        private int PageOffsetY { set; get; }

        //初始化用户票据
        private void RefreshSN()
        {            
            try
            {
                this.txtSN.Text = this.GetCurrentSN(WLDataLogicLayer.Setting.BillZeroize, WLDataLogicLayer.Setting.BillBits);
            }
            catch { this.txtSN.Text = string.Empty; }
        }

        private String GetCurrentSN(bool zeroize, int bits)
        {
            if (this.Bill == null)
                this.Bill = WLDataLogicLayer.Bill.GetUserBill(WLDataLogicLayer.User.LoginUser.Userid);
            else
            {
                //查看当前使用票据是否用完，如用完则尝试关闭
                if (this.Bill.IsOver())
                {
                    WLDataLogicLayer.Bill.Close(this.Bill);
                    this.Bill = null;

                    return GetCurrentSN(zeroize, bits);
                }
            }
            return this.Bill.Current(zeroize, bits);
        }

        #region 检查运单信息
        private void Check()
        {
            if(string.IsNullOrEmpty(this.txtSN.Text))
            {
                throw new ApplicationException("不存在可用单据号！");
            }

            if (WLDataLogicLayer.Setting.SecurityCheck && !this.chkSecurityCheck.Checked)
            {
                this.chkSecurityCheck.Focus(); throw new ApplicationException("办单之前必须开箱安全检查！");
            }

            if (this.cboFH_List.SelectedIndex < 0)
            {
                this.cboFH_List.Focus(); throw new ApplicationException("发货网点未选择！");
            }

            if (this.cboCZ_RQ.SelectedIndex < 0)
            {
                this.cboCZ_RQ.Focus(); throw new ApplicationException("班次日期不能为空！");
            }

            if (WLDataLogicLayer.EndOfDay.Exists(Convert.ToDateTime(this.cboCZ_RQ.Text)))
            {
                this.cboCZ_RQ.Focus(); throw new ApplicationException("班次日期已日结，不能继续办单！");
            }

            if (this.cboCZ_DZ.Text == string.Empty)
            {
                this.cboCZ_DZ.Focus(); throw new ApplicationException("班次到站不能为空！");
            }

            if (this.lstCZ.SelectedItems.Count <= 0)
            {
                this.lstCZ.Focus(); throw new ApplicationException("未选择承载班次！");
            }

            if (this.txtHW_MC.Text == string.Empty)
            {
                this.txtHW_MC.Focus(); throw new ApplicationException("货物名称不能为空！");
            }

            if (this.txtFHR_Name.Text == string.Empty)
            {
                this.txtFHR_Name.Focus(); throw new ApplicationException("发货人姓名不能为空！");
            }

            if (this.txtFHR_Mobile.Text == string.Empty)
            {
                this.txtFHR_Mobile.Focus(); throw new ApplicationException("发货人电话不能为空！");
            }

            if (this.txtJHR_Name.Text == string.Empty)
            {
                this.txtJHR_Name.Focus(); throw new ApplicationException("接货人姓名不能为空！");
            }

            if (this.txtJHR_Mobile.Text == string.Empty)
            {
                this.txtJHR_Mobile.Focus(); throw new ApplicationException("接货人电话不能为空！");
            }

            if (this.numTYF.Value <= 0)
            {
                this.numTYF.Focus(); throw new ApplicationException("托运费不能为零！");
            }

            if (this.cboSK_Type.Text == "现金" && this.numMoney.Value < Convert.ToDecimal(this.txtTotal.Text))
            {
                this.numMoney.Focus(); throw new ApplicationException("实收金额不能小于应收金额！");
            }
        }
        #endregion

        #region 构建运单记录
        private WLDataModelLayer.WLB Build()
        {
            WLDataModelLayer.WLB item = new WLDataModelLayer.WLB();

            item.Node = WLDataLogicLayer.Setting.NodeCode;
            item.Date = WLDataLogicLayer.Runtime.CurrentDate;
            item.SN = this.txtSN.Text;
            item.UID = WLDataLogicLayer.User.LoginUser.Userid;
            item.CDT = DateTime.Now;

            item.SK_Type = (WLDataModelLayer.SKType)Enum.Parse(typeof(WLDataModelLayer.SKType), this.cboSK_Type.Text);
            item.YD_Type = WLDataModelLayer.YDType.本地;
            item.ZT_Type = WLDataModelLayer.ZTType.接货;

            item.FH_Code = (this.cboFH_List.SelectedItem as WLDataModelLayer.Authorize).Code;
            item.FH_Name = (this.cboFH_List.SelectedItem as WLDataModelLayer.Authorize).Name;
            item.FH_CityName = (this.cboFH_List.SelectedItem as WLDataModelLayer.Authorize).CityName;
            item.JH_Code = (this.cboJH_List.SelectedIndex >= 0) ? (this.cboJH_List.SelectedItem as WLDataModelLayer.Node).Code : "";
            item.JH_Name = (this.cboJH_List.SelectedIndex >= 0) ? (this.cboJH_List.SelectedItem as WLDataModelLayer.Node).Name : "";

            item.CZ_RQ = Convert.ToDateTime(this.cboCZ_RQ.Text);
            item.CZ_DZ = this.cboCZ_DZ.Text;
            item.CZ_CPH = this.lstCZ.SelectedItems[0].SubItems[0].Text.ToUpper();
            item.CZ_BC = this.lstCZ.SelectedItems[0].SubItems[1].Text;
            item.CZ_SJ = this.lstCZ.SelectedItems[0].SubItems[2].Text;
            item.CZ_LC = Convert.ToInt32(this.lstCZ.SelectedItems[0].SubItems[3].Text);
            item.CZ_YX = "00:00";

            item.HW_MC = this.txtHW_MC.Text;
            item.HW_LX = this.cboHW_LX.Text;
            item.HW_JS = Convert.ToInt32(this.numHW_JS.Value);
            item.HW_BJ = this.numHW_BJ.Value;
            item.BXD_SN = this.txtBXD_SN.Text;

            item.FHR_Name = this.txtFHR_Name.Text;
            item.FHR_Mobile = this.txtFHR_Mobile.Text;
            item.FHR_Remark = this.cboFHR_Remark.Text;
            item.JHR_Name = this.txtJHR_Name.Text;
            item.JHR_Mobile = this.txtJHR_Mobile.Text;

            item.JFZL = this.numJFZL.Value;
            item.JFTJ = this.numJFTJ.Value;
            item.TYF = this.numTYF.Value;
            item.BXF = this.numBXF.Value;
            item.BZF = this.numBZF.Value;
            item.Total = Convert.ToDecimal(this.txtTotal.Text);
            item.Money = (this.cboSK_Type.Text != "现金" ? 0M : this.numMoney.Value);

            item.Synced = (this.chkSyncToCentral.Enabled && this.chkSyncToCentral.Checked);

            StringBuilder sb = new StringBuilder("00000000000000000000000000000000");
            sb[0] = this.chkSecurityCheck.Checked ? '1' : '0';
            sb[1] = this.chkTelService.Checked ? '1' : '0';
            sb[2] = this.chkSMSService.Checked ? '1' : '0';
            item.Sets = sb.ToString();                      

            return item;
        }
        #endregion

        #region 初始运单信息
        private void Init()
        {
            this.chkSecurityCheck.Checked = false;
            this.chkTelService.Checked = false;
            this.chkSMSService.Checked = false;
            this.chkSyncToCentral.Checked = WLDataLogicLayer.Setting.SyncCentral;

            this.txtHW_MC.Text = string.Empty;
            this.cboHW_LX.SelectedIndex = (this.cboHW_LX.Items.Count > 0) ? 0 : -1;
            this.numHW_BJ.Value = 0M;
            this.txtBXD_SN.Text = string.Empty;
            this.txtFHR_Name.Text = string.Empty;
            this.txtFHR_Mobile.Text = string.Empty;            
            this.txtJHR_Name.Text = string.Empty;
            this.txtJHR_Mobile.Text = string.Empty;
            this.cboFHR_Remark.SelectedIndex = (this.cboFHR_Remark.Items.Count > 0) ? 0 : -1;
                      
            this.numHW_JS.Value = 1M;
            this.numJFZL.Value = 0M;
            this.numJFTJ.Value = 0M;
            this.numTYF.Enabled = WLDataLogicLayer.Setting.ManualModify;
            this.numBXF.Enabled = WLDataLogicLayer.Setting.ChargeBXF;
            this.cboBZFL.Enabled = WLDataLogicLayer.Setting.ChargeBZF;
            this.numBZF.Enabled = this.cboBZFL.Enabled;
            this.numMoney.Value = 0M;
            this.txtDifference.Text = "0.00";
            this.cboSK_Type.Text = "现金";

            this.cboJFLC.SelectedIndex = (this.cboJFLC.Items.Count > 0) ? 0 : -1;
            this.cboBZFL.SelectedIndex = (this.cboBZFL.Items.Count > 0) ? 0 : -1;
            this.chkBF.Checked = false;

            this.cboCZ_DZ.Items.Clear();
            this.cboCZ_DZ.Text = string.Empty;
            this.lstCZ.Enabled = false;
            this.lstCZ.Items.Clear();

            if (this.cboFH_List.SelectedIndex < 0)
            {
                this.cboCZ_RQ.Items.Clear();
                this.cboCZ_RQ.Enabled = false;
                this.cboCZ_DZ.Enabled = false;
                this.txtHW_MC.Focus();
            }
            else
                this.cboCZ_DZ.Focus();

            if (this.cboJH_List.Items.Count > 0) this.cboJH_List.SelectedIndex = 0;

            this.RefreshSN();
        }
        #endregion

        private void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Open)
            {
                this.cboCZ_RQ.Enabled = true;
                this.cboCZ_DZ.Enabled = true;
                this.cboCZ_DZ.Focus();
                this.btnBDAndPrint.Enabled = true;

                this.grpBase.Text = "基础信息（客运连接：打开）";
            }
            else
            {
                this.cboCZ_RQ.Enabled = false;
                this.cboCZ_DZ.Enabled = false;
                this.lstCZ.Enabled = false;
                this.btnBDAndPrint.Enabled = false;

                this.grpBase.Text = "基础信息（客运连接：关闭）";
            }
        }

        public static DialogResult InitAndShowDialog(bool pingEnabled, int pingTimeout, int pageOffsetX, int pageOffsetY)
        {
            using (YDCreateForm ydCreateForm = new YDCreateForm())
            {
                ydCreateForm.PingEnabled = pingEnabled;
                ydCreateForm.PingTimeout = pingTimeout;
                ydCreateForm.PageOffsetX = pageOffsetX;
                ydCreateForm.PageOffsetY = pageOffsetY;

                return ydCreateForm.ShowDialog();
            }
        }

        public YDCreateForm()
        {
            InitializeComponent();
        }

        private void YDCreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                KYDataLogicLayer.Runtime.B_ConnectionClose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void YDCreateForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("办理运单（当前网点：{0}-{1}）", WLDataLogicLayer.Setting.NodeCode, WLDataLogicLayer.Setting.NodeName);

                WLDataLogicLayer.Authorize.Refresh(this.cboFH_List);                                                        //发货网点初始化（未授权网点不包括）
                WLDataLogicLayer.Node.Refresh(this.cboJH_List, this.cboFH_List);                                            //接货网点初始化（不含发货网点列表存在的网点）
                WLDataLogicLayer.HWLXB.Refresh(this.cboHW_LX);                                                              //货物类型初始化
                WLDataLogicLayer.BZXXB.Refresh(this.cboFHR_Remark);                                                         //备注信息初始化
                WLDataLogicLayer.YFB.Refresh(this.cboJFLC);                                                                 //运费标准初始化
                WLDataLogicLayer.BZFLB.Refresh(this.cboBZFL);                                                               //包装费率初始化（必须在YFB之后初始化）
                WLDataModelLayer.WLB.SKTypeList(this.cboSK_Type, WLDataLogicLayer.Setting.AllowDF, false);                  //收款类型初始化
       
                this.txtDT.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.timer.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void YDCreateForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Init();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                this.txtDT.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Letter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !(char.IsLower(e.KeyChar) || char.IsUpper(e.KeyChar) || e.KeyChar == 0x08);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 0x08);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                switch (e.KeyCode)
                {
                    case Keys.F2:   //修改计费里程
                        if (this.cboJFLC.SelectedIndex < this.cboJFLC.Items.Count - 1)
                            this.cboJFLC.SelectedIndex++;
                        else
                            this.cboJFLC.SelectedIndex = 0;
                        break;
                    case Keys.F3:  //修改包装费
                        if (this.cboBZFL.SelectedIndex < this.cboBZFL.Items.Count - 1)
                            this.cboBZFL.SelectedIndex++;
                        else
                            this.cboBZFL.SelectedIndex = 0;
                        break;                    
                    case Keys.F4:   //是否按文件袋收费
                        this.chkBF.Checked = !this.chkBF.Checked; break;                    
                    case Keys.F5:   //是否已经开箱安全检查
                        this.chkSecurityCheck.Checked = !this.chkSecurityCheck.Checked; break;                    
                    case Keys.F6:   //是否开启电话通知服务
                        this.chkTelService.Checked = !this.chkTelService.Checked; break;                    
                    case Keys.F7:   //是否开启短信通知服务
                        this.chkSMSService.Checked = !this.chkSMSService.Checked; break;
                    case Keys.Escape: 
                        this.SelectNextControl(c, false, true, true, true); break;
                    case Keys.Enter:
                        switch (c.Name)
                        {
                            case "txtHW_MC":
                                if (this.txtHW_MC.Text == string.Empty) return;
                                break;
                            case "txtFHR_Mobile":
                                if (this.txtFHR_Mobile.Text == string.Empty) return;
                                if (WLDataLogicLayer.Customer.Exists(this.txtFHR_Mobile.Text))
                                    this.txtFHR_Name.Text = WLDataLogicLayer.Customer.GetName(this.txtFHR_Mobile.Text);
                                break;
                            case "txtJHR_Mobile":
                                if (this.txtJHR_Mobile.Text == string.Empty) return;
                                if (WLDataLogicLayer.Customer.Exists(this.txtJHR_Mobile.Text))
                                    this.txtJHR_Name.Text = WLDataLogicLayer.Customer.GetName(this.txtJHR_Mobile.Text);
                                break;
                            case "txtFHR_Name":
                                if (this.txtFHR_Name.Text == string.Empty) return;
                                break;
                            case "txtJHR_Name":
                                if (this.txtJHR_Name.Text == string.Empty) return;
                                break;
                            case "numTYF":
                                if (this.numTYF.Value == 0M) return;
                                break;
                            case "numMoney":
                                if (this.cboSK_Type.Text == "现金" && this.numMoney.Value < Convert.ToDecimal(this.txtTotal.Text)) return;
                                break;
                            case "cboCZ_DZ":
                                if (this.cboCZ_DZ.Text == string.Empty) return;

                                //到站不为空，且首字符为英文字母，刷新承载列表
                                if (Char.IsLower(this.cboCZ_DZ.Text[0]) || Char.IsUpper(this.cboCZ_DZ.Text[0]))
                                {
                                    KYDataLogicLayer.ZMPJB_Simple.Refresh(this.cboCZ_DZ, Convert.ToDateTime(this.cboCZ_RQ.Text),this.cboCZ_DZ.Text);
                                }
                                break;
                        }
                        this.SelectNextControl(c, true, true, true, true);
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            try { this.Init(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnBDAndPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Check();

                WLCommon.PrintBill.Print(WLDataLogicLayer.WLB.Create(this.Build(), this.Bill), this.PageOffsetX, this.PageOffsetY);

                this.Init();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //发货网点改变时
        private void cboFH_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cboFH_List.SelectedIndex >= 0)                
                {                                       
                    //初始化客运连接
                    KYDataLogicLayer.Runtime.B_ConnectionInit(
                        Common.ConnectionInfo.ToConnectionInfo((this.cboFH_List.SelectedItem as WLDataModelLayer.Authorize).Content),
                        new StateChangeEventHandler(ConnectionStateChange));
                    //初始化日期列表
                    KYDataLogicLayer.BCK.RefreshDateList(this.cboCZ_RQ, WLDataLogicLayer.Runtime.CurrentDate, WLDataLogicLayer.Setting.OnlyToday);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //接货网点改变时
        private void cboJH_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.chkSyncToCentral.Enabled = this.cboJH_List.SelectedIndex > 0;

                this.cboCZ_DZ.SelectAll();
                this.cboCZ_DZ.Focus();                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //承载到站改变后
        private void cboCZ_DZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.lstCZ.Enabled = false;

                string code = (this.cboCZ_DZ.SelectedIndex < 0) ? "" : (this.cboCZ_DZ.SelectedItem as KYDataModelLayer.ZMPJB_Simple).Code;
                //根据日期、到站代码刷新承载班次列表
                KYDataLogicLayer.BCK.RefreshByZDDM(this.lstCZ, Convert.ToDateTime(this.cboCZ_RQ.Text), code);
                
                this.lstCZ.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }            
        }

        //承载班次改变后
        private void lstCZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            //自动选择运费标准
            if(this.lstCZ.SelectedItems.Count >0 && WLDataLogicLayer.Setting.AutoSelectYF)
            {
                KYDataModelLayer.BCK item = this.lstCZ.SelectedItems[0].Tag as KYDataModelLayer.BCK;
                if (item != null && item.QZLC > 0)
                    this.cboJFLC.SelectedIndex = WLDataLogicLayer.YFB.FindYFFromCBO(this.cboJFLC, item.QZLC);
            }
        }

        //收款类型改变时
        private void cboSK_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (this.cboSK_Type.Text)
                {
                    case "现金":
                        if (!numMoney.Enabled)
                        {
                            this.numMoney.Enabled = true;
                            this.numMoney.Value = 0M;
                        }
                        this.numMoney.Focus();
                        break;
                    case "到付":
                        if (numMoney.Enabled)
                        {
                            this.numMoney.Enabled = false;
                            this.numMoney.Value = 0M;
                        }
                        this.btnBDAndPrint.Focus();
                        break;
                    default: throw new ApplicationException("指定收款类型未支持！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void calcTYF(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.YFB item = this.cboJFLC.SelectedItem as WLDataModelLayer.YFB;
                if (item != null)
                {
                    //根据‘货物件数是否参加计算’计算包装费
                    decimal c = (WLDataLogicLayer.Setting.HWJSJoinCalc) ? this.numHW_JS.Value : 1M;

                    //如果按文件袋计算，关闭计费重量及计费体积
                    this.numJFZL.Enabled = !this.chkBF.Checked;
                    this.numJFTJ.Enabled = !this.chkBF.Checked;

                    //是否按文件袋计算
                    if (this.chkBF.Checked)
                    {
                        if (this.cboBZFL.Text != "自理包装") this.cboBZFL.Text = "文件袋";

                        this.numTYF.Value = item.BF * c;
                    }
                    else
                    {
                        decimal t = (this.numJFTJ.Value > 0) ? (this.numJFTJ.Value / item.Factor) : 0;              //体积折算公斤
                        decimal z = (this.numJFZL.Value > item.Weight) ? (this.numJFZL.Value - item.Weight) : 0;    //是否大于起重

                        this.numTYF.Value = Decimal.Ceiling((item.BW + ((z + t) * item.Excess)) * c);
                    }

                    Control control = sender as Control;
                    if (control != null && (control.Name == "cboJFLC" || control.Name == "chkBF")) { this.numTYF.Focus(); }
                }
                else
                    throw new NullReferenceException("当前运费标准无效！");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void calcBXF(object sender, EventArgs e)
        {
            try
            {
                if (this.numHW_BJ.Value == 0 || !WLDataLogicLayer.Setting.BXFAutoCalc) 
                    this.numBXF.Value = 0;
                else
                {
                    decimal bxf = this.numHW_BJ.Value * WLDataLogicLayer.Setting.BXFRatio;

                    decimal minBXF = WLDataLogicLayer.Setting.BXFMin;
                    decimal maxBXF = WLDataLogicLayer.Setting.BXFMax;

                    if (minBXF != 0 && bxf < minBXF) { this.numBXF.Value = minBXF; return; }
                    if (maxBXF != 0 && bxf > maxBXF) { this.numBXF.Value = maxBXF; return; }

                    if (WLDataLogicLayer.Setting.BXFRound) this.numBXF.Value = Decimal.Ceiling(bxf);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void calcBZF(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.BZFLB item = this.cboBZFL.SelectedItem as WLDataModelLayer.BZFLB;
                if (item != null && item.Name != "自理包装")
                {
                    //根据‘货物件数是否参加计算’计算包装费
                    this.numBZF.Value = item.Value * (WLDataLogicLayer.Setting.HWJSJoinCalc ? this.numHW_JS.Value : 1M);
                }
                else
                    this.numBZF.Value = 0M;

                Control control = sender as Control;
                if (control != null && control.Name == "cboBZFL") { this.numBZF.Focus(); }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void calcTotal(object sender, EventArgs e)
        {
            try
            {
                this.txtTotal.Text = (this.numTYF.Value + this.numBZF.Value + this.numBXF.Value).ToString("N2");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void calcDifference(object sender, EventArgs e)
        {
            try
            {
                this.txtDifference.Text = (this.numMoney.Value - Convert.ToDecimal(this.txtTotal.Text)).ToString("N2");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtSN_Click(object sender, EventArgs e)
        {
            try
            {
                this.Bill = null;
                this.RefreshSN();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //------------------------------------------------------------------------------------------------------------
        #region 2013-08-01 - 工具面板代码
        //------------------------------------------------------------------------------------------------------------  
        
        //更新汇总金额
        private void btnRefreshTotalAmount_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtTotalAmount.Text = WLDataLogicLayer.WLB.GetLocalUserTotalAmount(WLDataLogicLayer.User.LoginUser.Userid).ToString("N2");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private WLDataModelLayer.WLB OriginalWLB { get; set; }

        private void ToolBar_Clear()
        {
            this.txtCPH.Text = string.Empty;
            this.txtCPH.Enabled = false;
            this.btnFind.Enabled = false;
            this.btnGD.Enabled = false;
            this.btnFD.Enabled = false;

            this.OriginalWLB = null;
        }

        private bool ToolBar_Check(WLDataModelLayer.WLB item)
        {
            //if (item.UID != WLCommon.User.Item.Userid) throw new ApplicationException("非当前用户办理运单，不能办理改单或废单！");
            if (item.ZT_Type == WLDataModelLayer.ZTType.作废) throw new ApplicationException(string.Format("运单'{0}'已作废，不能再次办理改单或废单！", item.SN));
            if (item.Freeze)
            {
                string msg = string.Format("运单'{0}'已冻结，不能办理废单，改单须重新上传运单记录到汇总数据库！", item.SN);
                if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    return false;
            }
            return true;
        }

        private void ToolBar_Init(WLDataModelLayer.WLB item)
        {
            this.txtCPH.Enabled = true;
            this.txtCPH.Text = item.CZ_CPH;
            this.txtCPH.SelectAll();
            this.txtCPH.Focus();
            this.btnFD.Enabled = !item.Freeze;
        }

        private WLDataModelLayer.WLB ToolBar_Build(string cph)
        {
            WLDataModelLayer.WLB item = this.OriginalWLB.Clone();
            item.CZ_CPH = cph;
            return item;                
        }

        //查找指定单据号
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string sn = WLDataLogicLayer.Bill.Format(this.txtFindSN.Text);

                if (WLDataLogicLayer.WLB.Exists(sn))
                {
                    this.OriginalWLB = WLDataLogicLayer.WLB.ReadLocal(sn);
                    if (this.OriginalWLB != null)
                    {
                        if (this.ToolBar_Check(this.OriginalWLB)) this.ToolBar_Init(this.OriginalWLB);
                    }
                    else throw new ApplicationException(string.Format("无法获取‘{0}’的运单数据！", sn));
                }
                else throw new ApplicationException(string.Format("运单编号‘{0}’不存在！", sn));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //改单
        private void btnGD_Click(object sender, EventArgs e)
        {
            try
            {
                string cph = this.txtCPH.Text.ToUpper();

                //如果配置改单时检测车牌号且选择发货连接，则改单时查询客运站车辆库中是否存在指定车牌号，并在不存在时询问是否继续改单。
                if (WLDataLogicLayer.Setting.GDCheckCPH && this.cboFH_List.SelectedIndex >= 0 && !KYDataLogicLayer.CLK.Exist(cph))
                {
                    string msg = string.Format("客运站车辆库不存在车牌号‘{0}’，是否继续改单？", cph);
                    if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                        return;
                }
                WLDataLogicLayer.WLB.Change(this.ToolBar_Build(cph), this.OriginalWLB);
                this.ToolBar_Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //废单
        private void btnFD_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = string.Format("运单‘{0}’是否办理废单？", this.OriginalWLB.SN);
                if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                WLDataLogicLayer.WLB.Destroy(this.OriginalWLB);
                this.ToolBar_Clear();  
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //如果存在可用待查找单据号，激活查找按钮
        private void txtFindSN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.OriginalWLB != null) this.ToolBar_Clear();

                this.btnFind.Enabled = (this.txtFindSN.Text.Length > 0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //如果车牌号不为空、长度等于7，并且已改变，激活改单按钮
        private void txtCPH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cph = this.txtCPH.Text.ToUpper();

                this.btnGD.Enabled = (cph != string.Empty && cph.Length == 7 && cph != this.OriginalWLB.CZ_CPH);

                if (cph != string.Empty && WLDataLogicLayer.Mapping.Array.ContainsKey(cph))
                {
                    this.txtCPH.Text = WLDataLogicLayer.Mapping.Array[cph];
                    this.txtCPH.Select(cph.Length, 0);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
        //------------------------------------------------------------------------------------------------------------
    }
}
