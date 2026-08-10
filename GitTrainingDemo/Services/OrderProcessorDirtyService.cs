using System;

namespace GitTrainingDemo.Services
{
    public class OrderProcessorDirtyService(string name, string email)
    {
        public string name = name;
        public string email = email;

        public void Process(int orderId, double price, int quantity, int customerAge)
        {
            ValidatePrice(price);
            ValidateQuantity(quantity);
            double total = price * quantity;
            int legalAge = 17;
            double taxRate = 0.21;
            double discountRate = 0.1;
            if (customerAge > legalAge)
            {
                total = total * taxRate + total;
            }
            total = total - (total * discountRate);
            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");
            Console.WriteLine($"Order {orderId} confirmed � email terkirim ke {email}");
        }

        void ValidatePrice(double price)
        {
            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
        }

        void ValidateQuantity(int quantity)
        {
            if (quantity <= 0) throw new InvalidOperationException("Qty tidak valid");
        }

    }
}