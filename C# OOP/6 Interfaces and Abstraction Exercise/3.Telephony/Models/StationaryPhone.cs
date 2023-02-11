namespace _3.Telephony.Models
{
    using System.Linq;
    using Exceptions;
    using Interfaces;
    

    public class StationaryPhone : IStationaryPhone
    {
        public string Calling(string number)
        {
            if(!IsValid(number))
            {
                throw new InvalidePhoneNumberException();
            }

            return $"Calling...{number}";            
        }

        private bool IsValid(string number)
        {
            return number.All(x => char.IsDigit(x));
        }
    }
}
