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
            string str = " Hello World! ";
            Console.WriteLine(str);
            var nospace = str.Trim();
            Console.WriteLine(nospace);
        }
    }
}
