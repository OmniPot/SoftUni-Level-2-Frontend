namespace _2_Custom_Linq_Extension_Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LinqExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var notFoundItems =
                from item in collection.ToArray()
                where predicate(item) == false
                select item;

            return notFoundItems;
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            IEnumerable<T> newCollection = collection;
            for (int i = 0; i < count - 1; i += 1)
            {
                newCollection = newCollection.Concat(collection);
            }

            return newCollection;
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            var result =
                from item in collection
                from suffix in suffixes
                where item.EndsWith(suffix)
                select item;

            return result;
        }
    }
}
