using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WLDataAccessLayer
{
    public static class ServerInfo
    {
        public static DateTime GetServerDT(SqlCommand cmd)
        {
            cmd.CommandText = "SELECT { fn NOW() } AS ServerTime";
            return Convert.ToDateTime(cmd.ExecuteScalar());
        }
    }
}
