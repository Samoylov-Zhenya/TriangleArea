using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Vector
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Vector(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public Vector()
        {
        }
    }
}
