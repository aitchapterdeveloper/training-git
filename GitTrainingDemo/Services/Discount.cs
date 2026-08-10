namespace GitTrainingDemo.Services
{
    interface IDiscount
    {
        double Apply(double price);
    }

    class RegulerDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.9;
        }
    }

    class VIPDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.8;
        }
    }

    class StudentDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.7;
        }
    }

    class PremiumDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.95;
        }
    }
}