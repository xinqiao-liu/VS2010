using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KYDataModelLayer
{
    [Serializable]
    public sealed class ZMPJB_Simple
    {
        public String Code { get; set; }
        public String Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
