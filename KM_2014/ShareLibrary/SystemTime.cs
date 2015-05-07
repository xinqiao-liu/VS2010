using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace KM.ShareLibrary
{
    [StructLayout(LayoutKind.Sequential)]
    public class SystemTime
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;

        public override string ToString()
        {
            return wYear.ToString() + "-" + wMonth.ToString("N2") + "-" + wDay.ToString("N2") + " " + wHour.ToString("N2") + ":" + wMinute.ToString("N2") + ":" + wSecond.ToString("N2");
        }
    }
}
