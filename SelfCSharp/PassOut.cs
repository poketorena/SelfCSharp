using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SelfCSharp;

namespace SelfCSharp
{
    class PassOut
    {
        public void GetMaxMin(int x, int y, out int max, out int min)
        {
            if (x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
        }

        static void Main(string[] args)
        {
            var a = new PassOut();
            int resultMax, resultMin;
            a.GetMaxMin(5, 3, out resultMax, out resultMin);
            Console.WriteLine(resultMax);
            Console.WriteLine(resultMin);
        }
    }
}