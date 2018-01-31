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
            //value = "こんにちは";

            if (value == null)
            {
                Console.WriteLine("既定値");
            }
            else
            {
                Console.WriteLine(value);
            }
        }
    }
}
