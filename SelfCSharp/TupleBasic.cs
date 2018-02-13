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
            return x >= y ? (x, y) : (y, x);
        }

        static void Main(string[] args)
        {
            var a = new TupleBasic();
            (int max, int min) t = a.GetMaxMin(15, 13);
            Console.WriteLine(t.max);
            Console.WriteLine(t.min);

            var (resultMax, resultMin) = a.GetMaxMin(3, 5);
            Console.WriteLine(resultMax);
            Console.WriteLine(resultMin);
        }
    }
}