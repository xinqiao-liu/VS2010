namespace KM.Common
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.JSDMXDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JSDDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportParamDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.simpleBalanceDataSet = new KM.Common.SimpleBalanceDataSet();
            this.JSDMXTableAdapter = new KM.Common.SimpleBalanceDataSetTableAdapters.JSDMXTableAdapter();
            this.JSDTableAdapter = new KM.Common.SimpleBalanceDataSetTableAdapters.JSDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.JSDMXDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JSDDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportParamDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleBalanceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // JSDMXDataTableBindingSource
            // 
            this.JSDMXDataTableBindingSource.DataMember = "JSDMX";
            this.JSDMXDataTableBindingSource.DataSource = this.simpleBalanceDataSet;
            // 
            // JSDDataTableBindingSource
            // 
            this.JSDDataTableBindingSource.DataMember = "JSD";
            this.JSDDataTableBindingSource.DataSource = this.simpleBalanceDataSet;
            // 
            // ReportParamDataTableBindingSource
            // 
            this.ReportParamDataTableBindingSource.DataMember = "ReportParam";
            this.ReportParamDataTableBindingSource.DataSource = this.simpleBalanceDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SimpleBalanceDataSet_JSDMX";
            reportDataSource1.Value = this.JSDMXDataTableBindingSource;
            reportDataSource2.Name = "SimpleBalanceDataSet_JSD";
            reportDataSource2.Value = this.JSDDataTableBindingSource;
            reportDataSource3.Name = "SimpleBalanceDataSet_ReportParam";
            reportDataSource3.Value = this.ReportParamDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KM.Common.SimpleBalanceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(972, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // simpleBalanceDataSet
            // 
            this.simpleBalanceDataSet.DataSetName = "SimpleBalanceDataSet";
            this.simpleBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JSDMXTableAdapter
            // 
            this.JSDMXTableAdapter.ClearBeforeFill = true;
            // 
            // JSDTableAdapter
            // 
            this.JSDTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 540);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JSDMXDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JSDDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportParamDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleBalanceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JSDMXDataTableBindingSource;
        private System.Windows.Forms.BindingSource JSDDataTableBindingSource;
        private System.Windows.Forms.BindingSource ReportParamDataTableBindingSource;
        private SimpleBalanceDataSet simpleBalanceDataSet;
        private KM.Common.SimpleBalanceDataSetTableAdapters.JSDMXTableAdapter JSDMXTableAdapter;
        private KM.Common.SimpleBalanceDataSetTableAdapters.JSDTableAdapter JSDTableAdapter;
    }
}