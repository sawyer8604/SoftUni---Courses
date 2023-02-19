using System;
using System.Xml.Linq;

namespace _04._Sum_of_Integers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            string[] input = Console.ReadLine().Split(" ");

            int result = sum.CalculateSum(input);
            Console.WriteLine($"The total sum of all integers is: {result}");
        }
    }

    public class Sum
    {
        public int CalculateSum(string[] input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string elementAsString = input[i];
                try
                {
                    long elementLong = long.Parse(elementAsString);

                    if(elementLong < int.MinValue || elementLong > int.MaxValue)
                    {
                        throw new OverflowException($"The element '{elementAsString}' is out of range!");
                    }

                    int element = int.Parse(elementAsString);

                    sum += element;

                }
                catch (FormatException)
                {

                    Console.WriteLine($"The element '{elementAsString}' is in wrong format!");
                } 
                catch (OverflowException oe)
                {
                    Console.WriteLine(oe.Message);
                }
                finally
                {
                    Console.WriteLine($"Element '{elementAsString}' processed - current sum: {sum}");
                }

            }

            return sum;
        }
    }
}
