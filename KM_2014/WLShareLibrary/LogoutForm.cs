using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon
{
    public partial class LogoutForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (LogoutForm logoutForm = new LogoutForm())
            {
                return logoutForm.ShowDialog();
            }
        }

        public LogoutForm()
        {
            InitializeComponent();
        }
    }
}
