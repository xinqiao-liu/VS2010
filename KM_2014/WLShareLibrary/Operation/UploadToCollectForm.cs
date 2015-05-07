using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Operation
{
    public partial class UploadToCollectForm : Form
    {
        public static void InitAndShowDialog()
        {
            using (UploadToCollectForm uploadToCollectForm = new UploadToCollectForm()) { uploadToCollectForm.ShowDialog(); }
        }

        public UploadToCollectForm()
        {
            InitializeComponent();
        }

        private void UploadForm_Shown(object sender, EventArgs e)
        {
            try
            {
                List<DateTime> items = WLDataLogicLayer.WLB.GetLocalAllCZRQ();
                if (items.Count > 0)
                {
                    this.txtFromDate.MinDate = items[0];
                    this.txtFromDate.MaxDate = items[items.Count - 1];
                    this.txtFromDate.Value = items[items.Count - 1];
                    this.txtToDate.MinDate = items[0];
                    this.txtToDate.MaxDate = items[items.Count - 1];
                    this.txtToDate.Value = items[items.Count - 1];

                    this.btnUpload.Enabled = true;
                }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                this.statusStrip.Visible = true;

                for (DateTime date = this.txtFromDate.Value.Date; date <= this.txtToDate.Value.Date; date = date.AddDays(1))
                {
                    List<WLDataModelLayer.WLB> items;

                    //检测是否包含已冻结运单
                    if (this.chkIncludeFreeze.Checked)
                        items = WLDataLogicLayer.WLB.ReadLocalByCZRQ(date);
                    else
                        items = WLDataLogicLayer.WLB.ReadLocalNotFreezeByCZRQ(date);

                    for (int i = 0; i < items.Count; i++)
                    {
                        WLDataLogicLayer.WLB.UploadToCollect(items[i]); this.progressBar.Value = (i + 1) * 100 / items.Count;
                    }

                    //检测是否同步上传日报表
                    if (this.chkUploadDailySheet.Checked) WLDataLogicLayer.DailySheet.UploadToCollect(date);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                this.statusStrip.Visible = false;
                this.progressBar.Value = 0;
            }
        }
    }
}
