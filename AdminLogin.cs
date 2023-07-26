using A6_AB_LTA_OOP_Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace A6_AB_LTA_OOP_Polymorphism
{
    // Make sure that this child class inherits from the parent Login class
    class AdminLogin : Login
    {
        // Declare private fields (member variables) for admin password and count of admin password in database
        private string mAdminPasswordString;
        private int mCountOfAdminPasswordInDatabaseInteger;

        // Declare a private variable for counting unsuccessful admin login attempts
        private static int unsuccessfulAdminLoginAttemptsCounterInteger;

        // Add a child class constructor and make it pass arguments to the base class's constructor.
        public AdminLogin(string usernameString, string passwordString, int countOfUsernameInDatabaseInteger, int countOfPasswordInDatabaseInteger, string adminPasswordString, int countOfAdminPasswordInDatabaseInteger)
            : base(usernameString, passwordString, countOfUsernameInDatabaseInteger, countOfPasswordInDatabaseInteger)
        {
            // Set propertys equal to the parameters
            AdminPassword = adminPasswordString;
            CountOfAdminPasswordInDatabase = countOfAdminPasswordInDatabaseInteger;
            // Add a method call to the  ValidateAdminCredentials() method.
            ValidateAdminCredentials();
        }

        public string AdminPassword
        {
            get
            {
                return mAdminPasswordString;
            }
            set
            {
                mAdminPasswordString = value;
            }
        }

        // Declare public properties
        public int CountOfAdminPasswordInDatabase
        {
            get
            {
                return mCountOfAdminPasswordInDatabaseInteger;
            }
            set
            {
                mCountOfAdminPasswordInDatabaseInteger = value;
            }
        }

        public static int UnsuccessfulAdminLoginAttempts
        {
            get
            {
                return unsuccessfulAdminLoginAttemptsCounterInteger;
            }
            set
            {
                unsuccessfulAdminLoginAttemptsCounterInteger = value;
            }
        }


        // Declare a method to increment the variable for counting login attempts.
        protected void IncrementUnsuccessfulAdminLoginAttemptsCounter()
        {
            UnsuccessfulAdminLoginAttempts++;
        }

        // Implement polymorphism by doing regular method overriding.  The following method named ValidateCredentials() 
        // in the child class will override the method by the same name in the parent class.
        protected override void ValidateCredentials()
        {
            if (AdminPassword != null)
            {
                if (UnsuccessfulAdminLoginAttempts >= 3)
                {
                    LoginStatusMessage = "Sorry, you exhausted all your attempts!  Please contact the Chief InfoSec Officer!!!";
                    IncrementUnsuccessfulAdminLoginAttemptsCounter();

                    SuccessfulLogin = false;
                }
                else
                {
                    if (CountOfUsernameInDatabase == 0)
                    {
                        LoginStatusMessage = "Sorry, the username/password you entered was not found in database!   Please try again!!!";
                        IncrementUnsuccessfulAdminLoginAttemptsCounter();

                        SuccessfulLogin = false;
                    }
                    else
                    {
                        if (CountOfPasswordInDatabase == 0)
                        {
                            LoginStatusMessage = "Sorry, the username/password you entered was not found in database!   Please try again!!!";
                            IncrementUnsuccessfulAdminLoginAttemptsCounter();

                            SuccessfulLogin = false;
                        }
                        else
                        {
                            TransactionsDetailsForm newTransactionsDetailsForm = new TransactionsDetailsForm(Username);
                            newTransactionsDetailsForm.ShowDialog();

                            SuccessfulLogin = true;
                        }
                    }
                }
            }
        }

        // Declare a method to validate admin credentials
        private void ValidateAdminCredentials()
        {
            if (UnsuccessfulAdminLoginAttempts >= 3)
            {
                LoginStatusMessage = "Sorry, you exhausted all your attempts!  Please contact the Chief InfoSec Officer!!!";
                IncrementUnsuccessfulAdminLoginAttemptsCounter();
          
                SuccessfulLogin = false;
            }
            else
            {
                if (CountOfPasswordInDatabase == 0 || CountOfAdminPasswordInDatabase == 0)
                {
                    LoginStatusMessage = "Sorry, the username/password you entered was not found in database!  Please try again!!!";
                    IncrementUnsuccessfulAdminLoginAttemptsCounter();

                    SuccessfulLogin = false;
                }
                else
                {
                    TransactionsDetailsForm newTransactionsDetailsForm = new TransactionsDetailsForm(Username);
                    newTransactionsDetailsForm.ShowDialog();

                    SuccessfulLogin = true;
                }
            }
        }

        // Implement polymorphism by doing user-defined method overriding (The base class has a ToString() function.
        // Since we are overriding the base class's ToString() function with a function by the same name in this class, 
        // this would be an example of user-defined method overriding.)
        //
        // Declare a new overridden ToString() function.  Inside the function, add code to return the value in the 
        // LoginStatusMessage property. 
        public override string ToString()
        {
            return LoginStatusMessage;
        }
    }
}
