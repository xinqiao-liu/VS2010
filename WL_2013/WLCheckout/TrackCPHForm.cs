using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCheckout
{
    public partial class TrackCPHForm : Form
    {
        public string CPH
        {
            set
            {
                this.Text += (" - " + value);

                foreach (WLDataModelLayer.ZDMXB item in WLDataLogicLayer.ZDMXB.Reads(value))
                {
                    ListViewItem i = new ListViewItem(item.CPH);
                    i.Tag = item;
                    i.SubItems.Add(item.Year.ToString());
                    i.SubItems.Add(item.Month.ToString());
                    i.SubItems.Add(item.Code);

                    this.list.Items.Add(i);
                }
            }
        }

        public TrackCPHForm()
        {
            InitializeComponent();
        }
    }
}
