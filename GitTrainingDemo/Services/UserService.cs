namespace GitTrainingDemo.Services //test commit O.o
{
    public class UserService
    {
        public string Login(string user, string pass)
        {
            if (user == "admin" && pass == "1234")
            {
                return "Login berhasil wow";
            }
            else if (user == "admin")
            {
                return "Password salah bruh"; //test commit
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang";
            }
        }
    }
}
