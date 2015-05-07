using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class KYZ
    {
        public String DM { get; set; }      //CHAR(11)  代码（不是主键但不能为空）
        public String MC { get; set; }      //CHAR(30)  名称
        public String SM { get; set; }      //CHAR(60)  说明
        public String Server { get; set; }  //CHAR(20)  服务器
        public String BZ { get; set; }      //CHAR(1)   标志（YN）
        public String DMDM { get; set; }    //CHAR(11)  地名代码
        public String DWBZ { get; set; }    //CHAR(10)  单位标志（如长高、长黄等）
        public String DTSPBZ { get; set; }  //CHAR(1)   （YN）（不能为空）
        public int TQSPSJ { get; set; }     //INT       提前售票时间

        public override String ToString()
        {
            return String.Format("{0}-{1}", this.DM, this.MC);
        }
    }
}
