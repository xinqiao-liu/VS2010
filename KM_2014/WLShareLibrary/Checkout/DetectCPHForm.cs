using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Checkout
{
    public partial class DetectCPHForm : Form
    {
        public DateTime MinDate { private get; set; }
        public DateTime MaxDate { private get; set; }

        public static DialogResult InitAndShowDialog(DateTime fromDate, DateTime toDate)
        {
            using (DetectCPHForm detectCPHForm = new DetectCPHForm())
            {
                detectCPHForm.Text += " （" + fromDate.ToString("yyyy-MM-dd") + " - " + toDate.ToString("yyyy-MM-dd") + "）";
                detectCPHForm.MinDate = fromDate;
                detectCPHForm.MaxDate = toDate;
                return detectCPHForm.ShowDialog();
            }
        }

        private void AddItem(string title, string content, object tag)
        {
            ListViewItem item = new ListViewItem(title);
            item.Tag = tag;
            item.SubItems.Add(content);
            this.list.Items.Add(item);
        }

        public DetectCPHForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.list.Items.Clear();

                //获取指定日期待结账运单车牌号列表
                List<String> items = WLDataLogicLayer.WLB.GetCollectCPHList(this.MinDate, this.MaxDate);
                progressBar.Minimum = 0;
                progressBar.Maximum = items.Count;
                progressBar.Step = 1;

                foreach (string i in items)
                {
                    if (i.Length != 7)
                        this.AddItem("警告", string.Format("车牌号 {0} 长度可能不正确！", i), i);

                    if (!WLDataLogicLayer.CSXXB.Exists(i))
                        this.AddItem("警告", string.Format("车牌号 {0} 不存在关联车属信息！", i), i);

                    progressBar.PerformStep();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    WLCommon.Checkout.CPHRelatedForm.InitAndShowDialog(this.list.SelectedItems[0].Tag.ToString(), this.MinDate, this.MaxDate);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
