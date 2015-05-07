using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.KYData.Entry
{
    public static class KYZ_User
    {
        //检测用户
        //public static Boolean Exists(SqlConnection conn, String uid)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) AS Count FROM KYZ_USER WHERE [USER_ID] = @UID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;

        //            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("检测用户异常：" + ex.Message);
        //    }
        //}

        //验证用户
        //public static Boolean Validate(SqlConnection conn, String uid, String password)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) AS Count FROM KYZ_USER WHERE [USER_ID] = @UID AND [PASSWD] = @Password";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;
        //            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

        //            //记录验证相关信息
        //            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
        //            {
        //                cmd.CommandText = "UPDATE KYZ_USER SET [LOGIN_DATE] = GetDate(), [ERR_LOGIN_TIMES] = 0 WHERE [USER_ID] = @UID";
        //                cmd.Parameters.Clear();
        //                cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;
        //                cmd.ExecuteNonQuery();

        //                return true;
        //            }
        //            else
        //            {
        //                cmd.CommandText = "UPDATE KYZ_USER SET [ERR_LOGIN_DATE] = GetDate(), [ERR_LOGIN_TIMES] = [ERR_LOGIN_TIMES] + 1 WHERE [USER_ID] = @UID";
        //                cmd.Parameters.Clear();
        //                cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;
        //                cmd.ExecuteNonQuery();

        //                return false;
        //            }                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("验证用户异常：" + ex.Message);
        //    }
        //}

        //重设口令
        //public static Boolean ResetPassword(SqlConnection conn, String uid, String oldPassword, String newPassword)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "UPDATE KYZ_USER SET [PASSWD] = @NewPassword, [U_PASSWD_DATE] = GetDate() WHERE [USER_ID] = @UID AND [PASSWD] = @OldPassword";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;
        //            cmd.Parameters.Add("@OldPassword", SqlDbType.VarChar).Value = oldPassword;
        //            cmd.Parameters.Add("@NewPassword", SqlDbType.VarChar).Value = newPassword;

        //            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("重设口令异常：" + ex.Message);
        //    }
        //}

        //验证权限
        //public static Boolean Right(SqlConnection conn, String uid, Int32 rid)
        //{
        //    try
        //    {
        //        List<Int32> list = new List<Int32>();

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT * FROM USER_RIGHT WHERE [MENU_ID] = @RID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@RID", SqlDbType.Int).Value = rid;

        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    list.Add(Convert.ToInt32(rdr["role_id"]));
        //                }
        //            }
        //        }

        //        foreach(Int32 i in list)
        //        {
        //            if (KYZ_User.Role(conn, uid, i)) return true;
        //        }

        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("验证权限异常：" + ex.Message);
        //    }            
        //}

        //验证角色
        //public static Boolean Role(SqlConnection conn, String uid, Int32 rid)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) AS Count FROM USER_ROLE WHERE [USER_ID] = @UID AND [ROLE_ID] = @RID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;
        //            cmd.Parameters.Add("@RID", SqlDbType.Int).Value = rid;

        //            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("验证角色异常：" + ex.Message);
        //    }
        //}

        //验证系统
        //public static Boolean System(SqlConnection conn, String uid, Int32 sid)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) AS Count FROM USER_SYSTEM WHERE [USER_ID] = @UID AND [SYSTEM_ID] = @SID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;
        //            cmd.Parameters.Add("@SID", SqlDbType.Int).Value = sid;

        //            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("验证系统异常：" + ex.Message);
        //    }
        //}

        //读取用户信息
        //public static KYZ_User Read(SqlConnection conn, String uid)
        //{
        //    try
        //    {
        //        KYZ_User kyz_user = null;

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT * FROM KYZ_USER WHERE [USER_ID] = @UID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;

        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.Read())
        //                {
        //                    kyz_user = new KYZ_User();

        //                    if (rdr["user_id"] != DBNull.Value) kyz_user.UID = rdr["user_id"].ToString();
        //                    if (rdr["name"] != DBNull.Value) kyz_user.Name = rdr["name"].ToString();
        //                    if (rdr["fullname"] != DBNull.Value) kyz_user.Fullname = rdr["fullname"].ToString();
        //                    if (rdr["passwd"] != DBNull.Value) kyz_user.Password = rdr["passwd"].ToString();
        //                    if (rdr["o_telephone"] != DBNull.Value) kyz_user.OfficeTelephone = rdr["o_telephone"].ToString();
        //                    if (rdr["mobile"] != DBNull.Value) kyz_user.Mobile = rdr["mobile"].ToString();
        //                    if (rdr["email"] != DBNull.Value) kyz_user.Email = rdr["email"].ToString();
        //                    if (rdr["login_date"] != DBNull.Value) kyz_user.LoginDate = Convert.ToDateTime(rdr["login_date"]);
        //                    if (rdr["u_passwd_date"] != DBNull.Value) kyz_user.ResetPasswordDate = Convert.ToDateTime(rdr["u_passwd_date"]);
        //                    if (rdr["err_login_date"] != DBNull.Value) kyz_user.ErrLoginDate = Convert.ToDateTime(rdr["err_login_date"]);
        //                    if (rdr["err_login_times"] != DBNull.Value) kyz_user.ErrLoginCount = Convert.ToInt32(rdr["err_login_times"]);
        //                    if (rdr["symbol"] != DBNull.Value) kyz_user.Symbol = rdr["symbol"].ToString().Trim();
        //                    if (rdr["cid"] != DBNull.Value) kyz_user.CID = rdr["cid"].ToString();                        
        //                }
        //            }
        //        }
        //        return kyz_user;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("读取用户信息异常：" + ex.Message);
        //    }
        //}

        //读取用户数据
        //public static List<KYZ_User> Reads(SqlConnection conn, String type)
        //{
        //    try
        //    {
        //        List<KYZ_User> list = new List<KYZ_User>();

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT * FROM KYZ_USER WHERE [FULLNAME] = @TYPE ORDER BY [USER_ID]";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@TYPE", SqlDbType.VarChar).Value = type;

        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    KYZ_User item = new KYZ_User();

        //                    if (rdr["user_id"] != DBNull.Value) item.UID = rdr["user_id"].ToString();
        //                    if (rdr["name"] != DBNull.Value) item.Name = rdr["name"].ToString();
        //                    if (rdr["fullname"] != DBNull.Value) item.Fullname = rdr["fullname"].ToString();
        //                    if (rdr["passwd"] != DBNull.Value) item.Password = rdr["passwd"].ToString();
        //                    if (rdr["o_telephone"] != DBNull.Value) item.OfficeTelephone = rdr["o_telephone"].ToString();
        //                    if (rdr["mobile"] != DBNull.Value) item.Mobile = rdr["mobile"].ToString();
        //                    if (rdr["email"] != DBNull.Value) item.Email = rdr["email"].ToString();
        //                    if (rdr["login_date"] != DBNull.Value) item.LoginDate = Convert.ToDateTime(rdr["login_date"]);
        //                    if (rdr["u_passwd_date"] != DBNull.Value) item.ResetPasswordDate = Convert.ToDateTime(rdr["u_passwd_date"]);
        //                    if (rdr["err_login_date"] != DBNull.Value) item.ErrLoginDate = Convert.ToDateTime(rdr["err_login_date"]);
        //                    if (rdr["err_login_times"] != DBNull.Value) item.ErrLoginCount = Convert.ToInt32(rdr["err_login_times"]);
        //                    if (rdr["symbol"] != DBNull.Value) item.Symbol = rdr["symbol"].ToString().Trim();
        //                    if (rdr["cid"] != DBNull.Value) item.CID = rdr["cid"].ToString();

        //                    list.Add(item);
        //                }
        //            }
        //        }
        //        return list;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("读取用户数据异常：" + ex.Message);
        //    }
        //}

        //获取用户编号
        //public static String CIDToUID(SqlConnection conn, String cid)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT [USER_ID] FROM KYZ_USER WHERE [CID] = @CID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;

        //            return Convert.ToString(cmd.ExecuteScalar());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取用户编号异常：" + ex.Message);
        //    }
        //}

        //获取用户名称
        //public static String GetName(SqlConnection conn, String uid)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT [NAME] FROM KYZ_USER WHERE [USER_ID] = @UID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;

        //            return Convert.ToString(cmd.ExecuteScalar());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取用户名称异常：" + ex.Message);
        //    }
        //}

        //检测卡号
        //public static Boolean CIDExists(SqlConnection conn, String cid)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) AS Count FROM KYZ_USER WHERE CID = @CID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;

        //            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("检测卡号异常：" + ex.Message);
        //    }
        //}

        //设置卡号
        //public static Boolean SetCID(SqlConnection conn, String uid, String cid)
        //{
        //    try
        //    {
        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "UPDATE KYZ_USER SET CID = @CID WHERE [USER_ID] = @UID";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add("@UID", SqlDbType.VarChar).Value = uid;
        //            cmd.Parameters.Add("@CID", SqlDbType.VarChar).Value = cid;

        //            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("设置卡号异常：" + ex.Message);
        //    }
        //}


        //获取用户类型
        //public static List<String> GetTypes(SqlConnection conn)
        //{
        //    try
        //    {
        //        List<String> list = new List<string>();

        //        if (conn.State != ConnectionState.Open) conn.Open();

        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT [FULLNAME] FROM KYZ_USER GROUP BY [FULLNAME]";
        //            cmd.Parameters.Clear();

        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {                          
        //                    if (rdr["fullname"] != DBNull.Value) list.Add(rdr["fullname"].ToString());
        //                }
        //            }
        //        }
        //        return list;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("获取用户类型：" + ex.Message);
        //    }
        //}
    }
}
