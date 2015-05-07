using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KM.Common
{
    public partial class LockDialog : Form
    {
        private bool m_OccurError = false;

        public LockDialog()
        {
            InitializeComponent();
        }

        private void LockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    if (this.CIDText.Text == Runtime.Password || this.CIDText.Text == Runtime.CID)
                        e.Cancel = false;
                    else
                    {
                        this.CIDText.Clear();
                        this.CIDText.Focus();
                        throw new ApplicationException("口令或卡号无效！");
                    }
                }

                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == "osk") p.Kill();
                }
            }
            catch(Exception ex)
            {
                this.m_OccurError = true;
                MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 3);
            }
        }

        private void LockForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.UIDText.Text = Runtime.UID;
                this.NameText.Text = Runtime.Name;

                this.UnlockButton.Enabled = true;
            }
            catch { }
        }

        private void CIDText_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.m_OccurError) { this.m_OccurError = false; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.CIDText.Text = String.Empty;
                    break;
                case Keys.Enter:
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        private void KeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == "osk") return;
                }

                Process.Start(new ProcessStartInfo() { FileName = "osk.exe", Verb = "open", WindowStyle = ProcessWindowStyle.Normal });
            }
            catch (Exception ex)
            {
                MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 3);
            }
        }
    }
}
