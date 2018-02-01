using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var i = 0;
            while (i <= 100)
            {
                if (i % 2 != 0)
                {
                    i++;
                    continue;
                }
                sum += i;
                i++;
            }
            Console.WriteLine($"合計値は{sum}です。");
        }
    }
}