using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] cmdArguments = commands.Split(" -> ");

                string companyName = cmdArguments[0];
                string employeeId = cmdArguments[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if(companies[companyName].Contains(employeeId))
                {
                    continue;

                }
                companies[companyName].Add(employeeId); 
            }

            foreach (var company in companies)
            {
                string currCompany = company.Key;
                List<string> employees = company.Value;

                Console.WriteLine($"{currCompany}");

                foreach (var employee in employees)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
