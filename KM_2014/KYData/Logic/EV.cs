using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Logic
{
    public static class EV
    {
        public static Boolean Exist()
        {
            try
            {
                return false;
            }
            catch { throw new ApplicationException("检测有效验证异常！"); }
        }

        public static DateTime Read()
        {
            try
            {
                //解码日期并返回
                return DateTime.MinValue;
            }
            catch { throw new ApplicationException("读取有效验证异常！"); }
        }
    }
}
