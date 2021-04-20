using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using WildcatChemicalsDistrobutionAndTrackingSystem.Model;
using WildcatChemicalsDistrobutionAndTrackingSystem.View;

namespace WildcatChemicalsDistrobutionAndTrackingSystem.Controller
{
    class clsDBUserQueries
    {

        public static string AuthenticateUser = "SELECT * from Users WHERE Username = '" + clsUsers.username + "' AND Password = '" + clsUsers.password + "'"; // Query to return valid username/password combination
    }
}
