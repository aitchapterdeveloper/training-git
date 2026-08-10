using System;

namespace GitTrainingDemo.Services
{

    //Large Class - Class terlalu besar
    public class OrderProcessorDirtyService
    {
        private const int adultAge = 17;
        private const double rateTax = 0.21;
        private const double discountRate = 0.1;


        public string Name;
        public string Email;

            public void Process(int orderId, double price, int qty, int customerAge)
            {
                ValidateInput(price, qty);
                double total = calculateTotal(price, qty, customerAge);
                SaveOrder(orderId, total);
                NotifOrder(orderId);
            }

            private void ValidateInput(double price, int qty)
            {
            if (price <= 0) 
                throw new InvalidOperationException("Harga tidak valid", nameof(price));
            if (qty <= 0) 
                throw new InvalidOperationException("Qty tidak valid", nameof(qty));
            }

            private double calculateTotal(double price, int qty, int customerAge) 
            {
                double total = price * qty;
                total = ApplyTax(total, customerAge);
                total = ApplyDiscount(total);
            if (customerAge > adultAge)
                {
                    total += total * rateTax;
                }
                total -= total * discountRate;
                return total;


            }

            private double ApplyTax(double total, int customerAge)
            {
                if (customerAge > adultAge)
                {
                total += total * rateTax;
                }
        }

            private double ApplyDiscount()
            {

            }



    }
}