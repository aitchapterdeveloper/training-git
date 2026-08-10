using System;

namespace GitTrainingDemo.Services
{
    public class UserService

    {
        public string Login(string user, string pass)
        {
            if (user == "admin" && pass == "1234")
            {
                return "Login berhasil deh1";
            }
            else if (pass.Length < 4)
            {
                return "password terlalu pendek";
            }
            else if (user == "admin")
            {
                return "Password salah"; //test pelatihan
            }

            else
            {
                return "User hilang";
            }

        }
    }


    //program srp
    class userValidator
    {
        public void Uservalidate(string email)
        {
            Console.WriteLine($"Validasi email:  {email}");
        }
    }

    class userRepository
    {
        public void SaveToDatabase(string email)
        {
            Console.WriteLine($"simpan ke database: {email}");
        }
    }
    class WelcomeService
    {
        public void sendWelcome(string email)
        {
            Console.WriteLine($"kirim email welcome ke: {email}");
        }
    }

    //program ocp

    interface IDiscount
    {
        double Apply(double price);
    }

    class RegularDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.9;
        }
    }

    class VIPDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.8;
        }
    }
    class StudentDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.85;
        }
    }
    class FlashDiscount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.6;
        }
    }





    //program lsp
    interface IShape
    {
        int Area();
    }
    class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area() => Width * Height;
    }
    class Square : IShape
    {
        public int Side { get; set; }
        public int Area() => Side * Side;
    }

    interface IWorkable { void Work(); }
    interface IFeedable { void Eat(); }
    interface ISleepable { void Sleep(); }

    class Hewan : IFeedable, ISleepable
    {
        public void Eat()
        {
            Console.WriteLine("i eating");
        }
        public void Sleep()
        {
            Console.WriteLine("sleep");
        }
    }

    class Human : IWorkable, IFeedable, ISleepable
    {
        public void Eat()
        {
            Console.WriteLine("eat");
        }
        public void Work()
        {
            Console.WriteLine("work");
        }
        public void Sleep()
        {
            Console.WriteLine("sleep");
        }
    }




    interface INotificationService
    {
        void Send(string message);
    }

    class GithubService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Github: " + message);
        }
    }

    class EmailServiceSimple : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }

    class WhatsAppService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("WhatsApp: " + message);
        }
    }
    class OrderrService
    {
        private INotificationService _notification;

        public OrderrService(INotificationService notification)
        {
            _notification = notification;
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Order dibuat");

            _notification.Send("Pesanan berhasil!");
        }
    }
}
