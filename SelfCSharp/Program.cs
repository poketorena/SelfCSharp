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
            var str = "住所は〒184-0000 鎌ヶ谷市梶野町0-0-0です。\nあなたの住所は〒273-0000 懦恋市大野町0-9-9ですね";
            var rgx = new Regex(@"\d{3}-\d{4}");
            var result = rgx.Matches(str);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}