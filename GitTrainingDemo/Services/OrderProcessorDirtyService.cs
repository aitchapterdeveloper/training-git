using System;

namespace GitTrainingDemo.Services
{
    public class OrderProcessorDirtyService
    {
        //public string Name = "";
        //public string Email = "";
        public int MIN_CUSTOMER_AGE = 17;
        public double discount = 0.1;
        public double taxRate = 0.21;

        public bool IsCustomerMinAge(int customerAge)
        {
            if (customerAge <= MIN_CUSTOMER_AGE)
                return false;
            return true;
        }

        public double ApplyTax(double total, int customerAge)
        {
            if (IsCustomerMinAge(customerAge))
                return total + total * taxRate;
            return total;
        }

        public double ApplyDiscount(double total)
        {
            return total - total * discount;
        }

        public double TotalPayment(double price, int qty, int customerAge)
        {
            double totalAmount = price * qty;
            totalAmount = ApplyTax(totalAmount, customerAge);
            totalAmount = ApplyDiscount(totalAmount);
            return totalAmount;
        }

        public void PrintOrder(int orderId, double total, string customerEmail)
        {
            // Simpan
            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");

            // Kirim notifikasi
            Console.WriteLine($"Order {orderId} confirmed - email terkirim ke {customerEmail}");

            // Backup — tidak berhubungan dengan proses order
            Console.WriteLine("Backup database dijalankan...");
        }

        public void ValidatePriceQty(double price, int qty)
        {
            // Validasi
            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
            if (qty <= 0) throw new InvalidOperationException("Qty tidak valid");
        }

        public void Process(int orderId, double price, int qty, int customerAge, string customerName, string customerEmail)
        {
            ValidatePriceQty(price, qty);

            double total = 0;
            if (IsCustomerMinAge(customerAge))
            {
                discount = 0.21;
            }
            total = TotalPayment(price, qty, customerAge);
            PrintOrder(orderId, total, customerEmail);
        }
    }
}