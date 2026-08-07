using System;
using System.Collections.Generic;
using GitTrainingDemo.Services;
using GitTrainingDemo.Models;
using System.Net.Http.Headers;

var userService = new UserService();
Console.WriteLine(userService.Login("admin", "1234"));

var orderService = new OrderService();
Console.WriteLine("Discounted total of 100000 = " + orderService.CalculateTotal(100000));

Console.WriteLine(orderService.GetGreeting("grEetInGS          ", "John Pork")); 
orderService.GetFullNameGreeting("John", "Pork");

Console.WriteLine(userService.Login("admin", "admin"));
Console.WriteLine(userService.Login("admin", "adm"));
Console.WriteLine(userService.Login("adminer", "admin"));
Console.WriteLine(userService.Login("admin", "adminer"));

orderService.GetNumberLoop(10);

List<string> cities = new List<string>
{
    "New York",
    "Los Angeles",
    "Chicago",
    "Houston",
    "Phoenix"
};

userService.GetCities(cities);

//cities.Add("Seattle");
//cities.Remove("Houston");
//Console.WriteLine("Cities Count: " + cities.Count);
//Console.WriteLine("Contains Jakarta: " + cities.Contains("Jakarta"));
//Console.WriteLine(cities[0]);

List<string> matkul = new List<string>();

matkul.Add("IPA");
matkul.Add("IPS");
matkul.Add("Matematika");
matkul.Add("Bahasa Indonesia");

matkul.Remove("IPA");

Console.WriteLine("Jumlah Matkul: " + matkul.Count);
Console.WriteLine("Ada matkul mat: " + (matkul.Contains("Matematika") ? "Ada" : "Tidak Ada"));
Console.WriteLine(matkul[1]);

orderService.GetGoods("ATK-01");

var product = new Product("Bensin");

Console.WriteLine("Produk: " + product.Name + ", Harga: " + product.Price);

product.Price = 10420; 
Console.WriteLine("Produk: " + product.Name + ", Harga: " + product.Price);

Console.WriteLine(product.CreatedAt);

PotatoChips potatoChips = new PotatoChips("Lays", "Seaweed");

Console.WriteLine(potatoChips.Name + " " + potatoChips.Flavor);

Calculator calc = new Calculator();
calc.Add(1, 2); // int version
calc.Add(1.5, 2.5); // double version
calc.Add(1, 2, 3); // 3 param version
double tripleDouble = calc.Add(1.1, 2.2, 3.3); // 3 double param version
int quadruple = calc.Add(1, 2, 3, 4); // 4 param version

Console.WriteLine(tripleDouble + " " + quadruple);

List<Product> products = new List<Product>
{
    new Product("Toothbrush"),
    new PotatoChips("Chitato", "Barbeque")
};

foreach (Product p in products) 
{
    Console.Write(p.Name + ": ");
    p.GetDescription();
}

Triangle triangle = new Triangle();
triangle.Base = 5;
triangle.Height = 12;
Console.WriteLine("TRIANGLE: " + triangle.CalculateArea());