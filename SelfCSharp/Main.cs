using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SelfCSharp.Chap08.ExtensionBasic;
using SelfCSharp;

namespace SelfCSharp
{
    class M
    {
        static void Main(string[] args)
        {
            Coordinates c;
            c.Latitude = 35.681167;
            c.Longitude = 139.767052;
            Console.WriteLine(c);
        }
    }
}