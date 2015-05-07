using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace KM.Common
{
    public class SimpleBalancePrint : IDisposable
    {
        private int m_CurrentPageIndex;
        private IList<Stream> m_Streams;

        private SimpleBalanceDataSet simpleBalanceDataSet;

        private System.Windows.Forms.BindingSource JSDMXDataTableBindingSource;
        private System.Windows.Forms.BindingSource JSDDataTableBindingSource;
        private System.Windows.Forms.BindingSource ReportParamDataTableBindingSource;
        private KM.Common.SimpleBalanceDataSetTableAdapters.JSDMXTableAdapter JSDMXTableAdapter;
        private KM.Common.SimpleBalanceDataSetTableAdapters.JSDTableAdapter JSDTableAdapter;

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            try
            {
                Stream stream = new FileStream(@name + "." + fileNameExtension, FileMode.Create);
                m_Streams.Add(stream);
                return stream;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("创建流异常：" + ex.Message);
            }
        }

        ///// <summary>
        ///// Export the given report as an EMF (Enhanced Metafile) file.
        ///// </summary>
        private void Export(PrintSetting printSetting, LocalReport report)
        {
            try
            {
                string deviceInfo = String.Format("<DeviceInfo><OutputFormat>EMF</OutputFormat><PageWidth>{0}mm</PageWidth><PageHeight>{1}mm</PageHeight><MarginTop>{2}mm</MarginTop><MarginLeft>{3}mm</MarginLeft><MarginRight>{4}mm</MarginRight><MarginBottom>{5}mm</MarginBottom></DeviceInfo>",
                    printSetting.PageWidth,
                    printSetting.PageHeight,
                    printSetting.MarginTop,
                    printSetting.MarginLeft,
                    printSetting.MarginRight,
                    printSetting.MarginBottom);

                Warning[] warnings;
                m_Streams = new List<Stream>();
                report.Render("Image", deviceInfo, CreateStream, out warnings);
                foreach (Stream stream in m_Streams)
                    stream.Position = 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("导出报表到 EMF 发生异常：" + ex.Message);
            }
        }

        ///// <summary>
        ///// Handler for PrintPageEvents
        ///// </summary>
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(m_Streams[m_CurrentPageIndex]);
            ev.Graphics.DrawImage(pageImage, ev.PageBounds);
            m_CurrentPageIndex++;
            ev.HasMorePages = (m_CurrentPageIndex < m_Streams.Count);
        }

        private void Print(PrintSetting printSetting)
        {
            try
            {
                if (m_Streams == null || m_Streams.Count == 0)
                    return;

                PrintDocument printDoc = new PrintDocument();
                printDoc.PrinterSettings.PrinterName = printSetting.Printer;
                if (!printDoc.PrinterSettings.IsValid)
                {
                    throw new ApplicationException(String.Format("不能找到打印机 \"{0}\"！", printSetting.Printer));
                }
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                //printDoc.PrinterSettings.Copies = Convert.ToInt16(copies);
                printDoc.Print();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("打印发生异常：" + ex.Message);
            }
        }

        public void Run(SqlConnection conn, PrintSetting printSetting, DateTime rq, String cc, string title)
        {
            try
            {
                if (rq == DateTime.MinValue) throw new ApplicationException("打印单据未指定日期！");
                if (cc == String.Empty) throw new ApplicationException("打印单据未指定班次！");

                //初始化数据集
                this.simpleBalanceDataSet = new KM.Common.SimpleBalanceDataSet();
                this.simpleBalanceDataSet.DataSetName = "SimpleBalanceDataSet";
                this.simpleBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

                //初始化数据表
                this.JSDMXTableAdapter = new KM.Common.SimpleBalanceDataSetTableAdapters.JSDMXTableAdapter();
                this.JSDMXTableAdapter.ClearBeforeFill = true;
                this.JSDMXTableAdapter.Connection = conn;
                this.JSDMXTableAdapter.Fill(this.simpleBalanceDataSet.JSDMX, cc, rq);

                this.JSDTableAdapter = new KM.Common.SimpleBalanceDataSetTableAdapters.JSDTableAdapter();
                this.JSDTableAdapter.ClearBeforeFill = true;
                this.JSDTableAdapter.Connection = conn;
                this.JSDTableAdapter.Fill(this.simpleBalanceDataSet.JSD, rq, cc);

                this.simpleBalanceDataSet.ReportParam.AddReportParamRow(title);
                
                //初始化报表数据源
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
                this.JSDMXDataTableBindingSource = new System.Windows.Forms.BindingSource();
                this.JSDDataTableBindingSource = new System.Windows.Forms.BindingSource();
                this.ReportParamDataTableBindingSource = new System.Windows.Forms.BindingSource();

                this.JSDMXDataTableBindingSource.DataMember = "JSDMX";
                this.JSDMXDataTableBindingSource.DataSource = this.simpleBalanceDataSet;
                this.JSDDataTableBindingSource.DataMember = "JSD";
                this.JSDDataTableBindingSource.DataSource = this.simpleBalanceDataSet;
                this.ReportParamDataTableBindingSource.DataMember = "ReportParam";
                this.ReportParamDataTableBindingSource.DataSource = this.simpleBalanceDataSet;

                reportDataSource1.Name = "SimpleBalanceDataSet_JSDMX";
                reportDataSource1.Value = this.JSDMXDataTableBindingSource;
                reportDataSource2.Name = "SimpleBalanceDataSet_JSD";
                reportDataSource2.Value = this.JSDDataTableBindingSource;
                reportDataSource3.Name = "SimpleBalanceDataSet_ReportParam";
                reportDataSource3.Value = this.ReportParamDataTableBindingSource;

                //生成并打印报表
                using (LocalReport report = new LocalReport())
                {
                    //report.ReportPath = reportName;
                    if(printSetting.PrintDLF)
                        report.ReportEmbeddedResource = "KM.Common.SimpleBalanceReport.rdlc";
                    else
                        report.ReportEmbeddedResource = "KM.Common.SimpleBalanceReport_NoDLF.rdlc";

                    report.DataSources.Add(reportDataSource1);
                    report.DataSources.Add(reportDataSource2);
                    report.DataSources.Add(reportDataSource3);

                    Export(printSetting, report);
                    m_CurrentPageIndex = 0;
                    Print(printSetting);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public void Dispose()
        {
            if (m_Streams != null)
            {
                foreach (Stream stream in m_Streams)
                    stream.Close();
                m_Streams = null;
            }
        }
    }
}
