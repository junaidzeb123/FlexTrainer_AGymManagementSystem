using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class Session
    {
        private static bool isAuthenticated = false;
        private static string username;
        private static string role;


        /*these variable below means that these are using the above  private variables ,  but
         they are serving a read only acces to above private variables.*/
        public static bool IsAuthenticated => isAuthenticated;
        public static string Username => username;
        public static string Role => role;

        public static void Login(string enteredUsername,string userRole)
        {
            isAuthenticated = true;
            role = userRole;             
            username = enteredUsername;
        }

        public static void Logout()
        {
            isAuthenticated = false;
            username = null;
            role = null;
        }

      
     
    }
}
