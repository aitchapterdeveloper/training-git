using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        //public decimal CalculateTotal(decimal price)
        //{ 
        //    decimal afterdiscount = price * 0.9m; // diskon 10%
        //    return afterdiscount * 1.11m; //ppn 11%
        //}

        public string GetGreeting(string name, string city)
        {
            return "Hello, " + name + " from " + city + "!";
        }

        public void GetGreetingReturn(string name, string city)
        {
            Console.WriteLine("Hello, " + name + " from " + city + "!");
            //return "Hello"; // Ga bakal return karena void
        }

        public void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void ForEachLoop()
        {
            List<string> nama = new List<string>
            {
                "Vincent",
                "Budi",
                "Joko",
                "Siti"
            };

            foreach (string name in nama)
            {
                Console.WriteLine(name);
            }
        }

        public void SubjectList()
        {
            List<string> subject = new List<string>();
            subject.Add("Math");
            subject.Add("English");
            subject.Add("Science");
            subject.Add("History");
            subject.Add("Art");
            subject.Add("Music");

            //subject.Remove("Math");

            Console.WriteLine("List of subjects: ");
            Console.WriteLine(subject[0]);
            Console.WriteLine(subject.Count);
            Console.WriteLine(subject.Contains("Art"));
        }

        public void DictionaryTransportasi(string key)
        {
            Dictionary<string, string> transportasi = new Dictionary<string, string>();
            transportasi.Add("MTR001", "Motor");
            transportasi.Add("MBL001", "Mobil");
            transportasi.Add("BCK001", "Becak");
            transportasi.Add("SPD001", "Sepeda");
            transportasi.Add("TRK001", "Truk");
            transportasi.Add("BIS001", "Bus");

            Console.WriteLine(transportasi["MBL001"]);
            if (transportasi.ContainsKey(key))
            {
                Console.WriteLine("Key: " + key);
            }
            else
            {
                Console.WriteLine("nuh");
            }

        }

    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        //Constructor
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    public class DetailOrder : OrderService
    {
        
    }
    
    public class Animal()
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("is making a sound");
        }

        public void Breathe()
        {
            Console.WriteLine(Name + " is breathing");
        }
    }

    public class Cat : Animal
    {
        public string? Breed { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " the Cat is meowing");
        }

        public void Purr()
        {
            Console.WriteLine(Name + " is purring");
        }

        public void Scratch()
        {
            Console.WriteLine(Name + " is scratching");
        }
    }

    public class Goat : Animal
    {
        public string? Breed { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " the Goat is bleating");
        }
        public void Bleat()
        {
            Console.WriteLine(Name + " is bleating");
        }
        public void Graze()
        {
            Console.WriteLine(Name + " is grazing");
        }
    }

    public class Cow : Animal
    {
        public string? Breed { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " the cow is mooing");
        }
        public void Moo()
        {
            Console.WriteLine(Name + " is mooing");
        }
        public void Graze()
        {
            Console.WriteLine(Name + " is grazing");
        }
    }

    public class MakeAnimalSound()
    {
        public void MakeSound()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat { Name = "Evee", Age = 6, Breed = "Persia" });
            animals.Add(new Goat { Name = "Billy", Age = 3, Breed = "Boer" });
            animals.Add(new Cow { Name = "Bessie", Age = 5, Breed = "Holstein" });

            foreach (Animal a in animals)
            {
                a.MakeSound();
                
            }
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }

    public abstract class Shape
    {
        public string? Color { get; set; }
        // Method abstrak — WAJIB diimplementasikan child
        public abstract double CalculateArea();
        // Method konkret — bisa langsung digunakan
        public void DisplayColor()
        {
            Console.WriteLine("Color: " + Color);
        }
    }

    public class Triangle : Shape
    {
        public double baseLength { get; set; }
        public double height { get; set; }

        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
    }



}


