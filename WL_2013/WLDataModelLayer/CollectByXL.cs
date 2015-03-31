using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
          
namespace WLDataModelLayer
{
    [Serializable]
    public sealed class CollectByXL
    {
        public int SN { get; set; }
        public string Name { get; set; }
        public int Counts { get; set; }
        public int Packages { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
