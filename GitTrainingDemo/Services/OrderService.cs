using System;

namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            decimal discount = 0.9m;
            return Decimal.Multiply(price, discount);
        }

        public string GetGreeting(string greeting, string name)
        {
            greeting = greeting.Trim();
            return char.ToUpper(greeting[0]) + greeting.Substring(1).ToLower() + ", " + name + "!";
        }

        public void GetFullNameGreeting(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Hello, " + fullName + "!");
        }
    }
}
