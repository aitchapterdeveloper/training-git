using System;
using System.Collections.Generic;
using GitTrainingDemo.Services;
using GitTrainingDemo.Model;

var userService = new UserService();
//Console.WriteLine(userService.Login("admin1", "124"));

var orderService = new OrderService();
//Console.WriteLine(orderService.GetFormattedPrice("Rp.", 100000));

var practiceService = new PracticeService();
//practiceService.run();

var cat = new Cat();
var dog = new Dog();
var circle = new Circle(7);
//cat.Name = "Sone";
//cat.Dance();
//cat.Breathe();
//dog.Breathe();
//dog.Step();

//Console.WriteLine(circle.CalculateArea());

//Day 2

var linqService = new LINQService();

List<int> list = new List<int> { 3, 15, 7, 22, 9, 18, 56, 4, 11};

//linqService.PrintNumberList(list);

var listProcessed = linqService.ProcessListWithLINQ(list);
//foreach (var n in listProcessed)
//{
//    Console.Write(n + ", ");
//}
//linqService.PrintNumberListWithLINQ(list);
//linqService.PrintListAggregate(list);

var asyncService = new AsyncService();

//var result = await asyncService.GetDataAsync(listProcessed.Count);

//Console.WriteLine(result);

//var syncTime = asyncService.stopwatchSync();
//var asyncTime =  await asyncService.stopwatchAsync();

//Console.WriteLine($"Synchronous task takes: {syncTime}ms");
//Console.WriteLine($"Asynchronous task takes: {asyncTime}ms");

var rectangle = new Rectangle(4, 7);

Console.WriteLine(rectangle.Area());

