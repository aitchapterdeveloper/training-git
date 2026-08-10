using GitTrainingDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Net;


var userService = new UserService();
//Console.WriteLine(userService.Login("user", "123"));
//Console.WriteLine(userService.Loginn("admin", "1276"));

//var orderService = new OrderService();
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

//Triangle tria = new Triangle { Color = "Blue", alas = 5, tinggi = 4 };
//tria.DisplayColor();
//Console.WriteLine("Triangle Area: " + tria.CalculateArea());

//List<int> num = new List<int> { 3, 7, 12, 5, 18, 2, 15, 4, 13, 8, 17, 6};
//List<int> num2 = new List<int> { 3, 7, 12, 5, 18, 2, 15, 4, 13, 8, 17, 6 };
//List<int> result = new List<int>();

//Console.WriteLine("Tanpa LINQ");
//foreach (var n in num)
//{
//    if (n > 10) result.Add(n);
//}

//foreach (var r in result)
//{
//    Console.WriteLine(r);
//}
//Console.WriteLine("Dengan LINQ");
//var queryResult =
//    from n in num
//    where n > 10
//    select n;

//foreach (var r in queryResult)
//{
//    Console.WriteLine(r);
//}

//Console.WriteLine("Dengan LINQ with Syntax");
//var filtered = num
//      .Where(n => n > 10)
//      .Select(n => n%2)
//      .OrderByDescending(n => n)
//      .ToList();

//foreach (var p in filtered)
//{
//    Console.WriteLine(p);
//}

//Console.WriteLine("\n DEMO AGGREGATE OPERATORS");
//Console.WriteLine($"Count (>5): {num.Count(n => n > 5)}");     
//Console.WriteLine($"Sum: {num.Sum()}");                         
//Console.WriteLine($"Average: {num.Average():F2}");              
//Console.WriteLine($"Any (>15): {num.Any(n => n > 15)}");       
//Console.WriteLine($"All (>0): {num.All(n => n > 0)}");

//Console.WriteLine("\n Deferred Execution");
//var query = num
//    .Where(n => n > 5);
//    // Query belum berjalan!
//    num.Add(20); // ditambah dulu
//    foreach (var n in query)
//    {
//        Console.WriteLine(n);
//    }
//Console.WriteLine("\n Immediate Execution");
//var results = num2
//    .Where(n => n > 5)
//    .ToList(); // Dieksekusi sekarang!
//    num2.Add(20);
//    foreach (var n in results)
//    {
//        Console.WriteLine(n);
//    }

//var result = await GetDataAsync(42);
//Console.WriteLine(result);

//var results = await GetUserNameAsync(42);
//Console.WriteLine(results);

//async Task<string> GetDataAsync (int id)
//{
//    await Task.Delay(500);
//    return $"Data untuk id : {id}";
//}

//async Task<string> GetUserNameAsync (int id)
//{
//    await Task.Delay(300);
//    return $"User - {id}";
//}


//    var swSync = Stopwatch.StartNew();
//    DownloadFile(10);
//    CompressFile(20);
//    UploadFile(30);

//    swSync.Stop();
//    Console.WriteLine($"Total Waktu Sync : {swSync.ElapsedMilliseconds}ms");


//string DownloadFile(int id)
//{
//    Task.Delay(2000).Wait();
//    return $"Download File : {id}";
//}
//string CompressFile(int id)
//{
//    Task.Delay(2000).Wait();
//    return $"Compress File : {id}";
//}
//string UploadFile(int id)
//{
//    Task.Delay(2000).Wait();
//    return $"Upload File : {id}";
//}

//var swAsync = Stopwatch.StartNew();

//    await Task.WhenAll(DownloadFileAsync(40), CompressFileAsync(50), UploadFileAsync(60));

//    swSync.Stop();

//    Console.WriteLine($"Total Waktu Async : {swAsync.ElapsedMilliseconds}ms");


//async Task<string> DownloadFileAsync(int id)
//{
//    await Task.Delay(2000);
//    return $"Download File : {id}";
//}
//async Task<string> CompressFileAsync(int id)
//{
//    await Task.Delay(2000);
//    return $"Compress File : {id}";
//}
//async Task<string> UploadFileAsync(int id)
//{
//    await Task.Delay(2000);
//    return $"Upload File : {id}";
//}

//string data = await GetDataAsync();
//Console.WriteLine(data);

//async Task<string> GetDataAsync()
//{
//    await Task.Delay(2000);
//    return "Data dari Async";
//}

//var result = await GetFormattedDataAsync(42);
//Console.WriteLine(result);

//async Task<string> GetDataInternalAsync(int id)
//{
//    await Task.Delay(500).ConfigureAwait(false);
//    return $"Data untuk id: {id}";
//}
//async Task<string> GetFormattedDataAsync(int id)
//{
//    var rawData = await GetDataInternalAsync(id);
//    return $"Formatted: {rawData}";
//}

//var user = new UserValidator();
//user.Validate("aaa");

//class UserValidator { public void Validate(string email) {
//        Console.WriteLine($"Validasi Email : {email}");
//    } }
//class UserRepository { public void Save(string email) {
//        Console.WriteLine($"Simpan ke Database : {email}");
//    } }
//class EmailService { public void Send(string email) {
//        Console.WriteLine($"Kirim email ke : {email}");
//    } }

//double harga = 1500000;

//Discount student = new StudentDiscount();
//Discount premium = new VIPDiscount();

//Console.WriteLine($"Harga awal : {harga}");
//Console.WriteLine($"Student (10% off) : {student.Apply(harga)}");
//Console.WriteLine($"Premium (20% off) : {premium.Apply(harga)}");

//interface Discount
//{
//    double Apply(double price);
//}

//class StudentDiscount : Discount
//{
//    public double Apply(double price) => price * 0.9;
//}

//class VIPDiscount : Discount
//{
//    public double Apply(double price) => price * 0.8;
//}


//IShape rectangle = new Rectangle { Height = 5, Width = 10 };
//IShape square = new Square{Side = 5};

//Console.WriteLine($" Persegi Panjang : {rectangle.Area()}");
//Console.WriteLine($" Persegi : {square.Area()}");

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

//HumanWorker human = new HumanWorker();
//human.Work();
//human.Eat();

//RobotWorker robot = new RobotWorker();
//robot.Work();

//interface IWorkable { void Work(); }
//interface IFeedable { void Eat(); }
//interface ISleepable { void Sleep(); }
//class HumanWorker : IWorkable,
//IFeedable
//{
//    public void Work() {
//        Console.WriteLine("Pekerja manusia sedang bekerja");
//    }
//    public void Eat() {
//        Console.WriteLine("Pekerja manusia sedang makan");
//    }
//    public void Sleep()
//    {
//        Console.WriteLine("Pekerja lelah butuh tidur");
//    }
//}
//class RobotWorker : IWorkable
//{
//    public void Work() {
//        Console.WriteLine("Robot bekerja 24 jam");
//    }
//    // Hanya implement yang relevan!
//}
//INotificationService notif = new EmailNotification();
//notif.Send("Ini Pesanannya");


//class EmailServiceSimple
//{
//    public void Send(string message) => Console.WriteLine(message);
//}

//class OrderServiceBroken
//{
//    private EmailServiceSimple _email = new EmailServiceSimple();

//    public void PlaceOrder()
//    {
//        Console.WriteLine("Pesanan sedang diproses ...");
//        _email.Send("Pesanan dikonfirmasi");
//    }
//}

//interface INotificationService
//{
//    void Send(string message);
//}

//class EmailNotification : INotificationService
//{
//    public void Send(string message) => Console.WriteLine("Email : " +  message);
//}

//class OrderService
//{
//    private readonly INotificationService _notif;
//    public OrderService(INotificationService notif)
//    {
//        _notif = notif;
//    }

//}
var processor = new PaymentProcess(new EmailNotifier());
CreditCardPayment creditcard = new CreditCardPayment();
BankTransferPayment bankTransfer = new BankTransferPayment();
EWalletPayment ewallet = new EWalletPayment();
processor.ProcessPayment(creditcard, 100000, "aaa@email.com");
processor.ProcessPayment(bankTransfer, 200000, "bbb@email.com");
processor.ProcessPayment(ewallet, 190000, "ccc@email.com");

public interface IPaymentService
{
    double CalculateAdminFee(double amount);
    void Process(double totalAmount);
}

public interface INotifier
{
    void SendReceipt(string customerEmail, double totalAmount);
}

class CreditCardPayment : IPaymentService
{
    public double CalculateAdminFee(double amount) => amount * 0.03;

    public void Process(double totalAmount)
    {
        Console.WriteLine($"[CC] Charging Rp{totalAmount} to credit card");
    }
}

class BankTransferPayment : IPaymentService
{
    public double CalculateAdminFee(double amount) => 5000;

    public void Process(double totalAmount)
    {
        Console.WriteLine($"[TF] Transferring Rp{totalAmount} via bank");
    }
}

class EWalletPayment : IPaymentService
{
    public double CalculateAdminFee(double amount) => amount * 0.01;

    public void Process(double totalAmount)
    {
        Console.WriteLine($"[EW] Deducting Rp{totalAmount} from e-wallet");
    }
}

class EmailNotifier : INotifier
{
    public void SendReceipt(string customerEmail, double amount)
    {
        Console.WriteLine($"[EMAIL] Receipt sent to {customerEmail}: Rp{amount}");
    }
}

public class PaymentProcess
{
    private readonly INotifier _notifier;

    public PaymentProcess(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void ProcessPayment(IPaymentService payment, double amount, string customerEmail)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount harus lebih dari 0!");
            return;
        }

        double totalAmount = amount + payment.CalculateAdminFee(amount);
        payment.Process(totalAmount);
        _notifier.SendReceipt(customerEmail, totalAmount);
    }
}




