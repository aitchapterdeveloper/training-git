using System;

namespace GitTrainingDemo.Interfaces
{
    interface INotification
    {
        void Send(string receiver, double total);
    }

    class EmailNotification() : INotification
    {
        public void Send(string receiver, double total)
        {
            Console.WriteLine($"[EMAIL] Receipt sent to {receiver}: Rp{total}");
        }
    }

    class WhatsAppNotification() : INotification
    {
        public void Send(string msg, double total)
        {
            Console.WriteLine("Sending notif via WhatsApp");
        }
    }

    class PigeonNotification(): INotification
    {
        public void Send(string msg, double total)
        {
            Console.WriteLine("Sending notif using pigeon, it will takes at least 2 days");
        }
    }
}