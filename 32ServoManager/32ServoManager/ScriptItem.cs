using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32ServoManager
{
    public class ScriptItem
    {
        //private List<byte> bytes = new List<byte>();
        //public List<byte> Bytes
        //{
        //    get { return bytes; }
        //    set { bytes = value; }
        //}

        //public override string  ToString()
        //{
        //    string temp = "";
        //    foreach (byte i in bytes)
        //    {
        //        temp += i.ToString("X2");
        //    }
        //    return temp;
        //}
        
        //public void Add(byte sn, byte pw)
        //{
        //    bytes.Add(sn);
        //    bytes.Add(pw);
        //}

        public List<ServoItem> Items { get; set; }

        public ScriptItem()
        {
            Items = new List<ServoItem>();
        }

        public override string ToString()
        {
            string temp = string.Empty;
            foreach (ServoItem i in Items)
            {
                temp += i.ToString();
            }
            return temp;
        }

        public void Add(ServoItem item)
        {
            Items.Add(item);
        }

        public Byte[] ToArray()
        {
            List<byte> bytes = new List<byte>();
            foreach (ServoItem i in Items)
            {
                bytes.Add((byte) (i.SN | 0x80));
                bytes.Add(i.PW);
            }
            return bytes.ToArray();
        }
    }
}
