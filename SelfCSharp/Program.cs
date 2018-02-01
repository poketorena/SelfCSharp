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
            int score = 75;
            if (score >= 90)
            {
                Console.WriteLine("優");
            }
            else if (score >= 70)
            {
                Console.WriteLine("良");
            }
            else if (score >= 50)
            {
                Console.WriteLine("可");
            }
            else
            {
                Console.WriteLine("不可");
            }
        }
    }
}