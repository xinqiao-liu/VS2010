using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Logic
{
    public static class CZJL
    {
        //插入操作记录
        public static bool Insert(Model.CZJL item)
        {
            try
            {
                return false;
            }
            catch (Exception ex) { throw new ApplicationException("插入操作记录异常：" + ex.Message); }
        }
    }
}
