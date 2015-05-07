using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace KM.Common
{
    public static class Serializable
    {
        /*
        //序列化代码
        public static void ExportQDDataToFile(String filename, List<KM.Data.OleDb.QDItem> items)
        {
            //打开文件流
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                //创建二进制序列化对象
                BinaryFormatter bf = new BinaryFormatter();                
                //调用二进制序列化对象的序列化方法执行序列化操作
                bf.Serialize(fs, items);
            }
        }

        //反序列化代码
        public static List<KM.Data.OleDb.QDItem> ImportQDDataFromFile(String filename)
        {
            List<KM.Data.OleDb.QDItem> items = new List<KM.Data.OleDb.QDItem>();

            //打开文件流
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                //创建二进制序列化对象
                BinaryFormatter bf = new BinaryFormatter();
                //调用二进制序列化对象的反序列化方法执行反序列化操作
                return bf.Deserialize(fs) as List<KM.Data.OleDb.QDItem>;
            }
        }
        */
    }
}
