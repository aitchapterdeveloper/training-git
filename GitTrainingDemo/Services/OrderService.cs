using System;
using System.Collections.Generic;

namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        //public decimal CalculateTotal(decimal price)
        //{
        //    return price * 0.9m; //diskon 10%
        //}
        public string GetGreeting(string firstName, string lastName)
        {
            return "Halo, " + firstName + " " + lastName + "!";
        }

        public void GetGreetings(string firstNamee)
        {
            Console.WriteLine("Welcome " + firstNamee);
        }

        public string GetGrade(int score)
        {
            switch (score / 10)
            {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                case 6:
                    return "D";
                default:
                    return "E";
            }
        }
        public void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Nomor " + i);
                i++;
            }
        }
        public void Foreachname()
        {
            List<string> names = new List<string>
            {
                "Badak","Ayam","Cacing","Beruk","Semut"
            };
            foreach (string name in names)
            {
                Console.WriteLine("Halo, " + name);
            }
        }

        public void list()
        {
            List<string> matkul = new List<string>();
            matkul.Add("Analisis dan Visualisasi Data");
            matkul.Add("Pemrograman Web");
            matkul.Add("Business Intelligence");
            matkul.Add("Basis Data");
            Console.WriteLine(matkul[0]);
            Console.WriteLine(matkul[1]);
            Console.WriteLine(matkul[2]);
            Console.WriteLine(matkul[3]);
            Console.WriteLine(matkul.Count);
            matkul.Remove("Pemrograman Web");
            Console.WriteLine(matkul.Count);
            Console.WriteLine(matkul.Contains("Pemrograman Web"));
            foreach (string f in matkul)
            {
                Console.WriteLine(f);
            }

        }
        public void dictionary()
        {
            Dictionary<string, string> barang =
                new Dictionary<string, string>();
            barang.Add("MBL1", "Mobil Pajero");
            barang.Add("MTR2", "Motor NMax");
            barang.Add("SPL3", "Sepeda Listrik");

            Console.WriteLine(barang["SPL3"]);

            if (barang.ContainsKey("MBL5"))
            {
                Console.WriteLine("Barang Ditemukan");
            }
            else
            {
                Console.WriteLine("Tidak Ada Barang");
            }

        }
        public void hashset()
        {
            HashSet<string> tags = new HashSet<string>();
            tags.Add("C#");
            tags.Add("OOP");
            tags.Add("C#"); // Diabaikan — duplikat!
            Console.WriteLine(tags.Count); // 2, bukan 3
                                           // Set operations
            HashSet<string> setA = new HashSet<string> { "A", "B", "C" };
            HashSet<string> setB = new HashSet<string> { "B", "C", "D" };
            setA.IntersectWith(setB);

            foreach (var item in setA)
            {
                Console.WriteLine(item);
            }
            // setA sekarang: {"B", "C"}
        }


    }
    //OOP

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        // Constructor
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
    //Encapsulation (Bungkus Data)
    public class BankAccount
    {
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0) _balance = value;
            }
        }
    }

    //Inheritance (Pewarisan)
    public class Cat : Animal // Cat mewarisi Animal
    {
        public string Purr { get; set; } = string.Empty;
        public void Scratch()
        {
            Console.WriteLine(Name + " says: Miaw!");
        }
    }

    public class Animal
    {
        public string Name { get; set; } = string.Empty;

        public void Breathe()
        {
            Console.WriteLine(Name + " is breathing.");
        }
    }

    //Polymorphism Overloading
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
    }

    //Polymorphism Override
    public class Cow : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Mooooo");
        }
    }
    public class Goat : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Ankara Messi");
        }
    }
    public class Animals
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    //Abstraction
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

    public class Triangle : Shape
    {
        public double alas { get; set; }
        public double tinggi { get; set; }
        public override double CalculateArea()
        {
            return 0.5 * alas * tinggi;
        }
    }

}

