using System;
using GitTrainingDemo.Model;
public abstract class Shape
{
    public string Color { get; set; }
    public abstract double CalculateArea();
    public void DisplayColor()
    {
        if (Color != null)
        {
            Console.WriteLine(Color);
        }
    }
}

public class Circle: Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle: Shape, IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
    public double Area() => Width * Height;
}