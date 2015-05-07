using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Central
{
    public partial class UploadToCentralForm : Form
    {
        public static void InitAndShowDialog()
        {
            using (UploadToCentralForm uploadToCentralForm = new UploadToCentralForm())
            {
                uploadToCentralForm.ShowDialog();
            }
        }

        public UploadToCentralForm()
        {
            InitializeComponent();
        }

        private void UploadToCentralForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.txtDate.Value = DateTime.Now.Date;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnRefresh_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtAlreadySynced.Text = WLDataLogicLayer.WLB.GetLocalHasSynchronizedNumber(WLDataLogicLayer.Setting.NodeCode, this.txtDate.Value.Date).ToString();
                this.txtWaitingSynced.Text = WLDataLogicLayer.WLB.GetLocalNotSynchronizedNumber(WLDataLogicLayer.Setting.NodeCode, this.txtDate.Value.Date).ToString();

                this.btnUpload.Enabled = Convert.ToInt32(this.txtWaitingSynced.Text) > 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (WLDataModelLayer.WLB item in WLDataLogicLayer.WLB.ReadLocalUploadCentral(WLDataLogicLayer.Setting.NodeCode, this.txtDate.Value.Date))
                {
                    WLDataLogicLayer.WLB.UploadToCentral(item); 
                }
                this.btnRefresh_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
