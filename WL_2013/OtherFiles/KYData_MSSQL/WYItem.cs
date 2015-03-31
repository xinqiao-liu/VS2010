using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class WYItem
    {
        public String ID { get; set; }
        public String Item { get; set; }
        public Decimal Value { get; set; }

        public override String ToString()
        {
            return Item;
        }

        public static bool Exists(SqlConnection conn, String id)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM WYItem WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测违约项目异常：" + ex.Message);
            }
        }

        public static WYItem Read(SqlConnection conn, String id)
        {
            try
            {
                WYItem item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WYItem WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new WYItem();
                            item.ID = id;

                            if (rdr["Item"] != DBNull.Value) item.Item = rdr["Item"].ToString().Trim();
                            if (rdr["Value"] != DBNull.Value) item.Value = Convert.ToDecimal(rdr["Value"]);
                        }
                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取违约项目异常：" + ex.Message);
            }
        }

        public static List<WYItem> Reads(SqlConnection conn)
        {
            try
            {
                List<WYItem> list = new List<WYItem>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WYItem ORDER BY ID";
                    cmd.Parameters.Clear();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            WYItem item = new WYItem();

                            if (rdr["ID"] != DBNull.Value) item.ID = rdr["ID"].ToString().Trim();
                            if (rdr["Item"] != DBNull.Value) item.Item = rdr["Item"].ToString().Trim();
                            if (rdr["Value"] != DBNull.Value) item.Value = Convert.ToDecimal(rdr["Value"]);

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取全部违约项目异常：" + ex.Message);
            }
        }

        public static bool Delete(SqlConnection conn, String id)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM WYItem WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除违约项目异常：" + ex.Message);
            }
        }

        public static bool Insert(SqlConnection conn, WYItem item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WYItem ([ID], [Item], [Value]) VALUES( @ID, @Item, @Value) ";
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = item.ID;
                    cmd.Parameters.Add("@Item", SqlDbType.NVarChar).Value = item.Item;
                    cmd.Parameters.Add("@Value", SqlDbType.Decimal).Value = item.Value;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入违约项目异常：" + ex.Message);
            }
        }

        public static bool Update(SqlConnection conn, String id, WYItem item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE WYItem SET [ID] = @ID, [Item] = @Item, [Value] = @Value WHERE [ID] = @OID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = item.ID;
                    cmd.Parameters.Add("@Item", SqlDbType.NVarChar).Value = item.Item;
                    cmd.Parameters.Add("@Value", SqlDbType.Decimal).Value = item.Value;
                    cmd.Parameters.Add("@OID", SqlDbType.NVarChar).Value = id;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("更新违约项目异常：" + ex.Message);
            }
        }
    }
}
