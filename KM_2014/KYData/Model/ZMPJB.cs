using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class ZMPJB
    {
        public String ZDDM { get; set; }    //*VARCHAR(15)  站点代码
        public String ZM { get; set; }      //VARCHAR(30)   站名
        public Int32 LC { get; set; }       //SMALLINT      里程
        public Decimal PJ { get; set; }     //DECIMAL(6,2)  票价
        public Decimal ZWF { get; set; }    //DECIMAL(5,2)  站务费
        public String NM { get; set; }      //CHAR(11)      内码

        public override String ToString()
        {
            return this.ZDDM;
        }
    }
}
