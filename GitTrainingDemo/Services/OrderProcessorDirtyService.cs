using System;

namespace GitTrainingDemo.Services
{
    public class OrderProcessorDirtyService
    {
        public string Name;
        public string Email;

        public double CalculateTotal(double price, int qty, int customerAge)
        {
            double total = price * qty;

            double CUSTOMER_AGE_VERIFICATION = 17;
            double TAX = 0.21;
            double DISCOUNT = 0.1;

            if (customerAge > CUSTOMER_AGE_VERIFICATION)
            {
                total = total * TAX + total;
            }
            total = total - (total * DISCOUNT);

            return total;
        }

        public void Process(int orderId, double price, int qty, int customerAge)
        {
            ValidateOrder.Validate(price, qty);
            
            double total = CalculateTotal(price, qty, customerAge);

            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");

            Console.WriteLine($"Order {orderId} confirmed — email terkirim ke {Email}");

            Console.WriteLine("Backup database dijalankan...");
        }
    }

    public class ValidateOrder
    {
        public static void Validate(double price, int qty)
        {
            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
            if (qty <= 0) throw new InvalidOperationException("Qty tidak valid");
        }
    }
}