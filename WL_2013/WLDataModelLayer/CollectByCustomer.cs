using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataModelLayer
{
    public enum CollectByCustomerSortMode { Count, Total };

    [Serializable]
    public sealed class CollectByCustomer
    {
        public int SN { get; set; }
        public string FHR_Name { get; set; }
        public string FHR_Tel { get; set; }
        public int Counts { get; set; }
        public int Packages { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return this.FHR_Name + ":" + FHR_Tel;
        }

        public static CollectByCustomerSortMode ToSortMode(string sortStr)
        {
            return (CollectByCustomerSortMode)Enum.Parse(typeof(CollectByCustomerSortMode), sortStr);
        }
    }
}
