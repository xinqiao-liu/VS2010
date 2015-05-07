using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KYDataAccessLayer
{
    public static class ZMPJB
    {
        public static KYDataModelLayer.ZMPJB Read(SqlCommand cmd, String zddm, String lb)
        {
            KYDataModelLayer.ZMPJB item = null;

            cmd.CommandText = "SELECT [ZM], L" + lb[0].ToString() + ", " + lb[0].ToString() + ", [ZWF], [NM] FROM ZMPJB WHERE [ZDDM] = @ZDDM";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ZDDM", SqlDbType.Char).Value = zddm;
            //cmd.Parameters.Add("@LB", SqlDbType.Char).Value = temp;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    item = new KYDataModelLayer.ZMPJB();

                    item.ZDDM = zddm;
                    item.ZM = (rdr["zm"] != DBNull.Value) ? rdr["zm"].ToString().Trim() : "";
                    item.LC = (rdr["l" + lb[0].ToString()] != DBNull.Value) ? Convert.ToInt32(rdr["l" + lb[0].ToString()]) : 0;
                    item.PJ = (rdr[lb[0].ToString()] != DBNull.Value) ? Convert.ToDecimal(rdr[lb[0].ToString()]) : 0;
                    item.ZWF = (rdr["zwf"] != DBNull.Value) ? Convert.ToDecimal(rdr["zwf"]) : 0;
                    item.NM = (rdr["nm"] != DBNull.Value) ? rdr["nm"].ToString().Trim() : "";
                }
            }
            return item;
        }

        public static String GetName(SqlCommand cmd, String nm)
        {
            cmd.CommandText = "SELECT [ZM] FROM ZMPJB WHERE [NM] = @NM";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@NM", SqlDbType.Char).Value = nm;

            return Convert.ToString(cmd.ExecuteScalar()).Trim();
        }

        public static String GetCode(SqlCommand cmd, String nm)
        {
            cmd.CommandText = "SELECT [ZDDM] FROM ZMPJB WHERE [NM] = @NM";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@NM", SqlDbType.Char).Value = nm;

            return Convert.ToString(cmd.ExecuteScalar()).Trim();
        }
    }
}
