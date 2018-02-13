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
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (max: x, min: y) : (max: y, min: x);
        }

        static void Main(string[] args)
        {
            var t = (13, 108);
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);
        }
    }
}