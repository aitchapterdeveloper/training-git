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
            // Bang Dave baik
            else
            {
                return "User tidak ditemukan";
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