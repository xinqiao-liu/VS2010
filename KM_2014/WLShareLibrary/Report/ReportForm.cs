using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WLCommon
{
    public partial class ReportForm : Form
    {
        private string ReportName { set; get; }
        private object ReportDataSource_Value { set; get; }
        private string Param_Report_Title { set; get; }
        private string Param_Report_Username { set; get; }

        public void InitReport(string reportName, string reportTitle)
        {
            switch (reportName)
            {
                case "JZCPHRecord":
                    this.ReportName = "WLCommon.Report.JZCPHRecord.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.JZDMB.Read_JZCPH();
                    break;
                default: break;
            }
            this.Param_Report_Title = reportTitle;
            this.Param_Report_Username = WLDataLogicLayer.User.LoginUser.Username;
            this.ShowDialog();
        }

        public void InitReport(string reportName, string reportTitle, DateTime selectDate)
        {
            string dateStr = selectDate.ToString("yyyy-MM-dd");

            switch (reportName)
            {
                case "PayinRecord":
                    this.ReportName = "WLCommon.Report.PayinRecord.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.Payin.Reads(selectDate);
                    break;
                case "GDRecord":
                    this.ReportName = "WLCommon.Report.GDRecord.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.GDB.Reads(WLDataLogicLayer.Setting.NodeCode, selectDate);
                    break;
                case "FDRecord":
                    this.ReportName = "WLCommon.Report.FDRecord.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.FDB.Reads(WLDataLogicLayer.Setting.NodeCode, selectDate);
                    break;
                case "YBRecord":
                    this.ReportName = "WLCommon.Report.YBRecord.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.WLB.ReadLocalAdvanceRecord(WLDataLogicLayer.Setting.NodeCode, selectDate);
                    break;
                case "XCRecord":
                    this.ReportName = "WLCommon.Report.XCRecord.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.WLB.ReadLocalXCRecord(WLDataLogicLayer.Setting.NodeCode, selectDate);
                    break;
                case "SHRecord":
                    this.ReportName = "WLCommon.Report.SHRecord.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.WLB.ReadLocalSHRecord(WLDataLogicLayer.Setting.NodeCode, selectDate);
                    break;
                case "DaySummary":
                    this.ReportName = "WLCommon.Report.DaySummaryReport.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.DailySheet.Reads(selectDate);
                    break;
                default: break;
            }
            this.Param_Report_Title = dateStr + " " + reportTitle;
            this.Param_Report_Username = WLDataLogicLayer.User.LoginUser.Username;
            this.ShowDialog();
        }

        public void InitReport(string reportName, string reportTitle, int year, int month, string code = "")
        {
            //string dateStr = year.ToString() + "年" + month + "月";

            switch (reportName)
            {
                case "PrintAccount":
                    this.ReportName = "WLCommon.Report.AccountReport.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.ZDHZB.Reads(year, month);;
                    break;
                case "PrintDetail":
                    this.ReportName = "WLCommon.Report.DetailReport.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.ZDMXB.Reads(year, month, code);
                    break;
                default: break;
            }
            this.Param_Report_Title = reportTitle;
            this.Param_Report_Username = WLDataLogicLayer.User.LoginUser.Username;
            this.ShowDialog();
        }

        public void InitReport(string reportName, string reportTitle, DateTime minDate, DateTime maxDate)
        {
            string dateStr;
            if (minDate == maxDate) 
                dateStr = minDate.ToString("yyyy-MM-dd");
            else
                dateStr = minDate.ToString("yyyy-MM-dd") + "至" + maxDate.ToString("yyyy-MM-dd");

            switch (reportName)
            {
                case "CollectByWD":
                    this.ReportName = "WLCommon.Report.WDSummaryReport.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.Collect.ReadCollectByWD(minDate, maxDate);
                    break;
                case "CollectByCP":
                    this.ReportName = "WLCommon.Report.CPSummaryReport.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.Collect.ReadCollectByCP(minDate, maxDate);
                    break;
                case "CollectByXL":
                    this.ReportName = "WLCommon.Report.XLSummaryReport.rdlc";
                    this.ReportDataSource_Value = WLDataLogicLayer.Collect.ReadCollectByXL(minDate, maxDate);
                    break;
                default: break;
            }
            this.Param_Report_Title = dateStr + " " + reportTitle;
            this.Param_Report_Username = WLDataLogicLayer.User.LoginUser.Username;
            this.ShowDialog();
        }

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Shown(object sender, EventArgs e)
        {
            try
            {
                ReportDataSource dataSource = new ReportDataSource();
                dataSource.Name = "ReportDataSet";
                dataSource.Value = ReportDataSource_Value;

                ReportParameter param_report_title = new ReportParameter("Report_Title", this.Param_Report_Title);
                ReportParameter param_report_username = new ReportParameter("Report_Username", this.Param_Report_Username);

                this.reportViewer.LocalReport.ReportEmbeddedResource = ReportName;  // "WLCommon.Report.AccountReport.rdlc";
                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(dataSource);
                this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { param_report_title, param_report_username });
                this.reportViewer.RefreshReport();            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
