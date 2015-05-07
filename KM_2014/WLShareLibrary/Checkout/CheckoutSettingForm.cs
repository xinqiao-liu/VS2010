using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Checkout
{
    public partial class CheckoutSettingForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (CheckoutSettingForm checkoutSettingForm = new CheckoutSettingForm())
            {
                return checkoutSettingForm.ShowDialog();
            }
        }

        public CheckoutSettingForm()
        {
            InitializeComponent();
        }

        private void CheckoutSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    WLDataModelLayer.Node node = this.cboNode.SelectedItem as WLDataModelLayer.Node;
                    if (node != null)
                    {
                        WLDataLogicLayer.Setting.NodeCode = node.Code;
                        WLDataLogicLayer.Setting.NodeName = node.Name;
                        WLDataLogicLayer.Setting.CityCode = node.CityCode;
                        WLDataLogicLayer.Setting.CityName = node.CityName;
                    }

                    WLDataLogicLayer.Setting.JZDay = Convert.ToInt32(this.numJZDay.Value);
                    WLDataLogicLayer.Setting.JZDefValue = this.numJZDefValue.Value;
                    WLDataLogicLayer.Setting.CSDefValue = this.numCSDefValue.Value;

                    WLDataLogicLayer.Setting.UpdateItems(WLDataLogicLayer.Setting.Array);

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CheckoutSettingForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Node.Refresh(this.cboNode);

                this.cboNode.SelectedIndex = this.cboNode.FindStringExact(WLDataLogicLayer.Setting.NodeCode + "-" + WLDataLogicLayer.Setting.NodeName);

                this.numJZDay.Value = WLDataLogicLayer.Setting.JZDay;
                this.numJZDefValue.Value = WLDataLogicLayer.Setting.JZDefValue;
                this.numCSDefValue.Value = WLDataLogicLayer.Setting.CSDefValue;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
