using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SelfCSharp;

namespace SelfCSharp
{
    class TupleBasic
    {
        static void Main(string[] args)
        {
            var info1 = new { Title = "速習C#", Price = 1000 };
            var info2 = new { info1.Title, info1.Price };
            Console.WriteLine(info2.Title);
            Console.WriteLine(info2.Price);
        }
    }
}