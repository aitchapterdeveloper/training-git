using System;
using System.Collections.Generic;
using GitTrainingDemo.Model;

namespace GitTrainingDemo.Services
{
    public class UserService
    {
      
        public string Login(string username, string pass)
        {

            var userDict = new Dictionary<string, UserData>();
            var userList = GetUserDataList();
            foreach(UserData userData in userList)
            {
                userDict[userData.Username] = new UserData(userData.Username, userData.Password);
            }
            if (userDict.TryGetValue(username, out var user))
            {
                return (user.Password == pass) ? "Login berhasil" : "Password salah";
            }
            else if (pass.Length > 4)
            {
                return "Password Kepanjangan";
            }
            else
            {
                return "User tidak ditemukan silahkan login ulang";
            }
        }

        private List<UserData> GetUserDataList()
        {
            var userList = new List<UserData>
            {
                new UserData("user1", "1111"),
                new UserData("admin1","1234"),
                new UserData("user2","1214"),
                new UserData("admin2","4321")

            };
            return userList;
        }
    }
}
