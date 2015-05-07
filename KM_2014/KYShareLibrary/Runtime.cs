using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace KM.Common
{
    public static class Runtime
    {
        private static KM.Data.YHCS m_Setting;
        private static KM.Data.KYZ_User m_User;
        private static DateTime m_QueryDate = DateTime.Now.Date;

        public const Int32 检票系统 = 3;

        public const Int32 检票权限 = 96;
        public const Int32 设置权限 = 408;
        public const Int32 签到权限 = 24;
        public const Int32 结算权限 = 25;

        private static bool s_RunJP;
        private static bool s_AllowJP;
        private static bool s_AllowSZ;
        private static bool s_AllowJS;

        public static bool RunJP
        {
            get { return Runtime.s_RunJP; }
            set { Runtime.s_RunJP = value; }
        }
        
        public static bool AllowJP
        {
            get { return Runtime.s_AllowJP; }
            set { Runtime.s_AllowJP = value; }
        }
        
        public static bool AllowSZ
        {
            get { return Runtime.s_AllowSZ; }
            set { Runtime.s_AllowSZ = value; }
        }

        public static bool AllowJS
        {
            get { return Runtime.s_AllowJS; }
            set { Runtime.s_AllowJS = value; }
        }

        public static String BM
        {
            get { return Setting.BM; }
        }

        public static String MC
        {
            get { return Setting.MC; }
        }

        public static Int32 PJWS
        {
            get { return Setting.PJWS; }
        }

        public static String UID
        {
            get { return User.UID; }
        }

        public static String CID
        {
            get { return User.CID; }
        }

        public static String Name
        {
            get { return User.Name; }
        }

        public static String Fullname
        {
            get { return User.Fullname; }
        }

        public static String Password
        {
            get { return User.Password; }
        }

        internal static KM.Data.YHCS Setting
        {
            get { return Runtime.m_Setting; }
            set { Runtime.m_Setting = value; }
        }

        internal static KM.Data.KYZ_User User
        {
            get {return Runtime.m_User; }
            set { Runtime.m_User = value; }
        }

        public static DateTime QueryDate
        {
            get { return Runtime.m_QueryDate; }
            private set { Runtime.m_QueryDate = value; }
        }

        //初始化运行环境
        public static void InitEnvironment(SqlConnection conn, bool st)
        {
            try
            {
                Setting = KM.Data.YHCS.Read(conn);    //获取参数信息
                SyncServerTime(conn, st);             //同步服务器时间
            }
            catch (Exception ex)
            {
                throw new ApplicationException("初始化运行环境发生异常：" + ex.Message);
            }
        }

        //初始化用户信息
        public static void InitUser(SqlConnection conn, String uid)
        {
            try
            {
                User = KM.Data.KYZ_User.Read(conn, uid);

                RunJP = KM.Data.KYZ_User.System(conn, User.UID, 检票系统);

                AllowJP = KM.Data.KYZ_User.Right(conn, User.UID, 检票权限);
                AllowSZ = KM.Data.KYZ_User.Right(conn, User.UID, 设置权限);
                AllowJS = KM.Data.KYZ_User.Right(conn, User.UID, 结算权限);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("初始化用户信息发生异常：" + ex.Message);
            }
        }

        //同步服务器时间
        public static void SyncServerTime(SqlConnection conn, bool st)
        {
            DateTime serverTime = KM.Data.Common.GetDate(conn);

            if (st && !KM.Common.SystemTime.SetLocalTime(serverTime))
            {
                throw new ApplicationException("同步服务器时间失败！");
            }

            //初始化查询日期
            QueryDate = serverTime.Date;
        }
    }
}
