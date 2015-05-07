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
    public partial class ConnectionDialog : Form
    {
        public String OneConnectionString
        {
            get { return this.txtOneConnectionString.Text; }
            set 
            { 
                this.txtOneConnectionString.Text = value;
                this.txtOneConnectionString.Enabled = true;
            }
        }

        public String TwoConnectionString
        {
            get { return this.txtTwoConnectionString.Text; }
            set 
            { 
                this.txtTwoConnectionString.Text = value;
                this.txtTwoConnectionString.Enabled = true;
            }
        }

        public String OleConnectionString
        {
            get { return this.txtOleConnectionString.Text; }
            set 
            { 
                this.txtOleConnectionString.Text = value;
                this.txtOleConnectionString.Enabled = true;
            }
        }

        public ConnectionDialog()
        {
            InitializeComponent();
        }

        private void ConnectionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == "osk") p.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageDialog.Show("异常", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, 3);
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
