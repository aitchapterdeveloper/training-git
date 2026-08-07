using System;
using System.Collections.Generic;

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

        public void GetNumberLoop (int n)
        {
            for (int i = 1; i <= n; i ++)
            {
                Console.WriteLine(i);
                i++;
            }
        }


        public void GetGoods(string goodCode)
        {
            Dictionary<string, string> goods = new Dictionary<string, string>();
        
            goods.Add("ATK-01", "Pensil");
            goods.Add("ATK-02", "Pulpen");
            goods.Add("ATK-03", "Penghapus");

            Console.WriteLine(goods.ContainsKey(goodCode) ? ("Ada " + goods[goodCode]) : ("Tidak ada " + goodCode));
        }
    }
}
