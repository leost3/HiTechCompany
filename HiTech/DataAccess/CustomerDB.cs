using HiTech.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTech.DataAccess
{
    class CustomerDB
    {
        public static SqlConnection connDB = UtilityDB.ConnectDB();
        public static SqlCommand cmd = new SqlCommand();


        public static bool SaveUser(Customer customer)
        {
            bool result = true;
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }

                cmd.Connection = connDB;
                cmd.CommandText = string.Format("insert into Customer values( '{0}', '{1}','{2}','{3}','{4}','{5}','{6}')",
                customer.FirstName, customer.LastName, customer.City, customer.ZipCode, customer.PhoneNumber, customer.FaxNumber, customer.CreditLimit);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            catch (Exception)
            {
                result = false;
                // throw;
            }
            return result;
        }

        public static DataTable ListCUstomers()
        {
            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }

            cmd.Connection = connDB;
            cmd.CommandText = "select * from Customer";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            cmd.Dispose();
            connDB.Close();
            return dt;
        }

        public static bool DeleteCustomer(int CustomerId)
        {
            bool result = true;
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }
                cmd.Connection = connDB;
                cmd.CommandText = string.Format("delete from Customer where Customer_Id ='{0}'", CustomerId);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            catch (Exception)
            {
                result = false;
                // throw;
            }

            return result;
        }

        public static bool updateCustomer(Customer customer)
        {
            bool res = true;
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }
                cmd.Connection = connDB;
                cmd.CommandText = string.Format("update Customer set FirstName='{0}'," +
                    " LastName='{1}', City='{2}', ZipCode='{3}', PhoneNumber='{4}', " +
                    "FaxNumber='{5}', CreditLimit='{6}' where Customer_Id='{7}'",
                    customer.FirstName, customer.LastName, customer.City,
                    customer.ZipCode, customer.PhoneNumber, customer.FaxNumber
                    , customer.CreditLimit, customer.CustomerId);
                cmd.ExecuteNonQuery();
                connDB.Close();

            }
            catch (Exception)
            {
                res = false;
                throw;
            }
            return res;
        }

        public static string SearchCustomer(Customer customer)
        {
            if (connDB.State == System.Data.ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }

            //cmd.Connection = connDB;
            //cmd.CommandText = string.Format("SELECT [User] FROM Employee WHERE UserId='{0}'", UserId);
            //string FirstName = (String)cmd.ExecuteScalar();
            //connDB.Close();
            //return FirstName;

            cmd.Connection = connDB;
            cmd.CommandText = string.Format("SELECT FirstName + LastName FROM [Customer] WHERE Customer_Id='{0}'", customer.CustomerId);
            string FirstName = (String)cmd.ExecuteScalar();
            connDB.Close();
            return FirstName;
        }

    }
}
