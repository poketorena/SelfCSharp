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
    class DelegateUse
    {
        // string型の引数を受け取り、戻り値はvoidであるデリゲート
        delegate void OutputProcess(string str);

        // 配列要素の処理方法をデリゲート経由で受け取れるように
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        // OutputProcess型に対応したメソッド
        static void AddQuote(string data)
        {
            Console.WriteLine($"[{data}]");
        }
        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegateUse();
            OutputProcess proc = AddQuote;
            du.ArrayWalk(data, proc);
        }
    }
}