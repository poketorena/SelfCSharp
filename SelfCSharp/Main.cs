using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SelfCSharp;
using static System.Math;

namespace SelfCSharp
{
    class M
    {
        static void Main(string[] args)
        {
            try
            {
                throw new IOException();
            }
            catch (Exception e) when (
            e is IOException ||
            e is ArgumentException)
            {
                throw;
            }
        }
    }
}