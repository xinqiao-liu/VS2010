using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataModelLayer
{
    [Serializable]
    public sealed class ReportDay
    {
        public string NodeCode { get; set; }
        public string NodeName { get; set; }
        public int Counts { get; set; }
        public int Packages { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return this.NodeCode;
        }
    }
}
