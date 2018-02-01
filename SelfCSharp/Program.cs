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
            string str = "hogehoge.zip";
            // 変数strが「http://」で始まる場合にメッセージを表示
            if (str != null && str.EndsWith(".zip"))
            {
                Console.WriteLine("「.zip」で終わります。");
            }
        }
    }
}
