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
            long m = 10;
            int i = (int)m;
            Console.WriteLine($"{m.ToString()} {i.ToString()}");

            string str = "15";
            int tmp = 0;
            Console.WriteLine(int.TryParse(str, out tmp));
            Console.WriteLine(tmp);
        }
    }
}
