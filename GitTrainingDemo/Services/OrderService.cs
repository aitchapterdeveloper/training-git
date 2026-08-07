namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            return price * 1.11m; //ppn 11%
        }
    }
}
