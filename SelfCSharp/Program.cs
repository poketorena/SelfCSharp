using System;
using System.Collections.Generic;
using System.IO;
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
            var list = new List<int>()
            {
                15,23,29,37
            };

            var d = new Dictionary<string, string>()
            {
                ["cat"] = "猫",
                ["dog"] = "犬"
            };

            var enu1 = list.GetEnumerator();
            while (enu1.MoveNext())
            {
                int num = enu1.Current;
                Console.WriteLine(num);
            }

            var enu2 = d.GetEnumerator();
            while (enu2.MoveNext())
            {
                var pair = enu2.Current;
                Console.WriteLine(pair);
            }
        }
    }
}