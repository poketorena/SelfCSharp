using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    static class Average
    {
        public static double GetAverage(params double[] values)
        {
            double sum = 0;
            foreach (var item in values)
            {
                sum += item;
            }
            return sum / values.Length;
        }
    }
}
