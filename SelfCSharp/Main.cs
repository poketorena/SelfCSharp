using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SelfCSharp;
using System.Threading;
using System.Diagnostics;

namespace SelfCSharp
{
    class AsyncRegturn
    {
        static void Main(string[] args)
        {
            // 非同期メソッドの呼び出し
            Task<TimeSpan> t = RunAsync();
            // 非同期メソッドの終了待ち
            while (!t.IsCompleted)
            {
                t.Wait(200);
                Console.Write(".");
            }
            Console.WriteLine(t.Result);
        }

        // 戻り値のある非同期メソッド
        static async Task<TimeSpan> RunAsync()
        {
            var watch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
            });
            watch.Stop();
            return watch.Elapsed;
        }
    }
}