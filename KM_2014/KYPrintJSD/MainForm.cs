using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.PrintJSD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //if(Properties.Settings.Default.Timeouts < DateTime.Now.Date)
                //{
                //    MessageBox.Show("软件初始化超时，请与系统开发人员联系！", "终止", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    this.Close();
                //}

                ToolStrip.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Properties.Settings.Default.Path;
                    openFileDialog.Filter = "Microsoft Office Excel 文件 (*.xls)|*.xls";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtFileName.Text = openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            try
            {
                bool chkIdIsNull = false, chkIdNonInt = false, chkTotalIsNull = false, chkTotalNonDec = false, chkTotalIsZero = false;
                string id, total,大写金额 = string.Empty;
                int resultInt;
                decimal resultDecimal;

                if (txtFileName.Text != string.Empty)
                {
                    object MissingValue = Type.Missing;
                    Microsoft.Office.Interop.Excel.Application ea = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    Microsoft.Office.Interop.Excel.Workbook ew = ea.Workbooks.Open(txtFileName.Text,
                        MissingValue, MissingValue, MissingValue, MissingValue, MissingValue, MissingValue, MissingValue,
                        MissingValue, MissingValue, MissingValue, MissingValue, MissingValue, MissingValue, MissingValue);
                    
                    Microsoft.Office.Interop.Excel.Worksheet ews = (Microsoft.Office.Interop.Excel.Worksheet)ew.Worksheets[1];

                    int RowCount = 0, ColCount = 0, BeginRow, BeginCol;
                    
                    RowCount = 0 + ews.UsedRange.Cells.Rows.Count;
                    ColCount = 0 + ews.UsedRange.Cells.Columns.Count;
                    BeginRow = (ews.UsedRange.Cells.Row > 1) ? ews.UsedRange.Cells.Row - 1 : ews.UsedRange.Cells.Row;
                    BeginCol = (ews.UsedRange.Cells.Column > 1) ? ews.UsedRange.Cells.Column - 1 : ews.UsedRange.Cells.Column;

                    ImportData.结帐明细表.Clear();

                    ImportProgressBar.Minimum = 0;
                    ImportProgressBar.Maximum = RowCount;
                    ImportProgressBar.Value = 0;
                    ImportProgressBar.Step = 1;
                    ImportProgressBar.Visible = true;

                    for (int i = BeginRow; i < RowCount + BeginRow; i++)
                    {
                        ImportProgressBar.PerformStep();

                        #region 过滤记录

                        id = ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 1]).Text.ToString();
                        total = ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 15]).Text.ToString();

                        //检测 ID 是否为空
                        if (Properties.Settings.Default.CheckIdIsNull) chkIdIsNull = (id == string.Empty);

                        //检测 ID 是否非整数
                        if (Properties.Settings.Default.CheckIdNonInt) chkIdNonInt = (!int.TryParse(id, out resultInt));

                        //检测 Total 是否为空
                        if (Properties.Settings.Default.CheckTotalIsNull) chkTotalIsNull = (total == string.Empty);

                        //检测 Total 是否非金额
                        if (Properties.Settings.Default.CheckTotalNonDec)
                        {
                            chkTotalNonDec = (!Decimal.TryParse(total, out resultDecimal));

                            if (chkTotalNonDec)
                                大写金额 = "";
                            else
                            {
                                Money m = new Money(resultDecimal);
                                大写金额 = m.ToString();
                            }
                        }

                        if (Properties.Settings.Default.CheckTotalIsZero) chkTotalIsZero = (Decimal.TryParse(total, out resultDecimal) && resultDecimal == 0);                        

                        if (chkIdIsNull || chkIdNonInt || chkTotalIsNull || chkTotalNonDec || chkTotalIsZero) continue;

                        #endregion

                        ImportData.结帐明细表.Add结帐明细表Row(
                            id,
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 2]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 3]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 4]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 5]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 6]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 7]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 8]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 9]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 10]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 11]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 12]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 13]).Text.ToString(),
                            ((Microsoft.Office.Interop.Excel.Range)ews.UsedRange.Cells[i, 14]).Text.ToString(),
                            total,
                            大写金额);
                    }

                    ImportProgressBar.Visible = false;

                    ea.Quit();
                }
                else
                    MessageBox.Show("请选择结帐单文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            try
            {
                using (SettingDialog settingDialog = new SettingDialog())
                {
                    if (settingDialog.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                using (PrintSettingForm printSettingForm = new PrintSettingForm())
                {
                    if (printSettingForm.ShowDialog() == DialogResult.OK)
                    {
                        //for (int i = 0; i < DataGridView.SelectedRows.Count; i++)
                        //{
                        //    RequisitionReport requisitionReport = new RequisitionReport();
                        //    requisitionReport.PrintOptions.PaperSize = PaperSize.DefaultPaperSize;

                        //    this.SetTextObject(requisitionReport, "txtTitle", Properties.Settings.Default.PrintTitle);
                        //    this.SetTextObject(requisitionReport, "txtOneSign", Properties.Settings.Default.PrintOneSign);
                        //    this.SetTextObject(requisitionReport, "txtTwoSign", Properties.Settings.Default.PrintTwoSign);
                        //    this.SetTextObject(requisitionReport, "txtSN", DataGridView.SelectedRows[i].Cells[0].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtDW", DataGridView.SelectedRows[i].Cells[1].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtXM", DataGridView.SelectedRows[i].Cells[2].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtCPH", DataGridView.SelectedRows[i].Cells[3].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtPK", DataGridView.SelectedRows[i].Cells[4].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtDLF", DataGridView.SelectedRows[i].Cells[5].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtXZ", DataGridView.SelectedRows[i].Cells[6].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtWYJ", DataGridView.SelectedRows[i].Cells[7].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtWYY", DataGridView.SelectedRows[i].Cells[8].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtDKKJ", DataGridView.SelectedRows[i].Cells[9].Value.ToString());
                        //    this.SetTextObject(requisitionReport, "txtJF", DataGridView.SelectedRows[i].Cells[10].Value.ToString());

                        //    requisitionReport.Refresh();
                        //    requisitionReport.PrintToPrinter(1, false, 0, 0);
                        //}

                        using (PrintForm printForm = new PrintForm())
                        {
                            printForm.ReportDataTable = this.ImportData.结帐明细表;
                            printForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = (DataGridView.SelectedRows.Count > 0);
        }
    }
}
