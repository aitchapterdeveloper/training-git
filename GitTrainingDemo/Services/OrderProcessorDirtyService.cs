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
}