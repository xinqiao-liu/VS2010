using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataModelLayer
{
    [Serializable]
    public sealed class ReportMonth
    {
        public DateTime Date { get; set; }
        public string NodeCode { get; set; }
        public string NodeName { get; set; }
        public int Counts { get; set; }
        public int Packages { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return this.Date.ToString("yyyy-MM-dd");
        }
    }
}
