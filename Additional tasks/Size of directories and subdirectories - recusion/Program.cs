using System;
using System.IO;

namespace Size_Of_Directories_And_SubDirectories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\must8\source\repos\Arrays and Methods - More Exercises";
            var totalLength = GetTotalLength(directoryPath);
            Console.WriteLine(totalLength);

        }

        static long GetTotalLength(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);
            long totalLength = 0;

            foreach (var file in files)
            {
                totalLength += new FileInfo(file).Length;

            }

            var subDirectories = Directory.GetDirectories(directoryPath);


            foreach (var directories in subDirectories)
            {
                totalLength += GetTotalLength(directories);
            }


            return totalLength;

        }
    }
}
