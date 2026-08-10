using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GitTrainingDemo.Services;

var userService = new UserService();
//Console.WriteLine(userService.Login("admin", "123"));

var orderService = new OrderService();
//Console.WriteLine(orderService.CalculateTotal(100000));

//LATIHAN


//userService.ForLoopLoncat1(10);
//userService.ForEachLoopNama(new List<string> { 
//    "Adi", "Budi", "Citra", "Dodi", "Fahrul" 
//});
//Console.WriteLine(userService.GetGreeting("Adi", "Asep"));
//userService.SendGreeting("Adi", "Asep");
//userService.ListLatihan();
//userService.LatihanDictionary();

//Constructor

//Product p1 = new Product("Pisau", 10000, "Stabby");
//Product p2 = new Product("Pedang", 13000, "Long Stabby");

//Console.WriteLine("Barang " + p1.Name + " Harganya : " + p1.Price);
//Console.WriteLine("Deskripsi " + p1.Name + " : " + p1.Description);
//Console.WriteLine("Barang " + p2.Name + " Harganya : " + p2.Price);
//Console.WriteLine("Deskripsi " + p2.Name + " : " + p2.Description);

//Encapsulation

//BankAccount bankAccount = new BankAccount();
//bankAccount.Balance = -9000;
//Console.WriteLine("Balance : " + bankAccount.Balance);
//bankAccount.Balance = 109000;
//Console.WriteLine("Balance : " + bankAccount.Balance);


//Inheritance

//Cat cat = new Cat();
//cat.Name = "Asep";
//cat.Age = 5;
//cat.Purr();
//cat.Scratch();
//Console.WriteLine("The cat name is " + cat.Name + " and its " + cat.Age + " years old");

//public class Cat: Animal
//{
//    public string breed = string.Empty;

//    public void Purr() {
//        Console.WriteLine(Name + " is purring");
//    }

//    public void Scratch()
//    {
//        Console.WriteLine(Name + " is scratching");
//    }
//}

//public class Animal
//{
//    public string Name { get; set; } = string.Empty;
//    public int Age { get; set; } = 0;

//    public void Breathe()
//    {
//        Console.WriteLine(Name + " is breathing");
//    }
//}


//Polymorphism

//Calculator calc = new Calculator();
//Console.WriteLine("2 Param Integer (1,2) : " + calc.Add(1, 2)); // int version
//Console.WriteLine("2 Param Double (1.5,2.5) : " + calc.Add(1.5, 2.5)); // double version
//Console.WriteLine("3 Param Integer (1,2,3) : " + calc.Add(1, 2, 3)); // 3 param int version
//Console.WriteLine("3 Param Integer (1.5,2.5,3.5) : " + calc.Add(1.5, 2.5, 3.5)); //3 param double version
//Console.WriteLine("4 Param Integer (1,2,3,5) : " + calc.Add(1, 2, 3, 5)); //4 param int version

//public class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }
//    public double Add(double a, double b)
//    {
//        return a + b;
//    }
//    public int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public double Add(double a, double b, double c)
//    {
//        return a + b + c;
//    }
//    public int Add(int a, int b, int c, int d)
//    {
//        return a + b + c + d;
//    }
//}

//List<Animal> animals = new List<Animal>
//{
//    new Cow(),
//    new Sheep()
//};

//foreach(Animal animal in animals)
//{
//    animal.MakeSound();
//}


//public class Cow : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Moo! Moo!");
//    }
//}
//public class Sheep : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Baa! Baa!");
//    }
//}
//public class Animal
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Some generic sound");
//    }
//}


//// Abstraction

//Circle circle = new Circle();
//circle.Radius = 2 * Math.PI;
//Console.WriteLine("Circle Area : " + circle.CalculateArea());

//Rectangle rectangle = new Rectangle();
//rectangle.Width = 1;
//rectangle.Height = 2;
//Console.WriteLine("Rectangle Area : " + rectangle.CalculateArea());

//Triangle triangle = new Triangle();
//triangle.Color = "Blueberry";
//triangle.Base = 1;
//triangle.Height = 5;
//Console.WriteLine("Triangle Area : " + triangle.CalculateArea());
//triangle.DisplayColor();

//public class Circle : Shape
//{
//    public double Radius { get; set; }
//    public override double CalculateArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//public class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}

//public class Triangle : Shape
//{
//    public double Base {  get; set; }
//    public double Height { get; set; }

//    public override double CalculateArea()
//    {
//        return (Base/2) * Height;
//    }
//}

//public abstract class Shape
//{
//    public string Color { get; set; } = string.Empty;
//    // Method abstrak — WAJIB diimplementasikan child
//    public abstract double CalculateArea();
//    // Method konkret — bisa langsung digunakan
//    public void DisplayColor()
//    {
//        Console.WriteLine("Color: " + Color);
//    }
//}

////LINQ

//List<int> number = new List<int> { 1, 5, 23, 6, 34, 26, 3, 6, 43, 6, 2, 6, 34, 6, 23, 6 };

//List<int> result = new List<int>();

//foreach(var n in number)
//{
//    if (n > 10) result.Add(n);
//}

//Console.Write("Result : ");

//foreach(var prt in result)
//{
//    Console.Write(prt + ", ");
//}

//Console.WriteLine();

//var res =
//    (from n in number
//    where n > 10
//    orderby n descending
//    select n);

//Console.Write("Res : ");
//foreach(var x in res)
//{
//    Console.Write(x + ", ");
//}

//Console.WriteLine();


//var filtered = number
//    .Where(n => n > 10)
//    .OrderByDescending(n => n)
//    .GroupBy(n => n % 2)
//    .Select(n => n)
//    .ToList();

//Console.Write("Filtered : ");

//foreach(var groups in filtered)
//{
//    foreach(var value in groups)
//    {
//        Console.Write(value + ", ");
//    }
//}


//Console.WriteLine();

//Console.WriteLine("Count Numbers : " + number.Count(n => n > 5));
//Console.WriteLine("Sum Numbers : " + number.Where(n => n >= 40).Sum());
//Console.WriteLine("Average Numbers : " + number.Average());
//Console.WriteLine("Are There Any Numbers Higher Than 35 : " + number.Any(n => n > 35));
//Console.WriteLine("Are There Numbers Higher Than 43 : " + number.All(n => n > 43));

//var queryDefferred = number
//    .Where(n => n > 20)
//    .OrderByDescending( n => n );

//Console.Write("Querry Defferred : ");
//foreach(var x in queryDefferred)
//{
//    Console.Write(x + ", ");
//}

//Console.WriteLine();

//Console.Write("Executed Defferred Querry : ");

//number.Add(50);

//foreach (var x in queryDefferred)
//{
//    Console.Write(x + ", ");
//}

//Console.WriteLine();

//var queryImmediate = number
//    .Where(n => n > 20)
//    .OrderByDescending(n => n)
//    .ToList();

//Console.Write("Query Immediate Execute : ");
//foreach (var x in queryImmediate)
//{
//    Console.Write(x + ", ");
//}

//Console.WriteLine();

//Console.Write("Executed Immediate Querry Added 50 : ");

//number.Add(70);

//foreach (var x in queryImmediate)
//{
//    Console.Write(x + ", ");
//}

//async Task<string> GetDataAsync(int id)
//{
//    await Task.Delay(1500);
//    return $"Data untuk id : {id}";
//}


////Asynchronous Process

//Console.WriteLine("Mulai operasi sinkron...");
//Thread.Sleep(2000); //Simulasi menunggu I/O
//Console.WriteLine("Selesai - thread tadi menganggur total 2 detik.");

////await Task.Delay(2000);
//var value = await GetDataAsync(14);
//Console.WriteLine("Selesai - " + value);
////Console.WriteLine("Selesai - thread bebas melayani hal lain saat menunggu");

//string DownloadFileSync(string fileName)
//{
//    Task.Delay(2000).Wait();
//    return $"Downloaded file {fileName}";
//}

//string CompressFileSync(string fileName)
//{
//    Task.Delay(2000).Wait();
//    return $"Compressed file {fileName}";
//}

//string UploadFileSync(string fileName)
//{
//    Task.Delay(2000).Wait();
//    return $"Uploaded file {fileName}";
//}

//var stopwatchSync = Stopwatch.StartNew();

//var downloadedFileSync = DownloadFileSync("NewFile.html");
//var compressedFileSync = CompressFileSync("NewFile.html");
//var uploadedFileSync = UploadFileSync("NewFile.html");

//stopwatchSync.Stop();
//Console.WriteLine($"Total waktu Sync : {stopwatchSync.ElapsedMilliseconds}ms");

////Async Ver;
//async Task<string> DownloadFile(string fileName)
//{
//    await Task.Delay(2000);
//    return $"Downloaded file {fileName}";
//}

//async Task<string> CompressFile(string fileName)
//{
//    await Task.Delay(2000);
//    return $"Compressed file {fileName}";
//}

//async Task<string> UploadFile(string fileName)
//{
//    await Task.Delay(2000);
//    return $"Uploaded file {fileName}";
//}

//var stopwatchAsync = Stopwatch.StartNew();

//Task t1 = DownloadFile("NewFile.html");
//Task t2 = CompressFile("NewFile.html");
//Task t3 = UploadFile("NewFile.html");

//await Task.WhenAll(t1, t2, t3);

//stopwatchAsync.Stop();
//Console.WriteLine($"Total waktu Async : {stopwatchAsync.ElapsedMilliseconds}ms");

//var stopwatchAsync = Stopwatch.StartNew();

//var x = GetDataAsync().Result;

//stopwatchAsync.Stop();
//Console.WriteLine($"Total waktu Async : {stopwatchAsync.ElapsedMilliseconds}ms");

//Console.WriteLine(x);

//async Task<string> GetDataAsync()
//{
//    await Task.Delay(500);
//    return "Data dari async";
//}


//async Task<string> GetDataInternalAsync(int id)
//{
//    // Untuk library, ConfigureAwait(false)
//    // menghindari penangkapan SynchronizationContext
//    await Task.Delay(500).ConfigureAwait(false);
//    return $"Data untuk id: {id}";
//}
//async Task<string> GetFormattedDataAsync(int id)
//{
//    var rawData = await GetDataInternalAsync(id);
//    return $"Formatted: {rawData}";
//}
//// Di Controller atau Entry Point
//async Task<string> GetUserEndpoint(int id)
//{
//    var data = await GetFormattedDataAsync(id);
//    return $"OK {data}";
//}
//async Task<string> GetUserName(int id)
//{
//    var data = await GetUserEndpoint(id);

//    return $"User Name {data}";
//}

//Console.WriteLine(await GetUserName(0));



//Validation validation = new Validation();
//DatabaseAccess databaseAccess = new DatabaseAccess();
//SendAction sendAction = new SendAction();

//validation.ValidateUser("adins@gmail.com");
//databaseAccess.SaveToDatabase("adins@gmail.com");
//sendAction.SendWelcomeEmail("adins@gmail.com");

//public class Validation
//{
//    public void ValidateUser(string email)
//    {
//        Console.WriteLine($"Validasi email : {email}");
//    }
//}

//public class DatabaseAccess
//{
//    public void SaveToDatabase(string email)
//    {
//        Console.WriteLine($"Simpan ke database : {email}");
//    }
//}

//public class SendAction
//{
//    public void SendWelcomeEmail(string email)
//    {
//        Console.WriteLine($"Kirim welcome email ke : {email}");
//    }
//}

//int initPrice = 10000;

//double priceRegular = new RegularDiscount().Apply(initPrice);
//double priceVIP = new VIPDiscount().Apply(initPrice);
//double priceStudent = new StudentDiscount().Apply(initPrice);
//double pricePremium = new PremiumDiscount().Apply(initPrice);

//Console.WriteLine($"Regular : {priceRegular}");
//Console.WriteLine($"VIP     : {priceVIP}");
//Console.WriteLine($"Student : {priceStudent}");
//Console.WriteLine($"Premium : {pricePremium}");

//interface IDiscount
//{
//    double Apply(double price);
//}

//class RegularDiscount : IDiscount
//{
//    public double Apply(double price) => price * 0.9;
//}

//class VIPDiscount : IDiscount
//{
//    public double Apply(double price) => price * 0.8;
//}

//class StudentDiscount : IDiscount
//{
//    public double Apply(double price) => price * 0.7;
//}

//class PremiumDiscount : IDiscount
//{
//    public double Apply(double price) => price * 0.5;
//}

//Rectangle rectangle = new Rectangle();
//Square square = new Square();

//rectangle.Width = 5;
//rectangle.Height = 10;

//square.Side = 5;

//PrintArea(rectangle);
//PrintArea(square);

//// Keduanya bisa dipakai lewat IShape
//// tanpa melanggar kontrak satu sama lain.
//void PrintArea(IShape shape)
//=> Console.WriteLine($"{shape} Area : {shape.Area()}");

//interface IShape
//{
//    int Area();
//}
//class Rectangle : IShape
//{
//    public int Width { get; set; }
//    public int Height { get; set; }
//    public int Area() => Width * Height;
//}
//class Square : IShape
//{
//    public int Side { get; set; }
//    public int Area() => Side * Side;
//}

//Koala koala = new Koala();
//HumanWorker humanWorker = new HumanWorker();
//RobotWorker robotWorker = new RobotWorker();

//koala.Sleep();
//koala.Eat();

//humanWorker.Eat();
//humanWorker.Sleep();
//humanWorker.Work();

//robotWorker.Work();

//interface IWorkable { void Work(); }
//interface IFeedable { void Eat(); }
//interface ISleepable { void Sleep(); }

//class HumanWorker : IWorkable,
//IFeedable, ISleepable
//{
//    public void Work() {
//        Console.WriteLine("Human Working");
//    }
//    public void Eat()
//    {
//        Console.WriteLine("Human Eating");
//    }
//    public void Sleep()
//    {
//        Console.WriteLine("Human Sleeping");
//    }
//}
//class RobotWorker : IWorkable
//{
//    public void Work()
//    {
//        Console.WriteLine("Robot Working");
//    }
//}

//class Koala : IFeedable, ISleepable
//{
//    public void Sleep()
//    {
//        Console.WriteLine("Koala Sleeping");
//    }

//    public void Eat()
//    {
//        Console.WriteLine("Koala Eating");
//    }
//}

//Order order = new Order();

//order.PlaceOrderPhone();
//order.PlaceOrderEmail();

//interface INotificationService
//{
//    void Send(string message);
//}

//class EmailServiceSimple : INotificationService
//{
//    public void Send(string message) => Console.WriteLine($"Email : {message}");
//}

//class PhoneServiceSimple : INotificationService
//{
//    public void Send(string message) => Console.WriteLine($"Phone : {message}");
//}

//class Order
//{
//    public void PlaceOrderEmail()
//    {
//        EmailServiceSimple emailServiceSimple = new EmailServiceSimple();
//        emailServiceSimple.Send("adins@gmail.com");
//    }
//    public void PlaceOrderPhone()
//    {
//        PhoneServiceSimple phoneServiceSimple = new PhoneServiceSimple();
//        phoneServiceSimple.Send("087808780878");
//    }
//}



















// Latihan
//Ubah ini jadi prinsip SOLID

EmailNotificationSend emailNotificationSend = new EmailNotificationSend();
PaymentValidator paymentValidator = new PaymentValidator();
PaymentService paymentService = new PaymentService(paymentValidator, emailNotificationSend);

IPaymentMethod cc = new CreditPayment();
paymentService.ProcessPayment(cc, 1000, "adins@gmail.com");

Console.WriteLine();

IPaymentMethod ewallet = new EWalletPayment();
paymentService.ProcessPayment(ewallet, 1000, "adins@gmail.com");