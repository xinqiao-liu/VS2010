using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class IDCardItem
    {
        public int SN { get; set; }
        public String CID { get; set; }
        public String CPH { get; set; }

        public override String ToString()
        {
            return String.Empty;
        }

        //检测卡号绑定车牌
        public static bool Exist(SqlConnection conn, String cid)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM IDCardItems WHERE [CID] = @CID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测卡号绑定车牌异常：" + ex.Message);
            }
        }

        //检测卡号绑定车牌
        public static bool Exist(SqlConnection conn, String cid, String cph)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM IDCardItems WHERE [CID] = @CID AND [CPH] = @CPH";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = cph;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测卡号绑定车牌异常：" + ex.Message);
            }
        }

        //读取卡号绑定车牌列表
        public static List<IDCardItem> Reads(SqlConnection conn)
        {
            try
            {
                List<IDCardItem> list = new List<IDCardItem>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM IDCardItems ORDER BY SN";
                    cmd.Parameters.Clear();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            IDCardItem item = new IDCardItem();

                            item.SN = Convert.ToInt32(rdr["SN"]);
                            item.CID = rdr["CID"].ToString();
                            item.CPH = rdr["CPH"].ToString();

                            list.Add(item);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取卡号绑定车牌列表异常：" + ex.Message);
            }
        }

        //读取卡号绑定车牌列表
        public static List<IDCardItem> Reads(SqlConnection conn, String cid)
        {
            try
            {
                List<IDCardItem> list = new List<IDCardItem>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM IDCardItems WHERE [CID] = @CID ORDER BY SN";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            IDCardItem item = new IDCardItem();

                            item.SN = Convert.ToInt32(rdr["SN"]);
                            item.CID = rdr["CID"].ToString();
                            item.CPH = rdr["CPH"].ToString();

                            list.Add(item);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("读取卡号绑定车牌列表异常：" + ex.Message);
            }
        }

        //插入卡号绑定车牌
        public static bool Insert(SqlConnection conn, IDCardItem item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO IDCardItems ([CID], [CPH]) VALUES(@CID, @CPH)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = item.CID;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = item.CPH;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入卡号绑定车牌异常：" + ex.Message);
            }
        }

        //删除指定绑定车牌
        public static bool Delete(SqlConnection conn, int sn)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM IDCardItems WHERE [SN] = @SN";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@SN", SqlDbType.Int).Value = sn;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除指定绑定车牌异常：" + ex.Message);
            }
        }

        //删除卡号绑定车牌
        public static bool Delete(SqlConnection conn, String cid)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM IDCardItems WHERE [CID] = @CID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除卡号绑定车牌异常：" + ex.Message);
            }
        }

        //删除卡号绑定车牌
        public static bool Delete(SqlConnection conn, String cid, String cph)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM IDCardItems WHERE [CID] = @CID AND [CPH] = @CPH";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = cph;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除卡号绑定车牌异常：" + ex.Message);
            }
        }

        //更新卡号绑定车牌
        public static bool Update(SqlConnection conn, IDCardItem item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE IDCardItems SET [CID] = @CID, [CPH] = @CPH WHERE [SN] = @SN";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@SN", SqlDbType.Int).Value = item.SN;
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = item.CID;
                    cmd.Parameters.Add("@CPH", SqlDbType.NVarChar).Value = item.CPH;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("更新卡号绑定车牌异常：" + ex.Message);
            }
        }
    }
}
