using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class EndOfDay
    {
        public static bool Exists(DateTime date)
        {
            return WLDataAccessLayer.EndOfDay.Exists(Runtime.B_CreateCommand(), date);
        }

        public static bool Insert(WLDataModelLayer.EndOfDay item)
        {
            return WLDataAccessLayer.EndOfDay.Insert(Runtime.B_CreateCommand(), item);
        }

        public static List<DateTime> GetDates()
        {
            return WLDataAccessLayer.EndOfDay.GetDates(Runtime.B_CreateCommand());
        }

        public static List<WLDataModelLayer.EndOfDay> Reads(DateTime date)
        {
            return WLDataAccessLayer.EndOfDay.Reads(Runtime.B_CreateCommand(), date);
        }
    }
}
