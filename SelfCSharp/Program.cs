using System;
using System.Collections.Generic;
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
            var tmp1 = "東京";
            var tmp2 = 15.156;
            Console.WriteLine("{0}の気温は{1:f1}℃です。",tmp1,tmp2);
        }
    }
}