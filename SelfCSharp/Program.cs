using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "プログラミング言語";
            var result = str.Substring(4, 3);
            Console.WriteLine(result);
        }
    }
}