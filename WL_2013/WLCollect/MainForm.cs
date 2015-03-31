using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace WLCollect
{
    public enum DateRange { 昨日, 结账, 全部 };

    /// <summary>
    /// 用于各网点运单数据汇总合并到结账数据库
    /// 1、使用 WLService Web服务用于各网点数据获取
    /// 2、使用 WLData* 类库完成数据汇总合并
    /// </summary>
    public partial class MainForm : Form
    {
        private bool IsLogin { get; set; }
        private DateTime MaxDate { get; set; }
        private DateTime MinDate { get; set; }
        private DateRange DateRange { get; set; }

        #region WLService WEB服务关联函数

        //根据网点代码刷新汇总列表
        private void RefreshCollectList(string nodecode, DateTime minDate, DateTime maxDate)
        {
            using (WLBServiceReference.WLBServiceSoapClient client = new WLBServiceReference.WLBServiceSoapClient())
            {
                this.lstCollectItems.Items.Clear();
                foreach (WLBServiceReference.CollectByDateRange collectItem in client.GetCollectByDateRange(nodecode, minDate, maxDate))
                {
                    ListViewItem item = new ListViewItem(collectItem.Date.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(collectItem.Counts.ToString());
                    item.SubItems.Add(collectItem.Packages.ToString());
                    item.SubItems.Add(collectItem.Total.ToString("N2"));
                    this.lstCollectItems.Items.Add(item);
                }
            }
        }

        //根据网点代码、办单日期获取汇总记录
        private List<WLDataModelLayer.WLB> ReadByDate(string nodecode, DateTime date)
        {
            using (WLBServiceReference.WLBServiceSoapClient client = new WLBServiceReference.WLBServiceSoapClient())
            {
                List<WLDataModelLayer.WLB> list = new List<WLDataModelLayer.WLB>();
                foreach (WLBServiceReference.WLB item in client.ReadByDate(nodecode, date))
                {
                    list.Add(ConvertToWLB(item));
                }
                return list;
            }
        }

        //获取数据最小日期
        private DateTime GetMinDate(string nodecode)
        {
            using (WLBServiceReference.WLBServiceSoapClient client = new WLBServiceReference.WLBServiceSoapClient())
            {
                return client.GetMinDate(nodecode);
            }
        }

        //获取数据最大日期
        private DateTime GetMaxDate(string nodecode)
        {
            using (WLBServiceReference.WLBServiceSoapClient client = new WLBServiceReference.WLBServiceSoapClient())
            {
                return client.GetMaxDate(nodecode);
            }            
        }

        //转换Web服务WLB类到本地WLB类
        private WLDataModelLayer.WLB ConvertToWLB(WLBServiceReference.WLB webItem)
        {
            if (webItem == null) return null;

            WLDataModelLayer.WLB item = new WLDataModelLayer.WLB();

            item.Node = webItem.Node;
            item.Date =webItem.Date;
            item.SN = webItem.SN;
            item.UID = webItem.UID;
            item.CDT = webItem.CDT;

            item.SK_Type = (WLDataModelLayer.SKType)Enum.Parse(typeof(WLDataModelLayer.SKType), webItem.SK_Type.ToString());
            item.YD_Type = (WLDataModelLayer.YDType)Enum.Parse(typeof(WLDataModelLayer.YDType), webItem.YD_Type.ToString());
            item.ZT_Type = (WLDataModelLayer.ZTType)Enum.Parse(typeof(WLDataModelLayer.ZTType), webItem.ZT_Type.ToString());

            item.FH_Code = webItem.FH_Code;
            item.FH_Name = webItem.FH_Name;
            item.FH_CityName = webItem.FH_CityName;
            item.JH_Code = webItem.JH_Code;
            item.JH_Name = webItem.JH_Name;

            item.CZ_RQ = webItem.CZ_RQ;
            item.CZ_DZ = webItem.CZ_DZ;
            item.CZ_CPH = webItem.CZ_CPH;
            item.CZ_BC = webItem.CZ_BC;
            item.CZ_SJ = webItem.CZ_SJ;
            item.CZ_LC = webItem.CZ_LC;
            item.CZ_YX = webItem.CZ_YX;

            item.HW_MC = webItem.HW_MC;
            item.HW_LX = webItem.HW_LX;
            item.HW_JS = webItem.HW_JS;
            item.HW_BJ = webItem.HW_BJ;

            item.FHR_Name = webItem.FHR_Name;
            item.FHR_Mobile = webItem.FHR_Mobile;
            item.FHR_Remark = webItem.FHR_Remark;
            item.JHR_Name = webItem.JHR_Name;
            item.JHR_Mobile = webItem.JHR_Mobile;

            item.JFZL = webItem.JFZL;
            item.JFTJ = webItem.JFTJ;
            item.TYF = webItem.TYF;
            item.BZF = webItem.BZF;
            item.BXF = webItem.BXF;
            item.Total = webItem.Total;
            item.Money = webItem.Money;

            item.BXD_SN = webItem.BXD_SN;
            item.Freeze = webItem.Freeze;
            item.Synced = webItem.Synced;
            item.Sets = webItem.Sets;

            return item;        
        }

        //获取网点日报
        private WLDataModelLayer.DailyReport GetDailySheet(string nodecode, DateTime date)
        {
            using (DailySheetServiceReference.DailySheetServiceSoapClient client = new DailySheetServiceReference.DailySheetServiceSoapClient())
            {
                return this.ConvertToDailySheet(client.GetDailySheet(nodecode, date));
            }            
        }

        //转换Web服务DailySheet类到本地DailySheet类
        private WLDataModelLayer.DailyReport ConvertToDailySheet(DailySheetServiceReference.DailySheet webItem)
        {
            if (webItem == null) return null;

            WLDataModelLayer.DailyReport item = new WLDataModelLayer.DailyReport();
            item.Date = webItem.Date;
            item.NodeCode = webItem.NodeCode;
            item.NodeName = webItem.NodeName;
            item.Counts1 = webItem.Counts1;
            item.Packages1 = webItem.Packages1;
            item.Total1 = webItem.Total1;
            item.Counts2 = webItem.Counts2;
            item.Packages2 = webItem.Packages2;
            item.Total2 = webItem.Total2;
            item.UID = webItem.UID;
            item.CDT = webItem.CDT;
            return item;
        }

        #endregion

        #region WLData*类库关联函数

        //刷新网点列表
        private void RefreshKYZList()
        {
            this.cboKYZList.Items.Clear();
            foreach (WLDataModelLayer.Node item in WLDataLogicLayer.Node.Reads(true))
            {
                this.cboKYZList.Items.Add(item);
            }
        }

        //插入运单记录
        private void InsertWLBItems(List<WLDataModelLayer.WLB> items, DateTime date)
        {
            try
            {
                this.toolStripProgressBar.Maximum = items.Count;
                this.toolStripProgressBar.Value = 0;
                this.toolStripProgressBar.Step = 1;
                this.toolStripProgressBar.Visible = true;

                foreach (WLDataModelLayer.WLB item in items)
                {
                    this.toolStripProgressBar.PerformStep();

                    //检测是否导入废单，如果不导入废单且当前导入项为废单则不导入
                    if (!Properties.Settings.Default.CollectFD && item.ZT_Type == WLDataModelLayer.ZTType.作废) continue;
                    else
                    {
                        if (WLDataLogicLayer.WLB.Exists(item))
                            WLDataLogicLayer.WLB.Update(item);
                        else
                            WLDataLogicLayer.WLB.Insert(item);
                    }
                }
                this.AddMsg("汇总指定网点 " + date.ToString("yyyy-MM-dd") + " -> " + items.Count.ToString() + " 条记录。");
            }
            catch (Exception ex) 
            { 
                this.AddMsg("汇总指定网点 " + date.ToString("yyyy-MM-dd") + " -> 异常：" + ex.Message); 
            }
            finally { this.toolStripProgressBar.Visible = false; }
        }

        private void InsertDailySheet(WLDataModelLayer.DailyReport item, DateTime date)
        {
            if (!Properties.Settings.Default.ImportDailySheet) return;

            try
            {
                if (item != null)
                {
                    if (WLDataLogicLayer.DailyReport.Exists(item))
                        WLDataLogicLayer.DailyReport.Update(item);
                    else
                        WLDataLogicLayer.DailyReport.Insert(item);

                    this.AddMsg("导入指定网点 " + date.ToString("yyyy-MM-dd") + " -> 日报表成功。");
                }
                else
                    throw new ApplicationException("日报表未创建！");
            }
            catch (Exception ex)
            {
                this.AddMsg("导入指定网点 " + date.ToString("yyyy-MM-dd") + " -> 日报表异常：" + ex.Message);
            }
        }

        #endregion

        private void AddMsg(string msg)
        {
            this.lstMsg.Items.Add(msg);
        }

        private void Check(DateTime minDate, DateTime maxDate)
        {
            //检查是否已选择网点
            if (this.cboKYZList.SelectedIndex < 0)
                throw new ApplicationException("未选择网点！");
            if (!(this.cboKYZList.SelectedItem is WLDataModelLayer.Node))
                throw new ApplicationException("网点数据无效！");

            //检查日期范围是否正确（未大于MaxDate及未小于MinDate）
            if (minDate != DateTime.MaxValue && maxDate != DateTime.MaxValue)
            {
                if (minDate > maxDate) throw new ApplicationException("起始日期不能大于截止日期！");
                if (minDate < this.MinDate) throw new ApplicationException("起始日期不能小于 " + this.MinDate.ToString("yyyy-MM-dd") + " ！");
                if (minDate > this.MaxDate) throw new ApplicationException("起始日期不能大于 " + this.MaxDate.ToString("yyyy-MM-dd") + " ！");
                if (maxDate < this.MinDate) throw new ApplicationException("截止日期不能小于 " + this.MinDate.ToString("yyyy-MM-dd") + " ！");
                if (maxDate > this.MaxDate) throw new ApplicationException("截止日期不能大于 " + this.MaxDate.ToString("yyyy-MM-dd") + " ！");
            }
        }

        private void Logout()
        {
            try
            {
                WLDataLogicLayer.User.Logout();

                this.IsLogin = false;
                this.txtLoginState.ForeColor = Color.Red;
                this.txtLoginState.Text = "双击登录";
                this.toolStrip.Enabled = false;
            }
            catch (Exception ex) { throw new ApplicationException("登出发生异常：" + ex.Message); }
        }

        private void Login(string userid)
        {
            try
            {
                WLDataLogicLayer.User.Login(userid);

                this.IsLogin = true;
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
                this.txtLoginState.Enabled = false;
                this.toolStrip.Enabled = false;
            }
            else
            {
                this.txtConnectionState.Text = "开启";
                this.txtConnectionState.ForeColor = Color.Green;
                this.txtLoginState.Enabled = true;
                this.toolStrip.Enabled = this.IsLogin;
            }
        }

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
                WLDataLogicLayer.Runtime.B_ConnectionClose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.DateRange = WLCollect.DateRange.全部;                
                this.txtHint.Text = "（" + Properties.Settings.Default.SoftwareVersion + "）    技术支持：" + Properties.Settings.Default.TechnicalSupport;

                //初始化基础数据连接
                WLDataLogicLayer.Runtime.B_ConnectionInit(
                    ConfigurationManager.ConnectionStrings["connStr_b"].ConnectionString, 
                    new StateChangeEventHandler(ConnectionStateChange),
                    Properties.Settings.Default.PingEnabled, 
                    Properties.Settings.Default.PingTimeout);

                //初始化系统查询日期、运行配置
                WLDataLogicLayer.Setting.Init();
                                
                //检测是否自动登录，如果是则验证用户及密码是否正确
                if (Properties.Settings.Default.AutoLogin)
                {
                    if (WLDataLogicLayer.User.Validate(Properties.Settings.Default.Userid, Properties.Settings.Default.Password))
                    {
                        this.Login(Properties.Settings.Default.Userid); return;
                    }
                    else { /*如果用户验证失败！*/ }
                }

                this.RefreshKYZList();
                this.txtLoginState_Click(sender, e);
                this.btnDateRange_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtLoginState_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsLogin)
                {
                    switch (WLCommon.LogoutForm.InitAndShowDialog())
                    {
                        case DialogResult.No:       this.Logout(); return;
                        case DialogResult.Yes:      this.Logout(); break;
                        case DialogResult.Cancel:   return;
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

        private void cboKYZList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cboKYZList.SelectedIndex >= 0 && this.cboKYZList.SelectedItem is WLDataModelLayer.Node)
                {
                    WLDataModelLayer.Node item = this.cboKYZList.SelectedItem as WLDataModelLayer.Node;

                    //根据结账配置初始化起始与截止日期
                    this.MinDate = this.GetMinDate(item.Code);
                    this.MaxDate = this.GetMaxDate(item.Code);
                    this.DateRange = WLCollect.DateRange.全部;
                    this.btnDateRange_Click(sender, e);

                    this.lstMsg.Items.Clear();
                    this.lstCollectItems.Items.Clear();
                    this.lstCollectItems.Focus();
                }
                else throw new ApplicationException("未选择网点或网点数据无效！");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDateRange_Click(object sender, EventArgs e)
        {
            try
            {
                //根据设定重置日期范围
                switch (this.DateRange)
                {
                    case WLCollect.DateRange.全部: 
                        this.txtMinDate.Text = DateTime.Now.AddDays(-1).Date.ToString("yyyy-MM-dd");
                        this.txtMaxDate.Text = DateTime.Now.AddDays(-1).Date.ToString("yyyy-MM-dd");
                        this.DateRange = WLCollect.DateRange.昨日;
                        break;
                    case WLCollect.DateRange.昨日:
                        DateTime minDate = Convert.ToDateTime(DateTime.Now.AddMonths(-1).ToString("yyyy-M-") + (WLDataLogicLayer.Setting.JZDay + 1).ToString());
                        DateTime maxDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-M-") + WLDataLogicLayer.Setting.JZDay.ToString());
                        //检查日期范围是否有效，非有效则使用数据最小、最大日期
                        if(minDate < this.MinDate)      this.txtMinDate.Text = this.MinDate.ToString("yyyy-MM-dd");
                        else                            this.txtMinDate.Text = minDate.ToString("yyyy-MM-dd");
                        if(maxDate > this.MaxDate)      this.txtMaxDate.Text = this.MaxDate.ToString("yyyy-MM-dd");
                        else                            this.txtMaxDate.Text = maxDate.ToString("yyyy-MM-dd");

                        this.DateRange = WLCollect.DateRange.结账;
                        break;
                    case WLCollect.DateRange.结账:
                        this.txtMinDate.Text = this.MinDate.ToString("yyyy-MM-dd");
                        this.txtMaxDate.Text = this.MaxDate.ToString("yyyy-MM-dd");
                        this.DateRange = WLCollect.DateRange.全部;
                        break;
                }
                this.btnDateRange.Text = this.DateRange.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //获取待汇总日期及相关信息列表
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {                
                DateTime minDate = Convert.ToDateTime(this.txtMinDate.Text);
                DateTime maxDate = Convert.ToDateTime(this.txtMaxDate.Text);

                this.Check(minDate, maxDate);
                this.RefreshCollectList((this.cboKYZList.SelectedItem as WLDataModelLayer.Node).Code, minDate, maxDate);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //全选
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            try
            {                
                for (int i = 0; i < this.lstCollectItems.Items.Count; i++)
                {
                    this.lstCollectItems.Items[i].Checked = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //全消
        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < this.lstCollectItems.Items.Count; i++)
                {
                    this.lstCollectItems.Items[i].Checked = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //汇总
        private void btnCollect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lstCollectItems.CheckedItems.Count <= 1) this.AddMsg("请先选择所要汇总数据！");

                this.Check(DateTime.MaxValue, DateTime.MaxValue);

                string nodecode = (this.cboKYZList.SelectedItem as WLDataModelLayer.Node).Code;               
                foreach (ListViewItem item in this.lstCollectItems.CheckedItems) 
                {                    
                    DateTime date = Convert.ToDateTime(item.Text);
                    this.InsertWLBItems(this.ReadByDate(nodecode, date), date);
                    this.InsertDailySheet(this.GetDailySheet(nodecode, date), date);

                    item.Checked = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //本地配置
        private void btnClientSetting_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClientSettingForm clientSettingForm = new ClientSettingForm())
                {
                    clientSettingForm.ConfirmClose = Properties.Settings.Default.ConfirmClose;
                    clientSettingForm.PingEnabled = Properties.Settings.Default.PingEnabled;
                    clientSettingForm.PingTimeout = Properties.Settings.Default.PingTimeout;
                    clientSettingForm.AutoLogin = Properties.Settings.Default.AutoLogin;
                    clientSettingForm.Userid = Properties.Settings.Default.Userid;
                    clientSettingForm.Password = Properties.Settings.Default.Password;
                    clientSettingForm.CollectFD = Properties.Settings.Default.CollectFD;
                    clientSettingForm.CreateDailySheet = Properties.Settings.Default.ImportDailySheet;
                    if (clientSettingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Properties.Settings.Default.ConfirmClose = clientSettingForm.ConfirmClose;
                        Properties.Settings.Default.PingEnabled = clientSettingForm.PingEnabled;
                        Properties.Settings.Default.PingTimeout = clientSettingForm.PingTimeout;
                        Properties.Settings.Default.AutoLogin = clientSettingForm.AutoLogin;
                        Properties.Settings.Default.Userid = clientSettingForm.Userid;
                        Properties.Settings.Default.Password = clientSettingForm.Password;
                        Properties.Settings.Default.CollectFD = clientSettingForm.CollectFD;
                        Properties.Settings.Default.ImportDailySheet = clientSettingForm.CreateDailySheet;

                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
