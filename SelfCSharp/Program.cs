using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = string.Join(",", args);
            using (var writer = new StreamWriter(@"C:\data\sample.dat", append: true))
            {
                writer.WriteLine(result);
            }
        }
    }
}