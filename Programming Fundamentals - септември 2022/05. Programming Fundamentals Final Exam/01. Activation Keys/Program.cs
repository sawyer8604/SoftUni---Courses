using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string instructions;

            while ((instructions = Console.ReadLine()) != "Generate")
            {
                string[] arguments = instructions.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = arguments[0];


                switch (firstCommand)
                {
                    case "Contains":
                        string substring = arguments[1];

                        if(input.Contains(substring))
                        {
                            Console.WriteLine($"{input} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }

                        break;

                    case "Flip":
                        string upperOrLower = arguments[1];

                        int startIndex = int.Parse(arguments[2]);
                        int endIndex = int.Parse(arguments[3]); 

                        if(upperOrLower == "Upper")
                        {
                            string crrSubStrig = "";

                            for (int i = startIndex; i < endIndex; i++)
                            {
                                crrSubStrig += input[i];
                                
                            }
                          
                            input = input.Replace(crrSubStrig, crrSubStrig.ToUpper());
                            Console.WriteLine(input);
                        }
                        else
                        {
                            string crrSubStrig = "";

                            for (int i = startIndex; i < endIndex; i++)
                            {
                                crrSubStrig += input[i];

                            }

                            input = input.Replace(crrSubStrig, crrSubStrig.ToLower());
                            Console.WriteLine(input);

                        }

                        break;

                    case "Slice":
                        int deleteStartIndex = int.Parse(arguments[1]);
                        int deleteEndIndex = int.Parse(arguments[2]);

                        string crrDeleteString = "";

                        for (int i = deleteStartIndex; i < deleteEndIndex; i++)
                        {
                            crrDeleteString += input[i];

                        }

                        input = input.Remove(deleteStartIndex, crrDeleteString.Length);
                        Console.WriteLine(input);

                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {input}");

        }
    }
}
