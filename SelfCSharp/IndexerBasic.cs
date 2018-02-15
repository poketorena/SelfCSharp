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
    class IndexerBasic
    {
        public static (double addition, double subtract) AddSubtract(double x, double y) => (x + y, x - y);
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(IndexerBasic));
        }
    }
}