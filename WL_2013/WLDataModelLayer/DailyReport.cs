using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WLDataModelLayer
{
    [DataContract]
    [Serializable]
    public sealed class DailyReport
    {
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string NodeCode { get; set; }
        [DataMember]
        public string NodeName { get; set; }
        [DataMember]
        public int Counts1 { get; set; }
        [DataMember]
        public int Packages1 { get; set; }
        [DataMember]
        public decimal Total1 { get; set; }
        [DataMember]
        public int Counts2 { get; set; }
        [DataMember]
        public int Packages2 { get; set; }
        [DataMember]
        public decimal Total2 { get; set; }
        [DataMember]
        public int Counts { get { return Counts1 + Counts2; } }
        [DataMember]
        public int Packages { get { return Packages1 + Packages2; } }
        [DataMember]
        public decimal Total { get { return Total1 + Total2; } }
        [DataMember]
        public string UID { get; set; }
        [DataMember]
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return this.NodeName + "-" + this.Date.ToString("yyyy-MM-dd");
        }
    }
}
