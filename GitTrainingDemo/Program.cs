using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.XPath;
using GitTrainingDemo.Interfaces;
using GitTrainingDemo.Services;

// // var userService = new UserService();
// // Console.WriteLine(userService.Login("admin", "1"));
// // userService.IterateList();

// var orderService = new OrderService();
// Console.WriteLine(orderService.CalculateTotal(100000));
// orderService.setName("Ye");
// Console.WriteLine(orderService.GetGreetings("Slim Shady", "stand up"));
// // orderService.Greeting();
// // orderService.HitungLoop();
// orderService.ShowSubject();
// // var SapaService = new SapaService();
// // Console.WriteLine(SapaService.SapaNama("Rizal"));
// // Console.WriteLine(SapaService.GetGreetings("Rizal", "Fahmi"));
// orderService.FindVehicleByCode("C");
// orderService.FindVehicleByCode("EC");
// orderService.FindVehicleByCode("ZZ");

// var product = new Product(n: "Hp-Elitebook 9", p: 09.9m);
// product.ShowPrice();

// var account = new BankAccount(name: "Jackson", balance: 1000);
// account.balance = -100;
// Console.WriteLine(account.balance);
// account.balance = 1200;
// Console.WriteLine(account.balance);
// var meowth = new Cat("Meowth", 500);
// meowth.Purr();
// meowth.Eating();
// meowth.Scratch();

// Calculator calc = new Calculator();
// calc.Add(1, 2); // int version
// calc.Add(1.5, 2.5); // double version
// Console.WriteLine(calc.Add(1.5, 2.5, 2.5, 2.123, 1)); // double version
// calc.Add(1, 2, 3); // 3 param version
// calc.Add(1, 2, 3, 4, 5, 6); // 3 param version


// var fih = new Fish("Fih n chips", 200);
// fih.MakeSound();

// var triangle = new Triangle(12,5);
// Console.WriteLine(triangle.CalculateArea());

// List<int> funnyNumber = [67, 69420, 360];
// List<int> myList = InitiateList();
// PrintList(myList);

// Console.WriteLine("");
// foreach (var number in myList)
// {
//     if (funnyNumber.Contains(number))
//     {
//         Console.WriteLine($"{number} is a funny number");
//     }
// }

// var results =
//     from n in myList
//     // where funnyNumber.Contains(n)
//     select n;

// Console.WriteLine("Pakai LINQ COYYYYYYY");
// foreach (int result in results)
// {
//     Console.WriteLine($"{result} is a funny number");
// }

// Console.WriteLine("Grouping pakai LINQ");

// var groups = myList
//     .GroupBy(n => n % 2);
// var even = groups
//     .Where(g => g.Key == 0);
// var odd = groups
//     .Where(g => g.Key == 1);

// foreach (var i in odd)
// {
//     PrintList(i.ToList());
// }

// Console.WriteLine("Aggregate using LINQ");
// Console.WriteLine($"Sum : {myList.Sum()}");
// Console.WriteLine($"Avg : {myList.Average()}");
// Console.WriteLine($"Count : {myList.Count()}");
// Console.WriteLine($"Any 67 : {myList.Any(n => n == 67)}");
// Console.WriteLine($"is All Odd  : {myList.All(n => n % 2 == 1)}");

// DefferedTest(myList);
// ImmidiateTest(myList);
// Console.WriteLine("Starting fetch");
// var data = await GetListAsync();
// Console.WriteLine("After fetch");
// PrintList(data);
// Console.WriteLine("After printList");
// await VoidAsyncTestAsync();
// Console.WriteLine(await GetUserNameAsync(1));

// BatchProcess();
// await BatchProcessAsync();
// await GetUserEndpoint(67);

// var newUser = new UserManager(1);
// newUser.SaveUserData("Data");
// newUser.ValidateUser();
// newUser.SendEmail(12);

// var square = new Square();
// square.Width =5;
// square.Height =10;

// var rect = new Rectangle();
// rect.Height = 10;
// rect.Width = 5;

// var fixedSquare = new FixedSquare(5);
// var fixedRect= new FixedRectangle(5,10);

// Console.WriteLine($"{square.Area()}");
// Console.WriteLine($"{rect.Area()}");
// Console.WriteLine($"{fixedSquare.Area()}");
// Console.WriteLine($"{fixedRect.Area()}");

// var tyronne =new HumanWorker("Tyronne");
// tyronne.doWork();
// tyronne.eat();
// tyronne.sleep();

// var janeDoe = new UndeadWorker("Jane Doe");
// janeDoe.doWork();

var wa = new WhatsAppNotification();
var pigeon = new PigeonNotification();
var email = new EmailNotification();
var orderServiceEmail = new OrderService(email);
var orderServicePigeon = new OrderService(pigeon);
var orderServiceWa = new OrderService(wa);

var notif = new EmailNotification();
var paymentMethod = new BankTransfer();
var paymentService = new PaymentService(paymentMethod,notif); 
paymentService.ProcessPayment(6767676767,"Kenny");
// orderServiceEmail._notif.send("Noice");
// orderServicePigeon._notif.send("Noice");
// orderServiceWa._notif.send("Noice");


List<int> InitiateList()
{
    List<int> myList = [];
    var random = new Random();
    for (int i = 0; i < 100; i++)
    {
        myList.Add(random.Next(1000));
    }
    return myList;
}

void PrintList(List<int> list)
{
    foreach (int i in list)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}

void DefferedTest(List<int> query)
{
    Console.WriteLine("Deffered Execution");
    var result = query
        .Where(n => n % 2 == 0);

    Console.WriteLine("Before Adding: ");
    Console.WriteLine(result.Count());

    query.Add(200);
    Console.WriteLine("After adding to query");
    Console.WriteLine(result.Count());

}

void ImmidiateTest(List<int> query)
{
    Console.WriteLine("Immidiate Execution");
    var result = query
        .Where(n => n % 2 == 0)
        .ToList();

    Console.WriteLine("Before Adding: ");
    Console.WriteLine(result.Count());

    query.Add(200);
    Console.WriteLine("After adding to query");
    Console.WriteLine(result.Count());
}

async Task VoidAsyncTestAsync()
{
    try
    {
        await VoidAsync();
    }
    catch (NullReferenceException e)
    {
        Console.WriteLine(e);
    }
}
async Task VoidAsync()
{
    throw new NullReferenceException("AAA");
}

var x = GetListAsync().Result;
async Task<List<int>> GetListAsync()
{
    await Task.Delay(5000);
    return InitiateList();
}

async Task<string> GetUserNameAsync(int id)
{
    await Task.Delay(300);
    return $"User-{id}";
}

async Task DownloadAsync()
{
    Console.WriteLine("Downloading Asynchronously...");
    await Task.Delay(2000);
}

async Task UploadAsync()
{
    Console.WriteLine("Uploading Asynchronously...");
    await Task.Delay(2000);
}

async Task CompressAsync()
{
    Console.WriteLine("Compressing Asynchronously...");
    await Task.Delay(2000);
}

void Download()
{
    Console.WriteLine("Downloading..");
    Task.Delay(2000).Wait();
}


void Upload()
{
    Console.WriteLine("Uploading..");
    Task.Delay(2000).Wait();
}

void Compress()
{
    Console.WriteLine("Compressing..");
    Task.Delay(2000).Wait();
}

async Task BatchProcessAsync()
{
    var swSync = Stopwatch.StartNew();
    await Task.WhenAll(DownloadAsync(), UploadAsync(), CompressAsync());
    Console.WriteLine($"Total Async Batch Proccess Time : {swSync.ElapsedMilliseconds}");
}

void BatchProcess()
{
    var swSync = Stopwatch.StartNew();
    Download();
    Upload();
    Compress();
    Console.WriteLine($"Total Batch Proccess Time : {swSync.ElapsedMilliseconds}");
}

async Task<string> GetDataInternalAsync(int id)
{
    // Untuk library, ConfigureAwait(false)
    // menghindari penangkapan SynchronizationContext
    await Task.Delay(500).ConfigureAwait(false);
    return $"Data untuk id: {id}";
}

async Task<string> GetFormattedDataAsync(int id)
{
    var rawData = await GetDataInternalAsync(id);
    return $"Formatted: {rawData}";
}

async Task<string> GetUserEndpoint(int id)
{
    var data = await HashDataAsync(id);
    return $"Data for {id}: {data}";
}

async Task<string> HashDataAsync(int id)
{
    var data = await GetFormattedDataAsync(id);
    return "**************************";
}

