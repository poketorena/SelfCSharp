using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SelfCSharp;
using System.Threading;
using System.Diagnostics;
using System.Net;
using IronPython.Hosting;

namespace SelfCSharp
{
    class IronPython
    {
        static void Main(string[] args)
        {
            var py = Python.CreateRuntime();
            dynamic script = py.UseFile("myClass.py");
            dynamic clazz = script.MyClass();
            Console.WriteLine(clazz.greet("山田"));
        }
    }
}