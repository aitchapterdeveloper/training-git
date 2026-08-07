using GitTrainingDemo.Services;
using System;


var userService = new UserService();
Console.WriteLine(userService.Login("admin", "12"));

var orderService = new OrderService();
Console.WriteLine(orderService.CalculateTotal(100000));

var SapaService = new SapaService(); 
SapaService.SapaNama("Rizal","Fahmi"); 
var calculate = new calculator();

Console.WriteLine(SapaService.GetGreeting("rizal", "tuban")); 

var cekNim = new cekNim();
Console.WriteLine(cekNim.CekNim(1234));
cekNim.cetakAngka(10);

var LatihanSatu = new LatihanSatu();
LatihanSatu.TampilkanNama();
LatihanSatu.belajarList();
LatihanSatu.belajarDictionary();

var product1 = new Product("Laptop", 12000000);

var product2 = new Product("Pensil", 12000000);
Console.WriteLine(product1.Name);
Console.WriteLine($"{product1.Name} : {product1.Price}");
Console.WriteLine(product2.Price);

BankAccount acc = new BankAccount();
acc.Balance = 10000;

Console.WriteLine("total balance "+ acc.Balance);

var cat = new Cat();
cat.Name = "Milo";
cat.Age = 3;
cat.Breathe();
cat.Scratch();

Console.WriteLine("total : "+calculate.Add(1,2,3,4));
Console.WriteLine("total : "+calculate.Add(1.5,2.5,3.5));




Circle circle = new Circle();

circle.Color = "Merah";
circle.Radius = 7;

circle.DisplayColor();
Console.WriteLine("Luas Circle: " + circle.CalculateArea());


Rectangle rectangle = new Rectangle();

rectangle.Color = "Biru";
rectangle.Width = 10;
rectangle.Height = 5;

rectangle.DisplayColor();
Console.WriteLine("Luas Rectangle: " + rectangle.CalculateArea());

Triangle triangle = new Triangle();
triangle.Color = "hijau";
triangle.Base = 10;
triangle.Height = 5;

triangle.DisplayColor();

Console.WriteLine("Luas triangle: " + triangle.CalculateArea());

public abstract class Shape
{
    public string Color { get; set; }


    public abstract double CalculateArea();

   
    public void DisplayColor()
    {
        Console.WriteLine("Color: " + Color);
    }
}


public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}