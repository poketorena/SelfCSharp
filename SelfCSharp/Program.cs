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
            var radius = 3.0;
            var c1 = new Circle();
            var c2 = new Circle(radius);
            Console.WriteLine(c1.GetArea());
            Console.WriteLine(c2.GetArea());
        }
    }
}