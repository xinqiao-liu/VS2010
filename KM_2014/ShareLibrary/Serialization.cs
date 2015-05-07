using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace KM.ShareLibrary
{
    public static class Serialization
    {
        public static byte[] ToBinary(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();             
                
                bf.Serialize(stream, obj);

                byte[] array = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(array, 0, (int)stream.Length);

                return array;
            }
        }

        public static object ToObject(byte[] binary)
        {
            using (MemoryStream stream = new MemoryStream(binary))
            {                
                BinaryFormatter bf = new BinaryFormatter();
                
                if (stream.Position != stream.Length)
                {
                    return bf.Deserialize(stream);
                }

                return null;
            }
        }
    }
}
