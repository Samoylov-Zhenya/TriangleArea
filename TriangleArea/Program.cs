using System;

namespace TriangleArea
{
    class Program
    {
        static void Main()
        {
            int n = 6;
            double[] elements = new double[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = Convert.ToDouble(Console.ReadLine());
            }
            Vector vectors1 = new Vector(elements[0], elements[1], elements[2]);
            Vector vectors2 = new Vector(elements[3], elements[4], elements[5]);
            Triangle triangle = new Triangle(vectors1, vectors2);

            Console.WriteLine(triangle.area);
            Console.ReadKey();
        }
    }
}
