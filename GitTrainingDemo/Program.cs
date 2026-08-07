using GitTrainingDemo.Services;
using System.Collections.Generic;
using System;

var userService = new UserService();
//Console.WriteLine(userService.Login("admin", "123"));

var orderService = new OrderService();
//Console.WriteLine(orderService.CalculateTotal(100000));
//Console.WriteLine(orderService.GetGreeting("Bil", "Hakki"));
//orderService.GetGreetingV("Bil", "Hakki");
//orderService.showNumber(10);
//orderService.showLoop();
//orderService.showList();
//orderService.showDictionary();

Product product = new Product("Macbook", 200000000);
//product.Name("Macbook");
//product.Price(20000000);

//Console.WriteLine(product.Name);
//Console.WriteLine(product.Price);

//BankAccount acc = new BankAccount();
//acc.Balance = -99999; // tidak ada validasi!

//public class BankAccount
//{
//    public double Balance; // siapa pun bisa ubah!
//}

//Dog d = new Dog();
//d.Name = "Doggy";
//d.Age = 3;
//Console.WriteLine(d.Name + "is " + d.Age + "old");
//d.Bark();

//Cat cat = new Cat();
//cat.Name = "Kitty";
//cat.Age = 2;
//Console.WriteLine(cat.Name + " is " + cat.Age + " old");
//cat.Scratch();
//cat.Purr();



//public class Dog : Animal
//{
//    public string Breed { get; set; }

//    public void Bark()
//    {
//        Console.WriteLine(Name + "says: Woof!");
//    }
//}

//public class Cat : Animal
//{
//    public string Breed { get; set; }

//    public void Scratch()
//    {
//        Console.WriteLine(Name + "is Scratching kssssk");
//    }
//    public void Purr()
//    {
//        Console.WriteLine(Name + "'s ZZZZZZZ");
//    }
//}

//public class Animal
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public void Breath()
//    {
//        Console.WriteLine(Name + "is breathing");
//    }
//}

//Calculator c = new Calculator();
//Console.WriteLine(c.Add(1, 2, 3, 4));
//Console.WriteLine(c.Add(2.2, 4.5, 1.9));

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
//    public int Add(int a, int b, int c, int d)
//    {
//        return a + b + c + d;
//    }
//    public double Add(double a, double b, double c)
//    {
//        return a + b + c;
//    }
//}

//Goat g = new Goat();
//g.MakeSound();

//Cow co = new Cow();
//co.MakeSound();

//List<Animal> animals = new List<Animal>
//{
//    new Goat(),
//    new Cow(),
//    new Animal()
//};

//foreach (Animal a in animals)
//{
//    a.MakeSound();
//}

//public class Goat : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Mbek !!!!");
//    }
//}
//public class Cow : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Moo !!!");
//    }
//}

//public class Animal
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Some generic sound");
//    }
//}

Triangle triangle = new Triangle();
triangle.Color = "red";
triangle.DisplayColor();
triangle.alas = 7;
triangle.tinggi = 9;
Console.WriteLine(triangle.CalculateArea());


public class Triangle : Shape
{
    public double alas { get; set; }
    public double tinggi { get; set; }

    public override double CalculateArea()
    {
        return (alas * tinggi) / 2;
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