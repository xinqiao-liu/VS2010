using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KM.KYCheckTicket
{
    public partial class MainForm : Form
    {
        /*
        private Boolean m_Logged = false;
        private Boolean m_ShowAll = false;
        private StringBuilder m_KeyboardBuffer;
        private List<String> m_JPBCList;

        #region 公有属性

        public Boolean Logged
        {
            get { return m_Logged; }
            set
            {
                if (value)
                {
                    this.KeyPreview = true;

                    this.SettingButton.Enabled = KM.Common.Runtime.AllowSZ;
                    this.LoginButton.Text = "用户注销";
                    this.ResetPasswordButton.Enabled = KM.Common.Runtime.AllowSZ;
                    this.LockButton.Enabled = true;
                    this.JSButton.Enabled = KM.Common.Runtime.AllowJS;

                    this.ShowAllButton.Visible = Properties.Settings.Default.JPWindow != "全部";
                    this.ShowAllButton.Enabled = true;
                    this.RefreshBCButton.Enabled = true;

                    this.JPButton.Visible = KM.Common.Runtime.AllowJP;
                    this.TJButton.Visible = KM.Common.Runtime.AllowJP;

                    this.PHText.Enabled = true;
                    this.PHText.Focus();

                    this.BCList.Enabled = true;
                    this.WJList.Enabled = true;
                    this.YJList.Enabled = true;

                    this.ZWText.Text = KM.Common.Runtime.Fullname;
                    this.XMText.Text = KM.Common.Runtime.UID + "[" + KM.Common.Runtime.Name + "]";
                }
                else
                {
                    this.SettingButton.Enabled = false;
                    this.LoginButton.Text = "用户登录";
                    this.ResetPasswordButton.Enabled = false;
                    this.LockButton.Enabled = false;
                    this.JSButton.Enabled = false;

                    this.StartJPButton.Enabled = false;
                    this.ExitJPButton.Enabled = false;
                    this.JSPrintButton.Enabled = false;
                    this.ShowAllButton.Enabled = false;
                    this.RefreshBCButton.Enabled = false;

                    this.JPButton.Visible = false;
                    this.TJButton.Visible = false;

                    this.PHText.Text = String.Empty;
                    this.PHText.Enabled = false;

                    this.BCList.Items.Clear();
                    this.BCList.Enabled = false;
                    this.BCGroupBox.Text = "待检班次：0  检票检票：0";
                    this.WJList.Items.Clear();
                    this.WJList.Enabled = false;
                    this.WJGroupBox.Text = "未检客票：0";
                    this.YJList.Items.Clear();
                    this.YJList.Enabled = false;
                    this.YJGroupBox.Text = "已检客票：0";

                    this.ZWText.Text = String.Empty;
                    this.XMText.Text = String.Empty;

                    this.JPBCList.Clear();

                    this.KeyPreview = false;
                }
                m_Logged = value;
            }
        }

        public Boolean ShowAll
        {
            get { return m_ShowAll; }
            set { m_ShowAll = value; }
        }

        public List<String> JPBCList
        {
            get 
            {
                if (m_JPBCList == null)
                    m_JPBCList = new List<string>();
                return m_JPBCList; 
            }
            set { m_JPBCList = value; }
        }

        public StringBuilder KeyboardBuffer
        {
            get
            {
                if (m_KeyboardBuffer == null)
                    m_KeyboardBuffer = new StringBuilder();
                return m_KeyboardBuffer;
            }
            set { m_KeyboardBuffer = value; }
        }

        #endregion

        #region 私有方法

        private void OneConnection_StateChange(object sender, StateChangeEventArgs e)
        {
            switch (e.CurrentState)
            {
                case ConnectionState.Closed:
                    this.txtOneConnectionState.ForeColor = Color.Red;
                    this.txtOneConnectionState.Text = "断开";
                    break;
                case ConnectionState.Open:
                    this.txtOneConnectionState.ForeColor = Color.Green;
                    this.txtOneConnectionState.Text = "开启";
                    break;
                default:
                    this.txtOneConnectionState.ForeColor = Color.Gray;
                    this.txtOneConnectionState.Text = "其它";
                    break;
            }
        }

        private void TwoConnection_StateChange(object sender, StateChangeEventArgs e)
        {
            switch (e.CurrentState)
            {
                case ConnectionState.Closed:
                    this.txtTwoConnectionState.ForeColor = Color.Red;
                    this.txtTwoConnectionState.Text = "断开";
                    break;
                case ConnectionState.Open:
                    this.txtTwoConnectionState.ForeColor = Color.Green;
                    this.txtTwoConnectionState.Text = "开启";
                    break;
                default:
                    this.txtTwoConnectionState.ForeColor = Color.Gray;
                    this.txtTwoConnectionState.Text = "其它";
                    break;
            }
        }

        private void Login(String uid)
        {
            try
            {
                KM.Common.Runtime.InitUser(KM.Common.Connections.OneConnection, uid);

                if (KM.Common.Runtime.RunJP)
                {
                    this.Logged = true;
                    this.RefreshBC();
                }
                else
                    throw new ApplicationException("该用户无操作检票系统权限");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("登出发生异常：\r\n" + ex.Message);
            }
        }

        private void Logout()
        {
            try
            {
                this.Logged = false;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("登录发生异常：\r\n" + ex.Message);
            }
        }

        //刷新班次
        private void RefreshBC()
        {
            try
            {
                //最后更新 2011-04-25，支持本售异检票
                if (Properties.Settings.Default.EnableBSY_JP)
                    KM.Common.BSY_JP.RefreshBC(KM.Common.Connections.TwoConnection, KM.Common.Runtime.BM, this.BCList, this.JPBCList);
                else
                    KM.Common.JP.RefreshBC(KM.Common.Connections.OneConnection, this.BCList, this.JPBCList, this.ShowAll ? "全部" : Properties.Settings.Default.JPWindow);

                //检查进入检票班次列表，如果班次列表中不存在则清除
                for (int i = this.JPBCList.Count - 1; i >= 0; i--)
                {
                    if (!this.BCExists(this.JPBCList[i])) this.JPBCList.Remove(this.JPBCList[i]);
                }                    

                this.BCGroupBox.Text = "待检班次：" + this.BCList.Items.Count.ToString() + "  检票班次：" + this.JPBCList.Count.ToString();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("刷新班次发生异常：\r\n" + ex.Message);
            }
        }

        //2014-1-14 加入 zdz，用于区别热线
        //刷新客票
        private void RefreshCP(String cc, String fcsj, String zdz)
        {
            try
            {
                //最后更新 2011-04-25，支持本售异检票
                if (Properties.Settings.Default.EnableBSY_JP)
                {
                    //刷新未检客票
                    if (fcsj == "循环")
                        KM.Common.BSY_JP.RefreshCP(KM.Common.Connections.TwoConnection, KM.Common.Runtime.BM, this.WJList, "未定", " ");
                    else
                        KM.Common.BSY_JP.RefreshCP(KM.Common.Connections.TwoConnection, KM.Common.Runtime.BM, this.WJList, cc, " ");

                    //刷新已检客票
                    KM.Common.BSY_JP.RefreshCP(KM.Common.Connections.TwoConnection, KM.Common.Runtime.BM, this.YJList, cc, "J"); 
                }
                else
                {
                    //刷新未检客票
                    if (fcsj == "循环")
                        KM.Common.JP.RefreshCP(KM.Common.Connections.OneConnection, this.WJList, "未定", zdz, " ");
                    else
                        KM.Common.JP.RefreshCP(KM.Common.Connections.OneConnection, this.WJList, cc, zdz, " ");

                    //刷新已检客票
                    KM.Common.JP.RefreshCP(KM.Common.Connections.OneConnection, this.YJList, cc, zdz, "J");                    
                }

                this.WJGroupBox.Text = "未检客票：" + this.WJList.Items.Count.ToString();
                this.YJGroupBox.Text = "已检客票：" + this.YJList.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("刷新客票发生异常：\r\n" + ex.Message);
            }
        }

        private void ClearCP()
        {
            if (this.WJList.Items.Count > 0)
            {
                this.WJGroupBox.Text = "未检客票：0";
                this.WJList.Items.Clear();
            }
            if (this.YJList.Items.Count > 0)
            {
                this.YJGroupBox.Text = "已检客票：0";
                this.YJList.Items.Clear();
            }
        }

        //格式化票号
        public String FormatPH(String ph)
        {
            return String.Format("{0:D" + KM.Common.Runtime.PJWS.ToString() + "}", Convert.ToInt32(ph));
        }

        //是否存在指定检票班次
        private bool JPBCExists(string cc)
        {
            return this.JPBCList.Contains(cc);
        }

        //指定班次是否为当前检票班次
        private bool JPBCSelect(string cc)
        {
            if (this.BCList.SelectedItems.Count > 0 && this.BCList.SelectedItems[0].Text == "检票" && this.BCList.SelectedItems[0].SubItems[1].Text == cc)
                return true;
            else
                return false;
        }

        //检票列表是否存在指定班次
        private bool BCExists(string cc)
        {
            foreach (ListViewItem item in this.BCList.Items)
            {
                if (item.SubItems[1].Text == cc) return true;
            }
            return false;
        }

        //获取选择班次班次编号
        private string GetSelectBC_CC()
        {
            if (this.BCList.SelectedItems.Count > 0)
            {
                return this.BCList.SelectedItems[0].SubItems[1].Text;
            }
            return String.Empty;
        }

        private string GetSelectBC_ZDZ()
        {
            if (this.BCList.SelectedItems.Count > 0)
            {
                return this.BCList.SelectedItems[0].SubItems[2].Text;
            }
            return String.Empty;
        }

        //获取选择班次发车时间
        private string GetSelectBC_FCSJ()
        {
            if (this.BCList.SelectedItems.Count > 0)
            {
                return this.BCList.SelectedItems[0].SubItems[3].Text;
            }
            return String.Empty;
        }

        //获取指定班次发车时间
        private string GetBC_FCSJ(string cc)
        {
            for (int i = 0; i < this.BCList.Items.Count; i++)
            {
                if (this.BCList.Items[i].SubItems[1].Text == cc) return this.BCList.Items[i].SubItems[3].Text;
            }
            return string.Empty;
        }

        //检票，任何进入检票班次均可检票
        private void JP(String cc, String ph)
        {            
            try
            {
                //最后更新 2011-04-25，支持本售异检票
                if (Properties.Settings.Default.EnableBSY_JP)
                {
                    //1、检测客票是否存在
                    if (!KM.Common.JP.CPExists(KM.Common.Connections.TwoConnection, ph)) throw new ApplicationException("客票 " + ph + " 无效！");

                    //2、检测客票是否为热线票，如果是则检查班次是否热线班次
                    if (KM.Common.JP.IsHotCP(KM.Common.Connections.TwoConnection, ph))
                    {
                        if (!this.JPBCExists(cc) || !KM.Common.JP.IsHotBC(KM.Common.Connections.TwoConnection, cc)) throw new ApplicationException("检热线客票须指定热线班次！");

                        KM.Common.BSY_JP.TransactJP(KM.Common.Connections.TwoConnection, cc, ph, 0);
                    }
                    else
                    {
                        String cp_cc = KM.Common.JP.GetCPCC(KM.Common.Connections.TwoConnection, ph);

                        //3、获取客票班次，检测该班次是否开始检票
                        if (!this.JPBCExists(cp_cc)) throw new ApplicationException("客票 " + ph + " 班次非检票班次");

                        //4、检票
                        KM.Common.BSY_JP.TransactJP(KM.Common.Connections.TwoConnection, cp_cc, ph, 0);

                        //5、语音提示检票成功
                        if (Properties.Settings.Default.EnableSound) KM.Common.Speach.Play("检票成功");
                    }
                }
                else
                {
                    //1、检测客票是否存在
                    if (!KM.Common.JP.CPExists(KM.Common.Connections.OneConnection, ph)) throw new ApplicationException("客票 " + ph + " 无效！");

                    //2、检测客票是否为热线票，如果是则检查班次是否热线班次
                    if (KM.Common.JP.IsHotCP(KM.Common.Connections.OneConnection, ph))
                    {
                        //if (cc == String.Empty || !KM.Common.JP.IsHotBC(KM.Common.Connections.OneConnection, cc)) throw new ApplicationException("检热线客票须指定热线班次！");
                        if (!this.JPBCExists(cc) || !KM.Common.JP.IsHotBC(KM.Common.Connections.OneConnection, cc)) throw new ApplicationException("检热线客票须指定热线班次！");

                        KM.Common.JP.TransactJP(KM.Common.Connections.OneConnection, cc, ph, 0);
                    }
                    else
                    {
                        String cp_cc = KM.Common.JP.GetCPCC(KM.Common.Connections.OneConnection, ph);

                        //3、获取客票班次，检测该班次是否开始检票
                        if (!this.JPBCExists(cp_cc)) throw new ApplicationException("客票 " + ph + " 班次非检票班次");

                        //4、检票
                        KM.Common.JP.TransactJP(KM.Common.Connections.OneConnection, cp_cc, ph, 0);

                        //5、语音提示检票成功
                        if (Properties.Settings.Default.EnableSound) KM.Common.Speach.Play("检票成功");
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.EnableSound) KM.Common.Speach.Play ("检票失败");
                throw ex;
            }
        }

        //初始化
        private void Init()
        {
            this.PHText.MaxLength = KM.Common.Runtime.PJWS;

            this.ShowAllButton.Visible = Properties.Settings.Default.JPWindow != "全部";

            //最后更新 2011-04-25 确定检票口
            if (Properties.Settings.Default.EnableBSY_JP)
            {
                this.JPWindowText.Text = "全部";
                this.JPBCList.Clear();
            }
            else
            {
                if (this.JPWindowText.Text != Properties.Settings.Default.JPWindow)
                {
                    this.JPWindowText.Text = Properties.Settings.Default.JPWindow;
                    this.JPBCList.Clear();
                }
            }

            //配置待见班次自动刷新
            this.BCResreshTimer.Enabled = Properties.Settings.Default.BCAutoRefresh;
            this.BCResreshTimer.Interval = Properties.Settings.Default.BCRefreshTime * 1000;
        }

        #endregion
        */

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    if (Properties.Settings.Default.ShowConfirm && KM.Common.MessageDialog.Show( "确认", "是否退出系统？", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0) == DialogResult.Yes)
            //    {              
            //    }
            //    else
            //        e.Cancel = true;
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("窗口关闭异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    switch (e.KeyCode)
            //    {
            //        case Keys.NumPad0:
            //        case Keys.NumPad1:
            //        case Keys.NumPad2:
            //        case Keys.NumPad3:
            //        case Keys.NumPad4:
            //        case Keys.NumPad5:
            //        case Keys.NumPad6:
            //        case Keys.NumPad7:
            //        case Keys.NumPad8:
            //        case Keys.NumPad9:
            //            this.KeyboardBuffer.Append(Convert.ToChar(e.KeyValue - 48));
            //            break;
            //        case Keys.D0:
            //        case Keys.D1:
            //        case Keys.D2:
            //        case Keys.D3:
            //        case Keys.D4:
            //        case Keys.D5:
            //        case Keys.D6:
            //        case Keys.D7:
            //        case Keys.D8:
            //        case Keys.D9:
            //            this.KeyboardBuffer.Append(Convert.ToChar(e.KeyValue));
            //            break;
            //        case Keys.Enter:
            //            if (this.KeyboardBuffer.Length == KM.Common.Runtime.PJWS)
            //            {
            //                this.PHText.Text = this.KeyboardBuffer.ToString();
            //                this.PHText_KeyUp(sender, new KeyEventArgs(Keys.Enter));
            //            }

            //            if (this.KeyboardBuffer.Length > 0) this.KeyboardBuffer.Remove(0, this.KeyboardBuffer.Length);
            //            break;
            //        default:
            //            if (this.KeyboardBuffer.Length > 0) this.KeyboardBuffer.Remove(0, this.KeyboardBuffer.Length);
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("窗口键盘异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Logged = false;

            //    KM.Common.Connections.InitOneConnection(Properties.Settings.Default.OneConnectionString, new StateChangeEventHandler(OneConnection_StateChange));
            //    KM.Common.Runtime.InitEnvironment(KM.Common.Connections.OneConnection, Properties.Settings.Default.SyncServerTime);

            //    //2011-04-25 如果开启本售异检票，则开启辅数据连接
            //    if (Properties.Settings.Default.EnableBSY_JP)
            //    {
            //        KM.Common.Connections.InitOneConnection(Properties.Settings.Default.OneConnectionString, new StateChangeEventHandler(TwoConnection_StateChange));
            //    }

            //    this.Init();
            //    this.CopyrightInfo.Text = "长春市公路客运总站-触摸检票 （版本：2011.5）";
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("窗口打开异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //try
            //{
            //    if (KM.Common.Connections.OneConnectionState == ConnectionState.Open)
            //    {
            //        //最后更新 2011-04-25，完成授权代码
            //        //授权验证，>= 0代表授权有效，< 0代表授权过期
            //        //Properties.Settings.Default.EV 提前提示天数
            //        //注：读表异常也将提示授权已过期
            //        int ev = KM.Common.EV.Check(KM.Common.Connections.OneConnection);
            //        if (ev < 0)
            //        {
            //            this.LoginButton.Enabled = false;
            //            this.ConnectionSettingButton.Enabled = false;

            //            throw new ApplicationException("授权已过期！\r\n\r\n请尽快与长春客运总站业务处联系。");
            //        }
            //        else
            //        {
            //            if (ev < Properties.Settings.Default.EV)
            //            {
            //                String msg = "授权到期仅剩 " + ev.ToString() + " 天，\r\n到期后将不能使用！\r\n\r\n请尽快与长春客运总站业务处联系。";
            //                KM.Common.MessageDialog.Show("警告", msg, MessageBoxButtons.OK, MessageBoxIcon.Warning, 0);
            //            }

            //            this.LoginButton_Click(sender, e);
            //        }
            //    }
            //    else
            //        this.LoginButton.Enabled = false;
            //}
            //catch (Exception ex)
            //{
            //    KM.Common.MessageDialog.Show("错误", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 0);
            //}
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                this.Close();
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void ConnectionSettingButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Properties.Settings.Default.ShowConfirm && KM.Common.MessageDialog.Show("确认", "是否进入连接配置？", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0) == DialogResult.No)
            //        return;

            //    using (KM.Common.ConnectionDialog connectionDialog = new KM.Common.ConnectionDialog())
            //    {
            //        connectionDialog.OneConnectionString = Properties.Settings.Default.OneConnectionString;

            //        //2011-04-25 如果开启本售异检票，则允许配置辅数据连接
            //        if (Properties.Settings.Default.EnableBSY_JP)
            //        {
            //            connectionDialog.TwoConnectionString = Properties.Settings.Default.TwoConnectionString;
            //        }

            //        if (connectionDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            this.Logged = false;

            //            if (connectionDialog.OneConnectionString != String.Empty && connectionDialog.OneConnectionString != Properties.Settings.Default.OneConnectionString)
            //            {
            //                KM.Common.Connections.InitOneConnection(connectionDialog.OneConnectionString, new StateChangeEventHandler(OneConnection_StateChange));
            //                KM.Common.Runtime.InitEnvironment(KM.Common.Connections.OneConnection, Properties.Settings.Default.SyncServerTime);
            //                Properties.Settings.Default.OneConnectionString = connectionDialog.OneConnectionString;
            //            }

            //            //2011-04-25 如果开启本售异检票，则允许开启并保存辅数据连接
            //            if (Properties.Settings.Default.EnableBSY_JP && connectionDialog.TwoConnectionString != String.Empty && connectionDialog.TwoConnectionString != Properties.Settings.Default.TwoConnectionString)
            //            {
            //                KM.Common.Connections.InitTwoConnection(connectionDialog.TwoConnectionString, new StateChangeEventHandler(TwoConnection_StateChange));
            //                Properties.Settings.Default.TwoConnectionString = connectionDialog.TwoConnectionString;
            //            }

            //            this.Init();
            //            Properties.Settings.Default.Save();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (ClientSettingForm settingForm = new ClientSettingForm())
            //    {
            //        if (settingForm.ShowDialog() == DialogResult.OK)
            //        {
            //            this.Init();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.Logged)
            //    {
            //        using (KM.Common.LogoutDialog logoutDialog = new KM.Common.LogoutDialog())
            //        {
            //            logoutDialog.ShowDialog();
            //            switch (logoutDialog.LogoutType)
            //            {
            //                case KM.Common.LogoutType.注销:
            //                    this.Logout();
            //                    return;
            //                case KM.Common.LogoutType.切换:
            //                    this.Logout();
            //                    break;
            //                case KM.Common.LogoutType.取消:
            //                    return;
            //            }
            //        }
            //    }

            //    if (Properties.Settings.Default.UseCardLogin)
            //    {
            //        using (KM.Common.CIDLoginDialog loginDialog = new KM.Common.CIDLoginDialog())
            //        {
            //            if (loginDialog.ShowDialog() == DialogResult.OK)
            //            {
            //                this.Login(loginDialog.UserID);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        using (KM.Common.UIDLoginDialog loginDialog = new KM.Common.UIDLoginDialog())
            //        {
            //            if (loginDialog.ShowDialog() == DialogResult.OK)
            //            {
            //                this.Login(loginDialog.UserID);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (KM.Common.ResetPasswordDialog resetPasswordDialog = new KM.Common.ResetPasswordDialog())
            //    {
            //        resetPasswordDialog.UserID = KM.Common.Runtime.UID;
            //        resetPasswordDialog.ShowDialog();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (KM.Common.LockDialog lockDialog = new KM.Common.LockDialog())
            //    {
            //        lockDialog.ShowDialog();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void JSButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //最后更新 2011-04-25，支持本售异检票
            //    if (!Properties.Settings.Default.EnableBSY_JP)
            //    {
            //        using (JSForm jsForm = new JSForm())
            //        {
            //            jsForm.JPWindow = this.ShowAll ? "全部" : Properties.Settings.Default.JPWindow;
            //            jsForm.ShowDialog();
            //        }
            //    }
            //    else
            //        throw new ApplicationException("本售异检票不支持结算管理！");
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void PHText_KeyUp(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    switch (e.KeyCode)
            //    {
            //        case Keys.Escape:
            //            this.PHText.Text = String.Empty;
            //            break;
            //        case Keys.Enter:
            //            if (this.PHText.Text != String.Empty)
            //            {
            //                this.JP(this.GetSelectBC_CC(), FormatPH(this.PHText.Text));

            //                this.PHText.Text = String.Empty;

            //                this.RefreshCP(this.GetSelectBC_CC(), this.GetSelectBC_FCSJ(), this.GetSelectBC_ZDZ());
            //                this.WJList_SelectedIndexChanged(sender, e);
            //                this.YJList_SelectedIndexChanged(sender, e);
            //            }
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);

            //    this.PHText.Clear();
            //    this.PHText.Focus();
            //}
        }

        private void BCList_Leave(object sender, EventArgs e)
        {
            //this.StartJPButton.Enabled = false;
            //this.ExitJPButton.Enabled = false;
            //this.JSPrintButton.Enabled = false;
        }

        private void BCList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    this.StartJPButton.Enabled = this.Logged && this.BCList.SelectedItems.Count > 0 && this.BCList.SelectedItems[0].Text == String.Empty;
            //    this.ExitJPButton.Enabled = this.Logged && this.BCList.SelectedItems.Count > 0 && this.BCList.SelectedItems[0].Text == "[检票]";
            //    this.JSPrintButton.Enabled = this.Logged && this.BCList.SelectedItems.Count > 0 && this.BCList.SelectedItems[0].Text == "[检票]";
            //    this.RefreshCPButton.Enabled = this.Logged && this.BCList.SelectedItems.Count > 0 && this.BCList.SelectedItems[0].Text == "[检票]";

            //    if (this.Logged && this.BCList.SelectedItems.Count > 0 && this.BCList.SelectedItems[0].Text == "[检票]")
            //        this.RefreshCP(this.GetSelectBC_CC(), this.GetSelectBC_FCSJ(), this.GetSelectBC_ZDZ());
            //    else
            //        this.ClearCP();

            //    this.BCGroupBox.Text = "待检班次：" + this.BCList.Items.Count.ToString() + "  检票班次：" + this.JPBCList.Count.ToString();
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void WJList_Leave(object sender, EventArgs e)
        {
            //this.JPButton.Enabled = false;
        }

        private void WJList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.JPButton.Enabled = this.Logged && this.WJList.SelectedItems.Count > 0;
        }

        private void YJList_Leave(object sender, EventArgs e)
        {
            //this.TJButton.Enabled = false;
        }

        private void YJList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.TJButton.Enabled = this.Logged && this.YJList.SelectedItems.Count > 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    this.CurrentTimeText.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void BCResreshTimer_Tick(object sender, EventArgs e)
        {
            //if (this.Logged) this.RefreshBCButton_Click(sender, e);
        }

        private void StartJPButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.BCList.SelectedItems.Count > 0)
            //    {
            //        this.JPBCList.Add(this.GetSelectBC_CC());

            //        this.BCList.SelectedItems[0].Text = "[检票]";
            //        this.BCList_SelectedIndexChanged(sender, e);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void ExitJPButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.BCList.SelectedItems.Count > 0)
            //    {
            //        this.JPBCList.Remove(this.GetSelectBC_CC());

            //        this.BCList.SelectedItems[0].Text = String.Empty;
            //        this.BCList_SelectedIndexChanged(sender, e);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void JSPrintButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.BCList.SelectedItems.Count > 0 && this.BCList.SelectedItems[0].Text == "[检票]")
            //    {
            //        //最后更新 2011-04-25，支持本售异检票
            //        if (Properties.Settings.Default.EnableBSY_JP)
            //        {
            //            KM.Common.BSY_JS.Create(KM.Common.Connections.OneConnection, KM.Common.Connections.TwoConnection, this.GetSelectBC_CC(),
            //                Properties.Settings.Default.AllowNullBalance,
            //                Properties.Settings.Default.AllowWQDBalance,
            //                Properties.Settings.Default.BalanceAccount);
            //        }
            //        else
            //        {
            //            KM.Common.JS.Create(KM.Common.Connections.OneConnection, this.GetSelectBC_CC(),
            //                Properties.Settings.Default.AllowNullBalance,
            //                Properties.Settings.Default.AllowWQDBalance,
            //                Properties.Settings.Default.BalanceAccount);
            //        }

            //        if (Properties.Settings.Default.BalancePrint)
            //        {
            //            KM.Common.JS.Print(KM.Common.Connections.OneConnection, new KM.Common.PrintSetting(
            //                Properties.Settings.Default.PrinterName,
            //                Properties.Settings.Default.PageWidth,
            //                Properties.Settings.Default.PageHeight,
            //                Properties.Settings.Default.MarginTop,
            //                Properties.Settings.Default.MarginBottom,
            //                Properties.Settings.Default.MarginLeft,
            //                Properties.Settings.Default.MarginRight,
            //                Properties.Settings.Default.PrintDLF),
            //                this.GetSelectBC_CC(),
            //                Properties.Settings.Default.PrintCopies);
            //        }

            //        this.JPBCList.Remove(this.GetSelectBC_CC());
            //        this.BCList.SelectedItems[0].Remove();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.ShowAll = !this.ShowAll;                
            //    this.ShowAllButton.Text = (this.ShowAll) ? "指定班次" : "全部班次";               

            //    this.RefreshBC();
            //    this.BCList_SelectedIndexChanged(sender, e);
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void RefreshBCButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.RefreshBC();
            //    this.BCList_SelectedIndexChanged(sender, e);
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void JPButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.WJList.SelectedItems.Count > 0)
            //    {
            //        //最后更新 2011-04-25，支持本售异检票
            //        if (Properties.Settings.Default.EnableBSY_JP)
            //            KM.Common.BSY_JP.TransactJP(KM.Common.Connections.TwoConnection, this.GetSelectBC_CC(), this.WJList.SelectedItems[0].Text, 0);
            //        else
            //            KM.Common.JP.TransactJP(KM.Common.Connections.OneConnection, this.GetSelectBC_CC(), this.WJList.SelectedItems[0].Text, 0);

            //        this.RefreshCP(this.GetSelectBC_CC(), this.GetSelectBC_FCSJ(), this.GetSelectBC_ZDZ());
            //        this.WJList_SelectedIndexChanged(sender, e);
            //        this.YJList_SelectedIndexChanged(sender, e);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void TJButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.YJList.SelectedItems.Count > 0)
            //    {
            //        //最后更新 2011-04-25，支持本售异检票
            //        if (Properties.Settings.Default.EnableBSY_JP)
            //            KM.Common.BSY_JP.TransactTJ(KM.Common.Connections.TwoConnection, this.GetSelectBC_CC(), this.YJList.SelectedItems[0].Text);
            //        else
            //            KM.Common.JP.TransactTJ(KM.Common.Connections.OneConnection, this.GetSelectBC_CC(), this.YJList.SelectedItems[0].Text);

            //        this.RefreshCP(this.GetSelectBC_CC(), this.GetSelectBC_FCSJ(), this.GetSelectBC_ZDZ());
            //        this.WJList_SelectedIndexChanged(sender, e);
            //        this.YJList_SelectedIndexChanged(sender, e);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void RefreshCPButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.RefreshCP(this.GetSelectBC_CC(), this.GetSelectBC_FCSJ(), this.GetSelectBC_ZDZ());
            //    this.WJList_SelectedIndexChanged(sender, e);
            //    this.YJList_SelectedIndexChanged(sender, e);
            //}
            //catch (Exception ex)
            //{
            //    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            //}
        }

        private void BCList_DoubleClick(object sender, EventArgs e)
        {
            //Boolean show = false;

            //if (show)
            //{
            //    using (JPBCForm jpbcForm = new JPBCForm())
            //    {
            //        jpbcForm.BCList = this.JPBCList;
            //        jpbcForm.ShowDialog();
            //    }
            //}
        }
    }
}
