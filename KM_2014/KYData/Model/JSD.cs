using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class JSD
    {
        public String KYZBM { get; set; }   //*CHAR(11)     客运站编码
        public String KYZMC { get; set; }   //CHAR(30)      客运站名称
        public String JSDBH { get; set; }   //CHAR(9)       结算单编号
        public DateTime RQ { get; set; }    //*DateTime     日期
        public String CC { get; set; }      //*CHAR(4)      车次
        public String ZDZ { get; set; }     //VARCHAR(30)   终到站
        public String FCSJ { get; set; }    //CHAR(5)       发车时间
        public String CPH { get; set; }     //CHAR(8)       车牌号
        public String JSDM { get; set; }    //CHAR(6)       结算代码
        public String CSDW { get; set; }    //CHAR(20)      车属单位
        public String XM { get; set; }      //CHAR(8)       车主姓名
        public Int32 XBBS { get; set; }     //INT           行包笔数
        public Int32 XBJS { get; set; }     //INT           行包件数
        public Int32 JSZS { get; set; }     //INT           结算张数
        public Decimal KPPK { get; set; }   //DECIMAL(8,2)  客票票款
        public Decimal KBXF { get; set; }   //DECIMAL(8,2)  客票保险费
        public Decimal KFJF { get; set; }   //DECIMAL(8,2)  客票附加费
        public Decimal JSPK { get; set; }   //DECIMAL(8,2)  结算票款
        public Decimal XBYF { get; set; }   //DECIMAL(8,2)  行包运费
        public Decimal XBK { get; set; }    //DECIMAL(8,2)  行包款
        public Decimal HJJE { get; set; }   //DECIMAL(8,2)  合计金额
        public String FCBZ { get; set; }    //CHAR(4)       发车标志（结算次数）
        public Decimal FKJE { get; set; }   //DECIMAL(8,2)  罚款金额
        public String JSCZ { get; set; }    //CHAR(20)      结算操作员姓名
        public Decimal PKBL { get; set; }   //DECIMAL(6,2)  票款结算比率
        public Decimal XBBL { get; set; }   //DECIMAL(6,2)  行包结算比率
        public Decimal PKDLF { get; set; }  //DECIMAL(8,2)  票款代理费
        public Decimal XBDLF { get; set; }  //DECIMAL(8,2)  行包代理费
        public Int32 BXBZ { get; set; }     //INT           保险标志
        public Int32 FJBZ { get; set; }     //INT           附加标志
        public Decimal DBFK { get; set; }   //DECIMAL(8,2)  掉班罚款
        public String JZBZ { get; set; }    //CHAR(1)       结账标志
        public DateTime JZRQ { get; set; }  //DateTime      结账日期
        public String JZDBH { get; set; }   //CHAR(9)       结账单编号
        public String JZDWMC { get; set; }  //CHAR(30)      结账单位名称
        public String JZCZY { get; set; }   //CHAR(30)      结账操作员姓名
        public Decimal RYF { get; set; }    //DECIMAL(6,2)  燃油费
                
        public override String ToString()
        {
            return String.Format(" {0}:{1}-{2}", this.KYZBM, this.RQ.ToString("yyyy-MM-dd"), this.CC);
        }
    }
}
