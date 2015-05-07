using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace KM.PrintJSD
{
    public partial class PrintForm : Form
    {
        private ImportDataSet.结帐明细表DataTable m_ReportDataTable = new ImportDataSet.结帐明细表DataTable();
        public ImportDataSet.结帐明细表DataTable ReportDataTable
        {
            set { m_ReportDataTable = value; }
            get { return m_ReportDataTable; }
        }

        public PrintForm()
        {
            InitializeComponent();            
        }

        private void PrintForm_Shown(object sender, EventArgs e)
        {
            if (ReportDataTable == null) throw new ApplicationException("未指定报表数据源！");

            this.ReportViewer.Reset();

            ReportParameter p0 = new ReportParameter("Report_Parameter_0", Properties.Settings.Default.PrintTitle);
            ReportParameter p1 = new ReportParameter("Report_Parameter_1", Properties.Settings.Default.PrintName01);
            ReportParameter p2 = new ReportParameter("Report_Parameter_2", Properties.Settings.Default.PrintName02);
            ReportParameter p3 = new ReportParameter("Report_Parameter_3", Properties.Settings.Default.PrintName03);
            ReportParameter p4 = new ReportParameter("Report_ItemTitle01", Properties.Settings.Default.ItemTitle01);
            ReportParameter p5 = new ReportParameter("Report_ItemTitle02", Properties.Settings.Default.ItemTitle02);
            ReportParameter p6 = new ReportParameter("Report_ItemTitle03", Properties.Settings.Default.ItemTitle03);
            ReportParameter p7 = new ReportParameter("Report_ItemTitle04", Properties.Settings.Default.ItemTitle04);
            ReportParameter p8 = new ReportParameter("Report_ItemTitle05", Properties.Settings.Default.ItemTitle05);
            ReportParameter p9 = new ReportParameter("Report_ItemTitle06", Properties.Settings.Default.ItemTitle06);
            ReportParameter p10 = new ReportParameter("Report_ItemTitle07", Properties.Settings.Default.ItemTitle07);
            ReportParameter p11 = new ReportParameter("Report_ItemTitle08", Properties.Settings.Default.ItemTitle08);
            ReportParameter p12 = new ReportParameter("Report_ItemTitle09", Properties.Settings.Default.ItemTitle09);
            ReportParameter p13 = new ReportParameter("Report_ItemTitle10", Properties.Settings.Default.ItemTitle10);

            this.ReportViewer.LocalReport.ReportEmbeddedResource = "KM.PrintJSD.RequisitionReport.rdlc";
            this.ReportViewer.LocalReport.DataSources.Add(new ReportDataSource("ImportDataSet_结帐明细表",(DataTable) this.ReportDataTable));            
            this.ReportViewer.LocalReport.SetParameters(new ReportParameter[] { p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13 });
            this.ReportViewer.RefreshReport();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {

            this.ReportViewer.RefreshReport();
        }
    }
}
