using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class Payin
    {
        public static WLDataModelLayer.Payin Check(string prefix, WLDataModelLayer.Payin item)
        {
            Common.Validate.ValidString(prefix, "缴款用户编号", 8, item.Userid);
            Common.Validate.ValidString(prefix, "操作用户编号", 8, item.UID);

            Common.Validate.ValidPositiveInt(prefix, "托运数", item.BDS);
            Common.Validate.ValidPositiveInt(prefix, "废单数", item.FDS);

            Common.Validate.ValidDecimal(prefix, "托运费", item.TYF);
            Common.Validate.ValidDecimal(prefix, "包装费", item.BZF);
            Common.Validate.ValidDecimal(prefix, "保险费", item.BXF);
            Common.Validate.ValidDecimal(prefix, "合计金额", item.Total);
            Common.Validate.ValidDecimal(prefix, "实缴金额", item.Money);
            return item;
        }

        public static bool Exists(DateTime date, string userid)
        {
            return WLDataAccessLayer.Payin.Exists(Runtime.B_CreateCommand(), date, userid);
        }

        public static bool Insert(WLDataModelLayer.Payin item)
        {
            return WLDataAccessLayer.Payin.Insert(Runtime.B_CreateCommand(), Check("插入用户缴款数据", item));
        }

        public static bool Update(WLDataModelLayer.Payin item)
        {
            return WLDataAccessLayer.Payin.Update(Runtime.B_CreateCommand(), Check("更新用户缴款数据", item));
        }

        public static List<DateTime> GetDates(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Ascending)
        {
            return WLDataAccessLayer.Payin.GetDates(Runtime.B_CreateCommand(), mode);
        }

        public static List<WLDataModelLayer.Payin> Reads(DateTime date)
        {
            return WLDataAccessLayer.Payin.Reads(Runtime.B_CreateCommand(), date);
        }
    }
}
