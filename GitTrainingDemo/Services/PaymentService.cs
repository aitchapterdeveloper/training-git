using System;
using System.Collections.Generic;

namespace GitTrainingDemo.Services
{
    
    //public class PaymentService
    //{
    //    public void ProcessPayment(string method, double amount, string customerEmail)
    //    {
    //        if (amount <= 0)
    //        {
    //            Console.WriteLine("Amount harus lebih dari 0!");
    //            return;
    //        }

    //        double adminFee = 0;
    //        if (method == "CreditCard")
    //            adminFee = amount * 0.03;
    //        else if (method == "BankTransfer")
    //            adminFee = 5000;
    //        else if (method == "EWallet")
    //            adminFee = amount * 0.01;

    //        double total = amount + adminFee;

    //        if (method == "CreditCard")
    //            Console.WriteLine($"[CC] Charging Rp{total} to credit card");
    //        else if (method == "BankTransfer")
    //            Console.WriteLine($"[TF] Transferring Rp{total} via bank");
    //        else if (method == "EWallet")
    //            Console.WriteLine($"[EW] Deducting Rp{total} from e-wallet");

    //        Console.WriteLine($"[EMAIL] Receipt sent to {customerEmail}: Rp{total}");
    //    }
    //}
}
