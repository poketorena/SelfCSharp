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
            int[] data;
            data = new[] { 1, 2, 3, 4, 5 };
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
