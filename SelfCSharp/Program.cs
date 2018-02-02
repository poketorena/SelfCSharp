using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Math.Pow(5, 3);
            var result2 = Math.Abs(-12);
            var arr = new[] { 105, 18, 25, 30 };
            Array.Sort(arr);
            Console.WriteLine($"{result1}, {result2}");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}