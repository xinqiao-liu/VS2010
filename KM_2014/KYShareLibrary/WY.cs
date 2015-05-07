using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KM.Common
{
    public static class WY
    {
        public static void RefreshWY(SqlConnection conn, ListView list)
        {
            List<KM.Data.WYRecord> wyList = KM.Data.WYRecord.Reads(conn);

            list.Items.Clear();
            foreach (KM.Data.WYRecord wyItem in wyList)
            {
                list.Items.Add(new ListViewItem(new String[] { wyItem.ID, wyItem.CPH, wyItem.DW, wyItem.CZ, wyItem.RQ.ToString("yyyy-MM-dd"), wyItem.DD, wyItem.SFZ, wyItem.ZDZ, wyItem.WYX, wyItem.WYJ.ToString("N2"), wyItem.JBR, wyItem.LRR, wyItem.CDT.ToString("yyyy-MM-dd hh:mm:ss"), wyItem.Print }));
            }
        }

        public static bool ExistsWY(SqlConnection conn, String id)
        {
            return KM.Data.WYRecord.Exists(conn, id);
        }

        public static void InsertWY(String id, String cph, String dw, String cz, DateTime rq, String dd, String sfz, String zdz, String wyx, Decimal wyj, String jbr, String lrr, String print)
        {
            KM.Data.WYRecord item = new KM.Data.WYRecord();
            item.ID = id;
            item.CPH = cph;
            item.DW = dw;
            item.CZ = cz;
            item.RQ = rq;
            item.DD = dd;
            item.SFZ = sfz;
            item.ZDZ = zdz;
            item.WYX = wyx;
            item.WYJ = wyj;
            item.JBR = jbr;
            item.LRR = lrr;
            item.CDT = DateTime.Now;
            item.Print = print;

            KM.Data.WYRecord.Insert(Connections.OneConnection, item);
        }

        public static void RefreshZDZ(SqlConnection conn, ComboBox list)
        {
            List<String> items = KM.Data.BCK.Reads_ZDZ(conn);

            list.Items.Clear();
            foreach (String item in items)
            {
                list.Items.Add(item);
            }
        }

        public static void RefreshWYItem(SqlConnection conn, ComboBox list)
        {
            List<KM.Data.WYItem> wyItems = KM.Data.WYItem.Reads(conn);

            list.Items.Clear();
            foreach (KM.Data.WYItem wyItem in wyItems)
            {
                list.Items.Add(wyItem);
            }
        }

        public static void RefreshWYItem(SqlConnection conn, ListView list)
        {
            List<KM.Data.WYItem> wyItems = KM.Data.WYItem.Reads(conn);

            list.Items.Clear();
            foreach (KM.Data.WYItem wyItem in wyItems)
            {
                list.Items.Add(new ListViewItem(new String[] { wyItem.ID, wyItem.Item, wyItem.Value.ToString("N2") }));
            }
        }

        public static Decimal GetWYValue(object item)
        {
            return ((KM.Data.WYItem)item).Value;
        }

        public static bool ExistsWYItem(SqlConnection conn, String id)
        {
            return KM.Data.WYItem.Exists(conn, id);
        }

        public static bool DeleteWYItem(SqlConnection conn, String id)
        {
            return KM.Data.WYItem.Delete(conn, id);
        }

        public static bool InsertWYItem(SqlConnection conn, String id, String item, Decimal value)
        {
            return KM.Data.WYItem.Insert(conn, new KM.Data.WYItem() { ID = id, Item = item, Value = value });
        }

        public static bool UpdateWYItem(SqlConnection conn, String oid, String id, String item, Decimal value)
        {
            return KM.Data.WYItem.Update(conn, oid, new KM.Data.WYItem() { ID = id, Item = item, Value = value });
        }

        public static void RefreshWYSite(SqlConnection conn, ComboBox list)
        {
            List<KM.Data.WYSite> wySites = KM.Data.WYSite.Reads(conn);

            list.Items.Clear();
            foreach (KM.Data.WYSite wySite in wySites)
            {
                list.Items.Add(wySite);
            }
        }

        public static void RefreshWYSite(SqlConnection conn, ListView list)
        {
            List<KM.Data.WYSite> wySites = KM.Data.WYSite.Reads(conn);

            list.Items.Clear();
            foreach (KM.Data.WYSite wySite in wySites)
            {
                list.Items.Add(new ListViewItem(new String[] { wySite.ID, wySite.Site }));
            }
        }

        public static bool ExistsWYSite(SqlConnection conn, String id)
        {
            return KM.Data.WYSite.Exists(conn, id);
        }

        public static bool DeleteWYSite(SqlConnection conn, String id)
        {
            return KM.Data.WYSite.Delete(conn, id);
        }

        public static bool InsertWYSite(SqlConnection conn, String id, String site)
        {
            return KM.Data.WYSite.Insert(conn, new KM.Data.WYSite() { ID = id, Site = site });
        }

        public static bool UpdateWYSite(SqlConnection conn, String oid, String id, String site)
        {
            return KM.Data.WYSite.Update(conn, oid, new KM.Data.WYSite() { ID = id, Site = site });
        }
    }
}
