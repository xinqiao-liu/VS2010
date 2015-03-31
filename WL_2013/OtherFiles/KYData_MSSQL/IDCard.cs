using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class IDCard
    {
        public String CID { get; set; }
        public String Name { get; set; }
        public String Code { get; set; }
        public Decimal Money { get; set; }
        public String CPH { get; set; }
        public Char IsAdmin { get; set; }
        public Char IsGroup { get; set; }
        public Char IsCycle { get; set; }
        public String Lines { get; set; }
        public DateTime CreateDT { get; set; }
        
        public override String ToString()
        {
            return String.Empty;
        }

        //检测卡号
        public static bool CPHExist(SqlConnection conn, String cph)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM IDCards WHERE [CPH] = @CPH";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = cph;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测车牌号异常：" + ex.Message);
            }
        }

        public static bool CIDExist(SqlConnection conn, String cid)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM IDCards WHERE [CID] = @CID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测卡号异常：" + ex.Message);
            }
        }

        //读取卡号
        public static IDCard Read(SqlConnection conn, String cid)
        {
            try
            {
                IDCard card = null;

                if (conn.State != ConnectionState.Open) conn.Open();
                
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM IDCards WHERE [CID] = @CID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            card = new IDCard();
                            card.CID = cid;
                            card.Name = rdr["Name"].ToString();
                            card.Code = rdr["Code"].ToString();
                            card.Money = Convert.ToDecimal(rdr["Money"]);
                            card.CPH = rdr["CPH"].ToString();
                            card.IsAdmin = rdr["IsAdmin"].ToString()[0];
                            card.IsGroup = rdr["IsGroup"].ToString()[0];
                            card.IsCycle = rdr["IsCycle"].ToString()[0];
                            card.Lines = rdr["Lines"].ToString();
                            card.CreateDT = Convert.ToDateTime(rdr["CreateDT"]);
                        }
                    }
                }
                return card;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取卡号异常：" + ex.Message);
            }
        }

        //读取卡号列表
        public static List<IDCard> Reads(SqlConnection conn)
        {
            try
            {
                List<IDCard> list = new List<IDCard>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM IDCards ORDER BY CreateDT";
                    cmd.Parameters.Clear();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            IDCard card = new IDCard();

                            card.CID = rdr["CID"].ToString();
                            card.Name = rdr["Name"].ToString();
                            card.Code = rdr["Code"].ToString();
                            card.Money = Convert.ToDecimal(rdr["Money"]);
                            card.CPH = rdr["CPH"].ToString();
                            card.IsAdmin = rdr["IsAdmin"].ToString()[0];
                            card.IsGroup = rdr["IsGroup"].ToString()[0];
                            card.IsCycle = rdr["IsCycle"].ToString()[0];
                            card.Lines = rdr["Lines"].ToString();
                            card.CreateDT = Convert.ToDateTime(rdr["CreateDT"]);

                            list.Add(card);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取卡号列表异常：" + ex.Message);
            }
        }

        //插入卡号
        public static bool Insert(SqlConnection conn, IDCard card)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO IDCards ([CID], [Name], [Code], [Money], [CPH], [IsAdmin], [IsGroup], [IsCycle], [Lines]) VALUES(@CID, @Name, @Code, @Money, @CPH, @IsAdmin, @IsGroup, @IsCycle, @Lines)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = card.CID;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = card.Name;
                    cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = card.Code;
                    cmd.Parameters.Add("@Money", SqlDbType.Decimal).Value = card.Money;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = card.CPH;
                    cmd.Parameters.Add("@IsAdmin", SqlDbType.Char).Value = card.IsAdmin.ToString();
                    cmd.Parameters.Add("@IsGroup", SqlDbType.Char).Value = card.IsGroup.ToString();
                    cmd.Parameters.Add("@IsCycle", SqlDbType.Char).Value = card.IsCycle.ToString();
                    cmd.Parameters.Add("@Lines", SqlDbType.NVarChar).Value = card.Lines;
                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入卡号异常：" + ex.Message);
            }
        }

        //删除卡号
        public static bool Delete(SqlConnection conn, String cid)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM IDCards WHERE [CID] = @CID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除卡号异常：" + ex.Message);
            }
        }

        //更新卡号
        public static bool Update(SqlConnection conn, String ocid, IDCard card)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE IDCards SET [CID] = @CID, [Name] = @Name, [Code] = @Code, [Money] = @Money, [CPH] = @CPH, [IsAdmin] = @IsAdmin, [IsGroup] = @IsGroup WHERE [CID] = @OCID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@OCID", SqlDbType.VarChar).Value = ocid;
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = card.CID;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = card.Name;
                    cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = card.Code;
                    cmd.Parameters.Add("@Money", SqlDbType.Decimal).Value = card.Money;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = card.CPH;
                    cmd.Parameters.Add("@IsAdmin", SqlDbType.Char).Value = card.IsAdmin.ToString();
                    cmd.Parameters.Add("@IsGroup", SqlDbType.Char).Value = card.IsGroup.ToString();
                    cmd.Parameters.Add("@IsCycle", SqlDbType.Char).Value = card.IsCycle.ToString();
                    cmd.Parameters.Add("@Lines", SqlDbType.NVarChar).Value = card.Lines;
                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("更新卡号异常：" + ex.Message);
            }
        }

        //设置金额
        public static bool SetMoney(SqlConnection conn, String cid, Decimal money)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE IDCards SET [Money] = [Money] + @Money WHERE [CID] = @CID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;
                    cmd.Parameters.Add("@Money", SqlDbType.Decimal).Value = money;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("设置金额异常：" + ex.Message);
            }
        }

        public static String GetCID(SqlConnection conn, String cph)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [CID] FROM IDCards WHERE [CPH] = @CPH";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = cph;

                    return Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取ID卡号：" + ex.Message);
            }
        }
    }
}
