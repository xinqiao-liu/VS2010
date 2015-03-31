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
    public partial class ReportPrintForm : Form
    {
        public string DataSourceName { set; get; }         //"ReportDataSet"
        public object DataSourceValue { set; get; }        //WLDataLogicLayer.ZDHZB.Reads(year, month)
        public string ReportName { set; get; }             //"WLCommon.Report.AccountReport.rdlc";
        public string ParamTitle { set; get; }
        public string ParamUsername { set; get; }

        private void Check()
        {
            if (this.DataSourceName == string.Empty) throw new ApplicationException("未指定报表数据集名称！");
            if (this.DataSourceValue == null) throw new ApplicationException("未指定报表数据源！");
            if (this.ReportName == string.Empty) throw new ApplicationException("未指定报表名！");            
        }

        public ReportPrintForm()
        {
            InitializeComponent();

            this.DataSourceName = "ReportDataSet";
            this.ParamUsername = WLDataLogicLayer.User.LoginUser.Username;
        }

        private void ReportForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Check();

                this.reportViewer.LocalReport.ReportEmbeddedResource = this.ReportName;
                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource { Name = this.DataSourceName, Value = this.DataSourceValue });
                this.reportViewer.LocalReport.SetParameters(new ReportParameter[]{ 
                    new ReportParameter("Report_Title", this.ParamTitle), 
                    new ReportParameter("Report_Username", this.ParamUsername)
                });
                this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer.ZoomMode = ZoomMode.Percent;
                this.reportViewer.RefreshReport();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
