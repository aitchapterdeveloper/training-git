using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GitTrainingDemo.Services
{
    //Ubah ini jadi prinsip SOLID

    public interface IPaymentMethod
    {
        double AdminFee(double amount);
        void Pay(double total);
    }

    public interface IReceiptSender
    {
        public void SendReceipt(string email, double totalAmount);
    }

    public class EmailNotificationSend : IReceiptSender
    {
        public void SendReceipt(string email, double totalAmount)
        {
            Console.WriteLine($"[EMAIL] Receipt sent to {email}: Rp{totalAmount}");
        }
    }

    public class CreditPayment : IPaymentMethod
    {
        public double AdminFee(double amount) => amount * 0.03;
        public void Pay(double total) => Console.WriteLine($"[CC] Charging Rp{total} to credit card");
    }

    public class BankPayment : IPaymentMethod
    {
        public double AdminFee(double amount) => 5000;
        public void Pay(double total) => Console.WriteLine($"[TF] Transferring Rp{total} via bank");
    }

    public class EWalletPayment : IPaymentMethod
    {
        public double AdminFee(double amount) => amount * 0.01;
        public void Pay(double total) => Console.WriteLine($"[EW] Deducting Rp{total} from e-wallet");
    }

    public class TotalPayment
    {
        public double TotalPaymentProcess(double amount, double adminFee)
        {
            return amount + adminFee;
        }
    }

    public class PaymentValidator
    {
        public bool IsValid(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount harus lebih dari 0!");
                return false;
            }
            return true;
        }
    }

    public class PaymentService
    {
        private readonly IReceiptSender _receiptSender;
        private readonly PaymentValidator _validator;

        public PaymentService(PaymentValidator validator, IReceiptSender receiptSender)
        {
            _validator = validator;
            _receiptSender = receiptSender;
        }

        public void ProcessPayment(IPaymentMethod payment, double amount, string email)
        {
            if (!_validator.IsValid(amount)) return;

            double total = payment.AdminFee(amount);
            payment.Pay(total);

            _receiptSender.SendReceipt(email, total);
        }
    }
}
