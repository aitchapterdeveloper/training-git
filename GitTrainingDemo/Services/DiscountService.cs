using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Services
{
    public class DiscountService
    {
        private IDiscountStrategy _discountStrategy;
        private double diskon = 0;

        public DiscountService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double calculateDiscount(int totalPriceBeforeDisc)
        {
            diskon = _discountStrategy.calculateDiscount(totalPriceBeforeDisc);
            return diskon;
        }
    }
}
