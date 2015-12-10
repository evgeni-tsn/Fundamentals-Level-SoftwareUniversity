using System;
using System.Collections.Generic;

namespace _03.Action
{
    public static class Extension
    {
        public static void MyForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var element in collection)
            {
                action(element);
            }
        }
    }
}