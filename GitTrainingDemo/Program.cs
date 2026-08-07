using GitTrainingDemo.Services;

var userService = new UserService();
Console.WriteLine(userService.Login("admin", "1234"));

var orderService = new OrderService();
Console.WriteLine(orderService.CalculateTotal(100000));

var SapaService = new SapaService();
Console.WriteLine(SapaService.SapaNama("Rizal"));