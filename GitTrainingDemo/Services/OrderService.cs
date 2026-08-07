namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        { 
            decimal afterdiscount = price * 0.9m; // diskon 10%
            return afterdiscount * 1.11m; //ppn 11%
        }
    }
}
