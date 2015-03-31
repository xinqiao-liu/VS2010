using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    [Serializable]
    public sealed class AboutInfo
    {
        public String SoftwareName { get; set; }
        public String SoftwareVersion { get; set; }
        public String TechnicalSupport { get; set; }
    }
}
