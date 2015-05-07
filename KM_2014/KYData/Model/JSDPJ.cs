using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{    
    public sealed class JSDPJ
    {
        public String BH { get; set; }          //*CHAR(9)      编号
        public DateTime RQ { get; set; }        //*DateTime     日期
        public String CC { get; set; }          //*CHAR(4)      车次
        public String BZ { get; set; }          //CHAR(1)       标志 F-废单，省却为空
        public String CZ { get; set; }          //CHAR(20)      操作员姓名
        public DateTime SJ { get; set; }        //DateTime      操作时间

        public override String ToString()
        {
            return BH;
        }
    }
}
