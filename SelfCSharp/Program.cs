using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = null;
            value = "こんにちは";

            Console.WriteLine(value == null ? "既定値": value);
        }
    }
}
