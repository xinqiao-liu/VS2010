using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class CLK
    {
        public String CPH { get; set; }     //CHAR(8)       车牌号
        public String CX { get; set; }      //CHAR(6)       车型
        public Int32 ZWS { get; set; }      //TINYINT       座位数
        public Int32 DY { get; set; }       //TINYINT       定员
        public String CSDW { get; set; }    //CHAR(20)      车属单位
        public String XM { get; set; }      //CHAR(8)       车主姓名
        public String JSDM { get; set; }    //CHAR(6)       结算代码
        public String BZ1 { get; set; }     //CHAR(2)           
        public String BZ2 { get; set; }     //CHAR(1)
        public String BZ3 { get; set; }     //CHAR(1)
        public String BZ4 { get; set; }     //CHAR(1)
        public String BZ5 { get; set; }     //CHAR(1)
        public String BZ6 { get; set; }     //CHAR(1)
        public decimal BZ7 { get; set; }    //DECIMAL(6,2)  票款结算比率
        public decimal BZ8 { get; set; }    //DECIMAL(6,2)  行包结算比率
        public String BTBZ { get; set; }    //CHAR(1)       报停标志
        public String YYZH { get; set; }    //CHAR(10)
        public DateTime CCRQ { get; set; }  //DateTime      出厂日期
        public DateTime FZRQ { get; set; }  //DateTime      发证日期
        public String LGLBZ { get; set; }   //CHAR(1)
        public String LGLLB { get; set; }   //CHAR(1)
        public String YJBM { get; set; }    //CHAR(2)       运价编码
        public Int32 XJC { get; set; }      //INT           

        public override String ToString()
        {
            return this.CPH;
        }
    }
}
