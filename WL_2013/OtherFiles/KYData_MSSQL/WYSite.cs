using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYData_MSSQL
{
    [Serializable]
    public sealed class WYSite
    {
        public String ID { get; set; }
        public String Site { get; set; }

        public override String ToString()
        {
            return Site;
        }

        public static bool Exists(SqlConnection conn, String id)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) AS Count FROM WYSite WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                    return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("检测违约地点异常：" + ex.Message);
            }
        }

        public static WYSite Read(SqlConnection conn, String id)
        {
            try
            {
                WYSite item = null;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WYSite WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            item = new WYSite();
                            item.ID = id;

                            if (rdr["Site"] != DBNull.Value) item.Site = rdr["Site"].ToString().Trim();
                        }
                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取违约地点异常：" + ex.Message);
            }
        }

        public static List<WYSite> Reads(SqlConnection conn)
        {
            try
            {
                List<WYSite> list = new List<WYSite>();

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WYSite ORDER BY ID";
                    cmd.Parameters.Clear();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            WYSite item = new WYSite();

                            if (rdr["ID"] != DBNull.Value) item.ID = rdr["ID"].ToString().Trim();
                            if (rdr["Site"] != DBNull.Value) item.Site = rdr["Site"].ToString().Trim();

                            list.Add(item);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("获取全部违约地点异常：" + ex.Message);
            }
        }

        public static bool Delete(SqlConnection conn, String id)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM WYSite WHERE [ID] = @ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除违约地点异常：" + ex.Message);
            }
        }

        public static bool Insert(SqlConnection conn, WYSite item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WYSite ([ID], [Site]) VALUES( @ID, @Site) ";
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = item.ID;
                    cmd.Parameters.Add("@Site", SqlDbType.NVarChar).Value = item.Site;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入违约地点异常：" + ex.Message);
            }
        }

        public static bool Update(SqlConnection conn, String id, WYSite item)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE WYSite SET [ID] = @ID, [Site] = @Site WHERE [ID] = @OID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = item.ID;
                    cmd.Parameters.Add("@Site", SqlDbType.NVarChar).Value = item.Site;
                    cmd.Parameters.Add("@OID", SqlDbType.NVarChar).Value = id;

                    return ((cmd.ExecuteNonQuery() > 0) ? true : false);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("更新违约地点异常：" + ex.Message);
            }
        }
    }
}
