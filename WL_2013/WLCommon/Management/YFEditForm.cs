using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class YFEditForm : Form
    {
        public string YFName { set; get; }
        public WLDataModelLayer.YFB Item { set; get; }

        public YFEditForm()
        {
            InitializeComponent();
        }

        private void YFEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    Item.SM = Convert.ToInt32(this.numSM.Value);
                    Item.EM = Convert.ToInt32(this.numEM.Value);
                    Item.BF = this.numBF.Value;
                    Item.BW = this.numBW.Value;
                    Item.Weight = Convert.ToInt32(this.numWeight.Value);
                    Item.Excess = this.numExcess.Value;
                    Item.Factor = this.numFactor.Value;
      
                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void YFEditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.Item != null)
                {
                    this.txtName.Text = Item.Name;
                    this.numSM.Value = Item.SM;
                    this.numEM.Value = Item.EM;
                    this.numBF.Value = Item.BF;
                    this.numBW.Value = Item.BW;
                    this.numWeight.Value = Item.Weight;
                    this.numExcess.Value = Item.Excess;
                    this.numFactor.Value = Item.Factor;
                }
                else
                {
                    this.tabControl.Enabled = false;
                    this.btnOK.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
