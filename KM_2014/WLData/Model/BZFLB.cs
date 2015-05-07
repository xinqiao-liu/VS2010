using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class BZFLB
    {
        public string Name { get; set; }
        public decimal Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
