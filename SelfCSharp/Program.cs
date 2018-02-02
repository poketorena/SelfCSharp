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
            var str = "となりのきゃくはよくかきくうきゃくだ";
            Console.WriteLine(str.LastIndexOf("きゃく"));
        }
    }
}