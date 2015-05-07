using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class JYB
    {
        public DateTime RQ { get; set; }    //*DateTime     日期
        public String CC { get; set; }      //*CHAR(4)      车次
        public String ZDDM { get; set; }    //*VARCHAR(15)  站点代码
        public String XH { get; set; }      //CHAR(2)       序号
        public Char ZT { get; set; }        //CHAR(1)       状态（N - 、T - 停）
        public Char YDBZ { get; set; }      //CHAR(1)       异地标志（YN）

        //public String ZM//站名
        //public String NM//内码
        //public Int32 LC//里程
        //public Decimal PJ//票价
        //public Decimal ZWF//站务费

        public override String ToString()
        {
            return String.Format("{0}:{1}-{2}", this.RQ.ToString("yyyy-MM-dd"), this.CC, this.ZDDM);
        }
    }
}
