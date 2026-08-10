using System;
using System.Collections.Generic;
using GitTrainingDemo.Services;
using GitTrainingDemo.Models;
using System.Net.Http.Headers;
using System.Linq;

/*
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
*/



List<int> arr = new List<int>();

for (int i = 0; i < 10; i++)
{
    arr.Add(i + 1);
}

//foreach (var n in arr)
//{
//    Console.WriteLine(n);
//}

// NO LINQ

List<int> result = new List<int>();
foreach (var n in arr) 
{
    if (n % 2 == 0)
        result.Add(n);
}

Console.WriteLine("No LINQ: ");
foreach (var n in result)
{
    Console.Write(n + " ");
}

var queryResult = 
    from n in arr
    where n % 2 == 0
    select n;

Console.WriteLine("\nLINQ: ");
foreach (var n in queryResult)
{
    Console.Write(n + " ");
}

var queryResultChain = arr
    .Where(n => n % 2 != 0)
    .OrderByDescending(n => n)
    .GroupBy(n => n >= 5)
    .ToList();

Console.WriteLine("\nLINQ Method Chain, Total Groups: " + queryResultChain.Count());
foreach (var group in queryResultChain)
{
    Console.Write("Group " + (group.Key ? ">= 5" : "< 5") + ": ");
    foreach (var n in group)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine("");
}

Console.WriteLine("Count: " + arr.Count(n => n >= 5));
Console.WriteLine("Sum: " + arr.Sum());
Console.WriteLine("Avg: " + arr.Average());
Console.WriteLine("Any: " + arr.Any(n => n == 6 || n == 7));
Console.WriteLine("All: " + arr.All(n => n > 0));
