using System;
using System.Collections.Generic;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class User
    {
        public String Userid { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String NodeCode { get; set; }
        public String NodeName { get; set; }
        public bool MP { get; set; }
        public bool SP { get; set; }
        public bool IP { get; set; }
        public bool UP { get; set; }
        public bool DP { get; set; }
        public bool Enable { get; set; }
        public DateTime CDT { get; set; }

        public override string ToString()
        {
            return this.Userid + "-" + this.Username;
        }
    }
}
