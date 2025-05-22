using System;
using System.Collections;

namespace BackupCatalog {
    static class EnumerableExtensions {
        public static void ForEach<T>(this IList list, Action<T> action) {
            foreach (object value in list) {
                action((T)value);
            }
        }
    }
}
