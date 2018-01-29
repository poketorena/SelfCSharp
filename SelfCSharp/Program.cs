using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[,] {
                { 1,2,3},
                { 4,5,6}
            };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(arr[1,1]);
        }
    }
}
