using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    static class MyClass
    {
        public static double GetBmi(double weight, double height)
        {
            return weight / Math.Pow(height, 2);
        }
    }
}
