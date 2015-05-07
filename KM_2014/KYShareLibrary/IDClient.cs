using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KM.Common
{
    public static class IDClient
    {
        public static void RefreshIDCard(SqlConnection conn, ListView list)
        {
            List<KM.Data.IDCard> items = KM.Data.IDCard.Reads(conn);

            list.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                ListViewItem item = new ListViewItem(items[i].CID);
                item.SubItems.Add(items[i].Name);
                item.SubItems.Add(items[i].Code);
                item.SubItems.Add(items[i].CPH);
                item.SubItems.Add((items[i].IsAdmin == '1' ? "是" : "否"));
                item.SubItems.Add((items[i].IsGroup == '1' ? "是" : "否"));
                item.SubItems.Add((items[i].IsCycle == '1' ? "是" : "否"));
                item.SubItems.Add(items[i].Lines);
                item.SubItems.Add(items[i].CreateDT.ToString("yyyy-MM-dd hh:mm:ss"));
                item.SubItems.Add(items[i].Money.ToString("N2"));

                list.Items.Add(item);
            }
        }

        public static void RefreshIDCardPay(SqlConnection conn, ListView list, String cid)
        {
            List<KM.Data.IDCardPay> items = null;

            if (cid == string.Empty)
                items = KM.Data.IDCardPay.Reads(conn);
            else
                items = KM.Data.IDCardPay.Reads(conn, cid);

            list.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                ListViewItem item = new ListViewItem(items[i].CID);
                item.SubItems.Add(items[i].CreateDT.ToString("yyyy-MM-dd hh:mm:ss"));
                item.SubItems.Add(items[i].Context);
                item.SubItems.Add(items[i].Money.ToString("N2"));

                list.Items.Add(item);
            }
        }

        public static void RefreshIDCardLog(SqlConnection conn, ListView list, String cid)
        {
            List<KM.Data.IDCardLog> items = null;

            if (cid == string.Empty)
                items = KM.Data.IDCardLog.Reads(conn);
            else
                items = KM.Data.IDCardLog.Reads(conn, cid);

            list.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                ListViewItem item = new ListViewItem(items[i].CID);
                item.SubItems.Add(items[i].CreateDT.ToString("yyyy-MM-dd hh:mm:ss"));
                item.SubItems.Add(items[i].CPH);
                item.SubItems.Add(items[i].RQ.ToString("yyyy-MM-dd"));
                item.SubItems.Add(items[i].CC);
                item.SubItems.Add(items[i].Type);

                list.Items.Add(item);
            }
        }

        public static DateTime GetIDCardLogLastCreateDT(SqlConnection conn, String cid, String type)
        {
            return KM.Data.IDCardLog.GetCreateDT(conn, cid, type);
        }

        public static Boolean InsertIDCardLog(SqlConnection conn, String cid, String cph, String cc, String type, DateTime createDT)
        {
            return KM.Data.IDCardLog.Insert(conn, new KM.Data.IDCardLog() { Type = type, CID = cid, CPH = cph, CC = cc, RQ = createDT });
        }

        public static Boolean InsertLog(SqlConnection conn, String xm, String cc, String js)
        {
            return KM.Data.CZJL.Insert(conn, new KM.Data.CZJL() { SJ = DateTime.Now, XM = xm, CC = cc, JS = js });
        }

        public static void RefreshIDCardItem(SqlConnection conn, ListView list, String cid)
        {
            List<KM.Data.IDCardItem> items = KM.Data.IDCardItem.Reads(conn, cid);

            list.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                ListViewItem item = new ListViewItem(cid);
                item.SubItems.Add(items[i].CPH);
                item.Tag = items[i].SN;

                list.Items.Add(item);
            }
        }

        public static void RefreshCPH(SqlConnection conn, ComboBox list)
        {
            List<KM.Data.CLK> items = KM.Data.CLK.Reads(conn);

            list.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                list.Items.Add(items[i].CPH);
            }
        }

        public static Boolean ExistsIDCard(SqlConnection conn, String cid)
        {
            return KM.Data.IDCard.CIDExist(conn, cid);
        }

        public static Boolean InsertIDCard(SqlConnection conn, String cid, String name, String code, Decimal money, String cph, Char isAdmin, Char isGroup, Char isCycle, String lines, DateTime createDT)
        {
            return KM.Data.IDCard.Insert(conn, new KM.Data.IDCard() { CID = cid, Name = name, Code = code, Money = money, CPH = cph, IsAdmin = isAdmin, IsGroup = isGroup, IsCycle = isCycle, Lines = lines, CreateDT = createDT});
        }

        public static Boolean UpdateIDCard(SqlConnection conn, String ocid, String cid, String name, String code, Decimal money, String cph, Char isAdmin, Char isGroup, Char isCycle, String lines, DateTime createDT)
        {
            return KM.Data.IDCard.Update(conn, ocid, new KM.Data.IDCard() { CID = cid, Name = name, Code = code, Money = money, CPH = cph, IsAdmin = isAdmin, IsGroup = isGroup, IsCycle = isCycle, Lines = lines, CreateDT = createDT });
        }

        public static Boolean DeleteIDCard(SqlConnection conn, String cid)
        {
            return KM.Data.IDCard.Delete(conn, cid);
        }

        public static Boolean SetIDCardMoney(SqlConnection conn, String cid, Decimal money)
        {
            return KM.Data.IDCard.SetMoney(conn, cid, money);
        }

        public static Boolean ExistsIDCardItem(SqlConnection conn, String cid, String cph)
        {
            return KM.Data.IDCardItem.Exist(conn, cid, cph);
        }

        public static Boolean InsertIDCardItem(SqlConnection conn, String cid, String cph)
        {
            return KM.Data.IDCardItem.Insert(conn, new KM.Data.IDCardItem() { SN = 0, CID = cid, CPH = cph });
        }

        public static Boolean UpdateIDCardItem(SqlConnection conn, Int32 sn, String cid, String cph)
        {
            return KM.Data.IDCardItem.Update(conn, new KM.Data.IDCardItem() { SN = sn, CID = cid, CPH = cph });
        }

        public static Boolean DeleteIDCardItem(SqlConnection conn, String cid, String cph)
        {
            return KM.Data.IDCardItem.Delete(conn, cid, cph);
        }

        public static Boolean DeleteIDCardItem(SqlConnection conn, String cid)
        {
            return KM.Data.IDCardItem.Delete(conn, cid);
        }

        public static void RefreshBindCPH(SqlConnection conn, ComboBox list, String cid, String cph, Char isGroup)
        {
            if (isGroup == '1' && KM.Data.IDCardItem.Exist(conn, cid))
            {
                List<KM.Data.IDCardItem> items = KM.Data.IDCardItem.Reads(conn, cid);

                list.Items.Clear();
                for (int i = 0; i < items.Count; i++)
                {
                    list.Items.Add(items[i].CPH);
                }
            }
            else
                list.Items.Add(cph);
        }

        public static void RefreshJSD(SqlConnection conn, ComboBox list, String cph)
        {
            List<KM.Data.JSD> items = KM.Data.JSD.Reads_CPH(conn, cph);

            list.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                list.Items.Add(items[i]);
            }
        }

        public static void RefreshCP(SqlConnection conn, ListBox list, DateTime rq, String cc)
        {
            List<KM.Data.LSCPB> items = KM.Data.LSCPB.Reads(conn, rq, cc);

            list.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                list.Items.Add(items[i]);
            }
        }

        public static void RefreshWY(SqlConnection conn, ListView list, String cph)
        {
            List<KM.Data.WYRecord> items = KM.Data.WYRecord.Reads(conn, cph);

            list.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                list.Items.Add(new ListViewItem(new String[] { items[i].ID, items[i].CDT.ToString("yyyy-MM-dd"), items[i].DD, items[i].WYX, items[i].WYJ.ToString("N2")}));
            }
        }

        public static DateTime GetJSD_RQ(object jsd)
        {
            return ((KM.Data.JSD)jsd).RQ;
        }

        public static String GetJSD_CC(object jsd)
        {
            return ((KM.Data.JSD)jsd).CC;
        }

        public static void RefreshBCK(SqlConnection conn, ListBox list, DateTime rq, String startTime)
        {
            List<KM.Data.BCK> items = KM.Data.BCK.Reads(conn, rq, startTime);
            for (int n = 0; n < items.Count; n++)
            {
                list.Items.Add(items[n]);
            }
        }

        public static void RefreshBCK(SqlConnection conn, ListBox list, DateTime rq, String cph, String zdz, String startTime)
        {
            List<KM.Data.BCK> items = KM.Data.BCK.Reads(conn, rq, cph, zdz, startTime);
            for (int n = 0; n < items.Count; n++)
            {
                list.Items.Add(items[n]);
            }
        }
    }
}
