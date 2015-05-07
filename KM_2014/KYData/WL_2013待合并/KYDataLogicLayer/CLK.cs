using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KYDataLogicLayer
{
    public static class CLK
    {
        public static bool Exist(String cph)
        {
            return KYDataAccessLayer.CLK.Exist(Runtime.B_CreateCommand(), cph);
        }
    }
}
