using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KM.WLData.Model
{
    public enum RoundingType { 取整 = 'I', 保留角 = 'D', 保留分 = 'P' }

    [Serializable]
    public sealed class ZDB
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string Name { get; set; }
        public DateTime SDT { get; set; }
        public DateTime EDT { get; set; }
        public RoundingType Rounding { get; set; }
        public string UID { get; set; }
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return Year.ToString() + "-" + Month.ToString() + ":" + Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            ZDB item = obj as ZDB;
            if (this.Year == item.Year && this.Month == item.Month && this.Name == item.Name)
                return true;

            return false;           
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ZDB lhs, ZDB rhs)
        {
            if (lhs.Year == rhs.Year && lhs.Month == rhs.Month && lhs.Name == rhs.Name)
                return true;
            else
                return false;
        }

        public static bool operator !=(ZDB lhs, ZDB rhs)
        {
            return !(lhs == rhs);
        }

        public static ZDB ToTarget(object o)
        {
            if (o == null) throw new ArgumentNullException("参数为空引用！");

            if (o is KM.WLData.Model.ZDB)
                return (o as KM.WLData.Model.ZDB);
            else
                throw new ArgumentException("参数非指定对象！");
        }

        //初始化舍入列表
        public static void RoundTypeList(ComboBox list)
        {
            list.Items.Clear();
            list.Items.Add(KM.WLData.Model.RoundingType.取整);
            list.Items.Add(KM.WLData.Model.RoundingType.保留角);
            list.Items.Add(KM.WLData.Model.RoundingType.保留分);
            list.SelectedIndex = 1;
        }
    }
}
