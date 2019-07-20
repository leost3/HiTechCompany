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


        public static bool saveUser(User user)
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
    }
}
