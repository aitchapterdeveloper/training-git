using System;
using System.Collections.Generic;
using GitTrainingDemo.Services;

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
linqService.PrintNumberListWithLINQ(list);

var listProcessed = linqService.ProcessListWithLINQ(list);
foreach (var n in listProcessed)
{
    Console.Write(n + ", ");
}
//linqService.PrintListAggregate(list);