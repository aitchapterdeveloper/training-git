namespace GitTrainingDemo.Services
{
    public class UserService
    {
        public string Login(string user, string pass)
        {
            if (user == "admin" && pass == "1234")
            {
                return "Login berhasil deh1";
            }
             else if( pass.Length < 4)
            {
                return "password terlalu pendek";
            }
            else if (user == "admin")
            {
                return "Password salah"; //test pelatihan
            }
           
            else
            {
                return "User hilang";
            }

        }
    }
}
