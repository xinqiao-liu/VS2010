using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYDataAccessLayer
{
    public static class CLK
    {
        public static Boolean Exist(SqlCommand cmd, String cph)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM CLK WHERE [cph] = @cph";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cph", SqlDbType.Char).Value = cph;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }
    }
}
