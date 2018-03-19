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
            var data = from b in AppTables.Books
                       where b.Title.EndsWith("入門")
                       orderby b.Price descending
                       select new { Title = b.Title, Price = b.Price * 1.08 };
            foreach (var item in data)
            {
                Console.WriteLine("Title:" + item.Title + " Price:" + item.Price);
            }
        }
    }
}