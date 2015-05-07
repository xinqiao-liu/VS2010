using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class CPB
    {
        public String PH { get; set; }      //*CHAR(9)          票号
        public String CC { get; set; }      //CHAR(4)           车次
        public DateTime RQ { get; set; }    //*DateTime         日期
        public String ZH { get; set; }      //CHAR(2)           座号
        public String PZ { get; set; }      //CHAR(2)           票种
        public Decimal PJ { get; set; }     //DECIMAL(6,2)      票价
        public String FCSJ { get; set; }    //CHAR(5)           发车时间
        public Decimal BPF { get; set; }    //DECIMAL(6,2)      补票费
        public Decimal ZWF { get; set; }    //DECIMAL(6,2)      站务费
        public String BZ { get; set; }      //CHAR(1)           标志（F-废票、T-退票、J-检票）
        public String SPY { get; set; }     //VARCHAR(20)       售票员姓名（异-外站售票）
        public String YDBZ { get; set; }    //CHAR(1)           异地标志（YN）
        public String HPZBZ { get; set; }   //CHAR(1)           换票证标志（YN）
        public String DZBZ { get; set; }    //CHAR(11)          到站标志（代码）
        public String CCZBZ { get; set; }   //CHAR(11)          乘车站标志（代码）
        public String DZ { get; set; }      //VARCHAR(30)       到站
        public DateTime SPRQ { get; set; }  //DateTime          售票时间
        public int LC { get; set; }         //INT               里程
        public Decimal BXF { get; set; }    //DECIMAL(6,2)      保险费（异地售票可能为NULL）
        public Decimal RYFJF { get; set; }  //DECIMAL(6,2)      燃油附加费
        public Decimal BXJE { get; set; }   //DECIMAL(10,2)     保险金额（异地售票可能为NULL）
        public String BXBZ { get; set; }    //CHAR(1)           保险标志（B-未保，S-保险，T-退保）
        public String BXRXM { get; set; }   //VARCHAR(20)       保险人姓名（异地售票可能为NULL）
        public String SFZHM { get; set; }   //VARCHAR(18)       身份证号码（异地售票可能为NULL）
        public String TFBRY { get; set; }   //VARCHAR(20)       退费表人员工号（未退为NULL）
        public DateTime TFBSJ { get; set; } //DateTime          退费表时间（未退为NULL）
        public String BDLSH { get; set; }   //VARCHAR(30)       保单流水号
        public Decimal TBF { get; set; }    //DECIMAL(10,2)     退保费（未退为NULL）
        public String JPY { get; set; }     //VARCHAR(20)       检票员姓名

        public override String ToString()
        {
            return string.Format("{0}:{1}", this.RQ.ToString("yyyy-MM-dd"), this.PH);
        }
    }

    public sealed class CPB_CT
    {
        public String SPY { get; set; }     //售票员编号
        public String Name { get; set; }    //售票员姓名
        public DateTime SPRQ { get; set; }  //售票时间
        public String CC { get; set; }      //车次
        public DateTime RQ { get; set; }    //日期
        public String FCSJ { get; set; }    //发车时间
        public String DZ { get; set; }      //到站
        public Int32 Count { get; set; }    //计数

        public override String ToString()
        {
            return string.Format("{0}:{1}", this.SPY, this.Name);
        }
    }
}
