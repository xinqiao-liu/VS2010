using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class DailySheet
    {
        public DateTime Date { get; set; }
        public string NodeCode { get; set; }
        public string NodeName { get; set; }
        public int Counts1 { get; set; }
        public int Packages1 { get; set; }
        public decimal Total1 { get; set; }
        public int Counts2 { get; set; }
        public int Packages2 { get; set; }
        public decimal Total2 { get; set; }
        public int Counts { get { return Counts1 + Counts2; } }
        public int Packages { get { return Packages1 + Packages2; } }
        public decimal Total { get { return Total1 + Total2; } }
        public string UID { get; set; }
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return this.NodeName + "-" + this.Date.ToString("yyyy-MM-dd");
        }
    }
}
