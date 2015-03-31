using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLDataLogicLayer
{
    public static class CSXXB
    {
        public static WLDataModelLayer.CSXXB Check(string prefix, WLDataModelLayer.CSXXB item)
        {
            Common.Validate.ValidString(prefix, "车牌号", 8, item.CPH);
            Common.Validate.ValidString(prefix, "结账代码", 8, item.Code);
            Common.Validate.NonOverflow(prefix, "车主名称", 32, item.Name);
            Common.Validate.NonOverflow(prefix, "车主地址", 64, item.Address);
            Common.Validate.NonOverflow(prefix, "车主电话", 32, item.Tel);
            Common.Validate.ValidPercent(prefix, "结账比率", item.Value);
            return item;
        }

        public static bool Exists(string cph)
        {
            return WLDataAccessLayer.CSXXB.Exists(Runtime.B_CreateCommand(), cph);
        }

        public static bool Insert(WLDataModelLayer.CSXXB item)
        {
            return WLDataAccessLayer.CSXXB.Insert(Runtime.B_CreateCommand(), Check("插入车属记录", item));
        }

        public static bool Delete(string cph)
        {
            return WLDataAccessLayer.CSXXB.Delete(Runtime.B_CreateCommand(), cph);
        }

        public static bool Update(string old_cph, WLDataModelLayer.CSXXB item)
        {
            return WLDataAccessLayer.CSXXB.Update(Runtime.B_CreateCommand(), old_cph, Check("更新车属记录", item));
        }

        public static WLDataModelLayer.CSXXB Read(string cph)
        {
            return WLDataAccessLayer.CSXXB.Read(Runtime.B_CreateCommand(), cph);
        }

        public static List<WLDataModelLayer.CSXXB> Reads(string code)
        {
            return WLDataAccessLayer.CSXXB.Reads(Runtime.B_CreateCommand(), code);
        }

        public static int GetCount(string code)
        {
            return WLDataAccessLayer.CSXXB.GetCount(Runtime.B_CreateCommand(), code);
        }
    }
}
