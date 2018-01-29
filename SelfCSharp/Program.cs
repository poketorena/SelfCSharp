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
            int? num = null;
            if (num.HasValue)
            {
                Console.WriteLine($"numは{num.Value.ToString()}だよ");
            }
            else
            {
                Console.WriteLine("numはnullだよ");
            }
        }
    }
}
