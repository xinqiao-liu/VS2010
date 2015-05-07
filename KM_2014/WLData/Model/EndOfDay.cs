using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class EndOfDay
    {
        public DateTime Date { get; set; }
        public string UID { get; set; }
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return this.Date.ToString("yyyy-MM-dd");
        }
    }
}
