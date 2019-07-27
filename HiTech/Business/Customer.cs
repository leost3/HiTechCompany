using HiTech.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTech.Business
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string city;
        private string zipCode;
        private int phoneNumber;
        private int faxNumber;
        private int creditLimit;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string City { get => city; set => city = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int FaxNumber { get => faxNumber; set => faxNumber = value; }
        public int CreditLimit { get => creditLimit; set => creditLimit = value; }


        public bool SaveCustomer(Customer customer)
        {
            return CustomerDB.SaveUser(customer);
        }

        public DataTable ListCustomer()
        {
            return CustomerDB.ListCUstomers();
        }

        public bool DeleteUsers(int customerId)
        {
            return CustomerDB.DeleteCustomer(customerId);
        }

        public bool updateUsers(Customer customer)
        {
            return CustomerDB.updateCustomer(customer);
        }

        public string SearchCustomer(Customer customer)
        {
            return CustomerDB.SearchCustomer(customer);
        }
    }
}
