using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            string[] fileInfo = filePath
                .Split('\\')
                .Last()
                .Split('.')
                .ToArray();

            string filename = fileInfo[0];
            string fileExtension = fileInfo[1];

            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}
