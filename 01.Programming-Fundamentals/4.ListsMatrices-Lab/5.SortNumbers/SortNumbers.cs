using System.Linq;
using static System.Console;

namespace _5.SortNumbers
{
    /* 
     * Read a list of decimal numbers and sort them.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/173#4
     */
    class SortNumbers
    {
        static void Main() => WriteLine(string.Join(" <= ", ReadLine()
                                                    .Split()
                                                    .Select(decimal.Parse)
                                                    .ToList()
                                                    .OrderBy(e => e)));
    }
}
