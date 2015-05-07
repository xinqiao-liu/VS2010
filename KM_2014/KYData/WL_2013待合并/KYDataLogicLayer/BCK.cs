using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace KYDataLogicLayer
{
    public static class BCK
    {
        //刷新物流下单班次信息列表
        public static void RefreshByZDDM(ListView list, DateTime date, string code)
        {
            list.Items.Clear();
            foreach (KYDataModelLayer.BCK i in KYDataAccessLayer.BCK.ReadByZDDM(Runtime.B_CreateCommand(), date, code))
            {
                ListViewItem item = new ListViewItem(i.CPH);
                item.Tag = i;
                item.SubItems.Add(i.CC);
                item.SubItems.Add(i.FCSJ);
                item.SubItems.Add(i.QZLC.ToString());
                item.SubItems.Add(i.ZT);

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) list.Items[0].Selected = true;
        }

        //刷新物流下单班次信息列表（不受班次状态限制）
        public static void RefreshAllByZDDM(ListView list, DateTime date, string code)
        {
            list.Items.Clear();
            foreach (KYDataModelLayer.BCK i in KYDataAccessLayer.BCK.ReadAllByZDDM(Runtime.B_CreateCommand(), date, code))
            {
                ListViewItem item = new ListViewItem(i.CPH);
                item.Tag = i;
                item.SubItems.Add(i.CC);
                item.SubItems.Add(i.FCSJ);
                item.SubItems.Add(i.QZLC.ToString());
                item.SubItems.Add(i.ZT);

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) list.Items[0].Selected = true;
        }

        //刷新营运日期列表
        public static void RefreshDateList(ComboBox list, DateTime today, bool onlyToday)
        {
            list.Items.Clear();

            if (onlyToday) list.Items.Add(today.ToString("yyyy-MM-dd"));
            else
            {
                foreach (DateTime i in KYDataAccessLayer.BCK.GetDates(Runtime.B_CreateCommand()))
                {
                    if (i >= today) list.Items.Add(i.ToString("yyyy-MM-dd"));
                }
            }
            if (list.Items.Count > 0) list.SelectedIndex = 0;
        }

        //public static bool Exist(DateTime rq, String cc)
        //{
        //    return KYDataAccessLayer.BCK.Exist(Runtime.BaseConnection.CreateCommand(), rq, cc);
        //}

        //public static bool ExistByZDDM(DateTime rq, String code)
        //{
        //    return KYDataAccessLayer.BCK.ExistByZDDM(Runtime.B_CreateCommand(), rq, code);
        //}

        //public static KYDataModelLayer.BCK Read(DateTime rq, String cc)
        //{
        //    return KYDataAccessLayer.BCK.Read(Runtime.BaseConnection.CreateCommand(), rq, cc);
        //}

        //public static List<DateTime> GetDates()
        //{
        //    return KYDataAccessLayer.BCK.GetDates(Runtime.B_CreateCommand());
        //}

        //public static List<KYDataModelLayer.BCK> ReadsByZDDM(DateTime rq, string zddm)
        //{
        //    return KYDataAccessLayer.BCK.ReadByZDDM(Runtime.B_CreateCommand(), rq, zddm);
        //}
    }
}
