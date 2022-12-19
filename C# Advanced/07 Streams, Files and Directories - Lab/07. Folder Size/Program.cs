using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            string[] files = Directory.GetFiles(folderPath);
            double sum = 0;

            foreach (var filePath in files)
            {
                FileInfo file = new FileInfo(filePath);
                sum += file.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText(outputFilePath, sum.ToString());
        }
    }
}
