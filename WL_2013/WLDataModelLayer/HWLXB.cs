using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataModelLayer
{
    [Serializable]
    public sealed class HWLXB
    {
        public String Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
