using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WLDataLogicLayer
{
    public static class ZDB
    {
        public static WLDataModelLayer.ZDB Check(string prefix, WLDataModelLayer.ZDB item)
        {
            Common.Validate.ValidPositiveInt(prefix, "年度", item.Year);
            Common.Validate.ValidPositiveInt(prefix, "月份", item.Month);
            Common.Validate.ValidString(prefix, "账单名称", 32, item.Name);
            Common.Validate.ValidString(prefix, "用户编号", 8, item.UID);
            return item;
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.ZDB i in WLDataAccessLayer.ZDB.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem item = new ListViewItem(i.Year.ToString());
                item.Tag = i;
                item.SubItems.Add(i.Month.ToString());
                item.SubItems.Add(i.Name);
                item.SubItems.Add(i.SDT.ToString("yyyy-MM-dd"));
                item.SubItems.Add(i.EDT.ToString("yyyy-MM-dd"));

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        //通过指定结账日期获取本月起始结账日期
        public static DateTime GetMinDate(DateTime nowDate, int day)
        {
            return (Convert.ToDateTime(nowDate.AddMonths(-1).ToString("yyyy-MM-") + day.ToString())).AddDays(1);
        }

        //通过指定结账日期获取本月截止结账日期
        public static DateTime GetMaxDate(DateTime nowDate, int day)
        {
            return Convert.ToDateTime(nowDate.ToString("yyyy-MM-") + day.ToString());
        }

        public static bool Exists(WLDataModelLayer.ZDB item)
        {
            return WLDataAccessLayer.ZDB.Exists(Runtime.B_CreateCommand(), Check("检测账单记录", item));
        }

        public static bool Insert(WLDataModelLayer.ZDB item)
        {
            return WLDataAccessLayer.ZDB.Insert(Runtime.B_CreateCommand(), Check("插入账单记录", item));
        }

        public static void Delete(WLDataModelLayer.ZDB item)
        {
            Check("删除账单记录", item);
            using (SqlTransaction tran = Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        WLDataAccessLayer.ZDMXB.Delete(cmd, item.Year, item.Month);
                        WLDataAccessLayer.ZDHZB.Delete(cmd, item.Year, item.Month);
                        WLDataAccessLayer.ZDB.Delete(cmd, item);
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

        //获取指定日期范围结账单明细记录
        public static List<WLDataModelLayer.ZDMXB> GetCheckoutMX(WLDataModelLayer.ZDB item)
        {
            return WLDataAccessLayer.ZDB.GetCheckoutMX(Runtime.B_CreateCommand(), Check("获取结账明细记录", item));
        }

        //获取指定日期范围结账单明细记录
        public static List<WLDataModelLayer.ZDHZB> GetCheckoutHZ(WLDataModelLayer.ZDB item, string userid)
        {
            return WLDataAccessLayer.ZDB.GetCheckoutHZ(Runtime.B_CreateCommand(), Check("获取结账汇总记录", item), userid);
        }
    }
}
