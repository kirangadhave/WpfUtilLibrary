using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUtilLibrary
{
    public static class ExtensionMethods
    {
        public static bool IsAnyOf<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException(nameof(source));
            return list.Contains(source);
        }

        public static void AddRange<T, S>(this ICollection<T> list, params S[] values) where S:T
        {
            foreach (S value in values)
                list.Add(value);
        }

        public static void ForEach<T>(this IEnumerable<T> list, Action<T> mapFunction)
        {
            foreach (T t in list) mapFunction?.Invoke(t);
        }

        public static bool IsNull(this object o)
        {
            return (null == o);
        }
    }
}
