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
    public partial class AccountNewForm : Form
    {
        public WLDataModelLayer.ZDB Accounts { get; private set; }

        public void Check()
        {
            if (this.minDate.Value > this.maxDate.Value) throw new ApplicationException("起始日期不能大于截止日期！"); 
        }

        public WLDataModelLayer.ZDB Build()
        {
            WLDataModelLayer.ZDB item = new WLDataModelLayer.ZDB()
            {
                Year = Convert.ToInt32(this.cboYear.Text),
                Month = Convert.ToInt32(this.cboMonth.Text),
                Name = this.txtName.Text,
                SDT = this.minDate.Value,
                EDT = this.maxDate.Value,
                Rounding = (WLDataModelLayer.RoundingType)this.cboRoundingType.SelectedItem,
                UID = WLDataLogicLayer.User.LoginUser.Username
            };
            return item;
        }

        public AccountNewForm()
        {
            InitializeComponent();
        }

        private void AccountsNewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;

                    //检测并构建账单
                    this.Check();
                    this.Accounts = this.Build();

                    //检测并插入账单
                    if (WLDataLogicLayer.ZDB.Exists(this.Accounts))
                    {
                        string msg = string.Format("'{0}'账单已存在，是否删除并重新生成？", this.Accounts);
                        if (MessageBox.Show(msg, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;

                        WLDataLogicLayer.ZDB.Delete(this.Accounts);
                    }
                    WLDataLogicLayer.ZDB.Insert(this.Accounts);

                    //插入结账明细记录
                    List<WLDataModelLayer.ZDMXB> mxs = WLDataLogicLayer.ZDB.GetCheckoutMX(this.Accounts);
                    foreach (WLDataModelLayer.ZDMXB i in mxs)
                    {
                        WLDataModelLayer.CSXXB csxxb;
                        WLDataModelLayer.JZDMB jzdmb;

                        #region 获取车属信息及记账代码记录

                        if (!WLDataLogicLayer.CSXXB.Exists(i.CPH)) 
                            throw new ApplicationException(string.Format("{0} 车属信息记录不存在！", i.CPH));
                        if ((csxxb = WLDataLogicLayer.CSXXB.Read(i.CPH)) == null) 
                            throw new ApplicationException(string.Format("无法获取 {0} 车属信息记录！", i.CPH));

                        if (!WLDataLogicLayer.JZDMB.Exists(csxxb.Code)) 
                            throw new ApplicationException(string.Format("{0} 结账代码记录不存在！", csxxb.Code));
                        if ((jzdmb = WLDataLogicLayer.JZDMB.Read(csxxb.Code)) == null) 
                            throw new ApplicationException(string.Format("无法获取 {0} 结账代码记录！", csxxb.Code));

                        #endregion

                        #region 完善结账明细记录

                        i.Code = csxxb.Code;

                        if (jzdmb.Mode == 0)
                            i.Ratio = jzdmb.Value;  //使用统一比率
                        else
                            i.Ratio = csxxb.Value;  //使用独立比率                        

                        switch (this.Accounts.Rounding)
                        {
                            case WLDataModelLayer.RoundingType.取整:
                                i.Money = Decimal.Round(i.Total * i.Ratio, 0); break;
                            case WLDataModelLayer.RoundingType.保留角:
                                i.Money = Decimal.Round(i.Total * i.Ratio, 1); break;
                            case WLDataModelLayer.RoundingType.保留分:
                                i.Money = Decimal.Round(i.Total * i.Ratio, 2); break;
                            default: break;
                        }                       
                        #endregion
                    }
                    WLDataLogicLayer.ZDMXB.InsertItems(mxs);

                    //插入账单明细汇总
                    WLDataLogicLayer.ZDHZB.InsertItems(WLDataLogicLayer.ZDB.GetCheckoutHZ(this.Accounts, WLDataLogicLayer.User.LoginUser.Userid));

                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AccountsNewForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.cboYear.Text = WLDataLogicLayer.Runtime.CurrentDate.Year.ToString();
                this.cboMonth.Text = WLDataLogicLayer.Runtime.CurrentDate.Month.ToString();
                this.txtName.Text = this.cboYear.Text + "年" + this.cboMonth.Text + "月账单";
                this.minDate.Value = WLDataLogicLayer.ZDB.GetMinDate(WLDataLogicLayer.Runtime.CurrentDate, WLDataLogicLayer.Setting.JZDay);
                this.maxDate.Value = WLDataLogicLayer.ZDB.GetMaxDate(WLDataLogicLayer.Runtime.CurrentDate, WLDataLogicLayer.Setting.JZDay);

                WLDataModelLayer.ZDB.RoundTypeList(this.cboRoundingType);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDetectCPH_Click(object sender, EventArgs e)
        {
            try
            {
                DetectCPHForm.InitAndShowDialog(this.minDate.Value, this.maxDate.Value);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
