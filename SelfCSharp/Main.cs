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
    class DelegateAnonymous
    {
        // string型の引数を受け取り、戻り値はvoidであるデリゲート
        delegate string OutputProcess(string str);

        // 配列要素の処理方法をデリゲート経由で受け取れるように
        void ArrayWalk(string[] data, Func<string,string> output)
        {
            foreach (var value in data)
            {
                Console.WriteLine(output(value));
            }
        }

        // OutputProcess型に対応したメソッド
        static string AddQuote(string data)
        {
            return $"[{data}]";
        }

        static string Front4(string data)
        {
            return data.Substring(0, 4);
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dm = new DelegateAnonymous();

            // デリゲート型の引数に匿名メソッドを渡す
            dm.ArrayWalk(data, delegate (string d)
             {
                 return $"[{d}]";
             });
        }
    }
}