using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WLDataModelLayer
{
    [Serializable]
    public sealed class Authorize
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public System.Data.SqlTypes.SqlBinary Content { get; set; }

        public override string ToString()
        {
            return this.Code + "-" + this.Name;
        }

        public Authorize(Node item)
            : this(item, System.Data.SqlTypes.SqlBinary.Null)
        {}

        public Authorize(Node item, System.Data.SqlTypes.SqlBinary content)
            : this(item.Code, item.Name, item.CityCode, item.CityName, content)
        {}

        public Authorize(string code, string name, string citycode, string cityname, System.Data.SqlTypes.SqlBinary content)
        {
            this.Code = code;
            this.Name = name;
            this.CityCode = citycode;
            this.CityName = cityname;
            this.Content = content;
        }

        public static System.Data.SqlTypes.SqlBinary Import(string filename)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                return (System.Data.SqlTypes.SqlBinary)binFormat.Deserialize(fStream);
            }
        }

        public static void Export(string filename, System.Data.SqlTypes.SqlBinary content)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, content);
            }
        }

    }
}
