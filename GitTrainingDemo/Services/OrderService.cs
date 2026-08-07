namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            double discount = 0.9;
            return price * (1 - discount);
        }
    }
}
