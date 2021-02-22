using System;
using System.Text.RegularExpressions;
using UserRegistrationclass;

namespace UserRegistration
{
   public class Userregistrationclass
    {
        //Pttern for  userregistration
        string firstName = "^[A-Z]{1}[a-z]{2,}$";
        string lastName = "^[A-Z]{1}[a-z]{2,}$";
        string emailID = "^[0-9a-zA-Z]+([._+-]?[0-9a-zA-Z]+)*@[0-9A-Za-z]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$";
        public string FirstName(string[] patternfirstname)
        {
            //Validate first name
            Regex regex = new Regex(firstName);
            var answer = regex.Match(patternfirstname[1]);
            try
            {
                if (!answer.Success)
                {
                    throw new UserregistrationcustomException(UserregistrationcustomException.ExceptionType.FIRST_NAME_MESSAGE, "First name is not valid");
                }
                return "FirstName is Valid";
            }
            catch
            {
                throw new UserregistrationcustomException(UserregistrationcustomException.ExceptionType.FIRST_NAME_MESSAGE, "First name is not valid");
            }


        }
        public string LastName(string[] patternlastName)
        {
            //Validate the last name
            Regex regex = new Regex(lastName);
            var answer = regex.Match(patternlastName[1]);
            try
            {
                if (!answer.Success)
                {
                    throw new UserregistrationcustomException(UserregistrationcustomException.ExceptionType.LAST_NAME_MESSAGE, "Last name is not valid");
                }
                return "Last name is valid";
            }
            catch
            {
                throw new UserregistrationcustomException(UserregistrationcustomException.ExceptionType.LAST_NAME_MESSAGE, "Last name is not valid");
            }
        }
        public string EmailId(string patternEmailID)
        {
            //Validate the email ID
            Regex regex = new Regex(emailID);
            var answer = regex.Match(patternEmailID);
            try
            {
                if (!answer.Success)
                {
                    throw new UserregistrationcustomException(UserregistrationcustomException.ExceptionType.EMAIL_ID_MESSAGE, "Email id is not valid");
                }
                return "Email Id is valid";
            }
            catch
            {
                throw new UserregistrationcustomException(UserregistrationcustomException.ExceptionType.EMAIL_ID_MESSAGE, "Email id is not valid");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome user registration");
        }
    }
}
