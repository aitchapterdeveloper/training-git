using System;
using System.Collections.Generic;

namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            decimal discount = 1.11m;
            return price * (1 - discount);
        }

    }

    public class SapaService
    {
        public void SapaNama(string name, string namaakhir)
        {
            Console.WriteLine("halo " + name + namaakhir);
        }
        public string GetGreeting(string name, string alamat)
        {
            return $"halo {name}, {alamat}";
        }
    }

    public class cekNim
    {
        public string CekNim(int nim)
        {
            if (nim == 1234)
            {
                return "anda rizal";
            }
            else
            {
                return "anda bukan rizal";
            }
        }

        public void cetakAngka(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i++);
            }
        }
    }

    public class LatihanSatu

    {
        List<string> names = new List<string>
    {
        "adi",
        "rizal",
        "andri"
    };
        Dictionary<string, string> barang = new Dictionary<string, string>();

        List<string> mapel = new List<string>();


        public void belajarDictionary()
        {
            barang.Add("skt", "sikat gigi");
            barang.Add("sbn", "sabun");
            barang.Add("odl", "odol");

            foreach (var brg in barang)
            {
                Console.WriteLine($"{brg.Key} : {brg.Value}");
            }

            Console.WriteLine(barang["skt"]);

            if (barang.ContainsKey("sbn"))
            {
                Console.WriteLine("barang ditemukan");
            }
        }
        public void belajarList()
        {
            mapel.Add("kalkulus");
            mapel.Add("Sistem Informasi");
            mapel.Add("IOT");
            mapel.Add("Jaringan komputer");
            Console.WriteLine(mapel[0]);
            foreach (string m in mapel)
            {
                Console.WriteLine(m);
            }
            mapel.Remove("IOT");
            Console.WriteLine("total mapel: " + mapel.Count);

        }

        public void TampilkanNama()
        {
            foreach (string name in names)
            {
                Console.WriteLine("Halo " + name);
            }
        }



    }

    public class Product

    {
        public string Name { get; set; }
        public int Price { get; set; }



        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

    }

    public class BankAccount
    {
        private double _Balance;
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (value >= 0) _Balance = value;
            }
        }
    }



    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Breathe()
        {
            Console.WriteLine(Name + " is breathing");
        }
    }

    public class Cat : Animal
    {
        public void Scratch()
        {
            Console.WriteLine(Name + " is scratching");
        }
    }

    public class calculator
    {
        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c ;
        }
    }


}

