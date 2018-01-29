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
            var num = 10d;
            var name = "poketorena";
            Console.WriteLine($"ようこそ{name}さん！");
            int? i = null;
            var multi = new int[5, 4];
            var JyagArr = new int[3][]
            {
                new int[]{2, 3, 5 },
                new int[]{1, 2 },
                new int[]{10, 11, 12, 13 }
            };
        }
    }
}
