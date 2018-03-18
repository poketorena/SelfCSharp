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
    class M
    {
        static void Main(string[] args)
        {
            int i = -25;
            Console.WriteLine(i >= 0 ? Math.Sqrt(i) : throw new Exception("iは整数でなければいけません！"));
        }
    }
}