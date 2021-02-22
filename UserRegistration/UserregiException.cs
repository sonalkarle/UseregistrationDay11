using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationclass
{
    public class UserregistrationcustomException : Exception
    {
        ExceptionType type;

        public enum ExceptionType
        {
            FIRST_NAME_MESSAGE,
            LAST_NAME_MESSAGE,
            EMAIL_ID_MESSAGE,

        }
        public UserregistrationcustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }

}
