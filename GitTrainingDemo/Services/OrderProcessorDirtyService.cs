using System;

namespace GitTrainingDemo.Services
{
    public class OrderProcessorDirtyService
    {
        private int Calculation(int price, int qty)
        {
            // Validasi
            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
            if (qty <= 0) throw new InvalidOperationException("Qty tidak valid");

            // Kalkulasi total
            double total = price * qty;
            return total;
        }

        {
        }
            total = total - (total * 0.1); // diskon 10%, duplikasi logika diskon

            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");

            // Kirim notifikasi
            Console.WriteLine($"Order {orderId} confirmed — email terkirim ke {Email}");

            // Backup — tidak berhubungan dengan proses order
            Console.WriteLine("Backup database dijalankan...");
        }
    }

        {

        public string Name;
        public string Email;

        public void Process(int orderId, double price, int qty, int customerAge)
        {

            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
            if (qty <= 0) throw new InvalidOperationException("Qty tidak valid");


        private double ApplyTax(double total, int customerAge)
        {
            if (customerAge > MinAdultAge)
                return total + (total * TaxRate);
            return total;
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