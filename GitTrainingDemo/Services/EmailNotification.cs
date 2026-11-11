using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Services
{
    public class EmailNotification : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
