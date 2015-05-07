using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class YHCS
    {
        public String BM { get; set; }          //*CHAR(11)     编码
        public String MC { get; set; }          //CHAR(30)      名称
        public String Server { get; set; }      //CHAR(20)      服务器
        public Decimal KPBL { get; set; }       //DECIMAL(6,2)  客票比率
        public Decimal XBBL { get; set; }       //DECIMAL(6,2)  行包比率
        public Int32 PJWS { get; set; }         //TINYINT       票据位数
        public Int32 JPK { get; set; }          //TINYINT       检票口
        public Int32 SPTS { get; set; }         //TINYINT       售票天数
        public Int32 TSSJ { get; set; }         //INT           提前停售时间
        public Int32 BZSJ { get; set; }         //INT           提前报站时间
        public Int32 DBFK { get; set; }         //INT           掉班罚款
        public Decimal FKBS { get; set; }       //DECIMAL(6,2)  罚款笔数（和掉班罚款错位？）
        public Int32 WDJS { get; set; }         //INT           晚点时间
        public Int32 WDFK { get; set; }         //INT           晚点罚款
        public Int32 WDCS { get; set; }         //INT           
        public Decimal BPF { get; set; }        //DECIMAL(4,2)  补票费
        public Decimal DPF { get; set; }        //DECIMAL(4,2)  订票费
        public Decimal XBF { get; set; }        //DECIMAL(4,2)  行包费
        public Decimal XBFW { get; set; }       //DECIMAL(4,2)  
        public Decimal GBF { get; set; }        //DECIMAL(4,2)  改办费
        public String GN01 { get; set; }        //CHAR(1)
        public String GN02 { get; set; }        //CHAR(1)
        public String GN03 { get; set; }        //CHAR(1)
        public String GN04 { get; set; }        //CHAR(1)
        public String GN05 { get; set; }        //CHAR(1)
        public String GN06 { get; set; }        //CHAR(1)
        public String GN07 { get; set; }        //CHAR(1)
        public String GN08 { get; set; }        //CHAR(1)
        public String GN09 { get; set; }        //CHAR(1)
        public String GN10 { get; set; }        //CHAR(1)
        public String GN11 { get; set; }        //CHAR(1)
        public String GN12 { get; set; }        //CHAR(1)
        public String GN13 { get; set; }        //CHAR(1)
        public String GN14 { get; set; }        //CHAR(1)
        public String GN15 { get; set; }        //CHAR(1)
        public String DMDM { get; set; }        //CHAR(11)      地名代码
        public String DWBZ { get; set; }        //CHAR(10)      单位标志
        public DateTime SysClock { get; set; }  //DateTime      系统时钟
        public String JZRQ { get; set; }        //CHAR(4)       结账日期
        public Decimal JBYJ { get; set; }       //DECIMAL(8,2)
        public Decimal BXBL { get; set; }       //DECIMAL(6,2)
        public Decimal FJBL { get; set; }       //DECIMAL(6,2)
        public String BXLC { get; set; }        //CHAR(1)
        public String FJLC { get; set; }        //CHAR(1)
        public String JZCL { get; set; }        //CHAR(1)
        public String JSFS { get; set; }        //CHAR(1)
        public Decimal KPGB { get; set; }       //DECIMAL(4,2)
        public String JSDGS { get; set; }       //CHAR(1)
        public String QJBZ { get; set; }        //CHAR(1)
        public String CPJP { get; set; }        //CHAR(1)
        public String XBJP { get; set; }        //CHAR(1)
        public Int32 ExamTime { get; set; }     //INT
        public String ExamOnOff { get; set; }   //CHAR(1)
        public Int32 TSZS { get; set; }         //INT
        public String TPLJ { get; set; }        //CHAR(1)
        public String SBSJ { get; set; }        //CHAR(5)
        public String XBSJ { get; set; }        //CHAR(5)
        public String DYFS { get; set; }        //CHAR(1)
        public Decimal BXJE { get; set; }       //DECIMAL(10,2)
        public Decimal BXF { get; set; }        //DECIMAL(10,2)
        public String SBXF { get; set; }        //CHAR(1)
        public Int32 SJQLNX { get; set; }       //INT
        public Decimal BXF2 { get; set; }       //DECIMAL(10,2)
        public String BXHint { get; set; }      //CHAR(1)
        public String ZWTPBZ { get; set; }      //CHAR(1)
        public String ZWFPBZ { get; set; }      //CHAR(1)
        public String TJZDJP { get; set; }      //CHAR(1)
        public String ISBXSM { get; set; }      //CHAR(1)
        public String JZLSH { get; set; }       //CHAR(20)
        public DateTime JZSJ { get; set; }      //DateTime

        public override String ToString()
        {
            return this.BM;
        }
    }
}
