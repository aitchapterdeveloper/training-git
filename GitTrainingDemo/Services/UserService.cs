namespace GitTrainingDemo.Services
{
    public class UserService
    {
        public string Login(string user, string pass)
        {
            if (user == "admin" && pass == "1234")
            {
                return "Login Success !!!";
            }
            else if (user == "admin") // testA
            {
                return "Password salah"; // Test Commit

            }
            else
            {
                return "User tidak ditemukan silahkan login ulang";
            }
            return "Login Berhasil";
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
