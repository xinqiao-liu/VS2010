using System;
using System.Collections.Generic;
using System.Text;

namespace KM.WLData.Model
{
    [Serializable]
    public sealed class Setting
    {
        public string Id { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return this.Id + "=" + this.Value;
        }
    }
}
