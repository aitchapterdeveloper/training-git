using System;
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

Console.WriteLine(circle.CalculateArea());