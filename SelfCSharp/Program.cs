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
            var multi = new[,]
            {
                {10, 11, 12 },
                {20, 21, 22 }
            };
            Console.WriteLine(multi.Length);
            Console.WriteLine(multi.Rank);
            Console.WriteLine();

            int[][] data = new int[3][];
            data[0] = new[] { 10, 11, 12, 13, 14 };
            data[1] = new[] { 20, 21, 22 };
            data[2] = new[] { 30, 31, 32, 33 };
            Console.WriteLine(data.Length);
            Console.WriteLine(data.Rank);
        }
    }
}
