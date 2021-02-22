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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome user registration");
        }
    }
}
