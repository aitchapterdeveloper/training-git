
using System;

namespace GitTrainingDemo.Services
{
    public class PaymentService
    {
        private readonly PaymentValidator _validator;
        private readonly AdminFeeCalculator _feeCalculator;

        public PaymentService()
        {
            _validator = new PaymentValidator();
            _feeCalculator = new AdminFeeCalculator();
        }

        public void ProcessPayment(
            IPaymentMethod paymentMethod,
            double amount,
            string customerEmail)
        {
            // Validasi
            if (!_validator.IsValid(amount))
            {
                Console.WriteLine("Amount harus lebih dari 0!");
                return;
            }

            // Hitung fee
            double adminFee = _feeCalculator.Calculate(
                paymentMethod,
                amount
            );

            double total = amount + adminFee;

            // Proses pembayaran
            paymentMethod.Process(total);

            // Receipt
            Console.WriteLine(
                $"[EMAIL] Receipt sent to {customerEmail}: Rp{total}"
            );
        }
    }


   

    public interface IPaymentMethod
    {
        double CalculateFee(double amount);
        void Process(double amount);
    }


    public class CreditCardPayment : IPaymentMethod
    {
        public double CalculateFee(double amount)
        {
            return amount * 0.03;
        }

        public void Process(double amount)
        {
            Console.WriteLine(
                $"[CC] Charging Rp{amount} to credit card"
            );
        }
    }


    public class BankTransferPayment : IPaymentMethod
    {
        public double CalculateFee(double amount)
        {
            return 5000;
        }

        public void Process(double amount)
        {
            Console.WriteLine(
                $"[TF] Transferring Rp{amount} via bank"
            );
        }
    }


    public class EWalletPayment : IPaymentMethod
    {
        public double CalculateFee(double amount)
        {
            return amount * 0.01;
        }

        public void Process(double amount)
        {
            Console.WriteLine(
                $"[EW] Deducting Rp{amount} from e-wallet"
            );
        }
    }


 

    public class PaymentValidator
    {
        public bool IsValid(double amount)
        {
            return amount > 0;
        }
    }



    public class AdminFeeCalculator
    {
        public double Calculate(
            IPaymentMethod paymentMethod,
            double amount)
        {
            return paymentMethod.CalculateFee(amount);
        }
    }
}

