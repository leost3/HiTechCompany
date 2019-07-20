using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTech.Business
{
    class Employee
    {
        private string userId;
        private string firstName;
        private string lastName;
        private string roleId;

        public string UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string RoleId { get => roleId; set => roleId = value; }
    }
}
