using System;
using System.Collections.Generic;

namespace GitTrainingDemo.Services
{
    public class PaymentService
    {
        public void ProcessPayment(string method, double amount, string customerEmail)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount harus lebih dari 0!");
                return;
            }

            CreditCardPayment c1 = new CreditCardPayment();
            BankPayment b1 = new BankPayment();
            EWalletPayment ew1 = new EWalletPayment();

            double adminFee = 0;
            if (method == "CreditCard")
            {
                adminFee = c1.GetAdminFee(amount);
            }
            else if (method == "BankTransfer")
            {
                adminFee = b1.GetAdminFee(amount);
            }
            else if (method == "EWallet")
            {
                adminFee = ew1.GetAdminFee(amount);
            }

            double total = amount + adminFee;

            if (method == "CreditCard")
            {
                c1.ChargePrint(total);
            }
            else if (method == "BankTransfer")
            {
                b1.ChargePrint(total);
            }
            else if (method == "EWallet")
            {
                ew1.ChargePrint(total);
            }
            Console.WriteLine($"[EMAIL] Receipt sent to {customerEmail}: Rp{total}");
        }
    }

    interface PaymentMethod
    {
        double GetAdminFee(double amount);
        void ChargePrint(double total);
    }
    class CreditCardPayment : PaymentMethod
    {
        public double GetAdminFee(double amount) => amount * 0.03;
        public void ChargePrint(double total) => $"[CC] Charging Rp{total} to credit card";
    }
    class BankPayment : PaymentMethod
    {
        public double GetAdminFee(double amount) => 5000;
        public void ChargePrint(double total) => $"[TF] Transferring Rp{total} via bank";
    }
    class EWalletPayment : PaymentMethod
    {
        public double GetAdminFee(double amount) => amount * 0.01;
        public void ChargePrint(double total) => $"[EW] Deducting Rp{total} from e-wallet";
    }


    interface IReceiptSender
    {
        void SendReceipt(string to, double total);
    }
    class EmailReceipt : IReceiptSender
    {
        public void SendReceipt(string to, double total)
            => Console.WriteLine($"[EMAIL] Receipt sent to {customerEmail}: Rp{total}");
    }
    class PaymentProcessor
    {
        private readonly IReceiptSender _receiptSender;
        private readonly IReceiptSender _paymentMethod;

        public PaymentProcessor(IReceiptSender receiptSender )
        {
            _receiptSender = receiptSender;
        }
        public void Process(IPaymentMethod payment, double amount, string email)
        {
            if (amount <= 0) { Console.WriteLine("Amount harus > 0"); return; }
            if(payment = "EWallet")
            {
                total = amount + _paymentMethod.GetAdminFeeEWallet(amount)
            } else if(payment = "Credit Card")
            {

            }

        }

    }
}
