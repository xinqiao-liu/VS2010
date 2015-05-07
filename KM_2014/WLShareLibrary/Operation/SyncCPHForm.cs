using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Operation
{
    public partial class SyncCPHForm : Form
    {
        private void ResetKYConnection(string fh_code)
        {
            ////获取网点数据
            //WLDataModelLayer.Node node = WLDataLogicLayer.Node.Read(fh_code);
            //if (node != null)
            //{
            //    //获取授权客运连接
            //    Common.ConnectionInfo connectionInfo = new Common.ConnectionInfo(); //node.KConnection;
            //    if (connectionInfo != null)
            //    {
            //        //如果连接已打开，则先关闭
            //        if (KYDataLogicLayer.Connection.KYConnectionState) KYDataLogicLayer.Connection.ConnectionClose();

            //        //ping 通后打开该授权连接
            //        if (Common.Connection.Ping(connectionInfo.ServerAddress))
            //            KYDataLogicLayer.Connection.ConnectionOpen(connectionInfo);
            //        else
            //            throw new InvalidOperationException("未Ping通网点'" + fh_code + "'客运连接地址！");
            //    }
            //    else throw new NullReferenceException("网点'" + fh_code + "'未授权客运连接！");
            //}
            //else throw new NullReferenceException("无法获取'" + fh_code + "'网点数据！");
        }

        private void Append(WLDataModelLayer.WLB wlItem, string newCPH)
        {
            ListViewItem item = new ListViewItem(wlItem.SN);
            item.Tag = wlItem;
            item.SubItems.Add(wlItem.CDT.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(wlItem.CZ_BC);
            item.SubItems.Add(wlItem.CZ_CPH);
            item.SubItems.Add(newCPH);
            list.Items.Add(item).Checked = true;    //缺省为选中
        }

        public static DialogResult InitAndShowDialog()
        {
            using (SyncCPHForm syncCPHForm = new SyncCPHForm())
            {
                return syncCPHForm.ShowDialog();
            }
        }

        public SyncCPHForm()
        {
            InitializeComponent();
        }

        private void SyncCPHForm_Load(object sender, EventArgs e)
        {
            try
            {
                ////获取未日结承运日期列表
                //WLDataLogicLayer.WLB.RefreshWorkDates(this.cboRQ);

                //if (this.cboRQ.Items.Count > 0)
                //{
                //    this.btnCheck.Enabled = true;
                //    this.btnSync.Enabled = true;
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                //if (this.cboRQ.SelectedIndex < 0) throw new InvalidOperationException("为指定有效承运日期！");

                //string fh_code = string.Empty;

                ////获取承运日期运单列表
                //foreach (WLDataModelLayer.WLB wlItem in WLDataLogicLayer.WLB.Reads_CZRQ(Convert.ToDateTime(this.cboRQ.Text)))
                //{
                //    //检测发货网点代码是否改变，如改变重置客运数据连接
                //    if (fh_code != wlItem.FH_Code) this.ResetKYConnection(fh_code);
                                        
                //    KYDataModelLayer.BCK bcItem = KYDataLogicLayer.BCK.Read(wlItem.CZ_RQ, wlItem.CZ_BC);
                //    if (bcItem != null)
                //    {
                //        //循环检测运单项班次所对应承运车辆是否改变，如改变则添加变更信息到list中   
                //        if (wlItem.CZ_CPH != bcItem.CPH) this.Append(wlItem, bcItem.CPH);
                //    }
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            try
            {
                //if (this.list.Items.Count < 0) throw new InvalidOperationException("不存在可用变更信息！");

                ////循环list中的变更信息
                //foreach (ListViewItem item in this.list.Items)
                //{
                //    //排除未选择的变更信息
                //    if (!item.Checked) continue;

                //    WLDataModelLayer.WLB wlItem = item.Tag as WLDataModelLayer.WLB;
                //    if (wlItem != null)
                //    {
                //        //获取新承运车辆，并修改关联运单
                //        wlItem.CZ_CPH = item.SubItems[4].Text;
                //        WLDataLogicLayer.WLB.Update(wlItem);

                //        //添加变更信息到改单表中
                //        WLDataLogicLayer.GDB.Insert(new WLDataModelLayer.GDB()
                //        {
                //            Node = wlItem.Node,
                //            Date = wlItem.Date,
                //            SN = wlItem.SN,
                //            OldRQ = wlItem.CZ_RQ,
                //            OldBC = wlItem.CZ_BC,
                //            OldCPH = item.SubItems[3].Text,
                //            NewRQ = wlItem.CZ_RQ,
                //            NewBC = wlItem.CZ_BC,
                //            NewCPH = wlItem.CZ_CPH,
                //            RecordType = "S",
                //            UID = WLDataLogicLayer.User.Item.Userid,
                //        });
                //    }
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
