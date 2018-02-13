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
    class PassRefBasic
    {
        public int CountUp(ref int data)
        {
            data++;
            return data;
        }

        static void Main(string[] args)
        {
            var data = 1;
            var p = new PassRefBasic();
            Console.WriteLine(p.CountUp(ref data));
            Console.WriteLine(data);
        }
    }
}