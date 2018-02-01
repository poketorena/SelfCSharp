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
            var i = 1;
            var sum = 0;
            while (i <= 100)
            {
                sum += i;
                if (sum > 1000)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine($"合計が1000を超えるのは、１～{i}を加算したときです。");
        }
    }
}