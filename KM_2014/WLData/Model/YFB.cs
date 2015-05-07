using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class YFB
    {
        public string Name { get; set; }
        public decimal BF { get; set; }
        public decimal BW { get; set; }
        public int Weight { get; set; }
        public decimal Excess { get; set; }
        public decimal Factor { get; set; }
        public int SM { get; set; }
        public int EM { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
