
using System;

namespace _3.Telephony.Exceptions
{
    public class InvalidePhoneNumberException : Exception
    {
        private const string DefaultExeptionMessage = "Invalid number!";

        public InvalidePhoneNumberException()
            :base(DefaultExeptionMessage)
        {

        }

        public InvalidePhoneNumberException(string message)
            : base(message)
        {

        }
    }
}
