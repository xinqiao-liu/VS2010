using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.JP
{
    public partial class JPBCForm : Form
    {
        public List<String> BCList
        {
            set
            {
                this.list.Items.Clear();
                foreach (string item in value)
                {
                    this.list.Items.Add(item);
                }
            }
        }

        public JPBCForm()
        {
            InitializeComponent();
        }
    }
}
