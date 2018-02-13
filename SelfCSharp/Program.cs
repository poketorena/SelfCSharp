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
            var s = SelfCSharp.MySingleton.Instance;
        }
    }
}