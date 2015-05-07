using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace KM.Common
{
    //注意这个属性不能少
    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    struct TestStruct
    {
        public int c;
        //字符串，SizeConst为字符串的最大长度
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string str;
        //int数组，SizeConst表示数组的个数，在转换成
        //byte数组前必须先初始化数组，再使用，初始化
        //的数组长度必须和SizeConst一致，例test = new int[6];
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public int[] test;
    }
}
