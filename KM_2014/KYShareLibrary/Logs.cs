using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace KM.Common
{
    public enum LogType { 信息, 错误, 警告 }

    public class Logs
    {
        private static string m_Filename = "KM.Log";

        public static string Filename
        {
            get { return m_Filename; }
        }

        public static void WriteLine(string str)
        {
            WriteLine(LogType.信息, str);
        }

        public static void WriteLine(LogType type, string str)
        {
            using (FileStream fs = File.Open(m_Filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("{0} ： {1} -> {2}", type.ToString(), DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), str);
                }
            }
        }
    }
}
