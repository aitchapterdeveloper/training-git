namespace GitTrainingDemo.Services
{
    public class OrderService
    {
        public decimal CalculateTotal(decimal price)
        {
            return price;
        }

        public string GetGreeting(string name, string waktu)
        {
            return "Halo " + name + ", Selamat " + waktu + "!";
        }
    }
}
