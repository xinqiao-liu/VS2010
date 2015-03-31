using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCheckout
{
    public partial class YDRecordForm : Form
    {
        private WLCommon.QueryMode QueryMode { get; set; }
        private DateTime QueryDate { get; set; }

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

        public YDRecordForm()
        {
            InitializeComponent();

            this.QueryDate = DateTime.MinValue.Date;
            this.QueryMode = WLCommon.QueryMode.Date;
        }

        private void btnQueryMode_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                this.cboQueryContent.Items.Clear();
                this.cboQueryContent.DropDownStyle = ComboBoxStyle.Simple;                
                this.cboQueryContent.Text = string.Empty;
                this.cboQueryContent.Focus();
                switch (item.Name)
                {
                    case "miQueryModeSN":                       
                        this.btnQueryMode.Text = "运单编号：";
                        this.QueryMode = WLCommon.QueryMode.SN;
                        break;
                    case "miQueryModeFHRName":
                        this.btnQueryMode.Text = "发货姓名：";
                        this.QueryMode = WLCommon.QueryMode.FHRName;
                        break;
                    case "miQueryModeFHRTel":
                        this.btnQueryMode.Text = "发货电话：";
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
                    this.QueryDate = (this.cboQueryContent.Text == string.Empty) ?
                        DateTime.MinValue.Date : Convert.ToDateTime(this.cboQueryContent.Text);

                    WLDataLogicLayer.WLB.RefreshDates(this.cboQueryContent.ComboBox, WLDataLogicLayer.Setting.NodeCode,
                        System.Data.SqlClient.SortOrder.Descending, 0);
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

        private void cboQueryContent_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && (this.cboQueryContent.Text != string.Empty || this.cboQueryContent.SelectedIndex >= 0))
                {
                    this.btnFind_Click(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnFind_Click(object sender, EventArgs e)
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
                {
                    this.RefreshLists(this.list, this.QueryMode, this.cboQueryContent.Text);
                    this.btnPrint.Enabled = (this.list.Items.Count > 0);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                List<WLDataModelLayer.WLB> wlItems = new List<WLDataModelLayer.WLB>();

                foreach (ListViewItem item in this.list.Items)
                {
                    if (item.Tag is WLDataModelLayer.WLB) wlItems.Add((WLDataModelLayer.WLB)item.Tag);
                }

                MessageBox.Show(string.Format("共计 {0} 条打印记录！",wlItems.Count), "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (WLCommon.ReportPrintForm reportPrintForm = new WLCommon.ReportPrintForm { ReportName = "WLCommon.Report.Report_YDRecord.rdlc" })
                {
                    reportPrintForm.DataSourceValue = wlItems;
                    reportPrintForm.ParamTitle = "运单记录";
                    reportPrintForm.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
