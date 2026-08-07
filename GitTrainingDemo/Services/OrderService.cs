namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            decimal discount = 0.15m;
            return price*(1-discount);
        }
       
    }
    public class SapaService
    {
         public string SapaNama(string name )
        {
            return "selamat datang" + name;
        }
    }
}
