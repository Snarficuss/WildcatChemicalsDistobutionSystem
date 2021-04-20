using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WildcatChemicalsDistrobutionAndTrackingSystem.Model
{


    class clsUsers
        {
            public clsUsers(string Username, string Role, string Office, string UserID, int Shift)
            {
                string username = Username;
                string role = Role;
                string office = Office;
                string userID = UserID;
                int shift = Shift;
            }

            public static List<clsUsers> users { get; set; } // List of all returned users, 0th is the current user

            public static string username { get; set; }
            public static string password { get; set; }
            public static string role { get; set; }
            public static string office { get; set; }
            public static string userID { get; set; }
            public static int shift { get; set; }
        }
}
