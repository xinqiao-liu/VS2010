using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class BCK
    {
        public DateTime RQ { get; set; }        //*DateTime         日期
        public String CC { get; set; }          //*CHAR(4)          车次
        public String ZDZ { get; set; }         //VARCHAR(30)       终到站
        public String YXLB { get; set; }        //CHAR(4)           运行类别（直达、普客、普卧）
        public String FCSJ { get; set; }        //CHAR(5)           发车时间
        public String JPK { get; set; }         //CHAR(2)           检票口
        public String PJLB { get; set; }        //CHAR(2)           票价类别
        public String ZT { get; set; }          //CHAR(4)           状态
        public String JYDM { get; set; }        //CHAR(6)           经由代码
        public String CPH { get; set; }         //CHAR(8)           车牌号
        public Int32 DY { get; set; }           //INT               定员
        public String CX { get; set; }          //CHAR(6)           车型
        public Int32 SCS { get; set; }          //INT               售出票数
        public Int32 YDXS { get; set; }         //INT               异地限数
        public String XLLB { get; set; }        //CHAR(1)           线路类别（数字）
        public String SFZDM { get; set; }       //CHAR(11)          始发站代码
        public String DZDM { get; set; }        //CHAR(11)          终到站代码
        public String XLJY { get; set; }        //CHAR(11)          线路经由
        public String LMDM { get; set; }        //CHAR(1)           （数字）
        public String LCDM { get; set; }        //CHAR(1)           里程代码（数字）
        public String ZH { get; set; }          //CHAR(300)         座号状态
        public DateTime BDSJ { get; set; }      //DateTime          报到时间
        public Int32 WDSJ { get; set; }         //INT               晚点时间
        public Decimal WDFK { get; set; }       //DECIMAL(7,2)      晚点罚款
        public String WDBZ { get; set; }        //CHAR(1)           晚点标志（YN）
        public String JCBZ { get; set; }        //CHAR(1)           检车标志（YN）
        public String SFBZ { get; set; }        //CHAR(1)           始发标志（YN）
        public Int32 QZLC { get; set; }         //INT               里程
        public String YXSJ { get; set; }        //CHAR(5)           运行时间
        public String Server { get; set; }      //CHAR(20)          服务器
        public String DHBZ { get; set; }        //CHAR(1)           对号标志（YN)
        public String TPBZ { get; set; }        //CHAR(1)           退票标志（YN)
        public String ZWFBZ { get; set; }       //CHAR(1)           站务费标志（YN)
        public String SPBZ { get; set; }        //CHAR(1)           售票标志（YN)
        public String YLBZ { get; set; }        //CHAR(1)           预留标志
        public Int32 YLSL { get; set; }         //INT               预留数量
        public Int32 CYXL { get; set; }         //INT
        public String CKBZ { get; set; }        //CHAR(2)           窗口标志（YN）
        public String SPCK { get; set; }        //CHAR(1)           售票窗口（%)
        public Int32 XJC { get; set; }          //INT
        public String YZ { get; set; }          //CHAR(1)           （数字）

        public BCK()
        {
            this.BDSJ = DateTime.MaxValue;
        }

        public override String ToString()
        {
            return String.Format(" {0}-{1}", this.RQ.ToString("yyyy-MM-dd"), this.CC);
        }
    }
}
