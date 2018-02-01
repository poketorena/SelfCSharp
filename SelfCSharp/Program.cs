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
            var oddsum = 0;
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                oddsum += i;
            }
            Console.WriteLine(oddsum);
        }
    }
}