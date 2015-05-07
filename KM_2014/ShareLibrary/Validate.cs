using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace KM.ShareLibrary
{
    public static class Validate
    {
        //检测字符串是否为空
        public static string NonEmpty(string prefix, string name, string str)
        {
            if (str == string.Empty) throw new ArgumentException(prefix + "‘" + name + "’字符串为空！");

            return str;
        }

        //检测字符串长度是否溢出
        public static string NonOverflow(string prefix, string name, int range, string str)
        {
            if (str.Length > range) throw new ArgumentOutOfRangeException(prefix + "‘" + name + "’字符串长度溢出！");

            return str;
        }

        //检测字符串范围是否溢出
        public static string NonOverflow(string prefix, string name, string range, string str)
        {
            NonEmpty(prefix, name, str);

            foreach (char a in range)
            {
                if (a == str[0]) return str;
            }
            throw new ArgumentOutOfRangeException(prefix + "‘" + name + "’字符串范围溢出！");
        }

        //检测是否为非有效字符串
        public static string ValidString(string prefix, string name, int range, string str)
        {
            NonEmpty(prefix, name, str);
            NonOverflow(prefix, name, range, str);

            return str;
        }

        public static string ValidString(string prefix, string name, string range, string str)
        {
            NonEmpty(prefix, name, str);
            NonOverflow(prefix, name, range, str);

            return str;
        }

        //检测是否为非有效正整数值
        public static int ValidPositiveInt(string prefix, string name, int value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(prefix + "‘" + name + " = " + value.ToString() + "’为非有效正整数！");

            return value;
        }

        //检测是否为非有效小数值
        public static decimal ValidDecimal(string prefix, string name, decimal value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(prefix + "‘" + name + " = " + value.ToString() + "’为非有效正小数！");

            return value;
        }

        //检测字符串长度是否为有效长度
        public static string ValidLength(string prefix, string name, int length, string str)
        {
            if (str.Length != length) throw new ArgumentException(prefix + "‘" + name + " = " + str.Length.ToString() + "’为非有效长度！");

            return str;
        }

        //检测是否为非有效百分比
        public static decimal ValidPercent(string prefix, string name, decimal value)
        {
            if (value < 0 || value > 1) throw new ArgumentOutOfRangeException(prefix + "‘" + name + " = " + value.ToString() + "’为非有效比例！");

            return value;
        }

        //检测是否为非有效日
        public static int ValidDay(string prefix, string name, int value)
        {
            if (value < 1 || value > 31) throw new ArgumentOutOfRangeException(prefix + "‘" + name + " = " + value.ToString() + "’为非有效日！");

            return value;
        }
    }
}
