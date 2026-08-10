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
            double total = CalculatePrice(price,customerAge);
            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");
            Console.WriteLine($"Order {orderId} confirmed � email terkirim ke {email}");
        }

        private double CalculatePrice(double price, int customerAge)
        {
            int legalAge = 17;
            double total = price;
            if (customerAge > legalAge) { total = applyTax(price); }
            total = ApplyDiscount(total);
            return total;
        }

        private double applyTax(double amount)
        {
            double taxRate = 0.21;
            return amount * (1 + taxRate);
        }

        private double ApplyDiscount(double amount)
        {
            double discountRate = 0.1;
            return amount * (1 - discountRate);
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