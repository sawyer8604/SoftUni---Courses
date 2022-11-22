﻿using System;
using System.Numerics;

namespace _02._Convert_from_base_N_to_base_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            int baseNNum = int.Parse(input[0]);
            char[] baseTenNum = input[1].ToCharArray();

            BigInteger result = new BigInteger(0);

            for (int i = 0; i < baseTenNum.Length; i++)
            {
                int currentNum = (int)Char.GetNumericValue(baseTenNum[i]);
                result += currentNum * BigInteger.Pow(baseNNum, baseTenNum.Length - i - 1);
            }

            Console.WriteLine(result);
        }
    }
}
