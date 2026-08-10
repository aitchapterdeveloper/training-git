using GitTrainingDemo.Interfaces;

namespace GitTrainingDemo.Services
{
    class PremiumDisount : IDiscount
    {
        public double apply(double price)
        {
            return price * 0.9;
        }
    }

    class StudentDiscount : IDiscount
    {
        public double apply(double price)
        {
            return price*0.85;
        }
    }
}