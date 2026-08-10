namespace GitTrainingDemo.Services
{
    public class CarService
    {
        private string Brand { get; set; }
        private string Color { get; set; }
        private int Year { get; set; }

        public CarService(string brand, string color, int year)
        {
            Brand = brand;
            Color = color;
            Year = year;
        }

        public string Drive()
        {
            return Brand + " Is Driving......";
        }
    }
}