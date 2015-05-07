using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.Common
{
    public enum LogoutType { 注销, 切换, 取消 }

    public partial class LogoutDialog : Form
    {
        private LogoutType m_LogoutType = LogoutType.取消;

        public LogoutType LogoutType
        {
            get { return m_LogoutType; }
            private set { m_LogoutType = value; }
        }

        public LogoutDialog()
        {
            InitializeComponent();
        }

        private void m_LogoutButton_Click(object sender, EventArgs e)
        {
            this.LogoutType = LogoutType.注销;
        }

        private void m_SwitchButton_Click(object sender, EventArgs e)
        {
            this.LogoutType = LogoutType.切换;
        }

        private void m_CancelButton_Click(object sender, EventArgs e)
        {
            this.LogoutType = LogoutType.取消;
        }
    }
}
