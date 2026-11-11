using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Services
{
    public class DiscountMemberVIP : IDiscountStrategy
    {
        double TARIF_DISKON_VIP = 0.2;
        public double diskon = 0;

        public double calculateDiscount(int totalPriceBeforeDisc)
        {
            diskon = totalPriceBeforeDisc * TARIF_DISKON_VIP;
            return diskon;
        }
    }
}
