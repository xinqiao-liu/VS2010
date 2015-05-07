using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace WLManager
{
    public partial class MainForm : Form
    {
        private bool IsLogin { get; set; }
        private string FindKeyword { get; set; }
        private string FindContent { get; set; }

        private void Logout()
        {
            try
            {
                WLDataLogicLayer.User.Logout();

                this.IsLogin = false;
                this.miLogin.Text = "用户登录(&L)";
                this.txtLoginState.ForeColor = Color.Gray;
                this.txtLoginState.Text = "未登录";
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
                this.txtLoginState.ForeColor = Color.Black;
                this.txtLoginState.Text = WLDataLogicLayer.User.LoginUser.ToString();
            }
            catch (Exception ex) { throw new ApplicationException("登录发生异常：" + ex.Message); }
        }

        public void RefreshLists(ListView list, string keyword, string content)
        {
            switch (keyword)
            {
                case "RQ":
                    WLDataLogicLayer.WLB.RefreshLocalByDateOrCZRQ(list, WLDataLogicLayer.Setting.NodeCode, Convert.ToDateTime(content));
                    break;
                case "SN":
                    WLDataLogicLayer.WLB.RefreshLocalBySN(list, WLDataLogicLayer.Setting.NodeCode, WLDataModelLayer.Bill.Current(content, WLDataLogicLayer.Setting.BillZeroize, WLDataLogicLayer.Setting.BillBits));
                    break;
                case "FHR_Name":
                    WLDataLogicLayer.WLB.RefreshLocalByFHR_Name(list, WLDataLogicLayer.Setting.NodeCode, content);
                    break;
                case "FHR_Mobile":
                    WLDataLogicLayer.WLB.RefreshLocalByFHR_Mobile(list, WLDataLogicLayer.Setting.NodeCode, content);
                    break;
                default: break;
            }
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
            this.FindKeyword = string.Empty;
            this.FindContent = string.Empty;

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
                WLDataLogicLayer.Runtime.C_ConnectionClose();
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
                    Properties.Settings.Default.PingEnabled, Properties.Settings.Default.PingTimeout);

                //如指定为统一数据源，初始化汇总数据连接时使用与基础数据连接相同连接字符串，否则使用指定的汇总连接字符串
                WLDataLogicLayer.Runtime.UnifiedDataSource = Convert.ToBoolean(ConfigurationManager.AppSettings["UnifiedDataSource"]);
                if (WLDataLogicLayer.Runtime.UnifiedDataSource)
                {
                    WLDataLogicLayer.Runtime.C_ConnectionInit(
                        ConfigurationManager.ConnectionStrings["connStr_b"].ConnectionString, 
                        null,
                        Properties.Settings.Default.PingEnabled, Properties.Settings.Default.PingTimeout);
                }
                else
                {
                    WLDataLogicLayer.Runtime.C_ConnectionInit(
                        ConfigurationManager.ConnectionStrings["connStr_c"].ConnectionString, 
                        null,
                        Properties.Settings.Default.PingEnabled, Properties.Settings.Default.PingTimeout);
                }

                //初始化系统查询日期、运行配置及打印格式
                WLDataLogicLayer.Runtime.InitSystem(Properties.Settings.Default.AutoSyncServerDT);

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
                    clientSettingForm.PageWidth = Properties.Settings.Default.PageWidth;
                    clientSettingForm.PageHeight = Properties.Settings.Default.PageHeight;
                    clientSettingForm.PageOffsetX = Properties.Settings.Default.PageOffsetX;
                    clientSettingForm.PageOffsetY = Properties.Settings.Default.PageOffsetY;
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

        private void miManagement_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                this.miSetting.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miPrintFormat.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miNodeManagement.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miAuthorizeManagement.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miUserManagement.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
                this.miBillManagement.Enabled = this.IsLogin && WLDataLogicLayer.User.LoginUser.MP;
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

        private void miBD_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化打印机页面
                WLCommon.PrintBill.Init(Properties.Settings.Default.PageWidth, Properties.Settings.Default.PageHeight);

                WLCommon.Operation.YDCreateForm.InitAndShowDialog(
                    Properties.Settings.Default.PingEnabled, Properties.Settings.Default.PingTimeout,
                    Properties.Settings.Default.PageOffsetX, Properties.Settings.Default.PageOffsetY);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miFind_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.Operation.FindForm findForm = new WLCommon.Operation.FindForm())
                {
                    if (findForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.FindKeyword = findForm.Keyword;
                        this.FindContent = findForm.Content;

                        this.RefreshLists(list, this.FindKeyword, this.FindContent);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.WLB item = WLCommon.Operation.YDChangeForm.InitAndShowDialog(this.list.SelectedItems[0].Tag as WLDataModelLayer.WLB);
                if (item != null)
                    WLDataLogicLayer.WLB.UpdateLine(this.list.SelectedItems[0], item);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miClean_Click(object sender, EventArgs e)
        {
            this.FindKeyword = string.Empty;
            this.FindContent = string.Empty;

            this.list.Items.Clear();
        }

        private void miRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.RefreshLists(list, this.FindKeyword, this.FindContent);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miPayin_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Operation.PayinForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miUploadToCollect_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Operation.UploadToCollectForm.InitAndShowDialog();
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

        private void miEndOfDay_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Operation.EndOfDayForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miOperation_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                this.miBD.Enabled = this.IsLogin;
                this.miEdit.Enabled = this.IsLogin && this.list.SelectedItems.Count > 0;
                this.miFind.Enabled = this.IsLogin;
                this.miClean.Enabled = this.IsLogin && this.list.Items.Count > 0;
                this.miRefresh.Enabled = this.IsLogin && this.list.Items.Count > 0;
                this.miUpload.Enabled = this.IsLogin;
                this.miPayin.Enabled = this.IsLogin;
                this.miEndOfDay.Enabled = this.IsLogin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void miCentralManage_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Central.ManageForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCentralZC_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Central.ZCConfirmForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCentralXC_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Central.XCConfirmForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCentralQH_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Central.QHConfirmForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miCentralTrack_Click(object sender, EventArgs e)
        {
            try
            {
                WLCommon.Central.YDTrackForm.InitAndShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miNetworking_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                this.miCentralManage.Enabled = this.IsLogin;
                this.miCentralZC.Enabled = this.IsLogin;
                this.miCentralXC.Enabled = this.IsLogin;
                this.miCentralQH.Enabled = this.IsLogin;
                this.miCentralTrack.Enabled = this.IsLogin;
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
                        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                        {
                            reportForm.InitReport("PayinRecord", "缴款记录", selectDateForm.SelectDate);
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
                        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                        {
                            reportForm.InitReport("GDRecord", "改单记录", selectDateForm.SelectDate);
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
                        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                        {
                            reportForm.InitReport("FDRecord", "废单记录", selectDateForm.SelectDate);
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
                    selectDateForm.Dates = WLDataLogicLayer.WLB.GetLocalAllDates(System.Data.SqlClient.SortOrder.Descending);
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                        {
                            reportForm.InitReport("YBRecord", "预办记录", selectDateForm.SelectDate);
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
                using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                {
                    selectDateForm.Dates = WLDataLogicLayer.WLB.GetLocalXCDates();
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                        {
                            reportForm.InitReport("XCRecord", "卸车记录", selectDateForm.SelectDate);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void miSHRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (WLCommon.SelectDateForm selectDateForm = new WLCommon.SelectDateForm())
                {
                    selectDateForm.Dates = WLDataLogicLayer.WLB.GetLocalSHDates();
                    if (selectDateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (WLCommon.ReportForm reportForm = new WLCommon.ReportForm())
                        {
                            reportForm.InitReport("SHRecord", "取货记录", selectDateForm.SelectDate);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

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

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0) this.miEdit_Click(sender, e);
        }
    }
}
