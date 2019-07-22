using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.DataAccess;


namespace HiTech.Business
{
    public class User
    {
        private int userId;
        private string firstName;
        private string lastName;
        private int roleId;
        private string username;
        private string password;

        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int RoleId { get => roleId; set => roleId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public int Login(User user)
        {
            return UserDB.Login(user);
        }

        public bool Save(User user)
        {
            return UserDB.SaveUser(user);
        }
        public bool Delete(int userId)
        {
            return UserDB.DeleteUsers(userId);
        }

        public DataTable listUsers()
        {
            return UserDB.ListUsers();
        }

    }
}
