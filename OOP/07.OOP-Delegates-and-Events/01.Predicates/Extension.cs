using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Predicates
{
    public static class Extension
    {
        public static T MyFirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            foreach (var element in collection.Where(element => condition(element)))
            {
                return element;
            }

            return default(T);
        }
    }
}