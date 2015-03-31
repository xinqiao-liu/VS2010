using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WLDataModelLayer
{
    [DataContract]
    [Serializable]
    public sealed class Node
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CityCode { get; set; }
        [DataMember]
        public string CityName { get; set; }
        [DataMember]
        public bool Enable { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Tel { get; set; }

        public override string ToString()
        {
            return this.Code + "-" + this.Name;
        }
    }
}
