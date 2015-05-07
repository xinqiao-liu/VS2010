using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class CollectByWD
    {
        public int SN { get; set; }
        public string NodeCode { get; set; }
        public string NodeName { get; set; }
        public int Counts { get; set; }
        public int Packages { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return this.NodeCode + "-" + this.NodeName;
        }
    }
}
