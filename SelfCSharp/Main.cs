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
        static async Task Main(string[] args)
        {
            var client = new WebClient();
            var result = await client.DownloadStringTaskAsync("https://codezine.jp/");
            Console.WriteLine(result);
        }
    }
}