using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HiTech.DataAccess
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection("data source=DESKTOP-P03PBCK\\SQLSERVER; database=HiTech_DB; Integrated Security= SSPI"); //Integrated Security - windows autentication (outra maneira: data source= . ;)
            connDB.Open();
            return connDB;
        }
    }
}
