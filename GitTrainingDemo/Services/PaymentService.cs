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
            ValidateAmount(amount);
            double total = _paymentMethod.CalculateTotal(amount);
            _paymentMethod.DoPayment(total);
            _notif.Send(customerEmail, total);
        }

        private void ValidateAmount(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount harus lebih dari 0!");
                return;
            }
        }
    }
}
