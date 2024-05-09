using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class DatabaseManager
    {
        public static string ConnectionString = "Data Source=DESKTOP-MAO1OJ0" + "\\" + "SQLEXPRESS;Initial Catalog=GYM_MANAGMENT;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
