using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class NodeForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (NodeForm nodeForm = new NodeForm())
            {
                return nodeForm.ShowDialog();
            }
        }

        public NodeForm()
        {
            InitializeComponent();
        }

        private void NodeForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Node.Refresh(this.list);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
