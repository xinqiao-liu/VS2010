﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WLDataLogicLayer
{
    public static class ZDMXB
    {
        public static WLDataModelLayer.ZDMXB Check(string prefix, WLDataModelLayer.ZDMXB item)
        {
            Common.Validate.ValidPositiveInt(prefix, "年度", item.Year);
            Common.Validate.ValidPositiveInt(prefix, "月份", item.Month);
            Common.Validate.ValidString(prefix, "结账代码", 8, item.Code);
            Common.Validate.ValidString(prefix, "车牌号", 8, item.CPH);
            Common.Validate.ValidPositiveInt(prefix, "运单数", item.Count);
            Common.Validate.ValidDecimal(prefix, "运单额", item.Total);
            Common.Validate.ValidDecimal(prefix, "结算比率", item.Ratio);
            Common.Validate.ValidDecimal(prefix, "结账金额", item.Money);
            return item;
        }

        public static void Refresh(ListView list, int year, int month, string code)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.ZDMXB i in Reads(year, month, code))
            {
                ListViewItem item = new ListViewItem(i.CPH);
                item.Tag = i;
                item.SubItems.Add(i.Count.ToString());
                item.SubItems.Add(i.Total.ToString("N2"));
                item.SubItems.Add(i.Ratio.ToString("N2"));
                item.SubItems.Add(i.Money.ToString("N2"));

                list.Items.Add(item);
            }

            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static void InsertItems(List<WLDataModelLayer.ZDMXB> items)
        {
            using (SqlTransaction tran = Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        foreach (WLDataModelLayer.ZDMXB item in items)
                        {
                            if (!WLDataAccessLayer.ZDMXB.Insert(cmd, Check("插入账单明细记录", item))) throw new DataException("插入账单明细项失败！");
                        }
                        tran.Commit();
                    }
                    catch(Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<WLDataModelLayer.ZDMXB> Reads(int year, int month, string code)
        {
            return WLDataAccessLayer.ZDMXB.Reads(Runtime.B_CreateCommand(), year, month, code);
        }
    }
}
