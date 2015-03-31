using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WLDataLogicLayer
{
    public static class ZDHZB
    {
        public static WLDataModelLayer.ZDHZB Check(string prefix, WLDataModelLayer.ZDHZB item)
        {
            Common.Validate.ValidPositiveInt(prefix, "年度", item.Year);
            Common.Validate.ValidPositiveInt(prefix, "月份", item.Month);
            Common.Validate.ValidString(prefix, "结账代码", 8, item.Code);
            Common.Validate.ValidPositiveInt(prefix, "车辆数", item.Cars);
            Common.Validate.ValidPositiveInt(prefix, "运单总数", item.Count);
            Common.Validate.ValidDecimal(prefix, "运单总额", item.Total);
            Common.Validate.ValidDecimal(prefix, "结账金额", item.Money);
            Common.Validate.ValidString(prefix, "用户编号", 8, item.UID);
            return item;
        }

        public static void Refresh(ListView list, int year, int month)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.ZDHZB i in Reads(year, month))
            {
                ListViewItem item = new ListViewItem(i.Year.ToString());
                item.Tag = i;
                item.SubItems.Add(i.Month.ToString());
                item.SubItems.Add(i.Code);
                item.SubItems.Add(i.Name);
                item.SubItems.Add(i.Cars.ToString());
                item.SubItems.Add(i.Count.ToString());
                item.SubItems.Add(i.Total.ToString("N2"));
                item.SubItems.Add(i.Money.ToString("N2"));
                item.SubItems.Add(i.UID);
                item.SubItems.Add(i.CDT.ToString("yyyy-MM-dd"));

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static void InsertItems(List<WLDataModelLayer.ZDHZB> items)
        {
            using (SqlTransaction tran = Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        foreach (WLDataModelLayer.ZDHZB item in items)
                        {
                            if (!WLDataAccessLayer.ZDHZB.Insert(cmd, Check("插入账单汇总记录", item))) throw new DataException("插入账单汇总项失败！");
                        }
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<WLDataModelLayer.ZDHZB> Reads(int year, int month)
        {
            return WLDataAccessLayer.ZDHZB.Reads(Runtime.B_CreateCommand(), year, month);
        }
    }
}
