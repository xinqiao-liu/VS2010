using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Central
{
    public partial class YDTrackForm : Form
    {
        public static void InitAndShowDialog()
        {
            using (YDTrackForm ydTrackForm = new YDTrackForm())
            {
                ydTrackForm.Text = string.Format("运单追踪（当前网点：{0}-{1}）", WLDataLogicLayer.Setting.NodeCode, WLDataLogicLayer.Setting.NodeName);
                ydTrackForm.ShowDialog();
            }
        }

        public YDTrackForm()
        {
            InitializeComponent();
        }

        private void txtSN_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape: this.txtSN.Clear(); break;
                    case Keys.Enter:
                        if (this.txtSN.Text != string.Empty)
                        {
                            WLDataLogicLayer.WLT.RefreshList(this.list, WLDataLogicLayer.Setting.NodeCode, WLDataLogicLayer.Bill.Format(this.txtSN.Text));

                            this.txtSN.SelectAll();
                            this.txtSN.Focus();
                        }
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
