using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataModelLayer
{
    [Serializable]
    public sealed class Payin
    {
        public DateTime Date { get; set; }
        public string Userid { get; set; }
        public int BDS { get; set; }
        public int FDS { get; set; }
        public decimal TYF { get; set; }
        public decimal BZF { get; set; }
        public decimal BXF { get; set; }
        public decimal Total { get; set; }
        public decimal Money { get; set; }
        public int Count { get; set; }
        public string UID { get; set; }
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return this.Date.ToString("yyyy-MM-dd") + "-" + this.Userid;
        }
    }
}
