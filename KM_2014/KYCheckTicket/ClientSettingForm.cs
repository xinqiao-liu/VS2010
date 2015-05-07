using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace KM.JP
{
    public partial class ClientSettingForm : Form
    {
        public ClientSettingForm()
        {
            InitializeComponent();
        }

        private void SettingDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (PrinterSettings.InstalledPrinters.Count > 0 && this.PrinterNameCombo.Text == String.Empty)
                    {
                        if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("警告", "默认打印机不能为空！", MessageBoxButtons.OK, MessageBoxIcon.Warning, Properties.Settings.Default.ShowHintTime);
                        return;
                    }

                    //基础配置                   
                    Properties.Settings.Default.JPWindow = this.JPWindowCombo.Text;
                    Properties.Settings.Default.ShowHint = this.ShowHintCheck.Checked;
                    
                    if (this.ShowHintCheck.Checked)
                    {
                        Properties.Settings.Default.ShowHintTime = Convert.ToInt32(this.ShowHintTimeNumber.Value);
                    }

                    Properties.Settings.Default.BCAutoRefresh = this.BCAutoRefreshCheck.Checked;
                    if (this.BCAutoRefreshCheck.Checked)
                    {
                        Properties.Settings.Default.BCRefreshTime = Convert.ToInt32(this.BCRefreshTimeNumber.Value);
                    }

                    Properties.Settings.Default.AllowNullBalance = this.AllowNullBalanceCheck.Checked;
                    Properties.Settings.Default.AllowWQDBalance = this.AllowWQDBalanceCheck.Checked;
                    Properties.Settings.Default.BalancePrint = this.BalancePrintCheck.Checked;
                    Properties.Settings.Default.BalanceAccount = this.BalanceAccountCheck.Checked;
                    Properties.Settings.Default.UseCardLogin = this.UseCardLoginCheck.Checked;
                    Properties.Settings.Default.EnableSound = this.EnableSoundCheck.Checked;
                    Properties.Settings.Default.ShowConfirm = this.ShowConfirmCheck.Checked;
                    Properties.Settings.Default.AllowResumeJP = this.AllowResumeJPCheck.Checked;
                    Properties.Settings.Default.AllowReJS = this.AllowReJSCheck.Checked;
                    Properties.Settings.Default.PrintDLF = this.PrintDLFCheck.Checked;

                    //2011-04-25 同步服务器时间
                    Properties.Settings.Default.SyncServerTime = this.AllowSyncServerTime.Checked;

                    //2011-04-25 保存开启本售异检票功能
                    Properties.Settings.Default.EnableBSY_JP = this.EnableBSY_JPCheck.Checked;

                    //打印配置
                    Properties.Settings.Default.PrinterName = this.PrinterNameCombo.Text;
                    Properties.Settings.Default.PrintCopies = Convert.ToInt32(this.PrintCopiesNumber.Value);
                    Properties.Settings.Default.PageWidth = this.PageWidthNumber.Value;
                    Properties.Settings.Default.PageHeight = this.PageHeightNumber.Value;
                    Properties.Settings.Default.MarginTop = this.MarginTopNumber.Value;
                    Properties.Settings.Default.MarginBottom = this.MarginBottomNumber.Value;
                    Properties.Settings.Default.MarginLeft = this.MarginLeftNumber.Value;
                    Properties.Settings.Default.MarginRight = this.MarginRightNumber.Value;

                    Properties.Settings.Default.Save();

                    e.Cancel = false;

                    KM.Common.Log.InsertCZJL(KM.Common.Connections.OneConnection, "本地配置", "保存配置");
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning, Properties.Settings.Default.ShowHintTime);
            }
        }

        private void SettingDialog_Load(object sender, EventArgs e)
        {
            try
            {
                //初始化打印机列表
                if (PrinterSettings.InstalledPrinters.Count > 0)
                {
                    foreach (String printer in PrinterSettings.InstalledPrinters)
                    {
                        this.PrinterNameCombo.Items.Add(printer.ToString());
                    }
                }
                else
                {
                    if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("警告", "系统未安装打印机，将不能打印结算单据！", MessageBoxButtons.OK, MessageBoxIcon.Warning, Properties.Settings.Default.ShowHintTime);
                }

                //基础配置
                this.JPWindowCombo.Text = Properties.Settings.Default.JPWindow;

                this.ShowHintCheck.Checked = Properties.Settings.Default.ShowHint;
                this.ShowHintTimeNumber.Enabled = this.ShowHintCheck.Checked;
                this.ShowHintTimeNumber.Value = Properties.Settings.Default.ShowHintTime;

                this.BCAutoRefreshCheck.Checked = Properties.Settings.Default.BCAutoRefresh;
                this.BCRefreshTimeNumber.Enabled = this.BCAutoRefreshCheck.Checked;
                this.BCRefreshTimeNumber.Value = Properties.Settings.Default.BCRefreshTime;

                this.AllowNullBalanceCheck.Checked = Properties.Settings.Default.AllowNullBalance;
                this.AllowWQDBalanceCheck.Checked = Properties.Settings.Default.AllowWQDBalance;
                this.BalancePrintCheck.Checked = Properties.Settings.Default.BalancePrint;
                this.BalanceAccountCheck.Checked = Properties.Settings.Default.BalanceAccount;
                this.UseCardLoginCheck.Checked = Properties.Settings.Default.UseCardLogin;
                this.EnableSoundCheck.Checked = Properties.Settings.Default.EnableSound;
                this.ShowConfirmCheck.Checked = Properties.Settings.Default.ShowConfirm;
                this.AllowResumeJPCheck.Checked = Properties.Settings.Default.AllowResumeJP;
                this.AllowReJSCheck.Checked = Properties.Settings.Default.AllowReJS;
                this.PrintDLFCheck.Checked = Properties.Settings.Default.PrintDLF;

                //2011-04-25 同步服务器时间
                this.AllowSyncServerTime.Checked = Properties.Settings.Default.SyncServerTime;

                //2011-04-25 读取开启本售异检票功能
                this.EnableBSY_JPCheck.Checked = Properties.Settings.Default.EnableBSY_JP;

                //打印配置
                this.PrinterNameCombo.Text = Properties.Settings.Default.PrinterName;
                this.PrintCopiesNumber.Value = Properties.Settings.Default.PrintCopies;
                this.PageWidthNumber.Value = Properties.Settings.Default.PageWidth;
                this.PageHeightNumber.Value = Properties.Settings.Default.PageHeight;
                this.MarginTopNumber.Value = Properties.Settings.Default.MarginTop;
                this.MarginBottomNumber.Value = Properties.Settings.Default.MarginBottom;
                this.MarginLeftNumber.Value = Properties.Settings.Default.MarginLeft;
                this.MarginRightNumber.Value = Properties.Settings.Default.MarginRight;


                KM.Common.Log.InsertCZJL(KM.Common.Connections.OneConnection, "本地配置", "进入配置");
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning, Properties.Settings.Default.ShowHintTime);
            }
        }

        private void ShowHintCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowHintTimeNumber.Enabled = this.ShowHintCheck.Checked;
        }

        private void BCAutoRefreshCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.BCRefreshTimeNumber.Enabled = this.BCAutoRefreshCheck.Checked;
        }

        private void JPWindowCombo_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Items.Count > 0 && comboBox.SelectedIndex >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y + 8, e.Bounds.Width, e.Bounds.Height), StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }
    }
}
