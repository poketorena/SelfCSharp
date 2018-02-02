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
            var str = "お問い合わせはhoge@example.comまで";
            var rgx = new Regex(@"[a-z_0-9]+([-+.][a-z_0-9]+)*@[a-z_0-9]+([-.][a-z_0-9]+)*\.[a-z_0-9]+([-.][a-z_0-9]+)*", RegexOptions.IgnoreCase);
            Console.WriteLine(rgx.Replace(str, "<a href=\"mailto:$0\">$0</a>"));
        }
    }
}