using System;
using System.Collections.Generic;
using System.Text;

namespace WLDataModelLayer
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
