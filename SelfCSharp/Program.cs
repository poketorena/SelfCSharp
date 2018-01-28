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
            var num = 0x1a;
            Console.WriteLine(num);
            var num2 = 0b111_000_111;
            Console.WriteLine(num2);
            var str = @"おはよう
            こんにちは
                      こんばんは";
            Console.WriteLine(str);
            var num3 = 3.14e10;
            Console.WriteLine(num3);
            Console.WriteLine('\u3042');
        }
    }
}
