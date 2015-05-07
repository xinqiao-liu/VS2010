using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KM.Common
{
    public static class KYZ
    {
        public static void RefreshKYZ(SqlConnection conn, ComboBox list)
        {
            List<KM.Data.KYZ> kyzList = KM.Data.KYZ.Reads(conn);
            list.Items.Clear();
            foreach (KM.Data.KYZ kyzItem in kyzList)
            {
                list.Items.Add(kyzItem);
            }
        }

        public static String GetKYZDM(object item)
        {
            return ((KM.Data.KYZ)item).DM;
        }

        public static String GetKYZMC(object item)
        {
            return ((KM.Data.KYZ)item).MC;
        }
    }
}
