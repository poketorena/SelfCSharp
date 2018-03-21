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
    class LockBasicBad
    {
        public int Count { get; private set; } = 0;
        static void Main(string[] args)
        {
            const int TaskNum = 500000; // タスクの個数

            var ts = new Task[TaskNum];

            var tb = new LockBasicBad();

            // タスクを起動
            for (int i = 0; i < TaskNum; i++)
            {
                ts[i] = Task.Run(() => tb.Increment());
            }

            // 各タスクの終了まで待機
            for (int i = 0; i < TaskNum; i++)
            {
                ts[i].Wait();
            }

            Console.WriteLine(tb.Count);
        }

        void Increment()
        {
            this.Count++;
        }
    }
}