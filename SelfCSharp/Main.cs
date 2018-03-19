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
        delegate bool Hoge(string str);

        delegate TResult Foo<in T, out TResult>(T v1, T v2);
        static void Main(string[] args)
        {
            var data = new List<string> { "ABCDE", "OPQR", "WXYZ", "HIJKL" };
            var list = data.Select(x => x.Substring(0, 3));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}