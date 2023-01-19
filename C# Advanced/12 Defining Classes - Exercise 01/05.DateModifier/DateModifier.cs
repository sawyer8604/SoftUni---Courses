using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public class DateModifier
    {

        public int GetDifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime daetOne = DateTime.Parse(firstDate);
            DateTime dateTWo= DateTime.Parse(secondDate);

            int result = 0;

            return result = Math.Abs((daetOne - dateTWo).Days);

        }
    }
}
