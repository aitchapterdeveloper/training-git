using System;
using System.Collections.Generic;

namespace GitTrainingDemo.Services
{
    ISendNotification notification = new SendEmail();

    PaymentCreditCard paymentCreditCard = new PaymentCreditCard(notification, 100000, "fachri@gmail.com");
    paymentCreditCard.PlaceOrder();


    interface ISendNotification
    {
        void SendNotification(string message);
    }

    interface AdminFee
    {
        double CalculatePayment(double amount);
    }

    class SendWhatsApp : ISendNotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("WhatsApp: " + message);
        }
    }

    class SendEmail : ISendNotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }

    class CreditCard : AdminFee
    {
        public double CalculatePayment(double amount)
        {
            return amount + amount * 0.03;
        }
    }

    class BankTransfer : AdminFee
    {

        public double CalculatePayment(double amount)
        {
            return amount + 5000;
        }
    }

    class EWallet : AdminFee
    {
        public double CalculatePayment(double amount)
        {
            return amount + amount * 0.01;
        }
    }

    class PaymentCreditCard : CreditCard
    {
        private readonly CreditCard creditCard;
        private readonly ISendNotification _notification;
        string _customer;
        double _amount;
        double total;

        public PaymentCreditCard(ISendNotification notification, double amount, string customer)
        {
            creditCard = new CreditCard();
            _notification = notification;
            _amount = amount;
            _customer = customer;
            total = CalculatePayment(amount);
        }

        public void PlaceOrder()
        {
            _notification.SendNotification($"[EMAIL] Receipt sent to {_customer}: Rp{total}");
        }
    }

    class PaymentBankTransfer : BankTransfer
    {
        private readonly BankTransfer bankTransfer;
        private readonly ISendNotification _notification;
        string _customer;
        double _amount;
        double total;

        public PaymentBankTransfer(ISendNotification notification, double amount, string customer)
        {
            bankTransfer = new BankTransfer();
            _notification = notification;
            _amount = amount;
            _customer = customer;
            total = CalculatePayment(amount);
        }

        public void PlaceOrder()
        {
            _notification.SendNotification($"[EMAIL] Receipt sent to {_customer}: Rp{total}");
        }
    }

    class PaymentEWallet : EWallet
    {
        private readonly EWallet eWallet;
        private readonly ISendNotification _notification;
        string _customer;
        double _amount;
        double total;

        public PaymentEWallet(ISendNotification notification, double amount, string customer)
        {
            eWallet = new EWallet();
            _notification = notification;
            _amount = amount;
            _customer = customer;
            total = CalculatePayment(amount);
        }

        public void PlaceOrder()
        {
            _notification.SendNotification($"[EMAIL] Receipt sent to {_customer}: Rp{total}");
        }
    }
}
