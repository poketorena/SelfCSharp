using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SelfCSharp;
using System.Threading;

namespace SelfCSharp
{
    class AsyncBasic
    {
        static void Main(string[] args)
        {
            // 非同期メソッドを呼び出す
            Task t = RunAsync();
            Console.WriteLine("...他の処理...");
            t.Wait();
        }

        // 非同期メソッドを定義
        static async Task RunAsync()
        {
            await Task.Run(() => Count(1));
            Console.WriteLine("処理が完了しました。");
        }

        static void Count(int n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Task{n}:{i}");
            }
        }
    }
}