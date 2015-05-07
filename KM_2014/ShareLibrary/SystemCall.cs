using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace KM.ShareLibrary
{
    public class SystemCall
    {
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime", SetLastError = true)]
        public static extern void GetLocalTime(SystemTime st);
        public static DateTime GetLocalTime()
        {
            SystemTime st = new SystemTime();
            GetLocalTime(st);
            return new DateTime(st.wYear, st.wMonth, st.wDay, st.wHour, st.wMinute, st.wSecond, st.wMilliseconds);
        }

        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
        public static extern void SetLocalTime(SystemTime st);
        public static void SetLocalTime(DateTime t)
        {
            SystemTime st = new SystemTime();
            st.wYear = (ushort)t.Year;
            st.wMonth = (ushort)t.Month;
            st.wDay = (ushort)t.Day;
            st.wHour = (ushort)t.Hour;
            st.wMinute = (ushort)t.Minute;
            st.wSecond = (ushort)t.Second;
            SetLocalTime(st);
        }
    }
}
