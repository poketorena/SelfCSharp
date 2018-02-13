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
            var info = new { Title = "速習C#", Price = 1000 };
            Console.WriteLine(info.Title);
            Console.WriteLine(info.Price);
        }
    }
}