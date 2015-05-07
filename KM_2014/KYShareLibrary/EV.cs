using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.Common
{
    public static class EV
    {
        public static int Check(SqlConnection conn)
        {
            try
            {
                if (!KM.Data.EV.Exists(conn)) return -1;
              
                TimeSpan ts= Convert.ToDateTime(Base64.DecodeBase64(Base64.CT1, KM.Data.EV.GetRQ(conn))).Subtract(Runtime.QueryDate);

                return ts.Days;
            }
            catch
            {
                return -1;
            }
        }
    }
}
