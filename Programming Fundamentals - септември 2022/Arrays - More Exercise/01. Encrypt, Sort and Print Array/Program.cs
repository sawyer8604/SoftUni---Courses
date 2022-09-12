using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            string[] arr = new string[number];

            int[] currentArray = new int[number];

            int sum = 0;
           

            for (int i = 0; i < number; i++)
            {
                
                arr[i] = Console.ReadLine();

                string currentName = arr[i];

                sum = 0;

                for (int j = 0; j < currentName.Length; j++)
                {
                    
                    char digit = currentName[j];
                    int value = (int)digit;

                    if (digit == 'a' || digit == 'i' || digit == 'o' || digit == 'u' || digit == 'e'
                        || digit == 'A' || digit == 'I' || digit == 'O' || digit == 'U' || digit == 'E')
                    {
                        sum += value * currentName.Length;

                    }
                    else
                    {
                        sum += value / currentName.Length;
                    }
                    

                }
                currentArray[i] = sum;
                


            }
            Array.Sort(currentArray);
            for (int i = 0; i < currentArray.Length; i++)
            {
                Console.WriteLine(currentArray[i]);
            }

        }
    }
}
