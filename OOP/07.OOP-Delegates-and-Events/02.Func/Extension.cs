using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Func
{
    public static class Extension
    {
        public static IEnumerable<T> MyTakeWhile<T>(
        this IEnumerable<T> collection,Func<T, bool> predicate)
        {
            return Enumerable.TakeWhile(collection, element => predicate(element)).ToList();
        }
    }
}