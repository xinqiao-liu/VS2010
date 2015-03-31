using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class IDCardPay
    {
        public int SN { get; set; }
        public String CID { get; set; }
        public Decimal Money { get; set; }
        public String Context { get; set; }
        public DateTime CreateDT { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        //读取支付列表
        public static List<IDCardPay> Reads(SqlConnection conn, String cid)
        {
            try
            {
                List<IDCardPay> list = new List<IDCardPay>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM IDCardPay WHERE [CID] = @CID ORDER BY SN";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            IDCardPay pay = new IDCardPay();

                            pay.CID = rdr["CID"].ToString();
                            pay.Money = Convert.ToDecimal(rdr["Money"]);
                            pay.Context = rdr["Context"].ToString();
                            pay.CreateDT = Convert.ToDateTime(rdr["CreateDT"]);

                            list.Add(pay);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取支付列表异常：" + ex.Message);
            }
        }

        //读取全部支付列表
        public static List<IDCardPay> Reads(SqlConnection conn)
        {
            try
            {
                List<IDCardPay> list = new List<IDCardPay>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM IDCardPay ORDER BY SN";
                    cmd.Parameters.Clear();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            IDCardPay pay = new IDCardPay();

                            pay.CID = rdr["CID"].ToString();
                            pay.Money = Convert.ToDecimal(rdr["Money"]);
                            pay.Context = rdr["Context"].ToString();
                            pay.CreateDT = Convert.ToDateTime(rdr["CreateDT"]);

                            list.Add(pay);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取全部支付列表异常：" + ex.Message);
            }
        }

        //插入支付记录
        public static bool Insert(SqlConnection conn, IDCardPay pay)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO IDCardPay ([CID], [Money], [Context]) VALUES(@CID, @Money, @Context)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = pay.CID;
                    cmd.Parameters.Add("@Money", SqlDbType.Decimal).Value = pay.Money;
                    cmd.Parameters.Add("@Context", SqlDbType.NVarChar).Value = pay.Context;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);

                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入支付记录异常：" + ex.Message);
            }
        }
    }
}
