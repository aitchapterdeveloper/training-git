using System;
using System.Collections.Generic;
namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            return price;
        }

        public string GetGreeting(string firstName, string lastName)
        {
            return "Halo, " + firstName + lastName +" !";
        }

        //string message = GetGreeting("Bil", "Hakki");

        public void GetGreetingV(string firstName, string lastName)
        {
            Console.WriteLine("Halo , " + firstName + lastName + " !");
        }
        //string message2 - GetGreetingV("Bil", "Hakki");

        //public void showNumber(int iterasi)
        //{
        //    List<string> names = new List<string>
        //        {
        //        "Adi", "Budi", "Citra"
        //        };

        //    for (int i=0; i<iterasi; i++)
        //    {
        //        Console.WriteLine(i += 1);
            
        //    }
        //}

        public void showLoop()
        {
            List<string> names = new List<string>
               {
                "Adi", "Budi", "Citra", "Bil", "Hakki"
               };

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(names[i]);

            //}
            foreach(string name in names)
            {
                Console.WriteLine("Halo, " + name);
            }
        }

        public void showList()
        {
            List<string> matkul = new List<string>();
            matkul.Add("Kalkulus");
            matkul.Add("Machine Learning");
            matkul.Add("OOP");
            matkul.Add("Fisika");

            foreach (string item in matkul)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============================");

            matkul.Remove("Machine Learning");

            foreach (string item in matkul)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============================");

            Console.WriteLine(matkul.Contains("Machine Learning"));
            Console.WriteLine(matkul.Contains("OOP"));
            Console.WriteLine(matkul.Count);
        }

        public void showDictionary()
        {
            Dictionary<string, string> kodeBarang = new Dictionary<string, string>();

            kodeBarang.Add("MBL", "Lamborghini");
            kodeBarang.Add("MBF", "Ferrari");
            kodeBarang.Add("MBM", "Mercedes");
            kodeBarang.Add("MBLE", "Lexus");

            // Akses Berdasarkan Key
            Console.WriteLine(kodeBarang["MBL"]);

            // Cek Keberadaan Key
            if (kodeBarang.ContainsKey("MBLE"))
            {
                Console.WriteLine("Mobil Ada");
            }

            Console.WriteLine("============================");
            
            foreach (KeyValuePair<string, string> item in kodeBarang)
            {
                Console.WriteLine(item.Key + " ==> " + item.Value);
            }
        }
    }

    // OOP 
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        //protected int IdProduct { get; set; }

        public Product(string name, int price){
            Name = name;
            Price = price;
        }
    }

    //public class Animal
    //{
    //    public string Name { get; set; }
    //    public string Age { get; set; }

    //    public void Breath()
    //    {
    //        Console.WriteLine(Name + "is breathing");
    //    }
    //}

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
    //    public string
    //}
}
