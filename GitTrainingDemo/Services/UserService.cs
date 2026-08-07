namespace GitTrainingDemo.Services
{
    public class UserService
    {
        public string Login(string user, string pass)
        {
            if (user == "admin" && pass == "1234")
            {
                return "Login berhasil";
            }
            else if (user == "admin")
            {
                return "Password salah"; //test commit
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang";
            }
        }

        public string LoginTest(string user, string pass)
        {
            if (user == "adminxx" && pass == "123456")
            {
                return "Login berhasil ya";
            }
            else if (user == "admin")
            {
                return "Password salah ya"; //test commit
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang ya";
            }
        }
    }
}
