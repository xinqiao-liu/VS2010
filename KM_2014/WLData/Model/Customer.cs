using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class Customer
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public bool Enable { get; set; }

        public override string ToString()
        {
            return this.Name + "-" + this.Tel;
        }
    }
}
