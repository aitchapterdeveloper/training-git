using System.Reflection.Metadata;

namespace GitTrainingDemo.Services
{
    interface IShape
    {
        double Area();
    }

    class Trapezoid(int a, int b, int h) : IShape
    {
        int a = a;
        int b = b;
        int h = h;

        public double Area()
        {
            return h * (a + b) / 2;
        }
    }

    class Circle(int rad) : IShape
    {
        int rad = rad;
        private readonly double phi = 22/7;
        public double Area()
        {
            return phi*rad*rad;
        }
    }
}