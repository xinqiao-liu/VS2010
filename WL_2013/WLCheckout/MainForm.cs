using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Deployment.Application;

namespace WLCheckout
{
    public partial class MainForm : Form
    {
        private WLDataModelLayer.ZDB m_ZDItem = null;
        private bool m_IsLogin = false;

        #region 登录状态管理

        private bool IsLogin 
        {
            get { return this.m_IsLogin; }
            set
            {
                if (value == true)
                {
                    this.miLogin.Text = "用户注销";
                    this.txtLoginState.ForeColor = Color.Black;
                    this.txtLoginState.Text = WLDataLogicLayer.User.LoginUser.ToString();


                }
                else
                {
                    this.miLogin.Text = "用户登录";
                    this.txtLoginState.ForeColor = Color.Gray;
                    this.txtLoginState.Text = "未登录";

                    this.AccountsClose();
                }
                this.miSetting.Enabled = value;
                this.miBaseData.Enabled = value;
                this.miJZDMB.Enabled = value;
                this.miCSXXB.Enabled = value;
                this.miResetPassword.Enabled = value;

                this.miQuery.Enabled = value;
                this.miCreate.Enabled = value;
                this.miOpen.Enabled = value;
                this.miDelete.Enabled = value;
                this.miYDRecord.Enabled = value;
                
                this.miCollectByWD.Enabled = value;
                this.miCollectByCP.Enabled = value;
                this.miCollectByXL.Enabled = value;
                this.miCollectByCustomer.Enabled = value;
                this.miDayReport.Enabled = value;
                this.miMonthReport.Enabled = value;

                this.txtTrackCPH.Enabled = value;
                this.btnTrackCPH.Enabled = value;
                if (!value) 
                    this.txtTrackCPH.Clear();

                this.m_IsLogin = value;
            }
        }

        private void Logout()
        {
            try
            {
                WLDataLogicLayer.User.Logout();
                this.IsLogin = false;
            }
            catch (Exception ex) { throw new ApplicationException("登出发生异常：\r\n" + ex.Message); }
        }

        private void Login(string userid)
        {
            try
            {
                WLDataLogicLayer.User.Login(userid);
                this.IsLogin = true;
            }
            catch (Exception ex) { throw new ApplicationException("登录发生异常：\r\n" + ex.Message); }
        }

        #endregion

        #region 账单列表管理

        private WLDataModelLayer.ZDB ZDItem
        {
            get { return this.m_ZDItem; }
            set
            {
                if (value is WLDataModelLayer.ZDB)
                {
                    this.Text = Properties.Settings.Default.SoftwareName + " （ " + value.Name + " ）";
                    this.miClose.Enabled = true;
                    this.btnPrintHZ.Enabled = true;
                    this.btnPrintMX.Enabled = true;
                    this.btnFind.Enabled = true;
                    this.cboMXShowRange.Enabled = true;
                    this.cboMXShowRange.SelectedIndex = 0;
                }
                else
                {
                    this.Text = Properties.Settings.Default.SoftwareName;
                    this.miClose.Enabled = false;
                    this.btnPrintHZ.Enabled = false;
                    this.btnPrintMX.Enabled = false;
                    this.btnFind.Enabled = false;
                    this.cboMXShowRange.Enabled = false;
                    this.cboMXShowRange.SelectedIndex = -1;

                    this.listHZ.Items.Clear();
                    this.listHZ.Enabled = false;
                    this.listMX.Items.Clear();
                    this.listMX.Enabled = false;
                    this.listYD.Items.Clear();
                    this.listYD.Enabled = false;
                    this.txtTrackCPH.Clear();
                }
                this.m_ZDItem = value;
            }
        }

        private void AccountsClose()
        {
            if (this.ZDItem is WLDataModelLayer.ZDB) this.ZDItem = null;
        }

        private void AccountsOpen(WLDataModelLayer.ZDB item)
        {
            this.ZDItem = item;
            WLDataLogicLayer.ZDHZB.Refresh(this.listHZ, item.Year, item.Month);
        }

        private WLDataModelLayer.ZDHZB GetAccountHZItem()
        {
            if (this.listHZ.SelectedItems.Count > 0)
            {
                if (this.listHZ.SelectedItems[0].Tag is WLDataModelLayer.ZDHZB)
                    return this.listHZ.SelectedItems[0].Tag as WLDataModelLayer.ZDHZB;
                else
                    throw new ApplicationException("账单汇总项无效！");
            }
            else throw new ApplicationException("未选择账单汇总项！");
        }

        private WLDataModelLayer.ZDMXB GetAccountMXItem()
        {
            if (this.listMX.SelectedItems.Count > 0)
            {
                if (this.listMX.SelectedItems[0].Tag is WLDataModelLayer.ZDMXB)
                    return this.listMX.SelectedItems[0].Tag as WLDataModelLayer.ZDMXB;
                else
                    throw new ApplicationException("账单明细项无效！");
            }
            else throw new ApplicationException("未选择账单明细项！");
        }

        private void RefreshMXList(ListView list, int year, int month, string code)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.ZDMXB i in WLDataLogicLayer.ZDMXB.Reads(year, month, code))
            {
                ListViewItem item = new ListViewItem(i.CPH);
                item.Tag = i;
                item.SubItems.Add(i.Owner);
                item.SubItems.Add(i.Count.ToString());
                item.SubItems.Add(i.Total.ToString("N2"));
                item.SubItems.Add(i.Ratio.ToString("N2"));
                item.SubItems.Add(i.Money.ToString("N2"));

                list.Items.Add(item);
            }

            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public void RefreshYDList(ListView list, string cph, DateTime sdt, DateTime edt)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataLogicLayer.WLB.ReadByCPHAndDateRange(cph, sdt, edt))
            {
                list.Items.Add(this.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public ListViewItem ToListViewItem(WLDataModelLayer.WLB i)
        {
            ListViewItem item = new ListViewItem(i.SN);
            item.Tag = i;
            item.SubItems.Add(i.UID);
            item.SubItems.Add(i.CDT.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(i.SK_Type.ToString());
            item.SubItems.Add(i.YD_Type.ToString());
            item.SubItems.Add(i.ZT_Type.ToString());
            item.SubItems.Add(i.CZ_RQ.ToString("yyyy-MM-dd"));
            item.SubItems.Add(i.CZ_BC);
            item.SubItems.Add(i.CZ_CPH);
            item.SubItems.Add(i.CZ_DZ);
            item.SubItems.Add(i.CZ_SJ);
            item.SubItems.Add(i.HW_MC);
            item.SubItems.Add(i.HW_LX);
            item.SubItems.Add(i.HW_JS.ToString());
            item.SubItems.Add(i.HW_BJ.ToString("N2"));
            item.SubItems.Add(i.FHR_Name);
            item.SubItems.Add(i.FHR_Mobile);
            item.SubItems.Add(i.FHR_Remark);
            item.SubItems.Add(i.JHR_Name);
            item.SubItems.Add(i.JHR_Mobile);
            item.SubItems.Add(i.JFZL.ToString("N2"));
            item.SubItems.Add(i.JFTJ.ToString("N2"));
            item.SubItems.Add(i.TYF.ToString("N2"));
            item.SubItems.Add(i.BZF.ToString("N2"));
            item.SubItems.Add(i.BXF.ToString("N2"));
            item.SubItems.Add(i.Total.ToString("N2"));
            item.SubItems.Add(i.Money.ToString("N2"));
            item.SubItems.Add(i.FH_Code + "-" + i.FH_Name);
            item.SubItems.Add(i.JH_Code + "-" + i.JH_Name);
            item.SubItems.Add(i.BXD_SN);

            return item;
        }

        #endregion

        #region 联网状态改变
        
        private void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState != ConnectionState.Open)
            {
                this.txtConnectionState.Text = "关闭";
                this.txtConnectionState.ForeColor = Color.Gray;

                if (e.OriginalState == ConnectionState.Open)
                {
                    MessageBox.Show("数据连接已关闭，请检查本机网络连接是否正常！");
                }
            }
            else
            {                
                this.txtConnectionState.Text = "开启";
                this.txtConnectionState.ForeColor = Color.Black;
            }
        }
        
        #endregion

        #region 主窗口构建及事件

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.ConfirmClose)
                {
                    if (MessageBox.Show("是否退出系统？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    {
                        e.Cancel = true; return;
                    }
                }
                this.IsLogin = false;                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    this.txtHint.Text = "部署版本：" + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                }
                catch 
                { 
                    this.txtHint.Text = "部署版本：未知"; 
                }
                this.txtHint.Text += "    技术支持：" + Properties.Settings.Default.TechnicalSupport;

                //初始化基础数据连接
                WLDataLogicLayer.Runtime.B_ConnectionInit(
                    ConfigurationManager.ConnectionStrings["connStr_b"].ConnectionString,
                    new StateChangeEventHandler(ConnectionStateChange),
                    Properties.Settings.Default.PingEnabled,
                    Properties.Settings.Default.PingTimeout);

                //初始化系统查询日期、运行配置
                WLDataLogicLayer.Runtime.InitQueryDate(Properties.Settings.Default.AutoSyncServerDT);
                WLDataLogicLayer.Setting.Init();
                WLDataLogicLayer.Mapping.Init();

                //检测是否自动登录，如果是则验证用户及密码是否正确
                if (Properties.Settings.Default.AutoLogin && WLDataLogicLayer.User.Validate(Properties.Settings.Default.Userid, Properties.Settings.Default.Password))
                {
                    this.Login(Properties.Settings.Default.Userid); return;
                }

                this.miLogin_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region 系统管理菜单事件

        private void miClientSetting_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClientSettingForm clientSettingForm = new ClientSettingForm())
                {
                    clientSettingForm.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miSetting_Click(object sender, EventArgs e)
        {
            try
            {
                CheckoutSettingForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miMapping_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.MappingForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miJZDMB_Click(object sender, EventArgs e)
        {
            try
            {
                JZDMForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCSXXB_Click(object sender, EventArgs e)
        {
            try
            {
                CSXXForm.InitAndShowDialog(string.Empty);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsLogin)
                {
                    using (WLCommon.LogoutForm logoutForm = new WLCommon.LogoutForm())
                    {
                        switch (logoutForm.ShowDialog())
                        {
                            case DialogResult.No:
                                this.Logout();
                                return;
                            case DialogResult.Yes:
                                this.Logout();
                                break;
                            case DialogResult.Cancel:
                                return;
                        }
                    }
                }

                using (WLCommon.LoginForm loginForm = new WLCommon.LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        this.Login(loginForm.Userid);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.ResetPasswordForm.InitAndShowDialog(WLDataLogicLayer.User.LoginUser.Userid);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region 账单管理菜单事件

        private void miQuery_Click(object sender, EventArgs e)
        {
            try
            {
                using (QueryForm queryForm = new QueryForm())
                {
                    if (queryForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (AccountNewForm accountsNewForm = new AccountNewForm())
                {
                    if (accountsNewForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.AccountsOpen(accountsNewForm.Accounts);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.Checkout.AccountsOpenForm accountsOpenForm = new WLCommon.Checkout.AccountsOpenForm())
                {
                    if (accountsOpenForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.AccountsOpen(accountsOpenForm.Accounts);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.Checkout.AccountsOpenForm accountsOpenForm = new WLCommon.Checkout.AccountsOpenForm())
                {
                    accountsOpenForm.Text = "删除账单";
                    if (accountsOpenForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //检测所删除账单是否打开，如打开先关闭
                        if (accountsOpenForm.Accounts.Equals(this.ZDItem))
                            this.AccountsClose();

                        WLDataLogicLayer.ZDB.Delete(accountsOpenForm.Accounts);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.AccountsClose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miYDRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (YDRecordForm ydRecordForm = new YDRecordForm())
                {
                    ydRecordForm.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region 统计报表菜单事件

        private void miCollectByWD_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.QueryRangeForm queryRangeForm = new WLCommon.QueryRangeForm())
                {
                    if (queryRangeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_CollectByWD.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.Collect.ReadCollectByWD(queryRangeForm.MinDate, queryRangeForm.MaxDate);
                            reportPrintForm.ParamTitle = string.Format("{0} 按网点汇总表", (queryRangeForm.MinDate == queryRangeForm.MaxDate)
                                ? queryRangeForm.MinDate.ToString("yyyy-MM-dd")
                                : queryRangeForm.MinDate.ToString("yyyy-MM-dd") + "至" + queryRangeForm.MaxDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCollectByCP_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.QueryRangeForm queryRangeForm = new WLCommon.QueryRangeForm())
                {
                    if (queryRangeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_CollectByCP.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.Collect.ReadCollectByCP(queryRangeForm.MinDate, queryRangeForm.MaxDate);
                            reportPrintForm.ParamTitle = string.Format("{0} 按车牌汇总表", (queryRangeForm.MinDate == queryRangeForm.MaxDate)
                                ? queryRangeForm.MinDate.ToString("yyyy-MM-dd")
                                : queryRangeForm.MinDate.ToString("yyyy-MM-dd") + "至" + queryRangeForm.MaxDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCollectByXL_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.QueryRangeForm queryRangeForm = new WLCommon.QueryRangeForm())
                {
                    if (queryRangeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_CollectByXL.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.Collect.ReadCollectByXL(queryRangeForm.MinDate, queryRangeForm.MaxDate);
                            reportPrintForm.ParamTitle = string.Format("{0} 按线路汇总表", (queryRangeForm.MinDate == queryRangeForm.MaxDate)
                                ? queryRangeForm.MinDate.ToString("yyyy-MM-dd")
                                : queryRangeForm.MinDate.ToString("yyyy-MM-dd") + "至" + queryRangeForm.MaxDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCollectByCustomer_Click(object sender, EventArgs e)
        {
            try
            {               
                using (WLCommon.QueryRangeForm queryRangeForm = new WLCommon.QueryRangeForm())
                {
                    if (queryRangeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_CollectByCustomer.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.Collect.ReadCollectByCustomer(
                                queryRangeForm.MinDate, 
                                queryRangeForm.MaxDate,
                                (WLDataModelLayer.CollectByCustomerSortMode)Enum.Parse(typeof(WLDataModelLayer.CollectByCustomerSortMode), Properties.Settings.Default.CollectByCustomerSortMode));
                            reportPrintForm.ParamTitle = string.Format("{0} 按客户汇总表", (queryRangeForm.MinDate == queryRangeForm.MaxDate)
                                ? queryRangeForm.MinDate.ToString("yyyy-MM-dd")
                                : queryRangeForm.MinDate.ToString("yyyy-MM-dd") + "至" + queryRangeForm.MaxDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miDayReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                {
                    selectDateForm.Dates = WLDataLogicLayer.WLB.GetDateList(System.Data.SqlClient.SortOrder.Descending);
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_Day.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.WLB.ReadReport(selectDateForm.SelectDate);
                            reportPrintForm.ParamTitle = string.Format("{0} 日报表", selectDateForm.SelectDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miMonthReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.Checkout.AccountsOpenForm accountsOpenForm = new WLCommon.Checkout.AccountsOpenForm())
                {
                    if (accountsOpenForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_Month.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.WLB.ReadReport(accountsOpenForm.Accounts.SDT, accountsOpenForm.Accounts.EDT);
                            reportPrintForm.ParamTitle = string.Format("{0}年{1}月报表", accountsOpenForm.Accounts.Year, accountsOpenForm.Accounts.Month);
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region 工具按钮单击事件

        private void btnPrintHZ_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_Account.rdlc" })
                {
                    reportPrintForm.DataSourceValue = WLDataLogicLayer.ZDHZB.Reads(this.ZDItem.Year, this.ZDItem.Month);
                    reportPrintForm.ParamTitle = this.ZDItem.Name;
                    reportPrintForm.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnPrintMX_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.ZDHZB hzItem = this.GetAccountHZItem();
                if (hzItem != null)
                {
                    using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_Detail.rdlc" })
                    {
                        reportPrintForm.ParamTitle = string.Format("{0}明细表", this.ZDItem.Name);
                        if (this.cboMXShowRange.SelectedIndex == 0)
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.ZDMXB.Reads(hzItem.Year, hzItem.Month, hzItem.Code);
                        else
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.ZDMXB.Reads(hzItem.Year, hzItem.Month, string.Empty);

                        reportPrintForm.ShowDialog();
                    }
                }
                else throw new NullReferenceException("选择账单汇总项数据无效，无法打印该项明细！");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.SimpleFindForm simpleFindForm = new WLCommon.SimpleFindForm())
                {
                    simpleFindForm.Text = "查找";
                    simpleFindForm.ID = "结账代码：";
                    simpleFindForm.NonEmpty = true;
                    if (simpleFindForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        foreach (ListViewItem i in this.listHZ.Items)
                        {
                            if (i.SubItems[2].Text == simpleFindForm.Value) { i.EnsureVisible(); i.Selected = true; }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnTrackCPH_Click(object sender, EventArgs e)
        {
            try
            {
                string cph = this.txtTrackCPH.Text.ToUpper();
                if (cph == string.Empty)
                {
                    MessageBox.Show("请输入要追踪的车牌号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTrackCPH.Focus();
                    return;
                }
                if (cph.Length != 7)
                {
                    MessageBox.Show("请输入指定格式车牌号（如：吉A12345）！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTrackCPH.Focus();
                    return;
                }

                using (TrackCPHForm trackCPHForm = new TrackCPHForm())
                {
                    trackCPHForm.CPH = cph;
                    trackCPHForm.ShowDialog();
                }               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.AboutForm.InitAndShowDialog(new Common.AboutInfo()
                {
                    SoftwareName = Properties.Settings.Default.SoftwareName,
                    SoftwareVersion = Properties.Settings.Default.SoftwareVersion,
                    TechnicalSupport = Properties.Settings.Default.TechnicalSupport
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        private void listHZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.listHZ.SelectedItems.Count > 0)
                {
                    WLDataModelLayer.ZDHZB item = this.GetAccountHZItem();
                    if (this.cboMXShowRange.SelectedIndex == 0)
                        this.RefreshMXList(this.listMX, item.Year, item.Month, item.Code);
                    else
                        this.RefreshMXList(this.listMX, item.Year, item.Month, string.Empty);
                }
            }
            catch (Exception ex) { this.listMX.Items.Clear(); this.listMX.Enabled = false; MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listMX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.listMX.SelectedItems.Count > 0)
                {
                    this.txtTrackCPH.Text = this.GetAccountMXItem().CPH;
                    this.RefreshYDList(this.listYD, this.txtTrackCPH.Text, this.ZDItem.SDT, this.ZDItem.EDT);
                }
                else
                    this.listYD.Items.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region 计划删除
        /* 计划删除
                this.miAccountNew.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miAccountOpen.Enabled = this.IsLogin;
                this.miAccountDelete.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miAccountClose.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB);
                this.miYDView.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB) && this.listMX.SelectedItems.Count > 0;
                this.miPrintHZ.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB) && this.listHZ.Items.Count > 0;
                this.miPrintMX.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB) && this.listMX.Items.Count > 0;
                this.miFind.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB);

        private void miExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.CheckPathExists = true;
                    saveFileDialog.DefaultExt = ".xls";
                    //saveFileDialog.FileName = "";
                    saveFileDialog.Filter = "Excel 2003 文件|*.xls";
                    saveFileDialog.InitialDirectory = Application.StartupPath;
                    saveFileDialog.Title = "导出 Excel";
                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ToolStripMenuItem mi = sender as ToolStripMenuItem;
                        if (mi != null)
                        {
                            switch (mi.Name)
                            {
                                case "miExportHZ":
                                    WLCommon.ExportExcel.ExportAccount(saveFileDialog.FileName, this.listHZ);
                                    break;
                                case "miExportMX":
                                    WLCommon.ExportExcel.ExportDetail(saveFileDialog.FileName, this.listMX);
                                    break;
                                default: break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        */
        #endregion
    }
}
