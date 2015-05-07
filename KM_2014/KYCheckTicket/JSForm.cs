using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.JP
{
    public partial class JSForm : Form
    {
        private String m_JPWindow;

        public String JPWindow
        {
            get { return m_JPWindow; }
            set { m_JPWindow = value; }
        }

        public JSForm()
        {
            InitializeComponent();
        }

        private void JSForm_Load(object sender, EventArgs e)
        {
            this.JSList.Items.Clear();
            this.JSList.Enabled = this.JPWindow != String.Empty;
            this.RfreshButton.Enabled = this.JPWindow != String.Empty;

            this.RfreshButton_Click(sender, e);
        }

        private void JSList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ResumeButton.Enabled = (this.JSList.SelectedItems.Count > 0 && Properties.Settings.Default.AllowResumeJP);
            this.ReJSButton.Enabled = (this.JSList.SelectedItems.Count > 0 && Properties.Settings.Default.AllowReJS);
            this.PrintButton.Enabled = (this.JSList.SelectedItems.Count > 0);
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.JSList.SelectedItems.Count > 0)
                {
                    ListViewItem jsItem = this.JSList.SelectedItems[0];
                    if (!Properties.Settings.Default.ShowConfirm || KM.Common.MessageDialog.Show("确认", String.Format("班次 {0} 恢复检票？", jsItem.Text), MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0) == DialogResult.Yes)
                    {
                        KM.Common.JS.ResumeJS(KM.Common.Connections.OneConnection, jsItem.Text);
                        jsItem.Remove();
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            }
        }

        private void ReJSButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.JSList.SelectedItems.Count > 0)
                {
                    ListViewItem jsItem = this.JSList.SelectedItems[0];
                    if (!Properties.Settings.Default.ShowConfirm || KM.Common.MessageDialog.Show("确认", String.Format("班次 {0} 重新结算？", jsItem.Text), MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0) == DialogResult.Yes)
                    {
                        KM.Common.JS.Create(KM.Common.Connections.OneConnection, jsItem.Text, Properties.Settings.Default.AllowNullBalance, Properties.Settings.Default.AllowWQDBalance, Properties.Settings.Default.BalanceAccount);
                        if (Properties.Settings.Default.BalancePrint)
                        {
                            KM.Common.JS.Print(KM.Common.Connections.OneConnection, new KM.Common.PrintSetting(
                                Properties.Settings.Default.PrinterName,
                                Properties.Settings.Default.PageWidth,
                                Properties.Settings.Default.PageHeight,
                                Properties.Settings.Default.MarginTop,
                                Properties.Settings.Default.MarginBottom,
                                Properties.Settings.Default.MarginLeft,
                                Properties.Settings.Default.MarginRight,
                                Properties.Settings.Default.PrintDLF),
                                jsItem.Text,
                                Properties.Settings.Default.PrintCopies);
                        }
                    }
                }
                KM.Common.JS.RefreshJS(KM.Common.Connections.OneConnection, this.JSList, this.JPWindow);
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.JSList.SelectedItems.Count > 0)
                {
                    ListViewItem jsItem = this.JSList.SelectedItems[0];
                    if (!Properties.Settings.Default.ShowConfirm || KM.Common.MessageDialog.Show("确认", String.Format("班次 {0} 打印单据？", jsItem.Text), MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0) == DialogResult.Yes)
                    {
                        KM.Common.JS.Print(KM.Common.Connections.OneConnection, new KM.Common.PrintSetting(
                            Properties.Settings.Default.PrinterName,
                            Properties.Settings.Default.PageWidth,
                            Properties.Settings.Default.PageHeight,
                            Properties.Settings.Default.MarginTop,
                            Properties.Settings.Default.MarginBottom,
                            Properties.Settings.Default.MarginLeft,
                            Properties.Settings.Default.MarginRight,
                            Properties.Settings.Default.PrintDLF),
                            jsItem.Text,
                            Properties.Settings.Default.PrintCopies);

                        KM.Common.JS.InsertLog(KM.Common.Connections.OneConnection, "打印单据", jsItem.Text);
                    }
                }

                //using (KM.Common.ReportForm ReportForm = new KM.Common.ReportForm())
                //{
                //    ReportForm.CC = this.JSList.SelectedItems[0].Text;
                //    ReportForm.ShowDialog();
                //}
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            }
        }

        private void RfreshButton_Click(object sender, EventArgs e)
        {
            int result = 0;

            try
            {
                KM.Common.JS.RefreshJS(KM.Common.Connections.OneConnection, this.JSList, this.JPWindow);

                for (int i = 0; i < this.JSList.Items.Count; i++)
                {
                    if (this.JSList.Items[i].SubItems[6].Text == KM.Common.Runtime.Name) result++;
                }

                this.txtTitle.Text = "全部：" + this.JSList.Items.Count.ToString() + "  当前：" + result.ToString();
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.ShowHint) KM.Common.MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, Properties.Settings.Default.ShowHintTime);
            }
        }
    }
}
