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
    class Program
    {
        static void Main(string[] args)
        {
            var avg = Average.GetAverage(1, 2, 3, 4, 5);
            Console.WriteLine(avg);
        }
    }
}