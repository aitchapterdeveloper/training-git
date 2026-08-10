using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitTrainingDemo.Repositories
{
    public class UserRepository
    {
        public void SaveEmailToDatabase(string email)
        {
            Console.WriteLine($"Save email to database: {email}");
        }
    }
}