using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Predicates
{
    class Predicates
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 6, 11, 3 };

            Console.WriteLine(list.MyFirstOrDefault(x => x > 7));
            Console.WriteLine(list.MyFirstOrDefault(x => x < 0));
            
        }
    }
}
