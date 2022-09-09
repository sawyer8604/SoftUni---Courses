using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                string temp = arr[0];
                for (int operatoin = 0; operatoin < arr.Length-1; operatoin++)
                {
                    arr[operatoin] = arr[operatoin + 1];
                }
                arr[arr.Length - 1] = temp;

            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
