using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WildcatChemicalsDistrobutionAndTrackingSystem.Model;
using WildcatChemicalsDistrobutionAndTrackingSystem.View;
using System.Data.SqlClient;
using WildcatChemicalsDistrobutionAndTrackingSystem.Controller;

namespace WildcatChemicalsDistrobutionAndTrackingSystem
{
    public partial class frmLogin : Form
    {

        private static bool userAuthenticated = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUsers.username = ""; // clears the current user's username in case the user logged out and another logged in.
            clsUsers.password = "";

            string username = "Admin";
            //clsUsers.username = txtUsername.Text;
            clsUsers.username = username; // sets the attempted username to the Current User instance since we know they have been authenticated by this point
            string password = "Admin";
            //clsUsers.password = txt.Password.Text;

            verifyUserInDB();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void verifyUserInDB() // Opens and created a connection with BB Group 2 DB and If matching record is found populates an instance of clsUsers
        {

            string ConString = "Data Source=BB-Enterprise.users.campus;Initial Catalog=GROUP2;Persist Security Info=True;User ID=Group2;Password=Grp2s2117"; // Connection string to BB Group 2 DB

            try // Try the connection and user verification query
            {
                using (SqlConnection myConnection = new SqlConnection(ConString))
                {
                    SqlCommand cmd = new SqlCommand(clsDBUserQueries.AuthenticateUser, myConnection); // runs the above query
                    myConnection.Open(); // Opens a connection to the DB
                    SqlDataReader readerReturnVal = cmd.ExecuteReader(); // Reads all values returned by the SQL Query

                    if (readerReturnVal.HasRows == true) // Code to run if the username and password returns as a match
                    {
                        string role = readerReturnVal.GetString(3); // stores the read value in column 3 as the user's role
                            clsUsers.role = role;
                        string office = readerReturnVal.GetString(4); // stores the read value in column 4 as the user's office location
                            clsUsers.office = office;
                        string userID = readerReturnVal.GetString(0); // stroed the read value from column 0 as the user's identification number
                            clsUsers.userID = userID;
                        int shift = Convert.ToInt32(readerReturnVal.GetString(6)); // stores the read value from column 6 as the user's normal shift
                            clsUsers.shift = shift;
                        


                        clsUsers user = new clsUsers(clsUsers.username, role, office, userID, shift); // Establishes an instance of the user in the Users Class
                        clsUsers.users.Add(user); // Adds the new user as the 0th position in the clsUsers Users list

                        myConnection.Close(); // Closes the connection since reading is complete

                        switch (role) // Switch statement based on the value of the user's role
                        {
                            case "Manager": // If role is manager, display manager menu
                                frmManagerMenu manMenu = new frmManagerMenu();
                                manMenu.Show();
                                break;
                            case "Crew": // If role is crew, display crew menu
                                frmCrewMenu crwMenu = new frmCrewMenu();
                                crwMenu.Show();
                                break;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please try again. Username/Password combination not found."); // If no records matched the username or password
                        myConnection.Close(); // Closes the connection since reading is complete
                    }
                    
                    this.Close(); // Close the current form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message); // Displayed error message if the Query fails to complete
            }
        }
    }
}
