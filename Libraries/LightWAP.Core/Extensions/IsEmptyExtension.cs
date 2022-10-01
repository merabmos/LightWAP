using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightWAP.Core.Extensions
{
    public static class IsEmptyExtension
    {
        public static bool IsEmpty<T>(this IEnumerable<T> objs)
        {
            if (objs.Count() == 0) return true;
            else return false;
        }
        public static bool IsEmpty(this string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) return true;
            else return false;
        }
    }
}
