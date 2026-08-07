using System;
namespace GitTrainingDemo.Model
{
    public class UserData
    {

        public string Username { get; set; }

        private string _password = "";
        public string Password 
        {
            get { return _password; }
            set
            {
                if (value is not null && value.Length > 0 && value.Length < 5) _password = value;
                else Console.WriteLine("Password format wrong");
            }
        }

        public UserData(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

