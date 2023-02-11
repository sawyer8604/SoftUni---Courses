namespace _3.Telephony.Models
{
    using _3.Telephony.Exceptions;
    using _3.Telephony.Models.Interfaces;
    using System.Linq;

    public class Smartphone : ISmartphone, IStationaryPhone
    {
        public string Browsing(string url)
        {
            if (IsDigit(url))
            {
                throw new InvalidePhoneNumberException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        public string Calling(string number)
        {
            if (!IsLetter(number))
            {
                throw new InvalidePhoneNumberException();
            }

            return $"Dialing...{number}";
        }

        private bool IsLetter(string number)
        {
            return number.All(x => char.IsDigit(x));
        }
        private bool IsDigit(string number)
        {
            return number.Any(x => char.IsDigit(x));
        }
    }
}
