using System;
using GitTrainingDemo.Services;

var userService = new UserService();
Console.WriteLine(userService.Login("admin", "1234"));

var orderService = new OrderService();
Console.WriteLine("Discounted total of 100000 = " + orderService.CalculateTotal(100000));

Console.WriteLine(orderService.GetGreeting("GrEetInGS          ", "John Pork")); 
orderService.GetFullNameGreeting("John", "Pork");