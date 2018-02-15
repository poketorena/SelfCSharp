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
            var array = new FreeArray(5);
            array[0] = 1;
            array[1] = 10;
            array[2] = 15;
            array[3] = 30;
            array[4] = 60;

            Console.WriteLine(array[2]);
            Console.WriteLine(array[-10]);
            Console.WriteLine(array[6]);
        }
    }
}