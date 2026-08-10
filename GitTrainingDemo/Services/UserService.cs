using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitTrainingDemo.Repositories;

namespace GitTrainingDemo.Services
{
    public class UserService
    {
        public string Login(string user, string password)
        {
            if (user == "admin" && password == "admin")
            {
                return "Login successful!";
            }
            else if (password.Length < 4)
            {
                return "Password too short!";
            }
            else
            {
                return "Login failed!";
            }
        }

        public void GetCities(List<string> cities)
        {
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }

        public async Task<string> GetUserNameAsync(int id)
        {
            await Task.Delay(300);
            return $"User-{id}";
        }
    }

    public class UserManager
    {
        UserRepository userRepository = new UserRepository();
        public void ValidateUser(string email)
        {
            Console.WriteLine($"Validate email: {email}");

            userRepository.SaveEmailToDatabase(email);
        }
    }
}
