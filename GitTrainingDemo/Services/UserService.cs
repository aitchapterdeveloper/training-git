using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GitTrainingDemo.Services
{
    public class UserService
    {
        public string Login(string user, string pass)
        {
            if (user == "admin" && pass == "1234")
            {
                return "Login Success !!!";
            }
            else if(pass.Length < 4)
            {
                return "Password kurang dari 4 karakter";
            }
            else if (user == "admin")
            {
                return "Password salah";
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang";
            }
        }

        public string LoginTest(string user, string pass)
        {
            if (user == "adminxx" && pass == "123456")
            {
                return "Login berhasil ya";
            }
            else if (user == "admin")
            {
                return "!!!!!!!Password-----salah----------ya!!!!!!!!!!!"; //test commit
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang ya";
            }
        }

        public string GetGreeting(string firstName, string lastName)
        {
            return "Halo, " + firstName + " " + lastName + "!";
        }

        public void SendGreeting(string firstName, string lastName)
        {
            Console.WriteLine("Halo, " + firstName + " " +  lastName + "!");
        }

        public void ForLoopLoncat1(int n)
        {
            for (int i = 0; i < n; i += 2)
            {
                Console.WriteLine(i + 1);
            }
        }

        public void ForEachLoopNama(List<string> listNama)
        {
            foreach (string nama in listNama)
            {
                Console.WriteLine("Halo " + nama + "!");
            }
        }

        public void ListLatihan()
        {
            List<string> mataKuliah = new List<string> ();
            mataKuliah.Add("IPA");
            mataKuliah.Add("Matematika");
            mataKuliah.Add("Geologi");
            mataKuliah.Add("IPS");

            Console.WriteLine("Mata kuliah pertama : " + mataKuliah[0]);
            Console.WriteLine("Jumlah mata kuliah saat ini : " + mataKuliah.Count);

            mataKuliah.Remove("IPS");
            Console.WriteLine("Jumlah mata kuliah saat ini : " + mataKuliah.Count);

            Console.WriteLine("Apakah ada mata kuliah IPA : " + mataKuliah.Contains("IPA"));
            Console.WriteLine("Apakah ada mata kuliah IPS : " + mataKuliah.Contains("IPS"));

            foreach(string matkul in mataKuliah)
            {
                Console.WriteLine("Mata kuliah : " + matkul);
            }
        }

        public void LatihanDictionary()
        {
            Dictionary<string, string> barangProduk = new Dictionary<string, string> ();

            barangProduk.Add("ITM-001", "Pisang");
            barangProduk.Add("ITM-002", "Pisau");
            barangProduk.Add("ITM-003", "Apel");
            barangProduk.Add("ITM-004", "Susu");
            barangProduk.Add("ITM-005", "Sereal");
            barangProduk.Add("ITM-006", "Sosis");
            barangProduk.Add("ITM-007", "Kentang");
            barangProduk.Add("ITM-008", "Pir");
            barangProduk.Add("ITM-009", "Kopi");
            barangProduk.Add("ITM-010", "Laptop");
            barangProduk.Add("ITM-011", "Komputer");

            Console.WriteLine(barangProduk["ITM-001"]);

            Console.WriteLine(barangProduk.ContainsKey("ITM-010"));

            if (barangProduk.ContainsKey("ITM-010"))
            {
                Console.WriteLine("Barang ditemukan");
            }

            foreach(string namaBarang in barangProduk.Values)
            {
                Console.WriteLine("Nama Barang : " + namaBarang);
            }
        }

        public void LatihanHashSet()
        {
            HashSet<string> tags = new HashSet<string>();
            tags.Add("C#");
            tags.Add("OOP");
            tags.Add("C#"); // Diabaikan — duplikat!
            Console.WriteLine(tags.Count); // 2, bukan 3

            // Set operations
            HashSet<string> setA = new HashSet<string> { "A", "B", "C" };
            HashSet<string> setB = new HashSet<string> { "B", "C", "D" };
            //setA.IntersectWith(setB);
            //// setA sekarang: {"B", "C"}
            //setA.UnionWith(setB);
            //setA.ExceptWith(setb);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        //private string _description;

        //public string Description { 
        //    get { return _description; } 
        //    set
        //    {
        //        _description = value;
        //    }
        //}

        public Product(string name, int price, string description)
        {
            Name = name;
            Price = price;
            //Description = description;
        }
    }

    public class BankAccount
    {
        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set
            {
                if(value>0) _balance = value;
            }
        }
    }
}