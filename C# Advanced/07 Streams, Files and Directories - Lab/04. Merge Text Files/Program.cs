using System;
using System.Collections.Generic;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var lines = new List<string>();

            using (StreamReader firstInput = new StreamReader(firstInputFilePath))
            {
                using (StreamReader secondInput = new StreamReader(secondInputFilePath))
                {
                    string firstRow = firstInput.ReadLine();
                    string secondRow = secondInput.ReadLine();

                    while (firstRow != null || secondRow != null)
                    {
                        lines.Add(firstRow);

                        if (secondRow != null)
                        {
                            lines.Add(secondRow);
                        }

                        firstRow = firstInput.ReadLine();
                        secondRow = secondInput.ReadLine();
                    }
                }
            }

            using (StreamWriter output = new StreamWriter(outputFilePath))
            {
                foreach (var line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }
    }
}
