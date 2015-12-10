using System;
using System.Collections.Generic;

namespace _03.Action
{
    class Action
    {
        static void Main()
        {
            var list = new List<int>{1,2,3,4,6,11,3};

            list.MyForEach(Console.WriteLine);
        }
    }
}
