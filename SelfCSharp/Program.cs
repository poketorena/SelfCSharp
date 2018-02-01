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
            string str = "http://google.com";
            // 変数strが「http://」で始まる場合にメッセージを表示
            if (str != null && str.StartsWith("http://"))
            {
                Console.WriteLine("「http://～」で始まります。");
            }
        }
    }
}
