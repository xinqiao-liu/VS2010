using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.Common
{
    public partial class ReportForm : Form
    {
        private String m_CC;

        public String CC
        {
            get { return m_CC; }
            set { m_CC = value; }
        }

        public void FillData(SqlConnection conn)
        {
            JSDMXTableAdapter.Connection = conn;
            JSDMXTableAdapter.Fill(this.simpleBalanceDataSet.JSDMX, CC, Runtime.QueryDate);
            JSDTableAdapter.Connection = conn;
            JSDTableAdapter.Fill(this.simpleBalanceDataSet.JSD, Runtime.QueryDate, CC);
        }

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.FillData(Connections.OneConnection);
            this.simpleBalanceDataSet.ReportParam.AddReportParamRow("AAA");
            this.reportViewer1.RefreshReport();
        }
    }
}
