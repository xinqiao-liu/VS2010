using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataModelLayer
{
    [Serializable]
    public sealed class GDB
    {
        public string Node { get; set; }
        public DateTime Date { get; set; }
        public string SN { get; set; }
        public string OldCPH { get; set; }
        public DateTime OldRQ { get; set; }
        public string OldBC { get; set; }
        public string NewCPH { get; set; }
        public DateTime NewRQ { get; set; }
        public string NewBC { get; set; }
        public string RecordType { get; set; }
        public string UID { get; set; }
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return this.Node + ":" + this.Date.ToString("yyyy-MM-dd") + "-" + this.SN + ":" + this.OldCPH + " > " + this.NewCPH;
        }
    }
}
