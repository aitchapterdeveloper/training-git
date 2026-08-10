using System;
using GitTrainingDemo.Interfaces;
using Microsoft.VisualBasic;
namespace GitTrainingDemo.Services
{

    public class UserManager(int id)
    {
        int id = id;
        private USerRepository repo = new USerRepository();
        private EmailService emailService = new EmailService();
        private UserValidator validator = new UserValidator();

        public void ValidateUser()
        {
            Console.WriteLine(validator.ValidateUser(id));
        }

        public void SendEmail(int id)
        {
            emailService.sendEmail(id);
        }

        public void SaveUserData(string formData)
        {
            repo.SaveToDataBase(formData);
        }
    }

    public class USerRepository()
    {
        public void SaveToDataBase(string formData)
        {
            Console.WriteLine("User data is successfully saved");
        }
    }

    public class UserValidator()
    {
        public bool ValidateUser(int id)
        {
            var random = new Random();
            bool isSuccess = random.Next(1) == 1;
            return isSuccess;
        }
    }

    public class EmailService()
    {
        public void sendEmail(int id)
        {
            Console.WriteLine($"Successfully send email to: {id}");
        }
    }
}