using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataLogicLayer
{
    public static class DailyReport
    {
        //检测日报表是否存在
        public static bool Exists(WLDataModelLayer.DailyReport item)
        {
            return WLDataAccessLayer.DailyReport.Exists(Runtime.B_CreateCommand(), item);
        }
        
        //插入日报表
        public static bool Insert(WLDataModelLayer.DailyReport item)
        {
            return WLDataAccessLayer.DailyReport.Insert(Runtime.B_CreateCommand(), item);
        }

        //更新日报表
        public static bool Update(WLDataModelLayer.DailyReport item)
        {
            return WLDataAccessLayer.DailyReport.Update(Runtime.B_CreateCommand(), item);
        }

        //删除日报表
        public static bool Delete(WLDataModelLayer.DailyReport item)
        {
            return WLDataAccessLayer.DailyReport.Delete(Runtime.B_CreateCommand(), item);
        }

        //获取日期列表
        public static List<DateTime> GetDates(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Ascending)
        {
            return WLDataAccessLayer.DailyReport.GetDates(Runtime.B_CreateCommand(), mode);
        }

        //读取指定日期日报表
        public static List<WLDataModelLayer.DailyReport> Reads(DateTime date)
        {
            return WLDataAccessLayer.DailyReport.Reads(Runtime.B_CreateCommand(), date);
        }
    }
}
