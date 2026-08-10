using System;
using GitTrainingDemo.Interfaces;

namespace GitTrainingDemo.Services
{

    class PaymentService(IPaymentMethod paymentMethod, INotification notif)
    {
        private IPaymentMethod _paymentMethod = paymentMethod;
        private INotification _notif = notif;

        public void ProcessPayment(double amount, string customerEmail)
        {
            if (!ValidateAmount(amount)) return;
            double total = _paymentMethod.CalculateTotal(amount);
            _paymentMethod.DoPayment(total);
            _notif.Send(customerEmail, total);
        }

        public void ProcessPayment(IPaymentMethod method, double amount, string customerEmail)
        {
            if (!ValidateAmount(amount)) return;
            double total = method.CalculateTotal(amount);
            _paymentMethod.DoPayment(total);
            _notif.Send(customerEmail, total);
        }

        private bool ValidateAmount(double amount)
        {
            bool isValid = amount > 0;
            if (!isValid)
            {
                Console.WriteLine("Amount harus lebih dari 0!");
            }
            return isValid;
        }
    }
}
