using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rank = "甲";

            switch (rank)
            {
                case "甲":
                    Console.WriteLine("大変良いです。");
                    //break;
                case "乙":
                    Console.WriteLine("良いです");
                    break;
                case "丙":
                    Console.WriteLine("がんばりましょう");
                    break;
                default:
                    Console.WriteLine("？？？");
                    break;
            }
        }
    }
}