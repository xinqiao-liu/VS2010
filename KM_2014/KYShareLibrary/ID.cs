using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KM.Common
{
    public static class ID
    {
        public static void RefreshUserTypes(SqlConnection conn, ToolStripComboBox list)
        {
            List<String> types = KM.Data.KYZ_User.GetTypes(conn);

            list.Items.Clear();
            foreach (String item in types)
            {
                list.Items.Add(item);
            }
        }

        public static void RefreshUsers(SqlConnection conn, ListView list, String type)
        {
            List<KM.Data.KYZ_User> users = KM.Data.KYZ_User.Reads(conn, type);

            list.Items.Clear();
            foreach (KM.Data.KYZ_User user in users)
            {
                list.Items.Add(new ListViewItem(new String[] { user.UID, user.Name, user.Fullname, user.CID }));
            }
        }
    }
}
