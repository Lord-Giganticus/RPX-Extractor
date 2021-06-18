using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPX.Extractor.Classes
{
    public static class Extensions
    {
        public static List<T> ToList<T>(this T[] array)
        {
            var l = new List<T>();
            foreach (var a in array)
                l.Add(a);
            return l;
        }
    }
}
