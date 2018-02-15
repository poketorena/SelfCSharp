using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SelfCSharp.Chap08.ExtensionBasic;

namespace SelfCSharp
{
    class Extension
    {
        static void Main(string[] args)
        {
            string s = "(ΦωΦ)";
            Console.WriteLine(s.Repeat(3));
        }
    }
}