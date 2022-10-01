using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Extensions
{
    public static class IsNullExstension
    {
        public static bool IsNull(this object obj)
        {
            if (obj == null)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
