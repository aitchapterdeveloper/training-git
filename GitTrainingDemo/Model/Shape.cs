using System;
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

public class Rectangle: Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}