using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class Bill
    {
        public static WLDataModelLayer.Bill Check(string prefix, WLDataModelLayer.Bill item)
        {
            Common.Validate.ValidString(prefix, "用户编号", 8, item.Userid);
            Common.Validate.ValidPositiveInt(prefix, "起始票号", item.P_Start);
            Common.Validate.ValidPositiveInt(prefix, "单据总数", item.P_Count);
            Common.Validate.ValidPositiveInt(prefix, "使用计数", item.P_Index);

            if (item.P_Index > item.P_Count) throw new ArgumentOutOfRangeException(prefix + "使用计数大于单据总数！");

            return item;
        }

        public static string Format(string sn)
        {
            return WLDataModelLayer.Bill.Current(sn, Setting.BillZeroize, Setting.BillBits);
        }

        public static void Refresh(ListView list, string uid)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.Bill i in Reads(uid))
            {
                ListViewItem item = new ListViewItem(i.Userid);
                item.Tag = i;
                item.SubItems.Add(i.P_Start.ToString());
                item.SubItems.Add(i.P_Count.ToString());
                item.SubItems.Add(i.P_Index.ToString());
                item.SubItems.Add(i.P_State.ToString());
                item.SubItems.Add(i.CDT.ToString("yyyy-MM-dd HH:mm:ss"));

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static WLDataModelLayer.Bill GetUserBill(string userid)
        {
            WLDataModelLayer.Bill item = null;
            if (Exists(userid, WLDataModelLayer.BillState.使用))
            {
                if ((item = Read(userid, WLDataModelLayer.BillState.使用)) == null)
                    throw new ApplicationException(string.Format("无法读取用户‘{0}’的当前票组！", userid));
            }

            else
            {
                if (!Exists(userid, WLDataModelLayer.BillState.备用))
                    throw new ApplicationException(string.Format("用户‘{0}’不存在可用票据，请添加票组！", userid));

                if ((item = Read(userid, WLDataModelLayer.BillState.备用)) == null)
                    throw new ApplicationException(string.Format("无法读取用户‘{0}’的备用票组！", userid));

                Activation(item);

                return GetUserBill(userid);
            }
            return item;
        }

        public static bool Exists(string userid, WLDataModelLayer.BillState p_state = WLDataModelLayer.BillState.使用)
        {
            return WLDataAccessLayer.Bill.Exists(Runtime.B_CreateCommand(), Common.Validate.ValidString("检测用户票组", "用户编号", 8, userid), p_state);
        }

        public static bool Exists(int p_start)
        {
            Common.Validate.ValidPositiveInt("检测用户票组", "起始票号", p_start);

            foreach (WLDataModelLayer.Bill item in WLDataAccessLayer.Bill.Reads(Runtime.B_CreateCommand()))
            {
                if (p_start >= item.P_Start && p_start < (item.P_Start + item.P_Count)) return true;
            }
            return false;
        }

        public static bool Insert(WLDataModelLayer.Bill item)
        {
            return WLDataAccessLayer.Bill.Insert(Runtime.B_CreateCommand(), Check("插入用户票组", item));
        }

        public static bool Delete(string userid, int p_start)
        {
            return WLDataAccessLayer.Bill.Delete(Runtime.B_CreateCommand(),
                Common.Validate.ValidString("删除用户票组", "用户编号", 8, userid),
                Common.Validate.ValidPositiveInt("删除用户票组", "起始票号", p_start));
        }

        public static bool Update(WLDataModelLayer.Bill item)
        {
            return WLDataAccessLayer.Bill.Update(Runtime.B_CreateCommand(), Check("更新用户票组", item));
        }

        public static WLDataModelLayer.Bill Read(string userid, WLDataModelLayer.BillState p_state)
        {
            return WLDataAccessLayer.Bill.Read(Runtime.B_CreateCommand(),
                Common.Validate.ValidString("读取用户票组", "用户编号", 8, userid), p_state);
        }

        public static List<WLDataModelLayer.Bill> Reads(string userid = null)
        {
            if (userid == null)
                return WLDataAccessLayer.Bill.Reads(Runtime.B_CreateCommand());
            else
                return WLDataAccessLayer.Bill.Reads(Runtime.B_CreateCommand(), Common.Validate.ValidString("读取用户票组", "用户编号", 8, userid));
        }

        public static bool ClearHistory(string userid = null)
        {
            if (userid == null)
                return WLDataAccessLayer.Bill.ClearHistory(Runtime.B_CreateCommand());
            else
                return WLDataAccessLayer.Bill.ClearHistory(Runtime.B_CreateCommand(), Common.Validate.ValidString("清除历史票组", "用户编号", 8, userid));
        }

        public static void Activation(WLDataModelLayer.Bill item)
        {
            item.P_State = WLDataModelLayer.BillState.使用;
            if (!Bill.SetState(item)) throw new ApplicationException(string.Format("无法激活用户‘{0}’的备用票组！", item.Userid));
        }

        public static void Close(WLDataModelLayer.Bill item)
        {
            item.P_State = WLDataModelLayer.BillState.用完;
            if (!Bill.SetState(item)) throw new ApplicationException(string.Format("无法关闭用户‘{0}’的备用票组！", item.Userid));
        }

        public static bool SetState(WLDataModelLayer.Bill item)
        {
            Check("设置用户票组状态", item);
            return WLDataAccessLayer.Bill.SetState(Runtime.B_CreateCommand(), item.Userid, item.P_Start, item.P_State);
        }
    }
}
