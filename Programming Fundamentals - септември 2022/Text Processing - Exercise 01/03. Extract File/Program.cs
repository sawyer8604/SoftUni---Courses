using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string[] result = input[^1].Split(".").ToArray();

            string fileName = result[0];
            string fileExtention = result[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtention}");

        }
    }
}
