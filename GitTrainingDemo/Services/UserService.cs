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
            // Bang Dave baik
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
                return "!!!!!!!Password-----salah----------ya!!!!!!!!!!!"; //test commitj
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang ya";
            }
        }
    }
}


/*
- PRAKTEK 1 (LOCAL REPO)
git add
git commit -m ""
git log -- oneline
git remote -v

- PRAKTEK 2 (BRANCHING)
git branch
git branch <nama_branch>
git checkout <nama_branch>
git checkout -b <nama_branch>

- PRAKTEK 3 (MERGE)
berada di branch tujuan
git merge <nama_branch_asal>

- PRAKTEK 4 (MERGE CONFLICT)
git status (ditandai both modified)
buka edit file
hapus marker di dalam file (<<<<, =====, >>>>)
git add
gir commit
 */