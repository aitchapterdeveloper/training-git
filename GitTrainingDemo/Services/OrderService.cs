namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            double discount = 1.11;
            return price*(1-discount);
        }
       
    }
    public class SapaService
    {
         public string SapaNama(name string)
        {
            return "selamat datang" + name;
        }
    }
}
