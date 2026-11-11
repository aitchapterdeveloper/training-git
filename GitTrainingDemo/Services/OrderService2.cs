using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Services
{
    public class OrderService2
    {
        private INotificationService _notif;
        // Dependency di-inject dari luar
        public OrderService2( INotificationService notif )
        {
            _notif = notif;
        }

        public void sendMessage(string message)
        {
            _notif.Send(message);
        }

    }
}
