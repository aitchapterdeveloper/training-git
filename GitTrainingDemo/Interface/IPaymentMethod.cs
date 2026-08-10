using System;

namespace GitTrainingDemo.Interfaces
{
    interface IPaymentMethod
    {
        double CalculateTotal(double amount);
        void DoPayment(double totalAmount);
    }

    class CreditCard : IPaymentMethod
    {
        private double feeRate = 0.03;
        public double CalculateTotal(double amount)
        {
            return amount * (1 + feeRate);
        }

        public void DoPayment(double totalAmount)
        {
            Console.WriteLine($"[CC] Charging Rp{totalAmount} to credit card");
        }
    }

    class BankTransfer : IPaymentMethod
    {
        private double adminFee = 5000;

        public double CalculateTotal(double amount)
        {
            return amount + adminFee;
        }
        public void DoPayment(double totalAmount)
        {
                Console.WriteLine($"[TF] Transferring Rp{totalAmount} via bank");
        }
    }

    class EWallet : IPaymentMethod
    {
        private double feeRate = 0.01;

        public double CalculateTotal(double amount)
        {
            return amount * (1 + feeRate);
        }

        public void DoPayment(double totalAmount)
        {
                Console.WriteLine($"[EW] Deducting Rp{totalAmount} from e-wallet");
        }
    }
}