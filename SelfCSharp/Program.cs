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
            switch (language)
            {
                case "C#":
                case "Visulal Basic":
                case "F#":
                    Console.WriteLine(".Net対応言語");
                    break;
                case "Python":
                case "Ruby":
                    Console.WriteLine("スクリプト言語");
                    break;
                default:
                    Console.WriteLine("不明");
                    break;
            }
        }
    }
}