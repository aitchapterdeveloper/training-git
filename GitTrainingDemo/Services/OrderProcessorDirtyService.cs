using System;
using System.Threading.Tasks;

namespace GitTrainingDemo.Services
{
    public class OrderProcessorDirtyService
    {
        public string Name;
        public string Email;
        private int BatasUmurDiskon = 17;
        private double Diskon = 0.21; //21%
        private double Pajak = 0.1; //10%
        public async Task Process(int orderId, double price, int qty, int customerAge)
        {
            // Validasi
            try
            {
                ValidateInput(price, qty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            var total = CalculateTotalPrice(price, qty, customerAge);
            // Simpan
            var save = Simpan(orderId, total);

            // Kirim notifikasi
            var sendNotification = SendNotification(orderId, "yoruem@gmail.com");

            // Backup — tidak berhubungan dengan proses order
            var backup = Backup(orderId);

            await Task.WhenAll(save, sendNotification, backup);
        }

        private void ValidateInput(double price, int qty)
        {
            if (price <= 0) throw new InvalidOperationException("Harga tidak valid");
            if (qty <= 0) throw new InvalidOperationException("Qty tidak valid");
        }

        private double CalculateTotalPrice(double price, int qty, int customerAge)
        {
            // Kalkulasi total
            double total = price * qty;

            if (customerAge > BatasUmurDiskon)
            {
                total = total * Diskon + total;
            }
            return total - (total * Pajak); // diskon 10%, duplikasi logika diskon
        }

        private async Task Simpan(int orderId, double total)
        {
            Console.WriteLine($"Order {orderId} disimpan dengan total {total}");
        }

        private async Task SendNotification(int orderId, string email)
        {
            Console.WriteLine($"Order {orderId} confirmed — email terkirim ke {email}");
        }

        private async Task Backup(int orderId)
        {
            Console.WriteLine("Backup database dijalankan...");
        }
    }
}