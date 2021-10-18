using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Triangle
    {
        Vector vector1 { get; set; }
        Vector vector2 { get; set; }
        Vector vector12 = new Vector();
        double module { get; set; }

        public double area { get; set; }

        public Triangle(Vector _vector1, Vector _vector2)
        {
            vector1 = _vector1;
            vector2 = _vector2;
            VectorProductOfVectors();
            Module();
            Area();
        }
        void VectorProductOfVectors()
        {
            vector12.x = vector1.y * vector2.z - vector1.z * vector2.y;
            vector12.y = vector1.x * vector2.z - vector1.z * vector2.x;
            vector12.z = vector1.x * vector2.y - vector1.y * vector2.x;
        }
        void Module()
        {
            module = Math.Sqrt(
                vector12.x * vector12.x +
                vector12.y * vector12.y +
                vector12.z * vector12.z
                );
        }
        void Area()
        {
            area = module / 2;
        }
    }
}
