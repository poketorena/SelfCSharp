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
            var result = "";
            for (int i = 0; i < 100000; i++)
            {
                result += "いろは";
            }

            Console.WriteLine(result);
        }
    }
}
