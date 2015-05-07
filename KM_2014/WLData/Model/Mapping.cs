using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class Mapping
    {
        public string Code { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} -> {1}", this.Code, this.Value);
        }
    }
}
