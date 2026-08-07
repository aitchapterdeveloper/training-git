using System.ComponentModel.DataAnnotations;

namespace GitTrainingDemo.Services
{
    public class UserService
    {
        public string Login(string user, string pass)
        {
            if (user == "user" && pass == "1234")
            {
                return "Login berhasil"; 
            }
            else if (user == "admin") // testA
            {
                return "Password salah"; //test commit
            }
            else if (pass.Length < 4)
            {
                return "Password anda pendek";
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang";
            }
        }

        public string Loginn(string user, string pass)
        {
            return (user == "admin" && pass == "1234")
            ? "Login berhasil"
            : "Login gagal";
        }


    }
}
