using System;
using System.Collections.Generic;

namespace _02.Func
{
    class Func
    {
        static void Main()
        {
            var list = new List<int>{1,2,3,4,6,11,3};

            Console.WriteLine(string.Join(",", list.MyTakeWhile(x => x<10)));
        }
    }
}
