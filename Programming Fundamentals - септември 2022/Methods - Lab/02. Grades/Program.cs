using System;
using System.Text;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grades = double.Parse(Console.ReadLine());

            gradeBetweenTwoAndSix(grades);
        }

        private static void gradeBetweenTwoAndSix(double grades)
        {
            string result = String.Empty;

            if (grades >= 2 && grades < 3)
            {
                result = "Fail";
            }
            else if (grades < 3.5)
            {
                result = "Poor";
            }
            else if (grades < 4.50)
            {
                result = "Good";
            }
            else if (grades < 5.50)
            {
                result = "Very good";
            }
            else if (grades <= 6)
            {
                result = "Excellent";
            }

            Console.WriteLine(result);
        }
    }
}
