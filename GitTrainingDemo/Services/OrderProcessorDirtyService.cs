using System;

namespace GitTrainingDemo.Services
{
    public class OrderProcessorDirtyService
    {
        private int Calculation(int price, int qty)
        {
            double total = price * qty;
            return total;
        }

        private double TaxCalculation(double price, int age,double tax)
        {
            if (age > 17)
            {
                double totalAfterTax = price * tax + price;
                return totalAfterTax;
            } return price;
        }

        private double TenPercentDiscountCalculation(double price)
        {
            double totalAfterDiscount = price - price * 0.1;
            return totalAfterDiscount;
        }

        private string SaveToDatabase(int orderId, double total)
        {
            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");
        }

        private string EmailNotification(int orderId, double total, string email)
        {
            Console.WriteLine($"Order {orderId} confirmed — email terkirim ke {email}");
        }

        public string Name;
        public string Email;

        public void Process(int orderId, double price, int qty, int customerAge)
        {
            int ageLimit = 17;
            double tax = 0.21;

            OrderProcessorDirtyService o1 = new OrderProcessorDirtyService();
            // Validasi
            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
            if (qty <= 0) throw new InvalidOperationException("Qty tidak valid");

            // Kalkulasi total
            double finalPrice = o1.Calculation(price, qty);

            // Magic number — diskon dan pajak tanpa nama jelas
            o1.TaxCalculation(finalPrice, customerAge, tax);
            finalPrice = o1.TenPercentDiscountCalculation(finalPrice); // diskon 10%, duplikasi logika diskon

            o1.SaveToDatabase(orderId, finalPrice);
            o1.EmailNotification(orderId, finalPrice, Email);


            // Backup — tidak berhubungan dengan proses order
            Console.WriteLine("Backup database dijalankan...");


        }
    }
}