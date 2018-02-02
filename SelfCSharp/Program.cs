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
            var str = "2018/02/15 13:17:23";
            var time = DateTime.Parse(str);
            Console.WriteLine(time.Day);
            Console.WriteLine(time.Hour);
        }
    }
}