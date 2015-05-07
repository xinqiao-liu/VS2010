using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.Common
{
    public partial class MessageDialog : Form
    {
        private Int32 m_Count;

        public Int32 Count
        {
            get { return m_Count; }
            set { m_Count = value; }
        }

        public MessageDialog()
        {
            InitializeComponent();
        }

        public static DialogResult Show(String title, String msg, MessageBoxButtons buttons, MessageBoxIcon icon, Int32 count)
        {
            using (MessageDialog messageDialog = new MessageDialog())
            {
                messageDialog.Text = title;
                messageDialog.txtMsg.Text = msg;

                switch (buttons)
                {
                    case MessageBoxButtons.AbortRetryIgnore:
                        messageDialog.btn01.DialogResult = DialogResult.Abort;
                        messageDialog.btn01.Text = "终止";
                        messageDialog.btn01.Visible = true;
                        messageDialog.btn02.DialogResult = DialogResult.Retry;
                        messageDialog.btn02.Text = "重试";
                        messageDialog.btn02.Visible = true;
                        messageDialog.btn03.DialogResult = DialogResult.Ignore;
                        messageDialog.btn03.Text = "忽略";
                        messageDialog.btn03.Visible = true;
                        break;
                    case MessageBoxButtons.OK:
                        messageDialog.btn03.DialogResult = DialogResult.OK;
                        messageDialog.btn03.Text = "确定";
                        messageDialog.btn03.Visible = true;
                        break;
                    case MessageBoxButtons.OKCancel:
                        messageDialog.btn02.DialogResult = DialogResult.OK;
                        messageDialog.btn02.Text = "确定";
                        messageDialog.btn02.Visible = true;
                        messageDialog.btn03.DialogResult = DialogResult.Cancel;
                        messageDialog.btn03.Text = "取消";
                        messageDialog.btn03.Visible = true;
                        break;
                    case MessageBoxButtons.RetryCancel:
                        messageDialog.btn02.DialogResult = DialogResult.Retry;
                        messageDialog.btn02.Text = "重试";
                        messageDialog.btn02.Visible = true;
                        messageDialog.btn03.DialogResult = DialogResult.Cancel;
                        messageDialog.btn03.Text = "取消";
                        messageDialog.btn03.Visible = true;
                        break;
                    case MessageBoxButtons.YesNo:
                        messageDialog.btn02.DialogResult = DialogResult.Yes;
                        messageDialog.btn02.Text = "是";
                        messageDialog.btn02.Visible = true;
                        messageDialog.btn03.DialogResult = DialogResult.No;
                        messageDialog.btn03.Text = "否";
                        messageDialog.btn03.Visible = true;
                        break;
                    case MessageBoxButtons.YesNoCancel:
                        messageDialog.btn01.DialogResult = DialogResult.Yes;
                        messageDialog.btn01.Text = "是";
                        messageDialog.btn01.Visible = true;
                        messageDialog.btn02.DialogResult = DialogResult.No;
                        messageDialog.btn02.Text = "否";
                        messageDialog.btn02.Visible = true;
                        messageDialog.btn03.DialogResult = DialogResult.Cancel;
                        messageDialog.btn03.Text = "取消";
                        messageDialog.btn03.Visible = true;
                        break;
                }

                switch (icon)
                {
                    case MessageBoxIcon.Information:
                        messageDialog.picIcon.Image = SystemIcons.Information.ToBitmap();
                        break;
                    case MessageBoxIcon.Question:
                        messageDialog.picIcon.Image = SystemIcons.Question.ToBitmap();
                        break;
                    case MessageBoxIcon.Warning:
                        messageDialog.picIcon.Image = SystemIcons.Warning.ToBitmap();
                        break;
                    case MessageBoxIcon.Error:
                        messageDialog.picIcon.Image = SystemIcons.Error.ToBitmap();
                        break;
                    default:
                        break;
                }

                if (count > 0)
                {
                    messageDialog.Count = count;
                    messageDialog.txtCount.Visible = true;
                    messageDialog.txtCount.Text = messageDialog.Count.ToString();
                    messageDialog.timer.Enabled = true;
                }

                return messageDialog.ShowDialog();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Count--;

            if (this.Count > 0)
                this.txtCount.Text = this.Count.ToString();
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
