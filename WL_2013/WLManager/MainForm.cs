using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Deployment.Application;

namespace WLManager
{
    public partial class MainForm : Form
    {
        private WLCommon.QueryMode QueryMode { get; set; }
        private DateTime QueryDate { get; set; }
        private bool IsLogin { get; set; }

        private void Logout()
        {
            try
            {
                WLDataLogicLayer.User.Logout();

                this.IsLogin = false;
                this.miLogin.Text = "用户登录(&L)";
                this.txtLoginState.ForeColor = Color.Red;
                this.txtLoginState.Text = "未登录";
                this.toolStrip.Enabled = false;
                this.list.Items.Clear();
                this.list.Enabled = false;
            }
            catch (Exception ex) { throw new ApplicationException("登出发生异常：" + ex.Message); }
        }

        private void Login(string userid)
        {
            try
            {
                WLDataLogicLayer.User.Login(userid);

                this.IsLogin = true;
                this.miLogin.Text = "用户注销(&L)";
                this.txtLoginState.ForeColor = Color.Green;
                this.txtLoginState.Text = WLDataLogicLayer.User.LoginUser.ToString();
                this.toolStrip.Enabled = true;
            }
            catch (Exception ex) { throw new ApplicationException("登录发生异常：" + ex.Message); }
        }

        private void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState != ConnectionState.Open)
            {
                this.txtConnectionState.Text = "关闭";
                this.txtConnectionState.ForeColor = Color.Gray;
                this.miLogin.Enabled = false;
                this.toolStrip.Enabled = false;
            }
            else
            {
                this.txtConnectionState.Text = "开启";
                this.txtConnectionState.ForeColor = Color.Green;
                this.miLogin.Enabled = true;
                this.toolStrip.Enabled = this.IsLogin;
            }
        }

        #region 运单列表关联函数

        private ListViewItem ToListViewItem(WLDataModelLayer.WLB i)
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

        // 通过日期更新运单列表
        private void RefreshByDate(ListView list, string nodecode, DateTime date)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataLogicLayer.WLB.ReadByDate(nodecode, date))
            {
                list.Items.Add(this.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        // 通过编号更新运单列表
        private void RefreshBySN(ListView list, string nodecode, string sn)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataLogicLayer.WLB.ReadBySN(nodecode, sn))
            {
                list.Items.Add(this.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        // 通过发货人电话更新运单列表
        private void RefreshByFHRTel(ListView list, string nodecode, string fhr_tel)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataLogicLayer.WLB.ReadByFHRTel(nodecode, fhr_tel))
            {
                list.Items.Add(this.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        // 通过发货人姓名更新运单列表
        private void RefreshByFHRName(ListView list, string nodecode, string fhr_name)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataLogicLayer.WLB.ReadByFHRName(nodecode, fhr_name))
            {
                list.Items.Add(this.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        private void RefreshLists(ListView list, WLCommon.QueryMode queryMode, string content)
        {
            switch (queryMode)
            {
                case WLCommon.QueryMode.Date:
                    this.RefreshByDate(list, WLDataLogicLayer.Setting.NodeCode, Convert.ToDateTime(content));
                    break;
                case WLCommon.QueryMode.SN:
                    this.RefreshBySN(list, WLDataLogicLayer.Setting.NodeCode, WLDataModelLayer.Bill.Current(content, 
                        WLDataLogicLayer.Setting.BillZeroize, WLDataLogicLayer.Setting.BillBits));
                    break;
                case WLCommon.QueryMode.FHRName:
                    this.RefreshByFHRName(list, WLDataLogicLayer.Setting.NodeCode, content);
                    break;
                case WLCommon.QueryMode.FHRTel:
                    this.RefreshByFHRTel(list, WLDataLogicLayer.Setting.NodeCode, content);
                    break;
                default: break;
            }
        }

        private WLDataModelLayer.WLB GetListSelectedItem(bool checkFD)
        {
            if (this.list.SelectedItems.Count > 0)
            {
                WLDataModelLayer.WLB item = this.list.SelectedItems[0].Tag as WLDataModelLayer.WLB;
                if (item == null)
                    throw new ApplicationException("选定运单数据无效！");
                if (checkFD && item.ZT_Type == WLDataModelLayer.ZTType.作废)
                    throw new ApplicationException("选定运单已废！");

                return item;
            }
            else
                throw new ApplicationException("未选择有效运单！");
        }

        private void UpdateListSelectedItem(WLDataModelLayer.WLB i)
        {
            if (i != null)
            {
                ListViewItem item = this.list.SelectedItems[0];

                item.Text = i.SN;
                item.Tag = i;
                item.SubItems[1].Text = i.UID;
                item.SubItems[2].Text = i.CDT.ToString("yyyy-MM-dd HH:mm:ss");
                item.SubItems[3].Text = i.SK_Type.ToString();
                item.SubItems[4].Text = i.YD_Type.ToString();
                item.SubItems[5].Text = i.ZT_Type.ToString();
                item.SubItems[6].Text = i.CZ_RQ.ToString("yyyy-MM-dd");
                item.SubItems[7].Text = i.CZ_BC;
                item.SubItems[8].Text = i.CZ_CPH;
                item.SubItems[9].Text = i.CZ_DZ;
                item.SubItems[10].Text = i.CZ_SJ;
                item.SubItems[11].Text = i.HW_MC;
                item.SubItems[12].Text = i.HW_LX;
                item.SubItems[13].Text = i.HW_JS.ToString();
                item.SubItems[14].Text = i.HW_BJ.ToString("N2");
                item.SubItems[15].Text = i.FHR_Name;
                item.SubItems[16].Text = i.FHR_Mobile;
                item.SubItems[17].Text = i.FHR_Remark;
                item.SubItems[18].Text = i.JHR_Name;
                item.SubItems[19].Text = i.JHR_Mobile;
                item.SubItems[20].Text = i.JFZL.ToString("N2");
                item.SubItems[21].Text = i.JFTJ.ToString("N2");
                item.SubItems[22].Text = i.TYF.ToString("N2");
                item.SubItems[23].Text = i.BZF.ToString("N2");
                item.SubItems[24].Text = i.BXF.ToString("N2");
                item.SubItems[25].Text = i.Total.ToString("N2");
                item.SubItems[25].Text = i.Money.ToString("N2");
                item.SubItems[27].Text = i.FH_Code + "-" + i.FH_Name;
                item.SubItems[28].Text = i.JH_Code + "-" + i.JH_Name;
                item.SubItems[29].Text = i.BXD_SN;
            }
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();

            this.QueryDate = DateTime.MinValue.Date;
            this.QueryMode = WLCommon.QueryMode.Date;
            this.IsLogin = false;
        }

        #region 营运平台主窗口事件

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
                WLDataLogicLayer.Runtime.B_ConnectionClose();
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

                //初始化系统查询日期、运行配置及打印格式
                WLDataLogicLayer.Runtime.InitSystem(Properties.Settings.Default.AutoSyncServerDT);

                //检测是否自动登录，如果是则验证用户及密码是否正确
                if (Properties.Settings.Default.AutoLogin)
                {
                    if (WLDataLogicLayer.User.Validate(Properties.Settings.Default.Userid, Properties.Settings.Default.Password))
                    {
                        this.Login(Properties.Settings.Default.Userid); return;
                    }
                    else { /*如果用户验证失败！*/ }
                }

                this.miLogin_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region 系统管理菜单事件

        private void miManagement_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                this.miSetting.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miPrintFormat.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miNodeManagement.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miAuthorizeManagement.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miUserManagement.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miBillManagement.Enabled = this.IsLogin;
                this.miYF.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miBZFLB.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miHWLXB.Enabled = this.IsLogin;
                this.miBZXXB.Enabled = this.IsLogin;
                this.miMapping.Enabled = this.IsLogin;
                this.miCustomerManagement.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miResetPassword.Enabled = this.IsLogin;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miClientSetting_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClientSettingForm clientSettingForm = new ClientSettingForm())
                {
                    clientSettingForm.ConfirmClose = Properties.Settings.Default.ConfirmClose;
                    clientSettingForm.AutoSyncServerDT = Properties.Settings.Default.AutoSyncServerDT;
                    clientSettingForm.PingEnabled = Properties.Settings.Default.PingEnabled;
                    clientSettingForm.PingTimeout = Properties.Settings.Default.PingTimeout;
                    clientSettingForm.AutoLogin = Properties.Settings.Default.AutoLogin;
                    clientSettingForm.Userid = Properties.Settings.Default.Userid;
                    clientSettingForm.Password = Properties.Settings.Default.Password;
                    clientSettingForm.PageWidth = Properties.Settings.Default.PageWidth;
                    clientSettingForm.PageHeight = Properties.Settings.Default.PageHeight;
                    clientSettingForm.PageOffsetX = Properties.Settings.Default.PageOffsetX;
                    clientSettingForm.PageOffsetY = Properties.Settings.Default.PageOffsetY;
                    clientSettingForm.QueryDateListLength = Properties.Settings.Default.QueryDateListLength;
                    if (clientSettingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Properties.Settings.Default.ConfirmClose = clientSettingForm.ConfirmClose;
                        Properties.Settings.Default.AutoSyncServerDT = clientSettingForm.AutoSyncServerDT;
                        Properties.Settings.Default.PingEnabled = clientSettingForm.PingEnabled;
                        Properties.Settings.Default.PingTimeout = clientSettingForm.PingTimeout;
                        Properties.Settings.Default.AutoLogin = clientSettingForm.AutoLogin;
                        Properties.Settings.Default.Userid = clientSettingForm.Userid;
                        Properties.Settings.Default.Password = clientSettingForm.Password;
                        Properties.Settings.Default.PageWidth = clientSettingForm.PageWidth;
                        Properties.Settings.Default.PageHeight = clientSettingForm.PageHeight;
                        Properties.Settings.Default.PageOffsetX = clientSettingForm.PageOffsetX;
                        Properties.Settings.Default.PageOffsetY = clientSettingForm.PageOffsetY;
                        Properties.Settings.Default.QueryDateListLength = clientSettingForm.QueryDateListLength;

                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miSetting_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.BaseSettingForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miPrintFormat_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.Management.PrintFormatForm printFormatForm = new WLCommon.Management.PrintFormatForm())
                {
                    printFormatForm.PageWidth = Properties.Settings.Default.PageWidth;
                    printFormatForm.PageHeight = Properties.Settings.Default.PageHeight;
                    printFormatForm.PageOffsetX = Properties.Settings.Default.PageOffsetX;
                    printFormatForm.PageOffsetY = Properties.Settings.Default.PageOffsetY;
                    if (printFormatForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        WLDataLogicLayer.PrintFormat.Init();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miNodeManagement_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.NodeForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miAuthorizeManagement_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.AuthorizeForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miUserManagement_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.UserForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miBillManagement_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.BillForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miYF_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.YFForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miBZFLB_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.BZFLForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miHWLXB_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.HWLXForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miBZXXB_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.BZXXForm.InitAndShowDialog();
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

        private void miCustomerManagement_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Management.CustomerForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsLogin)
                {
                    switch (WLCommon.LogoutForm.InitAndShowDialog())
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

        #region 日常报表菜单事件

        private void miReports_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                this.miPayinRecord.Enabled = this.IsLogin;
                this.miGDRecord.Enabled = this.IsLogin;
                this.miFDRecord.Enabled = this.IsLogin;
                this.miAdvanceRecord.Enabled = this.IsLogin;
                this.miXCRecord.Enabled = this.IsLogin;
                this.miSHRecord.Enabled = this.IsLogin;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miPayinRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                {
                    selectDateForm.Dates = WLDataLogicLayer.Payin.GetDates(System.Data.SqlClient.SortOrder.Descending);
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_Payin.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.Payin.Reads(selectDateForm.SelectDate);
                            reportPrintForm.ParamTitle = string.Format("{0} 缴款记录", selectDateForm.SelectDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miGDRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                {
                    selectDateForm.Dates = WLDataLogicLayer.GDB.GetDates(System.Data.SqlClient.SortOrder.Descending);
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_GD.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.GDB.Reads(WLDataLogicLayer.Setting.NodeCode, selectDateForm.SelectDate);
                            reportPrintForm.ParamTitle = string.Format("{0} 改单记录", selectDateForm.SelectDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miFDRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                {
                    selectDateForm.Dates = WLDataLogicLayer.FDB.GetDates(System.Data.SqlClient.SortOrder.Descending);
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_FD.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.FDB.Reads(WLDataLogicLayer.Setting.NodeCode, selectDateForm.SelectDate);
                            reportPrintForm.ParamTitle = string.Format("{0} 废单记录", selectDateForm.SelectDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miAdvanceRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                {
                    selectDateForm.Dates = WLDataLogicLayer.WLB.GetDateList(WLDataLogicLayer.Setting.NodeCode, System.Data.SqlClient.SortOrder.Descending, 0);
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_YB.rdlc" })
                        {
                            reportPrintForm.DataSourceValue = WLDataLogicLayer.WLB.ReadLocalAdvanceRecord(WLDataLogicLayer.Setting.NodeCode, selectDateForm.SelectDate);
                            reportPrintForm.ParamTitle = string.Format("{0} 预办记录", selectDateForm.SelectDate.ToString("yyyy-MM-dd"));
                            reportPrintForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miXCRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                //{
                //    selectDateForm.Dates = WLDataLogicLayer.WLB.GetLocalXCDates();
                //    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //    {
                //        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                //        {
                //            reportForm.InitReport("XCRecord", "卸车记录", selectDateForm.SelectDate);
                //        }
                //    }
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miSHRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                //{
                //    selectDateForm.Dates = WLDataLogicLayer.WLB.GetLocalSHDates();
                //    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //    {
                //        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                //        {
                //            reportForm.InitReport("SHRecord", "取货记录", selectDateForm.SelectDate);
                //        }
                //    }
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

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

        #region 工具条按钮及菜单事件

        private void miQueryMode_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                this.cboQueryContent.DropDownStyle = ComboBoxStyle.Simple;
                this.cboQueryContent.Items.Clear();
                this.cboQueryContent.Text = string.Empty;
                this.cboQueryContent.Focus();
                switch (item.Name)
                {
                    case "miQueryModeSN":
                        this.btnQueryMode.Text = "运单编号：";
                        this.QueryMode = WLCommon.QueryMode.SN;
                        break;
                    case "miQueryModeFHRName":
                        this.btnQueryMode.Text = "发货人姓名：";
                        this.QueryMode = WLCommon.QueryMode.FHRName;
                        break;
                    case "miQueryModeFHRTel":
                        this.btnQueryMode.Text = "发货人电话：";
                        this.QueryMode = WLCommon.QueryMode.FHRTel;
                        break;
                    default:
                        this.btnQueryMode.Text = "办单日期：";
                        this.cboQueryContent.DropDownStyle = ComboBoxStyle.DropDownList;
                        this.QueryMode = WLCommon.QueryMode.Date;
                        break;
                }
            }
        }

        private void cboQueryContent_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (this.QueryMode == WLCommon.QueryMode.Date)                    //QueryDateListLength 默认值：15
                {
                    //保存日期
                    this.QueryDate = (this.cboQueryContent.Text == string.Empty) ? DateTime.MinValue.Date : Convert.ToDateTime(this.cboQueryContent.Text);

                    WLDataLogicLayer.WLB.RefreshDates(this.cboQueryContent.ComboBox, WLDataLogicLayer.Setting.NodeCode,
                        System.Data.SqlClient.SortOrder.Descending, Properties.Settings.Default.QueryDateListLength);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cboQueryContent_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (this.QueryMode == WLCommon.QueryMode.Date)
                {
                    if (this.cboQueryContent.SelectedIndex >= 0)
                    {
                        if (Convert.ToDateTime(this.cboQueryContent.Text) != this.QueryDate) this.list.Items.Clear();

                        this.list.Focus();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cboQueryContent.Text == string.Empty)
                {
                    this.cboQueryContent.Focus();
                    switch (this.QueryMode)
                    {
                        case WLCommon.QueryMode.SN:
                            MessageBox.Show("未指定运单编号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case WLCommon.QueryMode.FHRName:
                            MessageBox.Show("未指定发货人姓名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case WLCommon.QueryMode.FHRTel:
                            MessageBox.Show("未指定发货人电话！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        default:
                            MessageBox.Show("未指定办单日期！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else
                    this.RefreshLists(list, this.QueryMode, this.cboQueryContent.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化打印机页面
                WLCommon.PrintBill.Init(Properties.Settings.Default.PageWidth, Properties.Settings.Default.PageHeight);

                CreateForm.InitAndShowDialog(
                    Properties.Settings.Default.PingEnabled, Properties.Settings.Default.PingTimeout,
                    Properties.Settings.Default.PageOffsetX, Properties.Settings.Default.PageOffsetY);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.WLB item = this.GetListSelectedItem(true);
                using (EditForm editForm = new EditForm())
                {
                    editForm.Init(item);
                    if (editForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.UpdateListSelectedItem(WLDataLogicLayer.WLB.Change(editForm.Build(), item));
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.WLB item = this.GetListSelectedItem(true);
                using (ChangeForm changeForm = new ChangeForm())
                {
                    changeForm.Init(item);
                    if (changeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.UpdateListSelectedItem(changeForm.Build());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSyncCPH_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUserOver_Click(object sender, EventArgs e)
        {
            try
            {
                UserOverForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCreateDailySheet_Click(object sender, EventArgs e)
        {
            try
            {
                CreateDailySheetForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miUploadToCentral_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Central.UploadToCentralForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miConfirmLoaded_Click(object sender, EventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miConfirmUnload_Click(object sender, EventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miConfirmPickup_Click(object sender, EventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCentralQuery_Click(object sender, EventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        private void list_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0) this.btnChange_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnEdit.Enabled = this.list.SelectedItems.Count > 0;
                this.btnChange.Enabled = this.list.SelectedItems.Count > 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                this.miEdit.Enabled = this.list.SelectedItems.Count > 0;
                this.miChange.Enabled = this.list.SelectedItems.Count > 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
