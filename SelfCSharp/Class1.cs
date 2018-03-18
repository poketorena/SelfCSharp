using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    public static class Class1
    {
        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine(string.Join(",",list.ToArray()));
        }
    }
}
