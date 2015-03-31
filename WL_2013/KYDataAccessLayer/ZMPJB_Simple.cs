using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYDataAccessLayer
{
    public static class ZMPJB_Simple
    {
        public static List<KYDataModelLayer.ZMPJB_Simple> Reads(SqlCommand cmd, string zddm, string bdnm)
        {

            List<KYDataModelLayer.ZMPJB_Simple> list = new List<KYDataModelLayer.ZMPJB_Simple>();
            cmd.CommandText = "SELECT [zddm], [zm] FROM ZMPJB WHERE [zddm] LIKE @zddm AND [nm] <> @bdnm ORDER BY [zddm]";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@zddm", SqlDbType.VarChar).Value = zddm;
            cmd.Parameters.Add("@bdnm", SqlDbType.VarChar).Value = bdnm;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    KYDataModelLayer.ZMPJB_Simple item = new KYDataModelLayer.ZMPJB_Simple();

                    if (rdr["zddm"] != DBNull.Value) item.Code = rdr["zddm"].ToString().Trim();
                    if (rdr["zm"] != DBNull.Value) item.Name = rdr["zm"].ToString().Trim();

                    list.Add(item);
                }
            }
            return list;
        }
    }
}
