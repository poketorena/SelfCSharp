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
            object obj = -123;
            switch (obj)
            {
                // 変数objがint型の場合、絶対値を求める
                case int i:
                    Console.WriteLine(Math.Abs(i));
                    break;
                case string str:
                    Console.WriteLine(str[0]);
                    break;
                default:
                    Console.WriteLine("意図しない型です");
                    break;
            }
        }
    }
}