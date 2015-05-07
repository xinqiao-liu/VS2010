using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KM.WLData.Model
{
    public enum JZMode { 统一 = 0, 独立 = 1 }

    [Serializable]
    public sealed class JZDMB
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public JZMode Mode { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public override string ToString()
        {
            return Code + "-" + Name;
        }

        public static JZDMB ToTarget(object o)
        {
            if (o == null) throw new ArgumentNullException("参数为空引用！");

            if (o is KM.WLData.Model.JZDMB)
                return (o as KM.WLData.Model.JZDMB);
            else
                throw new ArgumentException("参数非指定对象！");
        }

        public static void JZModeList(ComboBox list)
        {
            list.Items.Clear();
            list.Items.Add(KM.WLData.Model.JZMode.统一);
            list.Items.Add(KM.WLData.Model.JZMode.独立);
            list.SelectedIndex = 0;
        }
    }
}
