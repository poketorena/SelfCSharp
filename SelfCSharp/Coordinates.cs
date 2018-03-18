using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    struct Coordinates
    {
        public double Latitude;
        public double Longitude;

        public override string ToString()
        {
            return $"緯度：{this.Latitude}/経度：{this.Longitude}";
        }

        public Coordinates(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}
