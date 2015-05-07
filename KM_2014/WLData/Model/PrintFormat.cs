using System;
using System.Collections.Generic;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class PrintFormat
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }
        public string FontMode { get; set; }
        public bool Enable { get; set; }

        public override string ToString()
        {
            return this.Code + "-" + this.Name;
        }
    }
}
