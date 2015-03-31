using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLManager
{
    public partial class ChangeForm : Form
    {
        private WLDataModelLayer.WLB OriginalItem { get; set; }

        public void Init(WLDataModelLayer.WLB item)
        {
            this.txtSN.Text = item.SN;
            this.txtCPH.Text = item.CZ_CPH;
            this.txtCPH.SelectAll();
            this.txtCPH.Focus();

            this.OriginalItem = item;
        }

        public WLDataModelLayer.WLB Build()
        {
            WLDataModelLayer.WLB item = this.OriginalItem.Clone();
            item.CZ_CPH = this.txtCPH.Text.ToUpper();
            return item;
        }

        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;

                    string cph = this.txtCPH.Text.ToUpper();
                    if (cph == string.Empty)
                    {
                        MessageBox.Show("车牌号为空，不能办理换车！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtCPH.Focus(); return;
                    }

                    if (cph.Length != 7)
                    {
                        MessageBox.Show("车牌号长度不符，不能办理换车！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtCPH.Focus(); return;
                    }

                    if (cph == this.OriginalItem.CZ_CPH)
                    {
                        MessageBox.Show("车牌号未改变，不能办理换车！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtCPH.Focus(); return;
                    } 
                    
                    WLDataLogicLayer.WLB.SetCZCPH(this.OriginalItem.Node, this.OriginalItem.Date, this.OriginalItem.SN, cph);
                    WLDataLogicLayer.GDB.Insert(new WLDataModelLayer.GDB()
                    {
                        Node = OriginalItem.Node,
                        Date = OriginalItem.Date,
                        SN = OriginalItem.SN,
                        OldRQ = OriginalItem.CZ_RQ,
                        OldBC = OriginalItem.CZ_BC,
                        OldCPH = OriginalItem.CZ_CPH,
                        NewRQ = OriginalItem.CZ_RQ,
                        NewBC = OriginalItem.CZ_BC,
                        NewCPH = cph,
                        RecordType = "M",
                        UID = WLDataLogicLayer.User.LoginUser.Userid
                    });

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtCPH_TextChanged(object sender, EventArgs e)
        {
            try
            {                
                //映射车牌号
                string cph = this.txtCPH.Text.ToUpper();
                if (cph != string.Empty && WLDataLogicLayer.Mapping.Array.ContainsKey(cph))
                {
                    this.txtCPH.Text = WLDataLogicLayer.Mapping.Array[cph];
                    this.txtCPH.Select(cph.Length, 0);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
