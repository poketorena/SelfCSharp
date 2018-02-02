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
            var time1 = DateTime.Parse("2018/02/13");
            var time2 = DateTime.Parse("2020/08/04");
            Console.WriteLine((time2.Subtract(time1)).ToString("%d"));
        }
    }
}