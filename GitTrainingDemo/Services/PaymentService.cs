using System;
using System.Collections.Generic;

namespace GitTrainingDemo.Services
{
    public interface IProcessPaymentType
    {
        void Pay(double amount);
        double GetAdminFee(double amount);
    }
    public interface IProcessPaymentFixedFeeType
    {
        void Pay(double amount);
        double GetAdminFee();
    }
    public interface IReceiptSender
    {
        void SendReceipt(double amount, string customerEmail);
    }
    public interface IProcessPayment
    {
        void Process(IProcessPaymentType processPaymentType, string customerEmail, double amount);
    }

    public class CreditCardPayment : IProcessPaymentType 
    {
        public double GetAdminFee(double amount)
        {
            double ADMIN_FEE = 0.03;

            return amount * ADMIN_FEE;
        }

        public void Pay (double amount)
        {
            double total = 0;
            
            total = amount + GetAdminFee(amount);

            Console.WriteLine($"[CC] Charging Rp{total} to credit card");
        }
    }

    public class BankTransferPayment : IProcessPaymentFixedFeeType
    {
        public double GetAdminFee()
        {
            double ADMIN_FEE_FIXED = 5000;
            return ADMIN_FEE_FIXED;
        }

        public void Pay (double amount)
        {
            double total = 0;

            total = amount + GetAdminFee();

            Console.WriteLine($"[TF] Transferring Rp{total} via bank");
        }
    }

    public class EWalletPayment : IProcessPaymentType
    {
        public double GetAdminFee(double amount)
        {
            double ADMIN_FEE = 0.01;

            return amount * ADMIN_FEE;
        }

        public void Pay (double amount)
        {
            double total = 0;
           
            total = amount + GetAdminFee(amount);

            Console.WriteLine($"[EW] Deducting Rp{total} from e-wallet");   
        }
    }

    public class EmailReceiptSender : IReceiptSender
    {
        public void SendReceipt(double amount, string customerEmail) => Console.WriteLine($"[EMAIL] Receipt sent to {customerEmail}: Rp{amount}");
    }

    public class ProcessPayment : IProcessPayment
    {
        private readonly IReceiptSender _receiptSender;

        public ProcessPayment (IReceiptSender receiptSender)
        {
            _receiptSender = receiptSender;
        }

        public void Process(IProcessPaymentType processPaymentType, string  customerEmail, double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount harus lebih dari 0!");
                return;
            }

            processPaymentType.Pay(amount);
        }
    }

}
