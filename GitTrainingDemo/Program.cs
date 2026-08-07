using System;
using System.Collections.Generic;
using GitTrainingDemo.Services;

var userService = new UserService();
//Console.WriteLine(userService.Login("admin", "123"));

var orderService = new OrderService();
//Console.WriteLine(orderService.CalculateTotal(100000));

//LATIHAN


//userService.ForLoopLoncat1(10);
//userService.ForEachLoopNama(new List<string> { 
//    "Adi", "Budi", "Citra", "Dodi", "Fahrul" 
//});
//Console.WriteLine(userService.GetGreeting("Adi", "Asep"));
//userService.SendGreeting("Adi", "Asep");
//userService.ListLatihan();
//userService.LatihanDictionary();

//Constructor

//Product p1 = new Product("Pisau", 10000, "Stabby");
//Product p2 = new Product("Pedang", 13000, "Long Stabby");

//Console.WriteLine("Barang " + p1.Name + " Harganya : " + p1.Price);
//Console.WriteLine("Deskripsi " + p1.Name + " : " + p1.Description);
//Console.WriteLine("Barang " + p2.Name + " Harganya : " + p2.Price);
//Console.WriteLine("Deskripsi " + p2.Name + " : " + p2.Description);

//Encapsulation

//BankAccount bankAccount = new BankAccount();
//bankAccount.Balance = -9000;
//Console.WriteLine("Balance : " + bankAccount.Balance);
//bankAccount.Balance = 109000;
//Console.WriteLine("Balance : " + bankAccount.Balance);


//Inheritance

//Cat cat = new Cat();
//cat.Name = "Asep";
//cat.Age = 5;
//cat.Purr();
//cat.Scratch();
//Console.WriteLine("The cat name is " + cat.Name + " and its " + cat.Age + " years old");

//public class Cat: Animal
//{
//    public string breed = string.Empty;

//    public void Purr() {
//        Console.WriteLine(Name + " is purring");
//    }

//    public void Scratch()
//    {
//        Console.WriteLine(Name + " is scratching");
//    }
//}

//public class Animal
//{
//    public string Name { get; set; } = string.Empty;
//    public int Age { get; set; } = 0;

//    public void Breathe()
//    {
//        Console.WriteLine(Name + " is breathing");
//    }
//}


//Polymorphism

//Calculator calc = new Calculator();
//Console.WriteLine("2 Param Integer (1,2) : " + calc.Add(1, 2)); // int version
//Console.WriteLine("2 Param Double (1.5,2.5) : " + calc.Add(1.5, 2.5)); // double version
//Console.WriteLine("3 Param Integer (1,2,3) : " + calc.Add(1, 2, 3)); // 3 param int version
//Console.WriteLine("3 Param Integer (1.5,2.5,3.5) : " + calc.Add(1.5, 2.5, 3.5)); //3 param double version
//Console.WriteLine("4 Param Integer (1,2,3,5) : " + calc.Add(1, 2, 3, 5)); //4 param int version

//public class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }
//    public double Add(double a, double b)
//    {
//        return a + b;
//    }
//    public int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public double Add(double a, double b, double c)
//    {
//        return a + b + c;
//    }
//    public int Add(int a, int b, int c, int d)
//    {
//        return a + b + c + d;
//    }
//}

//List<Animal> animals = new List<Animal>
//{
//    new Cow(),
//    new Sheep()
//};

//foreach(Animal animal in animals)
//{
//    animal.MakeSound();
//}


//public class Cow : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Moo! Moo!");
//    }
//}
//public class Sheep : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Baa! Baa!");
//    }
//}
//public class Animal
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Some generic sound");
//    }
//}


// Abstraction

Circle circle = new Circle();
circle.Radius = 2 * Math.PI;
Console.WriteLine("Circle Area : " + circle.CalculateArea());

Rectangle rectangle = new Rectangle();
rectangle.Width = 1;
rectangle.Height = 2;
Console.WriteLine("Rectangle Area : " + rectangle.CalculateArea());

Triangle triangle = new Triangle();
triangle.Color = "Blueberry";
triangle.Base = 1;
triangle.Height = 5;
Console.WriteLine("Triangle Area : " + triangle.CalculateArea());
triangle.DisplayColor();

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
    public double Base {  get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return (Base/2) * Height;
    }
}

public abstract class Shape
{
    public string Color { get; set; } = string.Empty;
    // Method abstrak — WAJIB diimplementasikan child
    public abstract double CalculateArea();
    // Method konkret — bisa langsung digunakan
    public void DisplayColor()
    {
        Console.WriteLine("Color: " + Color);
    }
}


