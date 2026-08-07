using System;

namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            return price;
        }

        public string GetFormattedPrice(string currencyType, decimal price)
        {
            string formattedPrice = currencyType + price.ToString();
            Console.WriteLine(formattedPrice);
            return formattedPrice;
        }
    }
}
