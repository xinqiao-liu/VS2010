using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace KM.ShareLibrary
{
    public static class PasswordMD5
    {
        /// <summary>
        /// SSO Service Type
        /// </summary>
        public enum SSOServiceType
        {
            CreateAccount = 0,
            SetPassword
        }

        /// <summary>
        /// MD5 16位加密
        /// </summary>
        /// <param name="strProclaimed">明文</param>
        /// <returns>密文</returns>
        public static string EncryptBy16MD5(string strProclaimed)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string strCryptograph = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(strProclaimed)), 4, 8);
            return strCryptograph;
        }

        /// <summary>
        /// MD5 32位加密
        /// </summary>
        /// <param name="strProclaimed">明文</param>
        /// <returns>密文</returns>
        public static string EncryptBy32MD5(string strProclaimed)
        {
            MD5 md5 = MD5.Create();
            byte[] byteCode = md5.ComputeHash(Encoding.UTF8.GetBytes(strProclaimed));

            StringBuilder sb = new StringBuilder();
            foreach (byte num in byteCode)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                sb.AppendFormat("{0:x2}", num);
            }
            return sb.ToString();
        }

    }
}
