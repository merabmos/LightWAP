using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Extensions
{
    public static class IsNotNullExstension
    {
        public static bool IsNotNull(this object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
