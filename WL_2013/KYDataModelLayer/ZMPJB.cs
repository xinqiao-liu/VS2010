using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KYDataModelLayer
{
    [Serializable]
    public sealed class ZMPJB
    {
        public String ZDDM { get; set; }
        public String ZM { get; set; }
        public Int32 LC { get; set; }
        public Decimal PJ { get; set; }
        public Decimal ZWF { get; set; }
        public String NM { get; set; }

        public override String ToString()
        {
            return ZDDM + "-" + ZM;
        }
    }
}
