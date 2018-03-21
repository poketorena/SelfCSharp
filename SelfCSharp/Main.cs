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
using System.Net;

namespace SelfCSharp
{
    class AsyncHttp
    {
        static void Main(string[] args)
        {
            var client = new WebClient();

            // 通信終了時のj処理
            client.DownloadStringCompleted += (sender, e) =>
            {
                Console.WriteLine(e.Result);
            };

            client.DownloadStringTaskAsync("https://codezine.jp/");
            Console.ReadLine();
        }
    }
}