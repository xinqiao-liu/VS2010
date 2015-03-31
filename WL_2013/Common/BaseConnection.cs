using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Common
{
    public class BaseConnection : IDisposable
    {
        private SqlConnection m_connection;
        private bool m_pingEnabled;
        private int m_pingTimeout;

        public SqlConnection Connection
        {
            get 
            {
                if (this.m_connection == null)
                    throw new ApplicationException("数据连接未初始化！");
                else
                    return this.m_connection; 
            }
            set { this.m_connection = value; }
        }

        public BaseConnection(string connStr, StateChangeEventHandler handler, bool pingEnabled, int pingTimeout)
        {
            this.Connection = new SqlConnection(connStr);
            this.m_pingEnabled = pingEnabled;
            this.m_pingTimeout = pingTimeout;

            if(handler != null) this.Connection.StateChange += handler;
        }

        public bool Compare(string connStr)
        {
            return (this.Connection.ConnectionString == connStr);
        }

        public void Open()
        {
            //检测是否 ping 服务器地址
            if (this.m_pingEnabled && !NetTools.Ping(this.Connection.DataSource, this.m_pingTimeout))
            {
                throw new ApplicationException(string.Format("主机 '{0}' 无法到达，请检查网络是否已连接！", this.Connection.DataSource));
            }

            if (this.Connection.State != ConnectionState.Open) this.Connection.Open();
        }

        public void Close()
        {
            if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
        }

        public SqlCommand CreateCommand()
        {
            if (this.Connection.State != ConnectionState.Open) this.Open();
            
            return this.Connection.CreateCommand();                
        }

        public SqlTransaction CreateTransaction()
        {
            if (this.Connection.State != ConnectionState.Open) this.Open();

            return this.Connection.BeginTransaction();
        }

        public void Dispose()
        {
            this.Close();        
        }
    }
}
