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
    class PassRefReturn
    {
        public ref int ReturnRef(int[] data)
        {
            return ref data[0];
        }

        static void Main(string[] args)
        {
            var data = new[] { 1, 2, 3 };
            var p = new PassRefReturn();
            ref int num = ref p.ReturnRef(data);
            num = 10;
            Console.WriteLine(num);
            Console.WriteLine(data[0]);
        }
    }
}