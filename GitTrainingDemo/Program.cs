using System;
using System.Diagnostics;
using System.Threading.Tasks;   
using System.Collections.Generic;
using GitTrainingDemo.Services;
using GitTrainingDemo.Object;
using System.Linq;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

/*var userService = new UserService();
//Console.WriteLine(userService.Login("admin", "24"));

var orderService = new OrderService();


Console.WriteLine(OrderService.GetKategoriTiket(8));
Console.WriteLine(OrderService.GetKategoriTiket(17));
Console.WriteLine(OrderService.GetKategoriTiket(30));
Console.WriteLine(OrderService.GetKategoriTiket(65));

Console.WriteLine(OrderService.GetStatusFilm17(8));
Console.WriteLine(OrderService.GetStatusFilm17(17));
Console.WriteLine(OrderService.GetStatusFilm17(30));
Console.WriteLine(OrderService.GetStatusFilm17(65));
//Console.WriteLine(orderService.CalculateTotal(100000));

Dictionary<string, int> hargaBarang = new Dictionary<string, int>();

hargaBarang.Add("Air Mineral", 3500);
hargaBarang.Add("Roti", 12000);
hargaBarang.Add("Kopi", 8000);

List<string> keranjang = new List<string>();
keranjang.Add("Roti");
keranjang.Add("Kopi");
keranjang.Add("Roti");
keranjang.Add("Air Mineral");

int total = 0;

foreach(string k in keranjang)
{
    total = total + hargaBarang[k];
}

Console.WriteLine("Total Belanja: Rp" + total);

keranjang.Add("Teh");
int total2 = 0;
foreach (string k in keranjang)
{
    if (hargaBarang.ContainsKey(k))
    {
        total2 = total2 + hargaBarang[k];
    } else
    {
        Console.WriteLine(k + " Tidak Dijual");
    }
}

Console.WriteLine("Total Belanja Setelah Teh: Rp" + total);

Student student = new Student("Budi", 12);

GitTrainingDemo.Object.Product product = new GitTrainingDemo.Object.Product("Pensil", 3000, 10);
Console.WriteLine("Product Stock 1: " + product.Stock);

product.Stock = -5;
Console.WriteLine("Product Stock 2: " + product.Stock);

List<int> angka = new List<int> { 1, 2, 3, };
Console.WriteLine(angka.Sum());

List<Kendaraan> listKendaraan = new List<Kendaraan>();
Kendaraan kendaraan = new Kendaraan();
kendaraan.PlatNomor = "DK432P";
Mobil mobil = new Mobil();
mobil.PlatNomor = "B232DK";
Motor motor = new Motor();
motor.PlatNomor = "D3245L";

listKendaraan.Add(kendaraan);
listKendaraan.Add(motor);
listKendaraan.Add(mobil);

foreach(Kendaraan k in listKendaraan)
{
    Console.WriteLine(k.PlatNomor + ": " + k.HitungBiayaParkir(3));
}

List<Ticket> listTickets = new List<Ticket>();

TiketReguler tiket1 = new TiketReguler("Jurassic");
TiketReguler tiket2 = new TiketReguler("Park");
TiketVip tiket3 = new TiketVip("Avengers");

listTickets.Add(tiket1);
listTickets.Add(tiket2);
listTickets.Add(tiket3);

int totalHargaTiket = 0;
foreach(Ticket t in listTickets)
{
    Console.WriteLine(t.NamaFilm + " :" + t.HitungHarga());
    totalHargaTiket = totalHargaTiket + t.HitungHarga();
}

int hargaSetelahDiskon = 0;
Console.WriteLine("Total Harga Tiket: " + totalHargaTiket);
if (totalHargaTiket > 150000)
{
    hargaSetelahDiskon = totalHargaTiket * 90 / 100;
}
Console.WriteLine("Total Harga Tiket Setelah Diskon: " + hargaSetelahDiskon);

var day3Services = new Day3Services();
*//*day3Services.linq(new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 50,51,53 });
*/

/*day3Services.tesAggregate(new List<int>() { 2, 6, 4 });
*//*
List<int> prices = new List<int> { 25000, 120000, 8000, 56000, 210000, 15000, 99000 };
day3Services.linq(prices);

await day3Services.GetUserEndpoint(2);
string infoFilm = await day3Services.GetInfoFilmAsync(7);
Console.WriteLine("Info Film: " + infoFilm);

Console.WriteLine("");
var orderServiceWA = new OrderService2(new WhatsAppNotification());
orderServiceWA.sendMessage("Ini message");

var orderServiceEmail = new OrderService2(new EmailNotification());
orderServiceEmail.sendMessage("Ini message");*/

//Console.WriteLine(orderService.GetGreeting("Vincent", "Jakarta"));
//orderService.GetGreetingReturn("Vincent", "Bandung");

//orderService.ForLoop();
//orderService.ForEachLoop();

//orderService.SubjectList();

//orderService.DictionaryTransportasi("BCK001");

//Product p1 = new Product("Laptop", 10000000);
//Console.WriteLine(p1.Price);

//var detail = new DetailOrder();
//detail.GetGreetingReturn("Vincent", "Jakarta");

//Cat c1 = new Cat();
//c1.Name = "Evee";
//c1.Age = 6;
//c1.Breed = "Persia";
//c1.MakeSound();
//c1.Breathe();

//var calculator = new Calculator();
//Console.WriteLine(calculator.Add(5.01, 10.67, 7.44));

//var animalMakeSound = new MakeAnimalSound();
//animalMakeSound.MakeSound();

//Triangle t1 = new Triangle();
//t1.baseLength = 5;
//t1.height = 10;
//Console.WriteLine("Area of Triangle is " + t1.CalculateArea());
//t1.Color = "Red";
//t1.DisplayColor();








//DAY 2 .NET TRAINING - C# Intermediate and Clean Code

//List<int> lists = new List<int>{1, 3, 5, 7, 9, 10, 11, 15, 19, 22, 27, 30, 36, 42};
//List<int> result = new List<int>();

//Console.WriteLine("Using foreach loop");
//foreach (var n in lists)
//{
//    if (n > 10) result.Add(n);
//}

//foreach (var n in result)
//{
//    Console.WriteLine(n);
//}


//Console.WriteLine("Using LINQ");
//var listWithLINQ =
//    from n in lists
//    where n > 10
//    select n;

//foreach (var n in listWithLINQ)
//{
//    Console.WriteLine(n);
//}

//Console.WriteLine("Using LINQ Method Syntax");
//var listWithLINQMethodSyntax = lists
//    .Where(n => n > 11)
//    .OrderByDescending(n => n)
//    .GroupBy(n => n % 2)
//    .Select(n => new {GroupName = n.Key == 0 ? "Even" : "Odd", Items = n});

//foreach (var group in listWithLINQMethodSyntax)
//{
//    Console.WriteLine("Group Key: " + group.GroupName);
//    foreach (var n in group.Items)
//    {
//        Console.WriteLine(n);
//    }
//}

//var nums = lists;
//Console.WriteLine("Count lists: " + nums.Count(n => n > 10));
//Console.WriteLine("Sum lists: " + nums.Sum());
//Console.WriteLine("Average lists: " + nums.Average());
//Console.WriteLine("Check if there is 10 in Lists: " + nums.Any(n => n == 10));
//Console.WriteLine("Check all if num negative: " + nums.All(n=> n < 0));

//Console.WriteLine("Immediate Execution:");
//var ImmediateExecution = lists
//    .Where(n => n >= 36)
//    .ToList(); // Immediate Execution, the query is executed immediately and the result is stored in a list
//lists.Add(77);

//foreach (var n in ImmediateExecution)
//{
//    Console.WriteLine(n);
//}

//var DeferredExecution = lists
//    .Where(n => n >= 36)
//    .Select(n => n);
//lists.Add(69);

//Console.WriteLine("Deferred Execution:");
//foreach (var n in DeferredExecution)
//{
//    Console.WriteLine(n);
//}

//// Pemanggilan
//var resultAsyncDemo = await GetDataAsync(42);
//Console.WriteLine(resultAsyncDemo);

//async Task<string> GetDataAsync(int id)
//{
//    // Simulate an asynchronous operation
//    await Task.Delay(5000); // Simulate a delay of 5 second
//    return $"Data for ID: {id}";
//}

//var resultAsyncDemo2 = await GetUserID(109090);
//Console.WriteLine(resultAsyncDemo2);

//async Task<string> GetUserID(int id)
//{
//    await Task.Delay(300);
//    return $"User ID: {id}";
//}


//var swSync = Stopwatch.StartNew();
//var download = await Download(1);
//Console.WriteLine(download);
//var compress = await Compress(1);
//Console.WriteLine(compress);
//var upload = await Upload(1);
//Console.WriteLine(upload);

//async Task<string> Download(int id)
//{
//    await Task.Delay(2000);
//    return $"Download File for ID: {id}";
//}
//async Task<string> Compress(int id)
//{
//    await Task.Delay(2000);
//    return $"Compress File for ID: {id}";
//}
//async Task<string> Upload(int id)
//{
//    await Task.Delay(2000);
//    return $"Upload File for ID: {id}";
//}

//swSync.Stop();
//Console.WriteLine($"Total waktu SYNC: {swSync.ElapsedMilliseconds}ms");


//var swSync = Stopwatch.StartNew();
//Task t1 = Download(1);
//Task t2 = Compress(1);
//Task t3 = Upload(1);

//await Task.WhenAll(t1, t2, t3);
//Console.WriteLine($"Total waktu SYNC: {swSync.ElapsedMilliseconds}ms");


//async Task<string> Download(int id)
//{
//    await Task.Delay(2000);
//    return $"Download File for ID: {id}";
//}
//async Task<string> Compress(int id)
//{
//    await Task.Delay(2000);
//    return $"Compress File for ID: {id}";
//}
//async Task<string> Upload(int id)
//{
//    await Task.Delay(2000);
//    return $"Upload File for ID: {id}";
//}
//swSync.Stop();
//Console.WriteLine($"Total waktu SYNC: {swSync.ElapsedMilliseconds}ms");

//var swSync = Stopwatch.StartNew();
//string data = await GetBebas(102);
//Console.WriteLine(data);

//async Task<string> GetDataAsyncWaw(int id)
//{
//    await Task.Delay(500).ConfigureAwait(false);
//    return "Data dari ASYNC";
//}
//async Task<string> GetFormattedDataAsyncWaw(int id)
//{
//    var rawData = await GetDataAsyncWaw(id);
//    return $"Formatted: {rawData} | ";
//}

//async Task<string> GetUserEndPointWaw(int id)
//{
//    var data = await GetFormattedDataAsyncWaw(id);
//    return $"User EndPoint: {data} = ";
//}

//async Task<string> GetBebas(int id)
//{
//    var bebas = await GetUserEndPointWaw(id);
//    return $"Bebas: {bebas} )(*&^%$#@!";
//}

//swSync.Stop();
//Console.WriteLine($"Total waktu SYNC: {swSync.ElapsedMilliseconds}ms");




//var validator = new UserValidator();
//var repository = new UserRepository();
//var emailService = new EmailService();

//validator.ValidateUser("buahbf@email.com");
//repository.SaveUserToDatabase("buahbf@email.com");
//emailService.WelcomeEmail("buahbf@email.com");

//public class UserValidator
//{
//    public void ValidateUser(string email)
//    {
//        Console.WriteLine($"Validating user with email: {email}");
//    }
//}
//public class UserRepository
//{
//    public void SaveUserToDatabase(string email)
//    {
//        Console.WriteLine($"Saving user with email: {email} to database");
//    }
//}
//public class EmailService
//{
//    public void WelcomeEmail(string email)
//    {
//        Console.WriteLine($"Sending welcome email to: {email}");
//    }
//}



//double harga = 6769;
//IDiscount regular = new RegularDiscount();
//Console.WriteLine($"Harga Asli: {harga}");

//IDiscount VIP = new VIPDiscount();
//Console.WriteLine($"Harga VIP: {VIP.Apply(harga)}");

//IDiscount VVIP = new VVIPDiscount();
//Console.WriteLine($"Harga VVIP: {VVIP.Apply(harga)}");

//interface IDiscount
//{
//    double Apply(double price);
//}
//class RegularDiscount : IDiscount
//{
//    public double Apply(double price)
//    => price * 0.9;
//}
//class VIPDiscount : IDiscount
//{
//    public double Apply(double price)
//    => price * 0.8;
//}

//class VVIPDiscount : IDiscount
//{
//    public double Apply(double price)
//    => price * 0.7;
//}




//var shapers = new Rectangle();
//shapers.Width = 10;
//shapers.Height = 5;
//Console.WriteLine($"Rectangle Area: {shapers.Area()}");

//var shapersSquare = new Square();
//shapersSquare.Side = 10;
//Console.WriteLine($"Square Area: {shapersSquare.Area()}");

//var shapersTriangle = new Triangle();
//shapersTriangle.Width = 3;
//shapersTriangle.Height = 5;
//Console.WriteLine($"Triangle Area: {shapersTriangle.Area()}");

//var shapersSquareBroken = new SquareBroke();
//shapersSquareBroken.Width = 5;
//Console.WriteLine($"Broken Square: {shapersSquareBroken.Area()}");

//interface IShape
//{
//    double Area();
//}
//class Rectangle : IShape
//{
//    public virtual double Width { get; set; }
//    public virtual double Height { get; set; }
//    public double Area() => Width * Height;
//}
//class Square : IShape
//{
//    public double Side { get; set; }
//    public double Area() => Side * Side;
//}
//class Triangle : IShape 
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//    public double Area() => 0.5 * Width * Height;
//}
//class SquareBroke : Rectangle
//{
//    public override double Width
//    {
//        set {base.Width = base.Height = value; }
//    }
//}



//var batman = new Bat();
//Console.WriteLine(batman.Echolocate());

//interface Echolocation { string Echolocate(); }
//interface Eater { void Eating(); }
//interface Sleeper { void Sleeping(); }
//interface Worker { void Working(); }

//class Bat : Echolocation//, Eater, Sleeper
//{
//    public string Echolocate() => "ECHO";
//    //public void Eating();
//    //public void Sleeping();
//}

//class Human : Eater, Sleeper, Worker
//{
//    public void Eating();
//    public void Sleeping();
//    public void Working();
//}

//var Email = new SMSServiceSimple();
//Email.Send("Bail@email.com");

//interface iNotificationService
//{
//    void Send(string message);
//}

//class EmailServiceSimple : iNotificationService
//{
//    public void Send(string message) => Console.WriteLine("Email: "+message);
//}

//class SMSServiceSimple : iNotificationService
//{
//    public void Send(string message) => Console.WriteLine("SMS: " + message);
//}

//class OrderService
//{
//    private EmailServiceSimple _email = new EmailServiceSimple();

//    public void PlaceOrder()
//    {
//        Console.WriteLine("Process Order...");
//        _email.Send("Order Confirmed");

//    }
//}

DiscountService discountService = new DiscountService(new DiscountMemberRegular());
discountService.calculateDiscount(20000);

var order = new TicketOrderManager
{
    CustomerName = "Budi Santoso",
    CustomerEmail = "budi@example.com",
    CustomerAge = 25,
    MemberType = "VIP"
};
order.Movies.Add("Avengers: Legacy");
order.Prices.Add(50000);
order.Qtys.Add(2);

order.Movies.Add("Laut Bercerita");
order.Prices.Add(45000);
order.Qtys.Add(1);

order.ProsesOrder();


/*using System;
using System.Collections.Generic;*/


// TODO (peserta): tulis di sini semua code smell yang kamu temukan
//Validasi
// Duplicate code di ProsesOrder dan HitungDiskonUntukPreview
// Long Method -> ProsesOrder()
// Magic Number -> 0.1, 0.2, 0.15, 17, 0.11, 0.15
// Naming Buruk => double x = 0; double d = 0; double total = x - d; bool flag = false; 
class TicketOrderManager
    {
        public string CustomerName;
        public string CustomerEmail;
        public int CustomerAge;
        public string MemberType; // "Regular", "VIP", "Student"
        public List<string> Movies = new List<string>();
        public List<double> Prices = new List<double>();
        public List<int> Qtys = new List<int>();

        public void validate()
        {
            if (string.IsNullOrEmpty(CustomerName)) throw new Exception("Nama wajib diisi");
            if (string.IsNullOrEmpty(CustomerEmail)) throw new Exception("Email wajib diisi");
            if (Movies.Count == 0) throw new Exception("Minimal 1 tiket");
        }

        public double calculateSubtotalBeforeDisc()
        {
            double totalPriceBeforeDisc = 0;
            for (int i = 0; i < Movies.Count; i++)
            {
                totalPriceBeforeDisc += Prices[i] * Qtys[i];
            }
            return totalPriceBeforeDisc;
        }


        public double calculateDiscount(double totalPriceBeforeDisc)
        {
            double TARIF_DISKON_REGULAR = 0.1;
            double TARIF_DISKON_VIP = 0.2;
            double TARIF_DISKON_STUDENT = 0.15;

            double diskon = 0;
            if (MemberType == "Regular")
            {
                diskon = totalPriceBeforeDisc * TARIF_DISKON_REGULAR;
            }
            else if (MemberType == "VIP")
            {
                diskon = totalPriceBeforeDisc * TARIF_DISKON_VIP;
            }
            else if (MemberType == "Student")
            {
                diskon = totalPriceBeforeDisc * TARIF_DISKON_STUDENT;
            }
            return diskon;
        }

        public void calculateTax(double totalPriceAfterDisc)
        {
            int MIN_AGE = 17;
            double TAX_RATE = 0.11;
            if (CustomerAge > MIN_AGE)
            {
                totalPriceAfterDisc = totalPriceAfterDisc + (totalPriceAfterDisc * TAX_RATE);
            }
        }

        public void saveToDB(double totalPriceAfterDisc)
        {
            Console.WriteLine("Menyimpan order untuk " + CustomerName + " total: " + totalPriceAfterDisc);
        }

        public void sendEmail(double totalPriceAfterDisc)
        {
            Console.WriteLine("Mengirim email ke " + CustomerEmail + ": Order Anda sebesar " + totalPriceAfterDisc + " telah dikonfirmasi.");
        }

        public void printLogAudit()
        {
            Console.WriteLine("[AUDIT] " + DateTime.Now + " - Order dibuat untuk " + CustomerName);

            // generate laporan harian
            Console.WriteLine("Laporan: " + Movies.Count + " tiket terjual hari ini.");
        }

        public void ProsesOrder()
        {
            // validasi
            validate();

            // hitung subtotal
            double totalPriceBeforeDisc = calculateSubtotalBeforeDisc();

            // hitung diskon member
            double diskon = calculateDiscount(totalPriceBeforeDisc);
            double totalPriceAfterDisc = totalPriceBeforeDisc - diskon;

            // pajak untuk pelanggan dewasa
            calculateTax(totalPriceAfterDisc);

            // simpan ke "database" (simulasi)
            saveToDB(totalPriceAfterDisc);

            // kirim email
            sendEmail(totalPriceAfterDisc);

            // log audit
            printLogAudit();
        }

        // method terpisah untuk preview diskon di halaman keranjang,
        // logikanya copy-paste dari ProsesOrder
        public double HitungDiskonUntukPreview(double subtotal, string memberType)
        {
            double disc = 0;
            /*if (memberType == "Regular") disc = subtotal * 0.1;
            else if (memberType == "VIP") disc = subtotal * 0.2;
            else if (memberType == "Student") disc = subtotal * 0.15;*/

            disc = calculateDiscount(subtotal);

            return disc;
        }

        // cek apakah order boleh diproses lebih lanjut ke tahap pembayaran
        public bool CekStatus()
        {
            bool isQualified = false;
            if (Movies.Count > 0 && !string.IsNullOrEmpty(CustomerEmail))
            {
                isQualified = true;
            }
            return isQualified;
        }
    }





























