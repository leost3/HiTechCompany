using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HiTech.Business;

namespace HiTech.DataAccess
{
    public static class UserDB
    {
        public static SqlConnection connDB = UtilityDB.ConnectDB();
        public static SqlCommand cmd = new SqlCommand();



        public static int Login(User user)
        {
            int roleId = 0;

            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }
            cmd.Connection = connDB;
            cmd.CommandText = string.Format("select role_id from [User] where username='{0}' and password='{1}'", user.Username, user.Password);
            SqlDataReader reader = cmd.ExecuteReader(); //looks like a table 
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            reader.Close();
           
            if (count > 0)
            {
                roleId = (Int32)cmd.ExecuteScalar();

            }else
            {
                roleId = 0;
            }
            cmd.Dispose();
            connDB.Close();
            return roleId;
        }


        public static bool SaveUser(User user)
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
                cmd.CommandText = string.Format("insert into [User] values( '{0}', '{1}','{2}','{3}','{4}','{5}')",
                user.UserId, user.Username, user.Password, user.FirstName, user.LastName, user.RoleId);
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


        public static DataTable ListUsers()
        {
            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }

            cmd.Connection = connDB;
            cmd.CommandText = "select * from [User]";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            cmd.Dispose();
            connDB.Close();
            return dt;
        }

        public static bool DeleteUsers(int EmployeeId)
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
                cmd.CommandText = string.Format("delete from [User] where UserId ='{0}'", EmployeeId);
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

        public static bool UpdateUser(User user)
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
                cmd.CommandText = string.Format("update [User] set username='{0}', " +
                    "password='{1}', FirstName='{2}' , LastName='{3}', role_id='{4}' where UserId='{5}'", 
                    user.Username, user.Password, user.FirstName, user.LastName, user.RoleId, user.UserId);

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

        public static string SearchUser(User user)
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
            cmd.CommandText = string.Format("SELECT FirstName FROM [User] WHERE UserId='{0}'", user.UserId);
            string FirstName = (String)cmd.ExecuteScalar();
            connDB.Close();
            return FirstName;
        }

    }
}
