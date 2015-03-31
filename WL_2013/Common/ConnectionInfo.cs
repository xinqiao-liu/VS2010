using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Common
{
    [Serializable]
    public sealed class ConnectionInfo
    {
        public String ServerAddress { get; set; }
        public String Userid { get; set; }
        public String UserPassword { get; set; }
        public String DatabaseName { get; set; }
        public Int32 ConnectionTimeout { get; set; }
        public Boolean PingEnabled { get; set; }
        public Int32 PingTimeout { get; set; }

        public static ConnectionInfo ToConnectionInfo(System.Data.SqlTypes.SqlBinary bytes)
        {
            if (bytes.IsNull)
                return null;
            else
                return (ConnectionInfo)Common.Serialization.ToObject(bytes.Value);
        }

        public static System.Data.SqlTypes.SqlBinary ToSqlBinary(ConnectionInfo conn)
        {
            if (conn == null)
                return System.Data.SqlTypes.SqlBinary.Null;
            else
                return Common.Serialization.ToBinary(conn);
        }

        // 创建连接字符串
        public static String ToConnectionString(ConnectionInfo connInfo)
        {
            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder();
            cb.DataSource = connInfo.ServerAddress;
            cb.UserID = connInfo.Userid;
            cb.Password = connInfo.UserPassword;
            cb.InitialCatalog = connInfo.DatabaseName;
            cb.ConnectTimeout = connInfo.ConnectionTimeout;
            cb.IntegratedSecurity = false;

            return cb.ConnectionString;
        }
    }
}
