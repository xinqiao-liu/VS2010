using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class ZDMXB
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string Code { get; set; }
        public string CPH { get; set; }
        public int Count { get; set; }
        public decimal Total { get; set; }
        public decimal Ratio { get; set; }
        public decimal Money { get; set; }

        public override string ToString()
        {
            return Year.ToString() + "-" + Month.ToString() + ":" + CPH;
        }

        public static ZDMXB ToTarget(object o)
        {
            if (o == null) throw new ArgumentNullException("参数为空引用！");

            if (o is KM.WLData.Model.ZDMXB)
                return (o as KM.WLData.Model.ZDMXB);
            else
                throw new ArgumentException("参数非指定对象！");
        }
    }
}
