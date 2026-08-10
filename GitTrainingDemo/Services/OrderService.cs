using System;
using System.Collections.Generic;
using System.Linq;
using GitTrainingDemo.Interfaces;

namespace GitTrainingDemo.Services
{
    class OrderService
    {
        private string name { get; set; } = "";
        private string gender { get; set; } = "Unknown";
        public readonly INotification _notif;

        public OrderService(INotification notif)
        {
            _notif =notif;
        }
        
        private Dictionary<string, string> vehicles = new Dictionary<string, string>
        {
          {"C","Car"},
          {"B","Bike"},
          {"T","Truck"},
          {"EB","Electric Bike"},
          {"EC","Electric Car"},
        };

        List<string> names = [
            "John",
            "Jane",
            "Jude",
            "Jackson",
            "Joe"
        ];

        List<string> listName = new List<string>()
        {
            "John",
            "Jane",
            "Jude",
            "Jackson",
            "Joe"
        };

        public string GetGreetings(string name, string act)
        {
            string title = gender == "F" ? "Mr" : "Ms";
            return $"Hello, {title}. {(name == "" ? this.name : name)} \nPlease {act}";
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void Greeting()
        {
            if (name == "")
            {
                Console.WriteLine("Name is Unset");
            }
            else
            {
                Console.WriteLine(GetGreetings(name, "stand up"));
            }
        }

        public decimal CalculateTotal(decimal price)
        {
            decimal discount = 0.15m;
            return price * (1 - discount);
        }
        public void HitungLoop()
        {
            Console.WriteLine(names.GetType());
            Console.WriteLine(listName.GetType());
            foreach (string name in listName)
            {
                Console.WriteLine(name);
            }
        }

        public void ShowSubject()
        {
            List<string> subjects = [];
            subjects.Add("Database");
            subjects.Add("OOP");
            subjects.Add("UI/UX");
            subjects.Add("Project Management");
            subjects.Add("Programming 1");
            subjects.Add("Programming 2");

            Console.WriteLine("Before removing");
            Console.WriteLine(subjects.Count);
            Console.WriteLine(subjects.Contains("Programming 2"));
            subjects.ForEach(s =>
                {
                    Console.WriteLine(s);
                }
            );
            Console.WriteLine("After removing a few subjects");
            subjects.Remove("Programming 2");
            Console.WriteLine(subjects.Count);
            Console.WriteLine(subjects.Contains("Programming 2"));
            subjects.ForEach(s =>
                {
                    Console.WriteLine(s);
                }
            );
        }

        public void FindVehicleByCode(string key)
        {
            HashSet<String> x = new HashSet<string>();
            bool isKeyValid = vehicles.ContainsKey(key);
            Console.WriteLine($"Is Key valid : {isKeyValid}");
            if (isKeyValid)
            {
                Console.WriteLine(vehicles[key]);
            }
            else
            {
                Console.WriteLine("Vehicle not found");
            }

        }

    }
    public class SapaService
    {
        public string SapaNama(string name)
        {
            return "selamat datang" + name;
        }
        public string GetGreetings(string firstName = "", string lastName = "")
        {
            return $"Hallo, {firstName} {lastName}";
        }
    }

    public class Product
    {
        public string name { get; set; }
        private decimal _price;
        public decimal price
        {
            get { return _price; }
            set
            {
                if (value > 0) _price = value;
            }
        }

        public string readOnlyVariable { get; } = "";
        protected string protectedVariable = "";

        public Product(string n, decimal p)
        {
            name = n;
            price = p;
        }

        public void ShowPrice()
        {
            Console.WriteLine($"{name}'s price is {price}");
        }
    }

    public class BankAccount
    {
        public string name { set; get; }
        private int _balance;
        public int balance
        {
            get { return _balance; }
            set
            {
                if (value > 0) _balance = value;
            }
        }

        public BankAccount(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }
    }

    public class Animal
    {
        public string name;
        public int age;

        public Animal(string n, int a)
        {
            name = n;
            age = a;
        }

        public void Eating()
        {
            Console.WriteLine($"{name} is eating something");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("ZZZZZZZZ");
        }
    }

    public class Cat : Animal
    {
        public Cat(string a, int n) : base(a, n) { }
        public void Scratch()
        {
            Console.WriteLine($"{name} is scratching something");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }

        public void Purr()
        {
            Console.WriteLine("Purrrrrrrr");
        }

        public void DoSomething(string x, string b)
        {
            Console.WriteLine("Do something 2 params");
        }
        public void DoSomething(string a, string c, string x = "")
        {
            Console.WriteLine("Do something 2 params");
        }
    }

    public class Fish : Animal
    {
        public Fish(string n, int a) : base(n, a) { }
        public override void MakeSound()
        {
            Console.WriteLine("Blubub blubub blubub");
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

        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }

        public double Add(params double[] numbers)
        {
            return numbers.Sum();
        }
    }

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Triangle : Shape
    {
        public int alas { set; get; }
        public int tinggi { set; get; }
        public Triangle(int a, int t)
        {
            alas = a;
            tinggi = t;
        }
        public override double CalculateArea()
        {
            List<int> nilai = new List<int> { 70, 45, 88, 30, 91 };

            foreach (int n in nilai)
            {
                if (n < 60)
                {
                    nilai.Remove(n);
                }
            }

            return 0.5 * alas * tinggi;

        }
    }
}
