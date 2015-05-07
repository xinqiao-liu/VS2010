using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class BaseSettingForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (BaseSettingForm baseSettingForm = new BaseSettingForm())
            {
                return baseSettingForm.ShowDialog();
            }
        }

        public BaseSettingForm()
        {
            InitializeComponent();
        }

        private void BaseSettingForm_FormClosing(object sender, FormClosingEventArgs e)
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

                    WLDataLogicLayer.Setting.BillBits = Convert.ToInt32(this.numBillBits.Value);
                    WLDataLogicLayer.Setting.BillZeroize = this.chkBillZeroize.Checked;
                    WLDataLogicLayer.Setting.SyncCentral = this.chkSyncCentral.Checked;
                    WLDataLogicLayer.Setting.SecurityCheck = this.chkSecurityCheck.Checked;

                    WLDataLogicLayer.Setting.HWJSJoinCalc = this.chkHWJSJoinCalc.Checked;
                    WLDataLogicLayer.Setting.ManualModify = this.chkManualModify.Checked;
                    WLDataLogicLayer.Setting.SaveCustomer = this.chkSaveCustomer.Checked;
                    WLDataLogicLayer.Setting.OnlyToday = this.chkOnlyToday.Checked;
                    WLDataLogicLayer.Setting.ChargeBZF = this.chkBZF.Checked;
                    WLDataLogicLayer.Setting.AllowDF = this.chkAllowDF.Checked;
                    WLDataLogicLayer.Setting.AllowJZ = this.chkAllowJZ.Checked;
                    WLDataLogicLayer.Setting.AutoSelectYF = this.chkAutoSelectYF.Checked;
                    WLDataLogicLayer.Setting.GDCheckCPH = this.chkGDCheckCPH.Checked;

                    WLDataLogicLayer.Setting.ChargeBXF = this.chkBXF.Checked;
                    WLDataLogicLayer.Setting.BXFAutoCalc = this.chkBXFAutoCalc.Checked;
                    WLDataLogicLayer.Setting.BXFRound = this.chkBXFRound.Checked;
                    WLDataLogicLayer.Setting.BXFMin = this.numBXFMin.Value;
                    WLDataLogicLayer.Setting.BXFMax = this.numBXFMax.Value;
                    WLDataLogicLayer.Setting.BXFRatio = this.numBXFRatio.Value;

                    WLDataLogicLayer.Setting.UpdateItems(WLDataLogicLayer.Setting.Array);

                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BaseSettingForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Node.Refresh(this.cboNode);

                this.cboNode.SelectedIndex = this.cboNode.FindStringExact(WLDataLogicLayer.Setting.NodeCode + "-" + WLDataLogicLayer.Setting.NodeName);

                this.numBillBits.Value = WLDataLogicLayer.Setting.BillBits;
                this.chkBillZeroize.Checked = WLDataLogicLayer.Setting.BillZeroize;
                this.chkSyncCentral.Checked = WLDataLogicLayer.Setting.SyncCentral;
                this.chkSecurityCheck.Checked = WLDataLogicLayer.Setting.SecurityCheck;

                this.chkHWJSJoinCalc.Checked = WLDataLogicLayer.Setting.HWJSJoinCalc;
                this.chkManualModify.Checked = WLDataLogicLayer.Setting.ManualModify;
                this.chkSaveCustomer.Checked = WLDataLogicLayer.Setting.SaveCustomer;
                this.chkOnlyToday.Checked = WLDataLogicLayer.Setting.OnlyToday;
                this.chkBZF.Checked = WLDataLogicLayer.Setting.ChargeBZF;
                this.chkAllowDF.Checked = WLDataLogicLayer.Setting.AllowDF;
                this.chkAllowJZ.Checked = WLDataLogicLayer.Setting.AllowJZ;
                this.chkAutoSelectYF.Checked = WLDataLogicLayer.Setting.AutoSelectYF;
                this.chkGDCheckCPH.Checked = WLDataLogicLayer.Setting.GDCheckCPH;

                this.chkBXF.Checked = WLDataLogicLayer.Setting.ChargeBXF;
                this.chkBXFAutoCalc.Checked = WLDataLogicLayer.Setting.BXFAutoCalc;
                this.chkBXFRound.Checked = WLDataLogicLayer.Setting.BXFRound;
                this.numBXFMin.Value = WLDataLogicLayer.Setting.BXFMin;
                this.numBXFMax.Value = WLDataLogicLayer.Setting.BXFMax;
                this.numBXFRatio.Value = WLDataLogicLayer.Setting.BXFRatio;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
