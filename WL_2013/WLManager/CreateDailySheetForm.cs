using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLManager
{
    public partial class CreateDailySheetForm : Form
    {
        public static void InitAndShowDialog()
        {
            using (CreateDailySheetForm endOfDayForm = new CreateDailySheetForm()) { endOfDayForm.ShowDialog(); }
        }

        public CreateDailySheetForm()
        {
            InitializeComponent();
        }

        private void CreateDailySheetForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtDate.Value = DateTime.Now.Date;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                WLDataModelLayer.DailyReport item = WLDataLogicLayer.WLB.CreateDailyReport(
                    WLDataLogicLayer.Setting.NodeCode,
                    Convert.ToDateTime(this.txtDate.Value));

                if (item != null)
                {
                    item.NodeName = WLDataLogicLayer.Setting.NodeName;
                    item.UID = WLDataLogicLayer.User.LoginUser.Userid;

                    if (WLDataLogicLayer.DailyReport.Exists(item))
                        WLDataLogicLayer.DailyReport.Update(item);
                    else
                        WLDataLogicLayer.DailyReport.Insert(item);

                    MessageBox.Show("成功创建 " + item.Date.ToString("yyyy-MM-dd") + " 日报表。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else throw new ApplicationException("创建日报表失败！");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
