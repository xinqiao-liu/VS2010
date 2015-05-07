using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class User
    {
        private static Model.User ToUser(SqlDataReader rdr)
        {
            Model.User user = new Model.User();

            user.Userid = rdr["userid"].ToString();
            user.Username = rdr["username"].ToString();
            user.Password = rdr["password"].ToString();
            user.NodeCode = rdr["nodecode"].ToString();
            user.NodeName = rdr["nodename"].ToString();
            user.MP = Convert.ToChar(rdr["manage_priv"]) == 'Y' ? true : false;
            user.SP = Convert.ToChar(rdr["select_priv"]) == 'Y' ? true : false;
            user.IP = Convert.ToChar(rdr["insert_priv"]) == 'Y' ? true : false;
            user.UP = Convert.ToChar(rdr["update_priv"]) == 'Y' ? true : false;
            user.DP = Convert.ToChar(rdr["delete_priv"]) == 'Y' ? true : false;
            user.Enable = Convert.ToChar(rdr["enable"]) == 'Y' ? true : false;
            user.CDT = Convert.ToDateTime(rdr["cdt"]);

            return user;
        }

        public static bool Exists(SqlCommand cmd, string userid)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM [USER] WHERE [userid] = @userid AND [enable] = 'Y'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.User user)
        {
            cmd.CommandText = "INSERT INTO [USER] ([userid], [username], [password], [nodecode], [nodename], [manage_priv], [select_priv], [insert_priv], [update_priv], [delete_priv], [enable]) "
                + "VALUES (@userid, @username, @password, @nodecode, @nodename, @manage_priv, @select_priv, @insert_priv, @update_priv, @delete_priv, @enable)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = user.Userid;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user.Username;
            cmd.Parameters.Add("@nodecode", SqlDbType.VarChar).Value = user.NodeCode;
            cmd.Parameters.Add("@nodename", SqlDbType.VarChar).Value = user.NodeName;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = user.Password;
            cmd.Parameters.Add("@manage_priv", SqlDbType.Char).Value = user.MP ? "Y" : "N";
            cmd.Parameters.Add("@select_priv", SqlDbType.Char).Value = user.SP ? "Y" : "N";
            cmd.Parameters.Add("@insert_priv", SqlDbType.Char).Value = user.IP ? "Y" : "N";
            cmd.Parameters.Add("@update_priv", SqlDbType.Char).Value = user.UP ? "Y" : "N";
            cmd.Parameters.Add("@delete_priv", SqlDbType.Char).Value = user.DP ? "Y" : "N";
            cmd.Parameters.Add("@enable", SqlDbType.Char).Value = user.Enable ? "Y" : "N";

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string userid)
        {
            cmd.CommandText = "DELETE FROM [USER] WHERE [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, string old_userid, Model.User user)
        {
            cmd.CommandText = "UPDATE [USER] SET [userid] = @userid, [username] = @username, [nodecode] = @nodecode, [nodename] = @nodename, [enable] = @enable, "
                + "[manage_priv] = @manage_priv, [select_priv] = @select_priv, [insert_priv] = @insert_priv, [update_priv] = @update_priv, [delete_priv] = @delete_priv "
                + "WHERE [userid] = @old_userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@old_userid", SqlDbType.VarChar).Value = old_userid;
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = user.Userid;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user.Username;
            //cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = user.Password;
            cmd.Parameters.Add("@nodecode", SqlDbType.VarChar).Value = user.NodeCode;
            cmd.Parameters.Add("@nodename", SqlDbType.VarChar).Value = user.NodeName;
            cmd.Parameters.Add("@manage_priv", SqlDbType.Char).Value = user.MP ? "Y" : "N";
            cmd.Parameters.Add("@select_priv", SqlDbType.Char).Value = user.SP ? "Y" : "N";
            cmd.Parameters.Add("@insert_priv", SqlDbType.Char).Value = user.IP ? "Y" : "N";
            cmd.Parameters.Add("@update_priv", SqlDbType.Char).Value = user.UP ? "Y" : "N";
            cmd.Parameters.Add("@delete_priv", SqlDbType.Char).Value = user.DP ? "Y" : "N";
            cmd.Parameters.Add("@enable", SqlDbType.Char).Value = user.Enable ? "Y" : "N";

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static Model.User Read(SqlCommand cmd, string userid)
        {
            cmd.CommandText = "SELECT * FROM [USER] WHERE [userid] = @userid AND [enable] = 'Y'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return ToUser(rdr);
            }
            return null;
        }

        public static List<Model.User> Reads(SqlCommand cmd)
        {
            List<Model.User> list = new List<Model.User>();

            cmd.CommandText = "SELECT * FROM [USER]";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToUser(rdr));
                }
            }
            return list;
        }

        public static bool SetUsername(SqlCommand cmd, string userid, string username)
        {
            cmd.CommandText = "UPDATE [USER] SET [username] = @username WHERE [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static string GetUsername(SqlCommand cmd, string userid)
        {
            cmd.CommandText = "SELECT [username] FROM [USER] WHERE [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            return Convert.ToString(cmd.ExecuteScalar());
        }

        public static bool SetPassword(SqlCommand cmd, string userid, string password)
        {
            cmd.CommandText = "UPDATE [USER] SET [password] = @password WHERE [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static string GetPassword(SqlCommand cmd, string userid)
        {
            cmd.CommandText = "SELECT [password] FROM [USER] WHERE [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            return Convert.ToString(cmd.ExecuteScalar());
        }
    }
}
