
using System;

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
        private readonly double phi = 22 / 7;
        public double Area()
        {
            return phi * rad * rad;
        }
    }

    class FixedSquare(int s):IShape
    {
        private int s = s;

        public double Area()
        {
            return Math.Pow(s,2);
        }
    }

    class FixedRectangle(int w,int h) : IShape
    {
        private int w = w;
        private int h = h;

        public double Area()
        {
            return w*h;
        }
    }

    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int Area() => Width * Height;
    }
    class Square : Rectangle
    {
        // Melanggar kontrak Rectangle!
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

    }
}