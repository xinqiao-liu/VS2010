using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class JSDMXB
    {
        public DateTime RQ { get; set; }    //*DateTime     日期
        public String CC { get; set; }      //*CHAR(4)      车次
        public String DZ { get; set; }      //*VARCHAR(30)  到站
        public String PZ { get; set; }      //*CHAR(2)      票种（整、半）
        public Decimal PJ { get; set; }     //DECIMAL(8,2)  票价
        public Decimal BXF { get; set; }    //DECIMAL(8,2)  保险费
        public Int32 JSS { get; set; }      //INT           结算数
        public Decimal JSK { get; set; }    //DECIMAL(8,2)  结算款
        public String SFDM { get; set; }    //CHAR(11)      始发代码
        public String DZDM { get; set; }    //CHAR(11)      到站代码

        public override String ToString()
        {
            return string.Format("{0}-{1}:{2}({3})", this.RQ.ToString("yyyy-MM-dd"), this.CC, this.DZ, this.PZ);
        }
    }
}
