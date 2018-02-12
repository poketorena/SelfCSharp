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
            // コレクション初期化子
            var flower = new Dictionary<string, string>()
            {
                {"Rose", "バラ"},
                {"Sunflower", "ひまわり"},
                {"Mornig Glory", "あさがお"}
            };

            // インデックス初期化子
            var flower2 = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Mornig Glory"] = "あさがお"
            };

            foreach (var item in flower)
            {
                Console.WriteLine(item);
            }
            foreach (var item in flower2)
            {
                Console.WriteLine(item);
            }
        }
    }
}