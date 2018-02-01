#define DEBUG
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

#if DEBUG
            Console.WriteLine("デバッグ時にだけ表示します");
#endif
        }
    }
}