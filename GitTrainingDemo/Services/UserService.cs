using System;
using System.Collections.Generic;

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
    }
}
