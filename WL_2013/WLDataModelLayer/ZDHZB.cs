using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataModelLayer
{
    [Serializable]
    public sealed class ZDHZB
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Cars { get; set; }
        public int Count { get; set; }
        public decimal Total { get; set; }
        public decimal Money { get; set; }
        public string UID { get; set; }
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return Year.ToString() + "-" + Month.ToString() + ":" + Code;
        }

        public static ZDHZB ToTarget(object o)
        {
            if (o == null) throw new ArgumentNullException("参数为空引用！");

            if (o is WLDataModelLayer.ZDHZB)
                return (o as WLDataModelLayer.ZDHZB);
            else
                throw new ArgumentException("参数非指定对象！");
        }
    }
}
