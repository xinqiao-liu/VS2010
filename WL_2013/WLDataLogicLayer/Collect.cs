using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataLogicLayer
{
    public static class Collect
    {
        public static List<WLDataModelLayer.CollectByCP> ReadCollectByCP(DateTime sd, DateTime ed)
        {
            return WLDataAccessLayer.Collect.ReadCollectByCP(Runtime.B_CreateCommand(), sd, ed);
        }

        public static List<WLDataModelLayer.CollectByXL> ReadCollectByXL(DateTime sd, DateTime ed)
        {
            return WLDataAccessLayer.Collect.ReadCollectByXL(Runtime.B_CreateCommand(), sd, ed);
        }

        public static List<WLDataModelLayer.CollectByWD> ReadCollectByWD(DateTime sd, DateTime ed)
        {
            return WLDataAccessLayer.Collect.ReadCollectByWD(Runtime.B_CreateCommand(), sd, ed);
        }

        public static List<WLDataModelLayer.CollectByCustomer> ReadCollectByCustomer(DateTime sd, DateTime ed, WLDataModelLayer.CollectByCustomerSortMode sortMode)
        {
            return WLDataAccessLayer.Collect.ReadCollectByCustomer(Runtime.B_CreateCommand(), sd, ed, sortMode);
        }
    }
}
