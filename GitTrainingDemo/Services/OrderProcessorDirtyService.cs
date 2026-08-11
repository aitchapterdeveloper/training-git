using System;

namespace GitTrainingDemo.Services
{
    public class OrderProcessorDirtyService
    {
        public string Name;
        public string Email;

        public void Process(int orderId, double price, int qty, int customerAge)
        {
            // Validasi
            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
            if (qty <= 0) throw new InvalidOperationException("Qty tidak valid");

            // Kalkulasi total
            double total = price * qty;

            // Magic number — diskon dan pajak tanpa nama jelas
            if (customerAge > 17)
            {
                total = total * 0.21 + total;
            }
            total = total - (total * 0.1); // diskon 10%, duplikasi logika diskon

            // Simpan
            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");

            // Kirim notifikasi
            Console.WriteLine($"Order {orderId} confirmed — email terkirim ke {Email}");

            // Backup — tidak berhubungan dengan proses order
            Console.WriteLine("Backup database dijalankan...");
        }
    }

    public class OrderProcessorClean
    {
        private const double TaxRate = 0.21;
        private const double DiscountRate = 0.10;
        private const int MinAdultAge = 17;

        public string Name;
        public string Email;

        public void Process(int orderId, double price, int qty, int customerAge)
        {
            Validate(price, qty);
            double total = CalculateTotal(price, qty, customerAge);
            SaveOrder(orderId, total);
            SendNotification(orderId);
        }

        private void Validate(double price, int qty)
        {
            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
            if (qty <= 0) throw new InvalidOperationException("Qty tidak valid");
        }

        private double CalculateTotal(double price, int qty, int customerAge)
        {
            double total = price * qty;
            double totalaftertax = ApplyTax(total, customerAge);
            double totalafterdisc = ApplyDiscount(totalaftertax);
            return totalafterdisc;
        }

        private double ApplyTax(double total, int customerAge)
        {
            if (customerAge > MinAdultAge)
                return total + (total * TaxRate);
            return total;
        }

        private double ApplyDiscount(double total)
        {
            return total - (total * DiscountRate);
        }

        private void SaveOrder(int orderId, double total)
        {
            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");
        }

        private void SendNotification(int orderId)
        {
            Console.WriteLine($"Order {orderId} confirmed — email terkirim ke {Email}");
        }
    }

}