using System;

namespace _03._Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TypOfAnimal = Console.ReadLine();

            switch (TypOfAnimal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
