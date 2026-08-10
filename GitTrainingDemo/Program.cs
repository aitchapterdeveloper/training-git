using GitTrainingDemo.Services;
using System;

var userService = new UserService();
//Console.WriteLine(userService.Login("user", "123"));
//Console.WriteLine(userService.Loginn("admin", "1276"));

var orderService = new OrderService();
//Console.WriteLine(orderService.GetGreeting("Ginda","Teguh"));
//Console.WriteLine(orderService.GetGrade(85));
//orderService.ForLoop();
//orderService.Foreachname();
//orderService.list();
//orderService.dictionary();
//orderService.hashset();
//orderService.GetGreetings("Enigma");


// Penggunaan — nilai langsung terisi
//Product s1 = new Product("Minyak", 22000);
//Product s2 = new Product("Mie Instan", 24000);
//Console.WriteLine(s1.Name); // "Minyak"
//Console.WriteLine(s2.Price); // 24000

//BankAccount acc = new BankAccount();
//acc.Balance = -99909; // tidak ada validasi!
//Console.WriteLine(acc.Balance);

//Cat c = new Cat();
//c.Name = "Lex"; // dari Animal
//c.Scratch(); // milik Cat
//c.Breathe(); // diwarisi dari Animal

//Calculator calc = new Calculator();

//Console.WriteLine(calc.Add(1, 2));
//Console.WriteLine(calc.Add(1.5, 2.5));
//Console.WriteLine(calc.Add(1, 2, 3));

// List of Animal tapi berisi berbagai jenis

//static void main(string[] args)
//{
//    List<Animals> animals = new List<Animals>
//    {
//        new Cow(),
//        new Goat(),
//        new Animals()
//    };
//    foreach (Animals a in animals)
//    {
//        a.MakeSound();
//    }
//}

Triangle tria = new Triangle { Color = "Blue", alas = 5, tinggi = 4 };
tria.DisplayColor();
Console.WriteLine("Triangle Area: " + tria.CalculateArea());



