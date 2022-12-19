﻿using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                int lineNumber = 1;

                while (!reader.EndOfStream)
                {
                    Console.WriteLine($"{lineNumber++}. {reader.ReadLine()}");
                }
            }
        }
    }
}
