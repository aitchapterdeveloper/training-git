using System;
using System.Collections.Generic;
using GitTrainingDemo.Services;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

//var userService = new UserService();
//var userValidator = new UserValidator();
//var userRepository = new UserRepository();
//var emailService = new EmailService();
//var orderService = new OrderService();
//bool login = false;

//do
//{
//    Console.WriteLine("====== SILAHKAN LOGIN =====");
//    Console.Write("Nama : ");
//    string nama = Console.ReadLine();
//    string password = "";
//    do
//    {
//        Console.Write("Password : ");
//        password = Console.ReadLine();

//        if (password.Length < 4)
//        {
//            Console.WriteLine("Password terlalu pendek");
//        }
//    } while (password.Length < 4);

//    login = userService.Login(nama, password);

//    if (login == true)
//    {
//        Console.WriteLine(orderService.GetGreeting(nama, "siang"));
//        Console.Write("Masukan Angka : ");
//        int angka = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= angka; i+=2)
//        {
//            Console.WriteLine("Angka - " + i);
//        };

//        List<string> matkuls = new List<string>();
//        Dictionary<int, string> kamusMatkul = new Dictionary<int, string>();
//        HashSet<string> tags = new HashSet<string>();

//        string tambahMatkul = "";
//        int key = 0;

//        while (tambahMatkul.ToLower() != "tidak")
//        {
//            Console.WriteLine("===== TAMBAH MATA KULIAH =====");
//            Console.Write("Mata Kuliah : ");
//            string mataKuliah = Console.ReadLine();
//            matkuls.Add(mataKuliah);
//            kamusMatkul.Add(key, mataKuliah);
//            tags.Add(mataKuliah);
//            Console.Write("Tambah Mata Kuliah ? (Ya/Tidak) : ");
//            tambahMatkul = Console.ReadLine();
//            key++;
//        }


//        Console.WriteLine("List");
//        foreach(string matkul in matkuls)
//        {
//            Console.WriteLine(matkul);
//        }

//        Console.WriteLine("Dictionary");
//        foreach (var kamus in kamusMatkul)
//        {
//            Console.WriteLine(kamus);
//        }

//        Console.WriteLine("Hash");
//        foreach (string tag in tags)
//        {
//            Console.WriteLine(tag);
//        }

//        Console.WriteLine("===== CAR =====");
//        Console.Write("Brand : ");
//        string brand = Console.ReadLine();
//        Console.Write("Color : ");
//        string color= Console.ReadLine();
//        Console.Write("Year : ");
//        int year = int.Parse(Console.ReadLine());
//        CarService car = new CarService(brand, color, year);
//        Console.WriteLine(car.Drive());

//        Console.WriteLine("===== ANIMAL =====");
//        Console.Write("Name : ");
//        string animalName = Console.ReadLine();
//        Console.Write("Age : ");
//        int animalAge = int.Parse(Console.ReadLine());
//        Console.Write("Breed : ");
//        string animalBreed = Console.ReadLine();
//        Cat cat = new Cat(animalName, animalAge, animalBreed);
//        Console.WriteLine(cat.MakeSound());
//    } else
//    {
//        Console.WriteLine("Nama atau Password Salah!!!");
//    }
//} while (login == false);

//List<int> numbers = new List<int> { 3, 15, 7, 22, 9, 18, 5, 11, 12, 22, 4, 17, 20 };
//List<int> result = new List<int>();

//Console.WriteLine("===== Menggunakan FOREACH =====");

//foreach (var n in numbers)
//{
//    if (n > 10)
//        result.Add(n);
//}

//foreach (var r in result)
//{
//    Console.WriteLine(r);
//}

//Console.WriteLine("===== Menggunakan LINQ =====");

//var queryResult = numbers.Where(n => n < 10).GroupBy(n => n % 2).OrderByDescending(g => g.Key).Select(g => g);
//numbers.Add(-1);

//foreach (var r in queryResult)
//{
//    Console.WriteLine(r.Key == 0 ? "Genap" : "Ganjil");

//    foreach (var n in r.OrderByDescending(n => n))
//    {
//        Console.WriteLine(n);
//    }
//}

//Console.WriteLine("===== Aggregate Operators =====");
//var flatResult = numbers.Select(g => g);

//Console.WriteLine(flatResult.Count(n => n > 5));
//Console.WriteLine(flatResult.Sum());
//Console.WriteLine(flatResult.Average());
//Console.WriteLine(flatResult.Any(n => n > 15));
//Console.WriteLine(flatResult.All(n => n > 0));

//var service = new Asyncronus();

//var stopwatch = Stopwatch.StartNew();

//var task1 = service.GetUserNameAsync(42);
//var task2 = service.GetUserNameAsync(42);
//var task3 = service.GetUserNameAsync(42);
//var task4 = service.GetFormattedDataAsync(42);

//var resultAsync = await Task.WhenAll(task1, task2, task3);

//stopwatch.Stop();

//Console.WriteLine($"Waktu: {stopwatch.ElapsedMilliseconds} ms");


//stopwatch.Restart();

//var resultSync = service.GetData(42);
//var resultSync2 = service.GetData(42);
//var resultSync3 = service.GetData(42);

//stopwatch.Stop();

//Console.WriteLine($"Waktu: {stopwatch.ElapsedMilliseconds} ms");

//string validator;

//userValidator.Validate("fachri", "1234", out validator);
//if (validator == "Login Berhasil")
//{
//    userRepository.Save("fachri");
//    emailService.Send("AdIns");
//}

//var vipDiscount = new VIPDiscount();
//Console.WriteLine(vipDiscount.Apply(500000));

ISendNotification notification = new SendEmail();

OrderServiceTes orderService = new OrderServiceTes(notification);

orderService.PlaceOrder();

interface ISendNotification
{
    void SendNotification(string message);
}

class SendWhatsApp : ISendNotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine("WhatsApp: " + message);
    }
}

class SendEmail: ISendNotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine("Email: " + message);
    }
}

class OrderServiceTes
{
    private readonly ISendNotification _notification;

    public OrderServiceTes(ISendNotification notification)
    {
        _notification = notification;
    }

    public void PlaceOrder()
    {
        Console.WriteLine("Order berhasil dibuat!");

        _notification.SendNotification(
            "Pesanan berhasil dibuat."
        );
    }
}
