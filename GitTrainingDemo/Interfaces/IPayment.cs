namespace GitTrainingDemo.Interfaces
{
    public interface IPayment
    {
        public double adminFee(double paymentAmount);
        public string NotificationMessage(double totalCharge);
    }
}