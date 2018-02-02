using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp1 = "ボクの名前は太郎です";
            tmp1 = tmp1.Replace("ボク", "私");
            Console.WriteLine(tmp1);
        }
    }
}