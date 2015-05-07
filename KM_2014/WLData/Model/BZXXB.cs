using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class BZXXB
    {
        public String Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
