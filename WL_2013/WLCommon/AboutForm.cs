using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon
{
    public partial class AboutForm : Form
    {
        public static DialogResult InitAndShowDialog(Common.AboutInfo aboutInfo)
        {
            using (AboutForm aboutForm = new AboutForm())
            {
                if (aboutInfo == null) throw new NullReferenceException();

                aboutForm.txtSoftwareName.Text = aboutInfo.SoftwareName;
                aboutForm.txtSoftwareVersion.Text = aboutInfo.SoftwareVersion;
                aboutForm.txtTechnicalSupport.Text = aboutInfo.TechnicalSupport;

                return aboutForm.ShowDialog();
            }
        }

        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
