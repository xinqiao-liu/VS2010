using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class CSXXB
    {
        public string CPH { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Value { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public override string ToString()
        {
            return this.CPH;
        }
    }
}
