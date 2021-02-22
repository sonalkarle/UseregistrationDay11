using System;
using System.Text.RegularExpressions;
using UserRegistrationclass;

namespace UserRegistration
{
   public class Userregistrationclass
    {
        string firstName = "^[A-Z]{1}[a-z]{2,}$";
    public string FirstName(string[] patternfirstname)
        {
            Regex regex = new Regex(firstName);
            var answer = regex.Match(patternfirstname[1]);
            try
            {
                if (!answer.Success)
                {
                    throw new UserregistrationcustomException(UserregistrationcustomException.ExceptionType.FIRST_NAME_MESSAGE, "First name is invalid");
                }
                return "FirstName is Valid";
            }
            catch
            {
                throw new UserregistrationcustomException(UserregistrationcustomException.ExceptionType.FIRST_NAME_MESSAGE, "First name is not valid");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome user registration");
        }
    }
}
