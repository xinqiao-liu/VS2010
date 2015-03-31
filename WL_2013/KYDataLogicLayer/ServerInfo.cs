using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KYDataLogicLayer
{
    public static class ServerInfo
    {
        public static DateTime GetServerDT()
        {
            return KYDataAccessLayer.ServerInfo.GetServerDT(Runtime.B_CreateCommand());
        }

        public static DateTime GetServerDate()
        {
            return GetServerDT().Date;
        }
    }
}
