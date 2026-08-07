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
            return "";
        }
    }
}
