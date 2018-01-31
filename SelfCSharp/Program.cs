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
            var builder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                builder.Append("いろは");
            }

            var result = builder.ToString();
            Console.WriteLine(result);
        }
    }
}
