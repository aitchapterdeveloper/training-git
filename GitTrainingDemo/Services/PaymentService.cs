using System;
using System.Collections.Generic;
using GitTrainingDemo.Interfaces;
using GitTrainingDemo.Model;

namespace GitTrainingDemo.Services
{
    public class PaymentService
    {
        public void ProcessPayment(PaymentMethod method, double amount, string customerEmail)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount harus lebih dari 0!");
                return;
            }
            var payment = Create(method);

            double adminFee = payment.adminFee(amount);
            double total = amount + adminFee;

            Console.WriteLine(payment.NotificationMessage(total));

            Console.WriteLine($"[EMAIL] Receipt sent to {customerEmail}: Rp{total}");
        }

        public IPayment Create(PaymentMethod method)
        {
            if (method == PaymentMethod.CreditCard)
                return new CreditCard();

            else if (method == PaymentMethod.BankTransfer)
                return new BankTransfer();

            else if (method == PaymentMethod.EWallet)
                return new EWallet();
            else
            {
                return new Email();
            }
        }
    }

     public class CreditCard: IPayment
    {
        public double adminFee(double amount)
        {
            return amount * 0.03;
        }
        public string NotificationMessage(double total)
        {
            return $"[CC] Charging Rp{total} to credit card";
        }
    }
    public class BankTransfer : IPayment
    {
        public double adminFee(double amount)
        {
            return 5000;
        }
        public string NotificationMessage(double total)
        {
            return $"[TF] Transferring Rp{total} via bank";
        }
    }
    public class EWallet : IPayment
    {
        public double adminFee(double amount)
        {
            return amount * 0.01;
        }
        public string NotificationMessage(double total)
        {
            return $"[EW] Deducting Rp{total} from e-wallet";
        }
    }
    public class Email: IPayment
    {
        public double adminFee(double amount)
        {
            return 0;
        }
        public string NotificationMessage(string customerEmail, double total)
        {
            return $"[EMAIL] Receipt sent to {customerEmail}: Rp{total}";
        }
        public string NotificationMessage(double total)
        {
            return $"[EMAIL] Receipt sent to : Rp{total}";
        }
    }
}
