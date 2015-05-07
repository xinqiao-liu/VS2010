using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Operation
{
    public partial class PayinForm : Form
    {
        public WLDataModelLayer.Payin Item
        {
            get 
            { 
                return new WLDataModelLayer.Payin(){
                    Date = WLDataLogicLayer.Runtime.CurrentDate,
                    Userid = WLDataLogicLayer.User.LoginUser.Userid,
                    BDS = Convert.ToInt32(this.txtBDS.Text),
                    FDS = Convert.ToInt32(this.txtFDS.Text),
                    TYF = Convert.ToDecimal(this.txtTYF.Text),
                    BZF = Convert.ToDecimal(this.txtBZF.Text),
                    BXF = Convert.ToDecimal(this.txtBXF.Text),
                    Total = Convert.ToDecimal(this.txtTotal.Text),
                    Money = Convert.ToDecimal(this.txtTotal.Text),
                    Count = 1,
                    UID = WLDataLogicLayer.User.LoginUser.Userid
                };
            }
        }

        private void PayinRefresh(DateTime date, string uid)
        {
            int bds = 0, fds = 0, zlbz = 0, wjd = 0, xbz = 0, dbz = 0;
            decimal tyf = 0, bxf = 0, bzf = 0;

            foreach (WLDataModelLayer.WLB item in WLDataLogicLayer.WLB.ReadLocalByUID(WLDataLogicLayer.Setting.NodeCode, date, uid))
            {
                if (item.ZT_Type != WLDataModelLayer.ZTType.作废)
                {
                    bds++;
                    tyf += item.TYF;
                    bxf += item.BXF;
                    bzf += item.BZF;

                    switch (WLDataLogicLayer.BZFLB.GetName(item.BZF))
                    {
                        case "文件袋": wjd++; break;
                        case "小包装": xbz++; break;
                        case "大包装": dbz++; break;
                        default: zlbz++; break;
                    }
                }
                else fds++;
            }

            this.txtBDS.Text = bds.ToString();
            this.txtFDS.Text = fds.ToString();
            this.txtTYF.Text = tyf.ToString("N2");
            this.txtBXF.Text = bxf.ToString("N2");
            this.txtBZF.Text = bzf.ToString("N2");
            this.txtZLBZ.Text = zlbz.ToString();
            this.txtWJD.Text = wjd.ToString();
            this.txtXBZ.Text = xbz.ToString();
            this.txtDBZ.Text = dbz.ToString();

            this.txtTotal.Text = (tyf + bzf + bxf).ToString("N2");
        }

        public static void InitAndShowDialog()
        {
            using (PayinForm payinForm = new PayinForm()) 
            {
                payinForm.txtUserid.Text = WLDataLogicLayer.User.LoginUser.Userid;
                payinForm.ShowDialog(); 
            }
        }

        public PayinForm()
        {
            InitializeComponent();
        }

        private void PayinForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.WLB.RefreshLocalAllDates(this.cboDate, System.Data.SqlClient.SortOrder.Descending);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }   
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            try
            {
                this.PayinRefresh(Convert.ToDateTime(this.cboDate.Text), this.txtUserid.Text); this.btnOk.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (WLDataLogicLayer.Payin.Exists(this.Item.Date, this.Item.Userid))
                    WLDataLogicLayer.Payin.Update(this.Item);
                else
                    WLDataLogicLayer.Payin.Insert(this.Item);

                this.btnOk.Enabled = false;
                MessageBox.Show(string.Format("用户 {0} 缴款成功。", WLDataLogicLayer.User.LoginUser.Userid), "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
