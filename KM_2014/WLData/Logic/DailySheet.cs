using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataLogicLayer
{
    public static class DailySheet
    {
        //获取日期列表
        public static List<DateTime> GetDates(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Ascending)
        {
            return WLDataAccessLayer.DailySheet.GetDates(Runtime.B_CreateCommand(), mode);
        }

        //读取指定日期日报表
        public static List<WLDataModelLayer.DailySheet> Reads(DateTime date)
        {
            return WLDataAccessLayer.DailySheet.Reads(Runtime.B_CreateCommand(), date);
        }

        //上传日报表到汇总数据库中
        public static void UploadToCollect(DateTime date)
        {   
            //初始化日报表数据
            WLDataModelLayer.DailySheet item = WLDataAccessLayer.WLB.GetLocalDailySheet(Runtime.B_CreateCommand(), WLDataLogicLayer.Setting.NodeCode, date);
            item.NodeName = Setting.NodeName;
            item.UID = User.LoginUser.Userid;

            SqlCommand cmd;
            //如果使用统一数据库，则使用基础数据连接，否则使用指定汇总连接
            if(Runtime.UnifiedDataSource)
                cmd = Runtime.B_CreateCommand();
            else
                cmd = Runtime.C_CreateCommand();

            if (WLDataAccessLayer.DailySheet.Exists(cmd, item))
                WLDataAccessLayer.DailySheet.Delete(cmd, item);

            WLDataAccessLayer.DailySheet.Insert(cmd, item);
        }
    }
}
