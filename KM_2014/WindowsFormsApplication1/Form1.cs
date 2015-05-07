using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=172.26.9.240;Initial Catalog=kyz_bs;Persist Security Info=True;User ID=net;Password=net2008";
            bool pingEnabled = true;
            int pingTimeout = 2000;

            using (Common.BaseConnection conn = new Common.BaseConnection(connStr, null, pingEnabled, pingTimeout))
            {
                KM.KYData.Entry.CPB.Query_CT(conn.CreateCommand(), DateTime.Parse("2014-8-12"), 5);
            }

        }
    }
}
