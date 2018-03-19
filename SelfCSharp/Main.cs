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
    class DelegateAnonymous
    {
        static void Main(string[] args)
        {
            var data = new List<string> { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            Console.WriteLine(data.TrueForAll(x => x.Length <= 5));
        }
    }
}