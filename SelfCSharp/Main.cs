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
    class M
    {
        delegate bool Hoge(string str);

        delegate TResult Foo<in T, out TResult>(T v1, T v2);
        static void Main(string[] args)
        {
            var data = AppTables.Books
                .Where(x => x.Title.EndsWith("入門"))
                .OrderByDescending(x => x.Price)
                .Select(x => new { Title = x.Title, Price = x.Price * 1.08 });
            foreach (var item in data)
            {
                Console.WriteLine("Title:" + item.Title + " Price:" + item.Price);
            }
        }
    }
}