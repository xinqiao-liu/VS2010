using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace KM.WLData.Model
{
    [DataContract]
    [Serializable]
    public sealed class WLT
    {
        [DataMember]
        public string Node { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string SN { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return string.Format("[{0} -> {1} : {2}] {3}", this.Node, this.Date.ToString("yyyy-MM-dd"), this.SN, this.Content);
        }
    }
}
