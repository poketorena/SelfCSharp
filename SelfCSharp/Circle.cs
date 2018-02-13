using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Circle
    {
        double radius;

        public Circle(double radius = 1)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
