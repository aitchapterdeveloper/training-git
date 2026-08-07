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
            else if (user == "admin")
            {
<<<<<<< HEAD
                return "Password salah"; // Test Commit
=======
                return "Password salah"; //test commit
>>>>>>> origin
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang";
            }
        }
    }
}
