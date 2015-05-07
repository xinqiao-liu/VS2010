using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace WLCheckout
{
    public partial class MainForm : Form
    {
        public bool IsLogin { get; set; }

        private void Logout()
        {
            try
            {
                WLDataLogicLayer.User.Logout();

                this.IsLogin = false;
                this.miLogin.Text = "用户登录(&L)";
                this.txtLoginState.ForeColor = Color.Gray;
                this.txtLoginState.Text = "未登录";

                this.AccountsClose();
            }
            catch (Exception ex) { throw new ApplicationException("登出发生异常：\r\n" + ex.Message); }
        }

        private void Login(string userid)
        {
            try
            {
                WLDataLogicLayer.User.Login(userid);

                this.IsLogin = true;
                this.miLogin.Text = "用户注销(&L)";
                this.txtLoginState.ForeColor = Color.Black;
                this.txtLoginState.Text = WLDataLogicLayer.User.LoginUser.ToString();
            }
            catch (Exception ex) { throw new ApplicationException("登录发生异常：\r\n" + ex.Message); }
        }

        private void AccountsClose()
        {
            this.Text = Properties.Settings.Default.SoftwareName;
            this.Tag = null;

            this.listHZ.Items.Clear();
            this.listHZ.Enabled = false;
            this.listMX.Items.Clear();
            this.listMX.Enabled = false;
        }

        private void AccountsOpen(WLDataModelLayer.ZDB item)
        {
            if (item is WLDataModelLayer.ZDB)
            {
                this.Text = Properties.Settings.Default.SoftwareName + " （ " + item.Name + " ）";
                this.Tag = item;

                WLDataLogicLayer.ZDHZB.Refresh(this.listHZ, item.Year, item.Month);                
            }
        }

        private WLDataModelLayer.ZDB GetAccountsData()
        {
            if (this.Tag is WLDataModelLayer.ZDB)
                return this.Tag as WLDataModelLayer.ZDB;
            else
                throw new ApplicationException("不存在打开账单！");
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

        private void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState != ConnectionState.Open)
            {
                this.txtConnectionState.Text = "关闭";
                this.txtConnectionState.ForeColor = Color.Gray;
            }
            else
            {
                this.txtConnectionState.Text = "开启";
                this.txtConnectionState.ForeColor = Color.Black;
            }
        }

        public MainForm()
        {
            this.IsLogin = false;
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
                WLDataLogicLayer.Runtime.B_ConnectionClose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.txtHint.Text = "技术支持：" + Properties.Settings.Default.TechnicalSupport;

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

        private void miClientSetting_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.ClientSettingForm clientSettingForm = new WLCommon.ClientSettingForm())
                {
                    clientSettingForm.ConfirmClose = Properties.Settings.Default.ConfirmClose;
                    clientSettingForm.AutoSyncServerDT = Properties.Settings.Default.AutoSyncServerDT;
                    clientSettingForm.PingEnabled = Properties.Settings.Default.PingEnabled;
                    clientSettingForm.PingTimeout = Properties.Settings.Default.PingTimeout;
                    clientSettingForm.AutoLogin = Properties.Settings.Default.AutoLogin;
                    clientSettingForm.Userid = Properties.Settings.Default.Userid;
                    clientSettingForm.Password = Properties.Settings.Default.Password;
                    clientSettingForm.RemovePrintTab();
                    if (clientSettingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Properties.Settings.Default.ConfirmClose = clientSettingForm.ConfirmClose;
                        Properties.Settings.Default.AutoSyncServerDT = clientSettingForm.AutoSyncServerDT;
                        Properties.Settings.Default.PingEnabled = clientSettingForm.PingEnabled;
                        Properties.Settings.Default.PingTimeout = clientSettingForm.PingTimeout;
                        Properties.Settings.Default.AutoLogin = clientSettingForm.AutoLogin;
                        Properties.Settings.Default.Userid = clientSettingForm.Userid;
                        Properties.Settings.Default.Password = clientSettingForm.Password;

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
                WLCommon.Checkout.CheckoutSettingForm.InitAndShowDialog();
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
                WLCommon.Checkout.JZDMForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCSXXB_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Checkout.CSXXForm.InitAndShowDialog(string.Empty);
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

        private void miAccountNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.Checkout.AccountsNewForm accountNewForm = new WLCommon.Checkout.AccountsNewForm())
                {
                    if (accountNewForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.AccountsOpen(accountNewForm.Accounts);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miAccountOpen_Click(object sender, EventArgs e)
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

        private void miAccountDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.Checkout.AccountsOpenForm accountsOpenForm = new WLCommon.Checkout.AccountsOpenForm())
                {
                    accountsOpenForm.Text = "删除账单";
                    if (accountsOpenForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //检测所删除账单是否打开，如打开先关闭
                        if (this.Tag is WLDataModelLayer.ZDB && accountsOpenForm.Accounts.Equals(this.Tag)) 
                            this.AccountsClose();

                        WLDataLogicLayer.ZDB.Delete(accountsOpenForm.Accounts);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miAccountClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.AccountsClose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miYDView_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listMX.SelectedItems.Count > 0)
                {
                    WLCommon.Checkout.YDViewForm.InitAndShowDialog(this.GetAccountMXItem().CPH, this.GetAccountsData().SDT, this.GetAccountsData().EDT);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miPrint_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                {
                    ToolStripMenuItem mi = sender as ToolStripMenuItem;
                    WLDataModelLayer.ZDB zditem = this.GetAccountsData();

                    if (zditem is WLDataModelLayer.ZDB)
                    {
                        switch (mi.Name)
                        {
                            case "miPrintHZ":
                                reportForm.InitReport("PrintAccount", zditem.Name, zditem.Year, zditem.Month);
                                break;
                            case "miPrintMX":
                                WLDataModelLayer.ZDHZB hzItem = this.GetAccountHZItem();
                                if (hzItem == null)
                                    throw new NullReferenceException("选择账单汇总项数据无效，无法打印该项明细！");

                                reportForm.InitReport("PrintDetail", zditem.Name + "-" + hzItem.Code + " 明细表", hzItem.Year, hzItem.Month, hzItem.Code);
                                break;
                            default: break;
                        }
                    }
                    else throw new NullReferenceException("账单信息为空，无法打印该账单汇总！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

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

        private void miFind_Click(object sender, EventArgs e)
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

        private void miRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.AccountsOpen(this.GetAccountsData());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCollectByWD_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.QueryRangeForm queryRangeForm = new WLCommon.QueryRangeForm())
                {
                    List<DateTime> items = WLDataLogicLayer.WLB.GetLocalAllDates(System.Data.SqlClient.SortOrder.Descending);
                    if (items.Count > 0)
                    {
                        queryRangeForm.MinDate = items[items.Count - 1];
                        queryRangeForm.MaxDate = items[0];
                        if (queryRangeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                            {
                                reportForm.InitReport("CollectByWD", "按网点汇总表", queryRangeForm.MinDate, queryRangeForm.MaxDate);
                            }
                        }
                    }
                    else throw new ApplicationException("不存在可汇总数据！");
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
                    List<DateTime> items = WLDataLogicLayer.WLB.GetLocalAllDates(System.Data.SqlClient.SortOrder.Descending);
                    if (items.Count > 0)
                    {
                        queryRangeForm.MinDate = items[items.Count - 1];
                        queryRangeForm.MaxDate = items[0];
                        if (queryRangeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                            {
                                reportForm.InitReport("CollectByCP", "按车牌汇总表", queryRangeForm.MinDate, queryRangeForm.MaxDate);
                            }
                        }
                    }
                    else throw new ApplicationException("不存在可汇总数据！");
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
                    List<DateTime> items = WLDataLogicLayer.WLB.GetLocalAllDates(System.Data.SqlClient.SortOrder.Descending);
                    if (items.Count > 0)
                    {
                        queryRangeForm.MinDate = items[items.Count - 1];
                        queryRangeForm.MaxDate = items[0];
                        if (queryRangeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                            {
                                reportForm.InitReport("CollectByXL", "按线路汇总表", queryRangeForm.MinDate, queryRangeForm.MaxDate);
                            }
                        }
                    }
                    else throw new ApplicationException("不存在可汇总数据！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
      
        private void miDaySummary_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                {
                    selectDateForm.Dates = WLDataLogicLayer.DailySheet.GetDates(System.Data.SqlClient.SortOrder.Descending);
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                        {
                            reportForm.InitReport("DaySummary", "日报表", selectDateForm.SelectDate);
                        }
                    }
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

        private void miSystem_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                this.miSetting.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miMapping.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miJZDMB.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miCSXXB.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miResetPassword.Enabled = this.IsLogin;

                this.miAccountNew.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miAccountOpen.Enabled = this.IsLogin;
                this.miAccountDelete.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miAccountClose.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB);
                this.miYDView.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB) && this.listMX.SelectedItems.Count > 0;
                this.miPrintHZ.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB) && this.listHZ.Items.Count > 0;
                this.miPrintMX.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB) && this.listMX.Items.Count > 0;
                this.miExportHZ.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB) && this.listHZ.Items.Count > 0;
                this.miExportMX.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB) && this.listMX.Items.Count > 0;
                this.miFind.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB);
                this.miRefresh.Enabled = this.IsLogin && (this.Tag is WLDataModelLayer.ZDB);

                this.miCollectByWD.Enabled = this.IsLogin;
                this.miCollectByCP.Enabled = this.IsLogin;
                this.miCollectByXL.Enabled = this.IsLogin;
                this.miDaySummary.Enabled = this.IsLogin;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listHZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.listHZ.SelectedItems.Count > 0)
                {
                    WLDataModelLayer.ZDHZB item = this.GetAccountHZItem();
                    WLDataLogicLayer.ZDMXB.Refresh(this.listMX, item.Year, item.Month, item.Code);
                }
            }
            catch (Exception ex) { this.listMX.Items.Clear(); this.listMX.Enabled = false; MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
