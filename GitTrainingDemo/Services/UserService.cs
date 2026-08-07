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
                return "Password salah";
            }
            else
            {
                return "User tidak ditemukan";
            }
            return "";
        }
    }
}
