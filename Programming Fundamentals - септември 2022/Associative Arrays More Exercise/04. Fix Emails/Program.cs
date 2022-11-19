using System;
using System.Collections.Generic;

namespace _04._Fix_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            string name;

            while ((name = Console.ReadLine()) != "stop")
            {
                string email = Console.ReadLine();

                string[] valiedMail = email.Split(".");
                if (valiedMail[1] == "us" || valiedMail[1] == "uk")
                {
                    continue;
                }

                if (!emails.ContainsKey(name))
                {
                    emails[name] = email;
                }

            }

            foreach (var (names, mail) in emails)
            {
                Console.WriteLine($"{names} -> {mail}");
            }
        }
    }
}
