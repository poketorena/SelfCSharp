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
            var language = "C#";
            if (language == "C#" || language == "Visulal Basic" || language == "F#")
            {
                Console.WriteLine(".Net対応言語");
            }
            else if (language == "Python" || language == "Ruby")
            {
                Console.WriteLine("スクリプト言語");
            }
            else
            {
                Console.WriteLine("不明");
            }
        }
    }
}