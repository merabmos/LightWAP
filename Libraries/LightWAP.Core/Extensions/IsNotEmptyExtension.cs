using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightWAP.Core.Extensions
{
    public static class IsNotEmptyExtension
    {
        public static bool IsNotEmpty<T>(this IEnumerable<T> objs)
        {
            if (objs.Count() == 0) return false;
            else return true;
        }
        public static bool IsNotEmpty(this string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) return false;
            else return true;
        }
    }
}
