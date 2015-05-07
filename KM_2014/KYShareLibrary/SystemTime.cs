using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace KM.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SystemTimeStruct
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMiliseconds;
    }

    public class SystemTime
    {
        [DllImport("Kernel32.dll")]
        public static extern bool SetSystemTime(ref SystemTimeStruct sysTime);
        [DllImport("Kernel32.dll")]
        public static extern bool SetLocalTime(ref SystemTimeStruct sysTime);
        [DllImport("Kernel32.dll")]
        public static extern void GetSystemTime(ref SystemTimeStruct sysTime);
        [DllImport("Kernel32.dll")]
        public static extern void GetLocalTime(ref SystemTimeStruct sysTime);

        public static bool SetLocalTime(DateTime dt)
        {
            bool flag = false;
            
            SystemTimeStruct sysTime = new SystemTimeStruct();
            sysTime.wYear = Convert.ToUInt16(dt.Year);
            sysTime.wMonth = Convert.ToUInt16(dt.Month);
            sysTime.wDay = Convert.ToUInt16(dt.Day);
            sysTime.wHour = Convert.ToUInt16(dt.Hour);
            sysTime.wMinute = Convert.ToUInt16(dt.Minute);
            sysTime.wSecond = Convert.ToUInt16(dt.Second);
            //结构体的wDayOfWeek属性一般不用赋值，函数会自动计算，写了如果不对应反而会出错
            //结构体的wMiliseconds属性默认值为一，可以赋值
            
            try
            {
                flag = SetLocalTime(ref sysTime);
                //函数执行成功则返回true，函数执行失败返回false
                //经常不返回异常，不提示错误，但是函数返回false，给查找错误带来了一定的困难
            }            
            catch (Exception ex)
            {
                throw new ApplicationException("设置本地时间发生异常：" + ex.Message);
            }
            return flag;
        }
    }
}
