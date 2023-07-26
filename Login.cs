using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_AB_LTA_OOP_Polymorphism
{
    class Login
    {
        // Declare private fields (member variables) for username, password and login status message
        protected string mUsernameString, mPasswordString, mLoginStatusMessageString;

        // Declare private fields (member variables) for count of username in database, count of password
        // in database
        protected int mCountOfUsernameInDatabaseInteger, mCountOfPasswordInDatabaseInteger;

        // Declare a private member field for successful login.
        // This variable can be inherited by the child class.
        protected bool mSuccessfulLoginBoolean;

        // Declare a private variable for counting unsuccessful login attempts
        protected static int unsuccessfulLoginAttemptsCounterInteger;

        // Declare a parameterized constructor with 4 parameters Inside the constructor, set the
        // appropriate properties to the member variables.  Then, add a method call to the method
        // ValidateCredentials().
        public Login(string usernameString, string passwordString, int countOfUsernameInDatabaseInteger, int countOfPasswordInDatabaseInteger)
        {
            // Add PropertyName = parameterName;
            Username = usernameString;
            Password = passwordString;
            CountOfUsernameInDatabase = countOfUsernameInDatabaseInteger;
            CountOfPasswordInDatabase = countOfPasswordInDatabaseInteger;

            // Add a method call to the  ValidateCredentials() method.
            ValidateCredentials();
        }

        // Implement polymorphism by doing constructor method overloading (The previous constructor has 4 parameters while
        // the next one will have no parameters.  Since there are two constructor methods with the same name, but with different 
        // parameter lists, this would be an example of constructor method overloading.)
        //
        // Add a no-arg constructor.
        public Login()
        {
            Username = "";
            Password = "";
            LoginStatusMessage = "";
            CountOfUsernameInDatabase = 0;
            CountOfPasswordInDatabase = 0;
            SuccessfulLogin = false;
        }

        // Declare public properties
        public string Username
        {
            get
            {
                return mUsernameString;
            }
            set
            {
                mUsernameString = value;
            }
        }

        public string Password
        {
            get
            {
                return mPasswordString;
            }
            set
            {
                mPasswordString = value;
            }
        }

        public string LoginStatusMessage
        {
            get
            {
                return mLoginStatusMessageString;
            }
            set
            {
                mLoginStatusMessageString = value;
            }
        }

        public int CountOfUsernameInDatabase
        {
            get
            {
                return mCountOfUsernameInDatabaseInteger;
            }
            set
            {
                mCountOfUsernameInDatabaseInteger = value;
            }
        }

        public int CountOfPasswordInDatabase
        {
            get
            {
                return mCountOfPasswordInDatabaseInteger;
            }
            set
            {
                mCountOfPasswordInDatabaseInteger = value;
            }
        }

        public bool SuccessfulLogin
        {
            get
            {
                return mSuccessfulLoginBoolean;
            }
            set
            {
                mSuccessfulLoginBoolean = value;
            }
        }

        public static int UnsuccessfulLoginAttempts
        {
            get
            {
                return unsuccessfulLoginAttemptsCounterInteger;
            }
            set
            {
                unsuccessfulLoginAttemptsCounterInteger = value;
            }
        }

        // Declare a method to increment the variable for counting login attempts.
        protected void IncrementUnsuccessfulLoginAttemptsCounter()
        {
            UnsuccessfulLoginAttempts++;
        }

        // Declare a method to validate the credentials
        // Implement polymorphism by doing regular method overriding.  A method named ValidateCredentials() in the
        // child class will override the following method by the same name in the parent class.
        protected virtual void ValidateCredentials()
        {
            if (UnsuccessfulLoginAttempts >= 3)
            {
                LoginStatusMessage = "Sorry, you exhausted all your attempts!  Please contact Customer Support!!!";
                IncrementUnsuccessfulLoginAttemptsCounter();

                SuccessfulLogin = false;
            }
            else
            {
                if (CountOfUsernameInDatabase == 0)
                {
                    LoginStatusMessage = "Sorry, the username/password you entered was not found in database!  Please try again!!!";
                    IncrementUnsuccessfulLoginAttemptsCounter();

                    SuccessfulLogin = false;
                }
                else
                {
                    if (CountOfPasswordInDatabase == 0)
                    {
                        LoginStatusMessage = "Sorry, the username/password you entered was not found in database!  Please try again!!!";
                        IncrementUnsuccessfulLoginAttemptsCounter();

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
