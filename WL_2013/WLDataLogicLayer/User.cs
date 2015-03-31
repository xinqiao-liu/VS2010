using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class User
    {
        private static WLDataModelLayer.User m_LoginUser = null;

        public static WLDataModelLayer.User LoginUser
        {
            get
            {
                if (User.m_LoginUser == null)
                    throw new ApplicationException("登录用户信息未初始化！");
                else
                    return User.m_LoginUser;
            }
            private set { User.m_LoginUser = value; }
        }

        public static void Login(string userid)
        {
            User.LoginUser = WLDataAccessLayer.User.Read(Runtime.B_CreateCommand(), userid);
        }

        public static void Logout()
        {
            User.LoginUser = null;
        }

        public static WLDataModelLayer.User Check(string prefix, WLDataModelLayer.User item)
        {
            Common.Validate.ValidString(prefix, "编号", 8, item.Userid);
            Common.Validate.ValidString(prefix, "名称", 32, item.Username);
            Common.Validate.NonOverflow(prefix, "用户密码", 32, item.Password);
            Common.Validate.NonOverflow(prefix, "网点代码", 12, item.NodeCode);
            Common.Validate.NonOverflow(prefix, "网点名称", 32, item.NodeName);
            return item;
        }

        public static void Refresh(ComboBox list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.User i in WLDataAccessLayer.User.Reads(Runtime.B_CreateCommand()))
            {
                list.Items.Add(i);
            }
            if (list.Items.Count > 0) list.SelectedIndex = 0;
        }

        public static void Refresh(ListView list)
        {
            list.Items.Clear();
            foreach (WLDataModelLayer.User i in WLDataAccessLayer.User.Reads(Runtime.B_CreateCommand()))
            {
                ListViewItem item = new ListViewItem(i.Userid);
                item.Tag = i;
                item.SubItems.Add(i.Username);
                item.SubItems.Add(i.NodeCode);
                item.SubItems.Add(i.NodeName);
                item.SubItems.Add(i.Enable ? "启用" : "停用");

                list.Items.Add(item);
            }
            if (list.Items.Count > 0) { list.Enabled = true; list.Items[0].Selected = true; }
        }

        public static bool Exists(string userid)
        {
            return WLDataAccessLayer.User.Exists(Runtime.B_CreateCommand(), userid);
        }

        public static bool Insert(WLDataModelLayer.User item)
        {
            return WLDataAccessLayer.User.Insert(Runtime.B_CreateCommand(), Check("插入用户数据", item));
        }

        public static bool Delete(string userid)
        {
            return WLDataAccessLayer.User.Delete(Runtime.B_CreateCommand(), userid);
        }

        public static bool Update(string old_userid, WLDataModelLayer.User item)
        {
            return WLDataAccessLayer.User.Update(Runtime.B_CreateCommand(), old_userid, Check("更新用户数据", item));
        }

        public static WLDataModelLayer.User Read(string userid)
        {
            return WLDataAccessLayer.User.Read(Runtime.B_CreateCommand(), userid);
        }

        public static bool Validate(string userid, string password)
        {
            return (User.GetPassword(userid) == password);
        }

        public static bool ResetPassword(string userid, string oldpassword, string newpassword)
        {
            if (User.GetPassword(userid) == oldpassword) return User.SetPassword(userid, newpassword);

            return false;
        }

        public static bool ClearPassword(string userid)
        {
            return User.SetPassword(userid, "");
        }

        public static string GetUsername(string userid)
        {
            return WLDataAccessLayer.User.GetUsername(Runtime.B_CreateCommand(), userid);
        }

        public static bool SetPassword(string userid, string password)
        {
            return WLDataAccessLayer.User.SetPassword(Runtime.B_CreateCommand(), userid,
                Common.Validate.NonOverflow("设置用户密码", "用户密码", 32, password));
        }

        public static string GetPassword(string userid)
        {
            return WLDataAccessLayer.User.GetPassword(Runtime.B_CreateCommand(), userid);
        }
    }
}
