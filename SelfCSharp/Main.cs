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
                .Where(x => x.Published < new DateTime(2016, 12, 1))
                .OrderBy(x => x.Publisher)
                .ThenBy(x => x.Title)
                .Select(x => new { Title = x.Title.Substring(0, 5), Price = x.Price, Publisher = x.Publisher });

            foreach (var item in data)
            {
                Console.WriteLine(item.Title + ":" + item.Price + ":" + item.Publisher);
            }
        }
    }
}