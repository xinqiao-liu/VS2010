using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KM.KYData.Logic
{
    public static class JSDBH
    {
        //递增并读取指定位数结算单编号
        public static String Read(int bits)
        {
            try
            {
                int result = 0;

                if (result == 0)
                    return String.Empty;
                else
                    return String.Format("{0:D" + bits.ToString() + "}", result);
            }
            catch (Exception ex) { throw new ApplicationException("递增并读取结算单编号异常：" + ex.Message); }
        }
    }
}
