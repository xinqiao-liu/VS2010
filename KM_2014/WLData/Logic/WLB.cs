using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WLDataLogicLayer
{
    public static class WLB
    {
        //------------------------------------------------------------------------------------
        //基础功能
        //------------------------------------------------------------------------------------

        #region 检测运单记录
        public static WLDataModelLayer.WLB Check(string prefix, WLDataModelLayer.WLB item)
        {
            Common.Validate.ValidString(prefix, "网点代码", 12, item.Node);
            Common.Validate.ValidString(prefix, "运单编号", 12, item.SN);
            Common.Validate.ValidString(prefix, "用户编号", 8, item.UID);

            Common.Validate.ValidString(prefix, "发货网点代码", 11, item.FH_Code);
            Common.Validate.ValidString(prefix, "发货网点名称", 32, item.FH_Name);
            Common.Validate.ValidString(prefix, "发货城市名称", 32, item.FH_CityName);
            Common.Validate.ValidString(prefix, "接货网点代码", 11, item.JH_Code);
            Common.Validate.ValidString(prefix, "接货网点名称", 32, item.JH_Name);

            Common.Validate.NonOverflow(prefix, "班次", 8, item.CZ_BC);
            Common.Validate.NonOverflow(prefix, "到站", 8, item.CZ_DZ);
            Common.Validate.NonOverflow(prefix, "发车时间", 5, item.CZ_SJ);
            Common.Validate.NonOverflow(prefix, "车牌号", 8, item.CZ_CPH);
            Common.Validate.ValidString(prefix, "货物名称", 32, item.HW_MC);
            //Common.Validate.ValidString(prefix, "货物类型", 32, item.HW_LX);
            Common.Validate.NonOverflow(prefix, "保险单编号", 32, item.BXD_SN);
            Common.Validate.ValidString(prefix, "发货人姓名", 32, item.FHR_Name);
            Common.Validate.ValidString(prefix, "发货人手机", 32, item.FHR_Mobile);
            Common.Validate.ValidString(prefix, "接货人姓名", 32, item.JHR_Name);
            Common.Validate.ValidString(prefix, "接货人手机", 32, item.JHR_Mobile);

            //Common.Validate.ValidPositiveInt(prefix, "里程", item.CZ_LC);
            Common.Validate.ValidPositiveInt(prefix, "货物件数", item.HW_JS);
            Common.Validate.ValidDecimal(prefix, "货物保金", item.HW_BJ);
            Common.Validate.ValidDecimal(prefix, "计费重量", item.JFZL);
            Common.Validate.ValidDecimal(prefix, "计费体积", item.JFTJ);
            Common.Validate.ValidDecimal(prefix, "托运费", item.TYF);
            Common.Validate.ValidDecimal(prefix, "包装费", item.BZF);
            Common.Validate.ValidDecimal(prefix, "保险费", item.BXF);
            Common.Validate.ValidDecimal(prefix, "合计金额", item.Total);
            Common.Validate.ValidDecimal(prefix, "实收金额", item.Money);

            return item;
        }
        #endregion

        #region 转换到列表项
        public static ListViewItem ToListViewItem(WLDataModelLayer.WLB i)
        {
            ListViewItem item = new ListViewItem(i.SN);
            item.Tag = i;
            item.SubItems.Add(i.UID);
            item.SubItems.Add(i.CDT.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(i.SK_Type.ToString());
            item.SubItems.Add(i.YD_Type.ToString());
            item.SubItems.Add(i.ZT_Type.ToString());
            item.SubItems.Add(i.CZ_RQ.ToString("yyyy-MM-dd"));
            item.SubItems.Add(i.CZ_BC);
            item.SubItems.Add(i.CZ_CPH);
            item.SubItems.Add(i.CZ_DZ);
            item.SubItems.Add(i.CZ_SJ);
            item.SubItems.Add(i.HW_MC);
            item.SubItems.Add(i.HW_LX);
            item.SubItems.Add(i.HW_JS.ToString());
            item.SubItems.Add(i.HW_BJ.ToString("N2"));
            item.SubItems.Add(i.FHR_Name);
            item.SubItems.Add(i.FHR_Mobile);
            item.SubItems.Add(i.FHR_Remark);
            item.SubItems.Add(i.JHR_Name);
            item.SubItems.Add(i.JHR_Mobile);
            item.SubItems.Add(i.JFZL.ToString("N2"));
            item.SubItems.Add(i.JFTJ.ToString("N2"));
            item.SubItems.Add(i.TYF.ToString("N2"));
            item.SubItems.Add(i.BZF.ToString("N2"));
            item.SubItems.Add(i.BXF.ToString("N2"));
            item.SubItems.Add(i.Total.ToString("N2"));
            item.SubItems.Add(i.Money.ToString("N2"));
            item.SubItems.Add(i.FH_Code + "-" + i.FH_Name);
            item.SubItems.Add(i.JH_Code + "-" + i.JH_Name);
            item.SubItems.Add(i.BXD_SN);

            return item;
        }
        #endregion

        #region 更新到列表项
        public static WLDataModelLayer.WLB UpdateLine(ListViewItem item, WLDataModelLayer.WLB i)
        {
            item.Text = i.SN;
            item.Tag = i;
            item.SubItems[1].Text = i.UID;
            item.SubItems[2].Text = i.CDT.ToString("yyyy-MM-dd HH:mm:ss");
            item.SubItems[3].Text = i.SK_Type.ToString();
            item.SubItems[4].Text = i.YD_Type.ToString();
            item.SubItems[5].Text = i.ZT_Type.ToString();
            item.SubItems[6].Text = i.CZ_RQ.ToString("yyyy-MM-dd");
            item.SubItems[7].Text = i.CZ_BC;
            item.SubItems[8].Text = i.CZ_CPH;
            item.SubItems[9].Text = i.CZ_DZ;
            item.SubItems[10].Text = i.CZ_SJ;
            item.SubItems[11].Text = i.HW_MC;
            item.SubItems[12].Text = i.HW_LX;
            item.SubItems[13].Text = i.HW_JS.ToString();
            item.SubItems[14].Text = i.HW_BJ.ToString("N2");
            item.SubItems[15].Text = i.FHR_Name;
            item.SubItems[16].Text = i.FHR_Mobile;
            item.SubItems[17].Text = i.FHR_Remark;
            item.SubItems[18].Text = i.JHR_Name;
            item.SubItems[19].Text = i.JHR_Mobile;
            item.SubItems[20].Text = i.JFZL.ToString("N2");
            item.SubItems[21].Text = i.JFTJ.ToString("N2");
            item.SubItems[22].Text = i.TYF.ToString("N2");
            item.SubItems[23].Text = i.BZF.ToString("N2");
            item.SubItems[24].Text = i.BXF.ToString("N2");
            item.SubItems[25].Text = i.Total.ToString("N2");
            item.SubItems[25].Text = i.Money.ToString("N2");
            item.SubItems[27].Text = i.FH_Code + "-" + i.FH_Name;
            item.SubItems[28].Text = i.JH_Code + "-" + i.JH_Name;
            item.SubItems[29].Text = i.BXD_SN;

            return i;
        }
        #endregion

        //------------------------------------------------------------------------------------
        //全局功能
        //------------------------------------------------------------------------------------

        #region 检测运单
        public static bool Exists(WLDataModelLayer.WLB item)
        {
            return WLDataAccessLayer.WLB.Exists(WLDataLogicLayer.Runtime.B_CreateCommand(), item.Node, item.Date, item.SN);
        }

        public static bool Exists(string sn)
        {
            return WLDataAccessLayer.WLB.Exists(WLDataLogicLayer.Runtime.B_CreateCommand(), sn);
        }
        #endregion

        #region 插入运单
        public static bool Insert(WLDataModelLayer.WLB item)
        {
            return WLDataAccessLayer.WLB.Insert(Runtime.B_CreateCommand(), Check("插入记录到运单表", item));
        }
        #endregion

        #region 更新运单
        public static bool Update(WLDataModelLayer.WLB item)
        {
            return WLDataAccessLayer.WLB.Update(WLDataLogicLayer.Runtime.B_CreateCommand(), Check("更新记录在运单表", item));
        }
        #endregion

        //------------------------------------------------------------------------------------
        //本站功能
        //------------------------------------------------------------------------------------

        #region 刷新列表

        //显示本站全部日期列表（默认DESC）- includeEOD 是否包含已日结日期
        public static void RefreshLocalAllDates(ComboBox list, System.Data.SqlClient.SortOrder mode)
        {
            list.Items.Clear();
            foreach (DateTime i in GetLocalAllDates(mode))
            {
                list.Items.Add(i.ToString("yyyy-MM-dd"));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.SelectedIndex = 0; }
        }

        //刷新本站未日结日期列表
        public static void RefreshLocalNotEndOfDayDates(ComboBox list, System.Data.SqlClient.SortOrder mode)
        {
            list.Items.Clear();
            foreach (DateTime i in WLDataAccessLayer.WLB.GetLocalAllDates(Runtime.B_CreateCommand(), mode))
            {
                if (!EndOfDay.Exists(i)) list.Items.Add(i.ToString("yyyy-MM-dd"));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.SelectedIndex = 0; }
        }

        public static void RefreshLocalByDateOrCZRQ(ListView list, string nodecode, DateTime date)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataAccessLayer.WLB.ReadLocalByDateOrCZRQ(Runtime.B_CreateCommand(), nodecode, date))
            {
                list.Items.Add(WLB.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static void RefreshLocalBySN(ListView list, string nodecode, string sn)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataAccessLayer.WLB.ReadLocalBySN(Runtime.B_CreateCommand(), nodecode, sn))
            {
                list.Items.Add(WLB.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static void RefreshLocalByFHR_Mobile(ListView list, string nodecode, string fhr_mobile)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataAccessLayer.WLB.ReadLocalByFHR_Mobile(Runtime.B_CreateCommand(), nodecode, fhr_mobile))
            {
                list.Items.Add(WLB.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static void RefreshLocalByFHR_Name(ListView list, string nodecode, string fhr_name)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataAccessLayer.WLB.ReadLocalByFHR_Mobile(Runtime.B_CreateCommand(), nodecode, fhr_name))
            {
                list.Items.Add(WLB.ToListViewItem(i));
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        #endregion

        #region 获取数据

        //获取本站日期列表
        public static List<DateTime> GetLocalAllDates(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Ascending)
        {
            return WLDataAccessLayer.WLB.GetLocalAllDates(Runtime.B_CreateCommand(), mode);
        }

        public static List<DateTime> GetLocalAllCZRQ(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Ascending)
        {
            return WLDataAccessLayer.WLB.GetLocalAllCZRQ(Runtime.B_CreateCommand(), mode);
        }

        //获取本站已卸车日期列表
        public static List<DateTime> GetLocalXCDates(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Descending)
        {
            return WLDataAccessLayer.WLB.GetLocalXCDates(Runtime.B_CreateCommand(), mode);
        }

        //获取本站已取货日期列表
        public static List<DateTime> GetLocalSHDates(System.Data.SqlClient.SortOrder mode = System.Data.SqlClient.SortOrder.Descending)
        {
            return WLDataAccessLayer.WLB.GetLocalSHDates(Runtime.B_CreateCommand(), mode);
        }

        //获取本站用户办单合计金额
        public static Decimal GetLocalUserTotalAmount(string uid)
        {
            return WLDataAccessLayer.WLB.GetLocalUserTotalAmount(Runtime.B_CreateCommand(), Setting.NodeCode, Runtime.CurrentDate, uid);
        }

        //获取本站汇总日报表
        public static WLDataModelLayer.DailySheet GetLocalDailySheet(string node, DateTime date)
        {
            return WLDataAccessLayer.WLB.GetLocalDailySheet(Runtime.B_CreateCommand(), node, date);
        }

        //获取已同步运单数
        public static int GetLocalHasSynchronizedNumber(string node, DateTime date)
        {
            return WLDataAccessLayer.WLB.GetLocalSynchronizedNumber(Runtime.B_CreateCommand(), node, date, true);
        }

        //获取未同步运单数
        public static int GetLocalNotSynchronizedNumber(string node, DateTime date)
        {
            return WLDataAccessLayer.WLB.GetLocalSynchronizedNumber(Runtime.B_CreateCommand(), node, date, false);
        }

        //获取未冻结日期列表
        //public static List<DateTime> GetLocalNotFreezeDates(System.Data.SqlClient.SortOrder mode)
        //{
        //    return WLDataAccessLayer.WLB.GetLocalFreezeDates(Runtime.B_CreateCommand(), mode, false);
        //}
        
        //获取已冻结运单数
        //public static int GetLocalHasFreezeNumber(DateTime date)
        //{
        //    return WLDataAccessLayer.WLB.GetLocalFreezeNumber(Runtime.B_CreateCommand(), Setting.NodeCode, date, true);
        //}

        //获取未冻结运单数
        //public static int GetLocalNotFreezeNumber(DateTime date)
        //{
        //    return WLDataAccessLayer.WLB.GetLocalFreezeNumber(Runtime.B_CreateCommand(), Setting.NodeCode, date, false);
        //}

        #endregion

        #region 读取运单

        //获取指定运单（办单窗口-改单、废单前查找运单）
        public static WLDataModelLayer.WLB ReadLocal(string sn)
        {
            return WLDataAccessLayer.WLB.ReadLocal(Runtime.B_CreateCommand(), Setting.NodeCode, 
                Common.Validate.ValidString("读取运单记录", "运单编号", 12, sn));
        }

        //获取指定日期预办运单（用于预办记录报表）
        public static List<WLDataModelLayer.WLB> ReadLocalAdvanceRecord(string node, DateTime date)
        {
            return WLDataAccessLayer.WLB.ReadLocalAdvanceRecord(Runtime.B_CreateCommand(), node, date);
        }

        //获取指定日期卸车运单（用于卸车记录报表）
        public static List<WLDataModelLayer.WLB> ReadLocalXCRecord(string node, DateTime date)
        {
            return WLDataAccessLayer.WLB.ReadLocalXCRecord(Runtime.B_CreateCommand(), node, date);
        }

        //获取指定日期取货运单（用于取货记录报表）
        public static List<WLDataModelLayer.WLB> ReadLocalSHRecord(string node, DateTime date)
        {
            return WLDataAccessLayer.WLB.ReadLocalSHRecord(Runtime.B_CreateCommand(), node, date);
        }

        //获取指定用户运单（用于用户交款计算）
        public static List<WLDataModelLayer.WLB> ReadLocalByUID(string node, DateTime date, string uid)
        {
            Common.Validate.ValidString("读取指定网点、日期及用户工号运单", "用户编号", 8, uid);

            return WLDataAccessLayer.WLB.ReadLocalByUID(Runtime.B_CreateCommand(), node, date, uid);
        }

        //读取本站等待上传中心运单
        public static List<WLDataModelLayer.WLB> ReadLocalUploadCentral(string node, DateTime date)
        {
            return WLDataAccessLayer.WLB.ReadLocalUploadCentral(Runtime.B_CreateCommand(), node, date);
        }

        //读取本站指定承运日期全部运单
        public static List<WLDataModelLayer.WLB> ReadLocalByCZRQ(DateTime date)
        {
            return WLDataAccessLayer.WLB.ReadLocalByCZRQ(Runtime.B_CreateCommand(), Setting.NodeCode, date);
        }

        //读取本站指定承运日期已冻结运单
        public static List<WLDataModelLayer.WLB> ReadLocalHasFreezeByCZRQ(DateTime date)
        {
            return WLDataAccessLayer.WLB.ReadLocalFreezeByCZRQ(Runtime.B_CreateCommand(), Setting.NodeCode, date, true);
        }

        //读取本站指定承运日期未冻结运单
        public static List<WLDataModelLayer.WLB> ReadLocalNotFreezeByCZRQ(DateTime date)
        {
            return WLDataAccessLayer.WLB.ReadLocalFreezeByCZRQ(Runtime.B_CreateCommand(), Setting.NodeCode, date, false);
        }
        #endregion

        //------------------------------------------------------------------------------------
        //汇总功能
        //------------------------------------------------------------------------------------

        #region 汇总-刷新运单列表
        //明细列表
        public static void RefreshCollectByCPH_L(ListView list, string cph, DateTime sdt, DateTime edt)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataAccessLayer.WLB.ReadCollectByCPH(Runtime.B_CreateCommand(), cph, sdt, edt))
            {
                list.Items.Add(WLB.ToListViewItem(i));
            }
            if (list.Items.Count > 0) list.Items[0].Selected = true;
        }

        //简单列表
        public static void RefreshCollectByCPH_S(ListView list, string cph, DateTime sdt, DateTime edt)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.WLB i in WLDataAccessLayer.WLB.ReadCollectByCPH(Runtime.B_CreateCommand(), cph, sdt, edt))
            {
                ListViewItem item = new ListViewItem(i.Node);
                item.Tag = i;
                item.SubItems.Add(i.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(i.SN);
                item.SubItems.Add(i.UID);

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) list.Items[0].Selected = true;
        }
        #endregion

        #region 汇总-获取车辆列表
        public static List<String> GetCollectCPHList(DateTime minDate, DateTime maxDate)
        {
            return WLDataAccessLayer.WLB.GetCollectCPHList(Runtime.B_CreateCommand(), minDate, maxDate);
        }
        #endregion

        //------------------------------------------------------------------------------------
        //中心功能
        //------------------------------------------------------------------------------------

        #region 装车处理
        public static void RefreshCentralZCDateList(ComboBox list)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (DateTime item in centralClient.WLB_ReadWaitingZCDates(Setting.NodeCode, System.Data.SqlClient.SortOrder.Descending))
                {
                    list.Items.Add(item);
                }                
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.SelectedIndex = 0; }
        }

        public static void RefreshCentralZCWaitingList(ListView list, DateTime date)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (WLDataModelLayer.WLB item in centralClient.WLB_ReadWaitingZCList(Setting.NodeCode, date))
                {
                    ListViewItem i = new ListViewItem(item.SN);
                    i.Tag = item;
                    i.SubItems.Add(item.FH_Code + "-" + item.FH_Name);
                    i.SubItems.Add(item.HW_MC);
                    i.SubItems.Add(item.HW_LX);
                    i.SubItems.Add(item.HW_JS.ToString());
                    i.SubItems.Add(item.HW_BJ.ToString("N2"));
                    i.SubItems.Add(item.FHR_Name);
                    i.SubItems.Add(item.FHR_Mobile);
                    i.SubItems.Add(item.JHR_Name);
                    i.SubItems.Add(item.JHR_Mobile);
                    i.SubItems.Add(item.CZ_RQ.ToString("yyyy-MM-dd"));
                    i.SubItems.Add(item.CZ_CPH);
                    i.SubItems.Add(item.CZ_BC);
                    i.SubItems.Add(item.CZ_SJ);
                    i.SubItems.Add(item.BXD_SN);
                    i.SubItems.Add(item.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

                    list.Items.Add(i);
                }
            }
        }

        public static void RefreshCentralZCAlreadyList(ListView list, DateTime date)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (WLDataModelLayer.WLB item in centralClient.WLB_ReadAlreadyZCList(Setting.NodeCode, date))
                {
                    ListViewItem i = new ListViewItem(item.SN);
                    i.Tag = item;
                    i.SubItems.Add(item.FH_Code + "-" + item.FH_Name);
                    i.SubItems.Add(item.HW_MC);
                    i.SubItems.Add(item.HW_LX);
                    i.SubItems.Add(item.HW_JS.ToString());
                    i.SubItems.Add(item.HW_BJ.ToString("N2"));
                    i.SubItems.Add(item.FHR_Name);
                    i.SubItems.Add(item.FHR_Mobile);
                    i.SubItems.Add(item.JHR_Name);
                    i.SubItems.Add(item.JHR_Mobile);
                    i.SubItems.Add(item.CZ_RQ.ToString("yyyy-MM-dd"));
                    i.SubItems.Add(item.CZ_CPH);
                    i.SubItems.Add(item.CZ_BC);
                    i.SubItems.Add(item.CZ_SJ);
                    i.SubItems.Add(item.BXD_SN);
                    i.SubItems.Add(item.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

                    list.Items.Add(i);
                }
            }
        }

        public static WLDataModelLayer.WLB CentralZCRead(string sn)
        {
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                if (centralClient.WLB_ExistWaitingZC(Setting.NodeCode, sn))
                    return centralClient.WLB_ReadWaitingZCItem(Setting.NodeCode, sn);
                else
                    return null;                    
            }
        }
        #endregion

        #region 卸车处理
        public static void RefreshCentralXCDateList(ComboBox list)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (DateTime item in centralClient.WLB_ReadWaitingXCDates(Setting.NodeCode, System.Data.SqlClient.SortOrder.Descending))
                {
                    list.Items.Add(item);
                }
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.SelectedIndex = 0; }
        }

        public static void RefreshCentralXCWaitingList(ListView list, DateTime date)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (WLDataModelLayer.WLB item in centralClient.WLB_ReadWaitingXCList(Setting.NodeCode, date))
                {
                    ListViewItem i = new ListViewItem(item.SN);
                    i.Tag = item;
                    i.SubItems.Add(item.FH_Code + "-" + item.FH_Name);
                    i.SubItems.Add(item.HW_MC);
                    i.SubItems.Add(item.HW_LX);
                    i.SubItems.Add(item.HW_JS.ToString());
                    i.SubItems.Add(item.HW_BJ.ToString("N2"));
                    i.SubItems.Add(item.FHR_Name);
                    i.SubItems.Add(item.FHR_Mobile);
                    i.SubItems.Add(item.JHR_Name);
                    i.SubItems.Add(item.JHR_Mobile);
                    i.SubItems.Add(item.CZ_RQ.ToString("yyyy-MM-dd"));
                    i.SubItems.Add(item.CZ_CPH);
                    i.SubItems.Add(item.CZ_BC);
                    i.SubItems.Add(item.CZ_SJ);
                    i.SubItems.Add(item.BXD_SN);
                    i.SubItems.Add(item.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

                    list.Items.Add(i);
                }
            }
        }

        public static void RefreshCentralXCAlreadyList(ListView list, DateTime date)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (WLDataModelLayer.WLB item in centralClient.WLB_ReadAlreadyXCList(Setting.NodeCode, date))
                {
                    ListViewItem i = new ListViewItem(item.SN);
                    i.Tag = item;
                    i.SubItems.Add(item.FH_Code + "-" + item.FH_Name);
                    i.SubItems.Add(item.HW_MC);
                    i.SubItems.Add(item.HW_LX);
                    i.SubItems.Add(item.HW_JS.ToString());
                    i.SubItems.Add(item.HW_BJ.ToString("N2"));
                    i.SubItems.Add(item.FHR_Name);
                    i.SubItems.Add(item.FHR_Mobile);
                    i.SubItems.Add(item.JHR_Name);
                    i.SubItems.Add(item.JHR_Mobile);
                    i.SubItems.Add(item.CZ_RQ.ToString("yyyy-MM-dd"));
                    i.SubItems.Add(item.CZ_CPH);
                    i.SubItems.Add(item.CZ_BC);
                    i.SubItems.Add(item.CZ_SJ);
                    i.SubItems.Add(item.BXD_SN);
                    i.SubItems.Add(item.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

                    list.Items.Add(i);
                }
            }
        }

        public static WLDataModelLayer.WLB CentralXCRead(string sn)
        {
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                if (centralClient.WLB_ExistWaitingXC(Setting.NodeCode, sn))
                    return centralClient.WLB_ReadWaitingXCItem(Setting.NodeCode, sn);
                else
                    return null;
            }
        }
        #endregion

        #region 取货处理
        public static void RefreshCentralQHDateList(ComboBox list)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (DateTime item in centralClient.WLB_ReadWaitingSHDates(Setting.NodeCode, System.Data.SqlClient.SortOrder.Descending))
                {
                    list.Items.Add(item);
                }
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.SelectedIndex = 0; }
        }

        public static void RefreshCentralQHWaitingList(ListView list, DateTime date)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (WLDataModelLayer.WLB item in centralClient.WLB_ReadWaitingSHList(Setting.NodeCode, date))
                {
                    ListViewItem i = new ListViewItem(item.SN);
                    i.Tag = item;
                    i.SubItems.Add(item.FH_Code + "-" + item.FH_Name);
                    i.SubItems.Add(item.HW_MC);
                    i.SubItems.Add(item.HW_LX);
                    i.SubItems.Add(item.HW_JS.ToString());
                    i.SubItems.Add(item.HW_BJ.ToString("N2"));
                    i.SubItems.Add(item.FHR_Name);
                    i.SubItems.Add(item.FHR_Mobile);
                    i.SubItems.Add(item.JHR_Name);
                    i.SubItems.Add(item.JHR_Mobile);
                    i.SubItems.Add(item.CZ_RQ.ToString("yyyy-MM-dd"));
                    i.SubItems.Add(item.CZ_CPH);
                    i.SubItems.Add(item.CZ_BC);
                    i.SubItems.Add(item.CZ_SJ);
                    i.SubItems.Add(item.BXD_SN);
                    i.SubItems.Add(item.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

                    list.Items.Add(i);
                }
            }
        }

        public static void RefreshCentralQHAlreadyList(ListView list, DateTime date)
        {
            list.Items.Clear();
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                foreach (WLDataModelLayer.WLB item in centralClient.WLB_ReadAlreadySHList(Setting.NodeCode, date))
                {
                    ListViewItem i = new ListViewItem(item.SN);
                    i.Tag = item;
                    i.SubItems.Add(item.FH_Code + "-" + item.FH_Name);
                    i.SubItems.Add(item.HW_MC);
                    i.SubItems.Add(item.HW_LX);
                    i.SubItems.Add(item.HW_JS.ToString());
                    i.SubItems.Add(item.HW_BJ.ToString("N2"));
                    i.SubItems.Add(item.FHR_Name);
                    i.SubItems.Add(item.FHR_Mobile);
                    i.SubItems.Add(item.JHR_Name);
                    i.SubItems.Add(item.JHR_Mobile);
                    i.SubItems.Add(item.CZ_RQ.ToString("yyyy-MM-dd"));
                    i.SubItems.Add(item.CZ_CPH);
                    i.SubItems.Add(item.CZ_BC);
                    i.SubItems.Add(item.CZ_SJ);
                    i.SubItems.Add(item.BXD_SN);
                    i.SubItems.Add(item.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

                    list.Items.Add(i);
                }
            }
        }

        public static WLDataModelLayer.WLB CentralQHRead(string sn)
        {
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                if (centralClient.WLB_ExistWaitingSH(Setting.NodeCode, sn))
                    return centralClient.WLB_ReadWaitingSHItem(Setting.NodeCode, sn);
                else
                    return null;
            }
        }
        #endregion

        #region 检测中心运单是否已修改
        public static bool CentralModified(WLDataModelLayer.WLB item)
        {
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                WLDataModelLayer.WLB newItem = centralClient.WLB_Read(item.Node, item.SN);
                if (newItem != null)
                {
                    if (newItem.ZT_Type != item.ZT_Type) return true;
                }
                else throw new ApplicationException(Message.E3050);
            }
            return false;
        }
        #endregion

        #region 刷新中心承运日期列表
        public static void RefreshCentralAllCZRQ(ComboBox list)
        {
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                list.Items.Clear();
                foreach (DateTime i in centralClient.WLB_GetAllCZRQ(Setting.NodeCode, System.Data.SqlClient.SortOrder.Descending))
                {
                    list.Items.Add(i.ToString("yyyy-MM-dd"));
                }
                if (list.Items.Count > 0) { list.Enabled = true; list.SelectedIndex = 0; }
            }
        }
        #endregion

        #region 刷新中心承运日期运单
        public static void RefreshCentralByCZRQ(ListView list, string nodecode, DateTime date)
        {
            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
            {
                list.Enabled = false;
                list.Items.Clear();
                foreach (WLDataModelLayer.WLB i in centralClient.WLB_ReadByCZRQ(nodecode, date))
                {
                    list.Items.Add(WLB.ToListViewItem(i));
                }
                if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
            }
        }
        #endregion

        //------------------------------------------------------------------------------------
        //事务功能
        //------------------------------------------------------------------------------------

        #region 创建运单
        public static WLDataModelLayer.WLB Create(WLDataModelLayer.WLB item, WLDataModelLayer.Bill bill)
        {
            using (SqlTransaction tran = Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        if (!WLDataAccessLayer.WLB.Insert(cmd, item))
                            throw new ApplicationException(string.Format("无法插入运单记录{0}到本站！", item));
                        if (!WLDataAccessLayer.Bill.Stepping(cmd, bill))
                            throw new ApplicationException(string.Format("无法在本站步进用户票组{0}！", bill));

                        //如果配置自动保存客户，则根据运单记录保存客户信息
                        if (Setting.SaveCustomer)
                        {
                            if (!WLDataAccessLayer.Customer.Exists(cmd, item.FHR_Mobile)) WLDataAccessLayer.Customer.Insert(cmd, 
                                    new WLDataModelLayer.Customer() { Name = item.FHR_Name, Tel = item.FHR_Mobile, Address = "", Enable = true });
                            if (!WLDataAccessLayer.Customer.Exists(cmd, item.JHR_Mobile)) WLDataAccessLayer.Customer.Insert(cmd, 
                                    new WLDataModelLayer.Customer() { Name = item.JHR_Name, Tel = item.JHR_Mobile, Address = "", Enable = true });
                        }

                        //如Synced为真则同步提交运单到中央服务器
                        if (item.Synced)    
                        {
                            item.YD_Type = WLDataModelLayer.YDType.中心;
                            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                            {
                                if (centralClient.WLB_Exist(item)) 
                                    throw new ApplicationException(string.Format("中心服务器中已存在运单{0}！", item));
                                else
                                { if (!centralClient.WLB_Insert(item)) throw new ApplicationException(string.Format("无法添加运单{0}到中心数据库！", item)); }
                            }
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
            return item;
        }
        #endregion

        #region 改变运单
        public static void Change(WLDataModelLayer.WLB newItem, WLDataModelLayer.WLB oldItem)
        {
            using (SqlTransaction tran = Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        if (newItem.Synced && newItem.ZT_Type == WLDataModelLayer.ZTType.接货)
                        {
                            string msg = string.Format("是否为运单'{0}'办理装车？", newItem.SN);
                            if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                newItem.ZT_Type = WLDataModelLayer.ZTType.装车;
                        }

                        if (!WLDataAccessLayer.WLB.Update(cmd, newItem)) throw new ApplicationException(string.Format("无法在本站更新运单记录{0}！", newItem));
                        if (!WLDataAccessLayer.GDB.Insert(cmd, new WLDataModelLayer.GDB()
                            {
                                Node = newItem.Node,
                                Date = newItem.Date,
                                SN = newItem.SN,
                                OldRQ = newItem.CZ_RQ,
                                OldBC = newItem.CZ_BC,
                                OldCPH = oldItem.CZ_CPH,
                                NewRQ = newItem.CZ_RQ,
                                NewBC = newItem.CZ_BC,
                                NewCPH = newItem.CZ_CPH,
                                RecordType = "M",
                                UID = WLDataLogicLayer.User.LoginUser.Userid
                            })) throw new ApplicationException(string.Format("无法在本站插入改单记录{0}！", newItem));

                        //如Synced为真则同步在中央服务器更新运单
                        if (newItem.Synced)
                        {
                            newItem.YD_Type = WLDataModelLayer.YDType.中心;
                            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                            {
                                if (centralClient.WLB_Exist(newItem))
                                { if (!centralClient.WLB_Update(newItem)) throw new ApplicationException(string.Format("无法更新运单{0}在中心数据库！", newItem)); }

                                else
                                { if (!centralClient.WLB_Insert(newItem)) throw new ApplicationException(string.Format("无法添加运单{0}到中心数据库！", newItem)); }
                            }
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }
        #endregion

        #region 废弃运单
        public static void Destroy(WLDataModelLayer.WLB item)
        {
            using (SqlTransaction tran = Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        item.ZT_Type = WLDataModelLayer.ZTType.作废;

                        if (!WLDataAccessLayer.WLB.Update(cmd, item))
                            throw new ApplicationException(string.Format("无法在本站作废‘{0}’的运单记录！", item.SN));
                        if (!WLDataAccessLayer.FDB.Insert(cmd, new WLDataModelLayer.FDB() { Node = item.Node, Date = item.Date, SN = item.SN, UID = User.LoginUser.Userid }))
                            throw new ApplicationException(string.Format("无法在本站插入‘{0}’的废单记录！", item.SN));

                        if (item.Synced)
                        {
                            using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                            {
                                if (centralClient.WLB_Exist(item))
                                { if (!centralClient.WLB_Update(item)) throw new ApplicationException(string.Format("无法废弃运单{0}在中心数据库！", item)); }
                            }
                        }

                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }
        #endregion

        #region 上传运单到汇总数据库中
        public static void UploadToCollect(WLDataModelLayer.WLB item)
        {            
            using (SqlTransaction b_tran = Runtime.B_CreateTransaction(), c_tran = Runtime.C_CreateTransaction())
            {
                using (SqlCommand b_cmd = Runtime.B_CreateCommand(), c_cmd = Runtime.C_CreateCommand())
                {
                    b_cmd.Transaction = b_tran;
                    c_cmd.Transaction = c_tran;                    
                    try                        
                    {
                        item.Freeze = true;
                        item.YD_Type = WLDataModelLayer.YDType.结账;

                        //如果使用统一数据库，则不进行上传操作，仅完成更新操作                        
                        if (!WLDataAccessLayer.WLB.Update(b_cmd, item)) throw new ApplicationException(string.Format("无法在本站更新运单记录{0}！", item));
                        
                        if (!Runtime.UnifiedDataSource)
                        {
                            if (WLDataAccessLayer.WLB.Exists(c_cmd, item.Node, item.Date, item.SN))
                            { if (!WLDataAccessLayer.WLB.Update(c_cmd, item)) throw new ApplicationException(string.Format("无法更新运单{0}在汇总数据库！", item)); }
                            else
                            { if (!WLDataAccessLayer.WLB.Insert(c_cmd, item)) throw new ApplicationException(string.Format("无法添加运单{0}到汇总数据库！", item)); }
                        }
                        b_tran.Commit();
                        c_tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        b_tran.Rollback(); 
                        c_tran.Rollback(); 
                        throw ex; 
                    }
                }
            }
        }
        #endregion

        #region 上传运单到中心数据库中
        public static void UploadToCentral(WLDataModelLayer.WLB item)
        {
            using (SqlTransaction tran = WLDataLogicLayer.Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = WLDataLogicLayer.Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        item.Synced = true;
                        if (!WLDataAccessLayer.WLB.Update(cmd, item)) throw new ApplicationException(string.Format("无法在本站更新运单记录{0}！", item));

                        item.YD_Type = WLDataModelLayer.YDType.中心;
                        using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                        {
                            if (centralClient.WLB_Exist(item))
                            {
                                if (!centralClient.WLB_Update(item)) throw new ApplicationException(string.Format("无法更新运单{0}在中心数据库！", item));
                            }
                            else
                            {
                                if (!centralClient.WLB_Insert(item)) throw new ApplicationException(string.Format("无法添加运单{0}到中心数据库！", item));
                            }
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }
        #endregion

        #region 设置接货状态
        public static void CentralJH(WLDataModelLayer.WLB item)
        {
            using (SqlTransaction tran = WLDataLogicLayer.Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = WLDataLogicLayer.Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        item.ZT_Type = WLDataModelLayer.ZTType.接货;
                        item.YD_Type = WLDataModelLayer.YDType.本地;
                        if (WLDataAccessLayer.WLB.Exists(cmd, item.SN))
                        {
                            if (!WLDataAccessLayer.WLB.Update(cmd, item)) throw new ApplicationException(string.Format("无法在本站更新运单记录{0}！", item));
                        }

                        item.YD_Type = WLDataModelLayer.YDType.中心;
                        using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                        {
                            centralClient.Execute(item, string.Format("{0}:{1} 设置为接货状态。", Setting.NodeCode + "-" + Setting.NodeName, User.LoginUser.ToString()));
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }
        #endregion

        #region 设置装车状态
        public static void CentralZC(WLDataModelLayer.WLB item)
        {
            using (SqlTransaction tran = WLDataLogicLayer.Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = WLDataLogicLayer.Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        item.ZT_Type = WLDataModelLayer.ZTType.装车;
                        item.YD_Type = WLDataModelLayer.YDType.本地; 
                        if (WLDataAccessLayer.WLB.Exists(cmd, item.SN))
                        {
                            if (!WLDataAccessLayer.WLB.Update(cmd, item)) throw new ApplicationException(string.Format("无法在本站更新运单记录{0}！", item));
                        }

                        item.YD_Type = WLDataModelLayer.YDType.中心;
                        using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                        {
                            centralClient.Execute(item, string.Format("{0}:{1} 设置为装车状态。", Setting.NodeCode + "-" + Setting.NodeName, User.LoginUser.ToString()));
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }
        #endregion

        #region 设置卸车状态
        public static void CentralXC(WLDataModelLayer.WLB item)
        {
            using (SqlTransaction tran = WLDataLogicLayer.Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = WLDataLogicLayer.Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        item.ZT_Type = WLDataModelLayer.ZTType.卸车;

                        //卸载如果本站不存在卸车运单，则插入到本站用于多站结算及报表打印
                        if (!WLDataAccessLayer.WLB.Exists(cmd, item.Node, item.Date, item.SN))
                        {
                            if (!WLDataAccessLayer.WLB.Insert(cmd, item)) throw new ApplicationException(string.Format("无法插入中心服务器运单记录{0}到本站！", item));
                        }

                        using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                        {
                            centralClient.Execute(item, string.Format("{0}:{1} 设置为卸车状态。", Setting.NodeCode + "-" + Setting.NodeName, User.LoginUser.ToString()));
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }
        
        #endregion

        #region 设置取货状态
        public static void CentralQH(WLDataModelLayer.WLB item)
        {
            using (SqlTransaction tran = WLDataLogicLayer.Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = WLDataLogicLayer.Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        item.ZT_Type = WLDataModelLayer.ZTType.取货;

                        //卸载如果本站不存在卸车运单，则插入到本站用于多站结算及报表打印
                        if (!WLDataAccessLayer.WLB.Exists(cmd, item.Node, item.Date, item.SN))
                        { if (!WLDataAccessLayer.WLB.Insert(cmd, item)) throw new ApplicationException(string.Format("无法插入中心服务器运单记录{0}到本站！", item)); }
                        else
                        { if (!WLDataAccessLayer.WLB.Update(cmd, item)) throw new ApplicationException(string.Format("无法在本站更新中心服务器运单记录{0}！", item)); }

                        using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                        {
                            centralClient.Execute(item, string.Format("{0}:{1} 设置为取货状态。", Setting.NodeCode + "-" + Setting.NodeName, User.LoginUser.ToString()));
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }
        #endregion

        #region 设置废单状态
        public static void CentralFD(WLDataModelLayer.WLB item)
        {
            using (SqlTransaction tran = WLDataLogicLayer.Runtime.B_CreateTransaction())
            {
                using (SqlCommand cmd = WLDataLogicLayer.Runtime.B_CreateCommand())
                {
                    cmd.Transaction = tran;
                    try
                    {
                        item.ZT_Type = WLDataModelLayer.ZTType.作废;
                        item.YD_Type = WLDataModelLayer.YDType.本地;
                        if (WLDataAccessLayer.WLB.Exists(cmd, item.SN))
                        {
                            if (!WLDataAccessLayer.WLB.Update(cmd, item)) throw new ApplicationException(string.Format("无法在本站更新运单记录{0}！", item));
                        }

                        item.YD_Type = WLDataModelLayer.YDType.中心;
                        using (WLCentralServiceReference.CentralClient centralClient = new WLCentralServiceReference.CentralClient())
                        {
                            centralClient.Execute(item, string.Format("{0}:{1} 设置为废单状态。", Setting.NodeCode + "-" + Setting.NodeName, User.LoginUser.ToString()));
                        }
                        tran.Commit();
                    }
                    catch (Exception ex) { tran.Rollback(); throw ex; }
                }
            }
        }
        #endregion
    }
}
