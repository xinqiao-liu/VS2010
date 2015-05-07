using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KM.Common
{
    public static class IDServer
    {
        private static KM.Data.IDCard Card = null;
        private static KM.Data.BCK BCK = null;
        private static KM.Data.CLK CLK = null;

        public static String CID
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.CID;
            }
        }

        public static String Name
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.Name;
            }
        }

        public static String Code
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.Code;
            }
        }

        public static Decimal Money
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.Money;
            }
        }

        public static String CPH
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.CPH;
            }
        }

        public static Char IsAdmin
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.IsAdmin;
            }
        }

        public static Char IsGroup
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.IsGroup;
            }
        }

        public static Char IsCycle
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.IsCycle;
            }
        }

        public static String Lines
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.Lines;
            }
        }

        public static DateTime CreateDT
        {
            get
            {
                if (Card == null)
                    throw new ApplicationException("ID 卡数据未初始化！");
                return Card.CreateDT;
            }
        }

        public static bool CardNonNull
        {
            get { return Card != null; }
        }

        public static bool BCKNonNull
        {
            get { return BCK != null; }
        }

        public static bool CLKNonNull
        {
            get { return CLK != null; }
        }

        public static String CLK_CPH
        {
            get
            {
                if (CLK == null)
                    throw new ApplicationException("车辆数据未初始化！");
                return CLK.CPH;
            }
        }

        public static Int32 CLK_DY
        {
            get
            {
                if (CLK == null)
                    throw new ApplicationException("车辆数据未初始化！");
                return CLK.DY;
            }
        }

        public static DateTime BCK_RQ
        {
            get
            {
                if (BCK == null)
                    throw new ApplicationException("班次数据未初始化！");
                return BCK.RQ;
            }
        }

        public static String BCK_CC
        {
            get
            {
                if (BCK == null)
                    throw new ApplicationException("班次数据未初始化！");
                return BCK.CC;
            }
        }

        public static String BCK_FCSJ
        {
            get
            {
                if (BCK == null)
                    throw new ApplicationException("班次数据未初始化！");
                return BCK.FCSJ;
            }
        }

        public static String BCK_ZDZ
        {
            get
            {
                if (BCK == null)
                    throw new ApplicationException("班次数据未初始化！");
                return BCK.ZDZ;
            }
        }

        public static String BCK_CPH
        {
            get
            {
                if (BCK == null)
                    throw new ApplicationException("班次数据未初始化！");
                return BCK.CPH;
            }
        }

        public static Int32 BCK_DY
        {
            get
            {
                if (BCK == null)
                    throw new ApplicationException("班次数据未初始化！");
                return BCK.DY;
            }
        }

        public static DateTime BCK_BDSJ
        {
            get
            {
                if (BCK == null)
                    throw new ApplicationException("班次数据未初始化！");
                return BCK.BDSJ;
            }
        }

        public static Boolean ReadIDCard(SqlConnection conn, String cid)
        {
            Card = KM.Data.IDCard.Read(conn, cid);

            return (Card != null);
        }

        public static Boolean ReadCLK(SqlConnection conn, String cph)
        {
            CLK = KM.Data.CLK.Read(conn, cph);

            return (CLK != null);
        }

        public static Boolean ReadBCK(SqlConnection conn, DateTime rq, String cph, String startTime)
        {
            BCK = KM.Data.BCK.Read(conn, rq, cph, startTime);

            return (BCK != null);
        }

        public static void SetBCKValue(object bck)
        {
            BCK = (KM.Data.BCK) bck;
        }

        //班次签到
        public static bool TransactQD(SqlConnection conn)
        {
            try
            {
                //不刷新班次数据
                //BCK new_bck = bck;

                //重刷新班次数据，从而避免因座号信息改变引发的签到错误
                KM.Data.BCK new_bck = KM.Data.BCK.Read(conn, BCK.RQ, BCK.CC);


                string update_zt = string.Empty, update_cl = string.Empty, where_zh = string.Empty;

                if (CLK.CPH != new_bck.CPH)
                {
                    string temp = GetZHUpdate(new_bck, CLK);

                    update_cl = " , cph = @cph, dy = @dy ";

                    if (temp != string.Empty)
                    {
                        update_cl += temp;
                        where_zh = " AND zh = @zh ";
                    }
                }

                if (new_bck.ZT == "待发") update_zt = " , zt = '售检' ";

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE BCK SET bdsj = GETDATE() " + update_cl + update_zt + " WHERE rq = @rq AND cc = @cc " + where_zh;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@rq", SqlDbType.DateTime).Value = new_bck.RQ;
                    cmd.Parameters.Add("@cc", SqlDbType.VarChar).Value = new_bck.CC;
                  
                    if (CLK.CPH != new_bck.CPH)
                    {
                        cmd.Parameters.Add("@zh", SqlDbType.VarChar).Value = new_bck.ZH;
                        cmd.Parameters.Add("@cph", SqlDbType.VarChar).Value = CLK.CPH;
                        cmd.Parameters.Add("@dy", SqlDbType.Int).Value = CLK.DY;
                    }

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("签到 -" + ex.Message);
            }
            //return false;
        }

        private static String GetZHUpdate(KM.Data.BCK bck, KM.Data.CLK clk)
        {
            if (clk.DY > bck.DY)
            {
                return " , zh = '" + bck.ZH.PadRight(clk.DY, '0') + "' ";
            }

            if (clk.DY < bck.DY)
            {
                //判断座号指定范围状态是否未改变
                for (int i = clk.DY; i < bck.DY; i++)
                {
                    if (bck.ZH.Length < i || bck.ZH[i] != '0') return string.Empty;
                }

                return " , zh = '" + bck.ZH.Remove(clk.DY) + "' ";
            }
            return string.Empty;
        }
    }
}
