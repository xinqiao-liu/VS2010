using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.Common
{
    public static class Log
    {
        public static void InsertCZJL(SqlConnection conn, String cc, String js)
        {
            try
            {
                KM.Data.CZJL.Insert(conn, new KM.Data.CZJL() { XM = Runtime.Name, SJ = DateTime.Now, CC = cc, JS = js });
            }
            catch { }
        }
    }
}
