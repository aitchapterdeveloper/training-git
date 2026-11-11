using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Services
{

    public class DiscountMemberRegular : IDiscountStrategy
    {
        double TARIF_DISKON_REGULAR = 0.1;
        public double diskon = 0;
        

        public double calculateDiscount(int totalPriceBeforeDisc)
        {
            diskon = totalPriceBeforeDisc * TARIF_DISKON_REGULAR;
            return diskon;
        }
    }
}
