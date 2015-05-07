using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Logic
{
    public static class JSDMB
    {
        //插入结算单明细列表
        public static bool InsertList(List<Model.JSDMXB> list)
        {
            try
            {
                //使用事物插入结算单明细项
                foreach (Model.JSDMXB item in list)
                {
                }
                return true;
            }
            catch (Exception ex) { throw new ApplicationException("插入结算单明细项异常：" + ex.Message); }
        }

        public static Boolean Delete(DateTime rq, String cc)
        {
            try
            {
                return false;
            }
            catch (Exception ex) { throw new ApplicationException("删除结算单明细项异常：" + ex.Message); }
        }
    }    
}
