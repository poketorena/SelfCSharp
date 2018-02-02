using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "鈴木\t太郎\t男\t50歳\t広島県";
            var result = str.Split('\t');
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}