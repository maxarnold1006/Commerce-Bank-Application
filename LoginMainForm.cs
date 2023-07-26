// Class Name:      LoginMainForm.cs
// Program Purpose: To allow the bank's customers to login to their accounts to view their transactions
// and to give the banks administrators the ability to view all transactions
// Programmer Name: Maxwell Arnold
// Program Date:    7/25/2023

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6_AB_LTA_OOP_Polymorphism
{
    public partial class LoginMainForm : Form
    {
        // Declare a class-level variable for username
        string usernameString;

        // Constructor method with 0 parameters
        public LoginMainForm()
        {
            InitializeComponent();
        }

        // Implement polymorphism by doing constructor method overloading (The previous constructor has no parameters while
        // the next one will have 1 parameter.  Since there are two constructor methods with the same name, but with different 
        // parameter lists, this would be an example of constructor method overloading.)
        //
        // Declare a constructor which has 1 parameter (splashScreenMessageString).  Inside the constructor method, 
        // use a 4-argument message box and the parameter to display a welcome message to the user.  After the message
        // box method call, call the InitializeComponent() method inside the parameterized constructor method.  
        public LoginMainForm(string splashScreenMessageString)
        {
            MessageBox.Show(splashScreenMessageString, "Welcome!!!", MessageBoxButtons.OK);
            InitializeComponent();
        }

        private void LoginMainForm_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'americanBankNewDataSet.AdminLogin' table. You can move, or remove it, as needed.
            this.adminLoginTableAdapter.Fill(this.americanBankNewDataSet.AdminLogin);
            // This line of code loads data into the 'americanBankNewDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.americanBankNewDataSet.Login);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Declare variables for password and admin password
            string passwordString;
            string adminPasswordString;

            // Declare variables for count of username in database, count of password in database, 
            // and count of admin password in database
            int countOfUsernameInDatabaseInteger = 0;
            int countOfPasswordInDatabaseInteger = 0;
            int countOfAdminPasswordInDatabaseInteger = 0;

            // Get the username and password and store those in the appropriate variables
            usernameString = usernameTextBox.Text;
            passwordString = passwordTextBox.Text;

            // Use an if() statement block to check if the username is "admin"
            if (usernameString == "admin")
            {
                // Get the admin password and store it in the appropriate variable
                adminPasswordString = adminPasswordTextBox.Text;

                // Get the count of username in database, count of password in database,
                // count of admin password in database, and store those in the appropriate
                // variables
                countOfUsernameInDatabaseInteger = Convert.ToInt32(adminLoginTableAdapter.CountOfUsernameInDatabase(usernameString));
                countOfPasswordInDatabaseInteger = Convert.ToInt32(adminLoginTableAdapter.CountOfPasswordInDatabase(usernameString, passwordString)); 
                countOfAdminPasswordInDatabaseInteger = Convert.ToInt32(adminLoginTableAdapter.CountOfAdminPasswordInDatabase(usernameString, adminPasswordString));
                // Since the username entered using the usernameTextBox control is “admin”,
                // instantiate an object (newAdminLogin) based on the child class by passing its
                // constructor method the appropriate arguments

                AdminLogin newAdminLogin = new AdminLogin(usernameString, passwordString, countOfUsernameInDatabaseInteger, countOfPasswordInDatabaseInteger, adminPasswordString, countOfAdminPasswordInDatabaseInteger);

                /// Use an if-statement block to check if the admin login was unsuccessful and if the number of
                // unsuccessful admin login attempts is less than or equal to 3
                if (newAdminLogin.SuccessfulLogin == false && AdminLogin.UnsuccessfulAdminLoginAttempts >= 3) 
                {
                    // Display the value stored in the newly created object's ToString() method using a 
                    // 4-argument message box
                    MessageBox.Show(newAdminLogin.ToString(), "AdminLogin Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Use an if-statement block to check if the number of unsuccessful admin login attempts is more than 3
                if (AdminLogin.UnsuccessfulAdminLoginAttempts > 3)
                {
                    // Display the value stored in the newly created object's ToString() method using a 
                    // 4-argument message box (add it as the first argument in the C# statement below)
                    MessageBox.Show(newAdminLogin.ToString(), "AdminLogin Status", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    // TO DO: Add code to close the application
                    this.Close();
                }
            }
            else
            {
                // Get the count of username in database and count of password in database
                // and store those in the appropriate variables
                countOfUsernameInDatabaseInteger = Convert.ToInt32(loginTableAdapter.CountOfUsernameInDatabase(usernameString));
                countOfPasswordInDatabaseInteger = Convert.ToInt32(loginTableAdapter.CountOfPasswordInDatabase(usernameString, passwordString));

                // Since the username entered using the usernameTextBox control is not “admin”,
                // instantiate an object (newLogin) based on the parent class by passing its constructor
                // method the appropriate arguments
                Login newLogin = new Login(usernameString, passwordString, countOfUsernameInDatabaseInteger, countOfPasswordInDatabaseInteger);


                // Use an if-statement block to check if the login was unsuccessful and if the number of
                // unsuccessful login attempts is less than or equal to 3
                if (newLogin.SuccessfulLogin == false && Login.UnsuccessfulLoginAttempts <= 3)
                {
                    // Display the value stored in the newly created object's ToString() method using a 
                    // 4-argument message box
                    MessageBox.Show(newLogin.ToString(), "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Use an if-statement block to check if the number of unsuccessful login attempts is more than 3
                if (Login.UnsuccessfulLoginAttempts > 3)
                {
                    // Display the value stored in the newly created object's ToString() method using a 
                    // 4-argument message box
                    MessageBox.Show(newLogin.ToString(), "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    // Code to close the application
                    this.Close();
                }
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get the username and store it in the appropriate variable
            usernameString = usernameTextBox.Text;

            // Code to show the adminPasswordLabel and adminPasswordTextBox controls
            // to the user if the username entered is “admin”.  If the username is not “admin”,
            // then hide the adminPasswordLabel and adminPasswordTextBox controls from the user.
            if (usernameString == "admin")
            {
                adminPasswordLabel.Visible = true;
                adminPasswordTextBox.Visible = true;
            }
            else
            {
                adminPasswordLabel.Visible = false;
                adminPasswordTextBox.Visible = false;
            }
        }
    }
}
