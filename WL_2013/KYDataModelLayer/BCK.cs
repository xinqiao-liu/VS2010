using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KYDataModelLayer
{
    [Serializable]
    public sealed class BCK
    {
        public DateTime RQ { get; set; }
        public String CC { get; set; }
        public String ZDZ { get; set; }
        public String YXLB { get; set; }
        public String FCSJ { get; set; }
        public String JPK { get; set; }
        public String PJLB { get; set; }
        public String ZT { get; set; }
        public String JYDM { get; set; }
        public String CPH { get; set; }
        public Int32 DY { get; set; }
        public String CX { get; set; }
        public Int32 SCS { get; set; }
        public Int32 YDXS { get; set; }
        public String XLLB { get; set; }
        public String SFZDM { get; set; }
        public String DZDM { get; set; }
        public String XLJY { get; set; }
        public String LMDM { get; set; }
        public String LCDM { get; set; }
        public String ZH { get; set; }
        public DateTime BDSJ { get; set; }
        public Int32 WDSJ { get; set; }
        public Decimal WDFK { get; set; }
        public String WDBZ { get; set; }
        public String JCBZ { get; set; }
        public String SFBZ { get; set; }
        public Int32 QZLC { get; set; }
        public String YXSJ { get; set; }
        public String Server { get; set; }
        public String DHBZ { get; set; }
        public String TPBZ { get; set; }
        public String ZWFBZ { get; set; }
        public String SPBZ { get; set; }
        public String YLBZ { get; set; }
        public Int32 YLSL { get; set; }
        public Int32 CYXL { get; set; }
        public String CKBZ { get; set; }
        public String SPCK { get; set; }

        public override String ToString()
        {
            return String.Format(" {0}{1,8}{2,06}{3,06}", this.ZDZ, this.FCSJ, this.CC, this.ZT);
        }
    }
}
