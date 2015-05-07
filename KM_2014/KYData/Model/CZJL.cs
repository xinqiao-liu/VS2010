using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class CZJL
    {
        public DateTime SJ { get; set; }    //DateTime  操作时间（非主键但不可为空）
        public String XM { get; set; }      //CHAR(20)  操作员姓名
        public String CC { get; set; }      //CHAR(8)   操作类型（管理、调度）
        public String JS { get; set; }      //CHAR(200) 操作内容

        public override String ToString()
        {
            return this.SJ.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
