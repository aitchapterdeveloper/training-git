using System;
using System.Collections.Generic;

namespace GitTrainingDemo.Services
{
    public class UserService
    {
        List<string> myList { get; set; } = ["1", "2", "23"];

        public void IterateList()
        {
            myList.ForEach(x =>
                Console.WriteLine(x)
            );
        }
        public string Login(string user, string pass)
        {
            return (user == "admin" && pass.Length<4) ?
            "Login Berhasil" : "Login Gagal";
            // if (user == "admin" && pass == "1234")
            // {
            //     return "Login berhasil deh1";
            // }
            // else if (pass.Length < 4)
            // {
            //     return "Error, Password kurang terlalu pendek";
            // }
            // else if (user == "admin")
            // {
            //     return "Password salah";
            // }
            // else
            // {
            //     return "User hilang";
            // }

        }
    }
}
