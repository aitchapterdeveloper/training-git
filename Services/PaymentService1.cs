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

            double adminFee = 0;
            if (method == "CreditCard")
                adminFee = amount * 0.03;
            else if (method == "BankTransfer")
                adminFee = 5000;
            else if (method == "EWallet")
                adminFee = amount * 0.01;

            double total = amount + adminFee;

            if (method == "CreditCard")
                Console.WriteLine($"[CC] Charging Rp{total} to credit card");
            else if (method == "BankTransfer")
                Console.WriteLine($"[TF] Transferring Rp{total} via bank");
            else if (method == "EWallet")
                Console.WriteLine($"[EW] Deducting Rp{total} from e-wallet");

            Console.WriteLine($"[EMAIL] Receipt sent to {customerEmail}: Rp{total}");
        }
    }


        public interface IPaymentMethod
        {
            double GetAdminFee(double amount);
            void Process(double totalAmount);
        }

        public class CreditCard : IPaymentMethod
        {
            public double GetAdminFee(double amount) => amount * 0.03;

            public void Process(double totalAmount) =>
                Console.WriteLine($"[CC] Charging Rp{totalAmount} to credit card");
        }

        public class BankTransfer : IPaymentMethod
        {
            public double GetAdminFee(double amount) => 5000;

            public void Process(double totalAmount) =>
                Console.WriteLine($"[TF] Transferring Rp{totalAmount} via bank");
        }

        public class EWallet : IPaymentMethod
        {
            public double GetAdminFee(double amount) => amount * 0.01;

            public void Process(double totalAmount) =>
                Console.WriteLine($"[EW] Deducting Rp{totalAmount} from e-wallet");
        }

        public class PaymentService
        {
            public void ProcessPayment(IPaymentMethod method, double amount, string email)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Amount harus lebih dari 0!");
                    return;
                }

                double total = amount + method.GetAdminFee(amount);

                method.Process(total);
                Console.WriteLine($"[EMAIL] Receipt sent to {email}: Rp{total}");
            }
        }
    }

//--New
var processor = new PaymentProcessor(new EmailReceiptSender());
CreditCardPayment ccmethod = new CreditCardPayment();
processor.Process(ccmethod, 500000, "budi@email.com");
processor.Process(new EWalletPayment(), 100000, "ani@email.com");
processor.Process(new EWalletPayment(), -100000, "ani@email.com");

interface IPaymentMethod
{
    double GetAdminFee(double amount);
    void Pay(double total);
}

class CreditCardPayment : IPaymentMethod
{
    public double GetAdminFee(double amount) => amount * 0.03;
    public void Pay(double total)
    {
        Console.WriteLine($"[CC] Charging Rp{total} to credit card");
    }
}

class bankTransferPayment : IPaymentMethod
{
    public double GetAdminFee(double amount) => 5000;
    public void Pay(double total)
    {
        Console.WriteLine($"[TF] Transferring Rp{total} via bank");
    }
}

class EWalletPayment : IPaymentMethod
{
    public double GetAdminFee(double amount) => amount * 0.01;
    public void Pay(double total)
    {
        Console.WriteLine($"[EW] Deducting Rp{total} from e-wallet");
    }
}

interface IReceiptSender
{
    void SendReceipt(string email, double amount);
}

class EmailReceiptSender : IReceiptSender
{
    public void SendReceipt(string email, double amount)
    {
        Console.WriteLine($"[EMAIL] Receipt sent to {email}: Rp{amount}");
    }
}

class PaymentProcessor
{
    private readonly IReceiptSender _receiptSender;

    public PaymentProcessor(IReceiptSender receiptSender)
    {
        _receiptSender = receiptSender;
    }
    public void Process(IPaymentMethod paymentMethod, double amount, string email)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount harus lebih dari 0!");
            return;
        }
        double total = amount + paymentMethod.GetAdminFee(amount);
        paymentMethod.Pay(total);
        _notificationService.SendReceipt(email, total);
    }
}
}