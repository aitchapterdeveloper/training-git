using System;
using GitTrainingDemo.Interfaces;
using GitTrainingDemo.Services;

namespace GitTrainingDemo.Services
{
    public class PaymentRegular : IPayment
    {
        private readonly RegularDiscount regularDiscount = new RegularDiscount();
        public void Pay(double price)
        {
            double getDiscounted = regularDiscount.Apply(price);

            Console.WriteLine($"I pay {getDiscounted}!");
        }
    }

    public class PaymentVIP : IPayment
    {
        private readonly VIPDiscount vipDiscount = new VIPDiscount();
        public void Pay(double price)
        {
            double getDiscounted = vipDiscount.Apply(price);

            Console.WriteLine($"I pay {getDiscounted}!");
        }
    }
}