using System.ComponentModel.DataAnnotations;

namespace GitTrainingDemo.Services
{
    public class UserService
    {
        public string Login(string user, string pass)
        {
            if (user == "admin" && pass == "24240942385") //change admin default password to 2424
            {
                return "Login Success !!!";
            }
            else if(pass.Length < 4)
            {
                return "Passwordnya harus lebih dari 4";
            }
            else if (user == "admin") // testA
            {
                return "Password salah"; // Test Commit

            }

            else
            {
                return "User tidak ditemukan silahkan login ulang kembali okayyy";
            }
            //return "Login Berhasil";
        }

        public string LoginTest(string user, string pass)
        {
            if (user == "adminxx" && pass == "123456")
            {
                return "Login berhasil ya";
            }
            else if (user == "admin")
            {
                return "!!!!!!!Password-----salah----------ya!!!!!!!!!!!"; //test commit
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang ya";
            }
        }
    }
}

