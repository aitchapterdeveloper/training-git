
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using GitTrainingDemo.Services;

List<int> numbers = new List<int> { 5, 12, 15, 7, 20, 18, 40, 70, 35, 55, 90, 80 };
List<int> result = new List<int>();



Console.WriteLine("tanpa linq");
foreach (int n in numbers)
{
    if (n > 10)
    {
        result.Add(n);
    }
}
foreach (int n in result)
{
    Console.WriteLine(n);
}




Console.WriteLine("dengan linq");
var resultLinq = from n in numbers
                 where n > 10
                 select n;

foreach (int n in resultLinq)
{
    Console.WriteLine(n);
}


//where
Console.WriteLine("dengan Wehere");
var filtered = numbers.Where(n => n > 10);

foreach (var i in filtered)
{
    Console.WriteLine(i);
}

//dengan orderby
Console.WriteLine("dengan order by");
var nums = numbers.OrderByDescending(n => n);

foreach (var num in nums)
{
    Console.WriteLine(num);
}

//select
Console.WriteLine("dengan select");
var newNums = numbers.Select(n => n * 2);

foreach (var newN in newNums)
{
    Console.WriteLine(newN);
}

//groupBy
Console.WriteLine("dengan group by");
var grouped = numbers.GroupBy(n => n % 2);
foreach (var groupN in grouped)
{
    Console.WriteLine("key:");
    Console.WriteLine(groupN);
}

//cek beberapa
Console.WriteLine("data");
var cekData = numbers.Where(n => n > 10).Select(n => n * 2).OrderBy(n => n);
foreach (var data in cekData)
{
    Console.WriteLine(data);
}


//cek beberapa tolist
Console.WriteLine("dengan tolist");
var CekData = numbers.Where(n => n > 1).Select(n => n * 2).OrderBy(n => n).ToList();
foreach (var data in CekData)
{
    Console.WriteLine(data);
}

//cek count
Console.WriteLine("count");
var Count = numbers.Count(n => n > 5);
Console.WriteLine(Count);


//sum
Console.WriteLine("sum data");
var SumData = numbers.Sum();
Console.WriteLine(SumData);

//average
Console.WriteLine("average data");
var AvgData = numbers.Average();
Console.WriteLine(AvgData);


//any
Console.WriteLine("any data");
var AnyData = numbers.Any(n => n > 20);
Console.WriteLine(AnyData);


//all
Console.WriteLine("all data");
var AllData = numbers.All(n => n > 10);
Console.WriteLine(AllData);

//defered
Console.WriteLine("defered eksekusi");
var query = numbers.Where(n => n > 10);
numbers.Add(20);
foreach (var r in query)
{
    Console.WriteLine(r);
}

//immediate
Console.WriteLine("immediate eksekusi");
var hasil = numbers.Where(n => n > 10).ToList();
numbers.Add(200);
foreach (var hsl in hasil)
{
    Console.WriteLine(hsl);
}




//async dan await
Console.WriteLine("async / await");

var resultAsync = await GetDataAsync(42);
Console.WriteLine(resultAsync);


async Task<string> GetDataAsync(int id)
{
    await Task.Delay(500);

    return $"Data untuk id: {id}";
}



//name
var resultNameAsync = await getNameAsync("rizal");
Console.WriteLine(resultNameAsync);

async Task<string> getNameAsync(string name)
{
    await Task.Delay(500);
    return $"Nama adalah: {name}";
}


//latihan
var resultGetUserName = await getUserNameAsync(12);
Console.WriteLine(resultGetUserName);

async Task<string> getUserNameAsync(int id)
{
    await Task.Delay(300);
    return $"user-{id}";
}



//soal latihan
async Task<String> DownloadFileAsync()
{
    await Task.Delay(2000);
    return "donwload berhasil";
}
async Task<String> CompressFileAsync()
{
    await Task.Delay(2000);
    return "donwload berhasil";
}
async Task<String> UploadFileAsync()
{
    await Task.Delay(2000);
    return "donwload berhasil";
}

string DownloadFileSync()
{
    Task.Delay(2000).Wait();
    return "download file";
}


string CompressFileSync()
{
    Task.Delay(2000).Wait();
    return "download file";
}


string UploadFileSync()
{
    Task.Delay(2000).Wait();
    return "download file";
}


//sync
var sw = Stopwatch.StartNew();

DownloadFileSync();
CompressFileSync();
UploadFileSync();

sw.Stop();

Console.WriteLine($"Sync  : {sw.ElapsedMilliseconds} ms");


//async
sw.Restart();

Task t1 = DownloadFileAsync();
Task t2 = CompressFileAsync();
Task t3 = UploadFileAsync();

await Task.WhenAll(t1, t2, t3);

sw.Stop();

Console.WriteLine($"Async : {sw.ElapsedMilliseconds} ms");


string test()
{
    return "halo";
}
Console.WriteLine(test());




//async all the way
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

var Data = await GetFormattedDataAsync(29);
Console.WriteLine(Data);



//program srp

var userService = new UserService();

var validator = new userValidator();
validator.Uservalidate("budi@gmail.com");

var repository = new userRepository();
repository.SaveToDatabase("budi@gmail.com");

var welcome = new WelcomeService();
welcome.sendWelcome("budi@gmail.com");




// Program ocp
double price = 100000;

IDiscount regular = new RegularDiscount();
Console.WriteLine($"Regular: {regular.Apply(price)}");

IDiscount vip = new VIPDiscount();
Console.WriteLine($"VIP: {vip.Apply(price)}");

IDiscount student = new StudentDiscount();
Console.WriteLine($"Student: {student.Apply(price)}");

IDiscount FlashSale = new FlashDiscount();
Console.WriteLine($"Flash sale: {FlashSale.Apply(price)}");


//lsp
Console.WriteLine($"rectangle: {new Rectangle { Width = 10, Height = 5 }.Area()}");

Console.WriteLine($"square: {new Square { Side = 5 }.Area()}");

//interface
Console.WriteLine("Hewan");
var cat = new Hewan();
cat.Eat();
cat.Sleep();

Console.WriteLine("human");
var human = new Human();
human.Eat();
human.Sleep();
human.Eat();



var email = new EmailServiceSimple();
var github = new GithubService(); 
var order = new OrderrService(github);

order.PlaceOrder();

//definiskan variable service di class nya
//baru panggil fungsi/method dari class nya
var service = new PaymentService();

service.ProcessPayment(
    new CreditCardPayment(),
    100000,
    "customer@email.com"
);
