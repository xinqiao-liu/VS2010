using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Logic
{
    public static class JSDPJ
    {
        //插入结算单票据项
        public static bool Insert(Model.JSDPJ item)
        {
            try
            {
                return false;
            }
            catch (Exception ex) { throw new ApplicationException("插入结算单票据异常：" + ex.Message); }
        }

        //废弃结算单票据项
        public static bool Discard(Model.JSDPJ item)
        {
            return Discard(item.BH, item.RQ, item.CC);
        }

        public static bool Discard(String bh, DateTime rq, String cc)
        {
            try
            {
                return false;
            }
            catch (Exception ex) { throw new ApplicationException("废弃结算单票据异常：" + ex.Message); }
        }
    }
}
