using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32ServoManager
{
    public class ServoItem
    {
        public Byte SN { get; set; }
        public Byte PW { get; set; }

        public override string ToString()
        {
            return PW.ToString("X2");
        }
    }
}
