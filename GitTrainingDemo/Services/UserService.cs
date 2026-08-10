using System;

namespace GitTrainingDemo.Services
{
    public class UserService
    {
        public bool Login(string user, string pass)
        {
            if (user == "fachri" && pass == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class UserValidator
    {
        public void Validate(string user, string password, out string result)
        {
            if (user == "fachri" && password == "1234")
            {
                result = "Login Berhasil";
            }
            else
            {
                result = "Login Gagal";
            }
        }
    }

    public class UserRepository
    {
        public void Save(string user)
        {
            Console.WriteLine($"Simpan ke database: {user}");
        }
    }

    public class EmailService
    {
        public void Send(string email)
        {
            Console.WriteLine($"Kirim welcome email ke: {email}");
        }
    }
}
