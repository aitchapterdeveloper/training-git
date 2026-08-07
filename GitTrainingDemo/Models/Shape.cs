using System;

namespace GitTrainingDemo.Models
{
    public abstract class Shape
    {
        public string Color { get; set; }
        // Method abstrak — WAJIB diimplementasikan child
        public abstract double CalculateArea();
        // Method konkret — bisa langsung digunakan
        public void DisplayColor()
        {
            Console.WriteLine("Color: " + Color);
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }
}

