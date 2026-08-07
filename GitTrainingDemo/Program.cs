using System;
using GitTrainingDemo.Services;

var userService = new UserService();
//Console.WriteLine(userService.Login("admin1", "124"));

var orderService = new OrderService();
//Console.WriteLine(orderService.GetFormattedPrice("Rp.", 100000));

var practiceService = new PracticeService();
//practiceService.run();

var cat = new Cat();

cat.Name = "Sone";
cat.Dance();