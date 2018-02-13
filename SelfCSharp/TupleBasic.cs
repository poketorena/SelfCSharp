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
            var a = new TupleBasic();
            var (_, min)  = a.GetMaxMin(15, 13);
            Console.WriteLine();
            Console.WriteLine(min);

            var (resultMax, resultMin) = a.GetMaxMin(3, 5);
            Console.WriteLine(resultMax);
            Console.WriteLine(resultMin);
        }
    }
}