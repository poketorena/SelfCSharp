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
    class M
    {
        delegate TResult Foo<in T, out TResult>(T v1, T v2);
        static void Main(string[] args)
        {
            // スレッドを生成
            var t1 = new Thread(Count);
            var t2 = new Thread(Count);
            var t3 = new Thread(Count);

            // スレッドを開始
            t1.Start(1);
            t2.Start(2);
            t3.Start(3);

            // スレッド終了まで待機
            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("すべての処理が完了しました。");
        }

        static void Count(object n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Thread{n}: {i}");
            }
        }
    }
}