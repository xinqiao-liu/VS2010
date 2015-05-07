using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public sealed class Table
    {
        public string Key { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Key;
        }
    }
}
