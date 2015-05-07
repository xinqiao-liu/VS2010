using System;
using System.Collections.Generic;
using System.Text;

namespace KM.WLData.Model
{
    public enum BillState { 备用 = 'B', 使用 = 'S', 用完 = 'E' }

    [Serializable]
    public sealed class Bill
    {
        public readonly int Bits = 12;

        public string Userid { get; set; }
        public int P_Start { get; set; }
        public int P_Count { get; set; }
        public int P_Index { get; set; }
        public BillState P_State { get; set; }
        public DateTime CDT { get; set; }

        public bool IsOver()
        {
            return (P_Index >= P_Count);
        }

        public override string ToString()
        {
            return Userid;
        }

        public string Current(bool padleft, int bits)
        {
            return Bill.Current((P_Start + P_Index).ToString(), padleft, bits);
        }

        public static string Current(string sn, bool padleft, int bits)
        {
            if (padleft)
                return sn.PadLeft(bits, '0');
            else
                return sn;
        }
    }
}
